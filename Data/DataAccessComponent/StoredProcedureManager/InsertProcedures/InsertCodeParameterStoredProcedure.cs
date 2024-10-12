

namespace DataAccessComponent.StoredProcedureManager.InsertProcedures
{

    #region class InsertCodeParameterStoredProcedure
    /// <summary>
    /// This class is used to Insert a 'CodeParameter' object.
    /// </summary>
    public class InsertCodeParameterStoredProcedure : StoredProcedure
    {

        #region Private Variables
        #endregion

        #region Constructor
        /// <summary>
        /// Create a new instance of a 'InsertCodeParameterStoredProcedure' object.
        /// </summary>
        public InsertCodeParameterStoredProcedure()
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
                this.ProcedureName = "CodeParameter_Insert";

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
