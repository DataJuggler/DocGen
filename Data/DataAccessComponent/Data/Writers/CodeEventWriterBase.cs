

#region using statements

using DataAccessComponent.StoredProcedureManager.DeleteProcedures;
using DataAccessComponent.StoredProcedureManager.FetchProcedures;
using DataAccessComponent.StoredProcedureManager.InsertProcedures;
using DataAccessComponent.StoredProcedureManager.UpdateProcedures;
using Microsoft.Data.SqlClient;
using ObjectLibrary.BusinessObjects;
using System;
using System.Data;

#endregion


namespace DataAccessComponent.Data.Writers
{

    #region class CodeEventWriterBase
    /// <summary>
    /// This class is used for converting a 'CodeEvent' object to
    /// the SqlParameter[] to perform the CRUD methods.
    /// </summary>
    public class CodeEventWriterBase
    {

        #region Static Methods

            #region CreatePrimaryKeyParameter(CodeEvent codeEvent)
            /// <summary>
            /// This method creates the sql Parameter[] array
            /// that holds the primary key value.
            /// </summary>
            /// <param name='codeEvent'>The 'CodeEvent' to get the primary key of.</param>
            /// <returns>A SqlParameter[] array which contains the primary key value.
            /// to delete.</returns>
            internal static SqlParameter[] CreatePrimaryKeyParameter(CodeEvent codeEvent)
            {
                // Initial Value
                SqlParameter[] parameters = new SqlParameter[1];

                // verify user exists
                if (codeEvent != null)
                {
                    // Create PrimaryKey Parameter
                    SqlParameter @Id = new SqlParameter("@Id", codeEvent.Id);

                    // Set parameters[0] to @Id
                    parameters[0] = @Id;
                }

                // return value
                return parameters;
            }
            #endregion

            #region CreateDeleteCodeEventStoredProcedure(CodeEvent codeEvent)
            /// <summary>
            /// This method creates an instance of an
            /// 'DeleteCodeEvent'StoredProcedure' object and
            /// creates the sql parameter[] array needed
            /// to execute the procedure 'CodeEvent_Delete'.
            /// </summary>
            /// <param name="codeEvent">The 'CodeEvent' to Delete.</param>
            /// <returns>An instance of a 'DeleteCodeEventStoredProcedure' object.</returns>
            public static DeleteCodeEventStoredProcedure CreateDeleteCodeEventStoredProcedure(CodeEvent codeEvent)
            {
                // Initial Value
                DeleteCodeEventStoredProcedure deleteCodeEventStoredProcedure = new DeleteCodeEventStoredProcedure();

                // Now Create Parameters For The DeleteProc
                deleteCodeEventStoredProcedure.Parameters = CreatePrimaryKeyParameter(codeEvent);

                // return value
                return deleteCodeEventStoredProcedure;
            }
            #endregion

            #region CreateFindCodeEventStoredProcedure(CodeEvent codeEvent)
            /// <summary>
            /// This method creates an instance of a
            /// 'FindCodeEventStoredProcedure' object and
            /// creates the sql parameter[] array needed
            /// to execute the procedure 'CodeEvent_Find'.
            /// </summary>
            /// <param name="codeEvent">The 'CodeEvent' to use to
            /// get the primary key parameter.</param>
            /// <returns>An instance of an FetchUserStoredProcedure</returns>
            public static FindCodeEventStoredProcedure CreateFindCodeEventStoredProcedure(CodeEvent codeEvent)
            {
                // Initial Value
                FindCodeEventStoredProcedure findCodeEventStoredProcedure = null;

                // verify codeEvent exists
                if(codeEvent != null)
                {
                    // Instanciate findCodeEventStoredProcedure
                    findCodeEventStoredProcedure = new FindCodeEventStoredProcedure();

                    // Now create parameters for this procedure
                    findCodeEventStoredProcedure.Parameters = CreatePrimaryKeyParameter(codeEvent);
                }

                // return value
                return findCodeEventStoredProcedure;
            }
            #endregion

            #region CreateInsertParameters(CodeEvent codeEvent)
            /// <summary>
            /// This method creates the sql Parameters[] needed for
            /// inserting a new codeEvent.
            /// </summary>
            /// <param name="codeEvent">The 'CodeEvent' to insert.</param>
            /// <returns></returns>
            internal static SqlParameter[] CreateInsertParameters(CodeEvent codeEvent)
            {
                // Initial Values
                SqlParameter[] parameters = new SqlParameter[6];
                SqlParameter param = null;

                // verify codeEventexists
                if(codeEvent != null)
                {
                    // Create [CodeFileId] parameter
                    param = new SqlParameter("@CodeFileId", codeEvent.CodeFileId);

                    // set parameters[0]
                    parameters[0] = param;

                    // Create [Description] parameter
                    param = new SqlParameter("@Description", codeEvent.Description);

                    // set parameters[1]
                    parameters[1] = param;

                    // Create [EndLineNumber] parameter
                    param = new SqlParameter("@EndLineNumber", codeEvent.EndLineNumber);

                    // set parameters[2]
                    parameters[2] = param;

                    // Create [Name] parameter
                    param = new SqlParameter("@Name", codeEvent.Name);

                    // set parameters[3]
                    parameters[3] = param;

                    // Create [StartLineNumber] parameter
                    param = new SqlParameter("@StartLineNumber", codeEvent.StartLineNumber);

                    // set parameters[4]
                    parameters[4] = param;

                    // Create [Status] parameter
                    param = new SqlParameter("@Status", codeEvent.Status);

                    // set parameters[5]
                    parameters[5] = param;
                }

                // return value
                return parameters;
            }
            #endregion

