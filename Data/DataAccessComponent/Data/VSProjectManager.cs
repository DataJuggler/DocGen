

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

    #region class VSProjectManager
    /// <summary>
    /// This class is used to manage a 'VSProject' object.
    /// </summary>
    public class VSProjectManager
    {

        #region Private Variables
        private DataManager dataManager;
        private DataHelper dataHelper;
        #endregion

        #region Constructor
        /// <summary>
        /// Create a new instance of a 'VSProjectManager' object.
        /// </summary>
        public VSProjectManager(DataManager dataManagerArg)
        {
            // Set DataManager
            this.DataManager = dataManagerArg;

            // Perform Initialization
            Init();
        }
        #endregion

        #region Methods

            #region DeleteVSProject()
            /// <summary>
            /// This method deletes a 'VSProject' object.
            /// </summary>
            /// <returns>True if successful false if not.</returns>
            /// </summary>
            public bool DeleteVSProject(DeleteVSProjectStoredProcedure deleteVSProjectProc, DataConnector databaseConnector)
            {
                // Initial Value
                bool deleted = false;

                // Verify database connection is connected
                if ((databaseConnector != null) && (databaseConnector.Connected))
                {
                    // Execute Non Query
                    deleted = this.DataHelper.DeleteRecord(deleteVSProjectProc, databaseConnector);
                }

                // return value
                return deleted;
            }
            #endregion

            #region FetchAllVSProjects()
            /// <summary>
            /// This method fetches a  'List<VSProject>' object.
            /// This method uses the 'VSProjects_FetchAll' procedure.
            /// </summary>
            /// <returns>A 'List<VSProject>'</returns>
            /// </summary>
            public List<VSProject> FetchAllVSProjects(FetchAllVSProjectsStoredProcedure fetchAllVSProjectsProc, DataConnector databaseConnector)
            {
                // Initial Value
                List<VSProject> vSProjectCollection = null;

                // Verify database connection is connected
                if ((databaseConnector != null) && (databaseConnector.Connected))
                {
                    // First Get Dataset
                    DataSet allVSProjectsDataSet = this.DataHelper.LoadDataSet(fetchAllVSProjectsProc, databaseConnector);

                    // Verify DataSet Exists
                    if(allVSProjectsDataSet != null)
                    {
                        // Get DataTable From DataSet
                        DataTable table = this.DataHelper.ReturnFirstTable(allVSProjectsDataSet);

                        // if table exists
                        if(table != null)
                        {
                            // Load Collection
                            vSProjectCollection = VSProjectReader.LoadCollection(table);
                        }
                    }
                }

                // return value
                return vSProjectCollection;
            }
            #endregion

            #region FindVSProject()
            /// <summary>
            /// This method finds a  'VSProject' object.
            /// This method uses the 'VSProject_Find' procedure.
            /// </summary>
            /// <returns>A 'VSProject' object.</returns>
            /// </summary>
            public VSProject FindVSProject(FindVSProjectStoredProcedure findVSProjectProc, DataConnector databaseConnector)
            {
                // Initial Value
                VSProject vSProject = null;

                // Verify database connection is connected
                if ((databaseConnector != null) && (databaseConnector.Connected))
                {
                    // First Get Dataset
                    DataSet vSProjectDataSet = this.DataHelper.LoadDataSet(findVSProjectProc, databaseConnector);

                    // Verify DataSet Exists
                    if(vSProjectDataSet != null)
                    {
                        // Get DataTable From DataSet
                        DataRow row = this.DataHelper.ReturnFirstRow(vSProjectDataSet);

                        // if row exists
                        if(row != null)
                        {
                            // Load VSProject
                            vSProject = VSProjectReader.Load(row);
                        }
                    }
                }

                // return value
                return vSProject;
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

            #region InsertVSProject()
            /// <summary>
            /// This method inserts a 'VSProject' object.
            /// This method uses the 'VSProject_Insert' procedure.
            /// </summary>
            /// <returns>The identity value of the new record.</returns>
            /// </summary>
            public int InsertVSProject(InsertVSProjectStoredProcedure insertVSProjectProc, DataConnector databaseConnector)
            {
                // Initial Value
                int newIdentity = -1;

                // Verify database connection is connected
                if ((databaseConnector != null) && (databaseConnector.Connected))
                {
                    // Execute Non Query
                    newIdentity = this.DataHelper.InsertRecord(insertVSProjectProc, databaseConnector);
                }

                // return value
                return newIdentity;
            }
            #endregion

            #region UpdateVSProject()
            /// <summary>
            /// This method updates a 'VSProject'.
            /// This method uses the 'VSProject_Update' procedure.
            /// </summary>
            /// <returns>True if successful false if not.</returns>
            /// </summary>
            public bool UpdateVSProject(UpdateVSProjectStoredProcedure updateVSProjectProc, DataConnector databaseConnector)
            {
                // Initial Value
                bool saved = false;

                // Verify database connection is connected
                if ((databaseConnector != null) && (databaseConnector.Connected))
                {
                    // Execute Update.
                    saved = this.DataHelper.UpdateRecord(updateVSProjectProc, databaseConnector);
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
