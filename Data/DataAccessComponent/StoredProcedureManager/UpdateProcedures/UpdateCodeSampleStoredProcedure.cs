

namespace DataJuggler.DocGen.DataAccessComponent.StoredProcedureManager.UpdateProcedures
{

    #region class UpdateCodeSampleStoredProcedure
    /// <summary>
    /// This class is used to Update a 'CodeSample' object.
    /// </summary>
    public class UpdateCodeSampleStoredProcedure : StoredProcedure
    {

        #region Private Variables
        #endregion

        #region Constructor
        /// <summary>
        /// Create a new instance of a 'UpdateCodeSampleStoredProcedure' object.
        /// </summary>
        public UpdateCodeSampleStoredProcedure()
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
                this.ProcedureName = "CodeSample_Update";

                // Set tableName
                this.TableName = "CodeSample";
            }
            #endregion

        #endregion

        #region Properties

        #endregion

    }
    #endregion

}
