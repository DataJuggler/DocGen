

namespace DataJuggler.DocGen.DataAccessComponent.StoredProcedureManager.DeleteProcedures
{

    #region class DeleteReferencedByStoredProcedure
    /// <summary>
    /// This class is used to Delete a 'ReferencedBy' object.
    /// </summary>
    public class DeleteReferencedByStoredProcedure : StoredProcedure
    {

        #region Private Variables
        #endregion

        #region Constructor
        /// <summary>
        /// Create a new instance of a 'DeleteReferencedByStoredProcedure' object.
        /// </summary>
        public DeleteReferencedByStoredProcedure()
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
                this.ProcedureName = "ReferencedBy_Delete";

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
