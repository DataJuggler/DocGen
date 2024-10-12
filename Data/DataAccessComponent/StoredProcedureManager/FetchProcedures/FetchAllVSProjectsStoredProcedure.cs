

namespace DataAccessComponent.StoredProcedureManager.FetchProcedures
{

    #region class FetchAllVSProjectsStoredProcedure
    /// <summary>
    /// This class is used to FetchAll 'VSProject' objects.
    /// </summary>
    public class FetchAllVSProjectsStoredProcedure : StoredProcedure
    {

        #region Private Variables
        #endregion

        #region Constructor
        /// <summary>
        /// Create a new instance of a 'FetchAllVSProjectsStoredProcedure' object.
        /// </summary>
        public FetchAllVSProjectsStoredProcedure()
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
                this.ProcedureName = "VSProject_FetchAll";

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
