

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

    #region class CodeSampleController
    /// <summary>
    /// This class controls a(n) 'CodeSample' object.
    /// </summary>
    public class CodeSampleController
    {

        #region Private Variables
        private ErrorHandler errorProcessor;
        private ApplicationController appController;
        #endregion

        #region Constructor
        /// <summary>
        /// Creates a new 'CodeSampleController' object.
        /// </summary>
        public CodeSampleController(ErrorHandler errorProcessorArg, ApplicationController appControllerArg)
        {
            // Save Arguments
            this.ErrorProcessor = errorProcessorArg;
            this.AppController = appControllerArg;
        }
        #endregion

        #region Methods

            #region CreateCodeSampleParameter
            /// <summary>
            /// This method creates the parameter for a 'CodeSample' data operation.
            /// </summary>
            /// <param name='codesample'>The 'CodeSample' to use as the first
            /// parameter (parameters[0]).</param>
            /// <returns>A List<PolymorphicObject> collection.</returns>
            private static List<PolymorphicObject> CreateCodeSampleParameter(CodeSample codeSample)
            {
                // Initial Value
                List<PolymorphicObject> parameters = new List<PolymorphicObject>();

                // Create PolymorphicObject to hold the parameter
                PolymorphicObject parameter = new PolymorphicObject();

                // Set parameter.ObjectValue
                parameter.ObjectValue = codeSample;

                // Add userParameter to parameters
                parameters.Add(parameter);

                // return value
                return parameters;
            }
            #endregion

            #region Delete(CodeSample tempCodeSample)
            /// <summary>
            /// Deletes a 'CodeSample' from the database
            /// This method calls the DataBridgeManager to execute the delete using the
            /// procedure 'CodeSample_Delete'.
            /// </summary>
            /// <param name='codesample'>The 'CodeSample' to delete.</param>
            /// <returns>True if the delete is successful or false if not.</returns>
            public bool Delete(CodeSample tempCodeSample)
            {
                // locals
                bool deleted = false;

                // Get information for calling 'DataBridgeManager.PerformDataOperation' method.
                string methodName = "DeleteCodeSample";
                string objectName = "ApplicationLogicComponent.Controllers";

                try
                {
                    // verify tempcodeSample exists before attemptintg to delete
                    if(tempCodeSample != null)
                    {
                        // Create Delegate For DataOperation
                        ApplicationController.DataOperationMethod deleteCodeSampleMethod = this.AppController.DataBridge.DataOperations.CodeSampleMethods.DeleteCodeSample;

                        // Create parameters for this method
                        List<PolymorphicObject> parameters = CreateCodeSampleParameter(tempCodeSample);

                        // Perform DataOperation
                        PolymorphicObject returnObject = this.AppController.DataBridge.PerformDataOperation(methodName, objectName, deleteCodeSampleMethod, parameters);

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

            #region FetchAll(CodeSample tempCodeSample)
            /// <summary>
            /// This method fetches a collection of 'CodeSample' objects.
            /// This method used the DataBridgeManager to execute the fetch all using the
            /// procedure 'CodeSample_FetchAll'.</summary>
            /// <param name='tempCodeSample'>A temporary CodeSample for passing values.</param>
            /// <returns>A collection of 'CodeSample' objects.</returns>
            public List<CodeSample> FetchAll(CodeSample tempCodeSample)
            {
                // Initial value
                List<CodeSample> codeSampleList = null;

                // Get information for calling 'DataBridgeManager.PerformDataOperation' method.
                string methodName = "FetchAll";
                string objectName = "ApplicationLogicComponent.Controllers";

                try
                {
                    // Create DataOperation Method
                    ApplicationController.DataOperationMethod fetchAllMethod = this.AppController.DataBridge.DataOperations.CodeSampleMethods.FetchAll;

                    // Create parameters for this method
                    List<PolymorphicObject> parameters = CreateCodeSampleParameter(tempCodeSample);

                    // Perform DataOperation
                    PolymorphicObject returnObject = this.AppController.DataBridge.PerformDataOperation(methodName, objectName, fetchAllMethod , parameters);

                    // If return object exists
                    if ((returnObject != null) && (returnObject.ObjectValue as List<CodeSample> != null))
                    {
                        // Create Collection From ReturnObject.ObjectValue
                        codeSampleList = (List<CodeSample>) returnObject.ObjectValue;
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
                return codeSampleList;
            }
            #endregion

            #region Find(CodeSample tempCodeSample)
            /// <summary>
            /// Finds a 'CodeSample' object by the primary key.
            /// This method used the DataBridgeManager to execute the 'Find' using the
            /// procedure 'CodeSample_Find'</param>
            /// </summary>
            /// <param name='tempCodeSample'>A temporary CodeSample for passing values.</param>
            /// <returns>A 'CodeSample' object if found else a null 'CodeSample'.</returns>
            public CodeSample Find(CodeSample tempCodeSample)
            {
                // Initial values
                CodeSample codeSample = null;

                // Get information for calling 'DataBridgeManager.PerformDataOperation' method.
                string methodName = "Find";
                string objectName = "ApplicationLogicComponent.Controllers";

                try
                {
                    // If object exists
                    if(tempCodeSample != null)
                    {
                        // Create DataOperation
                        ApplicationController.DataOperationMethod findMethod = this.AppController.DataBridge.DataOperations.CodeSampleMethods.FindCodeSample;

                        // Create parameters for this method
                        List<PolymorphicObject> parameters = CreateCodeSampleParameter(tempCodeSample);

                        // Perform DataOperation
                        PolymorphicObject returnObject = this.AppController.DataBridge.PerformDataOperation(methodName, objectName, findMethod , parameters);

                        // If return object exists
                        if ((returnObject != null) && (returnObject.ObjectValue as CodeSample != null))
                        {
                            // Get ReturnObject
                            codeSample = (CodeSample) returnObject.ObjectValue;
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
                return codeSample;
            }
            #endregion

            #region Insert(CodeSample codeSample)
            /// <summary>
            /// Insert a 'CodeSample' object into the database.
            /// This method uses the DataBridgeManager to execute the 'Insert' using the
            /// procedure 'CodeSample_Insert'.</param>
            /// </summary>
            /// <param name='codeSample'>The 'CodeSample' object to insert.</param>
            /// <returns>The id (int) of the new  'CodeSample' object that was inserted.</returns>
            public int Insert(CodeSample codeSample)
            {
                // Initial values
                int newIdentity = -1;

                // Get information for calling 'DataBridgeManager.PerformDataOperation' method.
                string methodName = "Insert";
                string objectName = "ApplicationLogicComponent.Controllers";

                try
                {
                    // If CodeSampleexists
                    if(codeSample != null)
                    {
                        ApplicationController.DataOperationMethod insertMethod = this.AppController.DataBridge.DataOperations.CodeSampleMethods.InsertCodeSample;

                        // Create parameters for this method
                        List<PolymorphicObject> parameters = CreateCodeSampleParameter(codeSample);

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

            #region Save(ref CodeSample codeSample)
            /// <summary>
            /// Saves a 'CodeSample' object into the database.
            /// This method calls the 'Insert' or 'Update' method.
            /// </summary>
            /// <param name='codeSample'>The 'CodeSample' object to save.</param>
            /// <returns>True if successful or false if not.</returns>
            public bool Save(ref CodeSample codeSample)
            {
                // Initial value
                bool saved = false;

                // If the codeSample exists.
                if(codeSample != null)
                {
                    // Is this a new CodeSample
                    if(codeSample.IsNew)
                    {
                        // Insert new CodeSample
                        int newIdentity = this.Insert(codeSample);

                        // if insert was successful
                        if(newIdentity > 0)
                        {
                            // Update Identity
                            codeSample.UpdateIdentity(newIdentity);

                            // Set return value
                            saved = true;
                        }
                    }
                    else
                    {
                        // Update CodeSample
                        saved = this.Update(codeSample);
                    }
                }

                // return value
                return saved;
            }
            #endregion

            #region Update(CodeSample codeSample)
            /// <summary>
            /// This method Updates a 'CodeSample' object in the database.
            /// This method used the DataBridgeManager to execute the 'Update' using the
            /// procedure 'CodeSample_Update'.</param>
            /// </summary>
            /// <param name='codeSample'>The 'CodeSample' object to update.</param>
            /// <returns>True if successful else false if not.</returns>
            public bool Update(CodeSample codeSample)
            {
                // Initial value
                bool saved = false;

                // Get information for calling 'DataBridgeManager.PerformDataOperation' method.
                string methodName = "Update";
                string objectName = "ApplicationLogicComponent.Controllers";

                try
                {
                    if(codeSample != null)
                    {
                        // Create Delegate
                        ApplicationController.DataOperationMethod updateMethod = this.AppController.DataBridge.DataOperations.CodeSampleMethods.UpdateCodeSample;

                        // Create parameters for this method
                        List<PolymorphicObject> parameters = CreateCodeSampleParameter(codeSample);
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
