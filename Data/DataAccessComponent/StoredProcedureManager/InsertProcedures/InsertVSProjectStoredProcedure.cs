

namespace DataAccessComponent.StoredProcedureManager.InsertProcedures
{

    #region class InsertVSProjectStoredProcedure
    /// <summary>
    /// This class is used to Insert a 'VSProject' object.
    /// </summary>
    public class InsertVSProjectStoredProcedure : StoredProcedure
    {

        #region Private Variables
        #endregion

        #region Constructor
        /// <summary>
        /// Create a new instance of a 'InsertVSProjectStoredProcedure' object.
        /// </summary>
        public InsertVSProjectStoredProcedure()
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
                this.ProcedureName = "VSProject_Insert";

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
