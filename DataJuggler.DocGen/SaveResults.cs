

#region using statements


#endregion

namespace DataJuggler.DocGen
{

    #region class SaveResults
    /// <summary>
    /// This class is used to return the results of a Save.
    /// </summary>
    public class SaveResults
    {
        
        #region Private Variables
        private int codeClassesSaved;
        private int codeConstructorsSaved;
        private int codeFilesSaved;
        private int codeMethodsSaved;
        private int codeParametersSaved;
        private int codePropertiesSaved;
        private int codeSamplesSaved;
        private List<Exception> exceptions;
        private int referencedBysSaved;
        private int eventHandlersSaved;
        private int vsProjectsSaved;
        private int vsSolutionsSaved;
        #endregion
        
        #region Constructor
        /// <summary>
        /// Create a new instance of a 'SaveResults' object.
        /// </summary>
        public SaveResults()
        {
            // Create a new collection of 'Exception' objects.
            Exceptions = new List<Exception>();
        }
        #endregion
        
        #region Events
            
        #endregion
        
        #region Methods
            
        #endregion
        
        #region Properties
            
            #region CodeClassesSaved
            /// <summary>
            /// This property gets or sets the value for 'CodeClassesSaved'.
            /// </summary>
            public int CodeClassesSaved
            {
                get { return codeClassesSaved; }
                set { codeClassesSaved = value; }
            }
            #endregion
            
            #region CodeConstructorsSaved
            /// <summary>
            /// This property gets or sets the value for 'CodeConstructorsSaved'.
            /// </summary>
            public int CodeConstructorsSaved
            {
                get { return codeConstructorsSaved; }
                set { codeConstructorsSaved = value; }
            }
            #endregion
            
            #region CodeFilesSaved
            /// <summary>
            /// This property gets or sets the value for 'CodeFilesSaved'.
            /// </summary>
            public int CodeFilesSaved
            {
                get { return codeFilesSaved; }
                set { codeFilesSaved = value; }
            }
            #endregion
            
            #region CodeMethodsSaved
            /// <summary>
            /// This property gets or sets the value for 'CodeMethodsSaved'.
            /// </summary>
            public int CodeMethodsSaved
            {
                get { return codeMethodsSaved; }
                set { codeMethodsSaved = value; }
            }
            #endregion
            
            #region CodeParametersSaved
            /// <summary>
            /// This property gets or sets the value for 'CodeParametersSaved'.
            /// </summary>
            public int CodeParametersSaved
            {
                get { return codeParametersSaved; }
                set { codeParametersSaved = value; }
            }
            #endregion
            
            #region CodePropertiesSaved
            /// <summary>
            /// This property gets or sets the value for 'CodePropertiesSaved'.
            /// </summary>
            public int CodePropertiesSaved
            {
                get { return codePropertiesSaved; }
                set { codePropertiesSaved = value; }
            }
            #endregion
            
            #region CodeSamplesSaved
            /// <summary>
            /// This property gets or sets the value for 'CodeSamplesSaved'.
            /// </summary>
            public int CodeSamplesSaved
            {
                get { return codeSamplesSaved; }
                set { codeSamplesSaved = value; }
            }
            #endregion
            
            #region EventHandlersSaved
            /// <summary>
            /// This property gets or sets the value for 'EventHandlersSaved'.
            /// </summary>
            public int EventHandlersSaved
            {
                get { return eventHandlersSaved; }
                set { eventHandlersSaved = value; }
            }
            #endregion
            
            #region Exceptions
            /// <summary>
            /// This property gets or sets the value for 'Exceptions'.
            /// </summary>
            public List<Exception> Exceptions
            {
                get { return exceptions; }
                set { exceptions = value; }
            }
            #endregion
            
            #region ReferencedBysSaved
            /// <summary>
            /// This property gets or sets the value for 'ReferencedBysSaved'.
            /// </summary>
            public int ReferencedBysSaved
            {
                get { return referencedBysSaved; }
                set { referencedBysSaved = value; }
            }
            #endregion
            
            #region VsProjectsSaved
            /// <summary>
            /// This property gets or sets the value for 'VsProjectsSaved'.
            /// </summary>
            public int VsProjectsSaved
            {
                get { return vsProjectsSaved; }
                set { vsProjectsSaved = value; }
            }
            #endregion
            
            #region VsSolutionsSaved
            /// <summary>
            /// This property gets or sets the value for 'VsSolutionsSaved'.
            /// </summary>
            public int VsSolutionsSaved
            {
                get { return vsSolutionsSaved; }
                set { vsSolutionsSaved = value; }
            }
            #endregion
            
        #endregion
        
    }
    #endregion

}
