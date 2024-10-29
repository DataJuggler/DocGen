

#region using statements

using DataJuggler.DocGen.ObjectLibrary.BusinessObjects;
using DataJuggler.DocGen.ObjectLibrary.Enumerations;
using System;
using System.Collections.Generic;
using System.Data;

#endregion


namespace DataJuggler.DocGen.DataAccessComponent.Data.Readers
{

    #region class CodePropertyReader
    /// <summary>
    /// This class loads a single 'CodeProperty' object or a list of type <CodeProperty>.
    /// </summary>
    public class CodePropertyReader
    {

        #region Static Methods

            #region Load(DataRow dataRow)
            /// <summary>
            /// This method loads a 'CodeProperty' object
            /// from the dataRow passed in.
            /// </summary>
            /// <param name='dataRow'>The 'DataRow' to load from.</param>
            /// <returns>A 'CodeProperty' DataObject.</returns>
            public static CodeProperty Load(DataRow dataRow)
            {
                // Initial Value
                CodeProperty codeProperty = new CodeProperty();

                // Create field Integers
                int codeClassIdfield = 0;
                int codeFileIdfield = 1;
                int descriptionfield = 2;
                int endLineNumberfield = 3;
                int idfield = 4;
                int namefield = 5;
                int returnTypefield = 6;
                int startLineNumberfield = 7;
                int statusfield = 8;
                int tagsfield = 9;
                int visiblefield = 10;

                try
                {
                    // Load Each field
                    codeProperty.CodeClassId = DataHelper.ParseInteger(dataRow.ItemArray[codeClassIdfield], 0);
                    codeProperty.CodeFileId = DataHelper.ParseInteger(dataRow.ItemArray[codeFileIdfield], 0);
                    codeProperty.Description = DataHelper.ParseString(dataRow.ItemArray[descriptionfield]);
                    codeProperty.EndLineNumber = DataHelper.ParseInteger(dataRow.ItemArray[endLineNumberfield], 0);
                    codeProperty.UpdateIdentity(DataHelper.ParseInteger(dataRow.ItemArray[idfield], 0));
                    codeProperty.Name = DataHelper.ParseString(dataRow.ItemArray[namefield]);
                    codeProperty.ReturnType = DataHelper.ParseString(dataRow.ItemArray[returnTypefield]);
                    codeProperty.StartLineNumber = DataHelper.ParseInteger(dataRow.ItemArray[startLineNumberfield], 0);
                    codeProperty.Status = DataHelper.ParseInteger(dataRow.ItemArray[statusfield], 0);
                    codeProperty.Tags = DataHelper.ParseString(dataRow.ItemArray[tagsfield]);
                    codeProperty.Visible = DataHelper.ParseBoolean(dataRow.ItemArray[visiblefield], false);
                }
                catch
                {
                }

                // return value
                return codeProperty;
            }
            #endregion

            #region LoadCollection(DataTable dataTable)
            /// <summary>
            /// This method loads a collection of 'CodeProperty' objects.
            /// from the dataTable.Rows object passed in.
            /// </summary>
            /// <param name='dataTable'>The 'DataTable.Rows' to load from.</param>
            /// <returns>A CodeProperty Collection.</returns>
            public static List<CodeProperty> LoadCollection(DataTable dataTable)
            {
                // Initial Value
                List<CodeProperty> codePropertys = new List<CodeProperty>();

                try
                {
                    // Load Each row In DataTable
                    foreach (DataRow row in dataTable.Rows)
                    {
                        // Create 'CodeProperty' from rows
                        CodeProperty codeProperty = Load(row);

                        // Add this object to collection
                        codePropertys.Add(codeProperty);
                    }
                }
                catch
                {
                }

                // return value
                return codePropertys;
            }
            #endregion

        #endregion

    }
    #endregion

}
