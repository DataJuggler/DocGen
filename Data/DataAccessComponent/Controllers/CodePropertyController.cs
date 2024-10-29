

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

    #region class CodePropertyController
    /// <summary>
    /// This class controls a(n) 'CodeProperty' object.
    /// </summary>
    public class CodePropertyController
    {

        #region Private Variables
        private ErrorHandler errorProcessor;
        private ApplicationController appController;
        #endregion

        #region Constructor
        /// <summary>
        /// Creates a new 'CodePropertyController' object.
        /// </summary>
        public CodePropertyController(ErrorHandler errorProcessorArg, ApplicationController appControllerArg)
        {
            // Save Arguments
            this.ErrorProcessor = errorProcessorArg;
            this.AppController = appControllerArg;
        }
        #endregion

        #region Methods

            #region CreateCodePropertyParameter
            /// <summary>
            /// This method creates the parameter for a 'CodeProperty' data operation.
            /// </summary>
            /// <param name='codeproperty'>The 'CodeProperty' to use as the first
            /// parameter (parameters[0]).</param>
            /// <returns>A List<PolymorphicObject> collection.</returns>
            private static List<PolymorphicObject> CreateCodePropertyParameter(CodeProperty codeProperty)
            {
                // Initial Value
                List<PolymorphicObject> parameters = new List<PolymorphicObject>();

                // Create PolymorphicObject to hold the parameter
                PolymorphicObject parameter = new PolymorphicObject();

                // Set parameter.ObjectValue
                parameter.ObjectValue = codeProperty;

                // Add userParameter to parameters
                parameters.Add(parameter);

                // return value
                return parameters;
            }
            #endregion

            #region Delete(CodeProperty tempCodeProperty)
            /// <summary>
            /// Deletes a 'CodeProperty' from the database
            /// This method calls the DataBridgeManager to execute the delete using the
            /// procedure 'CodeProperty_Delete'.
            /// </summary>
            /// <param name='codeproperty'>The 'CodeProperty' to delete.</param>
            /// <returns>True if the delete is successful or false if not.</returns>
            public bool Delete(CodeProperty tempCodeProperty)
            {
                // locals
                bool deleted = false;

                // Get information for calling 'DataBridgeManager.PerformDataOperation' method.
                string methodName = "DeleteCodeProperty";
                string objectName = "ApplicationLogicComponent.Controllers";

                try
                {
                    // verify tempcodeProperty exists before attemptintg to delete
                    if(tempCodeProperty != null)
                    {
                        // Create Delegate For DataOperation
                        ApplicationController.DataOperationMethod deleteCodePropertyMethod = this.AppController.DataBridge.DataOperations.CodePropertyMethods.DeleteCodeProperty;

                        // Create parameters for this method
                        List<PolymorphicObject> parameters = CreateCodePropertyParameter(tempCodeProperty);

                        // Perform DataOperation
                        PolymorphicObject returnObject = this.AppController.DataBridge.PerformDataOperation(methodName, objectName, deleteCodePropertyMethod, parameters);

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

            #region FetchAll(CodeProperty tempCodeProperty)
            /// <summary>
            /// This method fetches a collection of 'CodeProperty' objects.
            /// This method used the DataBridgeManager to execute the fetch all using the
            /// procedure 'CodeProperty_FetchAll'.</summary>
            /// <param name='tempCodeProperty'>A temporary CodeProperty for passing values.</param>
            /// <returns>A collection of 'CodeProperty' objects.</returns>
            public List<CodeProperty> FetchAll(CodeProperty tempCodeProperty)
            {
                // Initial value
                List<CodeProperty> codePropertyList = null;

                // Get information for calling 'DataBridgeManager.PerformDataOperation' method.
                string methodName = "FetchAll";
                string objectName = "ApplicationLogicComponent.Controllers";

                try
                {
                    // Create DataOperation Method
                    ApplicationController.DataOperationMethod fetchAllMethod = this.AppController.DataBridge.DataOperations.CodePropertyMethods.FetchAll;

                    // Create parameters for this method
                    List<PolymorphicObject> parameters = CreateCodePropertyParameter(tempCodeProperty);

                    // Perform DataOperation
                    PolymorphicObject returnObject = this.AppController.DataBridge.PerformDataOperation(methodName, objectName, fetchAllMethod , parameters);

                    // If return object exists
                    if ((returnObject != null) && (returnObject.ObjectValue as List<CodeProperty> != null))
                    {
                        // Create Collection From ReturnObject.ObjectValue
                        codePropertyList = (List<CodeProperty>) returnObject.ObjectValue;
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
                return codePropertyList;
            }
            #endregion

            #region Find(CodeProperty tempCodeProperty)
            /// <summary>
            /// Finds a 'CodeProperty' object by the primary key.
            /// This method used the DataBridgeManager to execute the 'Find' using the
            /// procedure 'CodeProperty_Find'</param>
            /// </summary>
            /// <param name='tempCodeProperty'>A temporary CodeProperty for passing values.</param>
            /// <returns>A 'CodeProperty' object if found else a null 'CodeProperty'.</returns>
            public CodeProperty Find(CodeProperty tempCodeProperty)
            {
                // Initial values
                CodeProperty codeProperty = null;

                // Get information for calling 'DataBridgeManager.PerformDataOperation' method.
                string methodName = "Find";
                string objectName = "ApplicationLogicComponent.Controllers";

                try
                {
                    // If object exists
                    if(tempCodeProperty != null)
                    {
                        // Create DataOperation
                        ApplicationController.DataOperationMethod findMethod = this.AppController.DataBridge.DataOperations.CodePropertyMethods.FindCodeProperty;

                        // Create parameters for this method
                        List<PolymorphicObject> parameters = CreateCodePropertyParameter(tempCodeProperty);

                        // Perform DataOperation
                        PolymorphicObject returnObject = this.AppController.DataBridge.PerformDataOperation(methodName, objectName, findMethod , parameters);

                        // If return object exists
                        if ((returnObject != null) && (returnObject.ObjectValue as CodeProperty != null))
                        {
                            // Get ReturnObject
                            codeProperty = (CodeProperty) returnObject.ObjectValue;
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
                return codeProperty;
            }
            #endregion

            #region Insert(CodeProperty codeProperty)
            /// <summary>
            /// Insert a 'CodeProperty' object into the database.
            /// This method uses the DataBridgeManager to execute the 'Insert' using the
            /// procedure 'CodeProperty_Insert'.</param>
            /// </summary>
            /// <param name='codeProperty'>The 'CodeProperty' object to insert.</param>
            /// <returns>The id (int) of the new  'CodeProperty' object that was inserted.</returns>
            public int Insert(CodeProperty codeProperty)
            {
                // Initial values
                int newIdentity = -1;

                // Get information for calling 'DataBridgeManager.PerformDataOperation' method.
                string methodName = "Insert";
                string objectName = "ApplicationLogicComponent.Controllers";

                try
                {
                    // If CodePropertyexists
                    if(codeProperty != null)
                    {
                        ApplicationController.DataOperationMethod insertMethod = this.AppController.DataBridge.DataOperations.CodePropertyMethods.InsertCodeProperty;

                        // Create parameters for this method
                        List<PolymorphicObject> parameters = CreateCodePropertyParameter(codeProperty);

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

            #region Save(ref CodeProperty codeProperty)
            /// <summary>
            /// Saves a 'CodeProperty' object into the database.
            /// This method calls the 'Insert' or 'Update' method.
            /// </summary>
            /// <param name='codeProperty'>The 'CodeProperty' object to save.</param>
            /// <returns>True if successful or false if not.</returns>
            public bool Save(ref CodeProperty codeProperty)
            {
                // Initial value
                bool saved = false;

                // If the codeProperty exists.
                if(codeProperty != null)
                {
                    // Is this a new CodeProperty
                    if(codeProperty.IsNew)
                    {
                        // Insert new CodeProperty
                        int newIdentity = this.Insert(codeProperty);

                        // if insert was successful
                        if(newIdentity > 0)
                        {
                            // Update Identity
                            codeProperty.UpdateIdentity(newIdentity);

                            // Set return value
                            saved = true;
                        }
                    }
                    else
                    {
                        // Update CodeProperty
                        saved = this.Update(codeProperty);
                    }
                }

                // return value
                return saved;
            }
            #endregion

            #region Update(CodeProperty codeProperty)
            /// <summary>
            /// This method Updates a 'CodeProperty' object in the database.
            /// This method used the DataBridgeManager to execute the 'Update' using the
            /// procedure 'CodeProperty_Update'.</param>
            /// </summary>
            /// <param name='codeProperty'>The 'CodeProperty' object to update.</param>
            /// <returns>True if successful else false if not.</returns>
            public bool Update(CodeProperty codeProperty)
            {
                // Initial value
                bool saved = false;

                // Get information for calling 'DataBridgeManager.PerformDataOperation' method.
                string methodName = "Update";
                string objectName = "ApplicationLogicComponent.Controllers";

                try
                {
                    if(codeProperty != null)
                    {
                        // Create Delegate
                        ApplicationController.DataOperationMethod updateMethod = this.AppController.DataBridge.DataOperations.CodePropertyMethods.UpdateCodeProperty;

                        // Create parameters for this method
                        List<PolymorphicObject> parameters = CreateCodePropertyParameter(codeProperty);
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
