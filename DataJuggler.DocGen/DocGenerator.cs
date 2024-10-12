

#region using statements

using DataJuggler.UltimateHelper;
using Microsoft.Build.Locator;
using Microsoft.CodeAnalysis;
using Microsoft.CodeAnalysis.CSharp.Syntax;
using Microsoft.CodeAnalysis.FindSymbols;
using Microsoft.CodeAnalysis.MSBuild;
using ObjectLibrary.BusinessObjects;
using ObjectLibrary.Enumerations;
using CodeConstructor = ObjectLibrary.BusinessObjects.CodeConstructor;
using MSProject = Microsoft.Build.Evaluation.Project;
using Project = Microsoft.CodeAnalysis.Project;

#endregion

namespace DataJuggler.DocGen
{

    #region class DocGenerator
    /// <summary>
    /// This class is designed to make it simple to analyze a Solution
    /// </summary>
    public class DocGenerator
    {
        
        #region Private Variables

        #endregion
        
        #region Events
            
        #endregion
        
        #region Methods

            #region AnalyzeSolution(string path)
            /// <summary>
            /// returns the Solution
            /// </summary>
            public async static Task<VSSolution> AnalyzeSolution(string path)
            {
                // initial value
                VSSolution vsSolution = new VSSolution();

                try
                {
                    // Load the Solution
                    VSSolution tempVSSolution = await CreateSolution(path);

                    // Set the return value
                    vsSolution = tempVSSolution;
                }
                catch (Exception error)
                {
                    // Add this exception
                    vsSolution.Errors.Add(error);
                }
                
                // return value
                return vsSolution;
            }
            #endregion
            
            #region CreateClasses(SyntaxNode root, SemanticModel semanticModel, Solution solution)
            /// <summary>
            /// returns a list of Classes
            /// </summary>
            public async static Task<List<CodeClass>> CreateClasses(SyntaxNode root, SemanticModel semanticModel, Solution solution)
            {
                // initial value
                List<CodeClass> codeClasses = new List<CodeClass>();

                // Assuming 'root' is the root of your syntax tree
                var classes = root.DescendantNodes().OfType<ClassDeclarationSyntax>().ToList();

                // If the classes collection exists and has one or more items
                if (ListHelper.HasOneOrMoreItems(classes))
                {
                    // Iterate the collection of var objects
                    foreach (var classDeclaration in classes)
                    {
                        // Create a new instance of a 'CodeClass' object.
                        CodeClass codeClass = new CodeClass();

                        // Set the Name
                        codeClass.Name = classDeclaration.Identifier.Text;
                        
                        // Get the summary XML documentation
                        var trivia = classDeclaration.GetLeadingTrivia();
                        var docCommentTrivia = trivia.Select(tr => tr.GetStructure()).OfType<DocumentationCommentTriviaSyntax>().FirstOrDefault();
        
                        // Get the Description
                        codeClass.Description = GetSummaryText(docCommentTrivia);

                        // Create the Constructors
                        codeClass.Constructors = await CreateConstructors(classDeclaration, semanticModel, solution);
                        
                        // Create the Properties
                        codeClass.Properties = await CreateProperties(classDeclaration, semanticModel, solution);

                        // Create the Methods
                        codeClass.Methods = await CreateMethods(classDeclaration, semanticModel, solution);

                        // Create the Events
                        codeClass.Events = await CreateEvents(classDeclaration, semanticModel, solution);

                        // Get the references for this class
                        List<ReferencedBy> references = await CreateReferences(classDeclaration, semanticModel, solution);

                        // Set the References
                        codeClass.References = references;
                        codeClass.SetupReferences();


                        // Add this item
                        codeClasses.Add(codeClass);
                    }
                }      
                
                // return value
                return codeClasses;
            }
            #endregion
            
