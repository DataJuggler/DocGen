

#region using statements

using DataJuggler.DocGen.DataAccessComponent.Data;
using DataJuggler.DocGen.DataAccessComponent.Data.Writers;
using DataJuggler.DocGen.DataAccessComponent.DataBridge;
using DataJuggler.DocGen.DataAccessComponent.StoredProcedureManager.DeleteProcedures;
using DataJuggler.DocGen.DataAccessComponent.StoredProcedureManager.FetchProcedures;
using DataJuggler.DocGen.DataAccessComponent.StoredProcedureManager.InsertProcedures;
using DataJuggler.DocGen.DataAccessComponent.StoredProcedureManager.UpdateProcedures;
using DataJuggler.DocGen.ObjectLibrary.BusinessObjects;
using System;
using System.Collections.Generic;

#endregion


namespace DataJuggler.DocGen.DataAccessComponent.DataOperations
{

    #region class CodeParameterMethods
    /// <summary>
    /// This class contains methods for modifying a 'CodeParameter' object.
    /// </summary>
    public class CodeParameterMethods
    {

        #region Private Variables
        private DataManager dataManager;
        #endregion

        #region Constructor
        /// <summary>
        /// Creates a new Creates a new 'CodeParameterMethods' object.
        /// </summary>
        public CodeParameterMethods(DataManager dataManagerArg)
        {
            // Save Argument
            this.DataManager = dataManagerArg;
        }
        #endregion

        #region Methods

