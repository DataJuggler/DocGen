

#region using statements

using ObjectLibrary.Enumerations;
using System;

#endregion


namespace ObjectLibrary.BusinessObjects
{

    #region class CodeSample
    [Serializable]
    public partial class CodeSample
    {

        #region Private Variables
        #endregion

        #region Constructor
        public CodeSample()
        {

        }
        #endregion

        #region Methods

            #region Clone()
            public CodeSample Clone()
            {
                // Create New Object
                CodeSample newCodeSample = (CodeSample) this.MemberwiseClone();

                // Return Cloned Object
                return newCodeSample;
            }
            #endregion

        #endregion

        #region Properties
        #endregion

    }
    #endregion

}
