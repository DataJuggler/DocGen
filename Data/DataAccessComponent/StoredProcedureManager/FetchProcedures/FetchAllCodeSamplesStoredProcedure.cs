

namespace DataAccessComponent.StoredProcedureManager.FetchProcedures
{

    #region class FetchAllCodeSamplesStoredProcedure
    /// <summary>
    /// This class is used to FetchAll 'CodeSample' objects.
    /// </summary>
    public class FetchAllCodeSamplesStoredProcedure : StoredProcedure
    {

        #region Private Variables
        #endregion

        #region Constructor
        /// <summary>
        /// Create a new instance of a 'FetchAllCodeSamplesStoredProcedure' object.
        /// </summary>
        public FetchAllCodeSamplesStoredProcedure()
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
                this.ProcedureName = "CodeSample_FetchAll";

                // Set tableName
                this.TableName = "CodeSample";
            }
            #endregion

        #endregion

        #region Properties

        #endregion

    }
    #endregion

}
