

namespace DataJuggler.DocGen.DataAccessComponent.StoredProcedureManager.FetchProcedures
{

    #region class FindCodeSampleStoredProcedure
    /// <summary>
    /// This class is used to Find a 'CodeSample' object.
    /// </summary>
    public class FindCodeSampleStoredProcedure : StoredProcedure
    {

        #region Private Variables
        #endregion

        #region Constructor
        /// <summary>
        /// Create a new instance of a 'FindCodeSampleStoredProcedure' object.
        /// </summary>
        public FindCodeSampleStoredProcedure()
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
                this.ProcedureName = "CodeSample_Find";

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
