

namespace DataAccessComponent.StoredProcedureManager.FetchProcedures
{

    #region class FindCodeConstructorStoredProcedure
    /// <summary>
    /// This class is used to Find a 'CodeConstructor' object.
    /// </summary>
    public class FindCodeConstructorStoredProcedure : StoredProcedure
    {

        #region Private Variables
        #endregion

        #region Constructor
        /// <summary>
        /// Create a new instance of a 'FindCodeConstructorStoredProcedure' object.
        /// </summary>
        public FindCodeConstructorStoredProcedure()
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
                this.ProcedureName = "CodeConstructor_Find";

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
