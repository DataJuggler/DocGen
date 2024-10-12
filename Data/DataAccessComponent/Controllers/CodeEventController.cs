

#region using statements

using DataAccessComponent.DataBridge;
using DataAccessComponent.DataOperations;
using DataAccessComponent.Logging;
using ObjectLibrary.BusinessObjects;
using System;
using System.Collections.Generic;

#endregion


namespace DataAccessComponent.Controllers
{

    #region class CodeEventController
    /// <summary>
    /// This class controls a(n) 'CodeEvent' object.
    /// </summary>
    public class CodeEventController
    {

        #region Private Variables
        private ErrorHandler errorProcessor;
        private ApplicationController appController;
        #endregion

        #region Constructor
        /// <summary>
        /// Creates a new 'CodeEventController' object.
        /// </summary>
        public CodeEventController(ErrorHandler errorProcessorArg, ApplicationController appControllerArg)
        {
            // Save Arguments
            this.ErrorProcessor = errorProcessorArg;
            this.AppController = appControllerArg;
        }
        #endregion

        #region Methods

            #region CreateCodeEventParameter
            /// <summary>
            /// This method creates the parameter for a 'CodeEvent' data operation.
            /// </summary>
            /// <param name='codeevent'>The 'CodeEvent' to use as the first
            /// parameter (parameters[0]).</param>
            /// <returns>A List<PolymorphicObject> collection.</returns>
            private static List<PolymorphicObject> CreateCodeEventParameter(CodeEvent codeEvent)
            {
                // Initial Value
                List<PolymorphicObject> parameters = new List<PolymorphicObject>();

                // Create PolymorphicObject to hold the parameter
                PolymorphicObject parameter = new PolymorphicObject();

                // Set parameter.ObjectValue
                parameter.ObjectValue = codeEvent;

                // Add userParameter to parameters
                parameters.Add(parameter);

                // return value
                return parameters;
            }
            #endregion

