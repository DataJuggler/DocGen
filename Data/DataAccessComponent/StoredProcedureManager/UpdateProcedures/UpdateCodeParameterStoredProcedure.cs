

namespace DataJuggler.DocGen.DataAccessComponent.StoredProcedureManager.UpdateProcedures
{

    #region class UpdateCodeParameterStoredProcedure
    /// <summary>
    /// This class is used to Update a 'CodeParameter' object.
    /// </summary>
    public class UpdateCodeParameterStoredProcedure : StoredProcedure
    {

        #region Private Variables
        #endregion

        #region Constructor
        /// <summary>
        /// Create a new instance of a 'UpdateCodeParameterStoredProcedure' object.
        /// </summary>
        public UpdateCodeParameterStoredProcedure()
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
                this.ProcedureName = "CodeParameter_Update";

                // Set tableName
                this.TableName = "CodeParameter";
            }
            #endregion

        #endregion

        #region Properties

        #endregion

    }
    #endregion

}
