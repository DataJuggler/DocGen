

#region using statements

using DataJuggler.DocGen.ObjectLibrary.Enumerations;
using System;

#endregion


namespace DataJuggler.DocGen.ObjectLibrary.BusinessObjects
{

    #region class ReferencedBy
    [Serializable]
    public partial class ReferencedBy
    {

        #region Private Variables
        private object source;
        private object target;
        #endregion

        #region Constructor
        public ReferencedBy()
        {

        }
        #endregion

        #region Methods

            #region Clone()
            public ReferencedBy Clone()
            {
                // Create New Object
                ReferencedBy newReferencedBy = (ReferencedBy) this.MemberwiseClone();

                // Return Cloned Object
                return newReferencedBy;
            }
            #endregion

        #endregion

        #region Properties

            #region Source
            /// <summary>
            /// This property gets or sets the value for 'Source'.
            /// </summary>
            public object Source
            {
                get { return source; }
                set { source = value; }
            }
            #endregion
            
            #region Target
            /// <summary>
            /// This property gets or sets the value for 'Target'.
            /// </summary>
            public object Target
            {
                get { return target; }
                set { target = value; }
            }
            #endregion
            
        #endregion

    }
    #endregion

}
