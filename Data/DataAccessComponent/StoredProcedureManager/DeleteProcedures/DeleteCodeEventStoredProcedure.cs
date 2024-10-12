

namespace DataAccessComponent.StoredProcedureManager.DeleteProcedures
{

    #region class DeleteCodeEventStoredProcedure
    /// <summary>
    /// This class is used to Delete a 'CodeEvent' object.
    /// </summary>
    public class DeleteCodeEventStoredProcedure : StoredProcedure
    {

        #region Private Variables
        #endregion

        #region Constructor
        /// <summary>
        /// Create a new instance of a 'DeleteCodeEventStoredProcedure' object.
        /// </summary>
        public DeleteCodeEventStoredProcedure()
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
                this.ProcedureName = "CodeEvent_Delete";

                // Set tableName
                this.TableName = "CodeEvent";
            }
            #endregion

        #endregion

        #region Properties

        #endregion

    }
    #endregion

}
