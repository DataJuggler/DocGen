

namespace DataAccessComponent.StoredProcedureManager.InsertProcedures
{

    #region class InsertCodeFileStoredProcedure
    /// <summary>
    /// This class is used to Insert a 'CodeFile' object.
    /// </summary>
    public class InsertCodeFileStoredProcedure : StoredProcedure
    {

        #region Private Variables
        #endregion

        #region Constructor
        /// <summary>
        /// Create a new instance of a 'InsertCodeFileStoredProcedure' object.
        /// </summary>
        public InsertCodeFileStoredProcedure()
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
                this.ProcedureName = "CodeFile_Insert";

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
