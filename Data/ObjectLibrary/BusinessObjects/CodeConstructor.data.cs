

#region using statements

using ObjectLibrary.Enumerations;
using System;

#endregion


namespace ObjectLibrary.BusinessObjects
{

    #region class CodeConstructor
    public partial class CodeConstructor
    {

        #region Private Variables
        private int codeClassId;
        private int codeFileId;
        private string description;
        private int endLineNumber;
        private int id;
        private string name;
        private string returnType;
        private int startLineNumber;
        private int status;
        private bool visible;
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

            #region int CodeClassId
            public int CodeClassId
            {
                get
                {
                    return codeClassId;
                }
                set
                {
                    codeClassId = value;
                }
            }
            #endregion

            #region int CodeFileId
            public int CodeFileId
            {
                get
                {
                    return codeFileId;
                }
                set
                {
                    codeFileId = value;
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

            #region int EndLineNumber
            public int EndLineNumber
            {
                get
                {
                    return endLineNumber;
                }
                set
                {
                    endLineNumber = value;
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

            #region string ReturnType
            public string ReturnType
            {
                get
                {
                    return returnType;
                }
                set
                {
                    returnType = value;
                }
            }
            #endregion

            #region int StartLineNumber
            public int StartLineNumber
            {
                get
                {
                    return startLineNumber;
                }
                set
                {
                    startLineNumber = value;
                }
            }
            #endregion

            #region int Status
            public int Status
            {
                get
                {
                    return status;
                }
                set
                {
                    status = value;
                }
            }
            #endregion

            #region bool Visible
            public bool Visible
            {
                get
                {
                    return visible;
                }
                set
                {
                    visible = value;
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
