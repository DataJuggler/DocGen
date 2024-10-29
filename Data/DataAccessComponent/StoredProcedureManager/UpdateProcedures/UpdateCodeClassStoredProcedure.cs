

namespace DataJuggler.DocGen.DataAccessComponent.StoredProcedureManager.UpdateProcedures
{

    #region class UpdateCodeClassStoredProcedure
    /// <summary>
    /// This class is used to Update a 'CodeClass' object.
    /// </summary>
    public class UpdateCodeClassStoredProcedure : StoredProcedure
    {

        #region Private Variables
        #endregion

        #region Constructor
        /// <summary>
        /// Create a new instance of a 'UpdateCodeClassStoredProcedure' object.
        /// </summary>
        public UpdateCodeClassStoredProcedure()
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
                this.ProcedureName = "CodeClass_Update";

                // Set tableName
                this.TableName = "CodeClass";
            }
            #endregion

        #endregion

        #region Properties

        #endregion

    }
    #endregion

}
