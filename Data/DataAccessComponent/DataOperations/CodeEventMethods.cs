

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

    #region class CodeEventMethods
    /// <summary>
    /// This class contains methods for modifying a 'CodeEvent' object.
    /// </summary>
    public class CodeEventMethods
    {

        #region Private Variables
        private DataManager dataManager;
        #endregion

        #region Constructor
        /// <summary>
        /// Creates a new Creates a new 'CodeEventMethods' object.
        /// </summary>
        public CodeEventMethods(DataManager dataManagerArg)
        {
            // Save Argument
            this.DataManager = dataManagerArg;
        }
        #endregion

        #region Methods

            #region DeleteCodeEvent(CodeEvent)
            /// <summary>
            /// This method deletes a 'CodeEvent' object.
            /// </summary>
            /// <param name='List<PolymorphicObject>'>The 'CodeEvent' to delete.
            /// <returns>A PolymorphicObject object with a Boolean value.
            internal PolymorphicObject DeleteCodeEvent(List<PolymorphicObject> parameters, DataConnector dataConnector)
            {
                // Initial Value
                PolymorphicObject returnObject = new PolymorphicObject();

                // If the data connection is connected
                if ((dataConnector != null) && (dataConnector.Connected == true))
                {
                    // Create Delete StoredProcedure
                    DeleteCodeEventStoredProcedure deleteCodeEventProc = null;

                    // verify the first parameters is a(n) 'CodeEvent'.
                    if (parameters[0].ObjectValue as CodeEvent != null)
                    {
                        // Create CodeEvent
                        CodeEvent codeEvent = (CodeEvent) parameters[0].ObjectValue;

                        // verify codeEvent exists
                        if(codeEvent != null)
                        {
                            // Now create deleteCodeEventProc from CodeEventWriter
                            // The DataWriter converts the 'CodeEvent'
                            // to the SqlParameter[] array needed to delete a 'CodeEvent'.
                            deleteCodeEventProc = CodeEventWriter.CreateDeleteCodeEventStoredProcedure(codeEvent);
                        }
                    }

                    // Verify deleteCodeEventProc exists
                    if(deleteCodeEventProc != null)
                    {
                        // Execute Delete Stored Procedure
                        bool deleted = this.DataManager.CodeEventManager.DeleteCodeEvent(deleteCodeEventProc, dataConnector);

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
            /// This method fetches all 'CodeEvent' objects.
            /// </summary>
            /// <param name='List<PolymorphicObject>'>The 'CodeEvent' to delete.
            /// <returns>A PolymorphicObject object with all  'CodeEvents' objects.
            internal PolymorphicObject FetchAll(List<PolymorphicObject> parameters, DataConnector dataConnector)
            {
                // Initial Value
                PolymorphicObject returnObject = new PolymorphicObject();

                // locals
                List<CodeEvent> codeEventListCollection =  null;

                // Create FetchAll StoredProcedure
                FetchAllCodeEventsStoredProcedure fetchAllProc = null;

                // If the data connection is connected
                if ((dataConnector != null) && (dataConnector.Connected == true))
                {
                    // Get CodeEventParameter
                    // Declare Parameter
                    CodeEvent paramCodeEvent = null;

                    // verify the first parameters is a(n) 'CodeEvent'.
                    if (parameters[0].ObjectValue as CodeEvent != null)
                    {
                        // Get CodeEventParameter
                        paramCodeEvent = (CodeEvent) parameters[0].ObjectValue;
                    }

                    // Now create FetchAllCodeEventsProc from CodeEventWriter
                    fetchAllProc = CodeEventWriter.CreateFetchAllCodeEventsStoredProcedure(paramCodeEvent);
                }

                // Verify fetchAllProc exists
                if(fetchAllProc!= null)
                {
                    // Execute FetchAll Stored Procedure
                    codeEventListCollection = this.DataManager.CodeEventManager.FetchAllCodeEvents(fetchAllProc, dataConnector);

                    // if dataObjectCollection exists
                    if(codeEventListCollection != null)
                    {
                        // set returnObject.ObjectValue
                        returnObject.ObjectValue = codeEventListCollection;
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

            #region FindCodeEvent(CodeEvent)
            /// <summary>
            /// This method finds a 'CodeEvent' object.
            /// </summary>
            /// <param name='List<PolymorphicObject>'>The 'CodeEvent' to delete.
            /// <returns>A PolymorphicObject object with a Boolean value.
            internal PolymorphicObject FindCodeEvent(List<PolymorphicObject> parameters, DataConnector dataConnector)
            {
                // Initial Value
                PolymorphicObject returnObject = new PolymorphicObject();

                // locals
                CodeEvent codeEvent = null;

                // If the data connection is connected
                if ((dataConnector != null) && (dataConnector.Connected == true))
                {
                    // Create Find StoredProcedure
                    FindCodeEventStoredProcedure findCodeEventProc = null;

                    // verify the first parameters is a 'CodeEvent'.
                    if (parameters[0].ObjectValue as CodeEvent != null)
                    {
                        // Get CodeEventParameter
                        CodeEvent paramCodeEvent = (CodeEvent) parameters[0].ObjectValue;

                        // verify paramCodeEvent exists
                        if(paramCodeEvent != null)
                        {
                            // Now create findCodeEventProc from CodeEventWriter
                            // The DataWriter converts the 'CodeEvent'
                            // to the SqlParameter[] array needed to find a 'CodeEvent'.
                            findCodeEventProc = CodeEventWriter.CreateFindCodeEventStoredProcedure(paramCodeEvent);
                        }

                        // Verify findCodeEventProc exists
                        if(findCodeEventProc != null)
                        {
                            // Execute Find Stored Procedure
                            codeEvent = this.DataManager.CodeEventManager.FindCodeEvent(findCodeEventProc, dataConnector);

                            // if dataObject exists
                            if(codeEvent != null)
                            {
                                // set returnObject.ObjectValue
                                returnObject.ObjectValue = codeEvent;
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

            #region InsertCodeEvent (CodeEvent)
            /// <summary>
            /// This method inserts a 'CodeEvent' object.
            /// </summary>
            /// <param name='List<PolymorphicObject>'>The 'CodeEvent' to insert.
            /// <returns>A PolymorphicObject object with a Boolean value.
            internal PolymorphicObject InsertCodeEvent(List<PolymorphicObject> parameters, DataConnector dataConnector)
            {
                // Initial Value
                PolymorphicObject returnObject = new PolymorphicObject();

                // locals
                CodeEvent codeEvent = null;

                // If the data connection is connected
                if ((dataConnector != null) && (dataConnector.Connected == true))
                {
                    // Create Insert StoredProcedure
                    InsertCodeEventStoredProcedure insertCodeEventProc = null;

                    // verify the first parameters is a(n) 'CodeEvent'.
                    if (parameters[0].ObjectValue as CodeEvent != null)
                    {
                        // Create CodeEvent Parameter
                        codeEvent = (CodeEvent) parameters[0].ObjectValue;

                        // verify codeEvent exists
                        if(codeEvent != null)
                        {
                            // Now create insertCodeEventProc from CodeEventWriter
                            // The DataWriter converts the 'CodeEvent'
                            // to the SqlParameter[] array needed to insert a 'CodeEvent'.
                            insertCodeEventProc = CodeEventWriter.CreateInsertCodeEventStoredProcedure(codeEvent);
                        }

                        // Verify insertCodeEventProc exists
                        if(insertCodeEventProc != null)
                        {
                            // Execute Insert Stored Procedure
                            returnObject.IntegerValue = this.DataManager.CodeEventManager.InsertCodeEvent(insertCodeEventProc, dataConnector);
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

            #region UpdateCodeEvent (CodeEvent)
            /// <summary>
            /// This method updates a 'CodeEvent' object.
            /// </summary>
            /// <param name='List<PolymorphicObject>'>The 'CodeEvent' to update.
            /// <returns>A PolymorphicObject object with a value.
            internal PolymorphicObject UpdateCodeEvent(List<PolymorphicObject> parameters, DataConnector dataConnector)
            {
                // Initial Value
                PolymorphicObject returnObject = new PolymorphicObject();

                // locals
                CodeEvent codeEvent = null;

                // If the data connection is connected
                if ((dataConnector != null) && (dataConnector.Connected == true))
                {
                    // Create Update StoredProcedure
                    UpdateCodeEventStoredProcedure updateCodeEventProc = null;

                    // verify the first parameters is a(n) 'CodeEvent'.
                    if (parameters[0].ObjectValue as CodeEvent != null)
                    {
                        // Create CodeEvent Parameter
                        codeEvent = (CodeEvent) parameters[0].ObjectValue;

                        // verify codeEvent exists
                        if(codeEvent != null)
                        {
                            // Now create updateCodeEventProc from CodeEventWriter
                            // The DataWriter converts the 'CodeEvent'
                            // to the SqlParameter[] array needed to update a 'CodeEvent'.
                            updateCodeEventProc = CodeEventWriter.CreateUpdateCodeEventStoredProcedure(codeEvent);
                        }

                        // Verify updateCodeEventProc exists
                        if(updateCodeEventProc != null)
                        {
                            // Execute Update Stored Procedure
                            bool saved = this.DataManager.CodeEventManager.UpdateCodeEvent(updateCodeEventProc, dataConnector);

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
