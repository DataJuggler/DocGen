

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

    #region class VSProjectController
    /// <summary>
    /// This class controls a(n) 'VSProject' object.
    /// </summary>
    public class VSProjectController
    {

        #region Private Variables
        private ErrorHandler errorProcessor;
        private ApplicationController appController;
        #endregion

        #region Constructor
        /// <summary>
        /// Creates a new 'VSProjectController' object.
        /// </summary>
        public VSProjectController(ErrorHandler errorProcessorArg, ApplicationController appControllerArg)
        {
            // Save Arguments
            this.ErrorProcessor = errorProcessorArg;
            this.AppController = appControllerArg;
        }
        #endregion

        #region Methods

            #region CreateVSProjectParameter
            /// <summary>
            /// This method creates the parameter for a 'VSProject' data operation.
            /// </summary>
            /// <param name='vsproject'>The 'VSProject' to use as the first
            /// parameter (parameters[0]).</param>
            /// <returns>A List<PolymorphicObject> collection.</returns>
            private static List<PolymorphicObject> CreateVSProjectParameter(VSProject vSProject)
            {
                // Initial Value
                List<PolymorphicObject> parameters = new List<PolymorphicObject>();

                // Create PolymorphicObject to hold the parameter
                PolymorphicObject parameter = new PolymorphicObject();

                // Set parameter.ObjectValue
                parameter.ObjectValue = vSProject;

                // Add userParameter to parameters
                parameters.Add(parameter);

                // return value
                return parameters;
            }
            #endregion

            #region Delete(VSProject tempVSProject)
            /// <summary>
            /// Deletes a 'VSProject' from the database
            /// This method calls the DataBridgeManager to execute the delete using the
            /// procedure 'VSProject_Delete'.
            /// </summary>
            /// <param name='vsproject'>The 'VSProject' to delete.</param>
            /// <returns>True if the delete is successful or false if not.</returns>
            public bool Delete(VSProject tempVSProject)
            {
                // locals
                bool deleted = false;

                // Get information for calling 'DataBridgeManager.PerformDataOperation' method.
                string methodName = "DeleteVSProject";
                string objectName = "ApplicationLogicComponent.Controllers";

                try
                {
                    // verify tempvSProject exists before attemptintg to delete
                    if(tempVSProject != null)
                    {
                        // Create Delegate For DataOperation
                        ApplicationController.DataOperationMethod deleteVSProjectMethod = this.AppController.DataBridge.DataOperations.VSProjectMethods.DeleteVSProject;

                        // Create parameters for this method
                        List<PolymorphicObject> parameters = CreateVSProjectParameter(tempVSProject);

                        // Perform DataOperation
                        PolymorphicObject returnObject = this.AppController.DataBridge.PerformDataOperation(methodName, objectName, deleteVSProjectMethod, parameters);

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

            #region FetchAll(VSProject tempVSProject)
            /// <summary>
            /// This method fetches a collection of 'VSProject' objects.
            /// This method used the DataBridgeManager to execute the fetch all using the
            /// procedure 'VSProject_FetchAll'.</summary>
            /// <param name='tempVSProject'>A temporary VSProject for passing values.</param>
            /// <returns>A collection of 'VSProject' objects.</returns>
            public List<VSProject> FetchAll(VSProject tempVSProject)
            {
                // Initial value
                List<VSProject> vSProjectList = null;

                // Get information for calling 'DataBridgeManager.PerformDataOperation' method.
                string methodName = "FetchAll";
                string objectName = "ApplicationLogicComponent.Controllers";

                try
                {
                    // Create DataOperation Method
                    ApplicationController.DataOperationMethod fetchAllMethod = this.AppController.DataBridge.DataOperations.VSProjectMethods.FetchAll;

                    // Create parameters for this method
                    List<PolymorphicObject> parameters = CreateVSProjectParameter(tempVSProject);

                    // Perform DataOperation
                    PolymorphicObject returnObject = this.AppController.DataBridge.PerformDataOperation(methodName, objectName, fetchAllMethod , parameters);

                    // If return object exists
                    if ((returnObject != null) && (returnObject.ObjectValue as List<VSProject> != null))
                    {
                        // Create Collection From ReturnObject.ObjectValue
                        vSProjectList = (List<VSProject>) returnObject.ObjectValue;
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
                return vSProjectList;
            }
            #endregion

            #region Find(VSProject tempVSProject)
            /// <summary>
            /// Finds a 'VSProject' object by the primary key.
            /// This method used the DataBridgeManager to execute the 'Find' using the
            /// procedure 'VSProject_Find'</param>
            /// </summary>
            /// <param name='tempVSProject'>A temporary VSProject for passing values.</param>
            /// <returns>A 'VSProject' object if found else a null 'VSProject'.</returns>
            public VSProject Find(VSProject tempVSProject)
            {
                // Initial values
                VSProject vSProject = null;

                // Get information for calling 'DataBridgeManager.PerformDataOperation' method.
                string methodName = "Find";
                string objectName = "ApplicationLogicComponent.Controllers";

                try
                {
                    // If object exists
                    if(tempVSProject != null)
                    {
                        // Create DataOperation
                        ApplicationController.DataOperationMethod findMethod = this.AppController.DataBridge.DataOperations.VSProjectMethods.FindVSProject;

                        // Create parameters for this method
                        List<PolymorphicObject> parameters = CreateVSProjectParameter(tempVSProject);

                        // Perform DataOperation
                        PolymorphicObject returnObject = this.AppController.DataBridge.PerformDataOperation(methodName, objectName, findMethod , parameters);

                        // If return object exists
                        if ((returnObject != null) && (returnObject.ObjectValue as VSProject != null))
                        {
                            // Get ReturnObject
                            vSProject = (VSProject) returnObject.ObjectValue;
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
                return vSProject;
            }
            #endregion

            #region Insert(VSProject vSProject)
            /// <summary>
            /// Insert a 'VSProject' object into the database.
            /// This method uses the DataBridgeManager to execute the 'Insert' using the
            /// procedure 'VSProject_Insert'.</param>
            /// </summary>
            /// <param name='vSProject'>The 'VSProject' object to insert.</param>
            /// <returns>The id (int) of the new  'VSProject' object that was inserted.</returns>
            public int Insert(VSProject vSProject)
            {
                // Initial values
                int newIdentity = -1;

                // Get information for calling 'DataBridgeManager.PerformDataOperation' method.
                string methodName = "Insert";
                string objectName = "ApplicationLogicComponent.Controllers";

                try
                {
                    // If VSProjectexists
                    if(vSProject != null)
                    {
                        ApplicationController.DataOperationMethod insertMethod = this.AppController.DataBridge.DataOperations.VSProjectMethods.InsertVSProject;

                        // Create parameters for this method
                        List<PolymorphicObject> parameters = CreateVSProjectParameter(vSProject);

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

            #region Save(ref VSProject vSProject)
            /// <summary>
            /// Saves a 'VSProject' object into the database.
            /// This method calls the 'Insert' or 'Update' method.
            /// </summary>
            /// <param name='vSProject'>The 'VSProject' object to save.</param>
            /// <returns>True if successful or false if not.</returns>
            public bool Save(ref VSProject vSProject)
            {
                // Initial value
                bool saved = false;

                // If the vSProject exists.
                if(vSProject != null)
                {
                    // Is this a new VSProject
                    if(vSProject.IsNew)
                    {
                        // Insert new VSProject
                        int newIdentity = this.Insert(vSProject);

                        // if insert was successful
                        if(newIdentity > 0)
                        {
                            // Update Identity
                            vSProject.UpdateIdentity(newIdentity);

                            // Set return value
                            saved = true;
                        }
                    }
                    else
                    {
                        // Update VSProject
                        saved = this.Update(vSProject);
                    }
                }

                // return value
                return saved;
            }
            #endregion

            #region Update(VSProject vSProject)
            /// <summary>
            /// This method Updates a 'VSProject' object in the database.
            /// This method used the DataBridgeManager to execute the 'Update' using the
            /// procedure 'VSProject_Update'.</param>
            /// </summary>
            /// <param name='vSProject'>The 'VSProject' object to update.</param>
            /// <returns>True if successful else false if not.</returns>
            public bool Update(VSProject vSProject)
            {
                // Initial value
                bool saved = false;

                // Get information for calling 'DataBridgeManager.PerformDataOperation' method.
                string methodName = "Update";
                string objectName = "ApplicationLogicComponent.Controllers";

                try
                {
                    if(vSProject != null)
                    {
                        // Create Delegate
                        ApplicationController.DataOperationMethod updateMethod = this.AppController.DataBridge.DataOperations.VSProjectMethods.UpdateVSProject;

                        // Create parameters for this method
                        List<PolymorphicObject> parameters = CreateVSProjectParameter(vSProject);
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
