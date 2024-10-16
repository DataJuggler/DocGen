

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

    #region class CodeSampleWriterBase
    /// <summary>
    /// This class is used for converting a 'CodeSample' object to
    /// the SqlParameter[] to perform the CRUD methods.
    /// </summary>
    public class CodeSampleWriterBase
    {

        #region Static Methods

            #region CreatePrimaryKeyParameter(CodeSample codeSample)
            /// <summary>
            /// This method creates the sql Parameter[] array
            /// that holds the primary key value.
            /// </summary>
            /// <param name='codeSample'>The 'CodeSample' to get the primary key of.</param>
            /// <returns>A SqlParameter[] array which contains the primary key value.
            /// to delete.</returns>
            internal static SqlParameter[] CreatePrimaryKeyParameter(CodeSample codeSample)
            {
                // Initial Value
                SqlParameter[] parameters = new SqlParameter[1];

                // verify user exists
                if (codeSample != null)
                {
                    // Create PrimaryKey Parameter
                    SqlParameter @Id = new SqlParameter("@Id", codeSample.Id);

                    // Set parameters[0] to @Id
                    parameters[0] = @Id;
                }

                // return value
                return parameters;
            }
            #endregion

            #region CreateDeleteCodeSampleStoredProcedure(CodeSample codeSample)
            /// <summary>
            /// This method creates an instance of an
            /// 'DeleteCodeSample'StoredProcedure' object and
            /// creates the sql parameter[] array needed
            /// to execute the procedure 'CodeSample_Delete'.
            /// </summary>
            /// <param name="codeSample">The 'CodeSample' to Delete.</param>
            /// <returns>An instance of a 'DeleteCodeSampleStoredProcedure' object.</returns>
            public static DeleteCodeSampleStoredProcedure CreateDeleteCodeSampleStoredProcedure(CodeSample codeSample)
            {
                // Initial Value
                DeleteCodeSampleStoredProcedure deleteCodeSampleStoredProcedure = new DeleteCodeSampleStoredProcedure();

                // Now Create Parameters For The DeleteProc
                deleteCodeSampleStoredProcedure.Parameters = CreatePrimaryKeyParameter(codeSample);

                // return value
                return deleteCodeSampleStoredProcedure;
            }
            #endregion

            #region CreateFindCodeSampleStoredProcedure(CodeSample codeSample)
            /// <summary>
            /// This method creates an instance of a
            /// 'FindCodeSampleStoredProcedure' object and
            /// creates the sql parameter[] array needed
            /// to execute the procedure 'CodeSample_Find'.
            /// </summary>
            /// <param name="codeSample">The 'CodeSample' to use to
            /// get the primary key parameter.</param>
            /// <returns>An instance of an FetchUserStoredProcedure</returns>
            public static FindCodeSampleStoredProcedure CreateFindCodeSampleStoredProcedure(CodeSample codeSample)
            {
                // Initial Value
                FindCodeSampleStoredProcedure findCodeSampleStoredProcedure = null;

                // verify codeSample exists
                if(codeSample != null)
                {
                    // Instanciate findCodeSampleStoredProcedure
                    findCodeSampleStoredProcedure = new FindCodeSampleStoredProcedure();

                    // Now create parameters for this procedure
                    findCodeSampleStoredProcedure.Parameters = CreatePrimaryKeyParameter(codeSample);
                }

                // return value
                return findCodeSampleStoredProcedure;
            }
            #endregion

            #region CreateInsertParameters(CodeSample codeSample)
            /// <summary>
            /// This method creates the sql Parameters[] needed for
            /// inserting a new codeSample.
            /// </summary>
            /// <param name="codeSample">The 'CodeSample' to insert.</param>
            /// <returns></returns>
            internal static SqlParameter[] CreateInsertParameters(CodeSample codeSample)
            {
                // Initial Values
                SqlParameter[] parameters = new SqlParameter[6];
                SqlParameter param = null;

                // verify codeSampleexists
                if(codeSample != null)
                {
                    // Create [CodeType] parameter
                    param = new SqlParameter("@CodeType", codeSample.CodeType);

                    // set parameters[0]
                    parameters[0] = param;

                    // Create [ParentId] parameter
                    param = new SqlParameter("@ParentId", codeSample.ParentId);

                    // set parameters[1]
                    parameters[1] = param;

                    // Create [ParentType] parameter
                    param = new SqlParameter("@ParentType", codeSample.ParentType);

                    // set parameters[2]
                    parameters[2] = param;

                    // Create [Status] parameter
                    param = new SqlParameter("@Status", codeSample.Status);

                    // set parameters[3]
                    parameters[3] = param;

                    // Create [Text] parameter
                    param = new SqlParameter("@Text", codeSample.Text);

                    // set parameters[4]
                    parameters[4] = param;

                    // Create [Visible] parameter
                    param = new SqlParameter("@Visible", codeSample.Visible);

                    // set parameters[5]
                    parameters[5] = param;
                }

                // return value
                return parameters;
            }
            #endregion

            #region CreateInsertCodeSampleStoredProcedure(CodeSample codeSample)
            /// <summary>
            /// This method creates an instance of an
            /// 'InsertCodeSampleStoredProcedure' object and
            /// creates the sql parameter[] array needed
            /// to execute the procedure 'CodeSample_Insert'.
            /// </summary>
            /// <param name="codeSample"The 'CodeSample' object to insert</param>
            /// <returns>An instance of a 'InsertCodeSampleStoredProcedure' object.</returns>
            public static InsertCodeSampleStoredProcedure CreateInsertCodeSampleStoredProcedure(CodeSample codeSample)
            {
                // Initial Value
                InsertCodeSampleStoredProcedure insertCodeSampleStoredProcedure = null;

                // verify codeSample exists
                if(codeSample != null)
                {
                    // Instanciate insertCodeSampleStoredProcedure
                    insertCodeSampleStoredProcedure = new InsertCodeSampleStoredProcedure();

                    // Now create parameters for this procedure
                    insertCodeSampleStoredProcedure.Parameters = CreateInsertParameters(codeSample);
                }

                // return value
                return insertCodeSampleStoredProcedure;
            }
            #endregion

            #region CreateUpdateParameters(CodeSample codeSample)
            /// <summary>
            /// This method creates the sql Parameters[] needed for
            /// update an existing codeSample.
            /// </summary>
            /// <param name="codeSample">The 'CodeSample' to update.</param>
            /// <returns></returns>
            internal static SqlParameter[] CreateUpdateParameters(CodeSample codeSample)
            {
                // Initial Values
                SqlParameter[] parameters = new SqlParameter[7];
                SqlParameter param = null;

                // verify codeSampleexists
                if(codeSample != null)
                {
                    // Create parameter for [CodeType]
                    param = new SqlParameter("@CodeType", codeSample.CodeType);

                    // set parameters[0]
                    parameters[0] = param;

                    // Create parameter for [ParentId]
                    param = new SqlParameter("@ParentId", codeSample.ParentId);

                    // set parameters[1]
                    parameters[1] = param;

                    // Create parameter for [ParentType]
                    param = new SqlParameter("@ParentType", codeSample.ParentType);

                    // set parameters[2]
                    parameters[2] = param;

                    // Create parameter for [Status]
                    param = new SqlParameter("@Status", codeSample.Status);

                    // set parameters[3]
                    parameters[3] = param;

                    // Create parameter for [Text]
                    param = new SqlParameter("@Text", codeSample.Text);

                    // set parameters[4]
                    parameters[4] = param;

                    // Create parameter for [Visible]
                    param = new SqlParameter("@Visible", codeSample.Visible);

                    // set parameters[5]
                    parameters[5] = param;

                    // Create parameter for [Id]
                    param = new SqlParameter("@Id", codeSample.Id);
                    parameters[6] = param;
                }

                // return value
                return parameters;
            }
            #endregion

            #region CreateUpdateCodeSampleStoredProcedure(CodeSample codeSample)
            /// <summary>
            /// This method creates an instance of an
            /// 'UpdateCodeSampleStoredProcedure' object and
            /// creates the sql parameter[] array needed
            /// to execute the procedure 'CodeSample_Update'.
            /// </summary>
            /// <param name="codeSample"The 'CodeSample' object to update</param>
            /// <returns>An instance of a 'UpdateCodeSampleStoredProcedure</returns>
            public static UpdateCodeSampleStoredProcedure CreateUpdateCodeSampleStoredProcedure(CodeSample codeSample)
            {
                // Initial Value
                UpdateCodeSampleStoredProcedure updateCodeSampleStoredProcedure = null;

                // verify codeSample exists
                if(codeSample != null)
                {
                    // Instanciate updateCodeSampleStoredProcedure
                    updateCodeSampleStoredProcedure = new UpdateCodeSampleStoredProcedure();

                    // Now create parameters for this procedure
                    updateCodeSampleStoredProcedure.Parameters = CreateUpdateParameters(codeSample);
                }

                // return value
                return updateCodeSampleStoredProcedure;
            }
            #endregion

            #region CreateFetchAllCodeSamplesStoredProcedure(CodeSample codeSample)
            /// <summary>
            /// This method creates an instance of a
            /// 'FetchAllCodeSamplesStoredProcedure' object and
            /// creates the sql parameter[] array needed
            /// to execute the procedure 'CodeSample_FetchAll'.
            /// </summary>
            /// <returns>An instance of a(n) 'FetchAllCodeSamplesStoredProcedure' object.</returns>
            public static FetchAllCodeSamplesStoredProcedure CreateFetchAllCodeSamplesStoredProcedure(CodeSample codeSample)
            {
                // Initial value
                FetchAllCodeSamplesStoredProcedure fetchAllCodeSamplesStoredProcedure = new FetchAllCodeSamplesStoredProcedure();

                // return value
                return fetchAllCodeSamplesStoredProcedure;
            }
            #endregion

        #endregion

    }
    #endregion

}
