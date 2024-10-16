

#region using statements

using ObjectLibrary.Enumerations;
using System;

#endregion


namespace ObjectLibrary.BusinessObjects
{

    #region class CodeMethod
    public partial class CodeMethod
    {

        #region Private Variables
        private int codeClassId;
        private int codeFileId;
        private string description;
        private int endLineNumber;
        private int id;
        private bool isAsync;
        private bool isEventHandler;
        private string name;
        private string referencedByPath;
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

            #region bool IsAsync
            public bool IsAsync
            {
                get
                {
                    return isAsync;
                }
                set
                {
                    isAsync = value;
                }
            }
            #endregion

            #region bool IsEventHandler
            public bool IsEventHandler
            {
                get
                {
                    return isEventHandler;
                }
                set
                {
                    isEventHandler = value;
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

            #region string ReferencedByPath
            public string ReferencedByPath
            {
                get
                {
                    return referencedByPath;
                }
                set
                {
                    referencedByPath = value;
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
