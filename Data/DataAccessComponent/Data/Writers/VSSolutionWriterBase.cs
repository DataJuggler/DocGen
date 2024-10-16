

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

    #region class VSSolutionWriterBase
    /// <summary>
    /// This class is used for converting a 'VSSolution' object to
    /// the SqlParameter[] to perform the CRUD methods.
    /// </summary>
    public class VSSolutionWriterBase
    {

        #region Static Methods

            #region CreatePrimaryKeyParameter(VSSolution vSSolution)
            /// <summary>
            /// This method creates the sql Parameter[] array
            /// that holds the primary key value.
            /// </summary>
            /// <param name='vSSolution'>The 'VSSolution' to get the primary key of.</param>
            /// <returns>A SqlParameter[] array which contains the primary key value.
            /// to delete.</returns>
            internal static SqlParameter[] CreatePrimaryKeyParameter(VSSolution vSSolution)
            {
                // Initial Value
                SqlParameter[] parameters = new SqlParameter[1];

                // verify user exists
                if (vSSolution != null)
                {
                    // Create PrimaryKey Parameter
                    SqlParameter @Id = new SqlParameter("@Id", vSSolution.Id);

                    // Set parameters[0] to @Id
                    parameters[0] = @Id;
                }

                // return value
                return parameters;
            }
            #endregion

            #region CreateDeleteVSSolutionStoredProcedure(VSSolution vSSolution)
            /// <summary>
            /// This method creates an instance of an
            /// 'DeleteVSSolution'StoredProcedure' object and
            /// creates the sql parameter[] array needed
            /// to execute the procedure 'VSSolution_Delete'.
            /// </summary>
            /// <param name="vSSolution">The 'VSSolution' to Delete.</param>
            /// <returns>An instance of a 'DeleteVSSolutionStoredProcedure' object.</returns>
            public static DeleteVSSolutionStoredProcedure CreateDeleteVSSolutionStoredProcedure(VSSolution vSSolution)
            {
                // Initial Value
                DeleteVSSolutionStoredProcedure deleteVSSolutionStoredProcedure = new DeleteVSSolutionStoredProcedure();

                // Now Create Parameters For The DeleteProc
                deleteVSSolutionStoredProcedure.Parameters = CreatePrimaryKeyParameter(vSSolution);

                // return value
                return deleteVSSolutionStoredProcedure;
            }
            #endregion

            #region CreateFindVSSolutionStoredProcedure(VSSolution vSSolution)
            /// <summary>
            /// This method creates an instance of a
            /// 'FindVSSolutionStoredProcedure' object and
            /// creates the sql parameter[] array needed
            /// to execute the procedure 'VSSolution_Find'.
            /// </summary>
            /// <param name="vSSolution">The 'VSSolution' to use to
            /// get the primary key parameter.</param>
            /// <returns>An instance of an FetchUserStoredProcedure</returns>
            public static FindVSSolutionStoredProcedure CreateFindVSSolutionStoredProcedure(VSSolution vSSolution)
            {
                // Initial Value
                FindVSSolutionStoredProcedure findVSSolutionStoredProcedure = null;

                // verify vSSolution exists
                if(vSSolution != null)
                {
                    // Instanciate findVSSolutionStoredProcedure
                    findVSSolutionStoredProcedure = new FindVSSolutionStoredProcedure();

                    // Now create parameters for this procedure
                    findVSSolutionStoredProcedure.Parameters = CreatePrimaryKeyParameter(vSSolution);
                }

                // return value
                return findVSSolutionStoredProcedure;
            }
            #endregion

            #region CreateInsertParameters(VSSolution vSSolution)
            /// <summary>
            /// This method creates the sql Parameters[] needed for
            /// inserting a new vSSolution.
            /// </summary>
            /// <param name="vSSolution">The 'VSSolution' to insert.</param>
            /// <returns></returns>
            internal static SqlParameter[] CreateInsertParameters(VSSolution vSSolution)
            {
                // Initial Values
                SqlParameter[] parameters = new SqlParameter[6];
                SqlParameter param = null;

                // verify vSSolutionexists
                if(vSSolution != null)
                {
                    // Create [CreatedDate] Parameter
                    param = new SqlParameter("@CreatedDate", SqlDbType.DateTime);

                    // If vSSolution.CreatedDate does not exist.
                    if (vSSolution.CreatedDate.Year < 1900)
                    {
                        // Set the value to 1/1/1900
                        param.Value = new DateTime(1900, 1, 1);
                    }
                    else
                    {
                        // Set the parameter value
                        param.Value = vSSolution.CreatedDate;
                    }
                    // set parameters[0]
                    parameters[0] = param;

                    // Create [Description] parameter
                    param = new SqlParameter("@Description", vSSolution.Description);

                    // set parameters[1]
                    parameters[1] = param;

                    // Create [FullPath] parameter
                    param = new SqlParameter("@FullPath", vSSolution.FullPath);

                    // set parameters[2]
                    parameters[2] = param;

                    // Create [Name] parameter
                    param = new SqlParameter("@Name", vSSolution.Name);

                    // set parameters[3]
                    parameters[3] = param;

                    // Create [Status] parameter
                    param = new SqlParameter("@Status", vSSolution.Status);

                    // set parameters[4]
                    parameters[4] = param;

                    // Create [Visible] parameter
                    param = new SqlParameter("@Visible", vSSolution.Visible);

                    // set parameters[5]
                    parameters[5] = param;
                }

                // return value
                return parameters;
            }
            #endregion

            #region CreateInsertVSSolutionStoredProcedure(VSSolution vSSolution)
            /// <summary>
            /// This method creates an instance of an
            /// 'InsertVSSolutionStoredProcedure' object and
            /// creates the sql parameter[] array needed
            /// to execute the procedure 'VSSolution_Insert'.
            /// </summary>
            /// <param name="vSSolution"The 'VSSolution' object to insert</param>
            /// <returns>An instance of a 'InsertVSSolutionStoredProcedure' object.</returns>
            public static InsertVSSolutionStoredProcedure CreateInsertVSSolutionStoredProcedure(VSSolution vSSolution)
            {
                // Initial Value
                InsertVSSolutionStoredProcedure insertVSSolutionStoredProcedure = null;

                // verify vSSolution exists
                if(vSSolution != null)
                {
                    // Instanciate insertVSSolutionStoredProcedure
                    insertVSSolutionStoredProcedure = new InsertVSSolutionStoredProcedure();

                    // Now create parameters for this procedure
                    insertVSSolutionStoredProcedure.Parameters = CreateInsertParameters(vSSolution);
                }

                // return value
                return insertVSSolutionStoredProcedure;
            }
            #endregion

            #region CreateUpdateParameters(VSSolution vSSolution)
            /// <summary>
            /// This method creates the sql Parameters[] needed for
            /// update an existing vSSolution.
            /// </summary>
            /// <param name="vSSolution">The 'VSSolution' to update.</param>
            /// <returns></returns>
            internal static SqlParameter[] CreateUpdateParameters(VSSolution vSSolution)
            {
                // Initial Values
                SqlParameter[] parameters = new SqlParameter[7];
                SqlParameter param = null;

                // verify vSSolutionexists
                if(vSSolution != null)
                {
                    // Create parameter for [CreatedDate]
                    // Create [CreatedDate] Parameter
                    param = new SqlParameter("@CreatedDate", SqlDbType.DateTime);

                    // If vSSolution.CreatedDate does not exist.
                    if (vSSolution.CreatedDate.Year < 1900)
                    {
                        // Set the value to 1/1/1900
                        param.Value = new DateTime(1900, 1, 1);
                    }
                    else
                    {
                        // Set the parameter value
                        param.Value = vSSolution.CreatedDate;
                    }

                    // set parameters[0]
                    parameters[0] = param;

                    // Create parameter for [Description]
                    param = new SqlParameter("@Description", vSSolution.Description);

                    // set parameters[1]
                    parameters[1] = param;

                    // Create parameter for [FullPath]
                    param = new SqlParameter("@FullPath", vSSolution.FullPath);

                    // set parameters[2]
                    parameters[2] = param;

                    // Create parameter for [Name]
                    param = new SqlParameter("@Name", vSSolution.Name);

                    // set parameters[3]
                    parameters[3] = param;

                    // Create parameter for [Status]
                    param = new SqlParameter("@Status", vSSolution.Status);

                    // set parameters[4]
                    parameters[4] = param;

                    // Create parameter for [Visible]
                    param = new SqlParameter("@Visible", vSSolution.Visible);

                    // set parameters[5]
                    parameters[5] = param;

                    // Create parameter for [Id]
                    param = new SqlParameter("@Id", vSSolution.Id);
                    parameters[6] = param;
                }

                // return value
                return parameters;
            }
            #endregion

            #region CreateUpdateVSSolutionStoredProcedure(VSSolution vSSolution)
            /// <summary>
            /// This method creates an instance of an
            /// 'UpdateVSSolutionStoredProcedure' object and
            /// creates the sql parameter[] array needed
            /// to execute the procedure 'VSSolution_Update'.
            /// </summary>
            /// <param name="vSSolution"The 'VSSolution' object to update</param>
            /// <returns>An instance of a 'UpdateVSSolutionStoredProcedure</returns>
            public static UpdateVSSolutionStoredProcedure CreateUpdateVSSolutionStoredProcedure(VSSolution vSSolution)
            {
                // Initial Value
                UpdateVSSolutionStoredProcedure updateVSSolutionStoredProcedure = null;

                // verify vSSolution exists
                if(vSSolution != null)
                {
                    // Instanciate updateVSSolutionStoredProcedure
                    updateVSSolutionStoredProcedure = new UpdateVSSolutionStoredProcedure();

                    // Now create parameters for this procedure
                    updateVSSolutionStoredProcedure.Parameters = CreateUpdateParameters(vSSolution);
                }

                // return value
                return updateVSSolutionStoredProcedure;
            }
            #endregion

            #region CreateFetchAllVSSolutionsStoredProcedure(VSSolution vSSolution)
            /// <summary>
            /// This method creates an instance of a
            /// 'FetchAllVSSolutionsStoredProcedure' object and
            /// creates the sql parameter[] array needed
            /// to execute the procedure 'VSSolution_FetchAll'.
            /// </summary>
            /// <returns>An instance of a(n) 'FetchAllVSSolutionsStoredProcedure' object.</returns>
            public static FetchAllVSSolutionsStoredProcedure CreateFetchAllVSSolutionsStoredProcedure(VSSolution vSSolution)
            {
                // Initial value
                FetchAllVSSolutionsStoredProcedure fetchAllVSSolutionsStoredProcedure = new FetchAllVSSolutionsStoredProcedure();

                // return value
                return fetchAllVSSolutionsStoredProcedure;
            }
            #endregion

        #endregion

    }
    #endregion

}
