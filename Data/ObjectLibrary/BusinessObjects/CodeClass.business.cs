

#region using statements

using DataJuggler.UltimateHelper;
using DataJuggler.DocGen.ObjectLibrary.Enumerations;
using System;
using System.Collections.Generic;

#endregion


namespace DataJuggler.DocGen.ObjectLibrary.BusinessObjects
{

    #region class CodeClass
    [Serializable]
    public partial class CodeClass
    {

        #region Private Variables
        private List<CodeMethod> methods;
        private List<CodeProperty> properties;
        private List<ReferencedBy> references;
        private List<CodeConstructor> constructors;
        private Guid internalParentId;
        private CodeFile parentCodeFile;
        #endregion

        #region Constructor
        public CodeClass()
        {
            // Perform initializations for this object
            Init();
        }
        #endregion

        #region Methods

            #region Clone()
            public CodeClass Clone()
            {
                // Create New Object
                CodeClass newCodeClass = (CodeClass) this.MemberwiseClone();

                // Return Cloned Object
                return newCodeClass;
            }
            #endregion

            #region Init()
            /// <summary>
            ///  This method performs initializations for this object.
            /// </summary>
            public void Init()
            {
                // Create child lists                
                Methods = new List<CodeMethod>();
                Properties = new List<CodeProperty>();
                References = new List<ReferencedBy>();
                Constructors = new List<CodeConstructor>();
            }
            #endregion

            #region SetupReferences()
            /// <summary>
            /// Setup References
            /// </summary>
            public void SetupReferences()
            {
                // If the References collection exists and has one or more items
                if (ListHelper.HasOneOrMoreItems(References))
                {
                    // Iterate the collection of ReferencedBy objects
                    foreach (ReferencedBy reference in References)
                    {
                        // Set the Source object to this so it can be saved
                        reference.Source = this;
                    }
                }
            }
            #endregion
            
        #endregion

        #region Properties

            #region Constructors
            /// <summary>
            /// This property gets or sets the value for 'Constructors'.
            /// </summary>
            public List<CodeConstructor> Constructors
            {
                get { return constructors; }
                set { constructors = value; }
            }
            #endregion
            
            #region HasMethods
            /// <summary>
            /// This property returns true if this object has a 'Methods'.
            /// </summary>
            public bool HasMethods
            {
                get
                {
                    // initial value
                    bool hasMethods = (this.Methods != null);
                    
                    // return value
                    return hasMethods;
                }
            }
            #endregion
            
            #region HasParentCodeFile
            /// <summary>
            /// This property returns true if this object has a 'ParentCodeFile'.
            /// </summary>
            public bool HasParentCodeFile
            {
                get
                {
                    // initial value
                    bool hasParentCodeFile = (this.ParentCodeFile != null);
                    
                    // return value
                    return hasParentCodeFile;
                }
            }
            #endregion
            
            #region HasProperties
            /// <summary>
            /// This property returns true if this object has a 'Properties'.
            /// </summary>
            public bool HasProperties
            {
                get
                {
                    // initial value
                    bool hasProperties = (this.Properties != null);
                    
                    // return value
                    return hasProperties;
                }
            }
            #endregion
            
            #region InternalParentId
            /// <summary>
            /// This property gets or sets the value for 'InternalParentId'.
            /// </summary>
            public Guid InternalParentId
            {
                get { return internalParentId; }
                set { internalParentId = value; }
            }
            #endregion
            
            #region Methods
            /// <summary>
            /// This property gets or sets the value for 'Methods'.
            /// </summary>
            public List<CodeMethod> Methods
            {
                get { return methods; }
                set { methods = value; }
            }
            #endregion
            
            #region ParentCodeFile
            /// <summary>
            /// This property gets or sets the value for 'ParentCodeFile'.
            /// </summary>
            public CodeFile ParentCodeFile
            {
                get { return parentCodeFile; }
                set { parentCodeFile = value; }
            }
            #endregion
            
            #region Properties
            /// <summary>
            /// This property gets or sets the value for 'Properties'.
            /// </summary>
            public List<CodeProperty> Properties
            {
                get { return properties; }
                set { properties = value; }
            }
            #endregion
            
            #region References
            /// <summary>
            /// This property gets or sets the value for 'References'.
            /// </summary>
            public List<ReferencedBy> References
            {
                get { return references; }
                set { references = value; }
            }
            #endregion
            
        #endregion

    }
    #endregion

}
