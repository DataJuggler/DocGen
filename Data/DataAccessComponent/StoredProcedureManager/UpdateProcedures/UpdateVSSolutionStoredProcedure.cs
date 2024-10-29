

namespace DataJuggler.DocGen.DataAccessComponent.StoredProcedureManager.UpdateProcedures
{

    #region class UpdateVSSolutionStoredProcedure
    /// <summary>
    /// This class is used to Update a 'VSSolution' object.
    /// </summary>
    public class UpdateVSSolutionStoredProcedure : StoredProcedure
    {

        #region Private Variables
        #endregion

        #region Constructor
        /// <summary>
        /// Create a new instance of a 'UpdateVSSolutionStoredProcedure' object.
        /// </summary>
        public UpdateVSSolutionStoredProcedure()
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
                this.ProcedureName = "VSSolution_Update";

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
