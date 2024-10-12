
#region using statements

using DataAccessComponent.Controllers;
using DataAccessComponent.DataOperations;
using DataAccessComponent.Data;
using ObjectLibrary.BusinessObjects;
using System;
using System.Collections.Generic;
using Microsoft.Data.SqlClient;

#endregion

namespace DataAccessComponent.DataGateway
{

    #region class Gateway
    /// <summary>
    /// This class is used to manage DataOperations
    /// between the client and the DataAccessComponent.
    /// Do not change the method name or the parameters for the
    /// code generated methods or they will be recreated the next 
    /// time you code generate with DataTier.Net. If you need additional
    /// parameters passed to a method either create an override or
    /// add or set properties to the temp object that is passed in.
    /// </summary>
    public class Gateway
    {

        #region Private Variables
        private ApplicationController appController;
        private string connectionName;
        #endregion

        #region Constructor
        /// <summary>
        /// Create a new instance of a Gateway object.
        /// </summary>
        public Gateway(string connectionName = "")
        {
            // store the ConnectionName
            this.ConnectionName = connectionName;

            // Perform Initializations for this object
            Init();
        }
        #endregion

        #region Methods
        
            #region DeleteCodeClass(int id, CodeClass tempCodeClass = null)
            /// <summary>
            /// This method is used to delete CodeClass objects.
            /// </summary>
            /// <param name="id">Delete the CodeClass with this id</param>
            /// <param name="tempCodeClass">Pass in a tempCodeClass to perform a custom delete.</param>
            public bool DeleteCodeClass(int id, CodeClass tempCodeClass = null)
            {
                // initial value
                bool deleted = false;
        
                // if the AppController exists
                if (this.HasAppController)
                {
                    // if the tempCodeClass does not exist
                    if (tempCodeClass == null)
                    {
                        // create a temp CodeClass
                        tempCodeClass = new CodeClass();
                    }
        
                    // if the id is set
                    if (id > 0)
                    {
                        // set the primary key
                        tempCodeClass.UpdateIdentity(id);
                    }
        
                    // perform the delete
                    deleted = this.AppController.ControllerManager.CodeClassController.Delete(tempCodeClass);
                }
        
                // return value
                return deleted;
            }
            #endregion
        
            #region DeleteCodeConstructor(int id, CodeConstructor tempCodeConstructor = null)
            /// <summary>
            /// This method is used to delete CodeConstructor objects.
            /// </summary>
            /// <param name="id">Delete the CodeConstructor with this id</param>
            /// <param name="tempCodeConstructor">Pass in a tempCodeConstructor to perform a custom delete.</param>
            public bool DeleteCodeConstructor(int id, CodeConstructor tempCodeConstructor = null)
            {
                // initial value
                bool deleted = false;
        
                // if the AppController exists
                if (this.HasAppController)
                {
                    // if the tempCodeConstructor does not exist
                    if (tempCodeConstructor == null)
                    {
                        // create a temp CodeConstructor
                        tempCodeConstructor = new CodeConstructor();
                    }
        
                    // if the id is set
                    if (id > 0)
                    {
                        // set the primary key
                        tempCodeConstructor.UpdateIdentity(id);
                    }
        
                    // perform the delete
                    deleted = this.AppController.ControllerManager.CodeConstructorController.Delete(tempCodeConstructor);
                }
        
                // return value
                return deleted;
            }
            #endregion
        
            #region DeleteCodeEvent(int id, CodeEvent tempCodeEvent = null)
            /// <summary>
            /// This method is used to delete CodeEvent objects.
            /// </summary>
            /// <param name="id">Delete the CodeEvent with this id</param>
            /// <param name="tempCodeEvent">Pass in a tempCodeEvent to perform a custom delete.</param>
            public bool DeleteCodeEvent(int id, CodeEvent tempCodeEvent = null)
            {
                // initial value
                bool deleted = false;
        
                // if the AppController exists
                if (this.HasAppController)
                {
                    // if the tempCodeEvent does not exist
                    if (tempCodeEvent == null)
                    {
                        // create a temp CodeEvent
                        tempCodeEvent = new CodeEvent();
                    }
        
                    // if the id is set
                    if (id > 0)
                    {
                        // set the primary key
                        tempCodeEvent.UpdateIdentity(id);
                    }
        
                    // perform the delete
                    deleted = this.AppController.ControllerManager.CodeEventController.Delete(tempCodeEvent);
                }
        
                // return value
                return deleted;
            }
            #endregion
        
