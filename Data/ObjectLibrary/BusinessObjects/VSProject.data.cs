

#region using statements

using ObjectLibrary.Enumerations;
using System;

#endregion


namespace ObjectLibrary.BusinessObjects
{

    #region class VSProject
    public partial class VSProject
    {

        #region Private Variables
        private string description;
        private string fullPath;
        private int id;
        private bool isPreview;
        private string name;
        private string previewDescription;
        private string projectType;
        private int solutionId;
        private int status;
        private string targetFramework;
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

            #region string FullPath
            public string FullPath
            {
                get
                {
                    return fullPath;
                }
                set
                {
                    fullPath = value;
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

            #region bool IsPreview
            public bool IsPreview
            {
                get
                {
                    return isPreview;
                }
                set
                {
                    isPreview = value;
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

            #region string PreviewDescription
            public string PreviewDescription
            {
                get
                {
                    return previewDescription;
                }
                set
                {
                    previewDescription = value;
                }
            }
            #endregion

            #region string ProjectType
            public string ProjectType
            {
                get
                {
                    return projectType;
                }
                set
                {
                    projectType = value;
                }
            }
            #endregion

            #region int SolutionId
            public int SolutionId
            {
                get
                {
                    return solutionId;
                }
                set
                {
                    solutionId = value;
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

            #region string TargetFramework
            public string TargetFramework
            {
                get
                {
                    return targetFramework;
                }
                set
                {
                    targetFramework = value;
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
