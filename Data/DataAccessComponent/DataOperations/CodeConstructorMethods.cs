

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

    #region class CodeConstructorMethods
    /// <summary>
    /// This class contains methods for modifying a 'CodeConstructor' object.
    /// </summary>
    public class CodeConstructorMethods
    {

        #region Private Variables
        private DataManager dataManager;
        #endregion

        #region Constructor
        /// <summary>
        /// Creates a new Creates a new 'CodeConstructorMethods' object.
        /// </summary>
        public CodeConstructorMethods(DataManager dataManagerArg)
        {
            // Save Argument
            this.DataManager = dataManagerArg;
        }
        #endregion

        #region Methods

            #region DeleteCodeConstructor(CodeConstructor)
            /// <summary>
            /// This method deletes a 'CodeConstructor' object.
            /// </summary>
            /// <param name='List<PolymorphicObject>'>The 'CodeConstructor' to delete.
            /// <returns>A PolymorphicObject object with a Boolean value.
            internal PolymorphicObject DeleteCodeConstructor(List<PolymorphicObject> parameters, DataConnector dataConnector)
            {
                // Initial Value
                PolymorphicObject returnObject = new PolymorphicObject();

                // If the data connection is connected
                if ((dataConnector != null) && (dataConnector.Connected == true))
                {
                    // Create Delete StoredProcedure
                    DeleteCodeConstructorStoredProcedure deleteCodeConstructorProc = null;

                    // verify the first parameters is a(n) 'CodeConstructor'.
                    if (parameters[0].ObjectValue as CodeConstructor != null)
                    {
                        // Create CodeConstructor
                        CodeConstructor codeConstructor = (CodeConstructor) parameters[0].ObjectValue;

                        // verify codeConstructor exists
                        if(codeConstructor != null)
                        {
                            // Now create deleteCodeConstructorProc from CodeConstructorWriter
                            // The DataWriter converts the 'CodeConstructor'
                            // to the SqlParameter[] array needed to delete a 'CodeConstructor'.
                            deleteCodeConstructorProc = CodeConstructorWriter.CreateDeleteCodeConstructorStoredProcedure(codeConstructor);
                        }
                    }

                    // Verify deleteCodeConstructorProc exists
                    if(deleteCodeConstructorProc != null)
                    {
                        // Execute Delete Stored Procedure
                        bool deleted = this.DataManager.CodeConstructorManager.DeleteCodeConstructor(deleteCodeConstructorProc, dataConnector);

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
            /// This method fetches all 'CodeConstructor' objects.
            /// </summary>
            /// <param name='List<PolymorphicObject>'>The 'CodeConstructor' to delete.
            /// <returns>A PolymorphicObject object with all  'CodeConstructors' objects.
            internal PolymorphicObject FetchAll(List<PolymorphicObject> parameters, DataConnector dataConnector)
            {
                // Initial Value
                PolymorphicObject returnObject = new PolymorphicObject();

                // locals
                List<CodeConstructor> codeConstructorListCollection =  null;

                // Create FetchAll StoredProcedure
                FetchAllCodeConstructorsStoredProcedure fetchAllProc = null;

                // If the data connection is connected
                if ((dataConnector != null) && (dataConnector.Connected == true))
                {
                    // Get CodeConstructorParameter
                    // Declare Parameter
                    CodeConstructor paramCodeConstructor = null;

                    // verify the first parameters is a(n) 'CodeConstructor'.
                    if (parameters[0].ObjectValue as CodeConstructor != null)
                    {
                        // Get CodeConstructorParameter
                        paramCodeConstructor = (CodeConstructor) parameters[0].ObjectValue;
                    }

                    // Now create FetchAllCodeConstructorsProc from CodeConstructorWriter
                    fetchAllProc = CodeConstructorWriter.CreateFetchAllCodeConstructorsStoredProcedure(paramCodeConstructor);
                }

                // Verify fetchAllProc exists
                if(fetchAllProc!= null)
                {
                    // Execute FetchAll Stored Procedure
                    codeConstructorListCollection = this.DataManager.CodeConstructorManager.FetchAllCodeConstructors(fetchAllProc, dataConnector);

                    // if dataObjectCollection exists
                    if(codeConstructorListCollection != null)
                    {
                        // set returnObject.ObjectValue
                        returnObject.ObjectValue = codeConstructorListCollection;
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

            #region FindCodeConstructor(CodeConstructor)
            /// <summary>
            /// This method finds a 'CodeConstructor' object.
            /// </summary>
            /// <param name='List<PolymorphicObject>'>The 'CodeConstructor' to delete.
            /// <returns>A PolymorphicObject object with a Boolean value.
            internal PolymorphicObject FindCodeConstructor(List<PolymorphicObject> parameters, DataConnector dataConnector)
            {
                // Initial Value
                PolymorphicObject returnObject = new PolymorphicObject();

                // locals
                CodeConstructor codeConstructor = null;

                // If the data connection is connected
                if ((dataConnector != null) && (dataConnector.Connected == true))
                {
                    // Create Find StoredProcedure
                    FindCodeConstructorStoredProcedure findCodeConstructorProc = null;

                    // verify the first parameters is a 'CodeConstructor'.
                    if (parameters[0].ObjectValue as CodeConstructor != null)
                    {
                        // Get CodeConstructorParameter
                        CodeConstructor paramCodeConstructor = (CodeConstructor) parameters[0].ObjectValue;

                        // verify paramCodeConstructor exists
                        if(paramCodeConstructor != null)
                        {
                            // Now create findCodeConstructorProc from CodeConstructorWriter
                            // The DataWriter converts the 'CodeConstructor'
                            // to the SqlParameter[] array needed to find a 'CodeConstructor'.
                            findCodeConstructorProc = CodeConstructorWriter.CreateFindCodeConstructorStoredProcedure(paramCodeConstructor);
                        }

                        // Verify findCodeConstructorProc exists
                        if(findCodeConstructorProc != null)
                        {
                            // Execute Find Stored Procedure
                            codeConstructor = this.DataManager.CodeConstructorManager.FindCodeConstructor(findCodeConstructorProc, dataConnector);

                            // if dataObject exists
                            if(codeConstructor != null)
                            {
                                // set returnObject.ObjectValue
                                returnObject.ObjectValue = codeConstructor;
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

            #region InsertCodeConstructor (CodeConstructor)
            /// <summary>
            /// This method inserts a 'CodeConstructor' object.
            /// </summary>
            /// <param name='List<PolymorphicObject>'>The 'CodeConstructor' to insert.
            /// <returns>A PolymorphicObject object with a Boolean value.
            internal PolymorphicObject InsertCodeConstructor(List<PolymorphicObject> parameters, DataConnector dataConnector)
            {
                // Initial Value
                PolymorphicObject returnObject = new PolymorphicObject();

                // locals
                CodeConstructor codeConstructor = null;

                // If the data connection is connected
                if ((dataConnector != null) && (dataConnector.Connected == true))
                {
                    // Create Insert StoredProcedure
                    InsertCodeConstructorStoredProcedure insertCodeConstructorProc = null;

                    // verify the first parameters is a(n) 'CodeConstructor'.
                    if (parameters[0].ObjectValue as CodeConstructor != null)
                    {
                        // Create CodeConstructor Parameter
                        codeConstructor = (CodeConstructor) parameters[0].ObjectValue;

                        // verify codeConstructor exists
                        if(codeConstructor != null)
                        {
                            // Now create insertCodeConstructorProc from CodeConstructorWriter
                            // The DataWriter converts the 'CodeConstructor'
                            // to the SqlParameter[] array needed to insert a 'CodeConstructor'.
                            insertCodeConstructorProc = CodeConstructorWriter.CreateInsertCodeConstructorStoredProcedure(codeConstructor);
                        }

                        // Verify insertCodeConstructorProc exists
                        if(insertCodeConstructorProc != null)
                        {
                            // Execute Insert Stored Procedure
                            returnObject.IntegerValue = this.DataManager.CodeConstructorManager.InsertCodeConstructor(insertCodeConstructorProc, dataConnector);
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

            #region UpdateCodeConstructor (CodeConstructor)
            /// <summary>
            /// This method updates a 'CodeConstructor' object.
            /// </summary>
            /// <param name='List<PolymorphicObject>'>The 'CodeConstructor' to update.
            /// <returns>A PolymorphicObject object with a value.
            internal PolymorphicObject UpdateCodeConstructor(List<PolymorphicObject> parameters, DataConnector dataConnector)
            {
                // Initial Value
                PolymorphicObject returnObject = new PolymorphicObject();

                // locals
                CodeConstructor codeConstructor = null;

                // If the data connection is connected
                if ((dataConnector != null) && (dataConnector.Connected == true))
                {
                    // Create Update StoredProcedure
                    UpdateCodeConstructorStoredProcedure updateCodeConstructorProc = null;

                    // verify the first parameters is a(n) 'CodeConstructor'.
                    if (parameters[0].ObjectValue as CodeConstructor != null)
                    {
                        // Create CodeConstructor Parameter
                        codeConstructor = (CodeConstructor) parameters[0].ObjectValue;

                        // verify codeConstructor exists
                        if(codeConstructor != null)
                        {
                            // Now create updateCodeConstructorProc from CodeConstructorWriter
                            // The DataWriter converts the 'CodeConstructor'
                            // to the SqlParameter[] array needed to update a 'CodeConstructor'.
                            updateCodeConstructorProc = CodeConstructorWriter.CreateUpdateCodeConstructorStoredProcedure(codeConstructor);
                        }

                        // Verify updateCodeConstructorProc exists
                        if(updateCodeConstructorProc != null)
                        {
                            // Execute Update Stored Procedure
                            bool saved = this.DataManager.CodeConstructorManager.UpdateCodeConstructor(updateCodeConstructorProc, dataConnector);

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