            #region DeleteCodeFile(int id, CodeFile tempCodeFile = null)
            /// <summary>
            /// This method is used to delete CodeFile objects.
            /// </summary>
            /// <param name="id">Delete the CodeFile with this id</param>
            /// <param name="tempCodeFile">Pass in a tempCodeFile to perform a custom delete.</param>
            public bool DeleteCodeFile(int id, CodeFile tempCodeFile = null)
            {
                // initial value
                bool deleted = false;
        
                // if the AppController exists
                if (this.HasAppController)
                {
                    // if the tempCodeFile does not exist
                    if (tempCodeFile == null)
                    {
                        // create a temp CodeFile
                        tempCodeFile = new CodeFile();
                    }
        
                    // if the id is set
                    if (id > 0)
                    {
                        // set the primary key
                        tempCodeFile.UpdateIdentity(id);
                    }
        
                    // perform the delete
                    deleted = this.AppController.ControllerManager.CodeFileController.Delete(tempCodeFile);
                }
        
                // return value
                return deleted;
            }
            #endregion
        
            #region DeleteCodeMethod(int id, CodeMethod tempCodeMethod = null)
            /// <summary>
            /// This method is used to delete CodeMethod objects.
            /// </summary>
            /// <param name="id">Delete the CodeMethod with this id</param>
            /// <param name="tempCodeMethod">Pass in a tempCodeMethod to perform a custom delete.</param>
            public bool DeleteCodeMethod(int id, CodeMethod tempCodeMethod = null)
            {
                // initial value
                bool deleted = false;
        
                // if the AppController exists
                if (this.HasAppController)
                {
                    // if the tempCodeMethod does not exist
                    if (tempCodeMethod == null)
                    {
                        // create a temp CodeMethod
                        tempCodeMethod = new CodeMethod();
                    }
        
                    // if the id is set
                    if (id > 0)
                    {
                        // set the primary key
                        tempCodeMethod.UpdateIdentity(id);
                    }
        
                    // perform the delete
                    deleted = this.AppController.ControllerManager.CodeMethodController.Delete(tempCodeMethod);
                }
        
                // return value
                return deleted;
            }
            #endregion
        
            #region DeleteCodeParameter(int id, CodeParameter tempCodeParameter = null)
            /// <summary>
            /// This method is used to delete CodeParameter objects.
            /// </summary>
            /// <param name="id">Delete the CodeParameter with this id</param>
            /// <param name="tempCodeParameter">Pass in a tempCodeParameter to perform a custom delete.</param>
            public bool DeleteCodeParameter(int id, CodeParameter tempCodeParameter = null)
            {
                // initial value
                bool deleted = false;
        
                // if the AppController exists
                if (this.HasAppController)
                {
                    // if the tempCodeParameter does not exist
                    if (tempCodeParameter == null)
                    {
                        // create a temp CodeParameter
                        tempCodeParameter = new CodeParameter();
                    }
        
                    // if the id is set
                    if (id > 0)
                    {
                        // set the primary key
                        tempCodeParameter.UpdateIdentity(id);
                    }
        
                    // perform the delete
                    deleted = this.AppController.ControllerManager.CodeParameterController.Delete(tempCodeParameter);
                }
        
                // return value
                return deleted;
            }
            #endregion
        
            #region DeleteCodeProperty(int id, CodeProperty tempCodeProperty = null)
            /// <summary>
            /// This method is used to delete CodeProperty objects.
            /// </summary>
            /// <param name="id">Delete the CodeProperty with this id</param>
            /// <param name="tempCodeProperty">Pass in a tempCodeProperty to perform a custom delete.</param>
            public bool DeleteCodeProperty(int id, CodeProperty tempCodeProperty = null)
            {
                // initial value
                bool deleted = false;
        
                // if the AppController exists
                if (this.HasAppController)
                {
                    // if the tempCodeProperty does not exist
                    if (tempCodeProperty == null)
                    {
                        // create a temp CodeProperty
                        tempCodeProperty = new CodeProperty();
                    }
        
                    // if the id is set
                    if (id > 0)
                    {
                        // set the primary key
                        tempCodeProperty.UpdateIdentity(id);
                    }
        
                    // perform the delete
                    deleted = this.AppController.ControllerManager.CodePropertyController.Delete(tempCodeProperty);
                }
        
                // return value
                return deleted;
            }
            #endregion
        
            #region DeleteReferencedBy(int id, ReferencedBy tempReferencedBy = null)
            /// <summary>
            /// This method is used to delete ReferencedBy objects.
            /// </summary>
            /// <param name="id">Delete the ReferencedBy with this id</param>
            /// <param name="tempReferencedBy">Pass in a tempReferencedBy to perform a custom delete.</param>
            public bool DeleteReferencedBy(int id, ReferencedBy tempReferencedBy = null)
            {
                // initial value
                bool deleted = false;
        
                // if the AppController exists
                if (this.HasAppController)
                {
                    // if the tempReferencedBy does not exist
                    if (tempReferencedBy == null)
                    {
                        // create a temp ReferencedBy
                        tempReferencedBy = new ReferencedBy();
                    }
        
                    // if the id is set
                    if (id > 0)
                    {
                        // set the primary key
                        tempReferencedBy.UpdateIdentity(id);
                    }
        
                    // perform the delete
                    deleted = this.AppController.ControllerManager.ReferencedByController.Delete(tempReferencedBy);
                }
        
                // return value
                return deleted;
            }
            #endregion
        
