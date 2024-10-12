

namespace DataAccessComponent.StoredProcedureManager.FetchProcedures
{

    #region class FindCodeParameterStoredProcedure
    /// <summary>
    /// This class is used to Find a 'CodeParameter' object.
    /// </summary>
    public class FindCodeParameterStoredProcedure : StoredProcedure
    {

        #region Private Variables
        #endregion

        #region Constructor
        /// <summary>
        /// Create a new instance of a 'FindCodeParameterStoredProcedure' object.
        /// </summary>
        public FindCodeParameterStoredProcedure()
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
                this.ProcedureName = "CodeParameter_Find";

                // Set tableName
                this.TableName = "CodeParameter";
            }
            #endregion

        #endregion

        #region Properties

        #endregion

    }
    #endregion

}
