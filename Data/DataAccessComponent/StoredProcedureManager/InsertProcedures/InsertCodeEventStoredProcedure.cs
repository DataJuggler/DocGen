

namespace DataAccessComponent.StoredProcedureManager.InsertProcedures
{

    #region class InsertCodeEventStoredProcedure
    /// <summary>
    /// This class is used to Insert a 'CodeEvent' object.
    /// </summary>
    public class InsertCodeEventStoredProcedure : StoredProcedure
    {

        #region Private Variables
        #endregion

        #region Constructor
        /// <summary>
        /// Create a new instance of a 'InsertCodeEventStoredProcedure' object.
        /// </summary>
        public InsertCodeEventStoredProcedure()
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
                this.ProcedureName = "CodeEvent_Insert";

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
