

namespace DataAccessComponent.StoredProcedureManager.InsertProcedures
{

    #region class InsertCodeMethodStoredProcedure
    /// <summary>
    /// This class is used to Insert a 'CodeMethod' object.
    /// </summary>
    public class InsertCodeMethodStoredProcedure : StoredProcedure
    {

        #region Private Variables
        #endregion

        #region Constructor
        /// <summary>
        /// Create a new instance of a 'InsertCodeMethodStoredProcedure' object.
        /// </summary>
        public InsertCodeMethodStoredProcedure()
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
                this.ProcedureName = "CodeMethod_Insert";

                // Set tableName
                this.TableName = "CodeMethod";
            }
            #endregion

        #endregion

        #region Properties

        #endregion

    }
    #endregion

}
