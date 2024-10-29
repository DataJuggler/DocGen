

namespace DataJuggler.DocGen.DataAccessComponent.StoredProcedureManager.DeleteProcedures
{

    #region class DeleteCodeMethodStoredProcedure
    /// <summary>
    /// This class is used to Delete a 'CodeMethod' object.
    /// </summary>
    public class DeleteCodeMethodStoredProcedure : StoredProcedure
    {

        #region Private Variables
        #endregion

        #region Constructor
        /// <summary>
        /// Create a new instance of a 'DeleteCodeMethodStoredProcedure' object.
        /// </summary>
        public DeleteCodeMethodStoredProcedure()
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
                this.ProcedureName = "CodeMethod_Delete";

                // Set tableName
                this.TableName = "CodeMethod";
            }
            #endregion

        #endregion

        #region Properties

        #endregion

    }
    #endregion

}
