

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

    #region class CodeFileMethods
    /// <summary>
    /// This class contains methods for modifying a 'CodeFile' object.
    /// </summary>
    public class CodeFileMethods
    {

        #region Private Variables
        private DataManager dataManager;
        #endregion

        #region Constructor
        /// <summary>
        /// Creates a new Creates a new 'CodeFileMethods' object.
        /// </summary>
        public CodeFileMethods(DataManager dataManagerArg)
        {
            // Save Argument
            this.DataManager = dataManagerArg;
        }
        #endregion

        #region Methods

            #region DeleteCodeFile(CodeFile)
            /// <summary>
            /// This method deletes a 'CodeFile' object.
            /// </summary>
            /// <param name='List<PolymorphicObject>'>The 'CodeFile' to delete.
            /// <returns>A PolymorphicObject object with a Boolean value.
            internal PolymorphicObject DeleteCodeFile(List<PolymorphicObject> parameters, DataConnector dataConnector)
            {
                // Initial Value
                PolymorphicObject returnObject = new PolymorphicObject();

                // If the data connection is connected
                if ((dataConnector != null) && (dataConnector.Connected == true))
                {
                    // Create Delete StoredProcedure
                    DeleteCodeFileStoredProcedure deleteCodeFileProc = null;

                    // verify the first parameters is a(n) 'CodeFile'.
                    if (parameters[0].ObjectValue as CodeFile != null)
                    {
                        // Create CodeFile
                        CodeFile codeFile = (CodeFile) parameters[0].ObjectValue;

                        // verify codeFile exists
                        if(codeFile != null)
                        {
                            // Now create deleteCodeFileProc from CodeFileWriter
                            // The DataWriter converts the 'CodeFile'
                            // to the SqlParameter[] array needed to delete a 'CodeFile'.
                            deleteCodeFileProc = CodeFileWriter.CreateDeleteCodeFileStoredProcedure(codeFile);
                        }
                    }

                    // Verify deleteCodeFileProc exists
                    if(deleteCodeFileProc != null)
                    {
                        // Execute Delete Stored Procedure
                        bool deleted = this.DataManager.CodeFileManager.DeleteCodeFile(deleteCodeFileProc, dataConnector);

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
            /// This method fetches all 'CodeFile' objects.
            /// </summary>
            /// <param name='List<PolymorphicObject>'>The 'CodeFile' to delete.
            /// <returns>A PolymorphicObject object with all  'CodeFiles' objects.
            internal PolymorphicObject FetchAll(List<PolymorphicObject> parameters, DataConnector dataConnector)
            {
                // Initial Value
                PolymorphicObject returnObject = new PolymorphicObject();

                // locals
                List<CodeFile> codeFileListCollection =  null;

                // Create FetchAll StoredProcedure
                FetchAllCodeFilesStoredProcedure fetchAllProc = null;

                // If the data connection is connected
                if ((dataConnector != null) && (dataConnector.Connected == true))
                {
                    // Get CodeFileParameter
                    // Declare Parameter
                    CodeFile paramCodeFile = null;

                    // verify the first parameters is a(n) 'CodeFile'.
                    if (parameters[0].ObjectValue as CodeFile != null)
                    {
                        // Get CodeFileParameter
                        paramCodeFile = (CodeFile) parameters[0].ObjectValue;
                    }

                    // Now create FetchAllCodeFilesProc from CodeFileWriter
                    fetchAllProc = CodeFileWriter.CreateFetchAllCodeFilesStoredProcedure(paramCodeFile);
                }

                // Verify fetchAllProc exists
                if(fetchAllProc!= null)
                {
                    // Execute FetchAll Stored Procedure
                    codeFileListCollection = this.DataManager.CodeFileManager.FetchAllCodeFiles(fetchAllProc, dataConnector);

                    // if dataObjectCollection exists
                    if(codeFileListCollection != null)
                    {
                        // set returnObject.ObjectValue
                        returnObject.ObjectValue = codeFileListCollection;
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

            #region FindCodeFile(CodeFile)
            /// <summary>
            /// This method finds a 'CodeFile' object.
            /// </summary>
            /// <param name='List<PolymorphicObject>'>The 'CodeFile' to delete.
            /// <returns>A PolymorphicObject object with a Boolean value.
            internal PolymorphicObject FindCodeFile(List<PolymorphicObject> parameters, DataConnector dataConnector)
            {
                // Initial Value
                PolymorphicObject returnObject = new PolymorphicObject();

                // locals
                CodeFile codeFile = null;

                // If the data connection is connected
                if ((dataConnector != null) && (dataConnector.Connected == true))
                {
                    // Create Find StoredProcedure
                    FindCodeFileStoredProcedure findCodeFileProc = null;

                    // verify the first parameters is a 'CodeFile'.
                    if (parameters[0].ObjectValue as CodeFile != null)
                    {
                        // Get CodeFileParameter
                        CodeFile paramCodeFile = (CodeFile) parameters[0].ObjectValue;

                        // verify paramCodeFile exists
                        if(paramCodeFile != null)
                        {
                            // Now create findCodeFileProc from CodeFileWriter
                            // The DataWriter converts the 'CodeFile'
                            // to the SqlParameter[] array needed to find a 'CodeFile'.
                            findCodeFileProc = CodeFileWriter.CreateFindCodeFileStoredProcedure(paramCodeFile);
                        }

                        // Verify findCodeFileProc exists
                        if(findCodeFileProc != null)
                        {
                            // Execute Find Stored Procedure
                            codeFile = this.DataManager.CodeFileManager.FindCodeFile(findCodeFileProc, dataConnector);

                            // if dataObject exists
                            if(codeFile != null)
                            {
                                // set returnObject.ObjectValue
                                returnObject.ObjectValue = codeFile;
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

            #region InsertCodeFile (CodeFile)
            /// <summary>
            /// This method inserts a 'CodeFile' object.
            /// </summary>
            /// <param name='List<PolymorphicObject>'>The 'CodeFile' to insert.
            /// <returns>A PolymorphicObject object with a Boolean value.
            internal PolymorphicObject InsertCodeFile(List<PolymorphicObject> parameters, DataConnector dataConnector)
            {
                // Initial Value
                PolymorphicObject returnObject = new PolymorphicObject();

                // locals
                CodeFile codeFile = null;

                // If the data connection is connected
                if ((dataConnector != null) && (dataConnector.Connected == true))
                {
                    // Create Insert StoredProcedure
                    InsertCodeFileStoredProcedure insertCodeFileProc = null;

                    // verify the first parameters is a(n) 'CodeFile'.
                    if (parameters[0].ObjectValue as CodeFile != null)
                    {
                        // Create CodeFile Parameter
                        codeFile = (CodeFile) parameters[0].ObjectValue;

                        // verify codeFile exists
                        if(codeFile != null)
                        {
                            // Now create insertCodeFileProc from CodeFileWriter
                            // The DataWriter converts the 'CodeFile'
                            // to the SqlParameter[] array needed to insert a 'CodeFile'.
                            insertCodeFileProc = CodeFileWriter.CreateInsertCodeFileStoredProcedure(codeFile);
                        }

                        // Verify insertCodeFileProc exists
                        if(insertCodeFileProc != null)
                        {
                            // Execute Insert Stored Procedure
                            returnObject.IntegerValue = this.DataManager.CodeFileManager.InsertCodeFile(insertCodeFileProc, dataConnector);
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

            #region UpdateCodeFile (CodeFile)
            /// <summary>
            /// This method updates a 'CodeFile' object.
            /// </summary>
            /// <param name='List<PolymorphicObject>'>The 'CodeFile' to update.
            /// <returns>A PolymorphicObject object with a value.
            internal PolymorphicObject UpdateCodeFile(List<PolymorphicObject> parameters, DataConnector dataConnector)
            {
                // Initial Value
                PolymorphicObject returnObject = new PolymorphicObject();

                // locals
                CodeFile codeFile = null;

                // If the data connection is connected
                if ((dataConnector != null) && (dataConnector.Connected == true))
                {
                    // Create Update StoredProcedure
                    UpdateCodeFileStoredProcedure updateCodeFileProc = null;

                    // verify the first parameters is a(n) 'CodeFile'.
                    if (parameters[0].ObjectValue as CodeFile != null)
                    {
                        // Create CodeFile Parameter
                        codeFile = (CodeFile) parameters[0].ObjectValue;

                        // verify codeFile exists
                        if(codeFile != null)
                        {
                            // Now create updateCodeFileProc from CodeFileWriter
                            // The DataWriter converts the 'CodeFile'
                            // to the SqlParameter[] array needed to update a 'CodeFile'.
                            updateCodeFileProc = CodeFileWriter.CreateUpdateCodeFileStoredProcedure(codeFile);
                        }

                        // Verify updateCodeFileProc exists
                        if(updateCodeFileProc != null)
                        {
                            // Execute Update Stored Procedure
                            bool saved = this.DataManager.CodeFileManager.UpdateCodeFile(updateCodeFileProc, dataConnector);

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
