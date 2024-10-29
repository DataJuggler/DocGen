

namespace DataJuggler.DocGen.DataAccessComponent.StoredProcedureManager.DeleteProcedures
{

    #region class DeleteVSSolutionStoredProcedure
    /// <summary>
    /// This class is used to Delete a 'VSSolution' object.
    /// </summary>
    public class DeleteVSSolutionStoredProcedure : StoredProcedure
    {

        #region Private Variables
        #endregion

        #region Constructor
        /// <summary>
        /// Create a new instance of a 'DeleteVSSolutionStoredProcedure' object.
        /// </summary>
        public DeleteVSSolutionStoredProcedure()
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
                this.ProcedureName = "VSSolution_Delete";

                // Set tableName
                this.TableName = "VSSolution";
            }
            #endregion

        #endregion

        #region Properties

        #endregion

    }
    #endregion

}
