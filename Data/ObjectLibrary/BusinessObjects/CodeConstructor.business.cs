

#region using statements

using DataJuggler.UltimateHelper;
using ObjectLibrary.Enumerations;
using System;
using System.Collections.Generic;

#endregion


namespace ObjectLibrary.BusinessObjects
{

    #region class CodeConstructor
    [Serializable]
    public partial class CodeConstructor
    {

        #region Private Variables
        private List<CodeParameter> parameters;
        private List<ReferencedBy> references;
        #endregion

        #region Constructor
        public CodeConstructor()
        {

        }
        #endregion

        #region Methods

            #region Clone()
            public CodeConstructor Clone()
            {
                // Create New Object
                CodeConstructor newCodeConstructor = (CodeConstructor) this.MemberwiseClone();

                // Return Cloned Object
                return newCodeConstructor;
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
