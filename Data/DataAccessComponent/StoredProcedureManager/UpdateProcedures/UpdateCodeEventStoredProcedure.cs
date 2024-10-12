

namespace DataAccessComponent.StoredProcedureManager.UpdateProcedures
{

    #region class UpdateCodeEventStoredProcedure
    /// <summary>
    /// This class is used to Update a 'CodeEvent' object.
    /// </summary>
    public class UpdateCodeEventStoredProcedure : StoredProcedure
    {

        #region Private Variables
        #endregion

        #region Constructor
        /// <summary>
        /// Create a new instance of a 'UpdateCodeEventStoredProcedure' object.
        /// </summary>
        public UpdateCodeEventStoredProcedure()
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
                this.ProcedureName = "CodeEvent_Update";

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
