

#region using statements

using DataJuggler.DocGen.DataAccessComponent.StoredProcedureManager.DeleteProcedures;
using DataJuggler.DocGen.DataAccessComponent.StoredProcedureManager.FetchProcedures;
using DataJuggler.DocGen.DataAccessComponent.StoredProcedureManager.InsertProcedures;
using DataJuggler.DocGen.DataAccessComponent.StoredProcedureManager.UpdateProcedures;
using DataJuggler.DocGen.ObjectLibrary.BusinessObjects;
using Microsoft.Data.SqlClient;
using System;
using System.Data;

#endregion


namespace DataJuggler.DocGen.DataAccessComponent.Data.Writers
{

    #region class CodeMethodWriterBase
    /// <summary>
    /// This class is used for converting a 'CodeMethod' object to
    /// the SqlParameter[] to perform the CRUD methods.
    /// </summary>
    public class CodeMethodWriterBase
    {

        #region Static Methods

            #region CreatePrimaryKeyParameter(CodeMethod codeMethod)
            /// <summary>
            /// This method creates the sql Parameter[] array
            /// that holds the primary key value.
            /// </summary>
            /// <param name='codeMethod'>The 'CodeMethod' to get the primary key of.</param>
            /// <returns>A SqlParameter[] array which contains the primary key value.
            /// to delete.</returns>
            internal static SqlParameter[] CreatePrimaryKeyParameter(CodeMethod codeMethod)
            {
                // Initial Value
                SqlParameter[] parameters = new SqlParameter[1];

                // verify user exists
                if (codeMethod != null)
                {
                    // Create PrimaryKey Parameter
                    SqlParameter @Id = new SqlParameter("@Id", codeMethod.Id);

                    // Set parameters[0] to @Id
                    parameters[0] = @Id;
                }

                // return value
                return parameters;
            }
            #endregion

            #region CreateDeleteCodeMethodStoredProcedure(CodeMethod codeMethod)
            /// <summary>
            /// This method creates an instance of an
            /// 'DeleteCodeMethod'StoredProcedure' object and
            /// creates the sql parameter[] array needed
            /// to execute the procedure 'CodeMethod_Delete'.
            /// </summary>
            /// <param name="codeMethod">The 'CodeMethod' to Delete.</param>
            /// <returns>An instance of a 'DeleteCodeMethodStoredProcedure' object.</returns>
            public static DeleteCodeMethodStoredProcedure CreateDeleteCodeMethodStoredProcedure(CodeMethod codeMethod)
            {
                // Initial Value
                DeleteCodeMethodStoredProcedure deleteCodeMethodStoredProcedure = new DeleteCodeMethodStoredProcedure();

                // Now Create Parameters For The DeleteProc
                deleteCodeMethodStoredProcedure.Parameters = CreatePrimaryKeyParameter(codeMethod);

                // return value
                return deleteCodeMethodStoredProcedure;
            }
            #endregion

            #region CreateFindCodeMethodStoredProcedure(CodeMethod codeMethod)
            /// <summary>
            /// This method creates an instance of a
            /// 'FindCodeMethodStoredProcedure' object and
            /// creates the sql parameter[] array needed
            /// to execute the procedure 'CodeMethod_Find'.
            /// </summary>
            /// <param name="codeMethod">The 'CodeMethod' to use to
            /// get the primary key parameter.</param>
            /// <returns>An instance of an FetchUserStoredProcedure</returns>
            public static FindCodeMethodStoredProcedure CreateFindCodeMethodStoredProcedure(CodeMethod codeMethod)
            {
                // Initial Value
                FindCodeMethodStoredProcedure findCodeMethodStoredProcedure = null;

                // verify codeMethod exists
                if(codeMethod != null)
                {
                    // Instanciate findCodeMethodStoredProcedure
                    findCodeMethodStoredProcedure = new FindCodeMethodStoredProcedure();

                    // Now create parameters for this procedure
                    findCodeMethodStoredProcedure.Parameters = CreatePrimaryKeyParameter(codeMethod);
                }

                // return value
                return findCodeMethodStoredProcedure;
            }
            #endregion

