

#region using statements

using DataJuggler.UltimateHelper;
using ObjectLibrary.Enumerations;
using System;
using System.Collections.Generic;

#endregion


namespace ObjectLibrary.BusinessObjects
{

    #region class CodeMethod
    [Serializable]
    /// <summary>
    /// This class represents one method in a CodeFile.
    /// </summary>
    public partial class CodeMethod
    {

        #region Private Variables
        private List<ReferencedBy> references;
        private List<CodeParameter> parameters;
        #endregion

        #region Constructor
        /// <summary>
        /// Create a new instance of a CodeMethod object.
        /// </summary>
        public CodeMethod()
        {
            // Create
            References = new List<ReferencedBy>();
            Parameters = new List<CodeParameter>();
        }
        #endregion

        #region Methods

            #region Clone()
            public CodeMethod Clone()
            {
                // Create New Object
                CodeMethod newCodeMethod = (CodeMethod) this.MemberwiseClone();

                // Return Cloned Object
                return newCodeMethod;
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

            #region HasReferences
            /// <summary>
            /// This property returns true if this object has a 'References'.
            /// </summary>
            public bool HasReferences
            {
                get
                {
                    // initial value
                    bool hasReferences = (this.References != null);
                    
                    // return value
                    return hasReferences;
                }
            }
            #endregion
            
            #region Parameters
            /// <summary>
            /// This property gets or sets the value for 'Parameters'.
            /// </summary>
            public List<CodeParameter> Parameters
            {
                get { return parameters; }
                set { parameters = value; }
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
