

#region using statements

using DataJuggler.UltimateHelper;
using Microsoft.CodeAnalysis;
using Microsoft.CodeAnalysis.FindSymbols;
using Microsoft.CodeAnalysis.MSBuild;
using DataJuggler.DocGen.ObjectLibrary.BusinessObjects;
using DataJuggler.DocGen.ObjectLibrary.Enumerations;
using CodeConstructor = DataJuggler.DocGen.ObjectLibrary.BusinessObjects.CodeConstructor;
using Project = Microsoft.CodeAnalysis.Project;
using DataJuggler.DocGen.DataAccessComponent.Connection;
using DataJuggler.DocGen.DataAccessComponent.DataGateway;
using System.Xml.Linq;
using DataJuggler.UltimateHelper.Objects;
using Microsoft.CodeAnalysis.CSharp;
using Microsoft.CodeAnalysis.CSharp.Syntax;
using Microsoft.Build.Evaluation;
using Microsoft.Build.Tasks.Deployment.ManifestUtilities;
using System.CodeDom;
using DataJuggler.DocGen.Delegates;

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

            #region AnalyzeSolution(string path, UICallback uICallback)
            /// <summary>
            /// returns the Solution
            /// </summary>
            public async static Task<VSSolution> AnalyzeSolution(string path, UICallback uICallback)
            {
                // initial value
                VSSolution vsSolution = new VSSolution();

                try
                {
                    // Load the Solution
                    VSSolution tempVSSolution = await CreateSolution(path, uICallback);

                    // Set the return value
                    vsSolution = tempVSSolution;

                    // Link the PartialClasses
                    LinkPartialClasses(vsSolution);

                    // Get a distinct list of ReferencedBy objects
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
            
            #region CreateClasses(SyntaxNode root, SemanticModel semanticModel, Solution solution, CodeFile codeFile, bool distinctReferenecedByList)
            /// <summary>
            /// returns a list of Classes
            /// </summary>
            public async static Task<List<CodeClass>> CreateClasses(SyntaxNode root, SemanticModel semanticModel, Solution solution, CodeFile codeFile, bool distinctReferenecedByList)
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

                        // Store this Parent CodeFile and Id
                        codeClass.ParentCodeFile = codeFile;
                        codeClass.InternalParentId = codeFile.InternalId;
        
                        // Get the Description
                        codeClass.Description = DescriptionHelper.FormatDescription(GetSummaryText(docCommentTrivia));

                        // Create the Constructors
                        codeClass.Constructors = await CreateConstructors(classDeclaration, semanticModel, solution, distinctReferenecedByList);
                        
                        // Create the Properties
                        codeClass.Properties = await CreateProperties(classDeclaration, semanticModel, solution, distinctReferenecedByList);

                        // Create the Methods
                        codeClass.Methods = await CreateMethods(classDeclaration, semanticModel, solution, distinctReferenecedByList);

                        // is this a partial class
                        codeClass.IsPartial = IsPartialClass(classDeclaration);

                        // Get the references for this class
                        List<ReferencedBy> references = await CreateReferences(classDeclaration, semanticModel, solution, ReferenceTypeEnum.Class);

                        // Set the References
                        codeClass.References = references;

                        // if the list needs to be distinct
                        if (distinctReferenecedByList)
                        {
                            // Get a distinct list
                            codeClass.References = codeClass.References.GroupBy(rb => rb.FilePath).Select(g => g.First()).ToList();
                        }

                        // Setup the References
                        codeClass.SetupReferences();

                        // Add this item
                        codeClasses.Add(codeClass);
                    }
                }      
                
                // return value
                return codeClasses;
            }
            #endregion
            
            #region CreateCodeFiles(Project project, Solution solution, UICallback uICallback, bool distinctReferenecedByList)
            /// <summary>
            /// returns a list of Code Files
            /// </summary>
            public async static Task<List<CodeFile>> CreateCodeFiles(Project project, Solution solution, UICallback uICallback, bool distinctReferenecedByList)
            {
                // initial value
                List<CodeFile> codeFiles = new List<CodeFile>();

                // Get the compilation
                var compilation = await project.GetCompilationAsync();

                // Create a list
                List<Document> documents = project.Documents.ToList();

                // local used for the graph
                int currentDocumentNumber = 0;
                int totalDocumentsCount = 0;

                // if there are one or more documents
                if (ListHelper.HasOneOrMoreItems(documents))
                {
                    // Set the total
                    totalDocumentsCount = documents.Count;

                    // If the uICallback object exists
                    if (NullHelper.Exists(uICallback))
                    {
                        // Update the Progress
                        uICallback.BatchProgress(documents.Count, 1, "Updating document 1 of " + documents.Count + ".");
                    }
                }

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
                        codeFile.Classes = await CreateClasses(root, semanticModel, solution, codeFile, distinctReferenecedByList);
                        
                        // Add this codeFile
                        codeFiles.Add(codeFile);

                        // Increment the value for currentDocumentNumber
                        currentDocumentNumber++;

                        // If the uICallback object exists
                        if (NullHelper.Exists(uICallback))
                        {
                            // Notify the caller
                            string statusMessage = "Analyzing File " + (currentDocumentNumber) + " of " + totalDocumentsCount + ".";
                            uICallback.BatchProgress(totalDocumentsCount, currentDocumentNumber, statusMessage);
                        }
                    }
                }
                
                // return value
                return codeFiles;
            }
            #endregion
            
            #region CreateConstructors(CreateConstructors classDeclaration, SemanticModel semanticModel, Solution solution, bool distinctReferenecedByList)
            /// <summary>
            /// returns a list of Methods
            /// </summary>
            public async static Task<List<CodeConstructor>> CreateConstructors(ClassDeclarationSyntax classDeclaration, SemanticModel semanticModel, Solution solution, bool distinctReferenecedByList)
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
                        string summaryText = DescriptionHelper.FormatDescription(GetSummaryText(docCommentTrivia));

                        // Get the parameters for this method
                        List<CodeParameter> codeParameters = CreateParameters(constructor, semanticModel);

                        // Get the ReferencedBy for this method
                        List<ReferencedBy> references = await CreateReferences(constructor, semanticModel, solution, ReferenceTypeEnum.Constructor);

                        // if the list needs to be distinct
                        if (distinctReferenecedByList)
                        {
                            // Get a distinct list
                            references = references.GroupBy(rb => rb.FilePath).Select(g => g.First()).ToList();
                        }
                        
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

            #region CreateMethods(ClassDeclarationSyntax classDeclaration, SemanticModel semanticModel, Solution solution, bool distinctReferenecedByList)
            /// <summary>
            /// returns a list of Methods
            /// </summary>
            public async static Task<List<CodeMethod>> CreateMethods(ClassDeclarationSyntax classDeclaration, SemanticModel semanticModel, Solution solution, bool distinctReferenecedByList)
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
                        string summaryText = DescriptionHelper.FormatDescription(GetSummaryText(docCommentTrivia));

                        // Get the parameters for this method
                        List<CodeParameter> codeParameters = CreateParameters(method, docCommentTrivia);

                        // Get the ReferencedBy for this method
                        List<ReferencedBy> references = await CreateReferences(method, semanticModel, solution, ReferenceTypeEnum.Method);

                        // if the list needs to be distinct
                        if (distinctReferenecedByList)
                        {
                            // Get a distinct list
                            references = references.GroupBy(rb => rb.FilePath).Select(g => g.First()).ToList();
                        }
                        
                        // Create a new instance of a 'CodeMethod' object.
                        CodeMethod codeMethod = new CodeMethod();
                        codeMethod.Name = method.Identifier.Text;
                        codeMethod.IsEventHandler = codeMethod.Name.Contains("_"); // not foolproof
                        codeMethod.StartLineNumber = lineNumber;
                        codeMethod.EndLineNumber = endLineNumber;
                        codeMethod.ReturnType = method.ReturnType.ToString();
                        codeMethod.Description = summaryText;
                        codeMethod.Parameters = codeParameters;
                        
                        // Set teh References
                        codeMethod.References = references;

                        // if the list needs to be distinct
                        if (distinctReferenecedByList)
                        {
                            // Get a distinct list
                            codeMethod.References = codeMethod.References.GroupBy(rb => rb.FilePath).Select(g => g.First()).ToList();
                        }
                        
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
                        codeParameter.Description = DescriptionHelper.FormatDescription(GetParameterDescription(paramElements, paramName));

                        // Add this item
                        createParameters.Add(codeParameter);
                    }
                }
                
                // return value
                return createParameters;
            }
            #endregion
            
            #region CreateProjects(List<Project> projects, Solution solution, UICallback uICallback, bool distinctReferenecedByList)
            /// <summary>
            /// returns a list of Projects
            /// </summary>
            public async static Task<List<VSProject>> CreateProjects(List<Project> projects, Solution solution, UICallback uICallback, bool distinctReferenecedByList)
            {
                // initial value
                List<VSProject> vsProjects = new List<VSProject>();

                // Load the Projects
                if (ListHelper.HasOneOrMoreItems(projects))
                {
                    // local for the graph
                    int projectsCount = 0;
                    string totalProjects = projects.Count.ToString();

                    // iterate the projects
                    foreach (Project project in projects)
                    {
                        // If the uICallback object exists
                        if (NullHelper.Exists(uICallback))
                        {
                            // Increment the value for projectsCount
                            projectsCount++;

                            // Notify the caller
                            string statusMessage = "Analyzing Project " + projectsCount + " of " + totalProjects + ".";
                            uICallback.OverallProgress(projects.Count, projectsCount, statusMessage);
                        }

                        // Create a new instance of a 'VSProject' object.
                        VSProject vsProject = new VSProject();
                        vsProject.Name = project.Name;
                        vsProject.FullPath = project.FilePath;
                        
                        // Values needed from the ProjectFile
                        string targetFramework;
                        string description = "";

                        vsProject.ProjectType = GetProjectType(vsProject.FullPath, out description, out targetFramework);
                        vsProject.Description = description;
                        vsProject.TargetFramework = targetFramework;
                        char[] delimiter = new char[] { '-' };

                        // Get the words
                        List<Word> words = TextHelper.GetWords(targetFramework, delimiter);
                        vsProject.TargetFramework = words[0].Text;
                        
                        // Create the CodeFiles
                        vsProject.CodeFiles = await CreateCodeFiles(project, solution, uICallback, distinctReferenecedByList);

                        // Add this project
                        vsProjects.Add(vsProject);
                    }
                }
                
                // return value
                return vsProjects;
            }
            #endregion
            
            #region CreateProperties(ClassDeclarationSyntax classDeclaration, SemanticModel semantic, Solution solution, bool distinctReferenecedByList))
            /// <summary>
            /// returns a list of Properties
            /// </summary>
            public async static Task<List<CodeProperty>> CreateProperties(ClassDeclarationSyntax classDeclaration, SemanticModel semanticModel, Solution solution, bool distinctReferenecedByList)
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
                        List<ReferencedBy> references = await CreateReferences(property, semanticModel, solution, ReferenceTypeEnum.Property);

                        // if the list needs to be distinct
                        if (distinctReferenecedByList)
                        {
                            // Get a distinct list
                            references = references.GroupBy(rb => rb.FilePath).Select(g => g.First()).ToList();
                        }

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

            #region CreateReferences(SyntaxNode codeObject, SemanticModel semanticModel, Solution solution, ReferenceTypeEnum referenceType)
            /// <summary>
            /// returns a list of References
            /// </summary>
            public async static Task<List<ReferencedBy>> CreateReferences(SyntaxNode codeObject, SemanticModel semanticModel, Solution solution, ReferenceTypeEnum referenceType)
            {
                // initial value
                List<ReferencedBy> referencesList = new List<ReferencedBy>();

                // If this is a method
                if (semanticModel.GetDeclaredSymbol(codeObject) is IMethodSymbol classSymbol)
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
                                referencedBy.SourceType = referenceType;
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
            
            #region CreateSolution(string path, UICallback uICallback, bool distinctReferenecedByList = true)
            /// <summary>
            /// returns the Solution
            /// </summary>
            public async static Task<VSSolution> CreateSolution(string path, UICallback uICallback, bool distinctReferenecedByList = true)
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

                    // Close the solution
                    workspace.CloseSolution();

                    // Create the Projects (and all child objects)
                    vsSolution.Projects = await CreateProjects(projects, solution, uICallback, distinctReferenecedByList);                    
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
            
            #region GetProjectType(string projectFilePath, out string description, out targetFramework)
            /// <summary>
            /// method returns the Project Type
            /// </summary>
            public static string GetProjectType(string projectFilePath, out string description, out string targetFramework)
            {
                var projectFile = XDocument.Load(projectFilePath);
                var outputType = projectFile.Descendants("OutputType").FirstOrDefault()?.Value;
                
                description = projectFile.Descendants("Description").FirstOrDefault()?.Value ?? "No description found.";
                targetFramework = projectFile.Descendants("TargetFramework").FirstOrDefault()?.Value ?? "No description found.";

                return outputType switch
                {
                    "Exe" => "Console Application",
                    "WinExe" => "Windows Application",
                    "Library" => "Class Library",
                    _ => "Unknown"
                    };
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

            #region GetTags(ClassDeclarationSyntax classDeclaration, SemanticModel semanticModel)
            /// <summary>
            /// method returns the Tags
            /// </summary>
            public static List<string> GetTags(SyntaxNode syntaxNode, SemanticModel semanticModel)
            {
                var tags = new List<string>();
                
                var symbol = semanticModel.GetDeclaredSymbol(syntaxNode) as INamedTypeSymbol;
                
                if (symbol != null)
                {
                    foreach (var attribute in symbol.GetAttributes())
                    {
                        tags.Add(attribute.AttributeClass.Name);
                    }
                }
                
                return tags;
            }
            #endregion

            #region IsPartialClass(ClassDeclarationSyntax classDeclaration)
            /// <summary>
            /// method returns the Partial Class
            /// </summary>
            public static bool IsPartialClass(ClassDeclarationSyntax classDeclaration)
            {
                return classDeclaration.Modifiers.Any(SyntaxKind.PartialKeyword);
            }
            #endregion
            
            #region LinkPartialClasses()
            /// <summary>
            /// Link Partial Classes
            /// </summary>
            public static void LinkPartialClasses(VSSolution solution)
            {
                // One final step, we need to link the CodeFiles
                if (ListHelper.HasOneOrMoreItems(solution.Projects))
                {
                    foreach (VSProject project in solution.Projects)
                    {
                        // Get all the partial classes for this project
                        List<CodeClass> partialClasses = project.CodeFiles.SelectMany(cf => cf.Classes).Where(c => c.IsPartial).ToList();

                        // If the partialClasses collection exists and has one or more items
                        if (ListHelper.HasOneOrMoreItems(partialClasses))
                        {
                            // last codeClass
                            CodeFile lastCodeFile = null;
                            string lastClassName = "";

                            // iterate the codeClasses
                            foreach (CodeClass codeClass in partialClasses)
                            {
                                // if this is the same as the last class
                                if (TextHelper.IsEqual(codeClass.Name, lastClassName))
                                {
                                    // if this codeClass has a ParentCodeFile
                                    if (codeClass.HasParentCodeFile)
                                    {
                                        // Set the lastCodeFile
                                        codeClass.ParentCodeFile.ParentCodeFile = lastCodeFile;
                                    }
                                }
                                else
                                {
                                    // Set the last CodeFile
                                    lastCodeFile = codeClass.ParentCodeFile;
                                }
                                    
                                // Set the lastClassName
                                lastClassName = codeClass.Name;
                            }
                        }
                    }
                }
            }
            #endregion
            
            #region Save(Gateway gateway, List<CodeClass> classes, int codeFileId, SaveResults saveResults)
            /// <summary>
            /// Saves a list of Classes.
            /// </summary>
            public static SaveResults Save(Gateway gateway, List<CodeClass> classes, int codeFileId, SaveResults saveResults)
            {
                // if there are one or more classes
                if (ListHelper.HasOneOrMoreItems(classes))
                {
                    // iterate the Classes
                    foreach (CodeClass codeClass in classes)
                    {
                        // Set the CodeFileId
                        codeClass.CodeFileId = codeFileId;
                                                        
                        // Clone the class
                        CodeClass codeClassClone = codeClass.Clone();

                        // Save the Class
                        bool tempSaved = gateway.SaveCodeClass(ref codeClassClone);

                        // if the value for tempSaved is true
                        if (tempSaved)
                        {
                            // Increment the value for saveResults
                            saveResults.CodeClassesSaved++;

                            // Update the Id
                            codeClass.UpdateIdentity(codeClassClone.Id);

                            // Save the Methods
                            saveResults = Save(gateway, codeClass.Methods, codeClass.Id, saveResults);

                            // Save the Properties
                            saveResults = Save(gateway, codeClass.Properties, codeClass.Id, saveResults);

                            // Save the Constructors
                            saveResults = Save(gateway, codeClass.Constructors, codeClass.Id, saveResults);

                            // Save the References
                            saveResults = Save(gateway, codeClass.References, codeClass.Id, ReferenceTypeEnum.Class, saveResults);
                        }
                        else
                        {
                            // Add the last Exceptiion
                            saveResults.Exceptions.Add(gateway.GetLastException());
                        }
                    }
                }
                
                // return value
                return saveResults;
            }
            #endregion
            
            #region Save(Gateway gateway, List<CodeMethod> methods, int classId, SaveResults saveResults)
            /// <summary>
            /// returns the
            /// </summary>
            public static SaveResults Save(Gateway gateway, List<CodeMethod> methods, int classId, SaveResults saveResults)
            {
                // If the value for the property codeClass.HasMethods is true
                if (ListHelper.HasOneOrMoreItems(methods))
                {
                    // Iterate the collection of CodeMethod objects
                    foreach (CodeMethod codeMethod in methods)
                    {
                        // Set the Id
                        codeMethod.CodeClassId = classId;

                        // clone
                        CodeMethod codeMethodClone = codeMethod.Clone();

                        // save
                        bool tempSaved = gateway.SaveCodeMethod(ref codeMethodClone);

                        // if the value for tempSaved is true
                        if (tempSaved)
                        {
                            // Update the Id
                            codeMethod.UpdateIdentity(codeMethodClone.Id);

                            // If the value for the property codeMethod.IsEventHandler is true
                            if (codeMethod.IsEventHandler)
                            {
                                // Increment the value for saveResults
                                saveResults.EventHandlersSaved++;
                            }
                            else
                            {
                                // Increment the value for saveResults
                                saveResults.CodeMethodsSaved++;    
                            }

                            // Save the Parameters
                            saveResults = Save(gateway, codeMethod.Parameters, codeMethod.Id, saveResults);

                            // Save the References
                            saveResults = Save(gateway, codeMethod.References, codeMethod.Id, ReferenceTypeEnum.Method, saveResults);
                        }
                        else
                        {
                            // Get the last Exception
                            saveResults.Exceptions.Add(gateway.GetLastException());
                        }
                    }
                }
                
                // return value
                return saveResults;
            }
            #endregion

            #region Save(Gateway gateway, List<CodeParameter> parameters, int methodId, SaveResults saveResults)
            /// <summary>
            /// Saves a list of Parameters
            /// </summary>
            public static SaveResults Save(Gateway gateway, List<CodeParameter> parameters, int methodId, SaveResults saveResults)
            {
                // If the codeMethod.Parameters collection exists and has one or more items
                if (ListHelper.HasOneOrMoreItems(parameters))
                {
                    // Iterate the collection of CodeParameter objects
                    foreach (CodeParameter codeParameter in parameters)
                    {
                        // Set the Parent
                        codeParameter.ParentId = methodId;
                        codeParameter.ParentType = ObjectTypeEnum.Method;

                        // Clone
                        CodeParameter codeParameterClone = codeParameter.Clone();

                        // perform the save
                        bool tempSaved = gateway.SaveCodeParameter(ref codeParameterClone);

                        // if the value for tempSaved is true
                        if (tempSaved)
                        {
                            // Increment the value for saveResults
                            saveResults.CodeParametersSaved++;
                        }
                    }
                }

                // return value
                return saveResults;
            }
            #endregion
            
            #region Save(Gateway gateway, List<CodeConstructor> codeConstructors, int classId, SaveResults saveResults)
            /// <summary>
            /// Saves a list of Classes.
            /// </summary>
            public static SaveResults Save(Gateway gateway, List<CodeConstructor> codeConstructors, int classId, SaveResults saveResults)
            {
                // if there are one or more codeConstructors
                if (ListHelper.HasOneOrMoreItems(codeConstructors))
                {
                    // Iterate the collection of CodeConstructor objects
                    foreach (CodeConstructor codeConstructor in codeConstructors)
                    {
                        // Set the classId
                        codeConstructor.CodeClassId = classId;
                                                        
                        // Clone the CodeConstructor
                        CodeConstructor codeConstructorClone = codeConstructor.Clone();

                        // Save the codeConstructorClone
                        bool tempSaved = gateway.SaveCodeConstructor(ref codeConstructorClone);

                        // if the value for tempSaved is true
                        if (tempSaved)
                        {
                            // Increment the value for saveResults
                            saveResults.CodeConstructorsSaved++;

                            // Update the Id
                            codeConstructor.UpdateIdentity(codeConstructorClone.Id);

                            // Save the References
                            saveResults = Save(gateway, codeConstructor.References, codeConstructor.Id, ReferenceTypeEnum.Constructor, saveResults);
                        }
                        else
                        {
                            // Add the last Exception
                            saveResults.Exceptions.Add(gateway.GetLastException());
                        }
                    }
                }
                
                // return value
                return saveResults;
            }
            #endregion
            
            #region Save(Gateway gateway, List<CodeFile> codeFiles, int projectId, SaveResults saveResults, UICallback uICallback)
            /// <summary>
            /// Saves a list of CodeFiles
            /// </summary>
            public static SaveResults Save(Gateway gateway, List<CodeFile> codeFiles, int projectId, SaveResults saveResults, UICallback uICallback)
            {
                // if there are one or more codeFiles
                if (ListHelper.HasOneOrMoreItems(codeFiles))
                {
                    // locals for saving
                    int totalFiles = codeFiles.Count;
                    int currentFileNumber = 0;
                    string statusText = "";

                    // If the uICallback object exists
                    if (NullHelper.Exists(uICallback))
                    {
                        // Display the results
                        statusText = "Saving file 1 of " + totalFiles + ".";
                        uICallback.BatchProgress(totalFiles, currentFileNumber, statusText);
                    }

                    // iterate the CodeFiles
                    foreach (CodeFile codeFile in codeFiles)
                    {
                        // Set the projectId
                        codeFile.ProjectId = projectId;

                        // Clone
                        CodeFile codeFileClone = codeFile.Clone();

                        // save the CodeFile
                        bool tempSaved = gateway.SaveCodeFile(ref codeFileClone);

                        // if the value for tempSaved is true
                        if (tempSaved)
                        {
                            // Set the Id
                            codeFile.UpdateIdentity(codeFileClone.Id);

                            // Find the linked files
                            List<CodeFile> linkedCodeFiles = codeFiles.Where(x => (x.ParentCodeFile != null && x.ParentCodeFile.InternalId == codeFile.InternalId)).ToList();

                            // If the linkedCodeFiles collection exists and has one or more items
                            if (ListHelper.HasOneOrMoreItems(linkedCodeFiles))
                            {
                                // Update the Parent Id. 
                                linkedCodeFiles.ForEach(linkedFile => linkedFile.ParentId = codeFile.Id);
                            }

                            // Increment the value for saveResults
                            saveResults.CodeFilesSaved++;

                            // Save the Parameters if Any
                            saveResults = Save(gateway, codeFile.Classes, codeFile.Id, saveResults);

                            // If the uICallback object exists
                            if (NullHelper.Exists(uICallback))
                            {
                                // Increment the value for currentFileNumber
                                currentFileNumber++;

                                // Display the results
                                statusText = "Saving file " + currentFileNumber + " of " + totalFiles + ".";
                                uICallback.BatchProgress(totalFiles, currentFileNumber, statusText);
                            }
                        }
                        else
                        {
                            // Add this Exception
                            saveResults.Exceptions.Add(gateway.GetLastException());
                        }
                    }
                }
                
                // return value
                return saveResults;
            }
            #endregion
            
            #region Save(Gateway gateway, VSProject project, int solutionId, SaveResults saveResults, UICallback uICallback)
            /// <summary>
            /// Saves the current Project
            /// </summary>
            public static SaveResults Save(Gateway gateway, VSProject project, int solutionId, SaveResults saveResults, UICallback uICallback)
            {
                // Update
                project.SolutionId = solutionId;

                // clone the project
                VSProject clone = project.Clone();

                // Save this projects
                bool tempSaved = gateway.SaveVSProject(ref clone);

                // if saved
                if (tempSaved)
                {
                    // Set the Id
                    project.UpdateIdentity(clone.Id);

                    // Increment the value for saveResults
                    saveResults.VsProjectsSaved++;

                    // Now save the codeFiles
                    saveResults = Save(gateway, project.CodeFiles, project.Id, saveResults, uICallback);
                }
                else
                {
                    // Get the last Exception
                    saveResults.Exceptions.Add(gateway.GetLastException());
                }
                
                // return value
                return saveResults;
            }
            #endregion

            #region Save(Gateway gateway, List<ReferencedBy> references, int sourceId, ReferenceTypeEnum referenceType, SaveResults saveResults)
            /// <summary>
            /// Saves a list of ReferencedBy.
            /// </summary>
            public static SaveResults Save(Gateway gateway, List<ReferencedBy> references, int sourceId, ReferenceTypeEnum referenceType, SaveResults saveResults)
            {
                // if there are one or more references
                if (ListHelper.HasOneOrMoreItems(references))
                {
                    // iterate the references
                    foreach (ReferencedBy reference in references)
                    {
                        // Set the 
                        reference.SourceId = sourceId;
                        reference.SourceType = referenceType;
                                                        
                        // Clone the ReferencedBy
                        ReferencedBy referencedByClone = reference.Clone();

                        // Save the referencedByClone
                        bool tempSaved = gateway.SaveReferencedBy(ref referencedByClone);

                        // if the value for tempSaved is true
                        if (tempSaved)
                        {
                            // Increment the value for saveResults.ReferencedBysSavedj
                            saveResults.ReferencedBysSaved++;

                            // Update the Id
                            reference.UpdateIdentity(referencedByClone.Id);
                        }
                        else
                        {
                            // Add the last Exception
                            saveResults.Exceptions.Add(gateway.GetLastException());
                        }
                    }
                }
                
                // return value
                return saveResults;
            }
            #endregion

            #region Save(Gateway gateway, List<CodeProperty> codeProperties, int classId, SaveResults saveResults)
            /// <summary>
            /// Saves a list of Classes.
            /// </summary>
            public static SaveResults Save(Gateway gateway, List<CodeProperty> codeProperties, int classId, SaveResults saveResults)
            {
                // if there are one or more codeProperties
                if (ListHelper.HasOneOrMoreItems(codeProperties))
                {
                    // iterate the codeProperties
                    foreach (CodeProperty codeProperty in codeProperties)
                    {
                        // Set the CodeFileId
                        codeProperty.CodeClassId = classId;
                                                        
                        // Clone the CodeProperty
                        CodeProperty codePropertyClone = codeProperty.Clone();

                        // Save the codePropertyClone
                        bool tempSaved = gateway.SaveCodeProperty(ref codePropertyClone);

                        // if the value for tempSaved is true
                        if (tempSaved)
                        {
                            // Increment the value for saveResults.CodePropertiesSaved
                            saveResults.CodePropertiesSaved++;

                            // Update the Id
                            codeProperty.UpdateIdentity(codePropertyClone.Id);

                            // Save the references
                            Save(gateway, codeProperty.References, codeProperty.Id, ReferenceTypeEnum.Property, saveResults);
                        }
                        else
                        {
                            // Add the last Exception
                            saveResults.Exceptions.Add(gateway.GetLastException());
                        }
                    }
                }
                
                // return value
                return saveResults;
            }
            #endregion
            
            #region Save(VSSolution solution, UICallback uICallback)
            /// <summary>
            /// returns the
            /// </summary>
            public static SaveResults Save(VSSolution solution, UICallback uICallback)
            {
                // initial value
                SaveResults saveResults = new SaveResults();

                // If the solution object exists
                if (NullHelper.Exists(solution))
                {
                    // Create a new instance of a 'Gateway' object.
                    Gateway gateway = new Gateway(Connection.Name);    

                    // perform the Save
                    bool saved = gateway.SaveVSSolution(ref solution);

                    // if the value for saved is true
                    if (saved)
                    {
                        // increment
                        saveResults.VsSolutionsSaved = 1;

                        // if there are one or more projects
                        if (ListHelper.HasOneOrMoreItems(solution.Projects))
                        {
                            // Set the totalProjectsCount
                            int totalProjectsCount = solution.Projects.Count;
                            int currentProjectNumber = 0;

                            // Set the StatusMessage
                            string statusMessage = "Saving project 1 of " + solution.Projects.Count;

                            // If the UICallback object exists
                            if (NullHelper.Exists(uICallback))
                            {
                                uICallback.OverallProgress(totalProjectsCount, 0, "Updating project 1 of " + totalProjectsCount);
                            }

                            // iterate the projects
                            foreach (VSProject project in solution.Projects)
                            {
                                // Call save Projects
                                saveResults = Save(gateway, project, solution.Id, saveResults, uICallback);

                                // Increment the value for currentProjectNumber
                                currentProjectNumber++;

                                // If the uICallback object exists
                                if (NullHelper.Exists(uICallback))
                                {
                                    // Display the current status
                                    string statusText = "Saving project " + currentProjectNumber + " of " + totalProjectsCount + ".";
                                    uICallback.OverallProgress(totalProjectsCount, currentProjectNumber, statusText);
                                }
                            }
                        }
                    }
                    else
                    {
                        // Get the last exception
                        Exception exception = gateway.GetLastException();

                        // If the exception object exists
                        if (NullHelper.Exists(exception))
                        {
                            // Add this exception
                            saveResults.Exceptions.Add(exception);
                        }
                    }
                }
                
                // return value
                return saveResults;
            }
            #endregion
            
        #endregion
        
    }
    #endregion

}