            #region DeleteCodeParameter(CodeParameter)
            /// <summary>
            /// This method deletes a 'CodeParameter' object.
            /// </summary>
            /// <param name='List<PolymorphicObject>'>The 'CodeParameter' to delete.
            /// <returns>A PolymorphicObject object with a Boolean value.
            internal PolymorphicObject DeleteCodeParameter(List<PolymorphicObject> parameters, DataConnector dataConnector)
            {
                // Initial Value
                PolymorphicObject returnObject = new PolymorphicObject();

                // If the data connection is connected
                if ((dataConnector != null) && (dataConnector.Connected == true))
                {
                    // Create Delete StoredProcedure
                    DeleteCodeParameterStoredProcedure deleteCodeParameterProc = null;

                    // verify the first parameters is a(n) 'CodeParameter'.
                    if (parameters[0].ObjectValue as CodeParameter != null)
                    {
                        // Create CodeParameter
                        CodeParameter codeParameter = (CodeParameter) parameters[0].ObjectValue;

                        // verify codeParameter exists
                        if(codeParameter != null)
                        {
                            // Now create deleteCodeParameterProc from CodeParameterWriter
                            // The DataWriter converts the 'CodeParameter'
                            // to the SqlParameter[] array needed to delete a 'CodeParameter'.
                            deleteCodeParameterProc = CodeParameterWriter.CreateDeleteCodeParameterStoredProcedure(codeParameter);
                        }
                    }

                    // Verify deleteCodeParameterProc exists
                    if(deleteCodeParameterProc != null)
                    {
                        // Execute Delete Stored Procedure
                        bool deleted = this.DataManager.CodeParameterManager.DeleteCodeParameter(deleteCodeParameterProc, dataConnector);

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
            /// This method fetches all 'CodeParameter' objects.
            /// </summary>
            /// <param name='List<PolymorphicObject>'>The 'CodeParameter' to delete.
            /// <returns>A PolymorphicObject object with all  'CodeParameters' objects.
            internal PolymorphicObject FetchAll(List<PolymorphicObject> parameters, DataConnector dataConnector)
            {
                // Initial Value
                PolymorphicObject returnObject = new PolymorphicObject();

                // locals
                List<CodeParameter> codeParameterListCollection =  null;

                // Create FetchAll StoredProcedure
                FetchAllCodeParametersStoredProcedure fetchAllProc = null;

                // If the data connection is connected
                if ((dataConnector != null) && (dataConnector.Connected == true))
                {
                    // Get CodeParameterParameter
                    // Declare Parameter
                    CodeParameter paramCodeParameter = null;

                    // verify the first parameters is a(n) 'CodeParameter'.
                    if (parameters[0].ObjectValue as CodeParameter != null)
                    {
                        // Get CodeParameterParameter
                        paramCodeParameter = (CodeParameter) parameters[0].ObjectValue;
                    }

                    // Now create FetchAllCodeParametersProc from CodeParameterWriter
                    fetchAllProc = CodeParameterWriter.CreateFetchAllCodeParametersStoredProcedure(paramCodeParameter);
                }

                // Verify fetchAllProc exists
                if(fetchAllProc!= null)
                {
                    // Execute FetchAll Stored Procedure
                    codeParameterListCollection = this.DataManager.CodeParameterManager.FetchAllCodeParameters(fetchAllProc, dataConnector);

                    // if dataObjectCollection exists
                    if(codeParameterListCollection != null)
                    {
                        // set returnObject.ObjectValue
                        returnObject.ObjectValue = codeParameterListCollection;
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

            #region FindCodeParameter(CodeParameter)
            /// <summary>
            /// This method finds a 'CodeParameter' object.
            /// </summary>
            /// <param name='List<PolymorphicObject>'>The 'CodeParameter' to delete.
            /// <returns>A PolymorphicObject object with a Boolean value.
            internal PolymorphicObject FindCodeParameter(List<PolymorphicObject> parameters, DataConnector dataConnector)
            {
                // Initial Value
                PolymorphicObject returnObject = new PolymorphicObject();

                // locals
                CodeParameter codeParameter = null;

                // If the data connection is connected
                if ((dataConnector != null) && (dataConnector.Connected == true))
                {
                    // Create Find StoredProcedure
                    FindCodeParameterStoredProcedure findCodeParameterProc = null;

                    // verify the first parameters is a 'CodeParameter'.
                    if (parameters[0].ObjectValue as CodeParameter != null)
                    {
                        // Get CodeParameterParameter
                        CodeParameter paramCodeParameter = (CodeParameter) parameters[0].ObjectValue;

                        // verify paramCodeParameter exists
                        if(paramCodeParameter != null)
                        {
                            // Now create findCodeParameterProc from CodeParameterWriter
                            // The DataWriter converts the 'CodeParameter'
                            // to the SqlParameter[] array needed to find a 'CodeParameter'.
                            findCodeParameterProc = CodeParameterWriter.CreateFindCodeParameterStoredProcedure(paramCodeParameter);
                        }

                        // Verify findCodeParameterProc exists
                        if(findCodeParameterProc != null)
                        {
                            // Execute Find Stored Procedure
                            codeParameter = this.DataManager.CodeParameterManager.FindCodeParameter(findCodeParameterProc, dataConnector);

                            // if dataObject exists
                            if(codeParameter != null)
                            {
                                // set returnObject.ObjectValue
                                returnObject.ObjectValue = codeParameter;
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

            #region InsertCodeParameter (CodeParameter)
            /// <summary>
            /// This method inserts a 'CodeParameter' object.
            /// </summary>
            /// <param name='List<PolymorphicObject>'>The 'CodeParameter' to insert.
            /// <returns>A PolymorphicObject object with a Boolean value.
            internal PolymorphicObject InsertCodeParameter(List<PolymorphicObject> parameters, DataConnector dataConnector)
            {
                // Initial Value
                PolymorphicObject returnObject = new PolymorphicObject();

                // locals
                CodeParameter codeParameter = null;

                // If the data connection is connected
                if ((dataConnector != null) && (dataConnector.Connected == true))
                {
                    // Create Insert StoredProcedure
                    InsertCodeParameterStoredProcedure insertCodeParameterProc = null;

                    // verify the first parameters is a(n) 'CodeParameter'.
                    if (parameters[0].ObjectValue as CodeParameter != null)
                    {
                        // Create CodeParameter Parameter
                        codeParameter = (CodeParameter) parameters[0].ObjectValue;

                        // verify codeParameter exists
                        if(codeParameter != null)
                        {
                            // Now create insertCodeParameterProc from CodeParameterWriter
                            // The DataWriter converts the 'CodeParameter'
                            // to the SqlParameter[] array needed to insert a 'CodeParameter'.
                            insertCodeParameterProc = CodeParameterWriter.CreateInsertCodeParameterStoredProcedure(codeParameter);
                        }

                        // Verify insertCodeParameterProc exists
                        if(insertCodeParameterProc != null)
                        {
                            // Execute Insert Stored Procedure
                            returnObject.IntegerValue = this.DataManager.CodeParameterManager.InsertCodeParameter(insertCodeParameterProc, dataConnector);
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

            #region UpdateCodeParameter (CodeParameter)
            /// <summary>
            /// This method updates a 'CodeParameter' object.
            /// </summary>
            /// <param name='List<PolymorphicObject>'>The 'CodeParameter' to update.
            /// <returns>A PolymorphicObject object with a value.
            internal PolymorphicObject UpdateCodeParameter(List<PolymorphicObject> parameters, DataConnector dataConnector)
            {
                // Initial Value
                PolymorphicObject returnObject = new PolymorphicObject();

                // locals
                CodeParameter codeParameter = null;

                // If the data connection is connected
                if ((dataConnector != null) && (dataConnector.Connected == true))
                {
                    // Create Update StoredProcedure
                    UpdateCodeParameterStoredProcedure updateCodeParameterProc = null;

                    // verify the first parameters is a(n) 'CodeParameter'.
                    if (parameters[0].ObjectValue as CodeParameter != null)
                    {
                        // Create CodeParameter Parameter
                        codeParameter = (CodeParameter) parameters[0].ObjectValue;

                        // verify codeParameter exists
                        if(codeParameter != null)
                        {
                            // Now create updateCodeParameterProc from CodeParameterWriter
                            // The DataWriter converts the 'CodeParameter'
                            // to the SqlParameter[] array needed to update a 'CodeParameter'.
                            updateCodeParameterProc = CodeParameterWriter.CreateUpdateCodeParameterStoredProcedure(codeParameter);
                        }

                        // Verify updateCodeParameterProc exists
                        if(updateCodeParameterProc != null)
                        {
                            // Execute Update Stored Procedure
                            bool saved = this.DataManager.CodeParameterManager.UpdateCodeParameter(updateCodeParameterProc, dataConnector);

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
