

#region using statements

using DataAccessComponent.Data;
using DataAccessComponent.Data.Writers;
using DataAccessComponent.DataBridge;
using DataAccessComponent.StoredProcedureManager.DeleteProcedures;
using DataAccessComponent.StoredProcedureManager.FetchProcedures;
using DataAccessComponent.StoredProcedureManager.InsertProcedures;
using DataAccessComponent.StoredProcedureManager.UpdateProcedures;
using ObjectLibrary.BusinessObjects;
using System;
using System.Collections.Generic;

#endregion


namespace DataAccessComponent.DataOperations
{

    #region class VSProjectMethods
    /// <summary>
    /// This class contains methods for modifying a 'VSProject' object.
    /// </summary>
    public class VSProjectMethods
    {

        #region Private Variables
        private DataManager dataManager;
        #endregion

        #region Constructor
        /// <summary>
        /// Creates a new Creates a new 'VSProjectMethods' object.
        /// </summary>
        public VSProjectMethods(DataManager dataManagerArg)
        {
            // Save Argument
            this.DataManager = dataManagerArg;
        }
        #endregion

        #region Methods

            #region DeleteVSProject(VSProject)
            /// <summary>
            /// This method deletes a 'VSProject' object.
            /// </summary>
            /// <param name='List<PolymorphicObject>'>The 'VSProject' to delete.
            /// <returns>A PolymorphicObject object with a Boolean value.
            internal PolymorphicObject DeleteVSProject(List<PolymorphicObject> parameters, DataConnector dataConnector)
            {
                // Initial Value
                PolymorphicObject returnObject = new PolymorphicObject();

                // If the data connection is connected
                if ((dataConnector != null) && (dataConnector.Connected == true))
                {
                    // Create Delete StoredProcedure
                    DeleteVSProjectStoredProcedure deleteVSProjectProc = null;

                    // verify the first parameters is a(n) 'VSProject'.
                    if (parameters[0].ObjectValue as VSProject != null)
                    {
                        // Create VSProject
                        VSProject vSProject = (VSProject) parameters[0].ObjectValue;

                        // verify vSProject exists
                        if(vSProject != null)
                        {
                            // Now create deleteVSProjectProc from VSProjectWriter
                            // The DataWriter converts the 'VSProject'
                            // to the SqlParameter[] array needed to delete a 'VSProject'.
                            deleteVSProjectProc = VSProjectWriter.CreateDeleteVSProjectStoredProcedure(vSProject);
                        }
                    }

                    // Verify deleteVSProjectProc exists
                    if(deleteVSProjectProc != null)
                    {
                        // Execute Delete Stored Procedure
                        bool deleted = this.DataManager.VSProjectManager.DeleteVSProject(deleteVSProjectProc, dataConnector);

                        // Create returnObject.Boolean
                        returnObject.Boolean = new NullableBoolean();

                        // If delete was successful
                        if(deleted)
                        {
                            // Set returnObject.Boolean.Value to true
                            returnObject.Boolean.Value = NullableBooleanEnum.True;
                        }
                        else
                        {
                            // Set returnObject.Boolean.Value to false
                            returnObject.Boolean.Value = NullableBooleanEnum.False;
                        }
                    }
                }
                else
                {
                    // Raise Error Data Connection Not Available
                    throw new Exception("The database connection is not available.");
                }

                // return value
                return returnObject;
            }
            #endregion

