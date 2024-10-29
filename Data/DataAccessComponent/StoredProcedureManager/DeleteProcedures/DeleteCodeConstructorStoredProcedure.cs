

namespace DataJuggler.DocGen.DataAccessComponent.StoredProcedureManager.DeleteProcedures
{

    #region class DeleteCodeConstructorStoredProcedure
    /// <summary>
    /// This class is used to Delete a 'CodeConstructor' object.
    /// </summary>
    public class DeleteCodeConstructorStoredProcedure : StoredProcedure
    {

        #region Private Variables
        #endregion

        #region Constructor
        /// <summary>
        /// Create a new instance of a 'DeleteCodeConstructorStoredProcedure' object.
        /// </summary>
        public DeleteCodeConstructorStoredProcedure()
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
                this.ProcedureName = "CodeConstructor_Delete";

                // Set tableName
                this.TableName = "CodeConstructor";
            }
            #endregion

        #endregion

        #region Properties

        #endregion

    }
    #endregion

}
