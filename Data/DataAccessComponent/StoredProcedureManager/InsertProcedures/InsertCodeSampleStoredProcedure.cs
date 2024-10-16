

namespace DataAccessComponent.StoredProcedureManager.InsertProcedures
{

    #region class InsertCodeSampleStoredProcedure
    /// <summary>
    /// This class is used to Insert a 'CodeSample' object.
    /// </summary>
    public class InsertCodeSampleStoredProcedure : StoredProcedure
    {

        #region Private Variables
        #endregion

        #region Constructor
        /// <summary>
        /// Create a new instance of a 'InsertCodeSampleStoredProcedure' object.
        /// </summary>
        public InsertCodeSampleStoredProcedure()
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
                this.ProcedureName = "CodeSample_Insert";

                // Set tableName
                this.TableName = "CodeSample";
            }
            #endregion

        #endregion

        #region Properties

        #endregion

    }
    #endregion

}
