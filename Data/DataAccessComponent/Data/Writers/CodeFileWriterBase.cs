

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

    #region class CodeFileWriterBase
    /// <summary>
    /// This class is used for converting a 'CodeFile' object to
    /// the SqlParameter[] to perform the CRUD methods.
    /// </summary>
    public class CodeFileWriterBase
    {

        #region Static Methods

            #region CreatePrimaryKeyParameter(CodeFile codeFile)
            /// <summary>
            /// This method creates the sql Parameter[] array
            /// that holds the primary key value.
            /// </summary>
            /// <param name='codeFile'>The 'CodeFile' to get the primary key of.</param>
            /// <returns>A SqlParameter[] array which contains the primary key value.
            /// to delete.</returns>
            internal static SqlParameter[] CreatePrimaryKeyParameter(CodeFile codeFile)
            {
                // Initial Value
                SqlParameter[] parameters = new SqlParameter[1];

                // verify user exists
                if (codeFile != null)
                {
                    // Create PrimaryKey Parameter
                    SqlParameter @Id = new SqlParameter("@Id", codeFile.Id);

                    // Set parameters[0] to @Id
                    parameters[0] = @Id;
                }

                // return value
                return parameters;
            }
            #endregion

            #region CreateDeleteCodeFileStoredProcedure(CodeFile codeFile)
            /// <summary>
            /// This method creates an instance of an
            /// 'DeleteCodeFile'StoredProcedure' object and
            /// creates the sql parameter[] array needed
            /// to execute the procedure 'CodeFile_Delete'.
            /// </summary>
            /// <param name="codeFile">The 'CodeFile' to Delete.</param>
            /// <returns>An instance of a 'DeleteCodeFileStoredProcedure' object.</returns>
            public static DeleteCodeFileStoredProcedure CreateDeleteCodeFileStoredProcedure(CodeFile codeFile)
            {
                // Initial Value
                DeleteCodeFileStoredProcedure deleteCodeFileStoredProcedure = new DeleteCodeFileStoredProcedure();

                // Now Create Parameters For The DeleteProc
                deleteCodeFileStoredProcedure.Parameters = CreatePrimaryKeyParameter(codeFile);

                // return value
                return deleteCodeFileStoredProcedure;
            }
            #endregion

            #region CreateFindCodeFileStoredProcedure(CodeFile codeFile)
            /// <summary>
            /// This method creates an instance of a
            /// 'FindCodeFileStoredProcedure' object and
            /// creates the sql parameter[] array needed
            /// to execute the procedure 'CodeFile_Find'.
            /// </summary>
            /// <param name="codeFile">The 'CodeFile' to use to
            /// get the primary key parameter.</param>
            /// <returns>An instance of an FetchUserStoredProcedure</returns>
            public static FindCodeFileStoredProcedure CreateFindCodeFileStoredProcedure(CodeFile codeFile)
            {
                // Initial Value
                FindCodeFileStoredProcedure findCodeFileStoredProcedure = null;

                // verify codeFile exists
                if(codeFile != null)
                {
                    // Instanciate findCodeFileStoredProcedure
                    findCodeFileStoredProcedure = new FindCodeFileStoredProcedure();

                    // Now create parameters for this procedure
                    findCodeFileStoredProcedure.Parameters = CreatePrimaryKeyParameter(codeFile);
                }

                // return value
                return findCodeFileStoredProcedure;
            }
            #endregion

            #region CreateInsertParameters(CodeFile codeFile)
            /// <summary>
            /// This method creates the sql Parameters[] needed for
            /// inserting a new codeFile.
            /// </summary>
            /// <param name="codeFile">The 'CodeFile' to insert.</param>
            /// <returns></returns>
            internal static SqlParameter[] CreateInsertParameters(CodeFile codeFile)
            {
                // Initial Values
                SqlParameter[] parameters = new SqlParameter[10];
                SqlParameter param = null;

                // verify codeFileexists
                if(codeFile != null)
                {
                    // Create [Description] parameter
                    param = new SqlParameter("@Description", codeFile.Description);

                    // set parameters[0]
                    parameters[0] = param;

                    // Create [EventsCount] parameter
                    param = new SqlParameter("@EventsCount", codeFile.EventsCount);

                    // set parameters[1]
                    parameters[1] = param;

                    // Create [FullPath] parameter
                    param = new SqlParameter("@FullPath", codeFile.FullPath);

                    // set parameters[2]
                    parameters[2] = param;

                    // Create [MethodsCount] parameter
                    param = new SqlParameter("@MethodsCount", codeFile.MethodsCount);

                    // set parameters[3]
                    parameters[3] = param;

                    // Create [Name] parameter
                    param = new SqlParameter("@Name", codeFile.Name);

                    // set parameters[4]
                    parameters[4] = param;

                    // Create [ParentId] parameter
                    param = new SqlParameter("@ParentId", codeFile.ParentId);

                    // set parameters[5]
                    parameters[5] = param;

                    // Create [ProjectId] parameter
                    param = new SqlParameter("@ProjectId", codeFile.ProjectId);

                    // set parameters[6]
                    parameters[6] = param;

                    // Create [PropertiesCount] parameter
                    param = new SqlParameter("@PropertiesCount", codeFile.PropertiesCount);

                    // set parameters[7]
                    parameters[7] = param;

                    // Create [Status] parameter
                    param = new SqlParameter("@Status", codeFile.Status);

                    // set parameters[8]
                    parameters[8] = param;

                    // Create [Visible] parameter
                    param = new SqlParameter("@Visible", codeFile.Visible);

                    // set parameters[9]
                    parameters[9] = param;
                }

                // return value
                return parameters;
            }
            #endregion

            #region CreateInsertCodeFileStoredProcedure(CodeFile codeFile)
            /// <summary>
            /// This method creates an instance of an
            /// 'InsertCodeFileStoredProcedure' object and
            /// creates the sql parameter[] array needed
            /// to execute the procedure 'CodeFile_Insert'.
            /// </summary>
            /// <param name="codeFile"The 'CodeFile' object to insert</param>
            /// <returns>An instance of a 'InsertCodeFileStoredProcedure' object.</returns>
            public static InsertCodeFileStoredProcedure CreateInsertCodeFileStoredProcedure(CodeFile codeFile)
            {
                // Initial Value
                InsertCodeFileStoredProcedure insertCodeFileStoredProcedure = null;

                // verify codeFile exists
                if(codeFile != null)
                {
                    // Instanciate insertCodeFileStoredProcedure
                    insertCodeFileStoredProcedure = new InsertCodeFileStoredProcedure();

                    // Now create parameters for this procedure
                    insertCodeFileStoredProcedure.Parameters = CreateInsertParameters(codeFile);
                }

                // return value
                return insertCodeFileStoredProcedure;
            }
            #endregion

            #region CreateUpdateParameters(CodeFile codeFile)
            /// <summary>
            /// This method creates the sql Parameters[] needed for
            /// update an existing codeFile.
            /// </summary>
            /// <param name="codeFile">The 'CodeFile' to update.</param>
            /// <returns></returns>
            internal static SqlParameter[] CreateUpdateParameters(CodeFile codeFile)
            {
                // Initial Values
                SqlParameter[] parameters = new SqlParameter[11];
                SqlParameter param = null;

                // verify codeFileexists
                if(codeFile != null)
                {
                    // Create parameter for [Description]
                    param = new SqlParameter("@Description", codeFile.Description);

                    // set parameters[0]
                    parameters[0] = param;

                    // Create parameter for [EventsCount]
                    param = new SqlParameter("@EventsCount", codeFile.EventsCount);

                    // set parameters[1]
                    parameters[1] = param;

                    // Create parameter for [FullPath]
                    param = new SqlParameter("@FullPath", codeFile.FullPath);

                    // set parameters[2]
                    parameters[2] = param;

                    // Create parameter for [MethodsCount]
                    param = new SqlParameter("@MethodsCount", codeFile.MethodsCount);

                    // set parameters[3]
                    parameters[3] = param;

                    // Create parameter for [Name]
                    param = new SqlParameter("@Name", codeFile.Name);

                    // set parameters[4]
                    parameters[4] = param;

                    // Create parameter for [ParentId]
                    param = new SqlParameter("@ParentId", codeFile.ParentId);

                    // set parameters[5]
                    parameters[5] = param;

                    // Create parameter for [ProjectId]
                    param = new SqlParameter("@ProjectId", codeFile.ProjectId);

                    // set parameters[6]
                    parameters[6] = param;

                    // Create parameter for [PropertiesCount]
                    param = new SqlParameter("@PropertiesCount", codeFile.PropertiesCount);

                    // set parameters[7]
                    parameters[7] = param;

                    // Create parameter for [Status]
                    param = new SqlParameter("@Status", codeFile.Status);

                    // set parameters[8]
                    parameters[8] = param;

                    // Create parameter for [Visible]
                    param = new SqlParameter("@Visible", codeFile.Visible);

                    // set parameters[9]
                    parameters[9] = param;

                    // Create parameter for [Id]
                    param = new SqlParameter("@Id", codeFile.Id);
                    parameters[10] = param;
                }

                // return value
                return parameters;
            }
            #endregion

            #region CreateUpdateCodeFileStoredProcedure(CodeFile codeFile)
            /// <summary>
            /// This method creates an instance of an
            /// 'UpdateCodeFileStoredProcedure' object and
            /// creates the sql parameter[] array needed
            /// to execute the procedure 'CodeFile_Update'.
            /// </summary>
            /// <param name="codeFile"The 'CodeFile' object to update</param>
            /// <returns>An instance of a 'UpdateCodeFileStoredProcedure</returns>
            public static UpdateCodeFileStoredProcedure CreateUpdateCodeFileStoredProcedure(CodeFile codeFile)
            {
                // Initial Value
                UpdateCodeFileStoredProcedure updateCodeFileStoredProcedure = null;

                // verify codeFile exists
                if(codeFile != null)
                {
                    // Instanciate updateCodeFileStoredProcedure
                    updateCodeFileStoredProcedure = new UpdateCodeFileStoredProcedure();

                    // Now create parameters for this procedure
                    updateCodeFileStoredProcedure.Parameters = CreateUpdateParameters(codeFile);
                }

                // return value
                return updateCodeFileStoredProcedure;
            }
            #endregion

            #region CreateFetchAllCodeFilesStoredProcedure(CodeFile codeFile)
            /// <summary>
            /// This method creates an instance of a
            /// 'FetchAllCodeFilesStoredProcedure' object and
            /// creates the sql parameter[] array needed
            /// to execute the procedure 'CodeFile_FetchAll'.
            /// </summary>
            /// <returns>An instance of a(n) 'FetchAllCodeFilesStoredProcedure' object.</returns>
            public static FetchAllCodeFilesStoredProcedure CreateFetchAllCodeFilesStoredProcedure(CodeFile codeFile)
            {
                // Initial value
                FetchAllCodeFilesStoredProcedure fetchAllCodeFilesStoredProcedure = new FetchAllCodeFilesStoredProcedure();

                // return value
                return fetchAllCodeFilesStoredProcedure;
            }
            #endregion

        #endregion

    }
    #endregion

}
