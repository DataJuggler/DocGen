

#region using statements

using ObjectLibrary.BusinessObjects;
using ObjectLibrary.Enumerations;
using System;
using System.Collections.Generic;
using System.Data;

#endregion


namespace DataAccessComponent.Data.Readers
{

    #region class CodeMethodReader
    /// <summary>
    /// This class loads a single 'CodeMethod' object or a list of type <CodeMethod>.
    /// </summary>
    public class CodeMethodReader
    {

        #region Static Methods

            #region Load(DataRow dataRow)
            /// <summary>
            /// This method loads a 'CodeMethod' object
            /// from the dataRow passed in.
            /// </summary>
            /// <param name='dataRow'>The 'DataRow' to load from.</param>
            /// <returns>A 'CodeMethod' DataObject.</returns>
            public static CodeMethod Load(DataRow dataRow)
            {
                // Initial Value
                CodeMethod codeMethod = new CodeMethod();

                // Create field Integers
                int codeClassIdfield = 0;
                int codeFileIdfield = 1;
                int descriptionfield = 2;
                int endLineNumberfield = 3;
                int idfield = 4;
                int namefield = 5;
                int referencedByPathfield = 6;
                int returnTypefield = 7;
                int startLineNumberfield = 8;
                int statusfield = 9;

                try
                {
                    // Load Each field
                    codeMethod.CodeClassId = DataHelper.ParseInteger(dataRow.ItemArray[codeClassIdfield], 0);
                    codeMethod.CodeFileId = DataHelper.ParseInteger(dataRow.ItemArray[codeFileIdfield], 0);
                    codeMethod.Description = DataHelper.ParseString(dataRow.ItemArray[descriptionfield]);
                    codeMethod.EndLineNumber = DataHelper.ParseInteger(dataRow.ItemArray[endLineNumberfield], 0);
                    codeMethod.UpdateIdentity(DataHelper.ParseInteger(dataRow.ItemArray[idfield], 0));
                    codeMethod.Name = DataHelper.ParseString(dataRow.ItemArray[namefield]);
                    codeMethod.ReferencedByPath = DataHelper.ParseString(dataRow.ItemArray[referencedByPathfield]);
                    codeMethod.ReturnType = DataHelper.ParseString(dataRow.ItemArray[returnTypefield]);
                    codeMethod.StartLineNumber = DataHelper.ParseInteger(dataRow.ItemArray[startLineNumberfield], 0);
                    codeMethod.Status = DataHelper.ParseInteger(dataRow.ItemArray[statusfield], 0);
                }
                catch
                {
                }

                // return value
                return codeMethod;
            }
            #endregion

            #region LoadCollection(DataTable dataTable)
            /// <summary>
            /// This method loads a collection of 'CodeMethod' objects.
            /// from the dataTable.Rows object passed in.
            /// </summary>
            /// <param name='dataTable'>The 'DataTable.Rows' to load from.</param>
            /// <returns>A CodeMethod Collection.</returns>
            public static List<CodeMethod> LoadCollection(DataTable dataTable)
            {
                // Initial Value
                List<CodeMethod> codeMethods = new List<CodeMethod>();

                try
                {
                    // Load Each row In DataTable
                    foreach (DataRow row in dataTable.Rows)
                    {
                        // Create 'CodeMethod' from rows
                        CodeMethod codeMethod = Load(row);

                        // Add this object to collection
                        codeMethods.Add(codeMethod);
                    }
                }
                catch
                {
                }

                // return value
                return codeMethods;
            }
            #endregion

        #endregion

    }
    #endregion

}
