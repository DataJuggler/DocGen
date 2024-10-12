

#region using statements

using ObjectLibrary.BusinessObjects;
using ObjectLibrary.Enumerations;
using System;
using System.Collections.Generic;
using System.Data;

#endregion


namespace DataAccessComponent.Data.Readers
{

    #region class CodeParameterReader
    /// <summary>
    /// This class loads a single 'CodeParameter' object or a list of type <CodeParameter>.
    /// </summary>
    public class CodeParameterReader
    {

        #region Static Methods

            #region Load(DataRow dataRow)
            /// <summary>
            /// This method loads a 'CodeParameter' object
            /// from the dataRow passed in.
            /// </summary>
            /// <param name='dataRow'>The 'DataRow' to load from.</param>
            /// <returns>A 'CodeParameter' DataObject.</returns>
            public static CodeParameter Load(DataRow dataRow)
            {
                // Initial Value
                CodeParameter codeParameter = new CodeParameter();

                // Create field Integers
                int codeEventIdfield = 0;
                int codeMethodIdfield = 1;
                int descriptionfield = 2;
                int idfield = 3;
                int isOptionalfield = 4;
                int namefield = 5;
                int parameterTypefield = 6;

                try
                {
                    // Load Each field
                    codeParameter.CodeEventId = DataHelper.ParseInteger(dataRow.ItemArray[codeEventIdfield], 0);
                    codeParameter.CodeMethodId = DataHelper.ParseInteger(dataRow.ItemArray[codeMethodIdfield], 0);
                    codeParameter.Description = DataHelper.ParseString(dataRow.ItemArray[descriptionfield]);
                    codeParameter.UpdateIdentity(DataHelper.ParseInteger(dataRow.ItemArray[idfield], 0));
                    codeParameter.IsOptional = DataHelper.ParseBoolean(dataRow.ItemArray[isOptionalfield], false);
                    codeParameter.Name = DataHelper.ParseString(dataRow.ItemArray[namefield]);
                    codeParameter.ParameterType = DataHelper.ParseString(dataRow.ItemArray[parameterTypefield]);
                }
                catch
                {
                }

                // return value
                return codeParameter;
            }
            #endregion

            #region LoadCollection(DataTable dataTable)
            /// <summary>
            /// This method loads a collection of 'CodeParameter' objects.
            /// from the dataTable.Rows object passed in.
            /// </summary>
            /// <param name='dataTable'>The 'DataTable.Rows' to load from.</param>
            /// <returns>A CodeParameter Collection.</returns>
            public static List<CodeParameter> LoadCollection(DataTable dataTable)
            {
                // Initial Value
                List<CodeParameter> codeParameters = new List<CodeParameter>();

                try
                {
                    // Load Each row In DataTable
                    foreach (DataRow row in dataTable.Rows)
                    {
                        // Create 'CodeParameter' from rows
                        CodeParameter codeParameter = Load(row);

                        // Add this object to collection
                        codeParameters.Add(codeParameter);
                    }
                }
                catch
                {
                }

                // return value
                return codeParameters;
            }
            #endregion

        #endregion

    }
    #endregion

}
