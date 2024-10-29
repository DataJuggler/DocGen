

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

    #region class ReferencedByWriterBase
    /// <summary>
    /// This class is used for converting a 'ReferencedBy' object to
    /// the SqlParameter[] to perform the CRUD methods.
    /// </summary>
    public class ReferencedByWriterBase
    {

        #region Static Methods

            #region CreatePrimaryKeyParameter(ReferencedBy referencedBy)
            /// <summary>
            /// This method creates the sql Parameter[] array
            /// that holds the primary key value.
            /// </summary>
            /// <param name='referencedBy'>The 'ReferencedBy' to get the primary key of.</param>
            /// <returns>A SqlParameter[] array which contains the primary key value.
            /// to delete.</returns>
            internal static SqlParameter[] CreatePrimaryKeyParameter(ReferencedBy referencedBy)
            {
                // Initial Value
                SqlParameter[] parameters = new SqlParameter[1];

                // verify user exists
                if (referencedBy != null)
                {
                    // Create PrimaryKey Parameter
                    SqlParameter @Id = new SqlParameter("@Id", referencedBy.Id);

                    // Set parameters[0] to @Id
                    parameters[0] = @Id;
                }

                // return value
                return parameters;
            }
            #endregion

            #region CreateDeleteReferencedByStoredProcedure(ReferencedBy referencedBy)
            /// <summary>
            /// This method creates an instance of an
            /// 'DeleteReferencedBy'StoredProcedure' object and
            /// creates the sql parameter[] array needed
            /// to execute the procedure 'ReferencedBy_Delete'.
            /// </summary>
            /// <param name="referencedBy">The 'ReferencedBy' to Delete.</param>
            /// <returns>An instance of a 'DeleteReferencedByStoredProcedure' object.</returns>
            public static DeleteReferencedByStoredProcedure CreateDeleteReferencedByStoredProcedure(ReferencedBy referencedBy)
            {
                // Initial Value
                DeleteReferencedByStoredProcedure deleteReferencedByStoredProcedure = new DeleteReferencedByStoredProcedure();

                // Now Create Parameters For The DeleteProc
                deleteReferencedByStoredProcedure.Parameters = CreatePrimaryKeyParameter(referencedBy);

                // return value
                return deleteReferencedByStoredProcedure;
            }
            #endregion

            #region CreateFindReferencedByStoredProcedure(ReferencedBy referencedBy)
            /// <summary>
            /// This method creates an instance of a
            /// 'FindReferencedByStoredProcedure' object and
            /// creates the sql parameter[] array needed
            /// to execute the procedure 'ReferencedBy_Find'.
            /// </summary>
            /// <param name="referencedBy">The 'ReferencedBy' to use to
            /// get the primary key parameter.</param>
            /// <returns>An instance of an FetchUserStoredProcedure</returns>
            public static FindReferencedByStoredProcedure CreateFindReferencedByStoredProcedure(ReferencedBy referencedBy)
            {
                // Initial Value
                FindReferencedByStoredProcedure findReferencedByStoredProcedure = null;

                // verify referencedBy exists
                if(referencedBy != null)
                {
                    // Instanciate findReferencedByStoredProcedure
                    findReferencedByStoredProcedure = new FindReferencedByStoredProcedure();

                    // Now create parameters for this procedure
                    findReferencedByStoredProcedure.Parameters = CreatePrimaryKeyParameter(referencedBy);
                }

                // return value
                return findReferencedByStoredProcedure;
            }
            #endregion

            #region CreateInsertParameters(ReferencedBy referencedBy)
            /// <summary>
            /// This method creates the sql Parameters[] needed for
            /// inserting a new referencedBy.
            /// </summary>
            /// <param name="referencedBy">The 'ReferencedBy' to insert.</param>
            /// <returns></returns>
            internal static SqlParameter[] CreateInsertParameters(ReferencedBy referencedBy)
            {
                // Initial Values
                SqlParameter[] parameters = new SqlParameter[10];
                SqlParameter param = null;

                // verify referencedByexists
                if(referencedBy != null)
                {
                    // Create [CodeFileId] parameter
                    param = new SqlParameter("@CodeFileId", referencedBy.CodeFileId);

                    // set parameters[0]
                    parameters[0] = param;

                    // Create [FilePath] parameter
                    param = new SqlParameter("@FilePath", referencedBy.FilePath);

                    // set parameters[1]
                    parameters[1] = param;

                    // Create [LineNumber] parameter
                    param = new SqlParameter("@LineNumber", referencedBy.LineNumber);

                    // set parameters[2]
                    parameters[2] = param;

                    // Create [ProjectId] parameter
                    param = new SqlParameter("@ProjectId", referencedBy.ProjectId);

                    // set parameters[3]
                    parameters[3] = param;

                    // Create [SourceId] parameter
                    param = new SqlParameter("@SourceId", referencedBy.SourceId);

                    // set parameters[4]
                    parameters[4] = param;

                    // Create [SourceType] parameter
                    param = new SqlParameter("@SourceType", referencedBy.SourceType);

                    // set parameters[5]
                    parameters[5] = param;

                    // Create [Status] parameter
                    param = new SqlParameter("@Status", referencedBy.Status);

                    // set parameters[6]
                    parameters[6] = param;

                    // Create [TargetId] parameter
                    param = new SqlParameter("@TargetId", referencedBy.TargetId);

                    // set parameters[7]
                    parameters[7] = param;

                    // Create [TargetType] parameter
                    param = new SqlParameter("@TargetType", referencedBy.TargetType);

                    // set parameters[8]
                    parameters[8] = param;

                    // Create [Visible] parameter
                    param = new SqlParameter("@Visible", referencedBy.Visible);

                    // set parameters[9]
                    parameters[9] = param;
                }

                // return value
                return parameters;
            }
            #endregion

            #region CreateInsertReferencedByStoredProcedure(ReferencedBy referencedBy)
            /// <summary>
            /// This method creates an instance of an
            /// 'InsertReferencedByStoredProcedure' object and
            /// creates the sql parameter[] array needed
            /// to execute the procedure 'ReferencedBy_Insert'.
            /// </summary>
            /// <param name="referencedBy"The 'ReferencedBy' object to insert</param>
            /// <returns>An instance of a 'InsertReferencedByStoredProcedure' object.</returns>
            public static InsertReferencedByStoredProcedure CreateInsertReferencedByStoredProcedure(ReferencedBy referencedBy)
            {
                // Initial Value
                InsertReferencedByStoredProcedure insertReferencedByStoredProcedure = null;

                // verify referencedBy exists
                if(referencedBy != null)
                {
                    // Instanciate insertReferencedByStoredProcedure
                    insertReferencedByStoredProcedure = new InsertReferencedByStoredProcedure();

                    // Now create parameters for this procedure
                    insertReferencedByStoredProcedure.Parameters = CreateInsertParameters(referencedBy);
                }

                // return value
                return insertReferencedByStoredProcedure;
            }
            #endregion

            #region CreateUpdateParameters(ReferencedBy referencedBy)
            /// <summary>
            /// This method creates the sql Parameters[] needed for
            /// update an existing referencedBy.
            /// </summary>
            /// <param name="referencedBy">The 'ReferencedBy' to update.</param>
            /// <returns></returns>
            internal static SqlParameter[] CreateUpdateParameters(ReferencedBy referencedBy)
            {
                // Initial Values
                SqlParameter[] parameters = new SqlParameter[11];
                SqlParameter param = null;

                // verify referencedByexists
                if(referencedBy != null)
                {
                    // Create parameter for [CodeFileId]
                    param = new SqlParameter("@CodeFileId", referencedBy.CodeFileId);

                    // set parameters[0]
                    parameters[0] = param;

                    // Create parameter for [FilePath]
                    param = new SqlParameter("@FilePath", referencedBy.FilePath);

                    // set parameters[1]
                    parameters[1] = param;

                    // Create parameter for [LineNumber]
                    param = new SqlParameter("@LineNumber", referencedBy.LineNumber);

                    // set parameters[2]
                    parameters[2] = param;

                    // Create parameter for [ProjectId]
                    param = new SqlParameter("@ProjectId", referencedBy.ProjectId);

                    // set parameters[3]
                    parameters[3] = param;

                    // Create parameter for [SourceId]
                    param = new SqlParameter("@SourceId", referencedBy.SourceId);

                    // set parameters[4]
                    parameters[4] = param;

                    // Create parameter for [SourceType]
                    param = new SqlParameter("@SourceType", referencedBy.SourceType);

                    // set parameters[5]
                    parameters[5] = param;

                    // Create parameter for [Status]
                    param = new SqlParameter("@Status", referencedBy.Status);

                    // set parameters[6]
                    parameters[6] = param;

                    // Create parameter for [TargetId]
                    param = new SqlParameter("@TargetId", referencedBy.TargetId);

                    // set parameters[7]
                    parameters[7] = param;

                    // Create parameter for [TargetType]
                    param = new SqlParameter("@TargetType", referencedBy.TargetType);

                    // set parameters[8]
                    parameters[8] = param;

                    // Create parameter for [Visible]
                    param = new SqlParameter("@Visible", referencedBy.Visible);

                    // set parameters[9]
                    parameters[9] = param;

                    // Create parameter for [Id]
                    param = new SqlParameter("@Id", referencedBy.Id);
                    parameters[10] = param;
                }

                // return value
                return parameters;
            }
            #endregion

            #region CreateUpdateReferencedByStoredProcedure(ReferencedBy referencedBy)
            /// <summary>
            /// This method creates an instance of an
            /// 'UpdateReferencedByStoredProcedure' object and
            /// creates the sql parameter[] array needed
            /// to execute the procedure 'ReferencedBy_Update'.
            /// </summary>
            /// <param name="referencedBy"The 'ReferencedBy' object to update</param>
            /// <returns>An instance of a 'UpdateReferencedByStoredProcedure</returns>
            public static UpdateReferencedByStoredProcedure CreateUpdateReferencedByStoredProcedure(ReferencedBy referencedBy)
            {
                // Initial Value
                UpdateReferencedByStoredProcedure updateReferencedByStoredProcedure = null;

                // verify referencedBy exists
                if(referencedBy != null)
                {
                    // Instanciate updateReferencedByStoredProcedure
                    updateReferencedByStoredProcedure = new UpdateReferencedByStoredProcedure();

                    // Now create parameters for this procedure
                    updateReferencedByStoredProcedure.Parameters = CreateUpdateParameters(referencedBy);
                }

                // return value
                return updateReferencedByStoredProcedure;
            }
            #endregion

            #region CreateFetchAllReferencedBysStoredProcedure(ReferencedBy referencedBy)
            /// <summary>
            /// This method creates an instance of a
            /// 'FetchAllReferencedBysStoredProcedure' object and
            /// creates the sql parameter[] array needed
            /// to execute the procedure 'ReferencedBy_FetchAll'.
            /// </summary>
            /// <returns>An instance of a(n) 'FetchAllReferencedBysStoredProcedure' object.</returns>
            public static FetchAllReferencedBysStoredProcedure CreateFetchAllReferencedBysStoredProcedure(ReferencedBy referencedBy)
            {
                // Initial value
                FetchAllReferencedBysStoredProcedure fetchAllReferencedBysStoredProcedure = new FetchAllReferencedBysStoredProcedure();

                // return value
                return fetchAllReferencedBysStoredProcedure;
            }
            #endregion

        #endregion

    }
    #endregion

}
