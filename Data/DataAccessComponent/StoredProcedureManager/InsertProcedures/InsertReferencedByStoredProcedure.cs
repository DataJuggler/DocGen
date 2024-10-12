

namespace DataAccessComponent.StoredProcedureManager.InsertProcedures
{

    #region class InsertReferencedByStoredProcedure
    /// <summary>
    /// This class is used to Insert a 'ReferencedBy' object.
    /// </summary>
    public class InsertReferencedByStoredProcedure : StoredProcedure
    {

        #region Private Variables
        #endregion

        #region Constructor
        /// <summary>
        /// Create a new instance of a 'InsertReferencedByStoredProcedure' object.
        /// </summary>
        public InsertReferencedByStoredProcedure()
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
                this.ProcedureName = "ReferencedBy_Insert";

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