            #region DeleteVSProject(int id, VSProject tempVSProject = null)
            /// <summary>
            /// This method is used to delete VSProject objects.
            /// </summary>
            /// <param name="id">Delete the VSProject with this id</param>
            /// <param name="tempVSProject">Pass in a tempVSProject to perform a custom delete.</param>
            public bool DeleteVSProject(int id, VSProject tempVSProject = null)
            {
                // initial value
                bool deleted = false;
        
                // if the AppController exists
                if (this.HasAppController)
                {
                    // if the tempVSProject does not exist
                    if (tempVSProject == null)
                    {
                        // create a temp VSProject
                        tempVSProject = new VSProject();
                    }
        
                    // if the id is set
                    if (id > 0)
                    {
                        // set the primary key
                        tempVSProject.UpdateIdentity(id);
                    }
        
                    // perform the delete
                    deleted = this.AppController.ControllerManager.VSProjectController.Delete(tempVSProject);
                }
        
                // return value
                return deleted;
            }
            #endregion
        
            #region DeleteVSSolution(int id, VSSolution tempVSSolution = null)
            /// <summary>
            /// This method is used to delete VSSolution objects.
            /// </summary>
            /// <param name="id">Delete the VSSolution with this id</param>
            /// <param name="tempVSSolution">Pass in a tempVSSolution to perform a custom delete.</param>
            public bool DeleteVSSolution(int id, VSSolution tempVSSolution = null)
            {
                // initial value
                bool deleted = false;
        
                // if the AppController exists
                if (this.HasAppController)
                {
                    // if the tempVSSolution does not exist
                    if (tempVSSolution == null)
                    {
                        // create a temp VSSolution
                        tempVSSolution = new VSSolution();
                    }
        
                    // if the id is set
                    if (id > 0)
                    {
                        // set the primary key
                        tempVSSolution.UpdateIdentity(id);
                    }
        
                    // perform the delete
                    deleted = this.AppController.ControllerManager.VSSolutionController.Delete(tempVSSolution);
                }
        
                // return value
                return deleted;
            }
            #endregion
        
            #region ExecuteNonQuery(string procedureName, SqlParameter[] sqlParameters)
            /// <summary>
            /// This method Executes a Non Query StoredProcedure
            /// </summary>
            public PolymorphicObject ExecuteNonQuery(string procedureName, SqlParameter[] sqlParameters)
            {
                // initial value
                PolymorphicObject returnValue = new PolymorphicObject();

                // locals
                List<PolymorphicObject> parameters = new List<PolymorphicObject>();

                // create the parameters
                PolymorphicObject procedureNameParameter = new PolymorphicObject();
                PolymorphicObject sqlParametersParameter = new PolymorphicObject();

                // if the procedureName exists
                if (!String.IsNullOrEmpty(procedureName))
                {
                    // Create an instance of the SystemMethods object
                    SystemMethods systemMethods = new SystemMethods();

                    // setup procedureNameParameter
                    procedureNameParameter.Name = "ProcedureName";
                    procedureNameParameter.Text = procedureName;

                    // setup sqlParametersParameter
                    sqlParametersParameter.Name = "SqlParameters";
                    sqlParametersParameter.ObjectValue = sqlParameters;

                    // Add these parameters to the parameters
                    parameters.Add(procedureNameParameter);
                    parameters.Add(sqlParametersParameter);

                    // get the dataConnector
                    DataAccessComponent.Data.DataConnector dataConnector = GetDataConnector();

                    // Execute the query
                    returnValue = systemMethods.ExecuteNonQuery(parameters, dataConnector);
                }

                // return value
                return returnValue;
            }
            #endregion

            #region FindCodeClass(int id, CodeClass tempCodeClass = null)
            /// <summary>
            /// This method is used to find 'CodeClass' objects.
            /// </summary>
            /// <param name="id">Find the CodeClass with this id</param>
            /// <param name="tempCodeClass">Pass in a tempCodeClass to perform a custom find.</param>
            public CodeClass FindCodeClass(int id, CodeClass tempCodeClass = null)
            {
                // initial value
                CodeClass codeClass = null;

                // if the AppController exists
                if (this.HasAppController)
                {
                    // if the tempCodeClass does not exist
                    if (tempCodeClass == null)
                    {
                        // create a temp CodeClass
                        tempCodeClass = new CodeClass();
                    }

                    // if the id is set
                    if (id > 0)
                    {
                        // set the primary key
                        tempCodeClass.UpdateIdentity(id);
                    }

                    // perform the find
                    codeClass = this.AppController.ControllerManager.CodeClassController.Find(tempCodeClass);
                }

                // return value
                return codeClass;
            }
            #endregion

