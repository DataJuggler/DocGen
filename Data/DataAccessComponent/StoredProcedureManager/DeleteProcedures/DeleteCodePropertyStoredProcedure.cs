

namespace DataAccessComponent.StoredProcedureManager.DeleteProcedures
{

    #region class DeleteCodePropertyStoredProcedure
    /// <summary>
    /// This class is used to Delete a 'CodeProperty' object.
    /// </summary>
    public class DeleteCodePropertyStoredProcedure : StoredProcedure
    {

        #region Private Variables
        #endregion

        #region Constructor
        /// <summary>
        /// Create a new instance of a 'DeleteCodePropertyStoredProcedure' object.
        /// </summary>
        public DeleteCodePropertyStoredProcedure()
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
                this.ProcedureName = "CodeProperty_Delete";

                // Set tableName
                this.TableName = "CodeProperty";
            }
            #endregion

        #endregion

        #region Properties

        #endregion

    }
    #endregion

}
