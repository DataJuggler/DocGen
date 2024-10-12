

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

    #region class CodeMethodMethods
    /// <summary>
    /// This class contains methods for modifying a 'CodeMethod' object.
    /// </summary>
    public class CodeMethodMethods
    {

        #region Private Variables
        private DataManager dataManager;
        #endregion

        #region Constructor
        /// <summary>
        /// Creates a new Creates a new 'CodeMethodMethods' object.
        /// </summary>
        public CodeMethodMethods(DataManager dataManagerArg)
        {
            // Save Argument
            this.DataManager = dataManagerArg;
        }
        #endregion

        #region Methods

            #region DeleteCodeMethod(CodeMethod)
            /// <summary>
            /// This method deletes a 'CodeMethod' object.
            /// </summary>
            /// <param name='List<PolymorphicObject>'>The 'CodeMethod' to delete.
            /// <returns>A PolymorphicObject object with a Boolean value.
            internal PolymorphicObject DeleteCodeMethod(List<PolymorphicObject> parameters, DataConnector dataConnector)
            {
                // Initial Value
                PolymorphicObject returnObject = new PolymorphicObject();

                // If the data connection is connected
                if ((dataConnector != null) && (dataConnector.Connected == true))
                {
                    // Create Delete StoredProcedure
                    DeleteCodeMethodStoredProcedure deleteCodeMethodProc = null;

                    // verify the first parameters is a(n) 'CodeMethod'.
                    if (parameters[0].ObjectValue as CodeMethod != null)
                    {
                        // Create CodeMethod
                        CodeMethod codeMethod = (CodeMethod) parameters[0].ObjectValue;

                        // verify codeMethod exists
                        if(codeMethod != null)
                        {
                            // Now create deleteCodeMethodProc from CodeMethodWriter
                            // The DataWriter converts the 'CodeMethod'
                            // to the SqlParameter[] array needed to delete a 'CodeMethod'.
                            deleteCodeMethodProc = CodeMethodWriter.CreateDeleteCodeMethodStoredProcedure(codeMethod);
                        }
                    }

                    // Verify deleteCodeMethodProc exists
                    if(deleteCodeMethodProc != null)
                    {
                        // Execute Delete Stored Procedure
                        bool deleted = this.DataManager.CodeMethodManager.DeleteCodeMethod(deleteCodeMethodProc, dataConnector);

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
            /// This method fetches all 'CodeMethod' objects.
            /// </summary>
            /// <param name='List<PolymorphicObject>'>The 'CodeMethod' to delete.
            /// <returns>A PolymorphicObject object with all  'CodeMethods' objects.
            internal PolymorphicObject FetchAll(List<PolymorphicObject> parameters, DataConnector dataConnector)
            {
                // Initial Value
                PolymorphicObject returnObject = new PolymorphicObject();

                // locals
                List<CodeMethod> codeMethodListCollection =  null;

                // Create FetchAll StoredProcedure
                FetchAllCodeMethodsStoredProcedure fetchAllProc = null;

                // If the data connection is connected
                if ((dataConnector != null) && (dataConnector.Connected == true))
                {
                    // Get CodeMethodParameter
                    // Declare Parameter
                    CodeMethod paramCodeMethod = null;

                    // verify the first parameters is a(n) 'CodeMethod'.
                    if (parameters[0].ObjectValue as CodeMethod != null)
                    {
                        // Get CodeMethodParameter
                        paramCodeMethod = (CodeMethod) parameters[0].ObjectValue;
                    }

                    // Now create FetchAllCodeMethodsProc from CodeMethodWriter
                    fetchAllProc = CodeMethodWriter.CreateFetchAllCodeMethodsStoredProcedure(paramCodeMethod);
                }

                // Verify fetchAllProc exists
                if(fetchAllProc!= null)
                {
                    // Execute FetchAll Stored Procedure
                    codeMethodListCollection = this.DataManager.CodeMethodManager.FetchAllCodeMethods(fetchAllProc, dataConnector);

                    // if dataObjectCollection exists
                    if(codeMethodListCollection != null)
                    {
                        // set returnObject.ObjectValue
                        returnObject.ObjectValue = codeMethodListCollection;
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

            #region FindCodeMethod(CodeMethod)
            /// <summary>
            /// This method finds a 'CodeMethod' object.
            /// </summary>
            /// <param name='List<PolymorphicObject>'>The 'CodeMethod' to delete.
            /// <returns>A PolymorphicObject object with a Boolean value.
            internal PolymorphicObject FindCodeMethod(List<PolymorphicObject> parameters, DataConnector dataConnector)
            {
                // Initial Value
                PolymorphicObject returnObject = new PolymorphicObject();

                // locals
                CodeMethod codeMethod = null;

                // If the data connection is connected
                if ((dataConnector != null) && (dataConnector.Connected == true))
                {
                    // Create Find StoredProcedure
                    FindCodeMethodStoredProcedure findCodeMethodProc = null;

                    // verify the first parameters is a 'CodeMethod'.
                    if (parameters[0].ObjectValue as CodeMethod != null)
                    {
                        // Get CodeMethodParameter
                        CodeMethod paramCodeMethod = (CodeMethod) parameters[0].ObjectValue;

                        // verify paramCodeMethod exists
                        if(paramCodeMethod != null)
                        {
                            // Now create findCodeMethodProc from CodeMethodWriter
                            // The DataWriter converts the 'CodeMethod'
                            // to the SqlParameter[] array needed to find a 'CodeMethod'.
                            findCodeMethodProc = CodeMethodWriter.CreateFindCodeMethodStoredProcedure(paramCodeMethod);
                        }

                        // Verify findCodeMethodProc exists
                        if(findCodeMethodProc != null)
                        {
                            // Execute Find Stored Procedure
                            codeMethod = this.DataManager.CodeMethodManager.FindCodeMethod(findCodeMethodProc, dataConnector);

                            // if dataObject exists
                            if(codeMethod != null)
                            {
                                // set returnObject.ObjectValue
                                returnObject.ObjectValue = codeMethod;
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

            #region InsertCodeMethod (CodeMethod)
            /// <summary>
            /// This method inserts a 'CodeMethod' object.
            /// </summary>
            /// <param name='List<PolymorphicObject>'>The 'CodeMethod' to insert.
            /// <returns>A PolymorphicObject object with a Boolean value.
            internal PolymorphicObject InsertCodeMethod(List<PolymorphicObject> parameters, DataConnector dataConnector)
            {
                // Initial Value
                PolymorphicObject returnObject = new PolymorphicObject();

                // locals
                CodeMethod codeMethod = null;

                // If the data connection is connected
                if ((dataConnector != null) && (dataConnector.Connected == true))
                {
                    // Create Insert StoredProcedure
                    InsertCodeMethodStoredProcedure insertCodeMethodProc = null;

                    // verify the first parameters is a(n) 'CodeMethod'.
                    if (parameters[0].ObjectValue as CodeMethod != null)
                    {
                        // Create CodeMethod Parameter
                        codeMethod = (CodeMethod) parameters[0].ObjectValue;

                        // verify codeMethod exists
                        if(codeMethod != null)
                        {
                            // Now create insertCodeMethodProc from CodeMethodWriter
                            // The DataWriter converts the 'CodeMethod'
                            // to the SqlParameter[] array needed to insert a 'CodeMethod'.
                            insertCodeMethodProc = CodeMethodWriter.CreateInsertCodeMethodStoredProcedure(codeMethod);
                        }

                        // Verify insertCodeMethodProc exists
                        if(insertCodeMethodProc != null)
                        {
                            // Execute Insert Stored Procedure
                            returnObject.IntegerValue = this.DataManager.CodeMethodManager.InsertCodeMethod(insertCodeMethodProc, dataConnector);
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

            #region UpdateCodeMethod (CodeMethod)
            /// <summary>
            /// This method updates a 'CodeMethod' object.
            /// </summary>
            /// <param name='List<PolymorphicObject>'>The 'CodeMethod' to update.
            /// <returns>A PolymorphicObject object with a value.
            internal PolymorphicObject UpdateCodeMethod(List<PolymorphicObject> parameters, DataConnector dataConnector)
            {
                // Initial Value
                PolymorphicObject returnObject = new PolymorphicObject();

                // locals
                CodeMethod codeMethod = null;

                // If the data connection is connected
                if ((dataConnector != null) && (dataConnector.Connected == true))
                {
                    // Create Update StoredProcedure
                    UpdateCodeMethodStoredProcedure updateCodeMethodProc = null;

                    // verify the first parameters is a(n) 'CodeMethod'.
                    if (parameters[0].ObjectValue as CodeMethod != null)
                    {
                        // Create CodeMethod Parameter
                        codeMethod = (CodeMethod) parameters[0].ObjectValue;

                        // verify codeMethod exists
                        if(codeMethod != null)
                        {
                            // Now create updateCodeMethodProc from CodeMethodWriter
                            // The DataWriter converts the 'CodeMethod'
                            // to the SqlParameter[] array needed to update a 'CodeMethod'.
                            updateCodeMethodProc = CodeMethodWriter.CreateUpdateCodeMethodStoredProcedure(codeMethod);
                        }

                        // Verify updateCodeMethodProc exists
                        if(updateCodeMethodProc != null)
                        {
                            // Execute Update Stored Procedure
                            bool saved = this.DataManager.CodeMethodManager.UpdateCodeMethod(updateCodeMethodProc, dataConnector);

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
