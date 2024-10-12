

namespace DataAccessComponent.StoredProcedureManager.FetchProcedures
{

    #region class FindCodeClassStoredProcedure
    /// <summary>
    /// This class is used to Find a 'CodeClass' object.
    /// </summary>
    public class FindCodeClassStoredProcedure : StoredProcedure
    {

        #region Private Variables
        #endregion

        #region Constructor
        /// <summary>
        /// Create a new instance of a 'FindCodeClassStoredProcedure' object.
        /// </summary>
        public FindCodeClassStoredProcedure()
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
                this.ProcedureName = "CodeClass_Find";

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
