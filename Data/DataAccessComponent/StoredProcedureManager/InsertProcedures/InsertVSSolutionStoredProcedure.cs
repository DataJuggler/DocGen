

namespace DataAccessComponent.StoredProcedureManager.InsertProcedures
{

    #region class InsertVSSolutionStoredProcedure
    /// <summary>
    /// This class is used to Insert a 'VSSolution' object.
    /// </summary>
    public class InsertVSSolutionStoredProcedure : StoredProcedure
    {

        #region Private Variables
        #endregion

        #region Constructor
        /// <summary>
        /// Create a new instance of a 'InsertVSSolutionStoredProcedure' object.
        /// </summary>
        public InsertVSSolutionStoredProcedure()
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
                this.ProcedureName = "VSSolution_Insert";

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
