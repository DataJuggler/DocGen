

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

    #region class CodeParameterWriterBase
    /// <summary>
    /// This class is used for converting a 'CodeParameter' object to
    /// the SqlParameter[] to perform the CRUD methods.
    /// </summary>
    public class CodeParameterWriterBase
    {

        #region Static Methods

            #region CreatePrimaryKeyParameter(CodeParameter codeParameter)
            /// <summary>
            /// This method creates the sql Parameter[] array
            /// that holds the primary key value.
            /// </summary>
            /// <param name='codeParameter'>The 'CodeParameter' to get the primary key of.</param>
            /// <returns>A SqlParameter[] array which contains the primary key value.
            /// to delete.</returns>
            internal static SqlParameter[] CreatePrimaryKeyParameter(CodeParameter codeParameter)
            {
                // Initial Value
                SqlParameter[] parameters = new SqlParameter[1];

                // verify user exists
                if (codeParameter != null)
                {
                    // Create PrimaryKey Parameter
                    SqlParameter @Id = new SqlParameter("@Id", codeParameter.Id);

                    // Set parameters[0] to @Id
                    parameters[0] = @Id;
                }

                // return value
                return parameters;
            }
            #endregion

            #region CreateDeleteCodeParameterStoredProcedure(CodeParameter codeParameter)
            /// <summary>
            /// This method creates an instance of an
            /// 'DeleteCodeParameter'StoredProcedure' object and
            /// creates the sql parameter[] array needed
            /// to execute the procedure 'CodeParameter_Delete'.
            /// </summary>
            /// <param name="codeParameter">The 'CodeParameter' to Delete.</param>
            /// <returns>An instance of a 'DeleteCodeParameterStoredProcedure' object.</returns>
            public static DeleteCodeParameterStoredProcedure CreateDeleteCodeParameterStoredProcedure(CodeParameter codeParameter)
            {
                // Initial Value
                DeleteCodeParameterStoredProcedure deleteCodeParameterStoredProcedure = new DeleteCodeParameterStoredProcedure();

                // Now Create Parameters For The DeleteProc
                deleteCodeParameterStoredProcedure.Parameters = CreatePrimaryKeyParameter(codeParameter);

                // return value
                return deleteCodeParameterStoredProcedure;
            }
            #endregion

            #region CreateFindCodeParameterStoredProcedure(CodeParameter codeParameter)
            /// <summary>
            /// This method creates an instance of a
            /// 'FindCodeParameterStoredProcedure' object and
            /// creates the sql parameter[] array needed
            /// to execute the procedure 'CodeParameter_Find'.
            /// </summary>
            /// <param name="codeParameter">The 'CodeParameter' to use to
            /// get the primary key parameter.</param>
            /// <returns>An instance of an FetchUserStoredProcedure</returns>
            public static FindCodeParameterStoredProcedure CreateFindCodeParameterStoredProcedure(CodeParameter codeParameter)
            {
                // Initial Value
                FindCodeParameterStoredProcedure findCodeParameterStoredProcedure = null;

                // verify codeParameter exists
                if(codeParameter != null)
                {
                    // Instanciate findCodeParameterStoredProcedure
                    findCodeParameterStoredProcedure = new FindCodeParameterStoredProcedure();

                    // Now create parameters for this procedure
                    findCodeParameterStoredProcedure.Parameters = CreatePrimaryKeyParameter(codeParameter);
                }

                // return value
                return findCodeParameterStoredProcedure;
            }
            #endregion

            #region CreateInsertParameters(CodeParameter codeParameter)
            /// <summary>
            /// This method creates the sql Parameters[] needed for
            /// inserting a new codeParameter.
            /// </summary>
            /// <param name="codeParameter">The 'CodeParameter' to insert.</param>
            /// <returns></returns>
            internal static SqlParameter[] CreateInsertParameters(CodeParameter codeParameter)
            {
                // Initial Values
                SqlParameter[] parameters = new SqlParameter[6];
                SqlParameter param = null;

                // verify codeParameterexists
                if(codeParameter != null)
                {
                    // Create [CodeEventId] parameter
                    param = new SqlParameter("@CodeEventId", codeParameter.CodeEventId);

                    // set parameters[0]
                    parameters[0] = param;

                    // Create [CodeMethodId] parameter
                    param = new SqlParameter("@CodeMethodId", codeParameter.CodeMethodId);

                    // set parameters[1]
                    parameters[1] = param;

                    // Create [Description] parameter
                    param = new SqlParameter("@Description", codeParameter.Description);

                    // set parameters[2]
                    parameters[2] = param;

                    // Create [IsOptional] parameter
                    param = new SqlParameter("@IsOptional", codeParameter.IsOptional);

                    // set parameters[3]
                    parameters[3] = param;

                    // Create [Name] parameter
                    param = new SqlParameter("@Name", codeParameter.Name);

                    // set parameters[4]
                    parameters[4] = param;

                    // Create [ParameterType] parameter
                    param = new SqlParameter("@ParameterType", codeParameter.ParameterType);

                    // set parameters[5]
                    parameters[5] = param;
                }

                // return value
                return parameters;
            }
            #endregion

            #region CreateInsertCodeParameterStoredProcedure(CodeParameter codeParameter)
            /// <summary>
            /// This method creates an instance of an
            /// 'InsertCodeParameterStoredProcedure' object and
            /// creates the sql parameter[] array needed
            /// to execute the procedure 'CodeParameter_Insert'.
            /// </summary>
            /// <param name="codeParameter"The 'CodeParameter' object to insert</param>
            /// <returns>An instance of a 'InsertCodeParameterStoredProcedure' object.</returns>
            public static InsertCodeParameterStoredProcedure CreateInsertCodeParameterStoredProcedure(CodeParameter codeParameter)
            {
                // Initial Value
                InsertCodeParameterStoredProcedure insertCodeParameterStoredProcedure = null;

                // verify codeParameter exists
                if(codeParameter != null)
                {
                    // Instanciate insertCodeParameterStoredProcedure
                    insertCodeParameterStoredProcedure = new InsertCodeParameterStoredProcedure();

                    // Now create parameters for this procedure
                    insertCodeParameterStoredProcedure.Parameters = CreateInsertParameters(codeParameter);
                }

                // return value
                return insertCodeParameterStoredProcedure;
            }
            #endregion

            #region CreateUpdateParameters(CodeParameter codeParameter)
            /// <summary>
            /// This method creates the sql Parameters[] needed for
            /// update an existing codeParameter.
            /// </summary>
            /// <param name="codeParameter">The 'CodeParameter' to update.</param>
            /// <returns></returns>
            internal static SqlParameter[] CreateUpdateParameters(CodeParameter codeParameter)
            {
                // Initial Values
                SqlParameter[] parameters = new SqlParameter[7];
                SqlParameter param = null;

                // verify codeParameterexists
                if(codeParameter != null)
                {
                    // Create parameter for [CodeEventId]
                    param = new SqlParameter("@CodeEventId", codeParameter.CodeEventId);

                    // set parameters[0]
                    parameters[0] = param;

                    // Create parameter for [CodeMethodId]
                    param = new SqlParameter("@CodeMethodId", codeParameter.CodeMethodId);

                    // set parameters[1]
                    parameters[1] = param;

                    // Create parameter for [Description]
                    param = new SqlParameter("@Description", codeParameter.Description);

                    // set parameters[2]
                    parameters[2] = param;

                    // Create parameter for [IsOptional]
                    param = new SqlParameter("@IsOptional", codeParameter.IsOptional);

                    // set parameters[3]
                    parameters[3] = param;

                    // Create parameter for [Name]
                    param = new SqlParameter("@Name", codeParameter.Name);

                    // set parameters[4]
                    parameters[4] = param;

                    // Create parameter for [ParameterType]
                    param = new SqlParameter("@ParameterType", codeParameter.ParameterType);

                    // set parameters[5]
                    parameters[5] = param;

                    // Create parameter for [Id]
                    param = new SqlParameter("@Id", codeParameter.Id);
                    parameters[6] = param;
                }

                // return value
                return parameters;
            }
            #endregion

            #region CreateUpdateCodeParameterStoredProcedure(CodeParameter codeParameter)
            /// <summary>
            /// This method creates an instance of an
            /// 'UpdateCodeParameterStoredProcedure' object and
            /// creates the sql parameter[] array needed
            /// to execute the procedure 'CodeParameter_Update'.
            /// </summary>
            /// <param name="codeParameter"The 'CodeParameter' object to update</param>
            /// <returns>An instance of a 'UpdateCodeParameterStoredProcedure</returns>
            public static UpdateCodeParameterStoredProcedure CreateUpdateCodeParameterStoredProcedure(CodeParameter codeParameter)
            {
                // Initial Value
                UpdateCodeParameterStoredProcedure updateCodeParameterStoredProcedure = null;

                // verify codeParameter exists
                if(codeParameter != null)
                {
                    // Instanciate updateCodeParameterStoredProcedure
                    updateCodeParameterStoredProcedure = new UpdateCodeParameterStoredProcedure();

                    // Now create parameters for this procedure
                    updateCodeParameterStoredProcedure.Parameters = CreateUpdateParameters(codeParameter);
                }

                // return value
                return updateCodeParameterStoredProcedure;
            }
            #endregion

            #region CreateFetchAllCodeParametersStoredProcedure(CodeParameter codeParameter)
            /// <summary>
            /// This method creates an instance of a
            /// 'FetchAllCodeParametersStoredProcedure' object and
            /// creates the sql parameter[] array needed
            /// to execute the procedure 'CodeParameter_FetchAll'.
            /// </summary>
            /// <returns>An instance of a(n) 'FetchAllCodeParametersStoredProcedure' object.</returns>
            public static FetchAllCodeParametersStoredProcedure CreateFetchAllCodeParametersStoredProcedure(CodeParameter codeParameter)
            {
                // Initial value
                FetchAllCodeParametersStoredProcedure fetchAllCodeParametersStoredProcedure = new FetchAllCodeParametersStoredProcedure();

                // return value
                return fetchAllCodeParametersStoredProcedure;
            }
            #endregion

        #endregion

    }
    #endregion

}
