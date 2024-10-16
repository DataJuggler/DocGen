

#region using statements

using ObjectLibrary.BusinessObjects;
using ObjectLibrary.Enumerations;
using System;
using System.Collections.Generic;
using System.Data;

#endregion


namespace DataAccessComponent.Data.Readers
{

    #region class VSSolutionReader
    /// <summary>
    /// This class loads a single 'VSSolution' object or a list of type <VSSolution>.
    /// </summary>
    public class VSSolutionReader
    {

        #region Static Methods

            #region Load(DataRow dataRow)
            /// <summary>
            /// This method loads a 'VSSolution' object
            /// from the dataRow passed in.
            /// </summary>
            /// <param name='dataRow'>The 'DataRow' to load from.</param>
            /// <returns>A 'VSSolution' DataObject.</returns>
            public static VSSolution Load(DataRow dataRow)
            {
                // Initial Value
                VSSolution vSSolution = new VSSolution();

                // Create field Integers
                int createdDatefield = 0;
                int descriptionfield = 1;
                int fullPathfield = 2;
                int idfield = 3;
                int namefield = 4;
                int statusfield = 5;
                int visiblefield = 6;

                try
                {
                    // Load Each field
                    vSSolution.CreatedDate = DataHelper.ParseDate(dataRow.ItemArray[createdDatefield]);
                    vSSolution.Description = DataHelper.ParseString(dataRow.ItemArray[descriptionfield]);
                    vSSolution.FullPath = DataHelper.ParseString(dataRow.ItemArray[fullPathfield]);
                    vSSolution.UpdateIdentity(DataHelper.ParseInteger(dataRow.ItemArray[idfield], 0));
                    vSSolution.Name = DataHelper.ParseString(dataRow.ItemArray[namefield]);
                    vSSolution.Status = DataHelper.ParseInteger(dataRow.ItemArray[statusfield], 0);
                    vSSolution.Visible = DataHelper.ParseBoolean(dataRow.ItemArray[visiblefield], false);
                }
                catch
                {
                }

                // return value
                return vSSolution;
            }
            #endregion

            #region LoadCollection(DataTable dataTable)
            /// <summary>
            /// This method loads a collection of 'VSSolution' objects.
            /// from the dataTable.Rows object passed in.
            /// </summary>
            /// <param name='dataTable'>The 'DataTable.Rows' to load from.</param>
            /// <returns>A VSSolution Collection.</returns>
            public static List<VSSolution> LoadCollection(DataTable dataTable)
            {
                // Initial Value
                List<VSSolution> vSSolutions = new List<VSSolution>();

                try
                {
                    // Load Each row In DataTable
                    foreach (DataRow row in dataTable.Rows)
                    {
                        // Create 'VSSolution' from rows
                        VSSolution vSSolution = Load(row);

                        // Add this object to collection
                        vSSolutions.Add(vSSolution);
                    }
                }
                catch
                {
                }

                // return value
                return vSSolutions;
            }
            #endregion

        #endregion

    }
    #endregion

}
