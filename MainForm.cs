

#region using statements

using System;
using DataJuggler.UltimateHelper;
using Microsoft.CodeAnalysis;
using Microsoft.CodeAnalysis.CSharp.Syntax;
using Microsoft.CodeAnalysis.MSBuild;
using System.Linq;
using Microsoft.CodeAnalysis.FindSymbols;
using ObjectLibrary.BusinessObjects;
using DataAccessComponent.DataGateway;
using DataAccessComponent.Connection;
using Microsoft.Build.Evaluation;
using Project = Microsoft.CodeAnalysis.Project;
using MSProject = Microsoft.Build.Evaluation.Project;
using DataJuggler.DocGen;

#endregion

namespace DocGen
{

    #region class MainForm
    /// <summary>
    /// This class is the Main Form for this app.
    /// </summary>
    public partial class MainForm : Form
    {

        #region Private Variables
        private VSSolution solution;
        private Gateway gateway;
        #endregion

        #region Constructor
        /// <summary>
        /// Create a new instance of a 'MainForm' object.
        /// </summary>
        public MainForm()
        {
            // Create Controls
            InitializeComponent();

            // Perform initializations for this object
            Init();
        }
        #endregion

        #region Events

        #region AnalyzeButton_Click(object sender, EventArgs e)
        /// <summary>
        /// event is fired when the 'AnalyzeButton' is clicked.
        /// </summary>
        private async void AnalyzeButton_Click(object sender, EventArgs e)
        {
            try
            {
                // Retrieve the Solution
                Solution = await DocGenerator.AnalyzeSolution(SolutionSelector.Text);

                if (Solution.Errors.Count > 0)
                {
                    // Show Success
                    DescriptionControl.Text = "Errors!";
                }
                else
                {
                    // Show Success
                    DescriptionControl.Text = "Success!";
                }

                

                // Set the properties
                Solution.Description = DescriptionControl.Text;
                Solution.CreatedDate = DateTime.Now;

                // if the project exists
                if (ListHelper.HasOneOrMoreItems(Solution.Projects))
                {
                    // iterate the projects                    
                    foreach (VSProject vsProject in solution.Projects)
                    {
                        

                        
                    }
                }
            }
            catch (Exception error)
            {
                DescriptionControl.Text = error.ToString();

                // For debugging only for now
                DebugHelper.WriteDebugError("AnalyzeButton_Click", "MainForm.cs", error);
            }
        }
        #endregion

        #region OpenSolutionButton_Click(object sender, EventArgs e)
        /// <summary>
        /// event is fired when the 'OpenSolutionButton' is clicked.
        /// </summary>
        private void OpenSolutionButton_Click(object sender, EventArgs e)
        {
            // To Do: Add Open Solution UI
        }
        #endregion

        #region SaveButton_Click(object sender, EventArgs e)
        /// <summary>
        /// event is fired when the 'SaveButton' is clicked.
        /// </summary>
        private void SaveButton_Click(object sender, EventArgs e)
        {
            
        }
        #endregion
            
        #endregion

        #region Methods

            #region Init()
            /// <summary>
            ///  This method performs initializations for this object.
            /// </summary>
            public void Init()
            {
                // For Testing Only
                // SolutionSelector.Text = "C:\\Projects\\GitHub\\DataJuggler.Blazor.Components\\DataJuggler.Blazor.Components.sln";

                // Create a new instance of a 'Gateway' object.
                Gateway = new Gateway(Connection.Name);
            }
            #endregion
           
            #region SetupCurrentProjectGraph(string statusText, int max, int value)
            /// <summary>
            /// Setup Current Project Graph
            /// </summary>
            public void SetupCurrentProjectGraph(string statusText, int max, int value)
            {
                // Display
                CurrentStatusLabel.Text = statusText;

                // Setup Graph
                CurrentGraph.Maximum = max;
                CurrentGraph.Value = value;
            }
            #endregion
            
            #region SetupGraph(string statusText, int max, int value)
            /// <summary>
            /// Setup Graph
            /// </summary>
            public void SetupGraph(string statusText, int max, int value)
            {
                // Display
                StatusLabel.Text = statusText;

                // Setup Graph
                Graph.Maximum = max;
                Graph.Value = value;
            }
            #endregion
            
        #endregion

        #region Properties

            #region Gateway
            /// <summary>
            /// This property gets or sets the value for 'Gateway'.
            /// </summary>
            public Gateway Gateway
            {
                get { return gateway; }
                set { gateway = value; }
            }
            #endregion
            
            #region HasSolution
            /// <summary>
            /// This property returns true if this object has a 'Solution'.
            /// </summary>
            public bool HasSolution
            {
                get
                {
                    // initial value
                    bool hasSolution = (this.Solution != null);
                    
                    // return value
                    return hasSolution;
                }
            }
            #endregion
            
            #region Solution
            /// <summary>
            /// This property gets or sets the value for 'Solution'.
            /// </summary>
            public VSSolution Solution
            {
                get { return solution; }
                set { solution = value; }
            }
            #endregion
            
        #endregion
    }
    #endregion

}
