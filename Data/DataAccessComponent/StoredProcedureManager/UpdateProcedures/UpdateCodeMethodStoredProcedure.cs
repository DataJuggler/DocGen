

namespace DataAccessComponent.StoredProcedureManager.UpdateProcedures
{

    #region class UpdateCodeMethodStoredProcedure
    /// <summary>
    /// This class is used to Update a 'CodeMethod' object.
    /// </summary>
    public class UpdateCodeMethodStoredProcedure : StoredProcedure
    {

        #region Private Variables
        #endregion

        #region Constructor
        /// <summary>
        /// Create a new instance of a 'UpdateCodeMethodStoredProcedure' object.
        /// </summary>
        public UpdateCodeMethodStoredProcedure()
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
                this.ProcedureName = "CodeMethod_Update";

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
