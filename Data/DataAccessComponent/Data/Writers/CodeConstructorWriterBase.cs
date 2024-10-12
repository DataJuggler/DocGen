

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

    #region class CodeConstructorWriterBase
    /// <summary>
    /// This class is used for converting a 'CodeConstructor' object to
    /// the SqlParameter[] to perform the CRUD methods.
    /// </summary>
    public class CodeConstructorWriterBase
    {

        #region Static Methods

            #region CreatePrimaryKeyParameter(CodeConstructor codeConstructor)
            /// <summary>
            /// This method creates the sql Parameter[] array
            /// that holds the primary key value.
            /// </summary>
            /// <param name='codeConstructor'>The 'CodeConstructor' to get the primary key of.</param>
            /// <returns>A SqlParameter[] array which contains the primary key value.
            /// to delete.</returns>
            internal static SqlParameter[] CreatePrimaryKeyParameter(CodeConstructor codeConstructor)
            {
                // Initial Value
                SqlParameter[] parameters = new SqlParameter[1];

                // verify user exists
                if (codeConstructor != null)
                {
                    // Create PrimaryKey Parameter
                    SqlParameter @Id = new SqlParameter("@Id", codeConstructor.Id);

                    // Set parameters[0] to @Id
                    parameters[0] = @Id;
                }

                // return value
                return parameters;
            }
            #endregion

            #region CreateDeleteCodeConstructorStoredProcedure(CodeConstructor codeConstructor)
            /// <summary>
            /// This method creates an instance of an
            /// 'DeleteCodeConstructor'StoredProcedure' object and
            /// creates the sql parameter[] array needed
            /// to execute the procedure 'CodeConstructor_Delete'.
            /// </summary>
            /// <param name="codeConstructor">The 'CodeConstructor' to Delete.</param>
            /// <returns>An instance of a 'DeleteCodeConstructorStoredProcedure' object.</returns>
            public static DeleteCodeConstructorStoredProcedure CreateDeleteCodeConstructorStoredProcedure(CodeConstructor codeConstructor)
            {
                // Initial Value
                DeleteCodeConstructorStoredProcedure deleteCodeConstructorStoredProcedure = new DeleteCodeConstructorStoredProcedure();

                // Now Create Parameters For The DeleteProc
                deleteCodeConstructorStoredProcedure.Parameters = CreatePrimaryKeyParameter(codeConstructor);

                // return value
                return deleteCodeConstructorStoredProcedure;
            }
            #endregion

            #region CreateFindCodeConstructorStoredProcedure(CodeConstructor codeConstructor)
            /// <summary>
            /// This method creates an instance of a
            /// 'FindCodeConstructorStoredProcedure' object and
            /// creates the sql parameter[] array needed
            /// to execute the procedure 'CodeConstructor_Find'.
            /// </summary>
            /// <param name="codeConstructor">The 'CodeConstructor' to use to
            /// get the primary key parameter.</param>
            /// <returns>An instance of an FetchUserStoredProcedure</returns>
            public static FindCodeConstructorStoredProcedure CreateFindCodeConstructorStoredProcedure(CodeConstructor codeConstructor)
            {
                // Initial Value
                FindCodeConstructorStoredProcedure findCodeConstructorStoredProcedure = null;

                // verify codeConstructor exists
                if(codeConstructor != null)
                {
                    // Instanciate findCodeConstructorStoredProcedure
                    findCodeConstructorStoredProcedure = new FindCodeConstructorStoredProcedure();

                    // Now create parameters for this procedure
                    findCodeConstructorStoredProcedure.Parameters = CreatePrimaryKeyParameter(codeConstructor);
                }

                // return value
                return findCodeConstructorStoredProcedure;
            }
            #endregion

            #region CreateInsertParameters(CodeConstructor codeConstructor)
            /// <summary>
            /// This method creates the sql Parameters[] needed for
            /// inserting a new codeConstructor.
            /// </summary>
            /// <param name="codeConstructor">The 'CodeConstructor' to insert.</param>
            /// <returns></returns>
            internal static SqlParameter[] CreateInsertParameters(CodeConstructor codeConstructor)
            {
                // Initial Values
                SqlParameter[] parameters = new SqlParameter[9];
                SqlParameter param = null;

                // verify codeConstructorexists
                if(codeConstructor != null)
                {
                    // Create [CodeClassId] parameter
                    param = new SqlParameter("@CodeClassId", codeConstructor.CodeClassId);

                    // set parameters[0]
                    parameters[0] = param;

                    // Create [CodeFileId] parameter
                    param = new SqlParameter("@CodeFileId", codeConstructor.CodeFileId);

                    // set parameters[1]
                    parameters[1] = param;

                    // Create [Description] parameter
                    param = new SqlParameter("@Description", codeConstructor.Description);

                    // set parameters[2]
                    parameters[2] = param;

                    // Create [EndLineNumber] parameter
                    param = new SqlParameter("@EndLineNumber", codeConstructor.EndLineNumber);

                    // set parameters[3]
                    parameters[3] = param;

                    // Create [Name] parameter
                    param = new SqlParameter("@Name", codeConstructor.Name);

                    // set parameters[4]
                    parameters[4] = param;

                    // Create [ReferencedByPath] parameter
                    param = new SqlParameter("@ReferencedByPath", codeConstructor.ReferencedByPath);

                    // set parameters[5]
                    parameters[5] = param;

                    // Create [ReturnType] parameter
                    param = new SqlParameter("@ReturnType", codeConstructor.ReturnType);

                    // set parameters[6]
                    parameters[6] = param;

                    // Create [StartLineNumber] parameter
                    param = new SqlParameter("@StartLineNumber", codeConstructor.StartLineNumber);

                    // set parameters[7]
                    parameters[7] = param;

                    // Create [Status] parameter
                    param = new SqlParameter("@Status", codeConstructor.Status);

                    // set parameters[8]
                    parameters[8] = param;
                }

                // return value
                return parameters;
            }
            #endregion

            #region CreateInsertCodeConstructorStoredProcedure(CodeConstructor codeConstructor)
            /// <summary>
            /// This method creates an instance of an
            /// 'InsertCodeConstructorStoredProcedure' object and
            /// creates the sql parameter[] array needed
            /// to execute the procedure 'CodeConstructor_Insert'.
            /// </summary>
            /// <param name="codeConstructor"The 'CodeConstructor' object to insert</param>
            /// <returns>An instance of a 'InsertCodeConstructorStoredProcedure' object.</returns>
            public static InsertCodeConstructorStoredProcedure CreateInsertCodeConstructorStoredProcedure(CodeConstructor codeConstructor)
            {
                // Initial Value
                InsertCodeConstructorStoredProcedure insertCodeConstructorStoredProcedure = null;

                // verify codeConstructor exists
                if(codeConstructor != null)
                {
                    // Instanciate insertCodeConstructorStoredProcedure
                    insertCodeConstructorStoredProcedure = new InsertCodeConstructorStoredProcedure();

                    // Now create parameters for this procedure
                    insertCodeConstructorStoredProcedure.Parameters = CreateInsertParameters(codeConstructor);
                }

                // return value
                return insertCodeConstructorStoredProcedure;
            }
            #endregion

            #region CreateUpdateParameters(CodeConstructor codeConstructor)
            /// <summary>
            /// This method creates the sql Parameters[] needed for
            /// update an existing codeConstructor.
            /// </summary>
            /// <param name="codeConstructor">The 'CodeConstructor' to update.</param>
            /// <returns></returns>
            internal static SqlParameter[] CreateUpdateParameters(CodeConstructor codeConstructor)
            {
                // Initial Values
                SqlParameter[] parameters = new SqlParameter[10];
                SqlParameter param = null;

                // verify codeConstructorexists
                if(codeConstructor != null)
                {
                    // Create parameter for [CodeClassId]
                    param = new SqlParameter("@CodeClassId", codeConstructor.CodeClassId);

                    // set parameters[0]
                    parameters[0] = param;

                    // Create parameter for [CodeFileId]
                    param = new SqlParameter("@CodeFileId", codeConstructor.CodeFileId);

                    // set parameters[1]
                    parameters[1] = param;

                    // Create parameter for [Description]
                    param = new SqlParameter("@Description", codeConstructor.Description);

                    // set parameters[2]
                    parameters[2] = param;

                    // Create parameter for [EndLineNumber]
                    param = new SqlParameter("@EndLineNumber", codeConstructor.EndLineNumber);

                    // set parameters[3]
                    parameters[3] = param;

                    // Create parameter for [Name]
                    param = new SqlParameter("@Name", codeConstructor.Name);

                    // set parameters[4]
                    parameters[4] = param;

                    // Create parameter for [ReferencedByPath]
                    param = new SqlParameter("@ReferencedByPath", codeConstructor.ReferencedByPath);

                    // set parameters[5]
                    parameters[5] = param;

                    // Create parameter for [ReturnType]
                    param = new SqlParameter("@ReturnType", codeConstructor.ReturnType);

                    // set parameters[6]
                    parameters[6] = param;

                    // Create parameter for [StartLineNumber]
                    param = new SqlParameter("@StartLineNumber", codeConstructor.StartLineNumber);

                    // set parameters[7]
                    parameters[7] = param;

                    // Create parameter for [Status]
                    param = new SqlParameter("@Status", codeConstructor.Status);

                    // set parameters[8]
                    parameters[8] = param;

                    // Create parameter for [Id]
                    param = new SqlParameter("@Id", codeConstructor.Id);
                    parameters[9] = param;
                }

                // return value
                return parameters;
            }
            #endregion

            #region CreateUpdateCodeConstructorStoredProcedure(CodeConstructor codeConstructor)
            /// <summary>
            /// This method creates an instance of an
            /// 'UpdateCodeConstructorStoredProcedure' object and
            /// creates the sql parameter[] array needed
            /// to execute the procedure 'CodeConstructor_Update'.
            /// </summary>
            /// <param name="codeConstructor"The 'CodeConstructor' object to update</param>
            /// <returns>An instance of a 'UpdateCodeConstructorStoredProcedure</returns>
            public static UpdateCodeConstructorStoredProcedure CreateUpdateCodeConstructorStoredProcedure(CodeConstructor codeConstructor)
            {
                // Initial Value
                UpdateCodeConstructorStoredProcedure updateCodeConstructorStoredProcedure = null;

                // verify codeConstructor exists
                if(codeConstructor != null)
                {
                    // Instanciate updateCodeConstructorStoredProcedure
                    updateCodeConstructorStoredProcedure = new UpdateCodeConstructorStoredProcedure();

                    // Now create parameters for this procedure
                    updateCodeConstructorStoredProcedure.Parameters = CreateUpdateParameters(codeConstructor);
                }

                // return value
                return updateCodeConstructorStoredProcedure;
            }
            #endregion

            #region CreateFetchAllCodeConstructorsStoredProcedure(CodeConstructor codeConstructor)
            /// <summary>
            /// This method creates an instance of a
            /// 'FetchAllCodeConstructorsStoredProcedure' object and
            /// creates the sql parameter[] array needed
            /// to execute the procedure 'CodeConstructor_FetchAll'.
            /// </summary>
            /// <returns>An instance of a(n) 'FetchAllCodeConstructorsStoredProcedure' object.</returns>
            public static FetchAllCodeConstructorsStoredProcedure CreateFetchAllCodeConstructorsStoredProcedure(CodeConstructor codeConstructor)
            {
                // Initial value
                FetchAllCodeConstructorsStoredProcedure fetchAllCodeConstructorsStoredProcedure = new FetchAllCodeConstructorsStoredProcedure();

                // return value
                return fetchAllCodeConstructorsStoredProcedure;
            }
            #endregion

        #endregion

    }
    #endregion

}
