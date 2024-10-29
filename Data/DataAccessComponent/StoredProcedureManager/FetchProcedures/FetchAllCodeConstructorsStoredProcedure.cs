

namespace DataJuggler.DocGen.DataAccessComponent.StoredProcedureManager.FetchProcedures
{

    #region class FetchAllCodeConstructorsStoredProcedure
    /// <summary>
    /// This class is used to FetchAll 'CodeConstructor' objects.
    /// </summary>
    public class FetchAllCodeConstructorsStoredProcedure : StoredProcedure
    {

        #region Private Variables
        #endregion

        #region Constructor
        /// <summary>
        /// Create a new instance of a 'FetchAllCodeConstructorsStoredProcedure' object.
        /// </summary>
        public FetchAllCodeConstructorsStoredProcedure()
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
                this.ProcedureName = "CodeConstructor_FetchAll";

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
