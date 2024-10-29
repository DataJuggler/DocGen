

namespace DataJuggler.DocGen.DataAccessComponent.StoredProcedureManager.FetchProcedures
{

    #region class FetchAllReferencedBysStoredProcedure
    /// <summary>
    /// This class is used to FetchAll 'ReferencedBy' objects.
    /// </summary>
    public class FetchAllReferencedBysStoredProcedure : StoredProcedure
    {

        #region Private Variables
        #endregion

        #region Constructor
        /// <summary>
        /// Create a new instance of a 'FetchAllReferencedBysStoredProcedure' object.
        /// </summary>
        public FetchAllReferencedBysStoredProcedure()
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
                this.ProcedureName = "ReferencedBy_FetchAll";

                // Set tableName
                this.TableName = "ReferencedBy";
            }
            #endregion

        #endregion

        #region Properties

        #endregion

    }
    #endregion

}
