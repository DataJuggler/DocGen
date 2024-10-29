

#region using statements

using DataJuggler.DocGen.ObjectLibrary.BusinessObjects;
using DataJuggler.DocGen.ObjectLibrary.Enumerations;
using System;
using System.Collections.Generic;
using System.Data;

#endregion


namespace DataJuggler.DocGen.DataAccessComponent.Data.Readers
{

    #region class CodeFileReader
    /// <summary>
    /// This class loads a single 'CodeFile' object or a list of type <CodeFile>.
    /// </summary>
    public class CodeFileReader
    {

        #region Static Methods

            #region Load(DataRow dataRow)
            /// <summary>
            /// This method loads a 'CodeFile' object
            /// from the dataRow passed in.
            /// </summary>
            /// <param name='dataRow'>The 'DataRow' to load from.</param>
            /// <returns>A 'CodeFile' DataObject.</returns>
            public static CodeFile Load(DataRow dataRow)
            {
                // Initial Value
                CodeFile codeFile = new CodeFile();

                // Create field Integers
                int descriptionfield = 0;
                int eventsCountfield = 1;
                int fullPathfield = 2;
                int idfield = 3;
                int methodsCountfield = 4;
                int namefield = 5;
                int parentIdfield = 6;
                int projectIdfield = 7;
                int propertiesCountfield = 8;
                int statusfield = 9;
                int visiblefield = 10;

                try
                {
                    // Load Each field
                    codeFile.Description = DataHelper.ParseString(dataRow.ItemArray[descriptionfield]);
                    codeFile.EventsCount = DataHelper.ParseInteger(dataRow.ItemArray[eventsCountfield], 0);
                    codeFile.FullPath = DataHelper.ParseString(dataRow.ItemArray[fullPathfield]);
                    codeFile.UpdateIdentity(DataHelper.ParseInteger(dataRow.ItemArray[idfield], 0));
                    codeFile.MethodsCount = DataHelper.ParseInteger(dataRow.ItemArray[methodsCountfield], 0);
                    codeFile.Name = DataHelper.ParseString(dataRow.ItemArray[namefield]);
                    codeFile.ParentId = DataHelper.ParseInteger(dataRow.ItemArray[parentIdfield], 0);
                    codeFile.ProjectId = DataHelper.ParseInteger(dataRow.ItemArray[projectIdfield], 0);
                    codeFile.PropertiesCount = DataHelper.ParseInteger(dataRow.ItemArray[propertiesCountfield], 0);
                    codeFile.Status = DataHelper.ParseInteger(dataRow.ItemArray[statusfield], 0);
                    codeFile.Visible = DataHelper.ParseBoolean(dataRow.ItemArray[visiblefield], false);
                }
                catch
                {
                }

                // return value
                return codeFile;
            }
            #endregion

            #region LoadCollection(DataTable dataTable)
            /// <summary>
            /// This method loads a collection of 'CodeFile' objects.
            /// from the dataTable.Rows object passed in.
            /// </summary>
            /// <param name='dataTable'>The 'DataTable.Rows' to load from.</param>
            /// <returns>A CodeFile Collection.</returns>
            public static List<CodeFile> LoadCollection(DataTable dataTable)
            {
                // Initial Value
                List<CodeFile> codeFiles = new List<CodeFile>();

                try
                {
                    // Load Each row In DataTable
                    foreach (DataRow row in dataTable.Rows)
                    {
                        // Create 'CodeFile' from rows
                        CodeFile codeFile = Load(row);

                        // Add this object to collection
                        codeFiles.Add(codeFile);
                    }
                }
                catch
                {
                }

                // return value
                return codeFiles;
            }
            #endregion

        #endregion

    }
    #endregion

}