            #region FindCodeConstructor(int id, CodeConstructor tempCodeConstructor = null)
            /// <summary>
            /// This method is used to find 'CodeConstructor' objects.
            /// </summary>
            /// <param name="id">Find the CodeConstructor with this id</param>
            /// <param name="tempCodeConstructor">Pass in a tempCodeConstructor to perform a custom find.</param>
            public CodeConstructor FindCodeConstructor(int id, CodeConstructor tempCodeConstructor = null)
            {
                // initial value
                CodeConstructor codeConstructor = null;

                // if the AppController exists
                if (this.HasAppController)
                {
                    // if the tempCodeConstructor does not exist
                    if (tempCodeConstructor == null)
                    {
                        // create a temp CodeConstructor
                        tempCodeConstructor = new CodeConstructor();
                    }

                    // if the id is set
                    if (id > 0)
                    {
                        // set the primary key
                        tempCodeConstructor.UpdateIdentity(id);
                    }

                    // perform the find
                    codeConstructor = this.AppController.ControllerManager.CodeConstructorController.Find(tempCodeConstructor);
                }

                // return value
                return codeConstructor;
            }
            #endregion

            #region FindCodeEvent(int id, CodeEvent tempCodeEvent = null)
            /// <summary>
            /// This method is used to find 'CodeEvent' objects.
            /// </summary>
            /// <param name="id">Find the CodeEvent with this id</param>
            /// <param name="tempCodeEvent">Pass in a tempCodeEvent to perform a custom find.</param>
            public CodeEvent FindCodeEvent(int id, CodeEvent tempCodeEvent = null)
            {
                // initial value
                CodeEvent codeEvent = null;

                // if the AppController exists
                if (this.HasAppController)
                {
                    // if the tempCodeEvent does not exist
                    if (tempCodeEvent == null)
                    {
                        // create a temp CodeEvent
                        tempCodeEvent = new CodeEvent();
                    }

                    // if the id is set
                    if (id > 0)
                    {
                        // set the primary key
                        tempCodeEvent.UpdateIdentity(id);
                    }

                    // perform the find
                    codeEvent = this.AppController.ControllerManager.CodeEventController.Find(tempCodeEvent);
                }

                // return value
                return codeEvent;
            }
            #endregion

            #region FindCodeFile(int id, CodeFile tempCodeFile = null)
            /// <summary>
            /// This method is used to find 'CodeFile' objects.
            /// </summary>
            /// <param name="id">Find the CodeFile with this id</param>
            /// <param name="tempCodeFile">Pass in a tempCodeFile to perform a custom find.</param>
            public CodeFile FindCodeFile(int id, CodeFile tempCodeFile = null)
            {
                // initial value
                CodeFile codeFile = null;

                // if the AppController exists
                if (this.HasAppController)
                {
                    // if the tempCodeFile does not exist
                    if (tempCodeFile == null)
                    {
                        // create a temp CodeFile
                        tempCodeFile = new CodeFile();
                    }

                    // if the id is set
                    if (id > 0)
                    {
                        // set the primary key
                        tempCodeFile.UpdateIdentity(id);
                    }

                    // perform the find
                    codeFile = this.AppController.ControllerManager.CodeFileController.Find(tempCodeFile);
                }

                // return value
                return codeFile;
            }
            #endregion

            #region FindCodeMethod(int id, CodeMethod tempCodeMethod = null)
            /// <summary>
            /// This method is used to find 'CodeMethod' objects.
            /// </summary>
            /// <param name="id">Find the CodeMethod with this id</param>
            /// <param name="tempCodeMethod">Pass in a tempCodeMethod to perform a custom find.</param>
            public CodeMethod FindCodeMethod(int id, CodeMethod tempCodeMethod = null)
            {
                // initial value
                CodeMethod codeMethod = null;

                // if the AppController exists
                if (this.HasAppController)
                {
                    // if the tempCodeMethod does not exist
                    if (tempCodeMethod == null)
                    {
                        // create a temp CodeMethod
                        tempCodeMethod = new CodeMethod();
                    }

                    // if the id is set
                    if (id > 0)
                    {
                        // set the primary key
                        tempCodeMethod.UpdateIdentity(id);
                    }

                    // perform the find
                    codeMethod = this.AppController.ControllerManager.CodeMethodController.Find(tempCodeMethod);
                }

                // return value
                return codeMethod;
            }
            #endregion