            #region Delete(CodeEvent tempCodeEvent)
            /// <summary>
            /// Deletes a 'CodeEvent' from the database
            /// This method calls the DataBridgeManager to execute the delete using the
            /// procedure 'CodeEvent_Delete'.
            /// </summary>
            /// <param name='codeevent'>The 'CodeEvent' to delete.</param>
            /// <returns>True if the delete is successful or false if not.</returns>
            public bool Delete(CodeEvent tempCodeEvent)
            {
                // locals
                bool deleted = false;

                // Get information for calling 'DataBridgeManager.PerformDataOperation' method.
                string methodName = "DeleteCodeEvent";
                string objectName = "ApplicationLogicComponent.Controllers";

                try
                {
                    // verify tempcodeEvent exists before attemptintg to delete
                    if(tempCodeEvent != null)
                    {
                        // Create Delegate For DataOperation
                        ApplicationController.DataOperationMethod deleteCodeEventMethod = this.AppController.DataBridge.DataOperations.CodeEventMethods.DeleteCodeEvent;

                        // Create parameters for this method
                        List<PolymorphicObject> parameters = CreateCodeEventParameter(tempCodeEvent);

                        // Perform DataOperation
                        PolymorphicObject returnObject = this.AppController.DataBridge.PerformDataOperation(methodName, objectName, deleteCodeEventMethod, parameters);

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

            #region FetchAll(CodeEvent tempCodeEvent)
            /// <summary>
            /// This method fetches a collection of 'CodeEvent' objects.
            /// This method used the DataBridgeManager to execute the fetch all using the
            /// procedure 'CodeEvent_FetchAll'.</summary>
            /// <param name='tempCodeEvent'>A temporary CodeEvent for passing values.</param>
            /// <returns>A collection of 'CodeEvent' objects.</returns>
            public List<CodeEvent> FetchAll(CodeEvent tempCodeEvent)
            {
                // Initial value
                List<CodeEvent> codeEventList = null;

                // Get information for calling 'DataBridgeManager.PerformDataOperation' method.
                string methodName = "FetchAll";
                string objectName = "ApplicationLogicComponent.Controllers";

                try
                {
                    // Create DataOperation Method
                    ApplicationController.DataOperationMethod fetchAllMethod = this.AppController.DataBridge.DataOperations.CodeEventMethods.FetchAll;

                    // Create parameters for this method
                    List<PolymorphicObject> parameters = CreateCodeEventParameter(tempCodeEvent);

                    // Perform DataOperation
                    PolymorphicObject returnObject = this.AppController.DataBridge.PerformDataOperation(methodName, objectName, fetchAllMethod , parameters);

                    // If return object exists
                    if ((returnObject != null) && (returnObject.ObjectValue as List<CodeEvent> != null))
                    {
                        // Create Collection From ReturnObject.ObjectValue
                        codeEventList = (List<CodeEvent>) returnObject.ObjectValue;
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
                return codeEventList;
            }
            #endregion

            #region Find(CodeEvent tempCodeEvent)
            /// <summary>
            /// Finds a 'CodeEvent' object by the primary key.
            /// This method used the DataBridgeManager to execute the 'Find' using the
            /// procedure 'CodeEvent_Find'</param>
            /// </summary>
            /// <param name='tempCodeEvent'>A temporary CodeEvent for passing values.</param>
            /// <returns>A 'CodeEvent' object if found else a null 'CodeEvent'.</returns>
            public CodeEvent Find(CodeEvent tempCodeEvent)
            {
                // Initial values
                CodeEvent codeEvent = null;

                // Get information for calling 'DataBridgeManager.PerformDataOperation' method.
                string methodName = "Find";
                string objectName = "ApplicationLogicComponent.Controllers";

                try
                {
                    // If object exists
                    if(tempCodeEvent != null)
                    {
                        // Create DataOperation
                        ApplicationController.DataOperationMethod findMethod = this.AppController.DataBridge.DataOperations.CodeEventMethods.FindCodeEvent;

                        // Create parameters for this method
                        List<PolymorphicObject> parameters = CreateCodeEventParameter(tempCodeEvent);

                        // Perform DataOperation
                        PolymorphicObject returnObject = this.AppController.DataBridge.PerformDataOperation(methodName, objectName, findMethod , parameters);

                        // If return object exists
                        if ((returnObject != null) && (returnObject.ObjectValue as CodeEvent != null))
                        {
                            // Get ReturnObject
                            codeEvent = (CodeEvent) returnObject.ObjectValue;
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
                return codeEvent;
            }
            #endregion

            #region Insert(CodeEvent codeEvent)
            /// <summary>
            /// Insert a 'CodeEvent' object into the database.
            /// This method uses the DataBridgeManager to execute the 'Insert' using the
            /// procedure 'CodeEvent_Insert'.</param>
            /// </summary>
            /// <param name='codeEvent'>The 'CodeEvent' object to insert.</param>
            /// <returns>The id (int) of the new  'CodeEvent' object that was inserted.</returns>
            public int Insert(CodeEvent codeEvent)
            {
                // Initial values
                int newIdentity = -1;

                // Get information for calling 'DataBridgeManager.PerformDataOperation' method.
                string methodName = "Insert";
                string objectName = "ApplicationLogicComponent.Controllers";

                try
                {
                    // If CodeEventexists
                    if(codeEvent != null)
                    {
                        ApplicationController.DataOperationMethod insertMethod = this.AppController.DataBridge.DataOperations.CodeEventMethods.InsertCodeEvent;

                        // Create parameters for this method
                        List<PolymorphicObject> parameters = CreateCodeEventParameter(codeEvent);

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

            #region Save(ref CodeEvent codeEvent)
            /// <summary>
            /// Saves a 'CodeEvent' object into the database.
            /// This method calls the 'Insert' or 'Update' method.
            /// </summary>
            /// <param name='codeEvent'>The 'CodeEvent' object to save.</param>
            /// <returns>True if successful or false if not.</returns>
            public bool Save(ref CodeEvent codeEvent)
            {
                // Initial value
                bool saved = false;

                // If the codeEvent exists.
                if(codeEvent != null)
                {
                    // Is this a new CodeEvent
                    if(codeEvent.IsNew)
                    {
                        // Insert new CodeEvent
                        int newIdentity = this.Insert(codeEvent);

                        // if insert was successful
                        if(newIdentity > 0)
                        {
                            // Update Identity
                            codeEvent.UpdateIdentity(newIdentity);

                            // Set return value
                            saved = true;
                        }
                    }
                    else
                    {
                        // Update CodeEvent
                        saved = this.Update(codeEvent);
                    }
                }

                // return value
                return saved;
            }
            #endregion

            #region Update(CodeEvent codeEvent)
            /// <summary>
            /// This method Updates a 'CodeEvent' object in the database.
            /// This method used the DataBridgeManager to execute the 'Update' using the
            /// procedure 'CodeEvent_Update'.</param>
            /// </summary>
            /// <param name='codeEvent'>The 'CodeEvent' object to update.</param>
            /// <returns>True if successful else false if not.</returns>
            public bool Update(CodeEvent codeEvent)
            {
                // Initial value
                bool saved = false;

                // Get information for calling 'DataBridgeManager.PerformDataOperation' method.
                string methodName = "Update";
                string objectName = "ApplicationLogicComponent.Controllers";

                try
                {
                    if(codeEvent != null)
                    {
                        // Create Delegate
                        ApplicationController.DataOperationMethod updateMethod = this.AppController.DataBridge.DataOperations.CodeEventMethods.UpdateCodeEvent;

                        // Create parameters for this method
                        List<PolymorphicObject> parameters = CreateCodeEventParameter(codeEvent);
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
