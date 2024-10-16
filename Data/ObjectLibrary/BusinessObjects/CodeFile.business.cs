

#region using statements

using ObjectLibrary.Enumerations;
using System;
using System.Collections.Generic;

#endregion


namespace ObjectLibrary.BusinessObjects
{

    #region class CodeFile
    [Serializable]
    public partial class CodeFile
    {

        #region Private Variables
        private List<CodeClass> classes;
        private Guid internalId;
        private CodeFile parentCodeFile;
        #endregion

        #region Constructor
        public CodeFile()
        {
            // Perform initializations for this object
            Init();
        }
        #endregion

        #region Methods

            #region Clone()
            public CodeFile Clone()
            {
                // Create New Object
                CodeFile newCodeFile = (CodeFile) this.MemberwiseClone();

                // Return Cloned Object
                return newCodeFile;
            }
            #endregion

            #region Init()
            /// <summary>
            ///  This method performs initializations for this object.
            /// </summary>
            public void Init()
            {
                // Create child lists
                Classes = new List<CodeClass>();

                // Create a Guid
                InternalId = Guid.NewGuid();
            }
            #endregion
            
        #endregion

        #region Properties

            #region Classes
            /// <summary>
            /// This property gets or sets the value for 'Classes'.
            /// </summary>
            public List<CodeClass> Classes
            {
                get { return classes; }
                set { classes = value; }
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
            
            #region InternalId
            /// <summary>
            /// This property gets or sets the value for 'InternalId'.
            /// </summary>
            public Guid InternalId
            {
                get { return internalId; }
                set { internalId = value; }
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
            
        #endregion

    }
    #endregion

}
