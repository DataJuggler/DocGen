

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

    #region class CodeConstructorController
    /// <summary>
    /// This class controls a(n) 'CodeConstructor' object.
    /// </summary>
    public class CodeConstructorController
    {

        #region Private Variables
        private ErrorHandler errorProcessor;
        private ApplicationController appController;
        #endregion

        #region Constructor
        /// <summary>
        /// Creates a new 'CodeConstructorController' object.
        /// </summary>
        public CodeConstructorController(ErrorHandler errorProcessorArg, ApplicationController appControllerArg)
        {
            // Save Arguments
            this.ErrorProcessor = errorProcessorArg;
            this.AppController = appControllerArg;
        }
        #endregion

        #region Methods

            #region CreateCodeConstructorParameter
            /// <summary>
            /// This method creates the parameter for a 'CodeConstructor' data operation.
            /// </summary>
            /// <param name='codeconstructor'>The 'CodeConstructor' to use as the first
            /// parameter (parameters[0]).</param>
            /// <returns>A List<PolymorphicObject> collection.</returns>
            private static List<PolymorphicObject> CreateCodeConstructorParameter(CodeConstructor codeConstructor)
            {
                // Initial Value
                List<PolymorphicObject> parameters = new List<PolymorphicObject>();

                // Create PolymorphicObject to hold the parameter
                PolymorphicObject parameter = new PolymorphicObject();

                // Set parameter.ObjectValue
                parameter.ObjectValue = codeConstructor;

                // Add userParameter to parameters
                parameters.Add(parameter);

                // return value
                return parameters;
            }
            #endregion

            #region Delete(CodeConstructor tempCodeConstructor)
            /// <summary>
            /// Deletes a 'CodeConstructor' from the database
            /// This method calls the DataBridgeManager to execute the delete using the
            /// procedure 'CodeConstructor_Delete'.
            /// </summary>
            /// <param name='codeconstructor'>The 'CodeConstructor' to delete.</param>
            /// <returns>True if the delete is successful or false if not.</returns>
            public bool Delete(CodeConstructor tempCodeConstructor)
            {
                // locals
                bool deleted = false;

                // Get information for calling 'DataBridgeManager.PerformDataOperation' method.
                string methodName = "DeleteCodeConstructor";
                string objectName = "ApplicationLogicComponent.Controllers";

                try
                {
                    // verify tempcodeConstructor exists before attemptintg to delete
                    if(tempCodeConstructor != null)
                    {
                        // Create Delegate For DataOperation
                        ApplicationController.DataOperationMethod deleteCodeConstructorMethod = this.AppController.DataBridge.DataOperations.CodeConstructorMethods.DeleteCodeConstructor;

                        // Create parameters for this method
                        List<PolymorphicObject> parameters = CreateCodeConstructorParameter(tempCodeConstructor);

                        // Perform DataOperation
                        PolymorphicObject returnObject = this.AppController.DataBridge.PerformDataOperation(methodName, objectName, deleteCodeConstructorMethod, parameters);

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

            #region FetchAll(CodeConstructor tempCodeConstructor)
            /// <summary>
            /// This method fetches a collection of 'CodeConstructor' objects.
            /// This method used the DataBridgeManager to execute the fetch all using the
            /// procedure 'CodeConstructor_FetchAll'.</summary>
            /// <param name='tempCodeConstructor'>A temporary CodeConstructor for passing values.</param>
            /// <returns>A collection of 'CodeConstructor' objects.</returns>
            public List<CodeConstructor> FetchAll(CodeConstructor tempCodeConstructor)
            {
                // Initial value
                List<CodeConstructor> codeConstructorList = null;

                // Get information for calling 'DataBridgeManager.PerformDataOperation' method.
                string methodName = "FetchAll";
                string objectName = "ApplicationLogicComponent.Controllers";

                try
                {
                    // Create DataOperation Method
                    ApplicationController.DataOperationMethod fetchAllMethod = this.AppController.DataBridge.DataOperations.CodeConstructorMethods.FetchAll;

                    // Create parameters for this method
                    List<PolymorphicObject> parameters = CreateCodeConstructorParameter(tempCodeConstructor);

                    // Perform DataOperation
                    PolymorphicObject returnObject = this.AppController.DataBridge.PerformDataOperation(methodName, objectName, fetchAllMethod , parameters);

                    // If return object exists
                    if ((returnObject != null) && (returnObject.ObjectValue as List<CodeConstructor> != null))
                    {
                        // Create Collection From ReturnObject.ObjectValue
                        codeConstructorList = (List<CodeConstructor>) returnObject.ObjectValue;
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
                return codeConstructorList;
            }
            #endregion

            #region Find(CodeConstructor tempCodeConstructor)
            /// <summary>
            /// Finds a 'CodeConstructor' object by the primary key.
            /// This method used the DataBridgeManager to execute the 'Find' using the
            /// procedure 'CodeConstructor_Find'</param>
            /// </summary>
            /// <param name='tempCodeConstructor'>A temporary CodeConstructor for passing values.</param>
            /// <returns>A 'CodeConstructor' object if found else a null 'CodeConstructor'.</returns>
            public CodeConstructor Find(CodeConstructor tempCodeConstructor)
            {
                // Initial values
                CodeConstructor codeConstructor = null;

                // Get information for calling 'DataBridgeManager.PerformDataOperation' method.
                string methodName = "Find";
                string objectName = "ApplicationLogicComponent.Controllers";

                try
                {
                    // If object exists
                    if(tempCodeConstructor != null)
                    {
                        // Create DataOperation
                        ApplicationController.DataOperationMethod findMethod = this.AppController.DataBridge.DataOperations.CodeConstructorMethods.FindCodeConstructor;

                        // Create parameters for this method
                        List<PolymorphicObject> parameters = CreateCodeConstructorParameter(tempCodeConstructor);

                        // Perform DataOperation
                        PolymorphicObject returnObject = this.AppController.DataBridge.PerformDataOperation(methodName, objectName, findMethod , parameters);

                        // If return object exists
                        if ((returnObject != null) && (returnObject.ObjectValue as CodeConstructor != null))
                        {
                            // Get ReturnObject
                            codeConstructor = (CodeConstructor) returnObject.ObjectValue;
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
                return codeConstructor;
            }
            #endregion

            #region Insert(CodeConstructor codeConstructor)
            /// <summary>
            /// Insert a 'CodeConstructor' object into the database.
            /// This method uses the DataBridgeManager to execute the 'Insert' using the
            /// procedure 'CodeConstructor_Insert'.</param>
            /// </summary>
            /// <param name='codeConstructor'>The 'CodeConstructor' object to insert.</param>
            /// <returns>The id (int) of the new  'CodeConstructor' object that was inserted.</returns>
            public int Insert(CodeConstructor codeConstructor)
            {
                // Initial values
                int newIdentity = -1;

                // Get information for calling 'DataBridgeManager.PerformDataOperation' method.
                string methodName = "Insert";
                string objectName = "ApplicationLogicComponent.Controllers";

                try
                {
                    // If CodeConstructorexists
                    if(codeConstructor != null)
                    {
                        ApplicationController.DataOperationMethod insertMethod = this.AppController.DataBridge.DataOperations.CodeConstructorMethods.InsertCodeConstructor;

                        // Create parameters for this method
                        List<PolymorphicObject> parameters = CreateCodeConstructorParameter(codeConstructor);

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

            #region Save(ref CodeConstructor codeConstructor)
            /// <summary>
            /// Saves a 'CodeConstructor' object into the database.
            /// This method calls the 'Insert' or 'Update' method.
            /// </summary>
            /// <param name='codeConstructor'>The 'CodeConstructor' object to save.</param>
            /// <returns>True if successful or false if not.</returns>
            public bool Save(ref CodeConstructor codeConstructor)
            {
                // Initial value
                bool saved = false;

                // If the codeConstructor exists.
                if(codeConstructor != null)
                {
                    // Is this a new CodeConstructor
                    if(codeConstructor.IsNew)
                    {
                        // Insert new CodeConstructor
                        int newIdentity = this.Insert(codeConstructor);

                        // if insert was successful
                        if(newIdentity > 0)
                        {
                            // Update Identity
                            codeConstructor.UpdateIdentity(newIdentity);

                            // Set return value
                            saved = true;
                        }
                    }
                    else
                    {
                        // Update CodeConstructor
                        saved = this.Update(codeConstructor);
                    }
                }

                // return value
                return saved;
            }
            #endregion

            #region Update(CodeConstructor codeConstructor)
            /// <summary>
            /// This method Updates a 'CodeConstructor' object in the database.
            /// This method used the DataBridgeManager to execute the 'Update' using the
            /// procedure 'CodeConstructor_Update'.</param>
            /// </summary>
            /// <param name='codeConstructor'>The 'CodeConstructor' object to update.</param>
            /// <returns>True if successful else false if not.</returns>
            public bool Update(CodeConstructor codeConstructor)
            {
                // Initial value
                bool saved = false;

                // Get information for calling 'DataBridgeManager.PerformDataOperation' method.
                string methodName = "Update";
                string objectName = "ApplicationLogicComponent.Controllers";

                try
                {
                    if(codeConstructor != null)
                    {
                        // Create Delegate
                        ApplicationController.DataOperationMethod updateMethod = this.AppController.DataBridge.DataOperations.CodeConstructorMethods.UpdateCodeConstructor;

                        // Create parameters for this method
                        List<PolymorphicObject> parameters = CreateCodeConstructorParameter(codeConstructor);
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
