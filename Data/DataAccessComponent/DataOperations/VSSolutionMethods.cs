

#region using statements

using DataAccessComponent.Data;
using DataAccessComponent.Data.Writers;
using DataAccessComponent.DataBridge;
using DataAccessComponent.StoredProcedureManager.DeleteProcedures;
using DataAccessComponent.StoredProcedureManager.FetchProcedures;
using DataAccessComponent.StoredProcedureManager.InsertProcedures;
using DataAccessComponent.StoredProcedureManager.UpdateProcedures;
using ObjectLibrary.BusinessObjects;
using System;
using System.Collections.Generic;

#endregion


namespace DataAccessComponent.DataOperations
{

    #region class VSSolutionMethods
    /// <summary>
    /// This class contains methods for modifying a 'VSSolution' object.
    /// </summary>
    public class VSSolutionMethods
    {

        #region Private Variables
        private DataManager dataManager;
        #endregion

        #region Constructor
        /// <summary>
        /// Creates a new Creates a new 'VSSolutionMethods' object.
        /// </summary>
        public VSSolutionMethods(DataManager dataManagerArg)
        {
            // Save Argument
            this.DataManager = dataManagerArg;
        }
        #endregion

        #region Methods

            #region DeleteVSSolution(VSSolution)
            /// <summary>
            /// This method deletes a 'VSSolution' object.
            /// </summary>
            /// <param name='List<PolymorphicObject>'>The 'VSSolution' to delete.
            /// <returns>A PolymorphicObject object with a Boolean value.
            internal PolymorphicObject DeleteVSSolution(List<PolymorphicObject> parameters, DataConnector dataConnector)
            {
                // Initial Value
                PolymorphicObject returnObject = new PolymorphicObject();

                // If the data connection is connected
                if ((dataConnector != null) && (dataConnector.Connected == true))
                {
                    // Create Delete StoredProcedure
                    DeleteVSSolutionStoredProcedure deleteVSSolutionProc = null;

                    // verify the first parameters is a(n) 'VSSolution'.
                    if (parameters[0].ObjectValue as VSSolution != null)
                    {
                        // Create VSSolution
                        VSSolution vSSolution = (VSSolution) parameters[0].ObjectValue;

                        // verify vSSolution exists
                        if(vSSolution != null)
                        {
                            // Now create deleteVSSolutionProc from VSSolutionWriter
                            // The DataWriter converts the 'VSSolution'
                            // to the SqlParameter[] array needed to delete a 'VSSolution'.
                            deleteVSSolutionProc = VSSolutionWriter.CreateDeleteVSSolutionStoredProcedure(vSSolution);
                        }
                    }

                    // Verify deleteVSSolutionProc exists
                    if(deleteVSSolutionProc != null)
                    {
                        // Execute Delete Stored Procedure
                        bool deleted = this.DataManager.VSSolutionManager.DeleteVSSolution(deleteVSSolutionProc, dataConnector);

                        // Create returnObject.Boolean
                        returnObject.Boolean = new NullableBoolean();

                        // If delete was successful
                        if(deleted)
                        {
                            // Set returnObject.Boolean.Value to true
                            returnObject.Boolean.Value = NullableBooleanEnum.True;
                        }
                        else
                        {
                            // Set returnObject.Boolean.Value to false
                            returnObject.Boolean.Value = NullableBooleanEnum.False;
                        }
                    }
                }
                else
                {
                    // Raise Error Data Connection Not Available
                    throw new Exception("The database connection is not available.");
                }

                // return value
                return returnObject;
            }
            #endregion

