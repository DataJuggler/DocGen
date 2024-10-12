

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

    #region class CodeParameterController
    /// <summary>
    /// This class controls a(n) 'CodeParameter' object.
    /// </summary>
    public class CodeParameterController
    {

        #region Private Variables
        private ErrorHandler errorProcessor;
        private ApplicationController appController;
        #endregion

        #region Constructor
        /// <summary>
        /// Creates a new 'CodeParameterController' object.
        /// </summary>
        public CodeParameterController(ErrorHandler errorProcessorArg, ApplicationController appControllerArg)
        {
            // Save Arguments
            this.ErrorProcessor = errorProcessorArg;
            this.AppController = appControllerArg;
        }
        #endregion

        #region Methods

            #region CreateCodeParameterParameter
            /// <summary>
            /// This method creates the parameter for a 'CodeParameter' data operation.
            /// </summary>
            /// <param name='codeparameter'>The 'CodeParameter' to use as the first
            /// parameter (parameters[0]).</param>
            /// <returns>A List<PolymorphicObject> collection.</returns>
            private static List<PolymorphicObject> CreateCodeParameterParameter(CodeParameter codeParameter)
            {
                // Initial Value
                List<PolymorphicObject> parameters = new List<PolymorphicObject>();

                // Create PolymorphicObject to hold the parameter
                PolymorphicObject parameter = new PolymorphicObject();

                // Set parameter.ObjectValue
                parameter.ObjectValue = codeParameter;

                // Add userParameter to parameters
                parameters.Add(parameter);

                // return value
                return parameters;
            }
            #endregion

            #region Delete(CodeParameter tempCodeParameter)
            /// <summary>
            /// Deletes a 'CodeParameter' from the database
            /// This method calls the DataBridgeManager to execute the delete using the
            /// procedure 'CodeParameter_Delete'.
            /// </summary>
            /// <param name='codeparameter'>The 'CodeParameter' to delete.</param>
            /// <returns>True if the delete is successful or false if not.</returns>
            public bool Delete(CodeParameter tempCodeParameter)
            {
                // locals
                bool deleted = false;

                // Get information for calling 'DataBridgeManager.PerformDataOperation' method.
                string methodName = "DeleteCodeParameter";
                string objectName = "ApplicationLogicComponent.Controllers";

                try
                {
                    // verify tempcodeParameter exists before attemptintg to delete
                    if(tempCodeParameter != null)
                    {
                        // Create Delegate For DataOperation
                        ApplicationController.DataOperationMethod deleteCodeParameterMethod = this.AppController.DataBridge.DataOperations.CodeParameterMethods.DeleteCodeParameter;

                        // Create parameters for this method
                        List<PolymorphicObject> parameters = CreateCodeParameterParameter(tempCodeParameter);

                        // Perform DataOperation
                        PolymorphicObject returnObject = this.AppController.DataBridge.PerformDataOperation(methodName, objectName, deleteCodeParameterMethod, parameters);

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

            #region FetchAll(CodeParameter tempCodeParameter)
            /// <summary>
            /// This method fetches a collection of 'CodeParameter' objects.
            /// This method used the DataBridgeManager to execute the fetch all using the
            /// procedure 'CodeParameter_FetchAll'.</summary>
            /// <param name='tempCodeParameter'>A temporary CodeParameter for passing values.</param>
            /// <returns>A collection of 'CodeParameter' objects.</returns>
            public List<CodeParameter> FetchAll(CodeParameter tempCodeParameter)
            {
                // Initial value
                List<CodeParameter> codeParameterList = null;

                // Get information for calling 'DataBridgeManager.PerformDataOperation' method.
                string methodName = "FetchAll";
                string objectName = "ApplicationLogicComponent.Controllers";

                try
                {
                    // Create DataOperation Method
                    ApplicationController.DataOperationMethod fetchAllMethod = this.AppController.DataBridge.DataOperations.CodeParameterMethods.FetchAll;

                    // Create parameters for this method
                    List<PolymorphicObject> parameters = CreateCodeParameterParameter(tempCodeParameter);

                    // Perform DataOperation
                    PolymorphicObject returnObject = this.AppController.DataBridge.PerformDataOperation(methodName, objectName, fetchAllMethod , parameters);

                    // If return object exists
                    if ((returnObject != null) && (returnObject.ObjectValue as List<CodeParameter> != null))
                    {
                        // Create Collection From ReturnObject.ObjectValue
                        codeParameterList = (List<CodeParameter>) returnObject.ObjectValue;
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
                return codeParameterList;
            }
            #endregion

            #region Find(CodeParameter tempCodeParameter)
            /// <summary>
            /// Finds a 'CodeParameter' object by the primary key.
            /// This method used the DataBridgeManager to execute the 'Find' using the
            /// procedure 'CodeParameter_Find'</param>
            /// </summary>
            /// <param name='tempCodeParameter'>A temporary CodeParameter for passing values.</param>
            /// <returns>A 'CodeParameter' object if found else a null 'CodeParameter'.</returns>
            public CodeParameter Find(CodeParameter tempCodeParameter)
            {
                // Initial values
                CodeParameter codeParameter = null;

                // Get information for calling 'DataBridgeManager.PerformDataOperation' method.
                string methodName = "Find";
                string objectName = "ApplicationLogicComponent.Controllers";

                try
                {
                    // If object exists
                    if(tempCodeParameter != null)
                    {
                        // Create DataOperation
                        ApplicationController.DataOperationMethod findMethod = this.AppController.DataBridge.DataOperations.CodeParameterMethods.FindCodeParameter;

                        // Create parameters for this method
                        List<PolymorphicObject> parameters = CreateCodeParameterParameter(tempCodeParameter);

                        // Perform DataOperation
                        PolymorphicObject returnObject = this.AppController.DataBridge.PerformDataOperation(methodName, objectName, findMethod , parameters);

                        // If return object exists
                        if ((returnObject != null) && (returnObject.ObjectValue as CodeParameter != null))
                        {
                            // Get ReturnObject
                            codeParameter = (CodeParameter) returnObject.ObjectValue;
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
                return codeParameter;
            }
            #endregion

            #region Insert(CodeParameter codeParameter)
            /// <summary>
            /// Insert a 'CodeParameter' object into the database.
            /// This method uses the DataBridgeManager to execute the 'Insert' using the
            /// procedure 'CodeParameter_Insert'.</param>
            /// </summary>
            /// <param name='codeParameter'>The 'CodeParameter' object to insert.</param>
            /// <returns>The id (int) of the new  'CodeParameter' object that was inserted.</returns>
            public int Insert(CodeParameter codeParameter)
            {
                // Initial values
                int newIdentity = -1;

                // Get information for calling 'DataBridgeManager.PerformDataOperation' method.
                string methodName = "Insert";
                string objectName = "ApplicationLogicComponent.Controllers";

                try
                {
                    // If CodeParameterexists
                    if(codeParameter != null)
                    {
                        ApplicationController.DataOperationMethod insertMethod = this.AppController.DataBridge.DataOperations.CodeParameterMethods.InsertCodeParameter;

                        // Create parameters for this method
                        List<PolymorphicObject> parameters = CreateCodeParameterParameter(codeParameter);

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

            #region Save(ref CodeParameter codeParameter)
            /// <summary>
            /// Saves a 'CodeParameter' object into the database.
            /// This method calls the 'Insert' or 'Update' method.
            /// </summary>
            /// <param name='codeParameter'>The 'CodeParameter' object to save.</param>
            /// <returns>True if successful or false if not.</returns>
            public bool Save(ref CodeParameter codeParameter)
            {
                // Initial value
                bool saved = false;

                // If the codeParameter exists.
                if(codeParameter != null)
                {
                    // Is this a new CodeParameter
                    if(codeParameter.IsNew)
                    {
                        // Insert new CodeParameter
                        int newIdentity = this.Insert(codeParameter);

                        // if insert was successful
                        if(newIdentity > 0)
                        {
                            // Update Identity
                            codeParameter.UpdateIdentity(newIdentity);

                            // Set return value
                            saved = true;
                        }
                    }
                    else
                    {
                        // Update CodeParameter
                        saved = this.Update(codeParameter);
                    }
                }

                // return value
                return saved;
            }
            #endregion

            #region Update(CodeParameter codeParameter)
            /// <summary>
            /// This method Updates a 'CodeParameter' object in the database.
            /// This method used the DataBridgeManager to execute the 'Update' using the
            /// procedure 'CodeParameter_Update'.</param>
            /// </summary>
            /// <param name='codeParameter'>The 'CodeParameter' object to update.</param>
            /// <returns>True if successful else false if not.</returns>
            public bool Update(CodeParameter codeParameter)
            {
                // Initial value
                bool saved = false;

                // Get information for calling 'DataBridgeManager.PerformDataOperation' method.
                string methodName = "Update";
                string objectName = "ApplicationLogicComponent.Controllers";

                try
                {
                    if(codeParameter != null)
                    {
                        // Create Delegate
                        ApplicationController.DataOperationMethod updateMethod = this.AppController.DataBridge.DataOperations.CodeParameterMethods.UpdateCodeParameter;

                        // Create parameters for this method
                        List<PolymorphicObject> parameters = CreateCodeParameterParameter(codeParameter);
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
