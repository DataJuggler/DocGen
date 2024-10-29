

#region using statements

using DataJuggler.DocGen.ObjectLibrary.BusinessObjects;
using DataJuggler.DocGen.ObjectLibrary.Enumerations;
using System;
using System.Collections.Generic;
using System.Data;

#endregion


namespace DataJuggler.DocGen.DataAccessComponent.Data.Readers
{

    #region class CodeConstructorReader
    /// <summary>
    /// This class loads a single 'CodeConstructor' object or a list of type <CodeConstructor>.
    /// </summary>
    public class CodeConstructorReader
    {

        #region Static Methods

            #region Load(DataRow dataRow)
            /// <summary>
            /// This method loads a 'CodeConstructor' object
            /// from the dataRow passed in.
            /// </summary>
            /// <param name='dataRow'>The 'DataRow' to load from.</param>
            /// <returns>A 'CodeConstructor' DataObject.</returns>
            public static CodeConstructor Load(DataRow dataRow)
            {
                // Initial Value
                CodeConstructor codeConstructor = new CodeConstructor();

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
                int visiblefield = 9;

                try
                {
                    // Load Each field
                    codeConstructor.CodeClassId = DataHelper.ParseInteger(dataRow.ItemArray[codeClassIdfield], 0);
                    codeConstructor.CodeFileId = DataHelper.ParseInteger(dataRow.ItemArray[codeFileIdfield], 0);
                    codeConstructor.Description = DataHelper.ParseString(dataRow.ItemArray[descriptionfield]);
                    codeConstructor.EndLineNumber = DataHelper.ParseInteger(dataRow.ItemArray[endLineNumberfield], 0);
                    codeConstructor.UpdateIdentity(DataHelper.ParseInteger(dataRow.ItemArray[idfield], 0));
                    codeConstructor.Name = DataHelper.ParseString(dataRow.ItemArray[namefield]);
                    codeConstructor.ReturnType = DataHelper.ParseString(dataRow.ItemArray[returnTypefield]);
                    codeConstructor.StartLineNumber = DataHelper.ParseInteger(dataRow.ItemArray[startLineNumberfield], 0);
                    codeConstructor.Status = DataHelper.ParseInteger(dataRow.ItemArray[statusfield], 0);
                    codeConstructor.Visible = DataHelper.ParseBoolean(dataRow.ItemArray[visiblefield], false);
                }
                catch
                {
                }

                // return value
                return codeConstructor;
            }
            #endregion

            #region LoadCollection(DataTable dataTable)
            /// <summary>
            /// This method loads a collection of 'CodeConstructor' objects.
            /// from the dataTable.Rows object passed in.
            /// </summary>
            /// <param name='dataTable'>The 'DataTable.Rows' to load from.</param>
            /// <returns>A CodeConstructor Collection.</returns>
            public static List<CodeConstructor> LoadCollection(DataTable dataTable)
            {
                // Initial Value
                List<CodeConstructor> codeConstructors = new List<CodeConstructor>();

                try
                {
                    // Load Each row In DataTable
                    foreach (DataRow row in dataTable.Rows)
                    {
                        // Create 'CodeConstructor' from rows
                        CodeConstructor codeConstructor = Load(row);

                        // Add this object to collection
                        codeConstructors.Add(codeConstructor);
                    }
                }
                catch
                {
                }

                // return value
                return codeConstructors;
            }
            #endregion

        #endregion

    }
    #endregion

}
