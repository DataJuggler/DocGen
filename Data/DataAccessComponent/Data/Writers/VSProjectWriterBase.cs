

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

    #region class VSProjectWriterBase
    /// <summary>
    /// This class is used for converting a 'VSProject' object to
    /// the SqlParameter[] to perform the CRUD methods.
    /// </summary>
    public class VSProjectWriterBase
    {

        #region Static Methods

            #region CreatePrimaryKeyParameter(VSProject vSProject)
            /// <summary>
            /// This method creates the sql Parameter[] array
            /// that holds the primary key value.
            /// </summary>
            /// <param name='vSProject'>The 'VSProject' to get the primary key of.</param>
            /// <returns>A SqlParameter[] array which contains the primary key value.
            /// to delete.</returns>
            internal static SqlParameter[] CreatePrimaryKeyParameter(VSProject vSProject)
            {
                // Initial Value
                SqlParameter[] parameters = new SqlParameter[1];

                // verify user exists
                if (vSProject != null)
                {
                    // Create PrimaryKey Parameter
                    SqlParameter @Id = new SqlParameter("@Id", vSProject.Id);

                    // Set parameters[0] to @Id
                    parameters[0] = @Id;
                }

                // return value
                return parameters;
            }
            #endregion

            #region CreateDeleteVSProjectStoredProcedure(VSProject vSProject)
            /// <summary>
            /// This method creates an instance of an
            /// 'DeleteVSProject'StoredProcedure' object and
            /// creates the sql parameter[] array needed
            /// to execute the procedure 'VSProject_Delete'.
            /// </summary>
            /// <param name="vSProject">The 'VSProject' to Delete.</param>
            /// <returns>An instance of a 'DeleteVSProjectStoredProcedure' object.</returns>
            public static DeleteVSProjectStoredProcedure CreateDeleteVSProjectStoredProcedure(VSProject vSProject)
            {
                // Initial Value
                DeleteVSProjectStoredProcedure deleteVSProjectStoredProcedure = new DeleteVSProjectStoredProcedure();

                // Now Create Parameters For The DeleteProc
                deleteVSProjectStoredProcedure.Parameters = CreatePrimaryKeyParameter(vSProject);

                // return value
                return deleteVSProjectStoredProcedure;
            }
            #endregion

            #region CreateFindVSProjectStoredProcedure(VSProject vSProject)
            /// <summary>
            /// This method creates an instance of a
            /// 'FindVSProjectStoredProcedure' object and
            /// creates the sql parameter[] array needed
            /// to execute the procedure 'VSProject_Find'.
            /// </summary>
            /// <param name="vSProject">The 'VSProject' to use to
            /// get the primary key parameter.</param>
            /// <returns>An instance of an FetchUserStoredProcedure</returns>
            public static FindVSProjectStoredProcedure CreateFindVSProjectStoredProcedure(VSProject vSProject)
            {
                // Initial Value
                FindVSProjectStoredProcedure findVSProjectStoredProcedure = null;

                // verify vSProject exists
                if(vSProject != null)
                {
                    // Instanciate findVSProjectStoredProcedure
                    findVSProjectStoredProcedure = new FindVSProjectStoredProcedure();

                    // Now create parameters for this procedure
                    findVSProjectStoredProcedure.Parameters = CreatePrimaryKeyParameter(vSProject);
                }

                // return value
                return findVSProjectStoredProcedure;
            }
            #endregion

            #region CreateInsertParameters(VSProject vSProject)
            /// <summary>
            /// This method creates the sql Parameters[] needed for
            /// inserting a new vSProject.
            /// </summary>
            /// <param name="vSProject">The 'VSProject' to insert.</param>
            /// <returns></returns>
            internal static SqlParameter[] CreateInsertParameters(VSProject vSProject)
            {
                // Initial Values
                SqlParameter[] parameters = new SqlParameter[4];
                SqlParameter param = null;

                // verify vSProjectexists
                if(vSProject != null)
                {
                    // Create [Description] parameter
                    param = new SqlParameter("@Description", vSProject.Description);

                    // set parameters[0]
                    parameters[0] = param;

                    // Create [FullPath] parameter
                    param = new SqlParameter("@FullPath", vSProject.FullPath);

                    // set parameters[1]
                    parameters[1] = param;

                    // Create [Name] parameter
                    param = new SqlParameter("@Name", vSProject.Name);

                    // set parameters[2]
                    parameters[2] = param;

                    // Create [SolutionId] parameter
                    param = new SqlParameter("@SolutionId", vSProject.SolutionId);

                    // set parameters[3]
                    parameters[3] = param;
                }

                // return value
                return parameters;
            }
            #endregion

            #region CreateInsertVSProjectStoredProcedure(VSProject vSProject)
            /// <summary>
            /// This method creates an instance of an
            /// 'InsertVSProjectStoredProcedure' object and
            /// creates the sql parameter[] array needed
            /// to execute the procedure 'VSProject_Insert'.
            /// </summary>
            /// <param name="vSProject"The 'VSProject' object to insert</param>
            /// <returns>An instance of a 'InsertVSProjectStoredProcedure' object.</returns>
            public static InsertVSProjectStoredProcedure CreateInsertVSProjectStoredProcedure(VSProject vSProject)
            {
                // Initial Value
                InsertVSProjectStoredProcedure insertVSProjectStoredProcedure = null;

                // verify vSProject exists
                if(vSProject != null)
                {
                    // Instanciate insertVSProjectStoredProcedure
                    insertVSProjectStoredProcedure = new InsertVSProjectStoredProcedure();

                    // Now create parameters for this procedure
                    insertVSProjectStoredProcedure.Parameters = CreateInsertParameters(vSProject);
                }

                // return value
                return insertVSProjectStoredProcedure;
            }
            #endregion

            #region CreateUpdateParameters(VSProject vSProject)
            /// <summary>
            /// This method creates the sql Parameters[] needed for
            /// update an existing vSProject.
            /// </summary>
            /// <param name="vSProject">The 'VSProject' to update.</param>
            /// <returns></returns>
            internal static SqlParameter[] CreateUpdateParameters(VSProject vSProject)
            {
                // Initial Values
                SqlParameter[] parameters = new SqlParameter[5];
                SqlParameter param = null;

                // verify vSProjectexists
                if(vSProject != null)
                {
                    // Create parameter for [Description]
                    param = new SqlParameter("@Description", vSProject.Description);

                    // set parameters[0]
                    parameters[0] = param;

                    // Create parameter for [FullPath]
                    param = new SqlParameter("@FullPath", vSProject.FullPath);

                    // set parameters[1]
                    parameters[1] = param;

                    // Create parameter for [Name]
                    param = new SqlParameter("@Name", vSProject.Name);

                    // set parameters[2]
                    parameters[2] = param;

                    // Create parameter for [SolutionId]
                    param = new SqlParameter("@SolutionId", vSProject.SolutionId);

                    // set parameters[3]
                    parameters[3] = param;

                    // Create parameter for [Id]
                    param = new SqlParameter("@Id", vSProject.Id);
                    parameters[4] = param;
                }

                // return value
                return parameters;
            }
            #endregion

            #region CreateUpdateVSProjectStoredProcedure(VSProject vSProject)
            /// <summary>
            /// This method creates an instance of an
            /// 'UpdateVSProjectStoredProcedure' object and
            /// creates the sql parameter[] array needed
            /// to execute the procedure 'VSProject_Update'.
            /// </summary>
            /// <param name="vSProject"The 'VSProject' object to update</param>
            /// <returns>An instance of a 'UpdateVSProjectStoredProcedure</returns>
            public static UpdateVSProjectStoredProcedure CreateUpdateVSProjectStoredProcedure(VSProject vSProject)
            {
                // Initial Value
                UpdateVSProjectStoredProcedure updateVSProjectStoredProcedure = null;

                // verify vSProject exists
                if(vSProject != null)
                {
                    // Instanciate updateVSProjectStoredProcedure
                    updateVSProjectStoredProcedure = new UpdateVSProjectStoredProcedure();

                    // Now create parameters for this procedure
                    updateVSProjectStoredProcedure.Parameters = CreateUpdateParameters(vSProject);
                }

                // return value
                return updateVSProjectStoredProcedure;
            }
            #endregion

            #region CreateFetchAllVSProjectsStoredProcedure(VSProject vSProject)
            /// <summary>
            /// This method creates an instance of a
            /// 'FetchAllVSProjectsStoredProcedure' object and
            /// creates the sql parameter[] array needed
            /// to execute the procedure 'VSProject_FetchAll'.
            /// </summary>
            /// <returns>An instance of a(n) 'FetchAllVSProjectsStoredProcedure' object.</returns>
            public static FetchAllVSProjectsStoredProcedure CreateFetchAllVSProjectsStoredProcedure(VSProject vSProject)
            {
                // Initial value
                FetchAllVSProjectsStoredProcedure fetchAllVSProjectsStoredProcedure = new FetchAllVSProjectsStoredProcedure();

                // return value
                return fetchAllVSProjectsStoredProcedure;
            }
            #endregion

        #endregion

    }
    #endregion

}