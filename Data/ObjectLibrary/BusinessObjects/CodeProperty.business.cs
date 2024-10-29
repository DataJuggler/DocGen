

#region using statements

using DataJuggler.UltimateHelper;
using DataJuggler.DocGen.ObjectLibrary.Enumerations;
using System;
using System.Collections.Generic;

#endregion


namespace DataJuggler.DocGen.ObjectLibrary.BusinessObjects
{

    #region class CodeProperty
    [Serializable]
    public partial class CodeProperty
    {

        #region Private Variables
        private List<ReferencedBy> references;
        #endregion

        #region Constructor
        public CodeProperty()
        {
            // Create
            References = new List<ReferencedBy>();
        }
        #endregion

        #region Methods

            #region Clone()
            public CodeProperty Clone()
            {
                // Create New Object
                CodeProperty newCodeProperty = (CodeProperty) this.MemberwiseClone();

                // Return Cloned Object
                return newCodeProperty;
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