            #region CreateInsertParameters(CodeMethod codeMethod)
            /// <summary>
            /// This method creates the sql Parameters[] needed for
            /// inserting a new codeMethod.
            /// </summary>
            /// <param name="codeMethod">The 'CodeMethod' to insert.</param>
            /// <returns></returns>
            internal static SqlParameter[] CreateInsertParameters(CodeMethod codeMethod)
            {
                // Initial Values
                SqlParameter[] parameters = new SqlParameter[12];
                SqlParameter param = null;

                // verify codeMethodexists
                if(codeMethod != null)
                {
                    // Create [CodeClassId] parameter
                    param = new SqlParameter("@CodeClassId", codeMethod.CodeClassId);

                    // set parameters[0]
                    parameters[0] = param;

                    // Create [CodeFileId] parameter
                    param = new SqlParameter("@CodeFileId", codeMethod.CodeFileId);

                    // set parameters[1]
                    parameters[1] = param;

                    // Create [Description] parameter
                    param = new SqlParameter("@Description", codeMethod.Description);

                    // set parameters[2]
                    parameters[2] = param;

                    // Create [EndLineNumber] parameter
                    param = new SqlParameter("@EndLineNumber", codeMethod.EndLineNumber);

                    // set parameters[3]
                    parameters[3] = param;

                    // Create [IsAsync] parameter
                    param = new SqlParameter("@IsAsync", codeMethod.IsAsync);

                    // set parameters[4]
                    parameters[4] = param;

                    // Create [IsEventHandler] parameter
                    param = new SqlParameter("@IsEventHandler", codeMethod.IsEventHandler);

                    // set parameters[5]
                    parameters[5] = param;

                    // Create [Name] parameter
                    param = new SqlParameter("@Name", codeMethod.Name);

                    // set parameters[6]
                    parameters[6] = param;

                    // Create [ReferencedByPath] parameter
                    param = new SqlParameter("@ReferencedByPath", codeMethod.ReferencedByPath);

                    // set parameters[7]
                    parameters[7] = param;

                    // Create [ReturnType] parameter
                    param = new SqlParameter("@ReturnType", codeMethod.ReturnType);

                    // set parameters[8]
                    parameters[8] = param;

                    // Create [StartLineNumber] parameter
                    param = new SqlParameter("@StartLineNumber", codeMethod.StartLineNumber);

                    // set parameters[9]
                    parameters[9] = param;

                    // Create [Status] parameter
                    param = new SqlParameter("@Status", codeMethod.Status);

                    // set parameters[10]
                    parameters[10] = param;

                    // Create [Visible] parameter
                    param = new SqlParameter("@Visible", codeMethod.Visible);

                    // set parameters[11]
                    parameters[11] = param;
                }

                // return value
                return parameters;
            }
            #endregion

            #region CreateInsertCodeMethodStoredProcedure(CodeMethod codeMethod)
            /// <summary>
            /// This method creates an instance of an
            /// 'InsertCodeMethodStoredProcedure' object and
            /// creates the sql parameter[] array needed
            /// to execute the procedure 'CodeMethod_Insert'.
            /// </summary>
            /// <param name="codeMethod"The 'CodeMethod' object to insert</param>
            /// <returns>An instance of a 'InsertCodeMethodStoredProcedure' object.</returns>
            public static InsertCodeMethodStoredProcedure CreateInsertCodeMethodStoredProcedure(CodeMethod codeMethod)
            {
                // Initial Value
                InsertCodeMethodStoredProcedure insertCodeMethodStoredProcedure = null;

                // verify codeMethod exists
                if(codeMethod != null)
                {
                    // Instanciate insertCodeMethodStoredProcedure
                    insertCodeMethodStoredProcedure = new InsertCodeMethodStoredProcedure();

                    // Now create parameters for this procedure
                    insertCodeMethodStoredProcedure.Parameters = CreateInsertParameters(codeMethod);
                }

                // return value
                return insertCodeMethodStoredProcedure;
            }
            #endregion

