

#region using statements

using DataJuggler.UltimateHelper;
using ObjectLibrary.Enumerations;
using System;
using System.Collections.Generic;

#endregion


namespace ObjectLibrary.BusinessObjects
{

    #region class CodeEvent
    [Serializable]
    public partial class CodeEvent
    {

        #region Private Variables
        private List<ReferencedBy> references;
        private List<CodeParameter> parameters;
        #endregion

        #region Constructor
        public CodeEvent()
        {
             // Create
            References = new List<ReferencedBy>();
            Parameters = new List<CodeParameter>();
        }
        #endregion

        #region Methods

            #region Clone()
            public CodeEvent Clone()
            {
                // Create New Object
                CodeEvent newCodeEvent = (CodeEvent) this.MemberwiseClone();

                // Return Cloned Object
                return newCodeEvent;
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
