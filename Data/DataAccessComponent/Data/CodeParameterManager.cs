

#region using statements

using DataJuggler.DocGen.DataAccessComponent.Data.Readers;
using DataJuggler.DocGen.DataAccessComponent.StoredProcedureManager.DeleteProcedures;
using DataJuggler.DocGen.DataAccessComponent.StoredProcedureManager.FetchProcedures;
using DataJuggler.DocGen.DataAccessComponent.StoredProcedureManager.InsertProcedures;
using DataJuggler.DocGen.DataAccessComponent.StoredProcedureManager.UpdateProcedures;
using DataJuggler.DocGen.ObjectLibrary.BusinessObjects;
using System;
using System.Collections.Generic;
using System.Data;

#endregion


namespace DataJuggler.DocGen.DataAccessComponent.Data
{

    #region class CodeParameterManager
    /// <summary>
    /// This class is used to manage a 'CodeParameter' object.
    /// </summary>
    public class CodeParameterManager
    {

        #region Private Variables
        private DataManager dataManager;
        private DataHelper dataHelper;
        #endregion

        #region Constructor
        /// <summary>
        /// Create a new instance of a 'CodeParameterManager' object.
        /// </summary>
        public CodeParameterManager(DataManager dataManagerArg)
        {
            // Set DataManager
            this.DataManager = dataManagerArg;

            // Perform Initialization
            Init();
        }
        #endregion

        #region Methods

            #region DeleteCodeParameter()
            /// <summary>
            /// This method deletes a 'CodeParameter' object.
            /// </summary>
            /// <returns>True if successful false if not.</returns>
            /// </summary>
            public bool DeleteCodeParameter(DeleteCodeParameterStoredProcedure deleteCodeParameterProc, DataConnector databaseConnector)
            {
                // Initial Value
                bool deleted = false;

                // Verify database connection is connected
                if ((databaseConnector != null) && (databaseConnector.Connected))
                {
                    // Execute Non Query
                    deleted = this.DataHelper.DeleteRecord(deleteCodeParameterProc, databaseConnector);
                }

                // return value
                return deleted;
            }
            #endregion

            #region FetchAllCodeParameters()
            /// <summary>
            /// This method fetches a  'List<CodeParameter>' object.
            /// This method uses the 'CodeParameters_FetchAll' procedure.
            /// </summary>
            /// <returns>A 'List<CodeParameter>'</returns>
            /// </summary>
            public List<CodeParameter> FetchAllCodeParameters(FetchAllCodeParametersStoredProcedure fetchAllCodeParametersProc, DataConnector databaseConnector)
            {
                // Initial Value
                List<CodeParameter> codeParameterCollection = null;

                // Verify database connection is connected
                if ((databaseConnector != null) && (databaseConnector.Connected))
                {
                    // First Get Dataset
                    DataSet allCodeParametersDataSet = this.DataHelper.LoadDataSet(fetchAllCodeParametersProc, databaseConnector);

                    // Verify DataSet Exists
                    if(allCodeParametersDataSet != null)
                    {
                        // Get DataTable From DataSet
                        DataTable table = this.DataHelper.ReturnFirstTable(allCodeParametersDataSet);

                        // if table exists
                        if(table != null)
                        {
                            // Load Collection
                            codeParameterCollection = CodeParameterReader.LoadCollection(table);
                        }
                    }
                }

                // return value
                return codeParameterCollection;
            }
            #endregion

            #region FindCodeParameter()
            /// <summary>
            /// This method finds a  'CodeParameter' object.
            /// This method uses the 'CodeParameter_Find' procedure.
            /// </summary>
            /// <returns>A 'CodeParameter' object.</returns>
            /// </summary>
            public CodeParameter FindCodeParameter(FindCodeParameterStoredProcedure findCodeParameterProc, DataConnector databaseConnector)
            {
                // Initial Value
                CodeParameter codeParameter = null;

                // Verify database connection is connected
                if ((databaseConnector != null) && (databaseConnector.Connected))
                {
                    // First Get Dataset
                    DataSet codeParameterDataSet = this.DataHelper.LoadDataSet(findCodeParameterProc, databaseConnector);

                    // Verify DataSet Exists
                    if(codeParameterDataSet != null)
                    {
                        // Get DataTable From DataSet
                        DataRow row = this.DataHelper.ReturnFirstRow(codeParameterDataSet);

                        // if row exists
                        if(row != null)
                        {
                            // Load CodeParameter
                            codeParameter = CodeParameterReader.Load(row);
                        }
                    }
                }

                // return value
                return codeParameter;
            }
            #endregion

            #region Init()
            /// <summary>
            /// Perorm Initialization For This Object
            /// </summary>
            private void Init()
            {
                // Create DataHelper object
                this.DataHelper = new DataHelper();
            }
            #endregion

            #region InsertCodeParameter()
            /// <summary>
            /// This method inserts a 'CodeParameter' object.
            /// This method uses the 'CodeParameter_Insert' procedure.
            /// </summary>
            /// <returns>The identity value of the new record.</returns>
            /// </summary>
            public int InsertCodeParameter(InsertCodeParameterStoredProcedure insertCodeParameterProc, DataConnector databaseConnector)
            {
                // Initial Value
                int newIdentity = -1;

                // Verify database connection is connected
                if ((databaseConnector != null) && (databaseConnector.Connected))
                {
                    // Execute Non Query
                    newIdentity = this.DataHelper.InsertRecord(insertCodeParameterProc, databaseConnector);
                }

                // return value
                return newIdentity;
            }
            #endregion

            #region UpdateCodeParameter()
            /// <summary>
            /// This method updates a 'CodeParameter'.
            /// This method uses the 'CodeParameter_Update' procedure.
            /// </summary>
            /// <returns>True if successful false if not.</returns>
            /// </summary>
            public bool UpdateCodeParameter(UpdateCodeParameterStoredProcedure updateCodeParameterProc, DataConnector databaseConnector)
            {
                // Initial Value
                bool saved = false;

                // Verify database connection is connected
                if ((databaseConnector != null) && (databaseConnector.Connected))
                {
                    // Execute Update.
                    saved = this.DataHelper.UpdateRecord(updateCodeParameterProc, databaseConnector);
                }

                // return value
                return saved;
            }
            #endregion

        #endregion

        #region Properties

            #region DataHelper
            /// <summary>
            /// This object uses the Microsoft Data
            /// Application Block to execute stored
            /// procedures.
            /// </summary>
            internal DataHelper DataHelper
            {
                get { return dataHelper; }
                set { dataHelper = value; }
            }
            #endregion

            #region DataManager
            /// <summary>
            /// A reference to this objects parent.
            /// </summary>
            internal DataManager DataManager
            {
                get { return dataManager; }
                set { dataManager = value; }
            }
            #endregion

        #endregion

    }
    #endregion

}
