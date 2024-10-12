

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

    #region class ReferencedByManager
    /// <summary>
    /// This class is used to manage a 'ReferencedBy' object.
    /// </summary>
    public class ReferencedByManager
    {

        #region Private Variables
        private DataManager dataManager;
        private DataHelper dataHelper;
        #endregion

        #region Constructor
        /// <summary>
        /// Create a new instance of a 'ReferencedByManager' object.
        /// </summary>
        public ReferencedByManager(DataManager dataManagerArg)
        {
            // Set DataManager
            this.DataManager = dataManagerArg;

            // Perform Initialization
            Init();
        }
        #endregion

        #region Methods

            #region DeleteReferencedBy()
            /// <summary>
            /// This method deletes a 'ReferencedBy' object.
            /// </summary>
            /// <returns>True if successful false if not.</returns>
            /// </summary>
            public bool DeleteReferencedBy(DeleteReferencedByStoredProcedure deleteReferencedByProc, DataConnector databaseConnector)
            {
                // Initial Value
                bool deleted = false;

                // Verify database connection is connected
                if ((databaseConnector != null) && (databaseConnector.Connected))
                {
                    // Execute Non Query
                    deleted = this.DataHelper.DeleteRecord(deleteReferencedByProc, databaseConnector);
                }

                // return value
                return deleted;
            }
            #endregion

            #region FetchAllReferencedBys()
            /// <summary>
            /// This method fetches a  'List<ReferencedBy>' object.
            /// This method uses the 'ReferencedBys_FetchAll' procedure.
            /// </summary>
            /// <returns>A 'List<ReferencedBy>'</returns>
            /// </summary>
            public List<ReferencedBy> FetchAllReferencedBys(FetchAllReferencedBysStoredProcedure fetchAllReferencedBysProc, DataConnector databaseConnector)
            {
                // Initial Value
                List<ReferencedBy> referencedByCollection = null;

                // Verify database connection is connected
                if ((databaseConnector != null) && (databaseConnector.Connected))
                {
                    // First Get Dataset
                    DataSet allReferencedBysDataSet = this.DataHelper.LoadDataSet(fetchAllReferencedBysProc, databaseConnector);

                    // Verify DataSet Exists
                    if(allReferencedBysDataSet != null)
                    {
                        // Get DataTable From DataSet
                        DataTable table = this.DataHelper.ReturnFirstTable(allReferencedBysDataSet);

                        // if table exists
                        if(table != null)
                        {
                            // Load Collection
                            referencedByCollection = ReferencedByReader.LoadCollection(table);
                        }
                    }
                }

                // return value
                return referencedByCollection;
            }
            #endregion

            #region FindReferencedBy()
            /// <summary>
            /// This method finds a  'ReferencedBy' object.
            /// This method uses the 'ReferencedBy_Find' procedure.
            /// </summary>
            /// <returns>A 'ReferencedBy' object.</returns>
            /// </summary>
            public ReferencedBy FindReferencedBy(FindReferencedByStoredProcedure findReferencedByProc, DataConnector databaseConnector)
            {
                // Initial Value
                ReferencedBy referencedBy = null;

                // Verify database connection is connected
                if ((databaseConnector != null) && (databaseConnector.Connected))
                {
                    // First Get Dataset
                    DataSet referencedByDataSet = this.DataHelper.LoadDataSet(findReferencedByProc, databaseConnector);

                    // Verify DataSet Exists
                    if(referencedByDataSet != null)
                    {
                        // Get DataTable From DataSet
                        DataRow row = this.DataHelper.ReturnFirstRow(referencedByDataSet);

                        // if row exists
                        if(row != null)
                        {
                            // Load ReferencedBy
                            referencedBy = ReferencedByReader.Load(row);
                        }
                    }
                }

                // return value
                return referencedBy;
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

            #region InsertReferencedBy()
            /// <summary>
            /// This method inserts a 'ReferencedBy' object.
            /// This method uses the 'ReferencedBy_Insert' procedure.
            /// </summary>
            /// <returns>The identity value of the new record.</returns>
            /// </summary>
            public int InsertReferencedBy(InsertReferencedByStoredProcedure insertReferencedByProc, DataConnector databaseConnector)
            {
                // Initial Value
                int newIdentity = -1;

                // Verify database connection is connected
                if ((databaseConnector != null) && (databaseConnector.Connected))
                {
                    // Execute Non Query
                    newIdentity = this.DataHelper.InsertRecord(insertReferencedByProc, databaseConnector);
                }

                // return value
                return newIdentity;
            }
            #endregion

            #region UpdateReferencedBy()
            /// <summary>
            /// This method updates a 'ReferencedBy'.
            /// This method uses the 'ReferencedBy_Update' procedure.
            /// </summary>
            /// <returns>True if successful false if not.</returns>
            /// </summary>
            public bool UpdateReferencedBy(UpdateReferencedByStoredProcedure updateReferencedByProc, DataConnector databaseConnector)
            {
                // Initial Value
                bool saved = false;

                // Verify database connection is connected
                if ((databaseConnector != null) && (databaseConnector.Connected))
                {
                    // Execute Update.
                    saved = this.DataHelper.UpdateRecord(updateReferencedByProc, databaseConnector);
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
