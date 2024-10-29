

namespace DataJuggler.DocGen.DataAccessComponent.StoredProcedureManager.DeleteProcedures
{

    #region class DeleteCodeClassStoredProcedure
    /// <summary>
    /// This class is used to Delete a 'CodeClass' object.
    /// </summary>
    public class DeleteCodeClassStoredProcedure : StoredProcedure
    {

        #region Private Variables
        #endregion

        #region Constructor
        /// <summary>
        /// Create a new instance of a 'DeleteCodeClassStoredProcedure' object.
        /// </summary>
        public DeleteCodeClassStoredProcedure()
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
                this.ProcedureName = "CodeClass_Delete";

                // Set tableName
                this.TableName = "CodeClass";
            }
            #endregion

        #endregion

        #region Properties

        #endregion

    }
    #endregion

}
