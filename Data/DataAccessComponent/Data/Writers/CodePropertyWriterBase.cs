

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

    #region class CodePropertyWriterBase
    /// <summary>
    /// This class is used for converting a 'CodeProperty' object to
    /// the SqlParameter[] to perform the CRUD methods.
    /// </summary>
    public class CodePropertyWriterBase
    {

        #region Static Methods

            #region CreatePrimaryKeyParameter(CodeProperty codeProperty)
            /// <summary>
            /// This method creates the sql Parameter[] array
            /// that holds the primary key value.
            /// </summary>
            /// <param name='codeProperty'>The 'CodeProperty' to get the primary key of.</param>
            /// <returns>A SqlParameter[] array which contains the primary key value.
            /// to delete.</returns>
            internal static SqlParameter[] CreatePrimaryKeyParameter(CodeProperty codeProperty)
            {
                // Initial Value
                SqlParameter[] parameters = new SqlParameter[1];

                // verify user exists
                if (codeProperty != null)
                {
                    // Create PrimaryKey Parameter
                    SqlParameter @Id = new SqlParameter("@Id", codeProperty.Id);

                    // Set parameters[0] to @Id
                    parameters[0] = @Id;
                }

                // return value
                return parameters;
            }
            #endregion

            #region CreateDeleteCodePropertyStoredProcedure(CodeProperty codeProperty)
            /// <summary>
            /// This method creates an instance of an
            /// 'DeleteCodeProperty'StoredProcedure' object and
            /// creates the sql parameter[] array needed
            /// to execute the procedure 'CodeProperty_Delete'.
            /// </summary>
            /// <param name="codeProperty">The 'CodeProperty' to Delete.</param>
            /// <returns>An instance of a 'DeleteCodePropertyStoredProcedure' object.</returns>
            public static DeleteCodePropertyStoredProcedure CreateDeleteCodePropertyStoredProcedure(CodeProperty codeProperty)
            {
                // Initial Value
                DeleteCodePropertyStoredProcedure deleteCodePropertyStoredProcedure = new DeleteCodePropertyStoredProcedure();

                // Now Create Parameters For The DeleteProc
                deleteCodePropertyStoredProcedure.Parameters = CreatePrimaryKeyParameter(codeProperty);

                // return value
                return deleteCodePropertyStoredProcedure;
            }
            #endregion

            #region CreateFindCodePropertyStoredProcedure(CodeProperty codeProperty)
            /// <summary>
            /// This method creates an instance of a
            /// 'FindCodePropertyStoredProcedure' object and
            /// creates the sql parameter[] array needed
            /// to execute the procedure 'CodeProperty_Find'.
            /// </summary>
            /// <param name="codeProperty">The 'CodeProperty' to use to
            /// get the primary key parameter.</param>
            /// <returns>An instance of an FetchUserStoredProcedure</returns>
            public static FindCodePropertyStoredProcedure CreateFindCodePropertyStoredProcedure(CodeProperty codeProperty)
            {
                // Initial Value
                FindCodePropertyStoredProcedure findCodePropertyStoredProcedure = null;

                // verify codeProperty exists
                if(codeProperty != null)
                {
                    // Instanciate findCodePropertyStoredProcedure
                    findCodePropertyStoredProcedure = new FindCodePropertyStoredProcedure();

                    // Now create parameters for this procedure
                    findCodePropertyStoredProcedure.Parameters = CreatePrimaryKeyParameter(codeProperty);
                }

                // return value
                return findCodePropertyStoredProcedure;
            }
            #endregion

            #region CreateInsertParameters(CodeProperty codeProperty)
            /// <summary>
            /// This method creates the sql Parameters[] needed for
            /// inserting a new codeProperty.
            /// </summary>
            /// <param name="codeProperty">The 'CodeProperty' to insert.</param>
            /// <returns></returns>
            internal static SqlParameter[] CreateInsertParameters(CodeProperty codeProperty)
            {
                // Initial Values
                SqlParameter[] parameters = new SqlParameter[10];
                SqlParameter param = null;

                // verify codePropertyexists
                if(codeProperty != null)
                {
                    // Create [CodeClassId] parameter
                    param = new SqlParameter("@CodeClassId", codeProperty.CodeClassId);

                    // set parameters[0]
                    parameters[0] = param;

                    // Create [CodeFileId] parameter
                    param = new SqlParameter("@CodeFileId", codeProperty.CodeFileId);

                    // set parameters[1]
                    parameters[1] = param;

                    // Create [Description] parameter
                    param = new SqlParameter("@Description", codeProperty.Description);

                    // set parameters[2]
                    parameters[2] = param;

                    // Create [EndLineNumber] parameter
                    param = new SqlParameter("@EndLineNumber", codeProperty.EndLineNumber);

                    // set parameters[3]
                    parameters[3] = param;

                    // Create [Name] parameter
                    param = new SqlParameter("@Name", codeProperty.Name);

                    // set parameters[4]
                    parameters[4] = param;

                    // Create [ReturnType] parameter
                    param = new SqlParameter("@ReturnType", codeProperty.ReturnType);

                    // set parameters[5]
                    parameters[5] = param;

                    // Create [StartLineNumber] parameter
                    param = new SqlParameter("@StartLineNumber", codeProperty.StartLineNumber);

                    // set parameters[6]
                    parameters[6] = param;

                    // Create [Status] parameter
                    param = new SqlParameter("@Status", codeProperty.Status);

                    // set parameters[7]
                    parameters[7] = param;

                    // Create [Tags] parameter
                    param = new SqlParameter("@Tags", codeProperty.Tags);

                    // set parameters[8]
                    parameters[8] = param;

                    // Create [Visible] parameter
                    param = new SqlParameter("@Visible", codeProperty.Visible);

                    // set parameters[9]
                    parameters[9] = param;
                }

                // return value
                return parameters;
            }
            #endregion

            #region CreateInsertCodePropertyStoredProcedure(CodeProperty codeProperty)
            /// <summary>
            /// This method creates an instance of an
            /// 'InsertCodePropertyStoredProcedure' object and
            /// creates the sql parameter[] array needed
            /// to execute the procedure 'CodeProperty_Insert'.
            /// </summary>
            /// <param name="codeProperty"The 'CodeProperty' object to insert</param>
            /// <returns>An instance of a 'InsertCodePropertyStoredProcedure' object.</returns>
            public static InsertCodePropertyStoredProcedure CreateInsertCodePropertyStoredProcedure(CodeProperty codeProperty)
            {
                // Initial Value
                InsertCodePropertyStoredProcedure insertCodePropertyStoredProcedure = null;

                // verify codeProperty exists
                if(codeProperty != null)
                {
                    // Instanciate insertCodePropertyStoredProcedure
                    insertCodePropertyStoredProcedure = new InsertCodePropertyStoredProcedure();

                    // Now create parameters for this procedure
                    insertCodePropertyStoredProcedure.Parameters = CreateInsertParameters(codeProperty);
                }

                // return value
                return insertCodePropertyStoredProcedure;
            }
            #endregion

            #region CreateUpdateParameters(CodeProperty codeProperty)
            /// <summary>
            /// This method creates the sql Parameters[] needed for
            /// update an existing codeProperty.
            /// </summary>
            /// <param name="codeProperty">The 'CodeProperty' to update.</param>
            /// <returns></returns>
            internal static SqlParameter[] CreateUpdateParameters(CodeProperty codeProperty)
            {
                // Initial Values
                SqlParameter[] parameters = new SqlParameter[11];
                SqlParameter param = null;

                // verify codePropertyexists
                if(codeProperty != null)
                {
                    // Create parameter for [CodeClassId]
                    param = new SqlParameter("@CodeClassId", codeProperty.CodeClassId);

                    // set parameters[0]
                    parameters[0] = param;

                    // Create parameter for [CodeFileId]
                    param = new SqlParameter("@CodeFileId", codeProperty.CodeFileId);

                    // set parameters[1]
                    parameters[1] = param;

                    // Create parameter for [Description]
                    param = new SqlParameter("@Description", codeProperty.Description);

                    // set parameters[2]
                    parameters[2] = param;

                    // Create parameter for [EndLineNumber]
                    param = new SqlParameter("@EndLineNumber", codeProperty.EndLineNumber);

                    // set parameters[3]
                    parameters[3] = param;

                    // Create parameter for [Name]
                    param = new SqlParameter("@Name", codeProperty.Name);

                    // set parameters[4]
                    parameters[4] = param;

                    // Create parameter for [ReturnType]
                    param = new SqlParameter("@ReturnType", codeProperty.ReturnType);

                    // set parameters[5]
                    parameters[5] = param;

                    // Create parameter for [StartLineNumber]
                    param = new SqlParameter("@StartLineNumber", codeProperty.StartLineNumber);

                    // set parameters[6]
                    parameters[6] = param;

                    // Create parameter for [Status]
                    param = new SqlParameter("@Status", codeProperty.Status);

                    // set parameters[7]
                    parameters[7] = param;

                    // Create parameter for [Tags]
                    param = new SqlParameter("@Tags", codeProperty.Tags);

                    // set parameters[8]
                    parameters[8] = param;

                    // Create parameter for [Visible]
                    param = new SqlParameter("@Visible", codeProperty.Visible);

                    // set parameters[9]
                    parameters[9] = param;

                    // Create parameter for [Id]
                    param = new SqlParameter("@Id", codeProperty.Id);
                    parameters[10] = param;
                }

                // return value
                return parameters;
            }
            #endregion

            #region CreateUpdateCodePropertyStoredProcedure(CodeProperty codeProperty)
            /// <summary>
            /// This method creates an instance of an
            /// 'UpdateCodePropertyStoredProcedure' object and
            /// creates the sql parameter[] array needed
            /// to execute the procedure 'CodeProperty_Update'.
            /// </summary>
            /// <param name="codeProperty"The 'CodeProperty' object to update</param>
            /// <returns>An instance of a 'UpdateCodePropertyStoredProcedure</returns>
            public static UpdateCodePropertyStoredProcedure CreateUpdateCodePropertyStoredProcedure(CodeProperty codeProperty)
            {
                // Initial Value
                UpdateCodePropertyStoredProcedure updateCodePropertyStoredProcedure = null;

                // verify codeProperty exists
                if(codeProperty != null)
                {
                    // Instanciate updateCodePropertyStoredProcedure
                    updateCodePropertyStoredProcedure = new UpdateCodePropertyStoredProcedure();

                    // Now create parameters for this procedure
                    updateCodePropertyStoredProcedure.Parameters = CreateUpdateParameters(codeProperty);
                }

                // return value
                return updateCodePropertyStoredProcedure;
            }
            #endregion

            #region CreateFetchAllCodePropertysStoredProcedure(CodeProperty codeProperty)
            /// <summary>
            /// This method creates an instance of a
            /// 'FetchAllCodePropertysStoredProcedure' object and
            /// creates the sql parameter[] array needed
            /// to execute the procedure 'CodeProperty_FetchAll'.
            /// </summary>
            /// <returns>An instance of a(n) 'FetchAllCodePropertysStoredProcedure' object.</returns>
            public static FetchAllCodePropertysStoredProcedure CreateFetchAllCodePropertysStoredProcedure(CodeProperty codeProperty)
            {
                // Initial value
                FetchAllCodePropertysStoredProcedure fetchAllCodePropertysStoredProcedure = new FetchAllCodePropertysStoredProcedure();

                // return value
                return fetchAllCodePropertysStoredProcedure;
            }
            #endregion

        #endregion

    }
    #endregion

}