            #region CreateCodeFiles(Project project, Solution solution)
            /// <summary>
            /// returns a list of Code Files
            /// </summary>
            public async static Task<List<CodeFile>> CreateCodeFiles(Project project, Solution solution)
            {
                // initial value
                List<CodeFile> codeFiles = new List<CodeFile>();

                // Get the ecompilation
                var compilation = await project.GetCompilationAsync();

                // iterate the documents
                foreach (var document in project.Documents)
                {
                    // Only dealing with C# files
                    if (document.FilePath.EndsWith(".cs"))
                    {
                        // Create a CodeFile
                        CodeFile codeFile = new CodeFile();

                        // Get the path
                        codeFile.FullPath = document.FilePath;
                        codeFile.Name = document.Name;

                        var syntaxTree = await document.GetSyntaxTreeAsync();
                        var root = await syntaxTree.GetRootAsync();

                        // Get the semanticModel
                        var semanticModel = compilation.GetSemanticModel(root.SyntaxTree);

                        // Get the Classes for this CodeFile
                        codeFile.Classes = await CreateClasses(root, semanticModel, solution);
                        
                        // Add this codeFile
                        codeFiles.Add(codeFile);
                    }
                }
                
                // return value
                return codeFiles;
            }
            #endregion
            
            #region CreateConstructors(CreateConstructors classDeclaration, SemanticModel semanticModel, Solution solution)
            /// <summary>
            /// returns a list of Methods
            /// </summary>
            public async static Task<List<CodeConstructor>> CreateConstructors(ClassDeclarationSyntax classDeclaration, SemanticModel semanticModel, Solution solution)
            {
                // initial value
                List<CodeConstructor> codeConstructors = new List<CodeConstructor>();

                // Retrieve constructors
                List<ConstructorDeclarationSyntax> constructors = classDeclaration.Members.OfType<ConstructorDeclarationSyntax>().ToList();

                // If the constructors collection exists and has one or more items
                if (ListHelper.HasOneOrMoreItems(constructors))
                {
                    // Iterate the collection of var objects
                    foreach (var constructor in constructors)
                    {
                        // Attributes of the method
                        var location = constructor.GetLocation();
                        var lineSpan = location.GetLineSpan();
                        int lineNumber = lineSpan.StartLinePosition.Line + 1;
                        int endLineNumber = lineSpan.EndLinePosition.Line + 1;

                        // Get the summary XML documentation
                        var trivia = constructor.GetLeadingTrivia();
                        var docCommentTrivia = trivia
                            .Select(tr => tr.GetStructure())
                            .OfType<DocumentationCommentTriviaSyntax>()
                            .FirstOrDefault();

                        // Get the Summary Text
                        string summaryText = GetSummaryText(docCommentTrivia);

                        // Get the parameters for this method
                        List<CodeParameter> codeParameters = CreateParameters(constructor, semanticModel);

                        // Get the ReferencedBy for this method
                        List<ReferencedBy> references = await CreateReferences(constructor, semanticModel, solution);
                        
                        // Create a new instance of a 'CodeMethod' object.
                        CodeConstructor codeConstructor = new CodeConstructor();
                        codeConstructor.Name = constructor.Identifier.Text;
                        codeConstructor.StartLineNumber = lineNumber;
                        codeConstructor.EndLineNumber = endLineNumber;
                        codeConstructor.Description = summaryText;
                        codeConstructor.Parameters = codeParameters;
                        
                        // Set teh References
                        codeConstructor.References = references;
                        
                        // Set the Source object to this method
                        codeConstructor.SetupReferences();

                        // Add this codeMethod
                        codeConstructors.Add(codeConstructor);
                    }
                }
                
                // return value
                return codeConstructors;
            }
            #endregion

