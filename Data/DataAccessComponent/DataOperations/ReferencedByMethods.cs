

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

    #region class ReferencedByMethods
    /// <summary>
    /// This class contains methods for modifying a 'ReferencedBy' object.
    /// </summary>
    public class ReferencedByMethods
    {

        #region Private Variables
        private DataManager dataManager;
        #endregion

        #region Constructor
        /// <summary>
        /// Creates a new Creates a new 'ReferencedByMethods' object.
        /// </summary>
        public ReferencedByMethods(DataManager dataManagerArg)
        {
            // Save Argument
            this.DataManager = dataManagerArg;
        }
        #endregion

        #region Methods

            #region DeleteReferencedBy(ReferencedBy)
            /// <summary>
            /// This method deletes a 'ReferencedBy' object.
            /// </summary>
            /// <param name='List<PolymorphicObject>'>The 'ReferencedBy' to delete.
            /// <returns>A PolymorphicObject object with a Boolean value.
            internal PolymorphicObject DeleteReferencedBy(List<PolymorphicObject> parameters, DataConnector dataConnector)
            {
                // Initial Value
                PolymorphicObject returnObject = new PolymorphicObject();

                // If the data connection is connected
                if ((dataConnector != null) && (dataConnector.Connected == true))
                {
                    // Create Delete StoredProcedure
                    DeleteReferencedByStoredProcedure deleteReferencedByProc = null;

                    // verify the first parameters is a(n) 'ReferencedBy'.
                    if (parameters[0].ObjectValue as ReferencedBy != null)
                    {
                        // Create ReferencedBy
                        ReferencedBy referencedBy = (ReferencedBy) parameters[0].ObjectValue;

                        // verify referencedBy exists
                        if(referencedBy != null)
                        {
                            // Now create deleteReferencedByProc from ReferencedByWriter
                            // The DataWriter converts the 'ReferencedBy'
                            // to the SqlParameter[] array needed to delete a 'ReferencedBy'.
                            deleteReferencedByProc = ReferencedByWriter.CreateDeleteReferencedByStoredProcedure(referencedBy);
                        }
                    }

                    // Verify deleteReferencedByProc exists
                    if(deleteReferencedByProc != null)
                    {
                        // Execute Delete Stored Procedure
                        bool deleted = this.DataManager.ReferencedByManager.DeleteReferencedBy(deleteReferencedByProc, dataConnector);

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
            /// This method fetches all 'ReferencedBy' objects.
            /// </summary>
            /// <param name='List<PolymorphicObject>'>The 'ReferencedBy' to delete.
            /// <returns>A PolymorphicObject object with all  'ReferencedBys' objects.
            internal PolymorphicObject FetchAll(List<PolymorphicObject> parameters, DataConnector dataConnector)
            {
                // Initial Value
                PolymorphicObject returnObject = new PolymorphicObject();

                // locals
                List<ReferencedBy> referencedByListCollection =  null;

                // Create FetchAll StoredProcedure
                FetchAllReferencedBysStoredProcedure fetchAllProc = null;

                // If the data connection is connected
                if ((dataConnector != null) && (dataConnector.Connected == true))
                {
                    // Get ReferencedByParameter
                    // Declare Parameter
                    ReferencedBy paramReferencedBy = null;

                    // verify the first parameters is a(n) 'ReferencedBy'.
                    if (parameters[0].ObjectValue as ReferencedBy != null)
                    {
                        // Get ReferencedByParameter
                        paramReferencedBy = (ReferencedBy) parameters[0].ObjectValue;
                    }

                    // Now create FetchAllReferencedBysProc from ReferencedByWriter
                    fetchAllProc = ReferencedByWriter.CreateFetchAllReferencedBysStoredProcedure(paramReferencedBy);
                }

                // Verify fetchAllProc exists
                if(fetchAllProc!= null)
                {
                    // Execute FetchAll Stored Procedure
                    referencedByListCollection = this.DataManager.ReferencedByManager.FetchAllReferencedBys(fetchAllProc, dataConnector);

                    // if dataObjectCollection exists
                    if(referencedByListCollection != null)
                    {
                        // set returnObject.ObjectValue
                        returnObject.ObjectValue = referencedByListCollection;
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

            #region FindReferencedBy(ReferencedBy)
            /// <summary>
            /// This method finds a 'ReferencedBy' object.
            /// </summary>
            /// <param name='List<PolymorphicObject>'>The 'ReferencedBy' to delete.
            /// <returns>A PolymorphicObject object with a Boolean value.
            internal PolymorphicObject FindReferencedBy(List<PolymorphicObject> parameters, DataConnector dataConnector)
            {
                // Initial Value
                PolymorphicObject returnObject = new PolymorphicObject();

                // locals
                ReferencedBy referencedBy = null;

                // If the data connection is connected
                if ((dataConnector != null) && (dataConnector.Connected == true))
                {
                    // Create Find StoredProcedure
                    FindReferencedByStoredProcedure findReferencedByProc = null;

                    // verify the first parameters is a 'ReferencedBy'.
                    if (parameters[0].ObjectValue as ReferencedBy != null)
                    {
                        // Get ReferencedByParameter
                        ReferencedBy paramReferencedBy = (ReferencedBy) parameters[0].ObjectValue;

                        // verify paramReferencedBy exists
                        if(paramReferencedBy != null)
                        {
                            // Now create findReferencedByProc from ReferencedByWriter
                            // The DataWriter converts the 'ReferencedBy'
                            // to the SqlParameter[] array needed to find a 'ReferencedBy'.
                            findReferencedByProc = ReferencedByWriter.CreateFindReferencedByStoredProcedure(paramReferencedBy);
                        }

                        // Verify findReferencedByProc exists
                        if(findReferencedByProc != null)
                        {
                            // Execute Find Stored Procedure
                            referencedBy = this.DataManager.ReferencedByManager.FindReferencedBy(findReferencedByProc, dataConnector);

                            // if dataObject exists
                            if(referencedBy != null)
                            {
                                // set returnObject.ObjectValue
                                returnObject.ObjectValue = referencedBy;
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

            #region InsertReferencedBy (ReferencedBy)
            /// <summary>
            /// This method inserts a 'ReferencedBy' object.
            /// </summary>
            /// <param name='List<PolymorphicObject>'>The 'ReferencedBy' to insert.
            /// <returns>A PolymorphicObject object with a Boolean value.
            internal PolymorphicObject InsertReferencedBy(List<PolymorphicObject> parameters, DataConnector dataConnector)
            {
                // Initial Value
                PolymorphicObject returnObject = new PolymorphicObject();

                // locals
                ReferencedBy referencedBy = null;

                // If the data connection is connected
                if ((dataConnector != null) && (dataConnector.Connected == true))
                {
                    // Create Insert StoredProcedure
                    InsertReferencedByStoredProcedure insertReferencedByProc = null;

                    // verify the first parameters is a(n) 'ReferencedBy'.
                    if (parameters[0].ObjectValue as ReferencedBy != null)
                    {
                        // Create ReferencedBy Parameter
                        referencedBy = (ReferencedBy) parameters[0].ObjectValue;

                        // verify referencedBy exists
                        if(referencedBy != null)
                        {
                            // Now create insertReferencedByProc from ReferencedByWriter
                            // The DataWriter converts the 'ReferencedBy'
                            // to the SqlParameter[] array needed to insert a 'ReferencedBy'.
                            insertReferencedByProc = ReferencedByWriter.CreateInsertReferencedByStoredProcedure(referencedBy);
                        }

                        // Verify insertReferencedByProc exists
                        if(insertReferencedByProc != null)
                        {
                            // Execute Insert Stored Procedure
                            returnObject.IntegerValue = this.DataManager.ReferencedByManager.InsertReferencedBy(insertReferencedByProc, dataConnector);
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

            #region UpdateReferencedBy (ReferencedBy)
            /// <summary>
            /// This method updates a 'ReferencedBy' object.
            /// </summary>
            /// <param name='List<PolymorphicObject>'>The 'ReferencedBy' to update.
            /// <returns>A PolymorphicObject object with a value.
            internal PolymorphicObject UpdateReferencedBy(List<PolymorphicObject> parameters, DataConnector dataConnector)
            {
                // Initial Value
                PolymorphicObject returnObject = new PolymorphicObject();

                // locals
                ReferencedBy referencedBy = null;

                // If the data connection is connected
                if ((dataConnector != null) && (dataConnector.Connected == true))
                {
                    // Create Update StoredProcedure
                    UpdateReferencedByStoredProcedure updateReferencedByProc = null;

                    // verify the first parameters is a(n) 'ReferencedBy'.
                    if (parameters[0].ObjectValue as ReferencedBy != null)
                    {
                        // Create ReferencedBy Parameter
                        referencedBy = (ReferencedBy) parameters[0].ObjectValue;

                        // verify referencedBy exists
                        if(referencedBy != null)
                        {
                            // Now create updateReferencedByProc from ReferencedByWriter
                            // The DataWriter converts the 'ReferencedBy'
                            // to the SqlParameter[] array needed to update a 'ReferencedBy'.
                            updateReferencedByProc = ReferencedByWriter.CreateUpdateReferencedByStoredProcedure(referencedBy);
                        }

                        // Verify updateReferencedByProc exists
                        if(updateReferencedByProc != null)
                        {
                            // Execute Update Stored Procedure
                            bool saved = this.DataManager.ReferencedByManager.UpdateReferencedBy(updateReferencedByProc, dataConnector);

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