            #region FetchAll()
            /// <summary>
            /// This method fetches all 'VSProject' objects.
            /// </summary>
            /// <param name='List<PolymorphicObject>'>The 'VSProject' to delete.
            /// <returns>A PolymorphicObject object with all  'VSProjects' objects.
            internal PolymorphicObject FetchAll(List<PolymorphicObject> parameters, DataConnector dataConnector)
            {
                // Initial Value
                PolymorphicObject returnObject = new PolymorphicObject();

                // locals
                List<VSProject> vSProjectListCollection =  null;

                // Create FetchAll StoredProcedure
                FetchAllVSProjectsStoredProcedure fetchAllProc = null;

                // If the data connection is connected
                if ((dataConnector != null) && (dataConnector.Connected == true))
                {
                    // Get VSProjectParameter
                    // Declare Parameter
                    VSProject paramVSProject = null;

                    // verify the first parameters is a(n) 'VSProject'.
                    if (parameters[0].ObjectValue as VSProject != null)
                    {
                        // Get VSProjectParameter
                        paramVSProject = (VSProject) parameters[0].ObjectValue;
                    }

                    // Now create FetchAllVSProjectsProc from VSProjectWriter
                    fetchAllProc = VSProjectWriter.CreateFetchAllVSProjectsStoredProcedure(paramVSProject);
                }

                // Verify fetchAllProc exists
                if(fetchAllProc!= null)
                {
                    // Execute FetchAll Stored Procedure
                    vSProjectListCollection = this.DataManager.VSProjectManager.FetchAllVSProjects(fetchAllProc, dataConnector);

                    // if dataObjectCollection exists
                    if(vSProjectListCollection != null)
                    {
                        // set returnObject.ObjectValue
                        returnObject.ObjectValue = vSProjectListCollection;
                    }
                }
                else
                {
                    // Raise Error Data Connection Not Available
                    throw new Exception("The database connection is not available.");
                }

                // return value
                return returnObject;
            }
            #endregion

            #region FindVSProject(VSProject)
            /// <summary>
            /// This method finds a 'VSProject' object.
            /// </summary>
            /// <param name='List<PolymorphicObject>'>The 'VSProject' to delete.
            /// <returns>A PolymorphicObject object with a Boolean value.
            internal PolymorphicObject FindVSProject(List<PolymorphicObject> parameters, DataConnector dataConnector)
            {
                // Initial Value
                PolymorphicObject returnObject = new PolymorphicObject();

                // locals
                VSProject vSProject = null;

                // If the data connection is connected
                if ((dataConnector != null) && (dataConnector.Connected == true))
                {
                    // Create Find StoredProcedure
                    FindVSProjectStoredProcedure findVSProjectProc = null;

                    // verify the first parameters is a 'VSProject'.
                    if (parameters[0].ObjectValue as VSProject != null)
                    {
                        // Get VSProjectParameter
                        VSProject paramVSProject = (VSProject) parameters[0].ObjectValue;

                        // verify paramVSProject exists
                        if(paramVSProject != null)
                        {
                            // Now create findVSProjectProc from VSProjectWriter
                            // The DataWriter converts the 'VSProject'
                            // to the SqlParameter[] array needed to find a 'VSProject'.
                            findVSProjectProc = VSProjectWriter.CreateFindVSProjectStoredProcedure(paramVSProject);
                        }

                        // Verify findVSProjectProc exists
                        if(findVSProjectProc != null)
                        {
                            // Execute Find Stored Procedure
                            vSProject = this.DataManager.VSProjectManager.FindVSProject(findVSProjectProc, dataConnector);

                            // if dataObject exists
                            if(vSProject != null)
                            {
                                // set returnObject.ObjectValue
                                returnObject.ObjectValue = vSProject;
                            }
                        }
                    }
                    else
                    {
                        // Raise Error Data Connection Not Available
                        throw new Exception("The database connection is not available.");
                    }
                }

                // return value
                return returnObject;
            }
            #endregion