            #region CreateEvents(ClassDeclarationSyntax classDeclaration, SemanticModel semanticModel, Solution solution)
            /// <summary>
            /// returns a list of Events
            /// </summary>
            public async static Task<List<CodeEvent>> CreateEvents(ClassDeclarationSyntax classDeclaration, SemanticModel semanticModel, Solution solution)
            {
                // initial value
                List<CodeEvent> codeEvents = new List<CodeEvent>();

                // Retrieve events
                List<EventDeclarationSyntax> events = classDeclaration.Members.OfType<EventDeclarationSyntax>().ToList();

                // If the events collection exists and has one or more items
                if (ListHelper.HasOneOrMoreItems(events))
                {
                    foreach (var eventDeclaration in events)
                    {
                        // Attributes of the event
                        var location = eventDeclaration.GetLocation();
                        var lineSpan = location.GetLineSpan();
                        int lineNumber = lineSpan.StartLinePosition.Line + 1;
                        int endLineNumber = lineSpan.EndLinePosition.Line + 1;

                        // Get the summary XML documentation
                        var trivia = eventDeclaration.GetLeadingTrivia();
                        var docCommentTrivia = trivia
                            .Select(tr => tr.GetStructure())
                            .OfType<DocumentationCommentTriviaSyntax>()
                            .FirstOrDefault();

                        // Get the Summary Text
                        string summaryText = GetSummaryText(docCommentTrivia);

                        // Get the parameters for this event
                        List<CodeParameter> codeParameters = CreateParameters(eventDeclaration, semanticModel);

                        // Create the References
                        List<ReferencedBy> references = await CreateReferences(eventDeclaration, semanticModel, solution); 

                        // Create a new instance of a 'CodeEvent' object.
                        CodeEvent codeEvent = new CodeEvent();
                        codeEvent.Name = eventDeclaration.Identifier.Text;
                        codeEvent.StartLineNumber = lineNumber;
                        codeEvent.EndLineNumber = endLineNumber;
                        codeEvent.Description = summaryText;

                        // Store the Parameters and References
                        codeEvent.Parameters = codeParameters;
                        codeEvent.References = references;
                        codeEvent.SetupReferences();

                        // Add this codeEvent
                        codeEvents.Add(codeEvent);
                    }
                }

                // return value
                return codeEvents;
            }
            #endregion
            
            #region CreateMethods(ClassDeclarationSyntax classDeclaration, SemanticModel semanticModel, Solution solution)
            /// <summary>
            /// returns a list of Methods
            /// </summary>
            public async static Task<List<CodeMethod>> CreateMethods(ClassDeclarationSyntax classDeclaration, SemanticModel semanticModel, Solution solution)
            {
                // initial value
                List<CodeMethod> codeMethods = new List<CodeMethod>();

                // Retrieve methods
                List<MethodDeclarationSyntax> methods = classDeclaration.Members.OfType<MethodDeclarationSyntax>().ToList();

                // If the methods collection exists and has one or more items
                if (ListHelper.HasOneOrMoreItems(methods))
                {
                    foreach (var method in methods)
                    {
                        // Attributes of the method
                        var location = method.GetLocation();
                        var lineSpan = location.GetLineSpan();
                        int lineNumber = lineSpan.StartLinePosition.Line + 1;
                        int endLineNumber = lineSpan.EndLinePosition.Line + 1;

                        // Get the summary XML documentation
                        var trivia = method.GetLeadingTrivia();
                        var docCommentTrivia = trivia
                            .Select(tr => tr.GetStructure())
                            .OfType<DocumentationCommentTriviaSyntax>()
                            .FirstOrDefault();

                        // Get the Summary Text
                        string summaryText = GetSummaryText(docCommentTrivia);

                        // Get the parameters for this method
                        List<CodeParameter> codeParameters = CreateParameters(method, docCommentTrivia);

                        // Get the ReferencedBy for this method
                        List<ReferencedBy> references = await CreateReferences(method, semanticModel, solution);
                        
                        // Create a new instance of a 'CodeMethod' object.
                        CodeMethod codeMethod = new CodeMethod();
                        codeMethod.Name = method.Identifier.Text;
                        codeMethod.StartLineNumber = lineNumber;
                        codeMethod.EndLineNumber = endLineNumber;
                        codeMethod.ReturnType = method.ReturnType.ToString();
                        codeMethod.Description = summaryText;
                        codeMethod.Parameters = codeParameters;
                        
                        // Set teh References
                        codeMethod.References = references;
                        
                        // Set the Source object to this method
                        codeMethod.SetupReferences();

                        // Add this codeMethod
                        codeMethods.Add(codeMethod);
                    }
                }
                
                // return value
                return codeMethods;
            }
            #endregion
            
