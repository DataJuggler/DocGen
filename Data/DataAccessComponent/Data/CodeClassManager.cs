

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

    #region class CodeClassManager
    /// <summary>
    /// This class is used to manage a 'CodeClass' object.
    /// </summary>
    public class CodeClassManager
    {

        #region Private Variables
        private DataManager dataManager;
        private DataHelper dataHelper;
        #endregion

        #region Constructor
        /// <summary>
        /// Create a new instance of a 'CodeClassManager' object.
        /// </summary>
        public CodeClassManager(DataManager dataManagerArg)
        {
            // Set DataManager
            this.DataManager = dataManagerArg;

            // Perform Initialization
            Init();
        }
        #endregion

        #region Methods

            #region DeleteCodeClass()
            /// <summary>
            /// This method deletes a 'CodeClass' object.
            /// </summary>
            /// <returns>True if successful false if not.</returns>
            /// </summary>
            public bool DeleteCodeClass(DeleteCodeClassStoredProcedure deleteCodeClassProc, DataConnector databaseConnector)
            {
                // Initial Value
                bool deleted = false;

                // Verify database connection is connected
                if ((databaseConnector != null) && (databaseConnector.Connected))
                {
                    // Execute Non Query
                    deleted = this.DataHelper.DeleteRecord(deleteCodeClassProc, databaseConnector);
                }

                // return value
                return deleted;
            }
            #endregion

            #region FetchAllCodeClass()
            /// <summary>
            /// This method fetches a  'List<CodeClass>' object.
            /// This method uses the 'CodeClass_FetchAll' procedure.
            /// </summary>
            /// <returns>A 'List<CodeClass>'</returns>
            /// </summary>
            public List<CodeClass> FetchAllCodeClass(FetchAllCodeClassStoredProcedure fetchAllCodeClassProc, DataConnector databaseConnector)
            {
                // Initial Value
                List<CodeClass> codeClassCollection = null;

                // Verify database connection is connected
                if ((databaseConnector != null) && (databaseConnector.Connected))
                {
                    // First Get Dataset
                    DataSet allCodeClassDataSet = this.DataHelper.LoadDataSet(fetchAllCodeClassProc, databaseConnector);

                    // Verify DataSet Exists
                    if(allCodeClassDataSet != null)
                    {
                        // Get DataTable From DataSet
                        DataTable table = this.DataHelper.ReturnFirstTable(allCodeClassDataSet);

                        // if table exists
                        if(table != null)
                        {
                            // Load Collection
                            codeClassCollection = CodeClassReader.LoadCollection(table);
                        }
                    }
                }

                // return value
                return codeClassCollection;
            }
            #endregion

            #region FindCodeClass()
            /// <summary>
            /// This method finds a  'CodeClass' object.
            /// This method uses the 'CodeClass_Find' procedure.
            /// </summary>
            /// <returns>A 'CodeClass' object.</returns>
            /// </summary>
            public CodeClass FindCodeClass(FindCodeClassStoredProcedure findCodeClassProc, DataConnector databaseConnector)
            {
                // Initial Value
                CodeClass codeClass = null;

                // Verify database connection is connected
                if ((databaseConnector != null) && (databaseConnector.Connected))
                {
                    // First Get Dataset
                    DataSet codeClassDataSet = this.DataHelper.LoadDataSet(findCodeClassProc, databaseConnector);

                    // Verify DataSet Exists
                    if(codeClassDataSet != null)
                    {
                        // Get DataTable From DataSet
                        DataRow row = this.DataHelper.ReturnFirstRow(codeClassDataSet);

                        // if row exists
                        if(row != null)
                        {
                            // Load CodeClass
                            codeClass = CodeClassReader.Load(row);
                        }
                    }
                }

                // return value
                return codeClass;
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

            #region InsertCodeClass()
            /// <summary>
            /// This method inserts a 'CodeClass' object.
            /// This method uses the 'CodeClass_Insert' procedure.
            /// </summary>
            /// <returns>The identity value of the new record.</returns>
            /// </summary>
            public int InsertCodeClass(InsertCodeClassStoredProcedure insertCodeClassProc, DataConnector databaseConnector)
            {
                // Initial Value
                int newIdentity = -1;

                // Verify database connection is connected
                if ((databaseConnector != null) && (databaseConnector.Connected))
                {
                    // Execute Non Query
                    newIdentity = this.DataHelper.InsertRecord(insertCodeClassProc, databaseConnector);
                }

                // return value
                return newIdentity;
            }
            #endregion

            #region UpdateCodeClass()
            /// <summary>
            /// This method updates a 'CodeClass'.
            /// This method uses the 'CodeClass_Update' procedure.
            /// </summary>
            /// <returns>True if successful false if not.</returns>
            /// </summary>
            public bool UpdateCodeClass(UpdateCodeClassStoredProcedure updateCodeClassProc, DataConnector databaseConnector)
            {
                // Initial Value
                bool saved = false;

                // Verify database connection is connected
                if ((databaseConnector != null) && (databaseConnector.Connected))
                {
                    // Execute Update.
                    saved = this.DataHelper.UpdateRecord(updateCodeClassProc, databaseConnector);
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