            #region InsertVSProject (VSProject)
            /// <summary>
            /// This method inserts a 'VSProject' object.
            /// </summary>
            /// <param name='List<PolymorphicObject>'>The 'VSProject' to insert.
            /// <returns>A PolymorphicObject object with a Boolean value.
            internal PolymorphicObject InsertVSProject(List<PolymorphicObject> parameters, DataConnector dataConnector)
            {
                // Initial Value
                PolymorphicObject returnObject = new PolymorphicObject();

                // locals
                VSProject vSProject = null;

                // If the data connection is connected
                if ((dataConnector != null) && (dataConnector.Connected == true))
                {
                    // Create Insert StoredProcedure
                    InsertVSProjectStoredProcedure insertVSProjectProc = null;

                    // verify the first parameters is a(n) 'VSProject'.
                    if (parameters[0].ObjectValue as VSProject != null)
                    {
                        // Create VSProject Parameter
                        vSProject = (VSProject) parameters[0].ObjectValue;

                        // verify vSProject exists
                        if(vSProject != null)
                        {
                            // Now create insertVSProjectProc from VSProjectWriter
                            // The DataWriter converts the 'VSProject'
                            // to the SqlParameter[] array needed to insert a 'VSProject'.
                            insertVSProjectProc = VSProjectWriter.CreateInsertVSProjectStoredProcedure(vSProject);
                        }

                        // Verify insertVSProjectProc exists
                        if(insertVSProjectProc != null)
                        {
                            // Execute Insert Stored Procedure
                            returnObject.IntegerValue = this.DataManager.VSProjectManager.InsertVSProject(insertVSProjectProc, dataConnector);
                        }

                    }
                    else
                    {
                        // Raise Error Data Connection Not Available
                        throw new Exception("The database connection is not available.");
                    }
                }

                // return value
                return returnObject;
            }
            #endregion

            #region UpdateVSProject (VSProject)
            /// <summary>
            /// This method updates a 'VSProject' object.
            /// </summary>
            /// <param name='List<PolymorphicObject>'>The 'VSProject' to update.
            /// <returns>A PolymorphicObject object with a value.
            internal PolymorphicObject UpdateVSProject(List<PolymorphicObject> parameters, DataConnector dataConnector)
            {
                // Initial Value
                PolymorphicObject returnObject = new PolymorphicObject();

                // locals
                VSProject vSProject = null;

                // If the data connection is connected
                if ((dataConnector != null) && (dataConnector.Connected == true))
                {
                    // Create Update StoredProcedure
                    UpdateVSProjectStoredProcedure updateVSProjectProc = null;

                    // verify the first parameters is a(n) 'VSProject'.
                    if (parameters[0].ObjectValue as VSProject != null)
                    {
                        // Create VSProject Parameter
                        vSProject = (VSProject) parameters[0].ObjectValue;

                        // verify vSProject exists
                        if(vSProject != null)
                        {
                            // Now create updateVSProjectProc from VSProjectWriter
                            // The DataWriter converts the 'VSProject'
                            // to the SqlParameter[] array needed to update a 'VSProject'.
                            updateVSProjectProc = VSProjectWriter.CreateUpdateVSProjectStoredProcedure(vSProject);
                        }

                        // Verify updateVSProjectProc exists
                        if(updateVSProjectProc != null)
                        {
                            // Execute Update Stored Procedure
                            bool saved = this.DataManager.VSProjectManager.UpdateVSProject(updateVSProjectProc, dataConnector);

                            // Create returnObject.Boolean
                            returnObject.Boolean = new NullableBoolean();

                            // If save was successful
                            if(saved)
                            {
                                // Set returnObject.Boolean.Value to true
                                returnObject.Boolean.Value = NullableBooleanEnum.True;
                            }
                            else
                            {
                                // Set returnObject.Boolean.Value to false
                                returnObject.Boolean.Value = NullableBooleanEnum.False;
                            }
                        }
                        else
                        {
                            // Raise Error Data Connection Not Available
                            throw new Exception("The database connection is not available.");
                        }
                    }
                }

                // return value
                return returnObject;
            }
            #endregion

        #endregion

        #region Properties

            #region DataManager 
            public DataManager DataManager 
            {
                get { return dataManager; }
                set { dataManager = value; }
            }
            #endregion

        #endregion

    }
    #endregion

}
