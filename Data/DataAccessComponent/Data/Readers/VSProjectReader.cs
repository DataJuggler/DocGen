

#region using statements

using ObjectLibrary.BusinessObjects;
using ObjectLibrary.Enumerations;
using System;
using System.Collections.Generic;
using System.Data;

#endregion


namespace DataAccessComponent.Data.Readers
{

    #region class VSProjectReader
    /// <summary>
    /// This class loads a single 'VSProject' object or a list of type <VSProject>.
    /// </summary>
    public class VSProjectReader
    {

        #region Static Methods

            #region Load(DataRow dataRow)
            /// <summary>
            /// This method loads a 'VSProject' object
            /// from the dataRow passed in.
            /// </summary>
            /// <param name='dataRow'>The 'DataRow' to load from.</param>
            /// <returns>A 'VSProject' DataObject.</returns>
            public static VSProject Load(DataRow dataRow)
            {
                // Initial Value
                VSProject vSProject = new VSProject();

                // Create field Integers
                int descriptionfield = 0;
                int fullPathfield = 1;
                int idfield = 2;
                int isPreviewfield = 3;
                int namefield = 4;
                int previewDescriptionfield = 5;
                int projectTypefield = 6;
                int solutionIdfield = 7;
                int statusfield = 8;
                int targetFrameworkfield = 9;
                int visiblefield = 10;

                try
                {
                    // Load Each field
                    vSProject.Description = DataHelper.ParseString(dataRow.ItemArray[descriptionfield]);
                    vSProject.FullPath = DataHelper.ParseString(dataRow.ItemArray[fullPathfield]);
                    vSProject.UpdateIdentity(DataHelper.ParseInteger(dataRow.ItemArray[idfield], 0));
                    vSProject.IsPreview = DataHelper.ParseBoolean(dataRow.ItemArray[isPreviewfield], false);
                    vSProject.Name = DataHelper.ParseString(dataRow.ItemArray[namefield]);
                    vSProject.PreviewDescription = DataHelper.ParseString(dataRow.ItemArray[previewDescriptionfield]);
                    vSProject.ProjectType = DataHelper.ParseString(dataRow.ItemArray[projectTypefield]);
                    vSProject.SolutionId = DataHelper.ParseInteger(dataRow.ItemArray[solutionIdfield], 0);
                    vSProject.Status = DataHelper.ParseInteger(dataRow.ItemArray[statusfield], 0);
                    vSProject.TargetFramework = DataHelper.ParseString(dataRow.ItemArray[targetFrameworkfield]);
                    vSProject.Visible = DataHelper.ParseBoolean(dataRow.ItemArray[visiblefield], false);
                }
                catch
                {
                }

                // return value
                return vSProject;
            }
            #endregion

            #region LoadCollection(DataTable dataTable)
            /// <summary>
            /// This method loads a collection of 'VSProject' objects.
            /// from the dataTable.Rows object passed in.
            /// </summary>
            /// <param name='dataTable'>The 'DataTable.Rows' to load from.</param>
            /// <returns>A VSProject Collection.</returns>
            public static List<VSProject> LoadCollection(DataTable dataTable)
            {
                // Initial Value
                List<VSProject> vSProjects = new List<VSProject>();

                try
                {
                    // Load Each row In DataTable
                    foreach (DataRow row in dataTable.Rows)
                    {
                        // Create 'VSProject' from rows
                        VSProject vSProject = Load(row);

                        // Add this object to collection
                        vSProjects.Add(vSProject);
                    }
                }
                catch
                {
                }

                // return value
                return vSProjects;
            }
            #endregion

        #endregion

    }
    #endregion

}
