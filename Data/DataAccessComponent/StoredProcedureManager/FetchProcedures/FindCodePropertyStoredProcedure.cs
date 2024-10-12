

namespace DataAccessComponent.StoredProcedureManager.FetchProcedures
{

    #region class FindCodePropertyStoredProcedure
    /// <summary>
    /// This class is used to Find a 'CodeProperty' object.
    /// </summary>
    public class FindCodePropertyStoredProcedure : StoredProcedure
    {

        #region Private Variables
        #endregion

        #region Constructor
        /// <summary>
        /// Create a new instance of a 'FindCodePropertyStoredProcedure' object.
        /// </summary>
        public FindCodePropertyStoredProcedure()
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
                this.ProcedureName = "CodeProperty_Find";

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
