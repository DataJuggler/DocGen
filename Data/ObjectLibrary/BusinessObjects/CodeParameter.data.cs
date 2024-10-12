

#region using statements

using ObjectLibrary.Enumerations;
using System;

#endregion


namespace ObjectLibrary.BusinessObjects
{

    #region class CodeParameter
    public partial class CodeParameter
    {

        #region Private Variables
        private int codeEventId;
        private int codeMethodId;
        private string description;
        private int id;
        private bool isOptional;
        private string name;
        private string parameterType;
        #endregion

        #region Methods

            #region UpdateIdentity(int id)
            // <summary>
            // This method provides a 'setter'
            // functionality for the Identity field.
            // </summary>
            public void UpdateIdentity(int id)
            {
                // Update The Identity field
                this.id = id;
            }
            #endregion

        #endregion

        #region Properties

            #region int CodeEventId
            public int CodeEventId
            {
                get
                {
                    return codeEventId;
                }
                set
                {
                    codeEventId = value;
                }
            }
            #endregion

            #region int CodeMethodId
            public int CodeMethodId
            {
                get
                {
                    return codeMethodId;
                }
                set
                {
                    codeMethodId = value;
                }
            }
            #endregion

            #region string Description
            public string Description
            {
                get
                {
                    return description;
                }
                set
                {
                    description = value;
                }
            }
            #endregion

            #region int Id
            public int Id
            {
                get
                {
                    return id;
                }
            }
            #endregion

            #region bool IsOptional
            public bool IsOptional
            {
                get
                {
                    return isOptional;
                }
                set
                {
                    isOptional = value;
                }
            }
            #endregion

            #region string Name
            public string Name
            {
                get
                {
                    return name;
                }
                set
                {
                    name = value;
                }
            }
            #endregion

            #region string ParameterType
            public string ParameterType
            {
                get
                {
                    return parameterType;
                }
                set
                {
                    parameterType = value;
                }
            }
            #endregion

            #region bool IsNew
            public bool IsNew
            {
                get
                {
                    // Initial Value
                    bool isNew = (this.Id < 1);

                    // return value
                    return isNew;
                }
            }
            #endregion

        #endregion

    }
    #endregion

}
