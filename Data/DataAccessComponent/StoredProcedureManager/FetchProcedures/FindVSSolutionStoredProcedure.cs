

namespace DataAccessComponent.StoredProcedureManager.FetchProcedures
{

    #region class FindVSSolutionStoredProcedure
    /// <summary>
    /// This class is used to Find a 'VSSolution' object.
    /// </summary>
    public class FindVSSolutionStoredProcedure : StoredProcedure
    {

        #region Private Variables
        #endregion

        #region Constructor
        /// <summary>
        /// Create a new instance of a 'FindVSSolutionStoredProcedure' object.
        /// </summary>
        public FindVSSolutionStoredProcedure()
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
                this.ProcedureName = "VSSolution_Find";

                // Set tableName
                this.TableName = "VSSolution";
            }
            #endregion

        #endregion

        #region Properties

        #endregion

    }
    #endregion

}
