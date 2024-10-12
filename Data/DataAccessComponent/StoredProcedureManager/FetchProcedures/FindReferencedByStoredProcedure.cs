

namespace DataAccessComponent.StoredProcedureManager.FetchProcedures
{

    #region class FindReferencedByStoredProcedure
    /// <summary>
    /// This class is used to Find a 'ReferencedBy' object.
    /// </summary>
    public class FindReferencedByStoredProcedure : StoredProcedure
    {

        #region Private Variables
        #endregion

        #region Constructor
        /// <summary>
        /// Create a new instance of a 'FindReferencedByStoredProcedure' object.
        /// </summary>
        public FindReferencedByStoredProcedure()
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
                this.ProcedureName = "ReferencedBy_Find";

                // Set tableName
                this.TableName = "ReferencedBy";
            }
            #endregion

        #endregion

        #region Properties

        #endregion

    }
    #endregion

}
