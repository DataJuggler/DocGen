

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

    #region class CodeClassWriterBase
    /// <summary>
    /// This class is used for converting a 'CodeClass' object to
    /// the SqlParameter[] to perform the CRUD methods.
    /// </summary>
    public class CodeClassWriterBase
    {

        #region Static Methods

            #region CreatePrimaryKeyParameter(CodeClass codeClass)
            /// <summary>
            /// This method creates the sql Parameter[] array
            /// that holds the primary key value.
            /// </summary>
            /// <param name='codeClass'>The 'CodeClass' to get the primary key of.</param>
            /// <returns>A SqlParameter[] array which contains the primary key value.
            /// to delete.</returns>
            internal static SqlParameter[] CreatePrimaryKeyParameter(CodeClass codeClass)
            {
                // Initial Value
                SqlParameter[] parameters = new SqlParameter[1];

                // verify user exists
                if (codeClass != null)
                {
                    // Create PrimaryKey Parameter
                    SqlParameter @Id = new SqlParameter("@Id", codeClass.Id);

                    // Set parameters[0] to @Id
                    parameters[0] = @Id;
                }

                // return value
                return parameters;
            }
            #endregion

            #region CreateDeleteCodeClassStoredProcedure(CodeClass codeClass)
            /// <summary>
            /// This method creates an instance of an
            /// 'DeleteCodeClass'StoredProcedure' object and
            /// creates the sql parameter[] array needed
            /// to execute the procedure 'CodeClass_Delete'.
            /// </summary>
            /// <param name="codeClass">The 'CodeClass' to Delete.</param>
            /// <returns>An instance of a 'DeleteCodeClassStoredProcedure' object.</returns>
            public static DeleteCodeClassStoredProcedure CreateDeleteCodeClassStoredProcedure(CodeClass codeClass)
            {
                // Initial Value
                DeleteCodeClassStoredProcedure deleteCodeClassStoredProcedure = new DeleteCodeClassStoredProcedure();

                // Now Create Parameters For The DeleteProc
                deleteCodeClassStoredProcedure.Parameters = CreatePrimaryKeyParameter(codeClass);

                // return value
                return deleteCodeClassStoredProcedure;
            }
            #endregion

            #region CreateFindCodeClassStoredProcedure(CodeClass codeClass)
            /// <summary>
            /// This method creates an instance of a
            /// 'FindCodeClassStoredProcedure' object and
            /// creates the sql parameter[] array needed
            /// to execute the procedure 'CodeClass_Find'.
            /// </summary>
            /// <param name="codeClass">The 'CodeClass' to use to
            /// get the primary key parameter.</param>
            /// <returns>An instance of an FetchUserStoredProcedure</returns>
            public static FindCodeClassStoredProcedure CreateFindCodeClassStoredProcedure(CodeClass codeClass)
            {
                // Initial Value
                FindCodeClassStoredProcedure findCodeClassStoredProcedure = null;

                // verify codeClass exists
                if(codeClass != null)
                {
                    // Instanciate findCodeClassStoredProcedure
                    findCodeClassStoredProcedure = new FindCodeClassStoredProcedure();

                    // Now create parameters for this procedure
                    findCodeClassStoredProcedure.Parameters = CreatePrimaryKeyParameter(codeClass);
                }

                // return value
                return findCodeClassStoredProcedure;
            }
            #endregion

            #region CreateInsertParameters(CodeClass codeClass)
            /// <summary>
            /// This method creates the sql Parameters[] needed for
            /// inserting a new codeClass.
            /// </summary>
            /// <param name="codeClass">The 'CodeClass' to insert.</param>
            /// <returns></returns>
            internal static SqlParameter[] CreateInsertParameters(CodeClass codeClass)
            {
                // Initial Values
                SqlParameter[] parameters = new SqlParameter[7];
                SqlParameter param = null;

                // verify codeClassexists
                if(codeClass != null)
                {
                    // Create [CodeFileId] parameter
                    param = new SqlParameter("@CodeFileId", codeClass.CodeFileId);

                    // set parameters[0]
                    parameters[0] = param;

                    // Create [Description] parameter
                    param = new SqlParameter("@Description", codeClass.Description);

                    // set parameters[1]
                    parameters[1] = param;

                    // Create [IsPartial] parameter
                    param = new SqlParameter("@IsPartial", codeClass.IsPartial);

                    // set parameters[2]
                    parameters[2] = param;

                    // Create [Name] parameter
                    param = new SqlParameter("@Name", codeClass.Name);

                    // set parameters[3]
                    parameters[3] = param;

                    // Create [Status] parameter
                    param = new SqlParameter("@Status", codeClass.Status);

                    // set parameters[4]
                    parameters[4] = param;

                    // Create [Tags] parameter
                    param = new SqlParameter("@Tags", codeClass.Tags);

                    // set parameters[5]
                    parameters[5] = param;

                    // Create [Visible] parameter
                    param = new SqlParameter("@Visible", codeClass.Visible);

                    // set parameters[6]
                    parameters[6] = param;
                }

                // return value
                return parameters;
            }
            #endregion

            #region CreateInsertCodeClassStoredProcedure(CodeClass codeClass)
            /// <summary>
            /// This method creates an instance of an
            /// 'InsertCodeClassStoredProcedure' object and
            /// creates the sql parameter[] array needed
            /// to execute the procedure 'CodeClass_Insert'.
            /// </summary>
            /// <param name="codeClass"The 'CodeClass' object to insert</param>
            /// <returns>An instance of a 'InsertCodeClassStoredProcedure' object.</returns>
            public static InsertCodeClassStoredProcedure CreateInsertCodeClassStoredProcedure(CodeClass codeClass)
            {
                // Initial Value
                InsertCodeClassStoredProcedure insertCodeClassStoredProcedure = null;

                // verify codeClass exists
                if(codeClass != null)
                {
                    // Instanciate insertCodeClassStoredProcedure
                    insertCodeClassStoredProcedure = new InsertCodeClassStoredProcedure();

                    // Now create parameters for this procedure
                    insertCodeClassStoredProcedure.Parameters = CreateInsertParameters(codeClass);
                }

                // return value
                return insertCodeClassStoredProcedure;
            }
            #endregion

            #region CreateUpdateParameters(CodeClass codeClass)
            /// <summary>
            /// This method creates the sql Parameters[] needed for
            /// update an existing codeClass.
            /// </summary>
            /// <param name="codeClass">The 'CodeClass' to update.</param>
            /// <returns></returns>
            internal static SqlParameter[] CreateUpdateParameters(CodeClass codeClass)
            {
                // Initial Values
                SqlParameter[] parameters = new SqlParameter[8];
                SqlParameter param = null;

                // verify codeClassexists
                if(codeClass != null)
                {
                    // Create parameter for [CodeFileId]
                    param = new SqlParameter("@CodeFileId", codeClass.CodeFileId);

                    // set parameters[0]
                    parameters[0] = param;

                    // Create parameter for [Description]
                    param = new SqlParameter("@Description", codeClass.Description);

                    // set parameters[1]
                    parameters[1] = param;

                    // Create parameter for [IsPartial]
                    param = new SqlParameter("@IsPartial", codeClass.IsPartial);

                    // set parameters[2]
                    parameters[2] = param;

                    // Create parameter for [Name]
                    param = new SqlParameter("@Name", codeClass.Name);

                    // set parameters[3]
                    parameters[3] = param;

                    // Create parameter for [Status]
                    param = new SqlParameter("@Status", codeClass.Status);

                    // set parameters[4]
                    parameters[4] = param;

                    // Create parameter for [Tags]
                    param = new SqlParameter("@Tags", codeClass.Tags);

                    // set parameters[5]
                    parameters[5] = param;

                    // Create parameter for [Visible]
                    param = new SqlParameter("@Visible", codeClass.Visible);

                    // set parameters[6]
                    parameters[6] = param;

                    // Create parameter for [Id]
                    param = new SqlParameter("@Id", codeClass.Id);
                    parameters[7] = param;
                }

                // return value
                return parameters;
            }
            #endregion

            #region CreateUpdateCodeClassStoredProcedure(CodeClass codeClass)
            /// <summary>
            /// This method creates an instance of an
            /// 'UpdateCodeClassStoredProcedure' object and
            /// creates the sql parameter[] array needed
            /// to execute the procedure 'CodeClass_Update'.
            /// </summary>
            /// <param name="codeClass"The 'CodeClass' object to update</param>
            /// <returns>An instance of a 'UpdateCodeClassStoredProcedure</returns>
            public static UpdateCodeClassStoredProcedure CreateUpdateCodeClassStoredProcedure(CodeClass codeClass)
            {
                // Initial Value
                UpdateCodeClassStoredProcedure updateCodeClassStoredProcedure = null;

                // verify codeClass exists
                if(codeClass != null)
                {
                    // Instanciate updateCodeClassStoredProcedure
                    updateCodeClassStoredProcedure = new UpdateCodeClassStoredProcedure();

                    // Now create parameters for this procedure
                    updateCodeClassStoredProcedure.Parameters = CreateUpdateParameters(codeClass);
                }

                // return value
                return updateCodeClassStoredProcedure;
            }
            #endregion

            #region CreateFetchAllCodeClassStoredProcedure(CodeClass codeClass)
            /// <summary>
            /// This method creates an instance of a
            /// 'FetchAllCodeClassStoredProcedure' object and
            /// creates the sql parameter[] array needed
            /// to execute the procedure 'CodeClass_FetchAll'.
            /// </summary>
            /// <returns>An instance of a(n) 'FetchAllCodeClassStoredProcedure' object.</returns>
            public static FetchAllCodeClassStoredProcedure CreateFetchAllCodeClassStoredProcedure(CodeClass codeClass)
            {
                // Initial value
                FetchAllCodeClassStoredProcedure fetchAllCodeClassStoredProcedure = new FetchAllCodeClassStoredProcedure();

                // return value
                return fetchAllCodeClassStoredProcedure;
            }
            #endregion

        #endregion

    }
    #endregion

}
