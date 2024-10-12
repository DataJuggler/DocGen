

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

    #region class CodePropertyMethods
    /// <summary>
    /// This class contains methods for modifying a 'CodeProperty' object.
    /// </summary>
    public class CodePropertyMethods
    {

        #region Private Variables
        private DataManager dataManager;
        #endregion

        #region Constructor
        /// <summary>
        /// Creates a new Creates a new 'CodePropertyMethods' object.
        /// </summary>
        public CodePropertyMethods(DataManager dataManagerArg)
        {
            // Save Argument
            this.DataManager = dataManagerArg;
        }
        #endregion

        #region Methods

            #region DeleteCodeProperty(CodeProperty)
            /// <summary>
            /// This method deletes a 'CodeProperty' object.
            /// </summary>
            /// <param name='List<PolymorphicObject>'>The 'CodeProperty' to delete.
            /// <returns>A PolymorphicObject object with a Boolean value.
            internal PolymorphicObject DeleteCodeProperty(List<PolymorphicObject> parameters, DataConnector dataConnector)
            {
                // Initial Value
                PolymorphicObject returnObject = new PolymorphicObject();

                // If the data connection is connected
                if ((dataConnector != null) && (dataConnector.Connected == true))
                {
                    // Create Delete StoredProcedure
                    DeleteCodePropertyStoredProcedure deleteCodePropertyProc = null;

                    // verify the first parameters is a(n) 'CodeProperty'.
                    if (parameters[0].ObjectValue as CodeProperty != null)
                    {
                        // Create CodeProperty
                        CodeProperty codeProperty = (CodeProperty) parameters[0].ObjectValue;

                        // verify codeProperty exists
                        if(codeProperty != null)
                        {
                            // Now create deleteCodePropertyProc from CodePropertyWriter
                            // The DataWriter converts the 'CodeProperty'
                            // to the SqlParameter[] array needed to delete a 'CodeProperty'.
                            deleteCodePropertyProc = CodePropertyWriter.CreateDeleteCodePropertyStoredProcedure(codeProperty);
                        }
                    }

                    // Verify deleteCodePropertyProc exists
                    if(deleteCodePropertyProc != null)
                    {
                        // Execute Delete Stored Procedure
                        bool deleted = this.DataManager.CodePropertyManager.DeleteCodeProperty(deleteCodePropertyProc, dataConnector);

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
            /// This method fetches all 'CodeProperty' objects.
            /// </summary>
            /// <param name='List<PolymorphicObject>'>The 'CodeProperty' to delete.
            /// <returns>A PolymorphicObject object with all  'CodePropertys' objects.
            internal PolymorphicObject FetchAll(List<PolymorphicObject> parameters, DataConnector dataConnector)
            {
                // Initial Value
                PolymorphicObject returnObject = new PolymorphicObject();

                // locals
                List<CodeProperty> codePropertyListCollection =  null;

                // Create FetchAll StoredProcedure
                FetchAllCodePropertysStoredProcedure fetchAllProc = null;

                // If the data connection is connected
                if ((dataConnector != null) && (dataConnector.Connected == true))
                {
                    // Get CodePropertyParameter
                    // Declare Parameter
                    CodeProperty paramCodeProperty = null;

                    // verify the first parameters is a(n) 'CodeProperty'.
                    if (parameters[0].ObjectValue as CodeProperty != null)
                    {
                        // Get CodePropertyParameter
                        paramCodeProperty = (CodeProperty) parameters[0].ObjectValue;
                    }

                    // Now create FetchAllCodePropertysProc from CodePropertyWriter
                    fetchAllProc = CodePropertyWriter.CreateFetchAllCodePropertysStoredProcedure(paramCodeProperty);
                }

                // Verify fetchAllProc exists
                if(fetchAllProc!= null)
                {
                    // Execute FetchAll Stored Procedure
                    codePropertyListCollection = this.DataManager.CodePropertyManager.FetchAllCodePropertys(fetchAllProc, dataConnector);

                    // if dataObjectCollection exists
                    if(codePropertyListCollection != null)
                    {
                        // set returnObject.ObjectValue
                        returnObject.ObjectValue = codePropertyListCollection;
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

            #region FindCodeProperty(CodeProperty)
            /// <summary>
            /// This method finds a 'CodeProperty' object.
            /// </summary>
            /// <param name='List<PolymorphicObject>'>The 'CodeProperty' to delete.
            /// <returns>A PolymorphicObject object with a Boolean value.
            internal PolymorphicObject FindCodeProperty(List<PolymorphicObject> parameters, DataConnector dataConnector)
            {
                // Initial Value
                PolymorphicObject returnObject = new PolymorphicObject();

                // locals
                CodeProperty codeProperty = null;

                // If the data connection is connected
                if ((dataConnector != null) && (dataConnector.Connected == true))
                {
                    // Create Find StoredProcedure
                    FindCodePropertyStoredProcedure findCodePropertyProc = null;

                    // verify the first parameters is a 'CodeProperty'.
                    if (parameters[0].ObjectValue as CodeProperty != null)
                    {
                        // Get CodePropertyParameter
                        CodeProperty paramCodeProperty = (CodeProperty) parameters[0].ObjectValue;

                        // verify paramCodeProperty exists
                        if(paramCodeProperty != null)
                        {
                            // Now create findCodePropertyProc from CodePropertyWriter
                            // The DataWriter converts the 'CodeProperty'
                            // to the SqlParameter[] array needed to find a 'CodeProperty'.
                            findCodePropertyProc = CodePropertyWriter.CreateFindCodePropertyStoredProcedure(paramCodeProperty);
                        }

                        // Verify findCodePropertyProc exists
                        if(findCodePropertyProc != null)
                        {
                            // Execute Find Stored Procedure
                            codeProperty = this.DataManager.CodePropertyManager.FindCodeProperty(findCodePropertyProc, dataConnector);

                            // if dataObject exists
                            if(codeProperty != null)
                            {
                                // set returnObject.ObjectValue
                                returnObject.ObjectValue = codeProperty;
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

            #region InsertCodeProperty (CodeProperty)
            /// <summary>
            /// This method inserts a 'CodeProperty' object.
            /// </summary>
            /// <param name='List<PolymorphicObject>'>The 'CodeProperty' to insert.
            /// <returns>A PolymorphicObject object with a Boolean value.
            internal PolymorphicObject InsertCodeProperty(List<PolymorphicObject> parameters, DataConnector dataConnector)
            {
                // Initial Value
                PolymorphicObject returnObject = new PolymorphicObject();

                // locals
                CodeProperty codeProperty = null;

                // If the data connection is connected
                if ((dataConnector != null) && (dataConnector.Connected == true))
                {
                    // Create Insert StoredProcedure
                    InsertCodePropertyStoredProcedure insertCodePropertyProc = null;

                    // verify the first parameters is a(n) 'CodeProperty'.
                    if (parameters[0].ObjectValue as CodeProperty != null)
                    {
                        // Create CodeProperty Parameter
                        codeProperty = (CodeProperty) parameters[0].ObjectValue;

                        // verify codeProperty exists
                        if(codeProperty != null)
                        {
                            // Now create insertCodePropertyProc from CodePropertyWriter
                            // The DataWriter converts the 'CodeProperty'
                            // to the SqlParameter[] array needed to insert a 'CodeProperty'.
                            insertCodePropertyProc = CodePropertyWriter.CreateInsertCodePropertyStoredProcedure(codeProperty);
                        }

                        // Verify insertCodePropertyProc exists
                        if(insertCodePropertyProc != null)
                        {
                            // Execute Insert Stored Procedure
                            returnObject.IntegerValue = this.DataManager.CodePropertyManager.InsertCodeProperty(insertCodePropertyProc, dataConnector);
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

            #region UpdateCodeProperty (CodeProperty)
            /// <summary>
            /// This method updates a 'CodeProperty' object.
            /// </summary>
            /// <param name='List<PolymorphicObject>'>The 'CodeProperty' to update.
            /// <returns>A PolymorphicObject object with a value.
            internal PolymorphicObject UpdateCodeProperty(List<PolymorphicObject> parameters, DataConnector dataConnector)
            {
                // Initial Value
                PolymorphicObject returnObject = new PolymorphicObject();

                // locals
                CodeProperty codeProperty = null;

                // If the data connection is connected
                if ((dataConnector != null) && (dataConnector.Connected == true))
                {
                    // Create Update StoredProcedure
                    UpdateCodePropertyStoredProcedure updateCodePropertyProc = null;

                    // verify the first parameters is a(n) 'CodeProperty'.
                    if (parameters[0].ObjectValue as CodeProperty != null)
                    {
                        // Create CodeProperty Parameter
                        codeProperty = (CodeProperty) parameters[0].ObjectValue;

                        // verify codeProperty exists
                        if(codeProperty != null)
                        {
                            // Now create updateCodePropertyProc from CodePropertyWriter
                            // The DataWriter converts the 'CodeProperty'
                            // to the SqlParameter[] array needed to update a 'CodeProperty'.
                            updateCodePropertyProc = CodePropertyWriter.CreateUpdateCodePropertyStoredProcedure(codeProperty);
                        }

                        // Verify updateCodePropertyProc exists
                        if(updateCodePropertyProc != null)
                        {
                            // Execute Update Stored Procedure
                            bool saved = this.DataManager.CodePropertyManager.UpdateCodeProperty(updateCodePropertyProc, dataConnector);

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
