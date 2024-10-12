

namespace DataAccessComponent.StoredProcedureManager.DeleteProcedures
{

    #region class DeleteVSProjectStoredProcedure
    /// <summary>
    /// This class is used to Delete a 'VSProject' object.
    /// </summary>
    public class DeleteVSProjectStoredProcedure : StoredProcedure
    {

        #region Private Variables
        #endregion

        #region Constructor
        /// <summary>
        /// Create a new instance of a 'DeleteVSProjectStoredProcedure' object.
        /// </summary>
        public DeleteVSProjectStoredProcedure()
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
                this.ProcedureName = "VSProject_Delete";

                // Set tableName
                this.TableName = "VSProject";
            }
            #endregion

        #endregion

        #region Properties

        #endregion

    }
    #endregion

}
