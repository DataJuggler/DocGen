

#region using statements

using ObjectLibrary.Enumerations;
using System;

#endregion


namespace ObjectLibrary.BusinessObjects
{

    #region class ReferencedBy
    public partial class ReferencedBy
    {

        #region Private Variables
        private int codeFileId;
        private string filePath;
        private int id;
        private int lineNumber;
        private int projectId;
        private int sourceId;
        private ReferenceTypeEnum sourceType;
        private int status;
        private int targetId;
        private ReferenceTypeEnum targetType;
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

            #region string FilePath
            public string FilePath
            {
                get
                {
                    return filePath;
                }
                set
                {
                    filePath = value;
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

            #region int LineNumber
            public int LineNumber
            {
                get
                {
                    return lineNumber;
                }
                set
                {
                    lineNumber = value;
                }
            }
            #endregion

            #region int ProjectId
            public int ProjectId
            {
                get
                {
                    return projectId;
                }
                set
                {
                    projectId = value;
                }
            }
            #endregion

            #region int SourceId
            public int SourceId
            {
                get
                {
                    return sourceId;
                }
                set
                {
                    sourceId = value;
                }
            }
            #endregion

            #region ReferenceTypeEnum SourceType
            public ReferenceTypeEnum SourceType
            {
                get
                {
                    return sourceType;
                }
                set
                {
                    sourceType = value;
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

            #region int TargetId
            public int TargetId
            {
                get
                {
                    return targetId;
                }
                set
                {
                    targetId = value;
                }
            }
            #endregion

            #region ReferenceTypeEnum TargetType
            public ReferenceTypeEnum TargetType
            {
                get
                {
                    return targetType;
                }
                set
                {
                    targetType = value;
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
