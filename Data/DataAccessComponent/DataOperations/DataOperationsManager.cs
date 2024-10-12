

#region using statements

using DataAccessComponent.Data;
using DataAccessComponent.Data.Writers;
using DataAccessComponent.DataBridge;
using DataAccessComponent.StoredProcedureManager.DeleteProcedures;
using DataAccessComponent.StoredProcedureManager.FetchProcedures;
using DataAccessComponent.StoredProcedureManager.InsertProcedures;
using DataAccessComponent.StoredProcedureManager.UpdateProcedures;
using ObjectLibrary.BusinessObjects;
using System;
using System.Collections.Generic;

#endregion


namespace DataAccessComponent.DataOperations
{

    #region class DataOperationsManager
    /// <summary>
    /// This class manages DataOperations for this project.
    /// </summary>
    public class DataOperationsManager
    {

        #region Private Variables
        private DataManager dataManager;
        private SystemMethods systemMethods;
        private CodeClassMethods codeclassMethods;
        private CodeConstructorMethods codeconstructorMethods;
        private CodeEventMethods codeeventMethods;
        private CodeFileMethods codefileMethods;
        private CodeMethodMethods codemethodMethods;
        private CodeParameterMethods codeparameterMethods;
        private CodePropertyMethods codepropertyMethods;
        private ReferencedByMethods referencedbyMethods;
        private VSProjectMethods vsprojectMethods;
        private VSSolutionMethods vssolutionMethods;
        #endregion

        #region Constructor
        /// <summary>
        /// Creates a new Creates a new 'DataOperationsManager' object.
        /// </summary>
        public DataOperationsManager(DataManager dataManagerArg)
        {
            // Save Arguments
            this.DataManager = dataManagerArg;

            // Create Child DataOperationMethods
            Init();
        }
        #endregion

        #region Methods

            #region Init()
            /// <summary>
            /// Create Child DataOperationMethods
            /// </summary>
            private void Init()
            {
                // Create Child DataOperatonMethods
                this.SystemMethods = new SystemMethods();
                this.CodeClassMethods = new CodeClassMethods(this.DataManager);
                this.CodeConstructorMethods = new CodeConstructorMethods(this.DataManager);
                this.CodeEventMethods = new CodeEventMethods(this.DataManager);
                this.CodeFileMethods = new CodeFileMethods(this.DataManager);
                this.CodeMethodMethods = new CodeMethodMethods(this.DataManager);
                this.CodeParameterMethods = new CodeParameterMethods(this.DataManager);
                this.CodePropertyMethods = new CodePropertyMethods(this.DataManager);
                this.ReferencedByMethods = new ReferencedByMethods(this.DataManager);
                this.VSProjectMethods = new VSProjectMethods(this.DataManager);
                this.VSSolutionMethods = new VSSolutionMethods(this.DataManager);
            }
            #endregion

        #endregion

        #region Properties

            #region DataManager
            public DataManager DataManager
            {
                get { return dataManager; }
                set { dataManager = value; }
            }
            #endregion

            #region SystemMethods
            public SystemMethods SystemMethods
            {
                get { return systemMethods; }
                set { systemMethods = value; }
            }
            #endregion

            #region CodeClassMethods
            public CodeClassMethods CodeClassMethods
            {
                get { return codeclassMethods; }
                set { codeclassMethods = value; }
            }
            #endregion

            #region CodeConstructorMethods
            public CodeConstructorMethods CodeConstructorMethods
            {
                get { return codeconstructorMethods; }
                set { codeconstructorMethods = value; }
            }
            #endregion

            #region CodeEventMethods
            public CodeEventMethods CodeEventMethods
            {
                get { return codeeventMethods; }
                set { codeeventMethods = value; }
            }
            #endregion

            #region CodeFileMethods
            public CodeFileMethods CodeFileMethods
            {
                get { return codefileMethods; }
                set { codefileMethods = value; }
            }
            #endregion

            #region CodeMethodMethods
            public CodeMethodMethods CodeMethodMethods
            {
                get { return codemethodMethods; }
                set { codemethodMethods = value; }
            }
            #endregion

            #region CodeParameterMethods
            public CodeParameterMethods CodeParameterMethods
            {
                get { return codeparameterMethods; }
                set { codeparameterMethods = value; }
            }
            #endregion

            #region CodePropertyMethods
            public CodePropertyMethods CodePropertyMethods
            {
                get { return codepropertyMethods; }
                set { codepropertyMethods = value; }
            }
            #endregion

            #region ReferencedByMethods
            public ReferencedByMethods ReferencedByMethods
            {
                get { return referencedbyMethods; }
                set { referencedbyMethods = value; }
            }
            #endregion

            #region VSProjectMethods
            public VSProjectMethods VSProjectMethods
            {
                get { return vsprojectMethods; }
                set { vsprojectMethods = value; }
            }
            #endregion

            #region VSSolutionMethods
            public VSSolutionMethods VSSolutionMethods
            {
                get { return vssolutionMethods; }
                set { vssolutionMethods = value; }
            }
            #endregion

        #endregion

    }
    #endregion

}