            #region FindCodeParameter(int id, CodeParameter tempCodeParameter = null)
            /// <summary>
            /// This method is used to find 'CodeParameter' objects.
            /// </summary>
            /// <param name="id">Find the CodeParameter with this id</param>
            /// <param name="tempCodeParameter">Pass in a tempCodeParameter to perform a custom find.</param>
            public CodeParameter FindCodeParameter(int id, CodeParameter tempCodeParameter = null)
            {
                // initial value
                CodeParameter codeParameter = null;

                // if the AppController exists
                if (this.HasAppController)
                {
                    // if the tempCodeParameter does not exist
                    if (tempCodeParameter == null)
                    {
                        // create a temp CodeParameter
                        tempCodeParameter = new CodeParameter();
                    }

                    // if the id is set
                    if (id > 0)
                    {
                        // set the primary key
                        tempCodeParameter.UpdateIdentity(id);
                    }

                    // perform the find
                    codeParameter = this.AppController.ControllerManager.CodeParameterController.Find(tempCodeParameter);
                }

                // return value
                return codeParameter;
            }
            #endregion

            #region FindCodeProperty(int id, CodeProperty tempCodeProperty = null)
            /// <summary>
            /// This method is used to find 'CodeProperty' objects.
            /// </summary>
            /// <param name="id">Find the CodeProperty with this id</param>
            /// <param name="tempCodeProperty">Pass in a tempCodeProperty to perform a custom find.</param>
            public CodeProperty FindCodeProperty(int id, CodeProperty tempCodeProperty = null)
            {
                // initial value
                CodeProperty codeProperty = null;

                // if the AppController exists
                if (this.HasAppController)
                {
                    // if the tempCodeProperty does not exist
                    if (tempCodeProperty == null)
                    {
                        // create a temp CodeProperty
                        tempCodeProperty = new CodeProperty();
                    }

                    // if the id is set
                    if (id > 0)
                    {
                        // set the primary key
                        tempCodeProperty.UpdateIdentity(id);
                    }

                    // perform the find
                    codeProperty = this.AppController.ControllerManager.CodePropertyController.Find(tempCodeProperty);
                }

                // return value
                return codeProperty;
            }
            #endregion

            #region FindReferencedBy(int id, ReferencedBy tempReferencedBy = null)
            /// <summary>
            /// This method is used to find 'ReferencedBy' objects.
            /// </summary>
            /// <param name="id">Find the ReferencedBy with this id</param>
            /// <param name="tempReferencedBy">Pass in a tempReferencedBy to perform a custom find.</param>
            public ReferencedBy FindReferencedBy(int id, ReferencedBy tempReferencedBy = null)
            {
                // initial value
                ReferencedBy referencedBy = null;

                // if the AppController exists
                if (this.HasAppController)
                {
                    // if the tempReferencedBy does not exist
                    if (tempReferencedBy == null)
                    {
                        // create a temp ReferencedBy
                        tempReferencedBy = new ReferencedBy();
                    }

                    // if the id is set
                    if (id > 0)
                    {
                        // set the primary key
                        tempReferencedBy.UpdateIdentity(id);
                    }

                    // perform the find
                    referencedBy = this.AppController.ControllerManager.ReferencedByController.Find(tempReferencedBy);
                }

                // return value
                return referencedBy;
            }
            #endregion

            #region FindVSProject(int id, VSProject tempVSProject = null)
            /// <summary>
            /// This method is used to find 'VSProject' objects.
            /// </summary>
            /// <param name="id">Find the VSProject with this id</param>
            /// <param name="tempVSProject">Pass in a tempVSProject to perform a custom find.</param>
            public VSProject FindVSProject(int id, VSProject tempVSProject = null)
            {
                // initial value
                VSProject vSProject = null;

                // if the AppController exists
                if (this.HasAppController)
                {
                    // if the tempVSProject does not exist
                    if (tempVSProject == null)
                    {
                        // create a temp VSProject
                        tempVSProject = new VSProject();
                    }

                    // if the id is set
                    if (id > 0)
                    {
                        // set the primary key
                        tempVSProject.UpdateIdentity(id);
                    }

                    // perform the find
                    vSProject = this.AppController.ControllerManager.VSProjectController.Find(tempVSProject);
                }

                // return value
                return vSProject;
            }
            #endregion

            #region FindVSSolution(int id, VSSolution tempVSSolution = null)
            /// <summary>
            /// This method is used to find 'VSSolution' objects.
            /// </summary>
            /// <param name="id">Find the VSSolution with this id</param>
            /// <param name="tempVSSolution">Pass in a tempVSSolution to perform a custom find.</param>
            public VSSolution FindVSSolution(int id, VSSolution tempVSSolution = null)
            {
                // initial value
                VSSolution vSSolution = null;

                // if the AppController exists
                if (this.HasAppController)
                {
                    // if the tempVSSolution does not exist
                    if (tempVSSolution == null)
                    {
                        // create a temp VSSolution
                        tempVSSolution = new VSSolution();
                    }

                    // if the id is set
                    if (id > 0)
                    {
                        // set the primary key
                        tempVSSolution.UpdateIdentity(id);
                    }

                    // perform the find
                    vSSolution = this.AppController.ControllerManager.VSSolutionController.Find(tempVSSolution);
                }

                // return value
                return vSSolution;
            }
            #endregion