            #region CreateUpdateParameters(CodeMethod codeMethod)
            /// <summary>
            /// This method creates the sql Parameters[] needed for
            /// update an existing codeMethod.
            /// </summary>
            /// <param name="codeMethod">The 'CodeMethod' to update.</param>
            /// <returns></returns>
            internal static SqlParameter[] CreateUpdateParameters(CodeMethod codeMethod)
            {
                // Initial Values
                SqlParameter[] parameters = new SqlParameter[13];
                SqlParameter param = null;

                // verify codeMethodexists
                if(codeMethod != null)
                {
                    // Create parameter for [CodeClassId]
                    param = new SqlParameter("@CodeClassId", codeMethod.CodeClassId);

                    // set parameters[0]
                    parameters[0] = param;

                    // Create parameter for [CodeFileId]
                    param = new SqlParameter("@CodeFileId", codeMethod.CodeFileId);

                    // set parameters[1]
                    parameters[1] = param;

                    // Create parameter for [Description]
                    param = new SqlParameter("@Description", codeMethod.Description);

                    // set parameters[2]
                    parameters[2] = param;

                    // Create parameter for [EndLineNumber]
                    param = new SqlParameter("@EndLineNumber", codeMethod.EndLineNumber);

                    // set parameters[3]
                    parameters[3] = param;

                    // Create parameter for [IsAsync]
                    param = new SqlParameter("@IsAsync", codeMethod.IsAsync);

                    // set parameters[4]
                    parameters[4] = param;

                    // Create parameter for [IsEventHandler]
                    param = new SqlParameter("@IsEventHandler", codeMethod.IsEventHandler);

                    // set parameters[5]
                    parameters[5] = param;

                    // Create parameter for [Name]
                    param = new SqlParameter("@Name", codeMethod.Name);

                    // set parameters[6]
                    parameters[6] = param;

                    // Create parameter for [ReferencedByPath]
                    param = new SqlParameter("@ReferencedByPath", codeMethod.ReferencedByPath);

                    // set parameters[7]
                    parameters[7] = param;

                    // Create parameter for [ReturnType]
                    param = new SqlParameter("@ReturnType", codeMethod.ReturnType);

                    // set parameters[8]
                    parameters[8] = param;

                    // Create parameter for [StartLineNumber]
                    param = new SqlParameter("@StartLineNumber", codeMethod.StartLineNumber);

                    // set parameters[9]
                    parameters[9] = param;

                    // Create parameter for [Status]
                    param = new SqlParameter("@Status", codeMethod.Status);

                    // set parameters[10]
                    parameters[10] = param;

                    // Create parameter for [Visible]
                    param = new SqlParameter("@Visible", codeMethod.Visible);

                    // set parameters[11]
                    parameters[11] = param;

                    // Create parameter for [Id]
                    param = new SqlParameter("@Id", codeMethod.Id);
                    parameters[12] = param;
                }

                // return value
                return parameters;
            }
            #endregion

            #region CreateUpdateCodeMethodStoredProcedure(CodeMethod codeMethod)
            /// <summary>
            /// This method creates an instance of an
            /// 'UpdateCodeMethodStoredProcedure' object and
            /// creates the sql parameter[] array needed
            /// to execute the procedure 'CodeMethod_Update'.
            /// </summary>
            /// <param name="codeMethod"The 'CodeMethod' object to update</param>
            /// <returns>An instance of a 'UpdateCodeMethodStoredProcedure</returns>
            public static UpdateCodeMethodStoredProcedure CreateUpdateCodeMethodStoredProcedure(CodeMethod codeMethod)
            {
                // Initial Value
                UpdateCodeMethodStoredProcedure updateCodeMethodStoredProcedure = null;

                // verify codeMethod exists
                if(codeMethod != null)
                {
                    // Instanciate updateCodeMethodStoredProcedure
                    updateCodeMethodStoredProcedure = new UpdateCodeMethodStoredProcedure();

                    // Now create parameters for this procedure
                    updateCodeMethodStoredProcedure.Parameters = CreateUpdateParameters(codeMethod);
                }

                // return value
                return updateCodeMethodStoredProcedure;
            }
            #endregion

            #region CreateFetchAllCodeMethodsStoredProcedure(CodeMethod codeMethod)
            /// <summary>
            /// This method creates an instance of a
            /// 'FetchAllCodeMethodsStoredProcedure' object and
            /// creates the sql parameter[] array needed
            /// to execute the procedure 'CodeMethod_FetchAll'.
            /// </summary>
            /// <returns>An instance of a(n) 'FetchAllCodeMethodsStoredProcedure' object.</returns>
            public static FetchAllCodeMethodsStoredProcedure CreateFetchAllCodeMethodsStoredProcedure(CodeMethod codeMethod)
            {
                // Initial value
                FetchAllCodeMethodsStoredProcedure fetchAllCodeMethodsStoredProcedure = new FetchAllCodeMethodsStoredProcedure();

                // return value
                return fetchAllCodeMethodsStoredProcedure;
            }
            #endregion

        #endregion

    }
    #endregion

}
