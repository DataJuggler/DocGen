

#region using statements

using ObjectLibrary.Enumerations;
using System;

#endregion


namespace ObjectLibrary.BusinessObjects
{

    #region class CodeFile
    public partial class CodeFile
    {

        #region Private Variables
        private string description;
        private int eventsCount;
        private string fullPath;
        private int id;
        private int methodsCount;
        private string name;
        private int parentId;
        private int projectId;
        private int propertiesCount;
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

            #region int EventsCount
            public int EventsCount
            {
                get
                {
                    return eventsCount;
                }
                set
                {
                    eventsCount = value;
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

            #region int MethodsCount
            public int MethodsCount
            {
                get
                {
                    return methodsCount;
                }
                set
                {
                    methodsCount = value;
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

            #region int ParentId
            public int ParentId
            {
                get
                {
                    return parentId;
                }
                set
                {
                    parentId = value;
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

            #region int PropertiesCount
            public int PropertiesCount
            {
                get
                {
                    return propertiesCount;
                }
                set
                {
                    propertiesCount = value;
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
