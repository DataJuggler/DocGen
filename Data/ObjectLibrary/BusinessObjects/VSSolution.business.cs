

#region using statements

using ObjectLibrary.Enumerations;
using System;
using System.Collections.Generic;

#endregion


namespace ObjectLibrary.BusinessObjects
{

    #region class VSSolution
    [Serializable]
    public partial class VSSolution
    {

        #region Private Variables
        private List<VSProject> projects;
        private List<Exception> errors;
        #endregion

        #region Constructor
        public VSSolution()
        {
            // Create a new collection of 'VSProject' objects.
            Projects = new List<VSProject>();

            // Create a new collection of 'Exception' objects.
            Errors = new List<Exception>();
        }
        #endregion

        #region Methods

            #region Clone()
            public VSSolution Clone()
            {
                // Create New Object
                VSSolution newVSSolution = (VSSolution) this.MemberwiseClone();

                // Return Cloned Object
                return newVSSolution;
            }
            #endregion

        #endregion

        #region Properties

            #region Errors
            /// <summary>
            /// This property gets or sets the value for 'Errors'.
            /// </summary>
            public List<Exception> Errors
            {
                get { return errors; }
                set { errors = value; }
            }
            #endregion
            
            #region HasProjects
            /// <summary>
            /// This property returns true if this object has a 'Projects'.
            /// </summary>
            public bool HasProjects
            {
                get
                {
                    // initial value
                    bool hasProjects = (this.Projects != null);
                    
                    // return value
                    return hasProjects;
                }
            }
            #endregion
            
            #region Projects
            /// <summary>
            /// This property gets or sets the value for 'Projects'.
            /// </summary>
            public List<VSProject> Projects
            {
                get { return projects; }
                set { projects = value; }
            }
            #endregion
            
        #endregion

    }
    #endregion

}
