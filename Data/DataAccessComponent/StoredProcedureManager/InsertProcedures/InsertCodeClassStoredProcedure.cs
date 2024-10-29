

namespace DataJuggler.DocGen.DataAccessComponent.StoredProcedureManager.InsertProcedures
{

    #region class InsertCodeClassStoredProcedure
    /// <summary>
    /// This class is used to Insert a 'CodeClass' object.
    /// </summary>
    public class InsertCodeClassStoredProcedure : StoredProcedure
    {

        #region Private Variables
        #endregion

        #region Constructor
        /// <summary>
        /// Create a new instance of a 'InsertCodeClassStoredProcedure' object.
        /// </summary>
        public InsertCodeClassStoredProcedure()
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
                this.ProcedureName = "CodeClass_Insert";

                // Set tableName
                this.TableName = "CodeClass";
            }
            #endregion

        #endregion

        #region Properties

        #endregion

    }
    #endregion

}
