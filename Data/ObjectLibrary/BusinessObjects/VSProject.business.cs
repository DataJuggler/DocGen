

#region using statements

using ObjectLibrary.Enumerations;
using System;
using System.Collections.Generic;

#endregion


namespace ObjectLibrary.BusinessObjects
{

    #region class VSProject
    [Serializable]
    public partial class VSProject
    {

        #region Private Variables
        private List<CodeFile> codeFiles;
        #endregion

        #region Constructor
        public VSProject()
        {
            // Create
            CodeFiles = new List<CodeFile>();
        }
        #endregion

        #region Methods

            #region Clone()
            public VSProject Clone()
            {
                // Create New Object
                VSProject newVSProject = (VSProject) this.MemberwiseClone();

                // Return Cloned Object
                return newVSProject;
            }
            #endregion

        #endregion

        #region Properties

            #region CodeFiles
            /// <summary>
            /// This property gets or sets the value for 'CodeFiles'.
            /// </summary>
            public List<CodeFile> CodeFiles
            {
                get { return codeFiles; }
                set { codeFiles = value; }
            }
            #endregion
            
            #region HasCodeFiles
            /// <summary>
            /// This property returns true if this object has a 'CodeFiles'.
            /// </summary>
            public bool HasCodeFiles
            {
                get
                {
                    // initial value
                    bool hasCodeFiles = (this.CodeFiles != null);
                    
                    // return value
                    return hasCodeFiles;
                }
            }
            #endregion
            
        #endregion

    }
    #endregion

}
