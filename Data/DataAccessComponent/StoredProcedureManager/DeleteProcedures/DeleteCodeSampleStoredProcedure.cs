

namespace DataAccessComponent.StoredProcedureManager.DeleteProcedures
{

    #region class DeleteCodeSampleStoredProcedure
    /// <summary>
    /// This class is used to Delete a 'CodeSample' object.
    /// </summary>
    public class DeleteCodeSampleStoredProcedure : StoredProcedure
    {

        #region Private Variables
        #endregion

        #region Constructor
        /// <summary>
        /// Create a new instance of a 'DeleteCodeSampleStoredProcedure' object.
        /// </summary>
        public DeleteCodeSampleStoredProcedure()
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
                this.ProcedureName = "CodeSample_Delete";

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
