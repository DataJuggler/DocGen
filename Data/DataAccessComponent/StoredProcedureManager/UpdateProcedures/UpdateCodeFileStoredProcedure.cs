

namespace DataJuggler.DocGen.DataAccessComponent.StoredProcedureManager.UpdateProcedures
{

    #region class UpdateCodeFileStoredProcedure
    /// <summary>
    /// This class is used to Update a 'CodeFile' object.
    /// </summary>
    public class UpdateCodeFileStoredProcedure : StoredProcedure
    {

        #region Private Variables
        #endregion

        #region Constructor
        /// <summary>
        /// Create a new instance of a 'UpdateCodeFileStoredProcedure' object.
        /// </summary>
        public UpdateCodeFileStoredProcedure()
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
                this.ProcedureName = "CodeFile_Update";

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
