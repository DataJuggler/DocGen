

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

    #region class CodePropertyManager
    /// <summary>
    /// This class is used to manage a 'CodeProperty' object.
    /// </summary>
    public class CodePropertyManager
    {

        #region Private Variables
        private DataManager dataManager;
        private DataHelper dataHelper;
        #endregion

        #region Constructor
        /// <summary>
        /// Create a new instance of a 'CodePropertyManager' object.
        /// </summary>
        public CodePropertyManager(DataManager dataManagerArg)
        {
            // Set DataManager
            this.DataManager = dataManagerArg;

            // Perform Initialization
            Init();
        }
        #endregion

        #region Methods

            #region DeleteCodeProperty()
            /// <summary>
            /// This method deletes a 'CodeProperty' object.
            /// </summary>
            /// <returns>True if successful false if not.</returns>
            /// </summary>
            public bool DeleteCodeProperty(DeleteCodePropertyStoredProcedure deleteCodePropertyProc, DataConnector databaseConnector)
            {
                // Initial Value
                bool deleted = false;

                // Verify database connection is connected
                if ((databaseConnector != null) && (databaseConnector.Connected))
                {
                    // Execute Non Query
                    deleted = this.DataHelper.DeleteRecord(deleteCodePropertyProc, databaseConnector);
                }

                // return value
                return deleted;
            }
            #endregion

            #region FetchAllCodePropertys()
            /// <summary>
            /// This method fetches a  'List<CodeProperty>' object.
            /// This method uses the 'CodePropertys_FetchAll' procedure.
            /// </summary>
            /// <returns>A 'List<CodeProperty>'</returns>
            /// </summary>
            public List<CodeProperty> FetchAllCodePropertys(FetchAllCodePropertysStoredProcedure fetchAllCodePropertysProc, DataConnector databaseConnector)
            {
                // Initial Value
                List<CodeProperty> codePropertyCollection = null;

                // Verify database connection is connected
                if ((databaseConnector != null) && (databaseConnector.Connected))
                {
                    // First Get Dataset
                    DataSet allCodePropertysDataSet = this.DataHelper.LoadDataSet(fetchAllCodePropertysProc, databaseConnector);

                    // Verify DataSet Exists
                    if(allCodePropertysDataSet != null)
                    {
                        // Get DataTable From DataSet
                        DataTable table = this.DataHelper.ReturnFirstTable(allCodePropertysDataSet);

                        // if table exists
                        if(table != null)
                        {
                            // Load Collection
                            codePropertyCollection = CodePropertyReader.LoadCollection(table);
                        }
                    }
                }

                // return value
                return codePropertyCollection;
            }
            #endregion

            #region FindCodeProperty()
            /// <summary>
            /// This method finds a  'CodeProperty' object.
            /// This method uses the 'CodeProperty_Find' procedure.
            /// </summary>
            /// <returns>A 'CodeProperty' object.</returns>
            /// </summary>
            public CodeProperty FindCodeProperty(FindCodePropertyStoredProcedure findCodePropertyProc, DataConnector databaseConnector)
            {
                // Initial Value
                CodeProperty codeProperty = null;

                // Verify database connection is connected
                if ((databaseConnector != null) && (databaseConnector.Connected))
                {
                    // First Get Dataset
                    DataSet codePropertyDataSet = this.DataHelper.LoadDataSet(findCodePropertyProc, databaseConnector);

                    // Verify DataSet Exists
                    if(codePropertyDataSet != null)
                    {
                        // Get DataTable From DataSet
                        DataRow row = this.DataHelper.ReturnFirstRow(codePropertyDataSet);

                        // if row exists
                        if(row != null)
                        {
                            // Load CodeProperty
                            codeProperty = CodePropertyReader.Load(row);
                        }
                    }
                }

                // return value
                return codeProperty;
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

            #region InsertCodeProperty()
            /// <summary>
            /// This method inserts a 'CodeProperty' object.
            /// This method uses the 'CodeProperty_Insert' procedure.
            /// </summary>
            /// <returns>The identity value of the new record.</returns>
            /// </summary>
            public int InsertCodeProperty(InsertCodePropertyStoredProcedure insertCodePropertyProc, DataConnector databaseConnector)
            {
                // Initial Value
                int newIdentity = -1;

                // Verify database connection is connected
                if ((databaseConnector != null) && (databaseConnector.Connected))
                {
                    // Execute Non Query
                    newIdentity = this.DataHelper.InsertRecord(insertCodePropertyProc, databaseConnector);
                }

                // return value
                return newIdentity;
            }
            #endregion

            #region UpdateCodeProperty()
            /// <summary>
            /// This method updates a 'CodeProperty'.
            /// This method uses the 'CodeProperty_Update' procedure.
            /// </summary>
            /// <returns>True if successful false if not.</returns>
            /// </summary>
            public bool UpdateCodeProperty(UpdateCodePropertyStoredProcedure updateCodePropertyProc, DataConnector databaseConnector)
            {
                // Initial Value
                bool saved = false;

                // Verify database connection is connected
                if ((databaseConnector != null) && (databaseConnector.Connected))
                {
                    // Execute Update.
                    saved = this.DataHelper.UpdateRecord(updateCodePropertyProc, databaseConnector);
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
