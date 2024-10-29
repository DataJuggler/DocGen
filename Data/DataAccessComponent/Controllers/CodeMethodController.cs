

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

    #region class CodeMethodController
    /// <summary>
    /// This class controls a(n) 'CodeMethod' object.
    /// </summary>
    public class CodeMethodController
    {

        #region Private Variables
        private ErrorHandler errorProcessor;
        private ApplicationController appController;
        #endregion

        #region Constructor
        /// <summary>
        /// Creates a new 'CodeMethodController' object.
        /// </summary>
        public CodeMethodController(ErrorHandler errorProcessorArg, ApplicationController appControllerArg)
        {
            // Save Arguments
            this.ErrorProcessor = errorProcessorArg;
            this.AppController = appControllerArg;
        }
        #endregion

        #region Methods

            #region CreateCodeMethodParameter
            /// <summary>
            /// This method creates the parameter for a 'CodeMethod' data operation.
            /// </summary>
            /// <param name='codemethod'>The 'CodeMethod' to use as the first
            /// parameter (parameters[0]).</param>
            /// <returns>A List<PolymorphicObject> collection.</returns>
            private static List<PolymorphicObject> CreateCodeMethodParameter(CodeMethod codeMethod)
            {
                // Initial Value
                List<PolymorphicObject> parameters = new List<PolymorphicObject>();

                // Create PolymorphicObject to hold the parameter
                PolymorphicObject parameter = new PolymorphicObject();

                // Set parameter.ObjectValue
                parameter.ObjectValue = codeMethod;

                // Add userParameter to parameters
                parameters.Add(parameter);

                // return value
                return parameters;
            }
            #endregion

            #region Delete(CodeMethod tempCodeMethod)
            /// <summary>
            /// Deletes a 'CodeMethod' from the database
            /// This method calls the DataBridgeManager to execute the delete using the
            /// procedure 'CodeMethod_Delete'.
            /// </summary>
            /// <param name='codemethod'>The 'CodeMethod' to delete.</param>
            /// <returns>True if the delete is successful or false if not.</returns>
            public bool Delete(CodeMethod tempCodeMethod)
            {
                // locals
                bool deleted = false;

                // Get information for calling 'DataBridgeManager.PerformDataOperation' method.
                string methodName = "DeleteCodeMethod";
                string objectName = "ApplicationLogicComponent.Controllers";

                try
                {
                    // verify tempcodeMethod exists before attemptintg to delete
                    if(tempCodeMethod != null)
                    {
                        // Create Delegate For DataOperation
                        ApplicationController.DataOperationMethod deleteCodeMethodMethod = this.AppController.DataBridge.DataOperations.CodeMethodMethods.DeleteCodeMethod;

                        // Create parameters for this method
                        List<PolymorphicObject> parameters = CreateCodeMethodParameter(tempCodeMethod);

                        // Perform DataOperation
                        PolymorphicObject returnObject = this.AppController.DataBridge.PerformDataOperation(methodName, objectName, deleteCodeMethodMethod, parameters);

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

            #region FetchAll(CodeMethod tempCodeMethod)
            /// <summary>
            /// This method fetches a collection of 'CodeMethod' objects.
            /// This method used the DataBridgeManager to execute the fetch all using the
            /// procedure 'CodeMethod_FetchAll'.</summary>
            /// <param name='tempCodeMethod'>A temporary CodeMethod for passing values.</param>
            /// <returns>A collection of 'CodeMethod' objects.</returns>
            public List<CodeMethod> FetchAll(CodeMethod tempCodeMethod)
            {
                // Initial value
                List<CodeMethod> codeMethodList = null;

                // Get information for calling 'DataBridgeManager.PerformDataOperation' method.
                string methodName = "FetchAll";
                string objectName = "ApplicationLogicComponent.Controllers";

                try
                {
                    // Create DataOperation Method
                    ApplicationController.DataOperationMethod fetchAllMethod = this.AppController.DataBridge.DataOperations.CodeMethodMethods.FetchAll;

                    // Create parameters for this method
                    List<PolymorphicObject> parameters = CreateCodeMethodParameter(tempCodeMethod);

                    // Perform DataOperation
                    PolymorphicObject returnObject = this.AppController.DataBridge.PerformDataOperation(methodName, objectName, fetchAllMethod , parameters);

                    // If return object exists
                    if ((returnObject != null) && (returnObject.ObjectValue as List<CodeMethod> != null))
                    {
                        // Create Collection From ReturnObject.ObjectValue
                        codeMethodList = (List<CodeMethod>) returnObject.ObjectValue;
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
                return codeMethodList;
            }
            #endregion

            #region Find(CodeMethod tempCodeMethod)
            /// <summary>
            /// Finds a 'CodeMethod' object by the primary key.
            /// This method used the DataBridgeManager to execute the 'Find' using the
            /// procedure 'CodeMethod_Find'</param>
            /// </summary>
            /// <param name='tempCodeMethod'>A temporary CodeMethod for passing values.</param>
            /// <returns>A 'CodeMethod' object if found else a null 'CodeMethod'.</returns>
            public CodeMethod Find(CodeMethod tempCodeMethod)
            {
                // Initial values
                CodeMethod codeMethod = null;

                // Get information for calling 'DataBridgeManager.PerformDataOperation' method.
                string methodName = "Find";
                string objectName = "ApplicationLogicComponent.Controllers";

                try
                {
                    // If object exists
                    if(tempCodeMethod != null)
                    {
                        // Create DataOperation
                        ApplicationController.DataOperationMethod findMethod = this.AppController.DataBridge.DataOperations.CodeMethodMethods.FindCodeMethod;

                        // Create parameters for this method
                        List<PolymorphicObject> parameters = CreateCodeMethodParameter(tempCodeMethod);

                        // Perform DataOperation
                        PolymorphicObject returnObject = this.AppController.DataBridge.PerformDataOperation(methodName, objectName, findMethod , parameters);

                        // If return object exists
                        if ((returnObject != null) && (returnObject.ObjectValue as CodeMethod != null))
                        {
                            // Get ReturnObject
                            codeMethod = (CodeMethod) returnObject.ObjectValue;
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
                return codeMethod;
            }
            #endregion

            #region Insert(CodeMethod codeMethod)
            /// <summary>
            /// Insert a 'CodeMethod' object into the database.
            /// This method uses the DataBridgeManager to execute the 'Insert' using the
            /// procedure 'CodeMethod_Insert'.</param>
            /// </summary>
            /// <param name='codeMethod'>The 'CodeMethod' object to insert.</param>
            /// <returns>The id (int) of the new  'CodeMethod' object that was inserted.</returns>
            public int Insert(CodeMethod codeMethod)
            {
                // Initial values
                int newIdentity = -1;

                // Get information for calling 'DataBridgeManager.PerformDataOperation' method.
                string methodName = "Insert";
                string objectName = "ApplicationLogicComponent.Controllers";

                try
                {
                    // If CodeMethodexists
                    if(codeMethod != null)
                    {
                        ApplicationController.DataOperationMethod insertMethod = this.AppController.DataBridge.DataOperations.CodeMethodMethods.InsertCodeMethod;

                        // Create parameters for this method
                        List<PolymorphicObject> parameters = CreateCodeMethodParameter(codeMethod);

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

            #region Save(ref CodeMethod codeMethod)
            /// <summary>
            /// Saves a 'CodeMethod' object into the database.
            /// This method calls the 'Insert' or 'Update' method.
            /// </summary>
            /// <param name='codeMethod'>The 'CodeMethod' object to save.</param>
            /// <returns>True if successful or false if not.</returns>
            public bool Save(ref CodeMethod codeMethod)
            {
                // Initial value
                bool saved = false;

                // If the codeMethod exists.
                if(codeMethod != null)
                {
                    // Is this a new CodeMethod
                    if(codeMethod.IsNew)
                    {
                        // Insert new CodeMethod
                        int newIdentity = this.Insert(codeMethod);

                        // if insert was successful
                        if(newIdentity > 0)
                        {
                            // Update Identity
                            codeMethod.UpdateIdentity(newIdentity);

                            // Set return value
                            saved = true;
                        }
                    }
                    else
                    {
                        // Update CodeMethod
                        saved = this.Update(codeMethod);
                    }
                }

                // return value
                return saved;
            }
            #endregion

            #region Update(CodeMethod codeMethod)
            /// <summary>
            /// This method Updates a 'CodeMethod' object in the database.
            /// This method used the DataBridgeManager to execute the 'Update' using the
            /// procedure 'CodeMethod_Update'.</param>
            /// </summary>
            /// <param name='codeMethod'>The 'CodeMethod' object to update.</param>
            /// <returns>True if successful else false if not.</returns>
            public bool Update(CodeMethod codeMethod)
            {
                // Initial value
                bool saved = false;

                // Get information for calling 'DataBridgeManager.PerformDataOperation' method.
                string methodName = "Update";
                string objectName = "ApplicationLogicComponent.Controllers";

                try
                {
                    if(codeMethod != null)
                    {
                        // Create Delegate
                        ApplicationController.DataOperationMethod updateMethod = this.AppController.DataBridge.DataOperations.CodeMethodMethods.UpdateCodeMethod;

                        // Create parameters for this method
                        List<PolymorphicObject> parameters = CreateCodeMethodParameter(codeMethod);
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
