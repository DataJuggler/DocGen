

namespace DataJuggler.DocGen.DataAccessComponent.StoredProcedureManager.DeleteProcedures
{

    #region class DeleteCodeFileStoredProcedure
    /// <summary>
    /// This class is used to Delete a 'CodeFile' object.
    /// </summary>
    public class DeleteCodeFileStoredProcedure : StoredProcedure
    {

        #region Private Variables
        #endregion

        #region Constructor
        /// <summary>
        /// Create a new instance of a 'DeleteCodeFileStoredProcedure' object.
        /// </summary>
        public DeleteCodeFileStoredProcedure()
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
                this.ProcedureName = "CodeFile_Delete";

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
