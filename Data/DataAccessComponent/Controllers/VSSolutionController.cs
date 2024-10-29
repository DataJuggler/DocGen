

#region using statements

using DataJuggler.DocGen.DataAccessComponent.DataBridge;
using DataJuggler.DocGen.DataAccessComponent.DataOperations;
using DataJuggler.DocGen.DataAccessComponent.Logging;
using DataJuggler.DocGen.ObjectLibrary.BusinessObjects;
using System;
using System.Collections.Generic;

#endregion


namespace DataJuggler.DocGen.DataAccessComponent.Controllers
{

    #region class VSSolutionController
    /// <summary>
    /// This class controls a(n) 'VSSolution' object.
    /// </summary>
    public class VSSolutionController
    {

        #region Private Variables
        private ErrorHandler errorProcessor;
        private ApplicationController appController;
        #endregion

        #region Constructor
        /// <summary>
        /// Creates a new 'VSSolutionController' object.
        /// </summary>
        public VSSolutionController(ErrorHandler errorProcessorArg, ApplicationController appControllerArg)
        {
            // Save Arguments
            this.ErrorProcessor = errorProcessorArg;
            this.AppController = appControllerArg;
        }
        #endregion

        #region Methods

            #region CreateVSSolutionParameter
            /// <summary>
            /// This method creates the parameter for a 'VSSolution' data operation.
            /// </summary>
            /// <param name='vssolution'>The 'VSSolution' to use as the first
            /// parameter (parameters[0]).</param>
            /// <returns>A List<PolymorphicObject> collection.</returns>
            private static List<PolymorphicObject> CreateVSSolutionParameter(VSSolution vSSolution)
            {
                // Initial Value
                List<PolymorphicObject> parameters = new List<PolymorphicObject>();

                // Create PolymorphicObject to hold the parameter
                PolymorphicObject parameter = new PolymorphicObject();

                // Set parameter.ObjectValue
                parameter.ObjectValue = vSSolution;

                // Add userParameter to parameters
                parameters.Add(parameter);

                // return value
                return parameters;
            }
            #endregion

            #region Delete(VSSolution tempVSSolution)
            /// <summary>
            /// Deletes a 'VSSolution' from the database
            /// This method calls the DataBridgeManager to execute the delete using the
            /// procedure 'VSSolution_Delete'.
            /// </summary>
            /// <param name='vssolution'>The 'VSSolution' to delete.</param>
            /// <returns>True if the delete is successful or false if not.</returns>
            public bool Delete(VSSolution tempVSSolution)
            {
                // locals
                bool deleted = false;

                // Get information for calling 'DataBridgeManager.PerformDataOperation' method.
                string methodName = "DeleteVSSolution";
                string objectName = "ApplicationLogicComponent.Controllers";

                try
                {
                    // verify tempvSSolution exists before attemptintg to delete
                    if(tempVSSolution != null)
                    {
                        // Create Delegate For DataOperation
                        ApplicationController.DataOperationMethod deleteVSSolutionMethod = this.AppController.DataBridge.DataOperations.VSSolutionMethods.DeleteVSSolution;

                        // Create parameters for this method
                        List<PolymorphicObject> parameters = CreateVSSolutionParameter(tempVSSolution);

                        // Perform DataOperation
                        PolymorphicObject returnObject = this.AppController.DataBridge.PerformDataOperation(methodName, objectName, deleteVSSolutionMethod, parameters);

                        // If return object exists
                        if (returnObject != null)
                        {
                            // Test For True
                            if (returnObject.Boolean.Value == NullableBooleanEnum.True)
                            {
                                // Set Deleted To True
                                deleted = true;
                            }
                        }
                    }
                }
                catch (Exception error)
                {
                    // If ErrorProcessor exists
                    if (this.ErrorProcessor != null)
                    {
                        // Log the current error
                        this.ErrorProcessor.LogError(methodName, objectName, error);
                    }
                }

                // return value
                return deleted;
            }
            #endregion

