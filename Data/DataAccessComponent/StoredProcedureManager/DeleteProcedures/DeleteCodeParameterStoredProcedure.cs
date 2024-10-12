

namespace DataAccessComponent.StoredProcedureManager.DeleteProcedures
{

    #region class DeleteCodeParameterStoredProcedure
    /// <summary>
    /// This class is used to Delete a 'CodeParameter' object.
    /// </summary>
    public class DeleteCodeParameterStoredProcedure : StoredProcedure
    {

        #region Private Variables
        #endregion

        #region Constructor
        /// <summary>
        /// Create a new instance of a 'DeleteCodeParameterStoredProcedure' object.
        /// </summary>
        public DeleteCodeParameterStoredProcedure()
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
                this.ProcedureName = "CodeParameter_Delete";

                // Set tableName
                this.TableName = "CodeParameter";
            }
            #endregion

        #endregion

        #region Properties

        #endregion

    }
    #endregion

}
