

namespace DataAccessComponent.StoredProcedureManager.UpdateProcedures
{

    #region class UpdateCodePropertyStoredProcedure
    /// <summary>
    /// This class is used to Update a 'CodeProperty' object.
    /// </summary>
    public class UpdateCodePropertyStoredProcedure : StoredProcedure
    {

        #region Private Variables
        #endregion

        #region Constructor
        /// <summary>
        /// Create a new instance of a 'UpdateCodePropertyStoredProcedure' object.
        /// </summary>
        public UpdateCodePropertyStoredProcedure()
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
                this.ProcedureName = "CodeProperty_Update";

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