            #region FetchAll(VSSolution tempVSSolution)
            /// <summary>
            /// This method fetches a collection of 'VSSolution' objects.
            /// This method used the DataBridgeManager to execute the fetch all using the
            /// procedure 'VSSolution_FetchAll'.</summary>
            /// <param name='tempVSSolution'>A temporary VSSolution for passing values.</param>
            /// <returns>A collection of 'VSSolution' objects.</returns>
            public List<VSSolution> FetchAll(VSSolution tempVSSolution)
            {
                // Initial value
                List<VSSolution> vSSolutionList = null;

                // Get information for calling 'DataBridgeManager.PerformDataOperation' method.
                string methodName = "FetchAll";
                string objectName = "ApplicationLogicComponent.Controllers";

                try
                {
                    // Create DataOperation Method
                    ApplicationController.DataOperationMethod fetchAllMethod = this.AppController.DataBridge.DataOperations.VSSolutionMethods.FetchAll;

                    // Create parameters for this method
                    List<PolymorphicObject> parameters = CreateVSSolutionParameter(tempVSSolution);

                    // Perform DataOperation
                    PolymorphicObject returnObject = this.AppController.DataBridge.PerformDataOperation(methodName, objectName, fetchAllMethod , parameters);

                    // If return object exists
                    if ((returnObject != null) && (returnObject.ObjectValue as List<VSSolution> != null))
                    {
                        // Create Collection From ReturnObject.ObjectValue
                        vSSolutionList = (List<VSSolution>) returnObject.ObjectValue;
                    }
                }
                catch (Exception error)
                {
                    // If ErrorProcessor exists
                    if (this.ErrorProcessor != null)
                    {
                        // Log the current error
                        this.ErrorProcessor.LogError(methodName, objectName, error);
                    }
                }

                // return value
                return vSSolutionList;
            }
            #endregion

            #region Find(VSSolution tempVSSolution)
            /// <summary>
            /// Finds a 'VSSolution' object by the primary key.
            /// This method used the DataBridgeManager to execute the 'Find' using the
            /// procedure 'VSSolution_Find'</param>
            /// </summary>
            /// <param name='tempVSSolution'>A temporary VSSolution for passing values.</param>
            /// <returns>A 'VSSolution' object if found else a null 'VSSolution'.</returns>
            public VSSolution Find(VSSolution tempVSSolution)
            {
                // Initial values
                VSSolution vSSolution = null;

                // Get information for calling 'DataBridgeManager.PerformDataOperation' method.
                string methodName = "Find";
                string objectName = "ApplicationLogicComponent.Controllers";

                try
                {
                    // If object exists
                    if(tempVSSolution != null)
                    {
                        // Create DataOperation
                        ApplicationController.DataOperationMethod findMethod = this.AppController.DataBridge.DataOperations.VSSolutionMethods.FindVSSolution;

                        // Create parameters for this method
                        List<PolymorphicObject> parameters = CreateVSSolutionParameter(tempVSSolution);

                        // Perform DataOperation
                        PolymorphicObject returnObject = this.AppController.DataBridge.PerformDataOperation(methodName, objectName, findMethod , parameters);

                        // If return object exists
                        if ((returnObject != null) && (returnObject.ObjectValue as VSSolution != null))
                        {
                            // Get ReturnObject
                            vSSolution = (VSSolution) returnObject.ObjectValue;
                        }
                    }
                }
                catch (Exception error)
                {
                    // If ErrorProcessor exists
                    if (this.ErrorProcessor != null)
                    {
                        // Log the current error
                        this.ErrorProcessor.LogError(methodName, objectName, error);
                    }
                }

                // return value
                return vSSolution;
            }
            #endregion

