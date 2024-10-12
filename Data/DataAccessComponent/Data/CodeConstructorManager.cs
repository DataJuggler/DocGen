

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

    #region class CodeConstructorManager
    /// <summary>
    /// This class is used to manage a 'CodeConstructor' object.
    /// </summary>
    public class CodeConstructorManager
    {

        #region Private Variables
        private DataManager dataManager;
        private DataHelper dataHelper;
        #endregion

        #region Constructor
        /// <summary>
        /// Create a new instance of a 'CodeConstructorManager' object.
        /// </summary>
        public CodeConstructorManager(DataManager dataManagerArg)
        {
            // Set DataManager
            this.DataManager = dataManagerArg;

            // Perform Initialization
            Init();
        }
        #endregion

        #region Methods

            #region DeleteCodeConstructor()
            /// <summary>
            /// This method deletes a 'CodeConstructor' object.
            /// </summary>
            /// <returns>True if successful false if not.</returns>
            /// </summary>
            public bool DeleteCodeConstructor(DeleteCodeConstructorStoredProcedure deleteCodeConstructorProc, DataConnector databaseConnector)
            {
                // Initial Value
                bool deleted = false;

                // Verify database connection is connected
                if ((databaseConnector != null) && (databaseConnector.Connected))
                {
                    // Execute Non Query
                    deleted = this.DataHelper.DeleteRecord(deleteCodeConstructorProc, databaseConnector);
                }

                // return value
                return deleted;
            }
            #endregion

            #region FetchAllCodeConstructors()
            /// <summary>
            /// This method fetches a  'List<CodeConstructor>' object.
            /// This method uses the 'CodeConstructors_FetchAll' procedure.
            /// </summary>
            /// <returns>A 'List<CodeConstructor>'</returns>
            /// </summary>
            public List<CodeConstructor> FetchAllCodeConstructors(FetchAllCodeConstructorsStoredProcedure fetchAllCodeConstructorsProc, DataConnector databaseConnector)
            {
                // Initial Value
                List<CodeConstructor> codeConstructorCollection = null;

                // Verify database connection is connected
                if ((databaseConnector != null) && (databaseConnector.Connected))
                {
                    // First Get Dataset
                    DataSet allCodeConstructorsDataSet = this.DataHelper.LoadDataSet(fetchAllCodeConstructorsProc, databaseConnector);

                    // Verify DataSet Exists
                    if(allCodeConstructorsDataSet != null)
                    {
                        // Get DataTable From DataSet
                        DataTable table = this.DataHelper.ReturnFirstTable(allCodeConstructorsDataSet);

                        // if table exists
                        if(table != null)
                        {
                            // Load Collection
                            codeConstructorCollection = CodeConstructorReader.LoadCollection(table);
                        }
                    }
                }

                // return value
                return codeConstructorCollection;
            }
            #endregion

            #region FindCodeConstructor()
            /// <summary>
            /// This method finds a  'CodeConstructor' object.
            /// This method uses the 'CodeConstructor_Find' procedure.
            /// </summary>
            /// <returns>A 'CodeConstructor' object.</returns>
            /// </summary>
            public CodeConstructor FindCodeConstructor(FindCodeConstructorStoredProcedure findCodeConstructorProc, DataConnector databaseConnector)
            {
                // Initial Value
                CodeConstructor codeConstructor = null;

                // Verify database connection is connected
                if ((databaseConnector != null) && (databaseConnector.Connected))
                {
                    // First Get Dataset
                    DataSet codeConstructorDataSet = this.DataHelper.LoadDataSet(findCodeConstructorProc, databaseConnector);

                    // Verify DataSet Exists
                    if(codeConstructorDataSet != null)
                    {
                        // Get DataTable From DataSet
                        DataRow row = this.DataHelper.ReturnFirstRow(codeConstructorDataSet);

                        // if row exists
                        if(row != null)
                        {
                            // Load CodeConstructor
                            codeConstructor = CodeConstructorReader.Load(row);
                        }
                    }
                }

                // return value
                return codeConstructor;
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

            #region InsertCodeConstructor()
            /// <summary>
            /// This method inserts a 'CodeConstructor' object.
            /// This method uses the 'CodeConstructor_Insert' procedure.
            /// </summary>
            /// <returns>The identity value of the new record.</returns>
            /// </summary>
            public int InsertCodeConstructor(InsertCodeConstructorStoredProcedure insertCodeConstructorProc, DataConnector databaseConnector)
            {
                // Initial Value
                int newIdentity = -1;

                // Verify database connection is connected
                if ((databaseConnector != null) && (databaseConnector.Connected))
                {
                    // Execute Non Query
                    newIdentity = this.DataHelper.InsertRecord(insertCodeConstructorProc, databaseConnector);
                }

                // return value
                return newIdentity;
            }
            #endregion

            #region UpdateCodeConstructor()
            /// <summary>
            /// This method updates a 'CodeConstructor'.
            /// This method uses the 'CodeConstructor_Update' procedure.
            /// </summary>
            /// <returns>True if successful false if not.</returns>
            /// </summary>
            public bool UpdateCodeConstructor(UpdateCodeConstructorStoredProcedure updateCodeConstructorProc, DataConnector databaseConnector)
            {
                // Initial Value
                bool saved = false;

                // Verify database connection is connected
                if ((databaseConnector != null) && (databaseConnector.Connected))
                {
                    // Execute Update.
                    saved = this.DataHelper.UpdateRecord(updateCodeConstructorProc, databaseConnector);
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
