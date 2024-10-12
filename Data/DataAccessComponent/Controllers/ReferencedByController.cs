

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

    #region class ReferencedByController
    /// <summary>
    /// This class controls a(n) 'ReferencedBy' object.
    /// </summary>
    public class ReferencedByController
    {

        #region Private Variables
        private ErrorHandler errorProcessor;
        private ApplicationController appController;
        #endregion

        #region Constructor
        /// <summary>
        /// Creates a new 'ReferencedByController' object.
        /// </summary>
        public ReferencedByController(ErrorHandler errorProcessorArg, ApplicationController appControllerArg)
        {
            // Save Arguments
            this.ErrorProcessor = errorProcessorArg;
            this.AppController = appControllerArg;
        }
        #endregion

        #region Methods

            #region CreateReferencedByParameter
            /// <summary>
            /// This method creates the parameter for a 'ReferencedBy' data operation.
            /// </summary>
            /// <param name='referencedby'>The 'ReferencedBy' to use as the first
            /// parameter (parameters[0]).</param>
            /// <returns>A List<PolymorphicObject> collection.</returns>
            private static List<PolymorphicObject> CreateReferencedByParameter(ReferencedBy referencedBy)
            {
                // Initial Value
                List<PolymorphicObject> parameters = new List<PolymorphicObject>();

                // Create PolymorphicObject to hold the parameter
                PolymorphicObject parameter = new PolymorphicObject();

                // Set parameter.ObjectValue
                parameter.ObjectValue = referencedBy;

                // Add userParameter to parameters
                parameters.Add(parameter);

                // return value
                return parameters;
            }
            #endregion

            #region Delete(ReferencedBy tempReferencedBy)
            /// <summary>
            /// Deletes a 'ReferencedBy' from the database
            /// This method calls the DataBridgeManager to execute the delete using the
            /// procedure 'ReferencedBy_Delete'.
            /// </summary>
            /// <param name='referencedby'>The 'ReferencedBy' to delete.</param>
            /// <returns>True if the delete is successful or false if not.</returns>
            public bool Delete(ReferencedBy tempReferencedBy)
            {
                // locals
                bool deleted = false;

                // Get information for calling 'DataBridgeManager.PerformDataOperation' method.
                string methodName = "DeleteReferencedBy";
                string objectName = "ApplicationLogicComponent.Controllers";

                try
                {
                    // verify tempreferencedBy exists before attemptintg to delete
                    if(tempReferencedBy != null)
                    {
                        // Create Delegate For DataOperation
                        ApplicationController.DataOperationMethod deleteReferencedByMethod = this.AppController.DataBridge.DataOperations.ReferencedByMethods.DeleteReferencedBy;

                        // Create parameters for this method
                        List<PolymorphicObject> parameters = CreateReferencedByParameter(tempReferencedBy);

                        // Perform DataOperation
                        PolymorphicObject returnObject = this.AppController.DataBridge.PerformDataOperation(methodName, objectName, deleteReferencedByMethod, parameters);

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

            #region FetchAll(ReferencedBy tempReferencedBy)
            /// <summary>
            /// This method fetches a collection of 'ReferencedBy' objects.
            /// This method used the DataBridgeManager to execute the fetch all using the
            /// procedure 'ReferencedBy_FetchAll'.</summary>
            /// <param name='tempReferencedBy'>A temporary ReferencedBy for passing values.</param>
            /// <returns>A collection of 'ReferencedBy' objects.</returns>
            public List<ReferencedBy> FetchAll(ReferencedBy tempReferencedBy)
            {
                // Initial value
                List<ReferencedBy> referencedByList = null;

                // Get information for calling 'DataBridgeManager.PerformDataOperation' method.
                string methodName = "FetchAll";
                string objectName = "ApplicationLogicComponent.Controllers";

                try
                {
                    // Create DataOperation Method
                    ApplicationController.DataOperationMethod fetchAllMethod = this.AppController.DataBridge.DataOperations.ReferencedByMethods.FetchAll;

                    // Create parameters for this method
                    List<PolymorphicObject> parameters = CreateReferencedByParameter(tempReferencedBy);

                    // Perform DataOperation
                    PolymorphicObject returnObject = this.AppController.DataBridge.PerformDataOperation(methodName, objectName, fetchAllMethod , parameters);

                    // If return object exists
                    if ((returnObject != null) && (returnObject.ObjectValue as List<ReferencedBy> != null))
                    {
                        // Create Collection From ReturnObject.ObjectValue
                        referencedByList = (List<ReferencedBy>) returnObject.ObjectValue;
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
                return referencedByList;
            }
            #endregion

            #region Find(ReferencedBy tempReferencedBy)
            /// <summary>
            /// Finds a 'ReferencedBy' object by the primary key.
            /// This method used the DataBridgeManager to execute the 'Find' using the
            /// procedure 'ReferencedBy_Find'</param>
            /// </summary>
            /// <param name='tempReferencedBy'>A temporary ReferencedBy for passing values.</param>
            /// <returns>A 'ReferencedBy' object if found else a null 'ReferencedBy'.</returns>
            public ReferencedBy Find(ReferencedBy tempReferencedBy)
            {
                // Initial values
                ReferencedBy referencedBy = null;

                // Get information for calling 'DataBridgeManager.PerformDataOperation' method.
                string methodName = "Find";
                string objectName = "ApplicationLogicComponent.Controllers";

                try
                {
                    // If object exists
                    if(tempReferencedBy != null)
                    {
                        // Create DataOperation
                        ApplicationController.DataOperationMethod findMethod = this.AppController.DataBridge.DataOperations.ReferencedByMethods.FindReferencedBy;

                        // Create parameters for this method
                        List<PolymorphicObject> parameters = CreateReferencedByParameter(tempReferencedBy);

                        // Perform DataOperation
                        PolymorphicObject returnObject = this.AppController.DataBridge.PerformDataOperation(methodName, objectName, findMethod , parameters);

                        // If return object exists
                        if ((returnObject != null) && (returnObject.ObjectValue as ReferencedBy != null))
                        {
                            // Get ReturnObject
                            referencedBy = (ReferencedBy) returnObject.ObjectValue;
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
                return referencedBy;
            }
            #endregion

            #region Insert(ReferencedBy referencedBy)
            /// <summary>
            /// Insert a 'ReferencedBy' object into the database.
            /// This method uses the DataBridgeManager to execute the 'Insert' using the
            /// procedure 'ReferencedBy_Insert'.</param>
            /// </summary>
            /// <param name='referencedBy'>The 'ReferencedBy' object to insert.</param>
            /// <returns>The id (int) of the new  'ReferencedBy' object that was inserted.</returns>
            public int Insert(ReferencedBy referencedBy)
            {
                // Initial values
                int newIdentity = -1;

                // Get information for calling 'DataBridgeManager.PerformDataOperation' method.
                string methodName = "Insert";
                string objectName = "ApplicationLogicComponent.Controllers";

                try
                {
                    // If ReferencedByexists
                    if(referencedBy != null)
                    {
                        ApplicationController.DataOperationMethod insertMethod = this.AppController.DataBridge.DataOperations.ReferencedByMethods.InsertReferencedBy;

                        // Create parameters for this method
                        List<PolymorphicObject> parameters = CreateReferencedByParameter(referencedBy);

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

            #region Save(ref ReferencedBy referencedBy)
            /// <summary>
            /// Saves a 'ReferencedBy' object into the database.
            /// This method calls the 'Insert' or 'Update' method.
            /// </summary>
            /// <param name='referencedBy'>The 'ReferencedBy' object to save.</param>
            /// <returns>True if successful or false if not.</returns>
            public bool Save(ref ReferencedBy referencedBy)
            {
                // Initial value
                bool saved = false;

                // If the referencedBy exists.
                if(referencedBy != null)
                {
                    // Is this a new ReferencedBy
                    if(referencedBy.IsNew)
                    {
                        // Insert new ReferencedBy
                        int newIdentity = this.Insert(referencedBy);

                        // if insert was successful
                        if(newIdentity > 0)
                        {
                            // Update Identity
                            referencedBy.UpdateIdentity(newIdentity);

                            // Set return value
                            saved = true;
                        }
                    }
                    else
                    {
                        // Update ReferencedBy
                        saved = this.Update(referencedBy);
                    }
                }

                // return value
                return saved;
            }
            #endregion

            #region Update(ReferencedBy referencedBy)
            /// <summary>
            /// This method Updates a 'ReferencedBy' object in the database.
            /// This method used the DataBridgeManager to execute the 'Update' using the
            /// procedure 'ReferencedBy_Update'.</param>
            /// </summary>
            /// <param name='referencedBy'>The 'ReferencedBy' object to update.</param>
            /// <returns>True if successful else false if not.</returns>
            public bool Update(ReferencedBy referencedBy)
            {
                // Initial value
                bool saved = false;

                // Get information for calling 'DataBridgeManager.PerformDataOperation' method.
                string methodName = "Update";
                string objectName = "ApplicationLogicComponent.Controllers";

                try
                {
                    if(referencedBy != null)
                    {
                        // Create Delegate
                        ApplicationController.DataOperationMethod updateMethod = this.AppController.DataBridge.DataOperations.ReferencedByMethods.UpdateReferencedBy;

                        // Create parameters for this method
                        List<PolymorphicObject> parameters = CreateReferencedByParameter(referencedBy);
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
