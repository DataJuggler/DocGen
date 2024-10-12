

namespace DataAccessComponent.StoredProcedureManager.FetchProcedures
{

    #region class FetchAllCodeEventsStoredProcedure
    /// <summary>
    /// This class is used to FetchAll 'CodeEvent' objects.
    /// </summary>
    public class FetchAllCodeEventsStoredProcedure : StoredProcedure
    {

        #region Private Variables
        #endregion

        #region Constructor
        /// <summary>
        /// Create a new instance of a 'FetchAllCodeEventsStoredProcedure' object.
        /// </summary>
        public FetchAllCodeEventsStoredProcedure()
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
                this.ProcedureName = "CodeEvent_FetchAll";

                // Set tableName
                this.TableName = "CodeEvent";
            }
            #endregion

        #endregion

        #region Properties

        #endregion

    }
    #endregion

}