            #region CreateParameters(ConstructorDeclarationSyntax constructorDeclaration, SemanticModel semanticModel)
            /// <summary>
            /// returns a list of Parameters
            /// </summary>
            /// <param name="constructor"></param>
            /// <param name="semanticModel">The Semantic Model </param>
            public static List<CodeParameter> CreateParameters(ConstructorDeclarationSyntax constructor, SemanticModel semanticModel)
            {
                var codeParameters = new List<CodeParameter>();

                // Get the summary XML documentation
                var trivia = constructor.GetLeadingTrivia();
                var docCommentTrivia = trivia
                    .Where(tr => tr.HasStructure)
                    .Select(tr => tr.GetStructure())
                    .OfType<DocumentationCommentTriviaSyntax>()
                    .FirstOrDefault();

                // Extract param descriptions
                var paramElements = docCommentTrivia?.Content
                    .OfType<XmlElementSyntax>()
                    .Where(e => e.StartTag.Name.LocalName.Text == "param")
                    .ToList();

                foreach (var parameter in constructor.ParameterList.Parameters)
                {
                    var paramName = parameter.Identifier.Text;
                    var paramType = parameter.Type.ToString();
                    var isOptional = parameter.Default != null;

                    // Find the corresponding paramElement
                    var paramElement = paramElements?.FirstOrDefault(e => e.StartTag.Attributes
                        .OfType<XmlNameAttributeSyntax>()
                        .FirstOrDefault()?
                        .Identifier.Identifier.Text == paramName);

                    var description = paramElement?.Content.ToString() ?? string.Empty;

                    var codeParameter = new CodeParameter
                    {
                        Name = paramName,
                        ParameterType = paramType,
                        IsOptional = isOptional,
                        Description = description
                    };

                    codeParameters.Add(codeParameter);
                }

                // return value
                return codeParameters;
            }
            #endregion

            #region CreateParameters(EventDeclarationSyntax eventDeclaration, SemanticModel semanticModel)
            /// <summary>
            /// returns a list of Parameters
            /// </summary>
            public static List<CodeParameter> CreateParameters(EventDeclarationSyntax eventDeclaration, SemanticModel semanticModel)
            {
                var codeParameters = new List<CodeParameter>();

                // Get the delegate type of the event
                var delegateType = semanticModel.GetTypeInfo(eventDeclaration.Type).Type as INamedTypeSymbol;
                if (delegateType != null)
                {
                    var delegateInvokeMethod = delegateType.DelegateInvokeMethod;

                    if (delegateInvokeMethod != null)
                    {
                        // Get the XML documentation for the delegate
                        var delegateSyntaxRef = delegateType.DeclaringSyntaxReferences.FirstOrDefault();
                        if (delegateSyntaxRef != null)
                        {
                            var delegateSyntax = delegateSyntaxRef.GetSyntax() as DelegateDeclarationSyntax;
                            var trivia = delegateSyntax.GetLeadingTrivia();
                            var docCommentTrivia = trivia
                                .Where(tr => tr.HasStructure)
                                .Select(tr => tr.GetStructure())
                                .OfType<DocumentationCommentTriviaSyntax>()
                                .FirstOrDefault();

                            // Extract param descriptions
                            var paramElements = docCommentTrivia?.Content
                                .OfType<XmlElementSyntax>()
                                .Where(e => e.StartTag.Name.LocalName.Text == "param")
                                .ToList();

                            foreach (var parameter in delegateInvokeMethod.Parameters)
                            {
                                var paramName = parameter.Name;
                                var paramType = parameter.Type.ToString();
                                var isOptional = parameter.HasExplicitDefaultValue;

                                // Find the corresponding paramElement
                                var paramElement = paramElements?.FirstOrDefault(e => e.StartTag.Attributes
                                    .OfType<XmlNameAttributeSyntax>()
                                    .FirstOrDefault()?
                                    .Identifier.Identifier.Text == paramName);

                                var description = paramElement?.Content.ToString() ?? string.Empty;

                                var codeParameter = new CodeParameter
                                {
                                    Name = paramName,
                                    ParameterType = paramType,
                                    IsOptional = isOptional,
                                    Description = description
                                };

                                // Add this codeParameter
                                codeParameters.Add(codeParameter);
                            }
                        }
                    }
                }

                // return value
                return codeParameters;
            }
            #endregion

