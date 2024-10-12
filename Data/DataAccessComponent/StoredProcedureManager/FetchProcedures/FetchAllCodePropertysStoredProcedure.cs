

namespace DataAccessComponent.StoredProcedureManager.FetchProcedures
{

    #region class FetchAllCodePropertysStoredProcedure
    /// <summary>
    /// This class is used to FetchAll 'CodeProperty' objects.
    /// </summary>
    public class FetchAllCodePropertysStoredProcedure : StoredProcedure
    {

        #region Private Variables
        #endregion

        #region Constructor
        /// <summary>
        /// Create a new instance of a 'FetchAllCodePropertysStoredProcedure' object.
        /// </summary>
        public FetchAllCodePropertysStoredProcedure()
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
                this.ProcedureName = "CodeProperty_FetchAll";

                // Set tableName
                this.TableName = "CodeProperty";
            }
            #endregion

        #endregion

        #region Properties

        #endregion

    }
    #endregion

}