            #region FetchAll()
            /// <summary>
            /// This method fetches all 'VSSolution' objects.
            /// </summary>
            /// <param name='List<PolymorphicObject>'>The 'VSSolution' to delete.
            /// <returns>A PolymorphicObject object with all  'VSSolutions' objects.
            internal PolymorphicObject FetchAll(List<PolymorphicObject> parameters, DataConnector dataConnector)
            {
                // Initial Value
                PolymorphicObject returnObject = new PolymorphicObject();

                // locals
                List<VSSolution> vSSolutionListCollection =  null;

                // Create FetchAll StoredProcedure
                FetchAllVSSolutionsStoredProcedure fetchAllProc = null;

                // If the data connection is connected
                if ((dataConnector != null) && (dataConnector.Connected == true))
                {
                    // Get VSSolutionParameter
                    // Declare Parameter
                    VSSolution paramVSSolution = null;

                    // verify the first parameters is a(n) 'VSSolution'.
                    if (parameters[0].ObjectValue as VSSolution != null)
                    {
                        // Get VSSolutionParameter
                        paramVSSolution = (VSSolution) parameters[0].ObjectValue;
                    }

                    // Now create FetchAllVSSolutionsProc from VSSolutionWriter
                    fetchAllProc = VSSolutionWriter.CreateFetchAllVSSolutionsStoredProcedure(paramVSSolution);
                }

                // Verify fetchAllProc exists
                if(fetchAllProc!= null)
                {
                    // Execute FetchAll Stored Procedure
                    vSSolutionListCollection = this.DataManager.VSSolutionManager.FetchAllVSSolutions(fetchAllProc, dataConnector);

                    // if dataObjectCollection exists
                    if(vSSolutionListCollection != null)
                    {
                        // set returnObject.ObjectValue
                        returnObject.ObjectValue = vSSolutionListCollection;
                    }
                }
                else
                {
                    // Raise Error Data Connection Not Available
                    throw new Exception("The database connection is not available.");
                }

                // return value
                return returnObject;
            }
            #endregion

            #region FindVSSolution(VSSolution)
            /// <summary>
            /// This method finds a 'VSSolution' object.
            /// </summary>
            /// <param name='List<PolymorphicObject>'>The 'VSSolution' to delete.
            /// <returns>A PolymorphicObject object with a Boolean value.
            internal PolymorphicObject FindVSSolution(List<PolymorphicObject> parameters, DataConnector dataConnector)
            {
                // Initial Value
                PolymorphicObject returnObject = new PolymorphicObject();

                // locals
                VSSolution vSSolution = null;

                // If the data connection is connected
                if ((dataConnector != null) && (dataConnector.Connected == true))
                {
                    // Create Find StoredProcedure
                    FindVSSolutionStoredProcedure findVSSolutionProc = null;

                    // verify the first parameters is a 'VSSolution'.
                    if (parameters[0].ObjectValue as VSSolution != null)
                    {
                        // Get VSSolutionParameter
                        VSSolution paramVSSolution = (VSSolution) parameters[0].ObjectValue;

                        // verify paramVSSolution exists
                        if(paramVSSolution != null)
                        {
                            // Now create findVSSolutionProc from VSSolutionWriter
                            // The DataWriter converts the 'VSSolution'
                            // to the SqlParameter[] array needed to find a 'VSSolution'.
                            findVSSolutionProc = VSSolutionWriter.CreateFindVSSolutionStoredProcedure(paramVSSolution);
                        }

                        // Verify findVSSolutionProc exists
                        if(findVSSolutionProc != null)
                        {
                            // Execute Find Stored Procedure
                            vSSolution = this.DataManager.VSSolutionManager.FindVSSolution(findVSSolutionProc, dataConnector);

                            // if dataObject exists
                            if(vSSolution != null)
                            {
                                // set returnObject.ObjectValue
                                returnObject.ObjectValue = vSSolution;
                            }
                        }
                    }
                    else
                    {
                        // Raise Error Data Connection Not Available
                        throw new Exception("The database connection is not available.");
                    }
                }

                // return value
                return returnObject;
            }
            #endregion

