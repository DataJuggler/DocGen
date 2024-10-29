

namespace DataJuggler.DocGen.DataAccessComponent.StoredProcedureManager.InsertProcedures
{

    #region class InsertCodePropertyStoredProcedure
    /// <summary>
    /// This class is used to Insert a 'CodeProperty' object.
    /// </summary>
    public class InsertCodePropertyStoredProcedure : StoredProcedure
    {

        #region Private Variables
        #endregion

        #region Constructor
        /// <summary>
        /// Create a new instance of a 'InsertCodePropertyStoredProcedure' object.
        /// </summary>
        public InsertCodePropertyStoredProcedure()
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
                this.ProcedureName = "CodeProperty_Insert";

                // Set tableName
                this.TableName = "CodeProperty";
            }
            #endregion

        #endregion

        #region Properties

        #endregion

    }
    #endregion

}
