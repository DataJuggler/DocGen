

namespace DataJuggler.DocGen.DataAccessComponent.StoredProcedureManager.FetchProcedures
{

    #region class FetchAllVSSolutionsStoredProcedure
    /// <summary>
    /// This class is used to FetchAll 'VSSolution' objects.
    /// </summary>
    public class FetchAllVSSolutionsStoredProcedure : StoredProcedure
    {

        #region Private Variables
        #endregion

        #region Constructor
        /// <summary>
        /// Create a new instance of a 'FetchAllVSSolutionsStoredProcedure' object.
        /// </summary>
        public FetchAllVSSolutionsStoredProcedure()
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
                this.ProcedureName = "VSSolution_FetchAll";

                // Set tableName
                this.TableName = "VSSolution";
            }
            #endregion

        #endregion

        #region Properties

        #endregion

    }
    #endregion

}
