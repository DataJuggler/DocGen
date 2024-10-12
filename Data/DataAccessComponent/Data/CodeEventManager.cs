

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

    #region class CodeEventManager
    /// <summary>
    /// This class is used to manage a 'CodeEvent' object.
    /// </summary>
    public class CodeEventManager
    {

        #region Private Variables
        private DataManager dataManager;
        private DataHelper dataHelper;
        #endregion

        #region Constructor
        /// <summary>
        /// Create a new instance of a 'CodeEventManager' object.
        /// </summary>
        public CodeEventManager(DataManager dataManagerArg)
        {
            // Set DataManager
            this.DataManager = dataManagerArg;

            // Perform Initialization
            Init();
        }
        #endregion

        #region Methods

            #region DeleteCodeEvent()
            /// <summary>
            /// This method deletes a 'CodeEvent' object.
            /// </summary>
            /// <returns>True if successful false if not.</returns>
            /// </summary>
            public bool DeleteCodeEvent(DeleteCodeEventStoredProcedure deleteCodeEventProc, DataConnector databaseConnector)
            {
                // Initial Value
                bool deleted = false;

                // Verify database connection is connected
                if ((databaseConnector != null) && (databaseConnector.Connected))
                {
                    // Execute Non Query
                    deleted = this.DataHelper.DeleteRecord(deleteCodeEventProc, databaseConnector);
                }

                // return value
                return deleted;
            }
            #endregion

            #region FetchAllCodeEvents()
            /// <summary>
            /// This method fetches a  'List<CodeEvent>' object.
            /// This method uses the 'CodeEvents_FetchAll' procedure.
            /// </summary>
            /// <returns>A 'List<CodeEvent>'</returns>
            /// </summary>
            public List<CodeEvent> FetchAllCodeEvents(FetchAllCodeEventsStoredProcedure fetchAllCodeEventsProc, DataConnector databaseConnector)
            {
                // Initial Value
                List<CodeEvent> codeEventCollection = null;

                // Verify database connection is connected
                if ((databaseConnector != null) && (databaseConnector.Connected))
                {
                    // First Get Dataset
                    DataSet allCodeEventsDataSet = this.DataHelper.LoadDataSet(fetchAllCodeEventsProc, databaseConnector);

                    // Verify DataSet Exists
                    if(allCodeEventsDataSet != null)
                    {
                        // Get DataTable From DataSet
                        DataTable table = this.DataHelper.ReturnFirstTable(allCodeEventsDataSet);

                        // if table exists
                        if(table != null)
                        {
                            // Load Collection
                            codeEventCollection = CodeEventReader.LoadCollection(table);
                        }
                    }
                }

                // return value
                return codeEventCollection;
            }
            #endregion

            #region FindCodeEvent()
            /// <summary>
            /// This method finds a  'CodeEvent' object.
            /// This method uses the 'CodeEvent_Find' procedure.
            /// </summary>
            /// <returns>A 'CodeEvent' object.</returns>
            /// </summary>
            public CodeEvent FindCodeEvent(FindCodeEventStoredProcedure findCodeEventProc, DataConnector databaseConnector)
            {
                // Initial Value
                CodeEvent codeEvent = null;

                // Verify database connection is connected
                if ((databaseConnector != null) && (databaseConnector.Connected))
                {
                    // First Get Dataset
                    DataSet codeEventDataSet = this.DataHelper.LoadDataSet(findCodeEventProc, databaseConnector);

                    // Verify DataSet Exists
                    if(codeEventDataSet != null)
                    {
                        // Get DataTable From DataSet
                        DataRow row = this.DataHelper.ReturnFirstRow(codeEventDataSet);

                        // if row exists
                        if(row != null)
                        {
                            // Load CodeEvent
                            codeEvent = CodeEventReader.Load(row);
                        }
                    }
                }

                // return value
                return codeEvent;
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

            #region InsertCodeEvent()
            /// <summary>
            /// This method inserts a 'CodeEvent' object.
            /// This method uses the 'CodeEvent_Insert' procedure.
            /// </summary>
            /// <returns>The identity value of the new record.</returns>
            /// </summary>
            public int InsertCodeEvent(InsertCodeEventStoredProcedure insertCodeEventProc, DataConnector databaseConnector)
            {
                // Initial Value
                int newIdentity = -1;

                // Verify database connection is connected
                if ((databaseConnector != null) && (databaseConnector.Connected))
                {
                    // Execute Non Query
                    newIdentity = this.DataHelper.InsertRecord(insertCodeEventProc, databaseConnector);
                }

                // return value
                return newIdentity;
            }
            #endregion

            #region UpdateCodeEvent()
            /// <summary>
            /// This method updates a 'CodeEvent'.
            /// This method uses the 'CodeEvent_Update' procedure.
            /// </summary>
            /// <returns>True if successful false if not.</returns>
            /// </summary>
            public bool UpdateCodeEvent(UpdateCodeEventStoredProcedure updateCodeEventProc, DataConnector databaseConnector)
            {
                // Initial Value
                bool saved = false;

                // Verify database connection is connected
                if ((databaseConnector != null) && (databaseConnector.Connected))
                {
                    // Execute Update.
                    saved = this.DataHelper.UpdateRecord(updateCodeEventProc, databaseConnector);
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
