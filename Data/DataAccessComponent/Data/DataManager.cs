

#region using statements

using DataJuggler.DocGen.DataAccessComponent.Data.Readers;
using DataJuggler.DocGen.DataAccessComponent.StoredProcedureManager.DeleteProcedures;
using DataJuggler.DocGen.DataAccessComponent.StoredProcedureManager.FetchProcedures;
using DataJuggler.DocGen.DataAccessComponent.StoredProcedureManager.InsertProcedures;
using DataJuggler.DocGen.DataAccessComponent.StoredProcedureManager.UpdateProcedures;
using DataJuggler.DocGen.ObjectLibrary.BusinessObjects;
using System;
using System.Collections.Generic;
using System.Data;

#endregion


namespace DataJuggler.DocGen.DataAccessComponent.Data
{

    #region class DataManager
    /// <summary>
    /// This class manages data operations for this project.
    /// </summary>
    public class DataManager
    {

        #region Private Variables
        private DataConnector dataConnector;
        private string connectionName;
        private CodeClassManager codeclassManager;
        private CodeConstructorManager codeconstructorManager;
        private CodeFileManager codefileManager;
        private CodeMethodManager codemethodManager;
        private CodeParameterManager codeparameterManager;
        private CodePropertyManager codepropertyManager;
        private CodeSampleManager codesampleManager;
        private ReferencedByManager referencedbyManager;
        private VSProjectManager vsprojectManager;
        private VSSolutionManager vssolutionManager;
        #endregion

        #region Constructor
        /// <summary>
        /// Creates a new instance of a(n) 'DataManager' object.
        /// </summary>
        public DataManager(string connectionName = "")
        {
            // Store the ConnectionName arg
            this.ConnectionName = connectionName;

            // Perform Initializations For This Object.
            Init();
        }
        #endregion

        #region Methods

            #region Init()
            /// <summary>
            /// Perform Initializations For This Object.
            /// Create the DataConnector and the Child Object Managers.
            /// </summary>
            private void Init()
            {
                // Create New DataConnector
                this.DataConnector = new DataConnector();

                // Create Child Object Managers
                this.CodeClassManager = new CodeClassManager(this);
                this.CodeConstructorManager = new CodeConstructorManager(this);
                this.CodeFileManager = new CodeFileManager(this);
                this.CodeMethodManager = new CodeMethodManager(this);
                this.CodeParameterManager = new CodeParameterManager(this);
                this.CodePropertyManager = new CodePropertyManager(this);
                this.CodeSampleManager = new CodeSampleManager(this);
                this.ReferencedByManager = new ReferencedByManager(this);
                this.VSProjectManager = new VSProjectManager(this);
                this.VSSolutionManager = new VSSolutionManager(this);
            }
            #endregion

        #endregion

        #region Properties

            #region DataConnector
            public DataConnector DataConnector
            {
                get { return dataConnector; }
                set { dataConnector = value; }
            }
            #endregion

            #region ConnectionName
            public string ConnectionName
            {
                get { return connectionName; }
                set { connectionName = value; }
            }
            #endregion

            #region CodeClassManager
            public CodeClassManager CodeClassManager
            {
                get { return codeclassManager; }
                set { codeclassManager = value; }
            }
            #endregion

            #region CodeConstructorManager
            public CodeConstructorManager CodeConstructorManager
            {
                get { return codeconstructorManager; }
                set { codeconstructorManager = value; }
            }
            #endregion

            #region CodeFileManager
            public CodeFileManager CodeFileManager
            {
                get { return codefileManager; }
                set { codefileManager = value; }
            }
            #endregion

            #region CodeMethodManager
            public CodeMethodManager CodeMethodManager
            {
                get { return codemethodManager; }
                set { codemethodManager = value; }
            }
            #endregion

            #region CodeParameterManager
            public CodeParameterManager CodeParameterManager
            {
                get { return codeparameterManager; }
                set { codeparameterManager = value; }
            }
            #endregion

            #region CodePropertyManager
            public CodePropertyManager CodePropertyManager
            {
                get { return codepropertyManager; }
                set { codepropertyManager = value; }
            }
            #endregion

            #region CodeSampleManager
            public CodeSampleManager CodeSampleManager
            {
                get { return codesampleManager; }
                set { codesampleManager = value; }
            }
            #endregion

            #region ReferencedByManager
            public ReferencedByManager ReferencedByManager
            {
                get { return referencedbyManager; }
                set { referencedbyManager = value; }
            }
            #endregion

            #region VSProjectManager
            public VSProjectManager VSProjectManager
            {
                get { return vsprojectManager; }
                set { vsprojectManager = value; }
            }
            #endregion

            #region VSSolutionManager
            public VSSolutionManager VSSolutionManager
            {
                get { return vssolutionManager; }
                set { vssolutionManager = value; }
            }
            #endregion

        #endregion

    }
    #endregion

}
