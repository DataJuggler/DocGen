

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

    #region class CodeFileController
    /// <summary>
    /// This class controls a(n) 'CodeFile' object.
    /// </summary>
    public class CodeFileController
    {

        #region Private Variables
        private ErrorHandler errorProcessor;
        private ApplicationController appController;
        #endregion

        #region Constructor
        /// <summary>
        /// Creates a new 'CodeFileController' object.
        /// </summary>
        public CodeFileController(ErrorHandler errorProcessorArg, ApplicationController appControllerArg)
        {
            // Save Arguments
            this.ErrorProcessor = errorProcessorArg;
            this.AppController = appControllerArg;
        }
        #endregion

        #region Methods

            #region CreateCodeFileParameter
            /// <summary>
            /// This method creates the parameter for a 'CodeFile' data operation.
            /// </summary>
            /// <param name='codefile'>The 'CodeFile' to use as the first
            /// parameter (parameters[0]).</param>
            /// <returns>A List<PolymorphicObject> collection.</returns>
            private static List<PolymorphicObject> CreateCodeFileParameter(CodeFile codeFile)
            {
                // Initial Value
                List<PolymorphicObject> parameters = new List<PolymorphicObject>();

                // Create PolymorphicObject to hold the parameter
                PolymorphicObject parameter = new PolymorphicObject();

                // Set parameter.ObjectValue
                parameter.ObjectValue = codeFile;

                // Add userParameter to parameters
                parameters.Add(parameter);

                // return value
                return parameters;
            }
            #endregion

            #region Delete(CodeFile tempCodeFile)
            /// <summary>
            /// Deletes a 'CodeFile' from the database
            /// This method calls the DataBridgeManager to execute the delete using the
            /// procedure 'CodeFile_Delete'.
            /// </summary>
            /// <param name='codefile'>The 'CodeFile' to delete.</param>
            /// <returns>True if the delete is successful or false if not.</returns>
            public bool Delete(CodeFile tempCodeFile)
            {
                // locals
                bool deleted = false;

                // Get information for calling 'DataBridgeManager.PerformDataOperation' method.
                string methodName = "DeleteCodeFile";
                string objectName = "ApplicationLogicComponent.Controllers";

                try
                {
                    // verify tempcodeFile exists before attemptintg to delete
                    if(tempCodeFile != null)
                    {
                        // Create Delegate For DataOperation
                        ApplicationController.DataOperationMethod deleteCodeFileMethod = this.AppController.DataBridge.DataOperations.CodeFileMethods.DeleteCodeFile;

                        // Create parameters for this method
                        List<PolymorphicObject> parameters = CreateCodeFileParameter(tempCodeFile);

                        // Perform DataOperation
                        PolymorphicObject returnObject = this.AppController.DataBridge.PerformDataOperation(methodName, objectName, deleteCodeFileMethod, parameters);

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

            #region FetchAll(CodeFile tempCodeFile)
            /// <summary>
            /// This method fetches a collection of 'CodeFile' objects.
            /// This method used the DataBridgeManager to execute the fetch all using the
            /// procedure 'CodeFile_FetchAll'.</summary>
            /// <param name='tempCodeFile'>A temporary CodeFile for passing values.</param>
            /// <returns>A collection of 'CodeFile' objects.</returns>
            public List<CodeFile> FetchAll(CodeFile tempCodeFile)
            {
                // Initial value
                List<CodeFile> codeFileList = null;

                // Get information for calling 'DataBridgeManager.PerformDataOperation' method.
                string methodName = "FetchAll";
                string objectName = "ApplicationLogicComponent.Controllers";

                try
                {
                    // Create DataOperation Method
                    ApplicationController.DataOperationMethod fetchAllMethod = this.AppController.DataBridge.DataOperations.CodeFileMethods.FetchAll;

                    // Create parameters for this method
                    List<PolymorphicObject> parameters = CreateCodeFileParameter(tempCodeFile);

                    // Perform DataOperation
                    PolymorphicObject returnObject = this.AppController.DataBridge.PerformDataOperation(methodName, objectName, fetchAllMethod , parameters);

                    // If return object exists
                    if ((returnObject != null) && (returnObject.ObjectValue as List<CodeFile> != null))
                    {
                        // Create Collection From ReturnObject.ObjectValue
                        codeFileList = (List<CodeFile>) returnObject.ObjectValue;
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
                return codeFileList;
            }
            #endregion

            #region Find(CodeFile tempCodeFile)
            /// <summary>
            /// Finds a 'CodeFile' object by the primary key.
            /// This method used the DataBridgeManager to execute the 'Find' using the
            /// procedure 'CodeFile_Find'</param>
            /// </summary>
            /// <param name='tempCodeFile'>A temporary CodeFile for passing values.</param>
            /// <returns>A 'CodeFile' object if found else a null 'CodeFile'.</returns>
            public CodeFile Find(CodeFile tempCodeFile)
            {
                // Initial values
                CodeFile codeFile = null;

                // Get information for calling 'DataBridgeManager.PerformDataOperation' method.
                string methodName = "Find";
                string objectName = "ApplicationLogicComponent.Controllers";

                try
                {
                    // If object exists
                    if(tempCodeFile != null)
                    {
                        // Create DataOperation
                        ApplicationController.DataOperationMethod findMethod = this.AppController.DataBridge.DataOperations.CodeFileMethods.FindCodeFile;

                        // Create parameters for this method
                        List<PolymorphicObject> parameters = CreateCodeFileParameter(tempCodeFile);

                        // Perform DataOperation
                        PolymorphicObject returnObject = this.AppController.DataBridge.PerformDataOperation(methodName, objectName, findMethod , parameters);

                        // If return object exists
                        if ((returnObject != null) && (returnObject.ObjectValue as CodeFile != null))
                        {
                            // Get ReturnObject
                            codeFile = (CodeFile) returnObject.ObjectValue;
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
                return codeFile;
            }
            #endregion

            #region Insert(CodeFile codeFile)
            /// <summary>
            /// Insert a 'CodeFile' object into the database.
            /// This method uses the DataBridgeManager to execute the 'Insert' using the
            /// procedure 'CodeFile_Insert'.</param>
            /// </summary>
            /// <param name='codeFile'>The 'CodeFile' object to insert.</param>
            /// <returns>The id (int) of the new  'CodeFile' object that was inserted.</returns>
            public int Insert(CodeFile codeFile)
            {
                // Initial values
                int newIdentity = -1;

                // Get information for calling 'DataBridgeManager.PerformDataOperation' method.
                string methodName = "Insert";
                string objectName = "ApplicationLogicComponent.Controllers";

                try
                {
                    // If CodeFileexists
                    if(codeFile != null)
                    {
                        ApplicationController.DataOperationMethod insertMethod = this.AppController.DataBridge.DataOperations.CodeFileMethods.InsertCodeFile;

                        // Create parameters for this method
                        List<PolymorphicObject> parameters = CreateCodeFileParameter(codeFile);

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

            #region Save(ref CodeFile codeFile)
            /// <summary>
            /// Saves a 'CodeFile' object into the database.
            /// This method calls the 'Insert' or 'Update' method.
            /// </summary>
            /// <param name='codeFile'>The 'CodeFile' object to save.</param>
            /// <returns>True if successful or false if not.</returns>
            public bool Save(ref CodeFile codeFile)
            {
                // Initial value
                bool saved = false;

                // If the codeFile exists.
                if(codeFile != null)
                {
                    // Is this a new CodeFile
                    if(codeFile.IsNew)
                    {
                        // Insert new CodeFile
                        int newIdentity = this.Insert(codeFile);

                        // if insert was successful
                        if(newIdentity > 0)
                        {
                            // Update Identity
                            codeFile.UpdateIdentity(newIdentity);

                            // Set return value
                            saved = true;
                        }
                    }
                    else
                    {
                        // Update CodeFile
                        saved = this.Update(codeFile);
                    }
                }

                // return value
                return saved;
            }
            #endregion

            #region Update(CodeFile codeFile)
            /// <summary>
            /// This method Updates a 'CodeFile' object in the database.
            /// This method used the DataBridgeManager to execute the 'Update' using the
            /// procedure 'CodeFile_Update'.</param>
            /// </summary>
            /// <param name='codeFile'>The 'CodeFile' object to update.</param>
            /// <returns>True if successful else false if not.</returns>
            public bool Update(CodeFile codeFile)
            {
                // Initial value
                bool saved = false;

                // Get information for calling 'DataBridgeManager.PerformDataOperation' method.
                string methodName = "Update";
                string objectName = "ApplicationLogicComponent.Controllers";

                try
                {
                    if(codeFile != null)
                    {
                        // Create Delegate
                        ApplicationController.DataOperationMethod updateMethod = this.AppController.DataBridge.DataOperations.CodeFileMethods.UpdateCodeFile;

                        // Create parameters for this method
                        List<PolymorphicObject> parameters = CreateCodeFileParameter(codeFile);
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
