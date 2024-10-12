

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

    #region class VSSolutionManager
    /// <summary>
    /// This class is used to manage a 'VSSolution' object.
    /// </summary>
    public class VSSolutionManager
    {

        #region Private Variables
        private DataManager dataManager;
        private DataHelper dataHelper;
        #endregion

        #region Constructor
        /// <summary>
        /// Create a new instance of a 'VSSolutionManager' object.
        /// </summary>
        public VSSolutionManager(DataManager dataManagerArg)
        {
            // Set DataManager
            this.DataManager = dataManagerArg;

            // Perform Initialization
            Init();
        }
        #endregion

        #region Methods

            #region DeleteVSSolution()
            /// <summary>
            /// This method deletes a 'VSSolution' object.
            /// </summary>
            /// <returns>True if successful false if not.</returns>
            /// </summary>
            public bool DeleteVSSolution(DeleteVSSolutionStoredProcedure deleteVSSolutionProc, DataConnector databaseConnector)
            {
                // Initial Value
                bool deleted = false;

                // Verify database connection is connected
                if ((databaseConnector != null) && (databaseConnector.Connected))
                {
                    // Execute Non Query
                    deleted = this.DataHelper.DeleteRecord(deleteVSSolutionProc, databaseConnector);
                }

                // return value
                return deleted;
            }
            #endregion

            #region FetchAllVSSolutions()
            /// <summary>
            /// This method fetches a  'List<VSSolution>' object.
            /// This method uses the 'VSSolutions_FetchAll' procedure.
            /// </summary>
            /// <returns>A 'List<VSSolution>'</returns>
            /// </summary>
            public List<VSSolution> FetchAllVSSolutions(FetchAllVSSolutionsStoredProcedure fetchAllVSSolutionsProc, DataConnector databaseConnector)
            {
                // Initial Value
                List<VSSolution> vSSolutionCollection = null;

                // Verify database connection is connected
                if ((databaseConnector != null) && (databaseConnector.Connected))
                {
                    // First Get Dataset
                    DataSet allVSSolutionsDataSet = this.DataHelper.LoadDataSet(fetchAllVSSolutionsProc, databaseConnector);

                    // Verify DataSet Exists
                    if(allVSSolutionsDataSet != null)
                    {
                        // Get DataTable From DataSet
                        DataTable table = this.DataHelper.ReturnFirstTable(allVSSolutionsDataSet);

                        // if table exists
                        if(table != null)
                        {
                            // Load Collection
                            vSSolutionCollection = VSSolutionReader.LoadCollection(table);
                        }
                    }
                }

                // return value
                return vSSolutionCollection;
            }
            #endregion

            #region FindVSSolution()
            /// <summary>
            /// This method finds a  'VSSolution' object.
            /// This method uses the 'VSSolution_Find' procedure.
            /// </summary>
            /// <returns>A 'VSSolution' object.</returns>
            /// </summary>
            public VSSolution FindVSSolution(FindVSSolutionStoredProcedure findVSSolutionProc, DataConnector databaseConnector)
            {
                // Initial Value
                VSSolution vSSolution = null;

                // Verify database connection is connected
                if ((databaseConnector != null) && (databaseConnector.Connected))
                {
                    // First Get Dataset
                    DataSet vSSolutionDataSet = this.DataHelper.LoadDataSet(findVSSolutionProc, databaseConnector);

                    // Verify DataSet Exists
                    if(vSSolutionDataSet != null)
                    {
                        // Get DataTable From DataSet
                        DataRow row = this.DataHelper.ReturnFirstRow(vSSolutionDataSet);

                        // if row exists
                        if(row != null)
                        {
                            // Load VSSolution
                            vSSolution = VSSolutionReader.Load(row);
                        }
                    }
                }

                // return value
                return vSSolution;
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

            #region InsertVSSolution()
            /// <summary>
            /// This method inserts a 'VSSolution' object.
            /// This method uses the 'VSSolution_Insert' procedure.
            /// </summary>
            /// <returns>The identity value of the new record.</returns>
            /// </summary>
            public int InsertVSSolution(InsertVSSolutionStoredProcedure insertVSSolutionProc, DataConnector databaseConnector)
            {
                // Initial Value
                int newIdentity = -1;

                // Verify database connection is connected
                if ((databaseConnector != null) && (databaseConnector.Connected))
                {
                    // Execute Non Query
                    newIdentity = this.DataHelper.InsertRecord(insertVSSolutionProc, databaseConnector);
                }

                // return value
                return newIdentity;
            }
            #endregion

            #region UpdateVSSolution()
            /// <summary>
            /// This method updates a 'VSSolution'.
            /// This method uses the 'VSSolution_Update' procedure.
            /// </summary>
            /// <returns>True if successful false if not.</returns>
            /// </summary>
            public bool UpdateVSSolution(UpdateVSSolutionStoredProcedure updateVSSolutionProc, DataConnector databaseConnector)
            {
                // Initial Value
                bool saved = false;

                // Verify database connection is connected
                if ((databaseConnector != null) && (databaseConnector.Connected))
                {
                    // Execute Update.
                    saved = this.DataHelper.UpdateRecord(updateVSSolutionProc, databaseConnector);
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