            #region CreateParameters(MethodDeclarationSyntax method, DocumentationCommentTriviaSyntax docCommentTriviia)
            /// <summary>
            /// returns a list of Parameters
            /// </summary>
            public static List<CodeParameter> CreateParameters(MethodDeclarationSyntax method, DocumentationCommentTriviaSyntax docCommentTrivia)
            {
                // initial value
                List<CodeParameter> createParameters = new List<CodeParameter>();

                // Get the paramElements
                List<XmlElementSyntax> paramElements = null;
                
                // If the docCommentTrivia object exists
                if (NullHelper.Exists(docCommentTrivia))
                {
                    // Get the paramElements
                    paramElements = docCommentTrivia.Content.OfType<XmlElementSyntax>().Where(e => e.StartTag.Name.LocalName.Text == "param").ToList();
                }

                // get the parameters
                var parameters = method.ParameterList.Parameters;

                // if there are one or more parameters
                if (parameters.Count > 0)
                {
                    // Iterate the collection of var objects
                    foreach (var parameter in parameters)
                    {
                        var paramName = parameter.Identifier.Text;
                        var paramType = parameter.Type.ToString();
                        var isOptional = parameter.Default != null;

                        // Create a new instance of a 'CodeParameter' object.
                        CodeParameter codeParameter = new CodeParameter();
                    
                        // Set the Name
                        codeParameter.Name = paramName;
                        codeParameter.ParameterType = paramType;
                        codeParameter.IsOptional = isOptional;

                        // Get to the Description
                        codeParameter.Description = GetParameterDescription(paramElements, paramName);

                        

                        // Add this item
                        createParameters.Add(codeParameter);
                    }
                }
                
                // return value
                return createParameters;
            }
            #endregion
            
            #region CreateProjects()
            /// <summary>
            /// returns a list of Projects
            /// </summary>
            public async static Task<List<VSProject>> CreateProjects(List<Project> projects, Solution solution)
            {
                // initial value
                List<VSProject> vsProjects = new List<VSProject>();

                // Load the Projects
                if (ListHelper.HasOneOrMoreItems(projects))
                {
                    // iterate the projects
                    foreach (Project project in projects)
                    {
                        // Create a new instance of a 'VSProject' object.
                        VSProject vsProject = new VSProject();
                        vsProject.Name = project.Name;
                        vsProject.FullPath = project.FilePath;

                        // Get the Description
                        var msBuildProject = new MSProject(vsProject.FullPath);
                        vsProject.Description = msBuildProject.GetPropertyValue("Description");

                        // Create the CodeFiles
                        vsProject.CodeFiles = await CreateCodeFiles(project, solution);

                        // Add this project
                        vsProjects.Add(vsProject);
                    }
                }
                
                // return value
                return vsProjects;
            }
            #endregion
            
            #region CreateProperties(ClassDeclarationSyntax classDeclaration, SemanticModel semantic, Solution solution)
            /// <summary>
            /// returns a list of Properties
            /// </summary>
            public async static Task<List<CodeProperty>> CreateProperties(ClassDeclarationSyntax classDeclaration, SemanticModel semanticModel, Solution solution)
            {
                // initial value
                List<CodeProperty> codeProperties = new List<CodeProperty>();

                // Retrieve properties
                // List<PropertyDeclarationSyntax> properties = root.DescendantNodes().OfType<PropertyDeclarationSyntax>().ToList();
                List<PropertyDeclarationSyntax> properties = classDeclaration.Members.OfType<PropertyDeclarationSyntax>().ToList();

                // If the properties collection exists and has one or more items
                if (ListHelper.HasOneOrMoreItems(properties))
                {
                    // Iterate the properties
                    foreach (var property in properties)
                    {
                        string name = property.Identifier.Text;
                        string propertyType = property.Type.ToString();

                        // Create a new instance of a 'CodeProperty' object.
                        CodeProperty codeProperty = new CodeProperty();

                        // Set the attributes
                        codeProperty.Name = name;
                        codeProperty.ReturnType = propertyType;
                        
                         // Attributes of the method
                        var location = property.GetLocation();
                        var lineSpan = location.GetLineSpan();
                        int lineNumber = lineSpan.StartLinePosition.Line + 1;
                        int endLineNumber = lineSpan.EndLinePosition.Line + 1;

                        // Set the Start and End line numbers
                        codeProperty.StartLineNumber = lineNumber;
                        codeProperty.EndLineNumber = endLineNumber;

                        // Get the DocCommentTrivia
                        var trivia = property.GetLeadingTrivia();
                        var docCommentTrivia = trivia
                            .Select(tr => tr.GetStructure())
                            .OfType<DocumentationCommentTriviaSyntax>()
                            .FirstOrDefault();

                        // Store the Description
                        codeProperty.Description = GetSummaryText(docCommentTrivia);

                        // Create the References
                        List<ReferencedBy> references = await CreateReferences(property, semanticModel, solution);

                        // Store the References
                        codeProperty.References = references;
                        codeProperty.SetupReferences();

                        // Add this item
                        codeProperties.Add(codeProperty);
                    }
                }
                
                // return value
                return codeProperties;
            }
            #endregion

