

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

    #region class CodeClassController
    /// <summary>
    /// This class controls a(n) 'CodeClass' object.
    /// </summary>
    public class CodeClassController
    {

        #region Private Variables
        private ErrorHandler errorProcessor;
        private ApplicationController appController;
        #endregion

        #region Constructor
        /// <summary>
        /// Creates a new 'CodeClassController' object.
        /// </summary>
        public CodeClassController(ErrorHandler errorProcessorArg, ApplicationController appControllerArg)
        {
            // Save Arguments
            this.ErrorProcessor = errorProcessorArg;
            this.AppController = appControllerArg;
        }
        #endregion

        #region Methods

            #region CreateCodeClassParameter
            /// <summary>
            /// This method creates the parameter for a 'CodeClass' data operation.
            /// </summary>
            /// <param name='codeclass'>The 'CodeClass' to use as the first
            /// parameter (parameters[0]).</param>
            /// <returns>A List<PolymorphicObject> collection.</returns>
            private static List<PolymorphicObject> CreateCodeClassParameter(CodeClass codeClass)
            {
                // Initial Value
                List<PolymorphicObject> parameters = new List<PolymorphicObject>();

                // Create PolymorphicObject to hold the parameter
                PolymorphicObject parameter = new PolymorphicObject();

                // Set parameter.ObjectValue
                parameter.ObjectValue = codeClass;

                // Add userParameter to parameters
                parameters.Add(parameter);

                // return value
                return parameters;
            }
            #endregion

            #region Delete(CodeClass tempCodeClass)
            /// <summary>
            /// Deletes a 'CodeClass' from the database
            /// This method calls the DataBridgeManager to execute the delete using the
            /// procedure 'CodeClass_Delete'.
            /// </summary>
            /// <param name='codeclass'>The 'CodeClass' to delete.</param>
            /// <returns>True if the delete is successful or false if not.</returns>
            public bool Delete(CodeClass tempCodeClass)
            {
                // locals
                bool deleted = false;

                // Get information for calling 'DataBridgeManager.PerformDataOperation' method.
                string methodName = "DeleteCodeClass";
                string objectName = "ApplicationLogicComponent.Controllers";

                try
                {
                    // verify tempcodeClass exists before attemptintg to delete
                    if(tempCodeClass != null)
                    {
                        // Create Delegate For DataOperation
                        ApplicationController.DataOperationMethod deleteCodeClassMethod = this.AppController.DataBridge.DataOperations.CodeClassMethods.DeleteCodeClass;

                        // Create parameters for this method
                        List<PolymorphicObject> parameters = CreateCodeClassParameter(tempCodeClass);

                        // Perform DataOperation
                        PolymorphicObject returnObject = this.AppController.DataBridge.PerformDataOperation(methodName, objectName, deleteCodeClassMethod, parameters);

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

            #region FetchAll(CodeClass tempCodeClass)
            /// <summary>
            /// This method fetches a collection of 'CodeClass' objects.
            /// This method used the DataBridgeManager to execute the fetch all using the
            /// procedure 'CodeClass_FetchAll'.</summary>
            /// <param name='tempCodeClass'>A temporary CodeClass for passing values.</param>
            /// <returns>A collection of 'CodeClass' objects.</returns>
            public List<CodeClass> FetchAll(CodeClass tempCodeClass)
            {
                // Initial value
                List<CodeClass> codeClassList = null;

                // Get information for calling 'DataBridgeManager.PerformDataOperation' method.
                string methodName = "FetchAll";
                string objectName = "ApplicationLogicComponent.Controllers";

                try
                {
                    // Create DataOperation Method
                    ApplicationController.DataOperationMethod fetchAllMethod = this.AppController.DataBridge.DataOperations.CodeClassMethods.FetchAll;

                    // Create parameters for this method
                    List<PolymorphicObject> parameters = CreateCodeClassParameter(tempCodeClass);

                    // Perform DataOperation
                    PolymorphicObject returnObject = this.AppController.DataBridge.PerformDataOperation(methodName, objectName, fetchAllMethod , parameters);

                    // If return object exists
                    if ((returnObject != null) && (returnObject.ObjectValue as List<CodeClass> != null))
                    {
                        // Create Collection From ReturnObject.ObjectValue
                        codeClassList = (List<CodeClass>) returnObject.ObjectValue;
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
                return codeClassList;
            }
            #endregion

            #region Find(CodeClass tempCodeClass)
            /// <summary>
            /// Finds a 'CodeClass' object by the primary key.
            /// This method used the DataBridgeManager to execute the 'Find' using the
            /// procedure 'CodeClass_Find'</param>
            /// </summary>
            /// <param name='tempCodeClass'>A temporary CodeClass for passing values.</param>
            /// <returns>A 'CodeClass' object if found else a null 'CodeClass'.</returns>
            public CodeClass Find(CodeClass tempCodeClass)
            {
                // Initial values
                CodeClass codeClass = null;

                // Get information for calling 'DataBridgeManager.PerformDataOperation' method.
                string methodName = "Find";
                string objectName = "ApplicationLogicComponent.Controllers";

                try
                {
                    // If object exists
                    if(tempCodeClass != null)
                    {
                        // Create DataOperation
                        ApplicationController.DataOperationMethod findMethod = this.AppController.DataBridge.DataOperations.CodeClassMethods.FindCodeClass;

                        // Create parameters for this method
                        List<PolymorphicObject> parameters = CreateCodeClassParameter(tempCodeClass);

                        // Perform DataOperation
                        PolymorphicObject returnObject = this.AppController.DataBridge.PerformDataOperation(methodName, objectName, findMethod , parameters);

                        // If return object exists
                        if ((returnObject != null) && (returnObject.ObjectValue as CodeClass != null))
                        {
                            // Get ReturnObject
                            codeClass = (CodeClass) returnObject.ObjectValue;
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
                return codeClass;
            }
            #endregion

            #region Insert(CodeClass codeClass)
            /// <summary>
            /// Insert a 'CodeClass' object into the database.
            /// This method uses the DataBridgeManager to execute the 'Insert' using the
            /// procedure 'CodeClass_Insert'.</param>
            /// </summary>
            /// <param name='codeClass'>The 'CodeClass' object to insert.</param>
            /// <returns>The id (int) of the new  'CodeClass' object that was inserted.</returns>
            public int Insert(CodeClass codeClass)
            {
                // Initial values
                int newIdentity = -1;

                // Get information for calling 'DataBridgeManager.PerformDataOperation' method.
                string methodName = "Insert";
                string objectName = "ApplicationLogicComponent.Controllers";

                try
                {
                    // If CodeClassexists
                    if(codeClass != null)
                    {
                        ApplicationController.DataOperationMethod insertMethod = this.AppController.DataBridge.DataOperations.CodeClassMethods.InsertCodeClass;

                        // Create parameters for this method
                        List<PolymorphicObject> parameters = CreateCodeClassParameter(codeClass);

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

            #region Save(ref CodeClass codeClass)
            /// <summary>
            /// Saves a 'CodeClass' object into the database.
            /// This method calls the 'Insert' or 'Update' method.
            /// </summary>
            /// <param name='codeClass'>The 'CodeClass' object to save.</param>
            /// <returns>True if successful or false if not.</returns>
            public bool Save(ref CodeClass codeClass)
            {
                // Initial value
                bool saved = false;

                // If the codeClass exists.
                if(codeClass != null)
                {
                    // Is this a new CodeClass
                    if(codeClass.IsNew)
                    {
                        // Insert new CodeClass
                        int newIdentity = this.Insert(codeClass);

                        // if insert was successful
                        if(newIdentity > 0)
                        {
                            // Update Identity
                            codeClass.UpdateIdentity(newIdentity);

                            // Set return value
                            saved = true;
                        }
                    }
                    else
                    {
                        // Update CodeClass
                        saved = this.Update(codeClass);
                    }
                }

                // return value
                return saved;
            }
            #endregion

            #region Update(CodeClass codeClass)
            /// <summary>
            /// This method Updates a 'CodeClass' object in the database.
            /// This method used the DataBridgeManager to execute the 'Update' using the
            /// procedure 'CodeClass_Update'.</param>
            /// </summary>
            /// <param name='codeClass'>The 'CodeClass' object to update.</param>
            /// <returns>True if successful else false if not.</returns>
            public bool Update(CodeClass codeClass)
            {
                // Initial value
                bool saved = false;

                // Get information for calling 'DataBridgeManager.PerformDataOperation' method.
                string methodName = "Update";
                string objectName = "ApplicationLogicComponent.Controllers";

                try
                {
                    if(codeClass != null)
                    {
                        // Create Delegate
                        ApplicationController.DataOperationMethod updateMethod = this.AppController.DataBridge.DataOperations.CodeClassMethods.UpdateCodeClass;

                        // Create parameters for this method
                        List<PolymorphicObject> parameters = CreateCodeClassParameter(codeClass);
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
