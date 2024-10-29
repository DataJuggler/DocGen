

#region using statements

using DataJuggler.DocGen.ObjectLibrary.Enumerations;
using System;
using System.Collections.Generic;
using System.Linq;

#endregion


namespace DataJuggler.DocGen.ObjectLibrary.BusinessObjects
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
            
            #region TotalReferencesCount
            /// <summary>
            /// This read only property returns the value of TotalReferencesCount from the object Projects.
            /// </summary>
            public int TotalReferencesCount
            {
                
                get
                {
                    // initial value
                    int totalReferencesCount = 0;
                    
                    // Get the projectReferences Count
                    int projectReferences = Projects.SelectMany(p => p.CodeFiles).SelectMany(cf => cf.Classes).SelectMany(cl => cl.References).Count();
                    int constructorReferences = Projects.SelectMany(p => p.CodeFiles).SelectMany(cf => cf.Classes).SelectMany(cl => cl.Constructors)    .SelectMany(c => c.References).Count();
                    int methodReferences = Projects.SelectMany(p => p.CodeFiles).SelectMany(cf => cf.Classes).SelectMany(cl => cl.Methods).SelectMany(m => m.References).Count();
                    int propertyReferences = Projects.SelectMany(p => p.CodeFiles).SelectMany(cf => cf.Classes).SelectMany(cl => cl.Properties).SelectMany(p => p.References).Count();

                    // set the total
                    totalReferencesCount = projectReferences + constructorReferences + methodReferences + projectReferences;
                    
                    // return value
                    return totalReferencesCount;
                }
            }
            #endregion
            
        #endregion

    }
    #endregion

}
