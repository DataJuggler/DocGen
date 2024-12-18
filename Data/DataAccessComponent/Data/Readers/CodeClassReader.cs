

#region using statements

using DataJuggler.DocGen.ObjectLibrary.BusinessObjects;
using DataJuggler.DocGen.ObjectLibrary.Enumerations;
using System;
using System.Collections.Generic;
using System.Data;

#endregion


namespace DataJuggler.DocGen.DataAccessComponent.Data.Readers
{

    #region class CodeClassReader
    /// <summary>
    /// This class loads a single 'CodeClass' object or a list of type <CodeClass>.
    /// </summary>
    public class CodeClassReader
    {

        #region Static Methods

            #region Load(DataRow dataRow)
            /// <summary>
            /// This method loads a 'CodeClass' object
            /// from the dataRow passed in.
            /// </summary>
            /// <param name='dataRow'>The 'DataRow' to load from.</param>
            /// <returns>A 'CodeClass' DataObject.</returns>
            public static CodeClass Load(DataRow dataRow)
            {
                // Initial Value
                CodeClass codeClass = new CodeClass();

                // Create field Integers
                int codeFileIdfield = 0;
                int descriptionfield = 1;
                int idfield = 2;
                int isPartialfield = 3;
                int namefield = 4;
                int statusfield = 5;
                int tagsfield = 6;
                int visiblefield = 7;

                try
                {
                    // Load Each field
                    codeClass.CodeFileId = DataHelper.ParseInteger(dataRow.ItemArray[codeFileIdfield], 0);
                    codeClass.Description = DataHelper.ParseString(dataRow.ItemArray[descriptionfield]);
                    codeClass.UpdateIdentity(DataHelper.ParseInteger(dataRow.ItemArray[idfield], 0));
                    codeClass.IsPartial = DataHelper.ParseBoolean(dataRow.ItemArray[isPartialfield], false);
                    codeClass.Name = DataHelper.ParseString(dataRow.ItemArray[namefield]);
                    codeClass.Status = DataHelper.ParseInteger(dataRow.ItemArray[statusfield], 0);
                    codeClass.Tags = DataHelper.ParseString(dataRow.ItemArray[tagsfield]);
                    codeClass.Visible = DataHelper.ParseBoolean(dataRow.ItemArray[visiblefield], false);
                }
                catch
                {
                }

                // return value
                return codeClass;
            }
            #endregion

            #region LoadCollection(DataTable dataTable)
            /// <summary>
            /// This method loads a collection of 'CodeClass' objects.
            /// from the dataTable.Rows object passed in.
            /// </summary>
            /// <param name='dataTable'>The 'DataTable.Rows' to load from.</param>
            /// <returns>A CodeClass Collection.</returns>
            public static List<CodeClass> LoadCollection(DataTable dataTable)
            {
                // Initial Value
                List<CodeClass> codeClass = new List<CodeClass>();

                try
                {
                    // Load Each row In DataTable
                    foreach (DataRow row in dataTable.Rows)
                    {
                        // Create 'CodeClass' from rows
                        CodeClass codeClas = Load(row);

                        // Add this object to collection
                        codeClass.Add(codeClas);
                    }
                }
                catch
                {
                }

                // return value
                return codeClass;
            }
            #endregion

        #endregion

    }
    #endregion

}
