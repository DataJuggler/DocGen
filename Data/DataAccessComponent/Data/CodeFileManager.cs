

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

    #region class CodeFileManager
    /// <summary>
    /// This class is used to manage a 'CodeFile' object.
    /// </summary>
    public class CodeFileManager
    {

        #region Private Variables
        private DataManager dataManager;
        private DataHelper dataHelper;
        #endregion

        #region Constructor
        /// <summary>
        /// Create a new instance of a 'CodeFileManager' object.
        /// </summary>
        public CodeFileManager(DataManager dataManagerArg)
        {
            // Set DataManager
            this.DataManager = dataManagerArg;

            // Perform Initialization
            Init();
        }
        #endregion

        #region Methods

            #region DeleteCodeFile()
            /// <summary>
            /// This method deletes a 'CodeFile' object.
            /// </summary>
            /// <returns>True if successful false if not.</returns>
            /// </summary>
            public bool DeleteCodeFile(DeleteCodeFileStoredProcedure deleteCodeFileProc, DataConnector databaseConnector)
            {
                // Initial Value
                bool deleted = false;

                // Verify database connection is connected
                if ((databaseConnector != null) && (databaseConnector.Connected))
                {
                    // Execute Non Query
                    deleted = this.DataHelper.DeleteRecord(deleteCodeFileProc, databaseConnector);
                }

                // return value
                return deleted;
            }
            #endregion

            #region FetchAllCodeFiles()
            /// <summary>
            /// This method fetches a  'List<CodeFile>' object.
            /// This method uses the 'CodeFiles_FetchAll' procedure.
            /// </summary>
            /// <returns>A 'List<CodeFile>'</returns>
            /// </summary>
            public List<CodeFile> FetchAllCodeFiles(FetchAllCodeFilesStoredProcedure fetchAllCodeFilesProc, DataConnector databaseConnector)
            {
                // Initial Value
                List<CodeFile> codeFileCollection = null;

                // Verify database connection is connected
                if ((databaseConnector != null) && (databaseConnector.Connected))
                {
                    // First Get Dataset
                    DataSet allCodeFilesDataSet = this.DataHelper.LoadDataSet(fetchAllCodeFilesProc, databaseConnector);

                    // Verify DataSet Exists
                    if(allCodeFilesDataSet != null)
                    {
                        // Get DataTable From DataSet
                        DataTable table = this.DataHelper.ReturnFirstTable(allCodeFilesDataSet);

                        // if table exists
                        if(table != null)
                        {
                            // Load Collection
                            codeFileCollection = CodeFileReader.LoadCollection(table);
                        }
                    }
                }

                // return value
                return codeFileCollection;
            }
            #endregion

            #region FindCodeFile()
            /// <summary>
            /// This method finds a  'CodeFile' object.
            /// This method uses the 'CodeFile_Find' procedure.
            /// </summary>
            /// <returns>A 'CodeFile' object.</returns>
            /// </summary>
            public CodeFile FindCodeFile(FindCodeFileStoredProcedure findCodeFileProc, DataConnector databaseConnector)
            {
                // Initial Value
                CodeFile codeFile = null;

                // Verify database connection is connected
                if ((databaseConnector != null) && (databaseConnector.Connected))
                {
                    // First Get Dataset
                    DataSet codeFileDataSet = this.DataHelper.LoadDataSet(findCodeFileProc, databaseConnector);

                    // Verify DataSet Exists
                    if(codeFileDataSet != null)
                    {
                        // Get DataTable From DataSet
                        DataRow row = this.DataHelper.ReturnFirstRow(codeFileDataSet);

                        // if row exists
                        if(row != null)
                        {
                            // Load CodeFile
                            codeFile = CodeFileReader.Load(row);
                        }
                    }
                }

                // return value
                return codeFile;
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

            #region InsertCodeFile()
            /// <summary>
            /// This method inserts a 'CodeFile' object.
            /// This method uses the 'CodeFile_Insert' procedure.
            /// </summary>
            /// <returns>The identity value of the new record.</returns>
            /// </summary>
            public int InsertCodeFile(InsertCodeFileStoredProcedure insertCodeFileProc, DataConnector databaseConnector)
            {
                // Initial Value
                int newIdentity = -1;

                // Verify database connection is connected
                if ((databaseConnector != null) && (databaseConnector.Connected))
                {
                    // Execute Non Query
                    newIdentity = this.DataHelper.InsertRecord(insertCodeFileProc, databaseConnector);
                }

                // return value
                return newIdentity;
            }
            #endregion

            #region UpdateCodeFile()
            /// <summary>
            /// This method updates a 'CodeFile'.
            /// This method uses the 'CodeFile_Update' procedure.
            /// </summary>
            /// <returns>True if successful false if not.</returns>
            /// </summary>
            public bool UpdateCodeFile(UpdateCodeFileStoredProcedure updateCodeFileProc, DataConnector databaseConnector)
            {
                // Initial Value
                bool saved = false;

                // Verify database connection is connected
                if ((databaseConnector != null) && (databaseConnector.Connected))
                {
                    // Execute Update.
                    saved = this.DataHelper.UpdateRecord(updateCodeFileProc, databaseConnector);
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