            #region CreateReferences(ClassDeclarationSyntax codeClass, SemanticModel semanticModel, Solution solution)
            /// <summary>
            /// returns a list of References
            /// </summary>
            public async static Task<List<ReferencedBy>> CreateReferences(ClassDeclarationSyntax codeClass, SemanticModel semanticModel, Solution solution)
            {
                // initial value
                List<ReferencedBy> referencesList = new List<ReferencedBy>();

                // If this is a method
                if (semanticModel.GetDeclaredSymbol(codeClass) is IMethodSymbol classSymbol)
                {
                    // Find all references to this method
                    var references = await SymbolFinder.FindReferencesAsync(classSymbol, solution);

                    // if the references exist
                    if (references != null)
                    {
                        // Iterate the collection of var objects
                        foreach (var reference in references)
                        {
                            // iterate the locations
                            foreach (var location2 in reference.Locations)
                            {
                                var locationSpan = location2.Location.GetLineSpan();
                                var lineNumber2 = locationSpan.StartLinePosition.Line + 1;
                                var document2 = location2.Document;
                                var documentPath = document2.FilePath;

                                ReferencedBy referencedBy = new ReferencedBy();
                                referencedBy.ProjectId = 0;
                                referencedBy.CodeFileId = 0;
                                referencedBy.SourceType = ReferenceTypeEnum.Event;
                                referencedBy.FilePath = documentPath;
                                referencedBy.LineNumber = lineNumber2;
                                
                                // Add this object
                                referencesList.Add(referencedBy);                                
                            }
                        }
                    }
                }

                // return value
                return referencesList;
            }
            #endregion

            #region CreateReferences(ConstructorDeclarationSyntax codeConstructor, SemanticModel semanticModel, Solution solution)
            /// <summary>
            /// returns a list of References
            /// </summary>
            public async static Task<List<ReferencedBy>> CreateReferences(ConstructorDeclarationSyntax codeConstructor, SemanticModel semanticModel, Solution solution)
            {
                // initial value
                List<ReferencedBy> referencesList = new List<ReferencedBy>();

                // If this is a method
                if (semanticModel.GetDeclaredSymbol(codeConstructor) is IMethodSymbol constructorSymbol)
                {
                    // Find all references to this method
                    var references = await SymbolFinder.FindReferencesAsync(constructorSymbol, solution);

                    // if the references exist
                    if (references != null)
                    {
                        // Iterate the collection of var objects
                        foreach (var reference in references)
                        {
                            // iterate the locations
                            foreach (var location2 in reference.Locations)
                            {
                                var locationSpan = location2.Location.GetLineSpan();
                                var lineNumber2 = locationSpan.StartLinePosition.Line + 1;
                                var document2 = location2.Document;
                                var documentPath = document2.FilePath;

                                ReferencedBy referencedBy = new ReferencedBy();
                                referencedBy.ProjectId = 0;
                                referencedBy.CodeFileId = 0;
                                referencedBy.SourceType = ReferenceTypeEnum.Event;
                                referencedBy.FilePath = documentPath;
                                referencedBy.LineNumber = lineNumber2;
                                
                                // Add this object
                                referencesList.Add(referencedBy);                                
                            }
                        }
                    }
                }

                // return value
                return referencesList;
            }
            #endregion

