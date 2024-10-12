

#region using statements

using ObjectLibrary.Enumerations;
using System;

#endregion


namespace ObjectLibrary.BusinessObjects
{

    #region class CodeParameter
    [Serializable]
    public partial class CodeParameter
    {

        #region Private Variables
        #endregion

        #region Constructor
        public CodeParameter()
        {

        }
        #endregion

        #region Methods

            #region Clone()
            public CodeParameter Clone()
            {
                // Create New Object
                CodeParameter newCodeParameter = (CodeParameter) this.MemberwiseClone();

                // Return Cloned Object
                return newCodeParameter;
            }
            #endregion

        #endregion

        #region Properties
        #endregion

    }
    #endregion

}
