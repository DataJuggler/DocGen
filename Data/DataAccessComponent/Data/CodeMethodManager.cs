

#region using statements

using DataAccessComponent.Data.Readers;
using DataAccessComponent.StoredProcedureManager.DeleteProcedures;
using DataAccessComponent.StoredProcedureManager.FetchProcedures;
using DataAccessComponent.StoredProcedureManager.InsertProcedures;
using DataAccessComponent.StoredProcedureManager.UpdateProcedures;
using ObjectLibrary.BusinessObjects;
using System;
using System.Collections.Generic;
using System.Data;

#endregion


namespace DataAccessComponent.Data
{

    #region class CodeMethodManager
    /// <summary>
    /// This class is used to manage a 'CodeMethod' object.
    /// </summary>
    public class CodeMethodManager
    {

        #region Private Variables
        private DataManager dataManager;
        private DataHelper dataHelper;
        #endregion

        #region Constructor
        /// <summary>
        /// Create a new instance of a 'CodeMethodManager' object.
        /// </summary>
        public CodeMethodManager(DataManager dataManagerArg)
        {
            // Set DataManager
            this.DataManager = dataManagerArg;

            // Perform Initialization
            Init();
        }
        #endregion

        #region Methods

            #region DeleteCodeMethod()
            /// <summary>
            /// This method deletes a 'CodeMethod' object.
            /// </summary>
            /// <returns>True if successful false if not.</returns>
            /// </summary>
            public bool DeleteCodeMethod(DeleteCodeMethodStoredProcedure deleteCodeMethodProc, DataConnector databaseConnector)
            {
                // Initial Value
                bool deleted = false;

                // Verify database connection is connected
                if ((databaseConnector != null) && (databaseConnector.Connected))
                {
                    // Execute Non Query
                    deleted = this.DataHelper.DeleteRecord(deleteCodeMethodProc, databaseConnector);
                }

                // return value
                return deleted;
            }
            #endregion

            #region FetchAllCodeMethods()
            /// <summary>
            /// This method fetches a  'List<CodeMethod>' object.
            /// This method uses the 'CodeMethods_FetchAll' procedure.
            /// </summary>
            /// <returns>A 'List<CodeMethod>'</returns>
            /// </summary>
            public List<CodeMethod> FetchAllCodeMethods(FetchAllCodeMethodsStoredProcedure fetchAllCodeMethodsProc, DataConnector databaseConnector)
            {
                // Initial Value
                List<CodeMethod> codeMethodCollection = null;

                // Verify database connection is connected
                if ((databaseConnector != null) && (databaseConnector.Connected))
                {
                    // First Get Dataset
                    DataSet allCodeMethodsDataSet = this.DataHelper.LoadDataSet(fetchAllCodeMethodsProc, databaseConnector);

                    // Verify DataSet Exists
                    if(allCodeMethodsDataSet != null)
                    {
                        // Get DataTable From DataSet
                        DataTable table = this.DataHelper.ReturnFirstTable(allCodeMethodsDataSet);

                        // if table exists
                        if(table != null)
                        {
                            // Load Collection
                            codeMethodCollection = CodeMethodReader.LoadCollection(table);
                        }
                    }
                }

                // return value
                return codeMethodCollection;
            }
            #endregion

            #region FindCodeMethod()
            /// <summary>
            /// This method finds a  'CodeMethod' object.
            /// This method uses the 'CodeMethod_Find' procedure.
            /// </summary>
            /// <returns>A 'CodeMethod' object.</returns>
            /// </summary>
            public CodeMethod FindCodeMethod(FindCodeMethodStoredProcedure findCodeMethodProc, DataConnector databaseConnector)
            {
                // Initial Value
                CodeMethod codeMethod = null;

                // Verify database connection is connected
                if ((databaseConnector != null) && (databaseConnector.Connected))
                {
                    // First Get Dataset
                    DataSet codeMethodDataSet = this.DataHelper.LoadDataSet(findCodeMethodProc, databaseConnector);

                    // Verify DataSet Exists
                    if(codeMethodDataSet != null)
                    {
                        // Get DataTable From DataSet
                        DataRow row = this.DataHelper.ReturnFirstRow(codeMethodDataSet);

                        // if row exists
                        if(row != null)
                        {
                            // Load CodeMethod
                            codeMethod = CodeMethodReader.Load(row);
                        }
                    }
                }

                // return value
                return codeMethod;
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

            #region InsertCodeMethod()
            /// <summary>
            /// This method inserts a 'CodeMethod' object.
            /// This method uses the 'CodeMethod_Insert' procedure.
            /// </summary>
            /// <returns>The identity value of the new record.</returns>
            /// </summary>
            public int InsertCodeMethod(InsertCodeMethodStoredProcedure insertCodeMethodProc, DataConnector databaseConnector)
            {
                // Initial Value
                int newIdentity = -1;

                // Verify database connection is connected
                if ((databaseConnector != null) && (databaseConnector.Connected))
                {
                    // Execute Non Query
                    newIdentity = this.DataHelper.InsertRecord(insertCodeMethodProc, databaseConnector);
                }

                // return value
                return newIdentity;
            }
            #endregion

            #region UpdateCodeMethod()
            /// <summary>
            /// This method updates a 'CodeMethod'.
            /// This method uses the 'CodeMethod_Update' procedure.
            /// </summary>
            /// <returns>True if successful false if not.</returns>
            /// </summary>
            public bool UpdateCodeMethod(UpdateCodeMethodStoredProcedure updateCodeMethodProc, DataConnector databaseConnector)
            {
                // Initial Value
                bool saved = false;

                // Verify database connection is connected
                if ((databaseConnector != null) && (databaseConnector.Connected))
                {
                    // Execute Update.
                    saved = this.DataHelper.UpdateRecord(updateCodeMethodProc, databaseConnector);
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