            #region GetDataConnector()
            /// <summary>
            /// This method (safely) returns the Data Connector from the
            /// AppController.DataBridget.DataManager.DataConnector
            /// </summary>
            private DataConnector GetDataConnector()
            {
                // initial value
                DataConnector dataConnector = null;

                // if the AppController exists
                if (this.AppController != null)
                {
                    // return the DataConnector from the AppController
                    dataConnector = this.AppController.GetDataConnector();
                }

                // return value
                return dataConnector;
            }
            #endregion

            #region GetLastException()
            /// <summary>
            /// This method returns the last Exception from the AppController if one exists.
            /// Always test for null before refeferencing the Exception returned as it will be null 
            /// if no errors were encountered.
            /// </summary>
            /// <returns></returns>
            public Exception GetLastException()
            {
                // initial value
                Exception exception = null;

                // If the AppController object exists
                if (this.HasAppController)
                {
                    // return the Exception from the AppController
                    exception = this.AppController.Exception;

                    // Set to null after the exception is retrieved so it does not return again
                    this.AppController.Exception = null;
                }

                // return value
                return exception;
            }
            #endregion

            #region Init()
            /// <summary>
            /// Perform Initializations for this object.
            /// </summary>
            private void Init()
            {
                // Create Application Controller
                this.AppController = new ApplicationController(ConnectionName);
            }
            #endregion

            #region LoadCodeClass(CodeClass tempCodeClass = null)
            /// <summary>
            /// This method loads a collection of 'CodeClass' objects.
            /// </summary>
            public List<CodeClass> LoadCodeClass(CodeClass tempCodeClass = null)
            {
                // initial value
                List<CodeClass> codeClass = null;

                // if the AppController exists
                if (this.HasAppController)
                {
                    // perform the load
                    codeClass = this.AppController.ControllerManager.CodeClassController.FetchAll(tempCodeClass);
                }

                // return value
                return codeClass;
            }
            #endregion

            #region LoadCodeConstructors(CodeConstructor tempCodeConstructor = null)
            /// <summary>
            /// This method loads a collection of 'CodeConstructor' objects.
            /// </summary>
            public List<CodeConstructor> LoadCodeConstructors(CodeConstructor tempCodeConstructor = null)
            {
                // initial value
                List<CodeConstructor> codeConstructors = null;

                // if the AppController exists
                if (this.HasAppController)
                {
                    // perform the load
                    codeConstructors = this.AppController.ControllerManager.CodeConstructorController.FetchAll(tempCodeConstructor);
                }

                // return value
                return codeConstructors;
            }
            #endregion

            #region LoadCodeEvents(CodeEvent tempCodeEvent = null)
            /// <summary>
            /// This method loads a collection of 'CodeEvent' objects.
            /// </summary>
            public List<CodeEvent> LoadCodeEvents(CodeEvent tempCodeEvent = null)
            {
                // initial value
                List<CodeEvent> codeEvents = null;

                // if the AppController exists
                if (this.HasAppController)
                {
                    // perform the load
                    codeEvents = this.AppController.ControllerManager.CodeEventController.FetchAll(tempCodeEvent);
                }

                // return value
                return codeEvents;
            }
            #endregion

            #region LoadCodeFiles(CodeFile tempCodeFile = null)
            /// <summary>
            /// This method loads a collection of 'CodeFile' objects.
            /// </summary>
            public List<CodeFile> LoadCodeFiles(CodeFile tempCodeFile = null)
            {
                // initial value
                List<CodeFile> codeFiles = null;

                // if the AppController exists
                if (this.HasAppController)
                {
                    // perform the load
                    codeFiles = this.AppController.ControllerManager.CodeFileController.FetchAll(tempCodeFile);
                }

                // return value
                return codeFiles;
            }
            #endregion

            #region LoadCodeMethods(CodeMethod tempCodeMethod = null)
            /// <summary>
            /// This method loads a collection of 'CodeMethod' objects.
            /// </summary>
            public List<CodeMethod> LoadCodeMethods(CodeMethod tempCodeMethod = null)
            {
                // initial value
                List<CodeMethod> codeMethods = null;

                // if the AppController exists
                if (this.HasAppController)
                {
                    // perform the load
                    codeMethods = this.AppController.ControllerManager.CodeMethodController.FetchAll(tempCodeMethod);
                }

                // return value
                return codeMethods;
            }
            #endregion

            #region LoadCodeParameters(CodeParameter tempCodeParameter = null)
            /// <summary>
            /// This method loads a collection of 'CodeParameter' objects.
            /// </summary>
            public List<CodeParameter> LoadCodeParameters(CodeParameter tempCodeParameter = null)
            {
                // initial value
                List<CodeParameter> codeParameters = null;

                // if the AppController exists
                if (this.HasAppController)
                {
                    // perform the load
                    codeParameters = this.AppController.ControllerManager.CodeParameterController.FetchAll(tempCodeParameter);
                }

                // return value
                return codeParameters;
            }
            #endregion

