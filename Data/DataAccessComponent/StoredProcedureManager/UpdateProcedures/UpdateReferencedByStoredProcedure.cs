

namespace DataJuggler.DocGen.DataAccessComponent.StoredProcedureManager.UpdateProcedures
{

    #region class UpdateReferencedByStoredProcedure
    /// <summary>
    /// This class is used to Update a 'ReferencedBy' object.
    /// </summary>
    public class UpdateReferencedByStoredProcedure : StoredProcedure
    {

        #region Private Variables
        #endregion

        #region Constructor
        /// <summary>
        /// Create a new instance of a 'UpdateReferencedByStoredProcedure' object.
        /// </summary>
        public UpdateReferencedByStoredProcedure()
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
                this.ProcedureName = "ReferencedBy_Update";

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
