

namespace DataAccessComponent.StoredProcedureManager.FetchProcedures
{

    #region class FindCodeEventStoredProcedure
    /// <summary>
    /// This class is used to Find a 'CodeEvent' object.
    /// </summary>
    public class FindCodeEventStoredProcedure : StoredProcedure
    {

        #region Private Variables
        #endregion

        #region Constructor
        /// <summary>
        /// Create a new instance of a 'FindCodeEventStoredProcedure' object.
        /// </summary>
        public FindCodeEventStoredProcedure()
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
                this.ProcedureName = "CodeEvent_Find";

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