            #region CreateReferences(EventDeclarationSyntax codeEvent, SemanticModel semanticModel, Solution solution)
            /// <summary>
            /// returns a list of References
            /// </summary>
            public async static Task<List<ReferencedBy>> CreateReferences(EventDeclarationSyntax codeEvent, SemanticModel semanticModel, Solution solution)
            {
                // initial value
                List<ReferencedBy> referencesList = new List<ReferencedBy>();

                // If this is a method
                if (semanticModel.GetDeclaredSymbol(codeEvent) is IMethodSymbol eventSymbol)
                {
                    // Find all references to this method
                    var references = await SymbolFinder.FindReferencesAsync(eventSymbol, solution);

                    // if the references exist
                    if (references != null)
                    {
                        // Iterate the collection of var objects
                        foreach (var reference in references)
                        {
                            // iterate the locations
                            foreach (var location2 in reference.Locations)
                            {
                                var locationSpan = location2.Location.GetLineSpan();
                                var lineNumber2 = locationSpan.StartLinePosition.Line + 1;
                                var document2 = location2.Document;
                                var documentPath = document2.FilePath;

                                ReferencedBy referencedBy = new ReferencedBy();
                                referencedBy.ProjectId = 0;
                                referencedBy.CodeFileId = 0;
                                referencedBy.SourceType = ReferenceTypeEnum.Event;
                                referencedBy.FilePath = documentPath;
                                referencedBy.LineNumber = lineNumber2;
                                
                                // Add this object
                                referencesList.Add(referencedBy);                                
                            }
                        }
                    }
                }

                // return value
                return referencesList;
            }
            #endregion
            
            #region CreateReferences(MethodDeclarationSyntax method, SemanticModel semanticModel, Solution solution)
            /// <summary>
            /// returns a list of References
            /// </summary>
            public async static Task<List<ReferencedBy>> CreateReferences(MethodDeclarationSyntax method, SemanticModel semanticModel, Solution solution)
            {
                // initial value
                List<ReferencedBy> referencesList = new List<ReferencedBy>();

                // If this is a method
                if (semanticModel.GetDeclaredSymbol(method) is IMethodSymbol methodSymbol)
                {
                    // Find all references to this method
                    var references = await SymbolFinder.FindReferencesAsync(methodSymbol, solution);

                    // if the references exist
                    if (references != null)
                    {
                        // Iterate the collection of var objects
                        foreach (var reference in references)
                        {
                            // iterate the locations
                            foreach (var location2 in reference.Locations)
                            {
                                var locationSpan = location2.Location.GetLineSpan();
                                var lineNumber2 = locationSpan.StartLinePosition.Line + 1;
                                var document2 = location2.Document;
                                var documentPath = document2.FilePath;

                                // Create a new instance of a 'ReferencedBy' object.
                                ReferencedBy referencedBy = new ReferencedBy();

                                // Setup the Attributes
                                referencedBy.ProjectId = 0;                                
                                referencedBy.CodeFileId = 0;
                                referencedBy.SourceType = ReferenceTypeEnum.Method;
                                referencedBy.FilePath = documentPath;
                                referencedBy.LineNumber = lineNumber2;
                                
                                // Add this object
                                referencesList.Add(referencedBy);                                
                            }
                        }
                    }
                }

                // return value
                return referencesList;
            }
            #endregion

            #region CreateReferences(PropertyDeclarationSyntax codeProperty, SemanticModel semanticModel, Solution solution)
            /// <summary>
            /// returns a list of References
            /// </summary>
            public async static Task<List<ReferencedBy>> CreateReferences(PropertyDeclarationSyntax codeProperty, SemanticModel semanticModel, Solution solution)
            {
                // initial value
                List<ReferencedBy> referencesList = new List<ReferencedBy>();

                // If this is a method
                if (semanticModel.GetDeclaredSymbol(codeProperty) is IMethodSymbol propertySymbol)
                {
                    // Find all references to this method
                    var references = await SymbolFinder.FindReferencesAsync(propertySymbol, solution);

                    // if the references exist
                    if (references != null)
                    {
                        // Iterate the collection of var objects
                        foreach (var reference in references)
                        {
                            // iterate the locations
                            foreach (var location2 in reference.Locations)
                            {
                                var locationSpan = location2.Location.GetLineSpan();
                                var lineNumber2 = locationSpan.StartLinePosition.Line + 1;
                                var document2 = location2.Document;
                                var documentPath = document2.FilePath;

                                ReferencedBy referencedBy = new ReferencedBy();
                                referencedBy.ProjectId = 0;
                                referencedBy.CodeFileId = 0;
                                referencedBy.SourceType = ReferenceTypeEnum.Event;
                                referencedBy.FilePath = documentPath;
                                referencedBy.LineNumber = lineNumber2;
                                
                                // Add this object
                                referencesList.Add(referencedBy);                                
                            }
                        }
                    }
                }

                // return value
                return referencesList;
            }
            #endregion
            
