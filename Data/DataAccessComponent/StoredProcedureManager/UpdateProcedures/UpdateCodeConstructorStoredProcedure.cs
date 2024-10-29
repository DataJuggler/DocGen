

namespace DataJuggler.DocGen.DataAccessComponent.StoredProcedureManager.UpdateProcedures
{

    #region class UpdateCodeConstructorStoredProcedure
    /// <summary>
    /// This class is used to Update a 'CodeConstructor' object.
    /// </summary>
    public class UpdateCodeConstructorStoredProcedure : StoredProcedure
    {

        #region Private Variables
        #endregion

        #region Constructor
        /// <summary>
        /// Create a new instance of a 'UpdateCodeConstructorStoredProcedure' object.
        /// </summary>
        public UpdateCodeConstructorStoredProcedure()
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
                this.ProcedureName = "CodeConstructor_Update";

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
