

namespace DataJuggler.DocGen.DataAccessComponent.StoredProcedureManager.FetchProcedures
{

    #region class FindCodeFileStoredProcedure
    /// <summary>
    /// This class is used to Find a 'CodeFile' object.
    /// </summary>
    public class FindCodeFileStoredProcedure : StoredProcedure
    {

        #region Private Variables
        #endregion

        #region Constructor
        /// <summary>
        /// Create a new instance of a 'FindCodeFileStoredProcedure' object.
        /// </summary>
        public FindCodeFileStoredProcedure()
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
                this.ProcedureName = "CodeFile_Find";

                // Set tableName
                this.TableName = "CodeFile";
            }
            #endregion

        #endregion

        #region Properties

        #endregion

    }
    #endregion

}
