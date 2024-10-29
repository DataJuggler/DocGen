

namespace DataJuggler.DocGen.DataAccessComponent.StoredProcedureManager.FetchProcedures
{

    #region class FetchAllCodeMethodsStoredProcedure
    /// <summary>
    /// This class is used to FetchAll 'CodeMethod' objects.
    /// </summary>
    public class FetchAllCodeMethodsStoredProcedure : StoredProcedure
    {

        #region Private Variables
        #endregion

        #region Constructor
        /// <summary>
        /// Create a new instance of a 'FetchAllCodeMethodsStoredProcedure' object.
        /// </summary>
        public FetchAllCodeMethodsStoredProcedure()
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
                this.ProcedureName = "CodeMethod_FetchAll";

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
