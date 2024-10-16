

#region using statements

using ObjectLibrary.BusinessObjects;
using ObjectLibrary.Enumerations;
using System;
using System.Collections.Generic;
using System.Data;

#endregion


namespace DataAccessComponent.Data.Readers
{

    #region class CodeSampleReader
    /// <summary>
    /// This class loads a single 'CodeSample' object or a list of type <CodeSample>.
    /// </summary>
    public class CodeSampleReader
    {

        #region Static Methods

            #region Load(DataRow dataRow)
            /// <summary>
            /// This method loads a 'CodeSample' object
            /// from the dataRow passed in.
            /// </summary>
            /// <param name='dataRow'>The 'DataRow' to load from.</param>
            /// <returns>A 'CodeSample' DataObject.</returns>
            public static CodeSample Load(DataRow dataRow)
            {
                // Initial Value
                CodeSample codeSample = new CodeSample();

                // Create field Integers
                int codeTypefield = 0;
                int idfield = 1;
                int parentIdfield = 2;
                int parentTypefield = 3;
                int statusfield = 4;
                int textfield = 5;
                int visiblefield = 6;

                try
                {
                    // Load Each field
                    codeSample.CodeType = DataHelper.ParseInteger(dataRow.ItemArray[codeTypefield], 0);
                    codeSample.UpdateIdentity(DataHelper.ParseInteger(dataRow.ItemArray[idfield], 0));
                    codeSample.ParentId = DataHelper.ParseInteger(dataRow.ItemArray[parentIdfield], 0);
                    codeSample.ParentType = (ObjectTypeEnum) DataHelper.ParseInteger(dataRow.ItemArray[parentTypefield], 0);
                    codeSample.Status = DataHelper.ParseInteger(dataRow.ItemArray[statusfield], 0);
                    codeSample.Text = DataHelper.ParseString(dataRow.ItemArray[textfield]);
                    codeSample.Visible = DataHelper.ParseBoolean(dataRow.ItemArray[visiblefield], false);
                }
                catch
                {
                }

                // return value
                return codeSample;
            }
            #endregion

            #region LoadCollection(DataTable dataTable)
            /// <summary>
            /// This method loads a collection of 'CodeSample' objects.
            /// from the dataTable.Rows object passed in.
            /// </summary>
            /// <param name='dataTable'>The 'DataTable.Rows' to load from.</param>
            /// <returns>A CodeSample Collection.</returns>
            public static List<CodeSample> LoadCollection(DataTable dataTable)
            {
                // Initial Value
                List<CodeSample> codeSamples = new List<CodeSample>();

                try
                {
                    // Load Each row In DataTable
                    foreach (DataRow row in dataTable.Rows)
                    {
                        // Create 'CodeSample' from rows
                        CodeSample codeSample = Load(row);

                        // Add this object to collection
                        codeSamples.Add(codeSample);
                    }
                }
                catch
                {
                }

                // return value
                return codeSamples;
            }
            #endregion

        #endregion

    }
    #endregion

}