            #region InsertVSSolution (VSSolution)
            /// <summary>
            /// This method inserts a 'VSSolution' object.
            /// </summary>
            /// <param name='List<PolymorphicObject>'>The 'VSSolution' to insert.
            /// <returns>A PolymorphicObject object with a Boolean value.
            internal PolymorphicObject InsertVSSolution(List<PolymorphicObject> parameters, DataConnector dataConnector)
            {
                // Initial Value
                PolymorphicObject returnObject = new PolymorphicObject();

                // locals
                VSSolution vSSolution = null;

                // If the data connection is connected
                if ((dataConnector != null) && (dataConnector.Connected == true))
                {
                    // Create Insert StoredProcedure
                    InsertVSSolutionStoredProcedure insertVSSolutionProc = null;

                    // verify the first parameters is a(n) 'VSSolution'.
                    if (parameters[0].ObjectValue as VSSolution != null)
                    {
                        // Create VSSolution Parameter
                        vSSolution = (VSSolution) parameters[0].ObjectValue;

                        // verify vSSolution exists
                        if(vSSolution != null)
                        {
                            // Now create insertVSSolutionProc from VSSolutionWriter
                            // The DataWriter converts the 'VSSolution'
                            // to the SqlParameter[] array needed to insert a 'VSSolution'.
                            insertVSSolutionProc = VSSolutionWriter.CreateInsertVSSolutionStoredProcedure(vSSolution);
                        }

                        // Verify insertVSSolutionProc exists
                        if(insertVSSolutionProc != null)
                        {
                            // Execute Insert Stored Procedure
                            returnObject.IntegerValue = this.DataManager.VSSolutionManager.InsertVSSolution(insertVSSolutionProc, dataConnector);
                        }

                    }
                    else
                    {
                        // Raise Error Data Connection Not Available
                        throw new Exception("The database connection is not available.");
                    }
                }

                // return value
                return returnObject;
            }
            #endregion

            #region UpdateVSSolution (VSSolution)
            /// <summary>
            /// This method updates a 'VSSolution' object.
            /// </summary>
            /// <param name='List<PolymorphicObject>'>The 'VSSolution' to update.
            /// <returns>A PolymorphicObject object with a value.
            internal PolymorphicObject UpdateVSSolution(List<PolymorphicObject> parameters, DataConnector dataConnector)
            {
                // Initial Value
                PolymorphicObject returnObject = new PolymorphicObject();

                // locals
                VSSolution vSSolution = null;

                // If the data connection is connected
                if ((dataConnector != null) && (dataConnector.Connected == true))
                {
                    // Create Update StoredProcedure
                    UpdateVSSolutionStoredProcedure updateVSSolutionProc = null;

                    // verify the first parameters is a(n) 'VSSolution'.
                    if (parameters[0].ObjectValue as VSSolution != null)
                    {
                        // Create VSSolution Parameter
                        vSSolution = (VSSolution) parameters[0].ObjectValue;

                        // verify vSSolution exists
                        if(vSSolution != null)
                        {
                            // Now create updateVSSolutionProc from VSSolutionWriter
                            // The DataWriter converts the 'VSSolution'
                            // to the SqlParameter[] array needed to update a 'VSSolution'.
                            updateVSSolutionProc = VSSolutionWriter.CreateUpdateVSSolutionStoredProcedure(vSSolution);
                        }

                        // Verify updateVSSolutionProc exists
                        if(updateVSSolutionProc != null)
                        {
                            // Execute Update Stored Procedure
                            bool saved = this.DataManager.VSSolutionManager.UpdateVSSolution(updateVSSolutionProc, dataConnector);

                            // Create returnObject.Boolean
                            returnObject.Boolean = new NullableBoolean();

                            // If save was successful
                            if(saved)
                            {
                                // Set returnObject.Boolean.Value to true
                                returnObject.Boolean.Value = NullableBooleanEnum.True;
                            }
                            else
                            {
                                // Set returnObject.Boolean.Value to false
                                returnObject.Boolean.Value = NullableBooleanEnum.False;
                            }
                        }
                        else
                        {
                            // Raise Error Data Connection Not Available
                            throw new Exception("The database connection is not available.");
                        }
                    }
                }

                // return value
                return returnObject;
            }
            #endregion

        #endregion

        #region Properties

            #region DataManager 
            public DataManager DataManager 
            {
                get { return dataManager; }
                set { dataManager = value; }
            }
            #endregion

        #endregion

    }
    #endregion

}