            #region CreateSolution(string path)
            /// <summary>
            /// returns the Solution
            /// </summary>
            public async static Task<VSSolution> CreateSolution(string path)
            {
                // initial value
                VSSolution vsSolution = null;

                // If the path Exists On Disk
                if (FileHelper.Exists(path))
                {
                    // Create a new instance of a 'VSSolution' object.
                    vsSolution = new VSSolution();

                    // Create workspace
                    using var workspace = MSBuildWorkspace.Create();

                    // RegisterMSBuild - C# wasn't working due to Roslyn
                    // MSBuildLocator.RegisterMSBuildPath(@"C:\Program Files\Microsoft Visual Studio\2022\Community\MSBuild\Current\Bin");
                    MSBuildLocator.RegisterDefaults();

                    // This line appears to not do anything, but it is required to force Rosyln to support C#.
                    // Take this out and you get an error 'C# Is Not Supported'. 
                    var temp = typeof(Microsoft.CodeAnalysis.CSharp.Formatting.CSharpFormattingOptions);

                    // open the solution
                    var solution = await workspace.OpenSolutionAsync(path);
                    var projects = solution.Projects.ToList();

                    // Get the Path and Name
                    var solutionPath = solution.FilePath;
                    var solutionName = Path.GetFileNameWithoutExtension(solutionPath);

                    // Store
                    vsSolution.FullPath = solutionPath;
                    vsSolution.Name = solutionName;

                    // Create the Projects (and all child objects)
                    vsSolution.Projects = await CreateProjects(projects, solution);
                }
                
                // return value
                return vsSolution;
            }
            #endregion
            
            #region GetParameterDescription(paramElements, string paramName)
            /// <summary>
            /// returns the Parameter Description
            /// </summary>
            public static string GetParameterDescription(List<XmlElementSyntax> paramElements, string paramName)
            {
                // initial value
                string parameterDescription = "";

                // If the paramElements collection exists and has one or more items
                if (ListHelper.HasOneOrMoreItems(paramElements))
                {
                    // Find the matching paramElement
                    var matchingParamElement = paramElements.FirstOrDefault(pe => pe.StartTag.Attributes.OfType<XmlNameAttributeSyntax>().FirstOrDefault()?.Identifier.Identifier.Text == paramName);

                    // Get the Description
                    if (matchingParamElement != null)
                    {
                        // Set the return value
                        parameterDescription = matchingParamElement.Content.ToString();
                    }
                }
                
                // return value
                return parameterDescription;
            }
            #endregion
            
            #region GetSummaryText()
            /// <summary>
            /// returns the Summary Text
            /// </summary>
            public static string GetSummaryText(DocumentationCommentTriviaSyntax docCommentTrivia)
            {
                // initial value
                string summaryText = null;

                // If the docCommentTrivia object exists
                if (docCommentTrivia != null)
                {
                    // Get the Summary Element
                    var summaryElement = docCommentTrivia.Content.OfType<XmlElementSyntax>().FirstOrDefault(e => e.StartTag.Name.LocalName.Text == "summary");
            
                    // If the summaryElement object exists
                    if (summaryElement != null)
                    {
                        // set the value for summaryText                                                
                        summaryText = summaryElement.Content.ToString();
                    }
                }
                
                // return value
                return summaryText;
            }
            #endregion
            
        #endregion
        
    }
    #endregion

}
