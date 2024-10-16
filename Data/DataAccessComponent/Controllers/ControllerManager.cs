

#region using statements

using DataAccessComponent.DataBridge;
using DataAccessComponent.DataOperations;
using DataAccessComponent.Logging;
using ObjectLibrary.BusinessObjects;
using System;
using System.Collections.Generic;

#endregion


namespace DataAccessComponent.Controllers
{

    #region class ControllerManager
    /// <summary>
    /// This class manages the child controllers for this application.
    /// </summary>
    public class ControllerManager
    {

        #region Private Variables
        private ErrorHandler errorProcessor;
        private ApplicationController appController;
        private CodeClassController codeclassController;
        private CodeConstructorController codeconstructorController;
        private CodeFileController codefileController;
        private CodeMethodController codemethodController;
        private CodeParameterController codeparameterController;
        private CodePropertyController codepropertyController;
        private CodeSampleController codesampleController;
        private ReferencedByController referencedbyController;
        private VSProjectController vsprojectController;
        private VSSolutionController vssolutionController;
        #endregion

        #region Constructor
        /// <summary>
        /// Creates a new Creates a new 'ControllerManager' object.
        /// </summary>
        public ControllerManager(ErrorHandler errorProcessorArg, ApplicationController appControllerArg)
        {
            // Save Arguments
            this.ErrorProcessor = errorProcessorArg;
            this.AppController = appControllerArg;

            // Create Child Controllers
            Init();
        }
        #endregion

        #region Methods

            #region Init()
            /// <summary>
            /// Create Child Controllers
            /// </summary>
            private void Init()
            {
                // Create Child Controllers
                this.CodeClassController = new CodeClassController(this.ErrorProcessor, this.AppController);
                this.CodeConstructorController = new CodeConstructorController(this.ErrorProcessor, this.AppController);
                this.CodeFileController = new CodeFileController(this.ErrorProcessor, this.AppController);
                this.CodeMethodController = new CodeMethodController(this.ErrorProcessor, this.AppController);
                this.CodeParameterController = new CodeParameterController(this.ErrorProcessor, this.AppController);
                this.CodePropertyController = new CodePropertyController(this.ErrorProcessor, this.AppController);
                this.CodeSampleController = new CodeSampleController(this.ErrorProcessor, this.AppController);
                this.ReferencedByController = new ReferencedByController(this.ErrorProcessor, this.AppController);
                this.VSProjectController = new VSProjectController(this.ErrorProcessor, this.AppController);
                this.VSSolutionController = new VSSolutionController(this.ErrorProcessor, this.AppController);
            }
            #endregion

        #endregion

        #region Properties

            #region AppController
            public ApplicationController AppController
            {
                get { return appController; }
                set { appController = value; }
            }
            #endregion

            #region ErrorProcessor
            public ErrorHandler ErrorProcessor
            {
                get { return errorProcessor; }
                set { errorProcessor = value; }
            }
            #endregion

            #region CodeClassController
            public CodeClassController CodeClassController
            {
                get { return codeclassController; }
                set { codeclassController = value; }
            }
            #endregion

            #region CodeConstructorController
            public CodeConstructorController CodeConstructorController
            {
                get { return codeconstructorController; }
                set { codeconstructorController = value; }
            }
            #endregion

            #region CodeFileController
            public CodeFileController CodeFileController
            {
                get { return codefileController; }
                set { codefileController = value; }
            }
            #endregion

            #region CodeMethodController
            public CodeMethodController CodeMethodController
            {
                get { return codemethodController; }
                set { codemethodController = value; }
            }
            #endregion

            #region CodeParameterController
            public CodeParameterController CodeParameterController
            {
                get { return codeparameterController; }
                set { codeparameterController = value; }
            }
            #endregion

            #region CodePropertyController
            public CodePropertyController CodePropertyController
            {
                get { return codepropertyController; }
                set { codepropertyController = value; }
            }
            #endregion

            #region CodeSampleController
            public CodeSampleController CodeSampleController
            {
                get { return codesampleController; }
                set { codesampleController = value; }
            }
            #endregion

            #region ReferencedByController
            public ReferencedByController ReferencedByController
            {
                get { return referencedbyController; }
                set { referencedbyController = value; }
            }
            #endregion

            #region VSProjectController
            public VSProjectController VSProjectController
            {
                get { return vsprojectController; }
                set { vsprojectController = value; }
            }
            #endregion

            #region VSSolutionController
            public VSSolutionController VSSolutionController
            {
                get { return vssolutionController; }
                set { vssolutionController = value; }
            }
            #endregion

        #endregion

    }
    #endregion

}
