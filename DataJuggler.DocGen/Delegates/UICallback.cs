

#region using statements

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

#endregion

namespace DataJuggler.DocGen.Delegates
{

    #region class UICallback
    /// <summary>
    /// This class is used so the UI can get a callback as operations are taking place
    /// </summary>
    public class UICallback
    {
        
        #region Private Variables
        private UpdateProgress batchProgress;
        private UpdateProgress overallProgress;
        #endregion
        
        #region Constructor
        /// <summary>
        /// Create a new instance of a 'UICallback' object.
        /// </summary>
        public UICallback(UpdateProgress batchProgressCallback, UpdateProgress overallProgressCallback)
        {
            // store
            BatchProgress = batchProgressCallback;
            OverallProgress = overallProgressCallback;
        }
        #endregion
        
        #region Events
            
        #endregion
        
        #region Methods
            
        #endregion
        
        #region Properties
            
            #region BatchProgress
            /// <summary>
            /// This property gets or sets the value for 'BatchProgress'.
            /// </summary>
            public UpdateProgress BatchProgress
            {
                get { return batchProgress; }
                set { batchProgress = value; }
            }
            #endregion
            
            #region HasBatchProgress
            /// <summary>
            /// This property returns true if this object has a 'BatchProgress'.
            /// </summary>
            public bool HasBatchProgress
            {
                get
                {
                    // initial value
                    bool hasBatchProgress = (this.BatchProgress != null);
                    
                    // return value
                    return hasBatchProgress;
                }
            }
            #endregion
            
            #region HasOverallProgress
            /// <summary>
            /// This property returns true if this object has an 'OverallProgress'.
            /// </summary>
            public bool HasOverallProgress
            {
                get
                {
                    // initial value
                    bool hasOverallProgress = (this.OverallProgress != null);
                    
                    // return value
                    return hasOverallProgress;
                }
            }
            #endregion
            
            #region OverallProgress
            /// <summary>
            /// This property gets or sets the value for 'OverallProgress'.
            /// </summary>
            public UpdateProgress OverallProgress
            {
                get { return overallProgress; }
                set { overallProgress = value; }
            }
            #endregion
            
        #endregion
        
    }
    #endregion

}
