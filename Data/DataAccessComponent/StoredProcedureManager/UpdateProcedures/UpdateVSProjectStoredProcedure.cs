

namespace DataJuggler.DocGen.DataAccessComponent.StoredProcedureManager.UpdateProcedures
{

    #region class UpdateVSProjectStoredProcedure
    /// <summary>
    /// This class is used to Update a 'VSProject' object.
    /// </summary>
    public class UpdateVSProjectStoredProcedure : StoredProcedure
    {

        #region Private Variables
        #endregion

        #region Constructor
        /// <summary>
        /// Create a new instance of a 'UpdateVSProjectStoredProcedure' object.
        /// </summary>
        public UpdateVSProjectStoredProcedure()
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
                this.ProcedureName = "VSProject_Update";

                // Set tableName
                this.TableName = "VSProject";
            }
            #endregion

        #endregion

        #region Properties

        #endregion

    }
    #endregion

}
