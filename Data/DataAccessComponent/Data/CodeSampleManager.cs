

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

    #region class CodeSampleManager
    /// <summary>
    /// This class is used to manage a 'CodeSample' object.
    /// </summary>
    public class CodeSampleManager
    {

        #region Private Variables
        private DataManager dataManager;
        private DataHelper dataHelper;
        #endregion

        #region Constructor
        /// <summary>
        /// Create a new instance of a 'CodeSampleManager' object.
        /// </summary>
        public CodeSampleManager(DataManager dataManagerArg)
        {
            // Set DataManager
            this.DataManager = dataManagerArg;

            // Perform Initialization
            Init();
        }
        #endregion

        #region Methods

            #region DeleteCodeSample()
            /// <summary>
            /// This method deletes a 'CodeSample' object.
            /// </summary>
            /// <returns>True if successful false if not.</returns>
            /// </summary>
            public bool DeleteCodeSample(DeleteCodeSampleStoredProcedure deleteCodeSampleProc, DataConnector databaseConnector)
            {
                // Initial Value
                bool deleted = false;

                // Verify database connection is connected
                if ((databaseConnector != null) && (databaseConnector.Connected))
                {
                    // Execute Non Query
                    deleted = this.DataHelper.DeleteRecord(deleteCodeSampleProc, databaseConnector);
                }

                // return value
                return deleted;
            }
            #endregion

            #region FetchAllCodeSamples()
            /// <summary>
            /// This method fetches a  'List<CodeSample>' object.
            /// This method uses the 'CodeSamples_FetchAll' procedure.
            /// </summary>
            /// <returns>A 'List<CodeSample>'</returns>
            /// </summary>
            public List<CodeSample> FetchAllCodeSamples(FetchAllCodeSamplesStoredProcedure fetchAllCodeSamplesProc, DataConnector databaseConnector)
            {
                // Initial Value
                List<CodeSample> codeSampleCollection = null;

                // Verify database connection is connected
                if ((databaseConnector != null) && (databaseConnector.Connected))
                {
                    // First Get Dataset
                    DataSet allCodeSamplesDataSet = this.DataHelper.LoadDataSet(fetchAllCodeSamplesProc, databaseConnector);

                    // Verify DataSet Exists
                    if(allCodeSamplesDataSet != null)
                    {
                        // Get DataTable From DataSet
                        DataTable table = this.DataHelper.ReturnFirstTable(allCodeSamplesDataSet);

                        // if table exists
                        if(table != null)
                        {
                            // Load Collection
                            codeSampleCollection = CodeSampleReader.LoadCollection(table);
                        }
                    }
                }

                // return value
                return codeSampleCollection;
            }
            #endregion

            #region FindCodeSample()
            /// <summary>
            /// This method finds a  'CodeSample' object.
            /// This method uses the 'CodeSample_Find' procedure.
            /// </summary>
            /// <returns>A 'CodeSample' object.</returns>
            /// </summary>
            public CodeSample FindCodeSample(FindCodeSampleStoredProcedure findCodeSampleProc, DataConnector databaseConnector)
            {
                // Initial Value
                CodeSample codeSample = null;

                // Verify database connection is connected
                if ((databaseConnector != null) && (databaseConnector.Connected))
                {
                    // First Get Dataset
                    DataSet codeSampleDataSet = this.DataHelper.LoadDataSet(findCodeSampleProc, databaseConnector);

                    // Verify DataSet Exists
                    if(codeSampleDataSet != null)
                    {
                        // Get DataTable From DataSet
                        DataRow row = this.DataHelper.ReturnFirstRow(codeSampleDataSet);

                        // if row exists
                        if(row != null)
                        {
                            // Load CodeSample
                            codeSample = CodeSampleReader.Load(row);
                        }
                    }
                }

                // return value
                return codeSample;
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

            #region InsertCodeSample()
            /// <summary>
            /// This method inserts a 'CodeSample' object.
            /// This method uses the 'CodeSample_Insert' procedure.
            /// </summary>
            /// <returns>The identity value of the new record.</returns>
            /// </summary>
            public int InsertCodeSample(InsertCodeSampleStoredProcedure insertCodeSampleProc, DataConnector databaseConnector)
            {
                // Initial Value
                int newIdentity = -1;

                // Verify database connection is connected
                if ((databaseConnector != null) && (databaseConnector.Connected))
                {
                    // Execute Non Query
                    newIdentity = this.DataHelper.InsertRecord(insertCodeSampleProc, databaseConnector);
                }

                // return value
                return newIdentity;
            }
            #endregion

            #region UpdateCodeSample()
            /// <summary>
            /// This method updates a 'CodeSample'.
            /// This method uses the 'CodeSample_Update' procedure.
            /// </summary>
            /// <returns>True if successful false if not.</returns>
            /// </summary>
            public bool UpdateCodeSample(UpdateCodeSampleStoredProcedure updateCodeSampleProc, DataConnector databaseConnector)
            {
                // Initial Value
                bool saved = false;

                // Verify database connection is connected
                if ((databaseConnector != null) && (databaseConnector.Connected))
                {
                    // Execute Update.
                    saved = this.DataHelper.UpdateRecord(updateCodeSampleProc, databaseConnector);
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