            #region CreateInsertCodeEventStoredProcedure(CodeEvent codeEvent)
            /// <summary>
            /// This method creates an instance of an
            /// 'InsertCodeEventStoredProcedure' object and
            /// creates the sql parameter[] array needed
            /// to execute the procedure 'CodeEvent_Insert'.
            /// </summary>
            /// <param name="codeEvent"The 'CodeEvent' object to insert</param>
            /// <returns>An instance of a 'InsertCodeEventStoredProcedure' object.</returns>
            public static InsertCodeEventStoredProcedure CreateInsertCodeEventStoredProcedure(CodeEvent codeEvent)
            {
                // Initial Value
                InsertCodeEventStoredProcedure insertCodeEventStoredProcedure = null;

                // verify codeEvent exists
                if(codeEvent != null)
                {
                    // Instanciate insertCodeEventStoredProcedure
                    insertCodeEventStoredProcedure = new InsertCodeEventStoredProcedure();

                    // Now create parameters for this procedure
                    insertCodeEventStoredProcedure.Parameters = CreateInsertParameters(codeEvent);
                }

                // return value
                return insertCodeEventStoredProcedure;
            }
            #endregion

            #region CreateUpdateParameters(CodeEvent codeEvent)
            /// <summary>
            /// This method creates the sql Parameters[] needed for
            /// update an existing codeEvent.
            /// </summary>
            /// <param name="codeEvent">The 'CodeEvent' to update.</param>
            /// <returns></returns>
            internal static SqlParameter[] CreateUpdateParameters(CodeEvent codeEvent)
            {
                // Initial Values
                SqlParameter[] parameters = new SqlParameter[7];
                SqlParameter param = null;

                // verify codeEventexists
                if(codeEvent != null)
                {
                    // Create parameter for [CodeFileId]
                    param = new SqlParameter("@CodeFileId", codeEvent.CodeFileId);

                    // set parameters[0]
                    parameters[0] = param;

                    // Create parameter for [Description]
                    param = new SqlParameter("@Description", codeEvent.Description);

                    // set parameters[1]
                    parameters[1] = param;

                    // Create parameter for [EndLineNumber]
                    param = new SqlParameter("@EndLineNumber", codeEvent.EndLineNumber);

                    // set parameters[2]
                    parameters[2] = param;

                    // Create parameter for [Name]
                    param = new SqlParameter("@Name", codeEvent.Name);

                    // set parameters[3]
                    parameters[3] = param;

                    // Create parameter for [StartLineNumber]
                    param = new SqlParameter("@StartLineNumber", codeEvent.StartLineNumber);

                    // set parameters[4]
                    parameters[4] = param;

                    // Create parameter for [Status]
                    param = new SqlParameter("@Status", codeEvent.Status);

                    // set parameters[5]
                    parameters[5] = param;

                    // Create parameter for [Id]
                    param = new SqlParameter("@Id", codeEvent.Id);
                    parameters[6] = param;
                }

                // return value
                return parameters;
            }
            #endregion

            #region CreateUpdateCodeEventStoredProcedure(CodeEvent codeEvent)
            /// <summary>
            /// This method creates an instance of an
            /// 'UpdateCodeEventStoredProcedure' object and
            /// creates the sql parameter[] array needed
            /// to execute the procedure 'CodeEvent_Update'.
            /// </summary>
            /// <param name="codeEvent"The 'CodeEvent' object to update</param>
            /// <returns>An instance of a 'UpdateCodeEventStoredProcedure</returns>
            public static UpdateCodeEventStoredProcedure CreateUpdateCodeEventStoredProcedure(CodeEvent codeEvent)
            {
                // Initial Value
                UpdateCodeEventStoredProcedure updateCodeEventStoredProcedure = null;

                // verify codeEvent exists
                if(codeEvent != null)
                {
                    // Instanciate updateCodeEventStoredProcedure
                    updateCodeEventStoredProcedure = new UpdateCodeEventStoredProcedure();

                    // Now create parameters for this procedure
                    updateCodeEventStoredProcedure.Parameters = CreateUpdateParameters(codeEvent);
                }

                // return value
                return updateCodeEventStoredProcedure;
            }
            #endregion

            #region CreateFetchAllCodeEventsStoredProcedure(CodeEvent codeEvent)
            /// <summary>
            /// This method creates an instance of a
            /// 'FetchAllCodeEventsStoredProcedure' object and
            /// creates the sql parameter[] array needed
            /// to execute the procedure 'CodeEvent_FetchAll'.
            /// </summary>
            /// <returns>An instance of a(n) 'FetchAllCodeEventsStoredProcedure' object.</returns>
            public static FetchAllCodeEventsStoredProcedure CreateFetchAllCodeEventsStoredProcedure(CodeEvent codeEvent)
            {
                // Initial value
                FetchAllCodeEventsStoredProcedure fetchAllCodeEventsStoredProcedure = new FetchAllCodeEventsStoredProcedure();

                // return value
                return fetchAllCodeEventsStoredProcedure;
            }
            #endregion

        #endregion

    }
    #endregion

}