            #region Insert(VSSolution vSSolution)
            /// <summary>
            /// Insert a 'VSSolution' object into the database.
            /// This method uses the DataBridgeManager to execute the 'Insert' using the
            /// procedure 'VSSolution_Insert'.</param>
            /// </summary>
            /// <param name='vSSolution'>The 'VSSolution' object to insert.</param>
            /// <returns>The id (int) of the new  'VSSolution' object that was inserted.</returns>
            public int Insert(VSSolution vSSolution)
            {
                // Initial values
                int newIdentity = -1;

                // Get information for calling 'DataBridgeManager.PerformDataOperation' method.
                string methodName = "Insert";
                string objectName = "ApplicationLogicComponent.Controllers";

                try
                {
                    // If VSSolutionexists
                    if(vSSolution != null)
                    {
                        ApplicationController.DataOperationMethod insertMethod = this.AppController.DataBridge.DataOperations.VSSolutionMethods.InsertVSSolution;

                        // Create parameters for this method
                        List<PolymorphicObject> parameters = CreateVSSolutionParameter(vSSolution);

                        // Perform DataOperation
                        PolymorphicObject returnObject = this.AppController.DataBridge.PerformDataOperation(methodName, objectName, insertMethod , parameters);

                        // If return object exists
                        if (returnObject != null)
                        {
                            // Set return value
                            newIdentity = returnObject.IntegerValue;
                        }
                    }
                }
                catch (Exception error)
                {
                    // If ErrorProcessor exists
                    if (this.ErrorProcessor != null)
                    {
                        // Log the current error
                        this.ErrorProcessor.LogError(methodName, objectName, error);
                    }
                }

                // return value
                return newIdentity;
            }
            #endregion

            #region Save(ref VSSolution vSSolution)
            /// <summary>
            /// Saves a 'VSSolution' object into the database.
            /// This method calls the 'Insert' or 'Update' method.
            /// </summary>
            /// <param name='vSSolution'>The 'VSSolution' object to save.</param>
            /// <returns>True if successful or false if not.</returns>
            public bool Save(ref VSSolution vSSolution)
            {
                // Initial value
                bool saved = false;

                // If the vSSolution exists.
                if(vSSolution != null)
                {
                    // Is this a new VSSolution
                    if(vSSolution.IsNew)
                    {
                        // Insert new VSSolution
                        int newIdentity = this.Insert(vSSolution);

                        // if insert was successful
                        if(newIdentity > 0)
                        {
                            // Update Identity
                            vSSolution.UpdateIdentity(newIdentity);

                            // Set return value
                            saved = true;
                        }
                    }
                    else
                    {
                        // Update VSSolution
                        saved = this.Update(vSSolution);
                    }
                }

                // return value
                return saved;
            }
            #endregion

            #region Update(VSSolution vSSolution)
            /// <summary>
            /// This method Updates a 'VSSolution' object in the database.
            /// This method used the DataBridgeManager to execute the 'Update' using the
            /// procedure 'VSSolution_Update'.</param>
            /// </summary>
            /// <param name='vSSolution'>The 'VSSolution' object to update.</param>
            /// <returns>True if successful else false if not.</returns>
            public bool Update(VSSolution vSSolution)
            {
                // Initial value
                bool saved = false;

                // Get information for calling 'DataBridgeManager.PerformDataOperation' method.
                string methodName = "Update";
                string objectName = "ApplicationLogicComponent.Controllers";

                try
                {
                    if(vSSolution != null)
                    {
                        // Create Delegate
                        ApplicationController.DataOperationMethod updateMethod = this.AppController.DataBridge.DataOperations.VSSolutionMethods.UpdateVSSolution;

                        // Create parameters for this method
                        List<PolymorphicObject> parameters = CreateVSSolutionParameter(vSSolution);
                        // Perform DataOperation
                        PolymorphicObject returnObject = this.AppController.DataBridge.PerformDataOperation(methodName, objectName, updateMethod , parameters);

                        // If return object exists
                        if ((returnObject != null) && (returnObject.Boolean != null) && (returnObject.Boolean.Value == NullableBooleanEnum.True))
                        {
                            // Set saved to true
                            saved = true;
                        }
                    }
                }
                catch (Exception error)
                {
                    // If ErrorProcessor exists
                    if (this.ErrorProcessor != null)
                    {
                        // Log the current error
                        this.ErrorProcessor.LogError(methodName, objectName, error);
                    }
                }

                // return value
                return saved;
            }
            #endregion

        #endregion

        #region Properties

            #region AppController
            public ApplicationController AppController
            {
                get { return appController; }
                set { appController = value; }
            }
            #endregion

            #region ErrorProcessor
            public ErrorHandler ErrorProcessor
            {
                get { return errorProcessor; }
                set { errorProcessor = value; }
            }
            #endregion

        #endregion

    }
    #endregion

}
