

namespace DataAccessComponent.StoredProcedureManager.FetchProcedures
{

    #region class FindVSProjectStoredProcedure
    /// <summary>
    /// This class is used to Find a 'VSProject' object.
    /// </summary>
    public class FindVSProjectStoredProcedure : StoredProcedure
    {

        #region Private Variables
        #endregion

        #region Constructor
        /// <summary>
        /// Create a new instance of a 'FindVSProjectStoredProcedure' object.
        /// </summary>
        public FindVSProjectStoredProcedure()
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
                this.ProcedureName = "VSProject_Find";

                // Set tableName
                this.TableName = "VSProject";
            }
            #endregion

        #endregion

        #region Properties

        #endregion

    }
    #endregion

}
