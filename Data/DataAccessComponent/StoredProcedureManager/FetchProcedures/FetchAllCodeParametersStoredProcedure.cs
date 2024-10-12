

namespace DataAccessComponent.StoredProcedureManager.FetchProcedures
{

    #region class FetchAllCodeParametersStoredProcedure
    /// <summary>
    /// This class is used to FetchAll 'CodeParameter' objects.
    /// </summary>
    public class FetchAllCodeParametersStoredProcedure : StoredProcedure
    {

        #region Private Variables
        #endregion

        #region Constructor
        /// <summary>
        /// Create a new instance of a 'FetchAllCodeParametersStoredProcedure' object.
        /// </summary>
        public FetchAllCodeParametersStoredProcedure()
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
                this.ProcedureName = "CodeParameter_FetchAll";

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
