

namespace DataAccessComponent.StoredProcedureManager.FetchProcedures
{

    #region class FetchAllCodeFilesStoredProcedure
    /// <summary>
    /// This class is used to FetchAll 'CodeFile' objects.
    /// </summary>
    public class FetchAllCodeFilesStoredProcedure : StoredProcedure
    {

        #region Private Variables
        #endregion

        #region Constructor
        /// <summary>
        /// Create a new instance of a 'FetchAllCodeFilesStoredProcedure' object.
        /// </summary>
        public FetchAllCodeFilesStoredProcedure()
        {
            // Perform Initialization
            Init();
        }
        #endregion

        #region Methods

            #region Init()
            /// <summary>
            /// Set Procedure Properties
            /// </summary>
            private void Init()
            {
                // Set Properties For This Proc

                // Set ProcedureName
                this.ProcedureName = "CodeFile_FetchAll";

                // Set tableName
                this.TableName = "CodeFile";
            }
            #endregion

        #endregion

        #region Properties

        #endregion

    }
    #endregion

}
