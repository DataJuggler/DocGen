

#region using statements

using DataJuggler.DocGen.ObjectLibrary.BusinessObjects;
using DataJuggler.DocGen.ObjectLibrary.Enumerations;
using System;
using System.Collections.Generic;
using System.Data;

#endregion


namespace DataJuggler.DocGen.DataAccessComponent.Data.Readers
{

    #region class ReferencedByReader
    /// <summary>
    /// This class loads a single 'ReferencedBy' object or a list of type <ReferencedBy>.
    /// </summary>
    public class ReferencedByReader
    {

        #region Static Methods

            #region Load(DataRow dataRow)
            /// <summary>
            /// This method loads a 'ReferencedBy' object
            /// from the dataRow passed in.
            /// </summary>
            /// <param name='dataRow'>The 'DataRow' to load from.</param>
            /// <returns>A 'ReferencedBy' DataObject.</returns>
            public static ReferencedBy Load(DataRow dataRow)
            {
                // Initial Value
                ReferencedBy referencedBy = new ReferencedBy();

                // Create field Integers
                int codeFileIdfield = 0;
                int filePathfield = 1;
                int idfield = 2;
                int lineNumberfield = 3;
                int projectIdfield = 4;
                int sourceIdfield = 5;
                int sourceTypefield = 6;
                int statusfield = 7;
                int targetIdfield = 8;
                int targetTypefield = 9;
                int visiblefield = 10;

                try
                {
                    // Load Each field
                    referencedBy.CodeFileId = DataHelper.ParseInteger(dataRow.ItemArray[codeFileIdfield], 0);
                    referencedBy.FilePath = DataHelper.ParseString(dataRow.ItemArray[filePathfield]);
                    referencedBy.UpdateIdentity(DataHelper.ParseInteger(dataRow.ItemArray[idfield], 0));
                    referencedBy.LineNumber = DataHelper.ParseInteger(dataRow.ItemArray[lineNumberfield], 0);
                    referencedBy.ProjectId = DataHelper.ParseInteger(dataRow.ItemArray[projectIdfield], 0);
                    referencedBy.SourceId = DataHelper.ParseInteger(dataRow.ItemArray[sourceIdfield], 0);
                    referencedBy.SourceType = (ReferenceTypeEnum) DataHelper.ParseInteger(dataRow.ItemArray[sourceTypefield], 0);
                    referencedBy.Status = DataHelper.ParseInteger(dataRow.ItemArray[statusfield], 0);
                    referencedBy.TargetId = DataHelper.ParseInteger(dataRow.ItemArray[targetIdfield], 0);
                    referencedBy.TargetType = (ReferenceTypeEnum) DataHelper.ParseInteger(dataRow.ItemArray[targetTypefield], 0);
                    referencedBy.Visible = DataHelper.ParseBoolean(dataRow.ItemArray[visiblefield], false);
                }
                catch
                {
                }

                // return value
                return referencedBy;
            }
            #endregion

            #region LoadCollection(DataTable dataTable)
            /// <summary>
            /// This method loads a collection of 'ReferencedBy' objects.
            /// from the dataTable.Rows object passed in.
            /// </summary>
            /// <param name='dataTable'>The 'DataTable.Rows' to load from.</param>
            /// <returns>A ReferencedBy Collection.</returns>
            public static List<ReferencedBy> LoadCollection(DataTable dataTable)
            {
                // Initial Value
                List<ReferencedBy> referencedBys = new List<ReferencedBy>();

                try
                {
                    // Load Each row In DataTable
                    foreach (DataRow row in dataTable.Rows)
                    {
                        // Create 'ReferencedBy' from rows
                        ReferencedBy referencedBy = Load(row);

                        // Add this object to collection
                        referencedBys.Add(referencedBy);
                    }
                }
                catch
                {
                }

                // return value
                return referencedBys;
            }
            #endregion

        #endregion

    }
    #endregion

}
