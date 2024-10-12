

#region using statements

using ObjectLibrary.BusinessObjects;
using ObjectLibrary.Enumerations;
using System;
using System.Collections.Generic;
using System.Data;

#endregion


namespace DataAccessComponent.Data.Readers
{

    #region class CodeEventReader
    /// <summary>
    /// This class loads a single 'CodeEvent' object or a list of type <CodeEvent>.
    /// </summary>
    public class CodeEventReader
    {

        #region Static Methods

            #region Load(DataRow dataRow)
            /// <summary>
            /// This method loads a 'CodeEvent' object
            /// from the dataRow passed in.
            /// </summary>
            /// <param name='dataRow'>The 'DataRow' to load from.</param>
            /// <returns>A 'CodeEvent' DataObject.</returns>
            public static CodeEvent Load(DataRow dataRow)
            {
                // Initial Value
                CodeEvent codeEvent = new CodeEvent();

                // Create field Integers
                int codeFileIdfield = 0;
                int descriptionfield = 1;
                int endLineNumberfield = 2;
                int idfield = 3;
                int namefield = 4;
                int startLineNumberfield = 5;
                int statusfield = 6;

                try
                {
                    // Load Each field
                    codeEvent.CodeFileId = DataHelper.ParseInteger(dataRow.ItemArray[codeFileIdfield], 0);
                    codeEvent.Description = DataHelper.ParseString(dataRow.ItemArray[descriptionfield]);
                    codeEvent.EndLineNumber = DataHelper.ParseInteger(dataRow.ItemArray[endLineNumberfield], 0);
                    codeEvent.UpdateIdentity(DataHelper.ParseInteger(dataRow.ItemArray[idfield], 0));
                    codeEvent.Name = DataHelper.ParseString(dataRow.ItemArray[namefield]);
                    codeEvent.StartLineNumber = DataHelper.ParseInteger(dataRow.ItemArray[startLineNumberfield], 0);
                    codeEvent.Status = DataHelper.ParseInteger(dataRow.ItemArray[statusfield], 0);
                }
                catch
                {
                }

                // return value
                return codeEvent;
            }
            #endregion

            #region LoadCollection(DataTable dataTable)
            /// <summary>
            /// This method loads a collection of 'CodeEvent' objects.
            /// from the dataTable.Rows object passed in.
            /// </summary>
            /// <param name='dataTable'>The 'DataTable.Rows' to load from.</param>
            /// <returns>A CodeEvent Collection.</returns>
            public static List<CodeEvent> LoadCollection(DataTable dataTable)
            {
                // Initial Value
                List<CodeEvent> codeEvents = new List<CodeEvent>();

                try
                {
                    // Load Each row In DataTable
                    foreach (DataRow row in dataTable.Rows)
                    {
                        // Create 'CodeEvent' from rows
                        CodeEvent codeEvent = Load(row);

                        // Add this object to collection
                        codeEvents.Add(codeEvent);
                    }
                }
                catch
                {
                }

                // return value
                return codeEvents;
            }
            #endregion

        #endregion

    }
    #endregion

}
