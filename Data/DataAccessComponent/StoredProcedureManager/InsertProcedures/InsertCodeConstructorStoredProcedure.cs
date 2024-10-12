

namespace DataAccessComponent.StoredProcedureManager.InsertProcedures
{

    #region class InsertCodeConstructorStoredProcedure
    /// <summary>
    /// This class is used to Insert a 'CodeConstructor' object.
    /// </summary>
    public class InsertCodeConstructorStoredProcedure : StoredProcedure
    {

        #region Private Variables
        #endregion

        #region Constructor
        /// <summary>
        /// Create a new instance of a 'InsertCodeConstructorStoredProcedure' object.
        /// </summary>
        public InsertCodeConstructorStoredProcedure()
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
                this.ProcedureName = "CodeConstructor_Insert";

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