            #region LoadCodePropertys(CodeProperty tempCodeProperty = null)
            /// <summary>
            /// This method loads a collection of 'CodeProperty' objects.
            /// </summary>
            public List<CodeProperty> LoadCodePropertys(CodeProperty tempCodeProperty = null)
            {
                // initial value
                List<CodeProperty> codePropertys = null;

                // if the AppController exists
                if (this.HasAppController)
                {
                    // perform the load
                    codePropertys = this.AppController.ControllerManager.CodePropertyController.FetchAll(tempCodeProperty);
                }

                // return value
                return codePropertys;
            }
            #endregion

            #region LoadReferencedBys(ReferencedBy tempReferencedBy = null)
            /// <summary>
            /// This method loads a collection of 'ReferencedBy' objects.
            /// </summary>
            public List<ReferencedBy> LoadReferencedBys(ReferencedBy tempReferencedBy = null)
            {
                // initial value
                List<ReferencedBy> referencedBys = null;

                // if the AppController exists
                if (this.HasAppController)
                {
                    // perform the load
                    referencedBys = this.AppController.ControllerManager.ReferencedByController.FetchAll(tempReferencedBy);
                }

                // return value
                return referencedBys;
            }
            #endregion

            #region LoadVSProjects(VSProject tempVSProject = null)
            /// <summary>
            /// This method loads a collection of 'VSProject' objects.
            /// </summary>
            public List<VSProject> LoadVSProjects(VSProject tempVSProject = null)
            {
                // initial value
                List<VSProject> vSProjects = null;

                // if the AppController exists
                if (this.HasAppController)
                {
                    // perform the load
                    vSProjects = this.AppController.ControllerManager.VSProjectController.FetchAll(tempVSProject);
                }

                // return value
                return vSProjects;
            }
            #endregion

            #region LoadVSSolutions(VSSolution tempVSSolution = null)
            /// <summary>
            /// This method loads a collection of 'VSSolution' objects.
            /// </summary>
            public List<VSSolution> LoadVSSolutions(VSSolution tempVSSolution = null)
            {
                // initial value
                List<VSSolution> vSSolutions = null;

                // if the AppController exists
                if (this.HasAppController)
                {
                    // perform the load
                    vSSolutions = this.AppController.ControllerManager.VSSolutionController.FetchAll(tempVSSolution);
                }

                // return value
                return vSSolutions;
            }
            #endregion

            #region SaveCodeClass(ref CodeClass codeClass)
            /// <summary>
            /// This method is used to save 'CodeClass' objects.
            /// </summary>
            /// <param name="codeClass">The CodeClass to save.</param>
            public bool SaveCodeClass(ref CodeClass codeClass)
            {
                // initial value
                bool saved = false;

                // if the AppController exists
                if (this.HasAppController)
                {
                    // perform the save
                    saved = this.AppController.ControllerManager.CodeClassController.Save(ref codeClass);
                }

                // return value
                return saved;
            }
            #endregion

            #region SaveCodeConstructor(ref CodeConstructor codeConstructor)
            /// <summary>
            /// This method is used to save 'CodeConstructor' objects.
            /// </summary>
            /// <param name="codeConstructor">The CodeConstructor to save.</param>
            public bool SaveCodeConstructor(ref CodeConstructor codeConstructor)
            {
                // initial value
                bool saved = false;

                // if the AppController exists
                if (this.HasAppController)
                {
                    // perform the save
                    saved = this.AppController.ControllerManager.CodeConstructorController.Save(ref codeConstructor);
                }

                // return value
                return saved;
            }
            #endregion

            #region SaveCodeEvent(ref CodeEvent codeEvent)
            /// <summary>
            /// This method is used to save 'CodeEvent' objects.
            /// </summary>
            /// <param name="codeEvent">The CodeEvent to save.</param>
            public bool SaveCodeEvent(ref CodeEvent codeEvent)
            {
                // initial value
                bool saved = false;

                // if the AppController exists
                if (this.HasAppController)
                {
                    // perform the save
                    saved = this.AppController.ControllerManager.CodeEventController.Save(ref codeEvent);
                }

                // return value
                return saved;
            }
            #endregion

            #region SaveCodeFile(ref CodeFile codeFile)
            /// <summary>
            /// This method is used to save 'CodeFile' objects.
            /// </summary>
            /// <param name="codeFile">The CodeFile to save.</param>
            public bool SaveCodeFile(ref CodeFile codeFile)
            {
                // initial value
                bool saved = false;

                // if the AppController exists
                if (this.HasAppController)
                {
                    // perform the save
                    saved = this.AppController.ControllerManager.CodeFileController.Save(ref codeFile);
                }

                // return value
                return saved;
            }
            #endregion

