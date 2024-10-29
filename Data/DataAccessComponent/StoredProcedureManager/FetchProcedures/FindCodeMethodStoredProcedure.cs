

namespace DataJuggler.DocGen.DataAccessComponent.StoredProcedureManager.FetchProcedures
{

    #region class FindCodeMethodStoredProcedure
    /// <summary>
    /// This class is used to Find a 'CodeMethod' object.
    /// </summary>
    public class FindCodeMethodStoredProcedure : StoredProcedure
    {

        #region Private Variables
        #endregion

        #region Constructor
        /// <summary>
        /// Create a new instance of a 'FindCodeMethodStoredProcedure' object.
        /// </summary>
        public FindCodeMethodStoredProcedure()
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
                this.ProcedureName = "CodeMethod_Find";

                // Set tableName
                this.TableName = "CodeMethod";
            }
            #endregion

        #endregion

        #region Properties

        #endregion

    }
    #endregion

}
