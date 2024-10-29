

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

    #region class CodeSampleMethods
    /// <summary>
    /// This class contains methods for modifying a 'CodeSample' object.
    /// </summary>
    public class CodeSampleMethods
    {

        #region Private Variables
        private DataManager dataManager;
        #endregion

        #region Constructor
        /// <summary>
        /// Creates a new Creates a new 'CodeSampleMethods' object.
        /// </summary>
        public CodeSampleMethods(DataManager dataManagerArg)
        {
            // Save Argument
            this.DataManager = dataManagerArg;
        }
        #endregion

        #region Methods

            #region DeleteCodeSample(CodeSample)
            /// <summary>
            /// This method deletes a 'CodeSample' object.
            /// </summary>
            /// <param name='List<PolymorphicObject>'>The 'CodeSample' to delete.
            /// <returns>A PolymorphicObject object with a Boolean value.
            internal PolymorphicObject DeleteCodeSample(List<PolymorphicObject> parameters, DataConnector dataConnector)
            {
                // Initial Value
                PolymorphicObject returnObject = new PolymorphicObject();

                // If the data connection is connected
                if ((dataConnector != null) && (dataConnector.Connected == true))
                {
                    // Create Delete StoredProcedure
                    DeleteCodeSampleStoredProcedure deleteCodeSampleProc = null;

                    // verify the first parameters is a(n) 'CodeSample'.
                    if (parameters[0].ObjectValue as CodeSample != null)
                    {
                        // Create CodeSample
                        CodeSample codeSample = (CodeSample) parameters[0].ObjectValue;

                        // verify codeSample exists
                        if(codeSample != null)
                        {
                            // Now create deleteCodeSampleProc from CodeSampleWriter
                            // The DataWriter converts the 'CodeSample'
                            // to the SqlParameter[] array needed to delete a 'CodeSample'.
                            deleteCodeSampleProc = CodeSampleWriter.CreateDeleteCodeSampleStoredProcedure(codeSample);
                        }
                    }

                    // Verify deleteCodeSampleProc exists
                    if(deleteCodeSampleProc != null)
                    {
                        // Execute Delete Stored Procedure
                        bool deleted = this.DataManager.CodeSampleManager.DeleteCodeSample(deleteCodeSampleProc, dataConnector);

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
            /// This method fetches all 'CodeSample' objects.
            /// </summary>
            /// <param name='List<PolymorphicObject>'>The 'CodeSample' to delete.
            /// <returns>A PolymorphicObject object with all  'CodeSamples' objects.
            internal PolymorphicObject FetchAll(List<PolymorphicObject> parameters, DataConnector dataConnector)
            {
                // Initial Value
                PolymorphicObject returnObject = new PolymorphicObject();

                // locals
                List<CodeSample> codeSampleListCollection =  null;

                // Create FetchAll StoredProcedure
                FetchAllCodeSamplesStoredProcedure fetchAllProc = null;

                // If the data connection is connected
                if ((dataConnector != null) && (dataConnector.Connected == true))
                {
                    // Get CodeSampleParameter
                    // Declare Parameter
                    CodeSample paramCodeSample = null;

                    // verify the first parameters is a(n) 'CodeSample'.
                    if (parameters[0].ObjectValue as CodeSample != null)
                    {
                        // Get CodeSampleParameter
                        paramCodeSample = (CodeSample) parameters[0].ObjectValue;
                    }

                    // Now create FetchAllCodeSamplesProc from CodeSampleWriter
                    fetchAllProc = CodeSampleWriter.CreateFetchAllCodeSamplesStoredProcedure(paramCodeSample);
                }

                // Verify fetchAllProc exists
                if(fetchAllProc!= null)
                {
                    // Execute FetchAll Stored Procedure
                    codeSampleListCollection = this.DataManager.CodeSampleManager.FetchAllCodeSamples(fetchAllProc, dataConnector);

                    // if dataObjectCollection exists
                    if(codeSampleListCollection != null)
                    {
                        // set returnObject.ObjectValue
                        returnObject.ObjectValue = codeSampleListCollection;
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

            #region FindCodeSample(CodeSample)
            /// <summary>
            /// This method finds a 'CodeSample' object.
            /// </summary>
            /// <param name='List<PolymorphicObject>'>The 'CodeSample' to delete.
            /// <returns>A PolymorphicObject object with a Boolean value.
            internal PolymorphicObject FindCodeSample(List<PolymorphicObject> parameters, DataConnector dataConnector)
            {
                // Initial Value
                PolymorphicObject returnObject = new PolymorphicObject();

                // locals
                CodeSample codeSample = null;

                // If the data connection is connected
                if ((dataConnector != null) && (dataConnector.Connected == true))
                {
                    // Create Find StoredProcedure
                    FindCodeSampleStoredProcedure findCodeSampleProc = null;

                    // verify the first parameters is a 'CodeSample'.
                    if (parameters[0].ObjectValue as CodeSample != null)
                    {
                        // Get CodeSampleParameter
                        CodeSample paramCodeSample = (CodeSample) parameters[0].ObjectValue;

                        // verify paramCodeSample exists
                        if(paramCodeSample != null)
                        {
                            // Now create findCodeSampleProc from CodeSampleWriter
                            // The DataWriter converts the 'CodeSample'
                            // to the SqlParameter[] array needed to find a 'CodeSample'.
                            findCodeSampleProc = CodeSampleWriter.CreateFindCodeSampleStoredProcedure(paramCodeSample);
                        }

                        // Verify findCodeSampleProc exists
                        if(findCodeSampleProc != null)
                        {
                            // Execute Find Stored Procedure
                            codeSample = this.DataManager.CodeSampleManager.FindCodeSample(findCodeSampleProc, dataConnector);

                            // if dataObject exists
                            if(codeSample != null)
                            {
                                // set returnObject.ObjectValue
                                returnObject.ObjectValue = codeSample;
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

            #region InsertCodeSample (CodeSample)
            /// <summary>
            /// This method inserts a 'CodeSample' object.
            /// </summary>
            /// <param name='List<PolymorphicObject>'>The 'CodeSample' to insert.
            /// <returns>A PolymorphicObject object with a Boolean value.
            internal PolymorphicObject InsertCodeSample(List<PolymorphicObject> parameters, DataConnector dataConnector)
            {
                // Initial Value
                PolymorphicObject returnObject = new PolymorphicObject();

                // locals
                CodeSample codeSample = null;

                // If the data connection is connected
                if ((dataConnector != null) && (dataConnector.Connected == true))
                {
                    // Create Insert StoredProcedure
                    InsertCodeSampleStoredProcedure insertCodeSampleProc = null;

                    // verify the first parameters is a(n) 'CodeSample'.
                    if (parameters[0].ObjectValue as CodeSample != null)
                    {
                        // Create CodeSample Parameter
                        codeSample = (CodeSample) parameters[0].ObjectValue;

                        // verify codeSample exists
                        if(codeSample != null)
                        {
                            // Now create insertCodeSampleProc from CodeSampleWriter
                            // The DataWriter converts the 'CodeSample'
                            // to the SqlParameter[] array needed to insert a 'CodeSample'.
                            insertCodeSampleProc = CodeSampleWriter.CreateInsertCodeSampleStoredProcedure(codeSample);
                        }

                        // Verify insertCodeSampleProc exists
                        if(insertCodeSampleProc != null)
                        {
                            // Execute Insert Stored Procedure
                            returnObject.IntegerValue = this.DataManager.CodeSampleManager.InsertCodeSample(insertCodeSampleProc, dataConnector);
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

            #region UpdateCodeSample (CodeSample)
            /// <summary>
            /// This method updates a 'CodeSample' object.
            /// </summary>
            /// <param name='List<PolymorphicObject>'>The 'CodeSample' to update.
            /// <returns>A PolymorphicObject object with a value.
            internal PolymorphicObject UpdateCodeSample(List<PolymorphicObject> parameters, DataConnector dataConnector)
            {
                // Initial Value
                PolymorphicObject returnObject = new PolymorphicObject();

                // locals
                CodeSample codeSample = null;

                // If the data connection is connected
                if ((dataConnector != null) && (dataConnector.Connected == true))
                {
                    // Create Update StoredProcedure
                    UpdateCodeSampleStoredProcedure updateCodeSampleProc = null;

                    // verify the first parameters is a(n) 'CodeSample'.
                    if (parameters[0].ObjectValue as CodeSample != null)
                    {
                        // Create CodeSample Parameter
                        codeSample = (CodeSample) parameters[0].ObjectValue;

                        // verify codeSample exists
                        if(codeSample != null)
                        {
                            // Now create updateCodeSampleProc from CodeSampleWriter
                            // The DataWriter converts the 'CodeSample'
                            // to the SqlParameter[] array needed to update a 'CodeSample'.
                            updateCodeSampleProc = CodeSampleWriter.CreateUpdateCodeSampleStoredProcedure(codeSample);
                        }

                        // Verify updateCodeSampleProc exists
                        if(updateCodeSampleProc != null)
                        {
                            // Execute Update Stored Procedure
                            bool saved = this.DataManager.CodeSampleManager.UpdateCodeSample(updateCodeSampleProc, dataConnector);

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