            #region SaveCodeMethod(ref CodeMethod codeMethod)
            /// <summary>
            /// This method is used to save 'CodeMethod' objects.
            /// </summary>
            /// <param name="codeMethod">The CodeMethod to save.</param>
            public bool SaveCodeMethod(ref CodeMethod codeMethod)
            {
                // initial value
                bool saved = false;

                // if the AppController exists
                if (this.HasAppController)
                {
                    // perform the save
                    saved = this.AppController.ControllerManager.CodeMethodController.Save(ref codeMethod);
                }

                // return value
                return saved;
            }
            #endregion

            #region SaveCodeParameter(ref CodeParameter codeParameter)
            /// <summary>
            /// This method is used to save 'CodeParameter' objects.
            /// </summary>
            /// <param name="codeParameter">The CodeParameter to save.</param>
            public bool SaveCodeParameter(ref CodeParameter codeParameter)
            {
                // initial value
                bool saved = false;

                // if the AppController exists
                if (this.HasAppController)
                {
                    // perform the save
                    saved = this.AppController.ControllerManager.CodeParameterController.Save(ref codeParameter);
                }

                // return value
                return saved;
            }
            #endregion

            #region SaveCodeProperty(ref CodeProperty codeProperty)
            /// <summary>
            /// This method is used to save 'CodeProperty' objects.
            /// </summary>
            /// <param name="codeProperty">The CodeProperty to save.</param>
            public bool SaveCodeProperty(ref CodeProperty codeProperty)
            {
                // initial value
                bool saved = false;

                // if the AppController exists
                if (this.HasAppController)
                {
                    // perform the save
                    saved = this.AppController.ControllerManager.CodePropertyController.Save(ref codeProperty);
                }

                // return value
                return saved;
            }
            #endregion

            #region SaveReferencedBy(ref ReferencedBy referencedBy)
            /// <summary>
            /// This method is used to save 'ReferencedBy' objects.
            /// </summary>
            /// <param name="referencedBy">The ReferencedBy to save.</param>
            public bool SaveReferencedBy(ref ReferencedBy referencedBy)
            {
                // initial value
                bool saved = false;

                // if the AppController exists
                if (this.HasAppController)
                {
                    // perform the save
                    saved = this.AppController.ControllerManager.ReferencedByController.Save(ref referencedBy);
                }

                // return value
                return saved;
            }
            #endregion

            #region SaveVSProject(ref VSProject vSProject)
            /// <summary>
            /// This method is used to save 'VSProject' objects.
            /// </summary>
            /// <param name="vSProject">The VSProject to save.</param>
            public bool SaveVSProject(ref VSProject vSProject)
            {
                // initial value
                bool saved = false;

                // if the AppController exists
                if (this.HasAppController)
                {
                    // perform the save
                    saved = this.AppController.ControllerManager.VSProjectController.Save(ref vSProject);
                }

                // return value
                return saved;
            }
            #endregion

            #region SaveVSSolution(ref VSSolution vSSolution)
            /// <summary>
            /// This method is used to save 'VSSolution' objects.
            /// </summary>
            /// <param name="vSSolution">The VSSolution to save.</param>
            public bool SaveVSSolution(ref VSSolution vSSolution)
            {
                // initial value
                bool saved = false;

                // if the AppController exists
                if (this.HasAppController)
                {
                    // perform the save
                    saved = this.AppController.ControllerManager.VSSolutionController.Save(ref vSSolution);
                }

                // return value
                return saved;
            }
            #endregion

        #endregion

        #region Properties

            #region AppController
            /// <summary>
            /// This property gets or sets the value for 'AppController'.
            /// </summary>
            public ApplicationController AppController
            {
                get { return appController; }
                set { appController = value; }
            }
            #endregion

            #region ConnectionName
            /// <summary>
            /// This property gets or sets the value for 'ConnectionName'.
            /// </summary>
            public string ConnectionName
            {
                get { return connectionName; }
                set { connectionName = value; }
            }
            #endregion
            
            #region HasAppController
            /// <summary>
            /// This property returns true if this object has an 'AppController'.
            /// </summary>
            public bool HasAppController
            {
                get
                {
                    // initial value
                    bool hasAppController = (this.AppController != null);

                    // return value
                    return hasAppController;
                }
            }
            #endregion

            #region HasConnectionName
            /// <summary>
            /// This property returns true if the 'ConnectionName' exists.
            /// </summary>
            public bool HasConnectionName
            {
                get
                {
                    // initial value
                    bool hasConnectionName = (!String.IsNullOrEmpty(this.ConnectionName));
                    
                    // return value
                    return hasConnectionName;
                }
            }
            #endregion
            
        #endregion

    }
    #endregion

}

