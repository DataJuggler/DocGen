

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

    #region class CodeClassMethods
    /// <summary>
    /// This class contains methods for modifying a 'CodeClass' object.
    /// </summary>
    public class CodeClassMethods
    {

        #region Private Variables
        private DataManager dataManager;
        #endregion

        #region Constructor
        /// <summary>
        /// Creates a new Creates a new 'CodeClassMethods' object.
        /// </summary>
        public CodeClassMethods(DataManager dataManagerArg)
        {
            // Save Argument
            this.DataManager = dataManagerArg;
        }
        #endregion

        #region Methods

            #region DeleteCodeClass(CodeClass)
            /// <summary>
            /// This method deletes a 'CodeClass' object.
            /// </summary>
            /// <param name='List<PolymorphicObject>'>The 'CodeClass' to delete.
            /// <returns>A PolymorphicObject object with a Boolean value.
            internal PolymorphicObject DeleteCodeClass(List<PolymorphicObject> parameters, DataConnector dataConnector)
            {
                // Initial Value
                PolymorphicObject returnObject = new PolymorphicObject();

                // If the data connection is connected
                if ((dataConnector != null) && (dataConnector.Connected == true))
                {
                    // Create Delete StoredProcedure
                    DeleteCodeClassStoredProcedure deleteCodeClassProc = null;

                    // verify the first parameters is a(n) 'CodeClass'.
                    if (parameters[0].ObjectValue as CodeClass != null)
                    {
                        // Create CodeClass
                        CodeClass codeClass = (CodeClass) parameters[0].ObjectValue;

                        // verify codeClass exists
                        if(codeClass != null)
                        {
                            // Now create deleteCodeClassProc from CodeClassWriter
                            // The DataWriter converts the 'CodeClass'
                            // to the SqlParameter[] array needed to delete a 'CodeClass'.
                            deleteCodeClassProc = CodeClassWriter.CreateDeleteCodeClassStoredProcedure(codeClass);
                        }
                    }

                    // Verify deleteCodeClassProc exists
                    if(deleteCodeClassProc != null)
                    {
                        // Execute Delete Stored Procedure
                        bool deleted = this.DataManager.CodeClassManager.DeleteCodeClass(deleteCodeClassProc, dataConnector);

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
            /// This method fetches all 'CodeClass' objects.
            /// </summary>
            /// <param name='List<PolymorphicObject>'>The 'CodeClass' to delete.
            /// <returns>A PolymorphicObject object with all  'CodeClass' objects.
            internal PolymorphicObject FetchAll(List<PolymorphicObject> parameters, DataConnector dataConnector)
            {
                // Initial Value
                PolymorphicObject returnObject = new PolymorphicObject();

                // locals
                List<CodeClass> codeClassListCollection =  null;

                // Create FetchAll StoredProcedure
                FetchAllCodeClassStoredProcedure fetchAllProc = null;

                // If the data connection is connected
                if ((dataConnector != null) && (dataConnector.Connected == true))
                {
                    // Get CodeClassParameter
                    // Declare Parameter
                    CodeClass paramCodeClass = null;

                    // verify the first parameters is a(n) 'CodeClass'.
                    if (parameters[0].ObjectValue as CodeClass != null)
                    {
                        // Get CodeClassParameter
                        paramCodeClass = (CodeClass) parameters[0].ObjectValue;
                    }

                    // Now create FetchAllCodeClassProc from CodeClassWriter
                    fetchAllProc = CodeClassWriter.CreateFetchAllCodeClassStoredProcedure(paramCodeClass);
                }

                // Verify fetchAllProc exists
                if(fetchAllProc!= null)
                {
                    // Execute FetchAll Stored Procedure
                    codeClassListCollection = this.DataManager.CodeClassManager.FetchAllCodeClass(fetchAllProc, dataConnector);

                    // if dataObjectCollection exists
                    if(codeClassListCollection != null)
                    {
                        // set returnObject.ObjectValue
                        returnObject.ObjectValue = codeClassListCollection;
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

            #region FindCodeClass(CodeClass)
            /// <summary>
            /// This method finds a 'CodeClass' object.
            /// </summary>
            /// <param name='List<PolymorphicObject>'>The 'CodeClass' to delete.
            /// <returns>A PolymorphicObject object with a Boolean value.
            internal PolymorphicObject FindCodeClass(List<PolymorphicObject> parameters, DataConnector dataConnector)
            {
                // Initial Value
                PolymorphicObject returnObject = new PolymorphicObject();

                // locals
                CodeClass codeClass = null;

                // If the data connection is connected
                if ((dataConnector != null) && (dataConnector.Connected == true))
                {
                    // Create Find StoredProcedure
                    FindCodeClassStoredProcedure findCodeClassProc = null;

                    // verify the first parameters is a 'CodeClass'.
                    if (parameters[0].ObjectValue as CodeClass != null)
                    {
                        // Get CodeClassParameter
                        CodeClass paramCodeClass = (CodeClass) parameters[0].ObjectValue;

                        // verify paramCodeClass exists
                        if(paramCodeClass != null)
                        {
                            // Now create findCodeClassProc from CodeClassWriter
                            // The DataWriter converts the 'CodeClass'
                            // to the SqlParameter[] array needed to find a 'CodeClass'.
                            findCodeClassProc = CodeClassWriter.CreateFindCodeClassStoredProcedure(paramCodeClass);
                        }

                        // Verify findCodeClassProc exists
                        if(findCodeClassProc != null)
                        {
                            // Execute Find Stored Procedure
                            codeClass = this.DataManager.CodeClassManager.FindCodeClass(findCodeClassProc, dataConnector);

                            // if dataObject exists
                            if(codeClass != null)
                            {
                                // set returnObject.ObjectValue
                                returnObject.ObjectValue = codeClass;
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

            #region InsertCodeClass (CodeClass)
            /// <summary>
            /// This method inserts a 'CodeClass' object.
            /// </summary>
            /// <param name='List<PolymorphicObject>'>The 'CodeClass' to insert.
            /// <returns>A PolymorphicObject object with a Boolean value.
            internal PolymorphicObject InsertCodeClass(List<PolymorphicObject> parameters, DataConnector dataConnector)
            {
                // Initial Value
                PolymorphicObject returnObject = new PolymorphicObject();

                // locals
                CodeClass codeClass = null;

                // If the data connection is connected
                if ((dataConnector != null) && (dataConnector.Connected == true))
                {
                    // Create Insert StoredProcedure
                    InsertCodeClassStoredProcedure insertCodeClassProc = null;

                    // verify the first parameters is a(n) 'CodeClass'.
                    if (parameters[0].ObjectValue as CodeClass != null)
                    {
                        // Create CodeClass Parameter
                        codeClass = (CodeClass) parameters[0].ObjectValue;

                        // verify codeClass exists
                        if(codeClass != null)
                        {
                            // Now create insertCodeClassProc from CodeClassWriter
                            // The DataWriter converts the 'CodeClass'
                            // to the SqlParameter[] array needed to insert a 'CodeClass'.
                            insertCodeClassProc = CodeClassWriter.CreateInsertCodeClassStoredProcedure(codeClass);
                        }

                        // Verify insertCodeClassProc exists
                        if(insertCodeClassProc != null)
                        {
                            // Execute Insert Stored Procedure
                            returnObject.IntegerValue = this.DataManager.CodeClassManager.InsertCodeClass(insertCodeClassProc, dataConnector);
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

            #region UpdateCodeClass (CodeClass)
            /// <summary>
            /// This method updates a 'CodeClass' object.
            /// </summary>
            /// <param name='List<PolymorphicObject>'>The 'CodeClass' to update.
            /// <returns>A PolymorphicObject object with a value.
            internal PolymorphicObject UpdateCodeClass(List<PolymorphicObject> parameters, DataConnector dataConnector)
            {
                // Initial Value
                PolymorphicObject returnObject = new PolymorphicObject();

                // locals
                CodeClass codeClass = null;

                // If the data connection is connected
                if ((dataConnector != null) && (dataConnector.Connected == true))
                {
                    // Create Update StoredProcedure
                    UpdateCodeClassStoredProcedure updateCodeClassProc = null;

                    // verify the first parameters is a(n) 'CodeClass'.
                    if (parameters[0].ObjectValue as CodeClass != null)
                    {
                        // Create CodeClass Parameter
                        codeClass = (CodeClass) parameters[0].ObjectValue;

                        // verify codeClass exists
                        if(codeClass != null)
                        {
                            // Now create updateCodeClassProc from CodeClassWriter
                            // The DataWriter converts the 'CodeClass'
                            // to the SqlParameter[] array needed to update a 'CodeClass'.
                            updateCodeClassProc = CodeClassWriter.CreateUpdateCodeClassStoredProcedure(codeClass);
                        }

                        // Verify updateCodeClassProc exists
                        if(updateCodeClassProc != null)
                        {
                            // Execute Update Stored Procedure
                            bool saved = this.DataManager.CodeClassManager.UpdateCodeClass(updateCodeClassProc, dataConnector);

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
