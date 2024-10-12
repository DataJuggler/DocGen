

namespace DataAccessComponent.StoredProcedureManager.FetchProcedures
{

    #region class FetchAllCodeClassStoredProcedure
    /// <summary>
    /// This class is used to FetchAll 'CodeClass' objects.
    /// </summary>
    public class FetchAllCodeClassStoredProcedure : StoredProcedure
    {

        #region Private Variables
        #endregion

        #region Constructor
        /// <summary>
        /// Create a new instance of a 'FetchAllCodeClassStoredProcedure' object.
        /// </summary>
        public FetchAllCodeClassStoredProcedure()
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
                this.ProcedureName = "CodeClass_FetchAll";

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
