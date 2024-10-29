

#region using statements

using DataJuggler.DocGen;
using DataJuggler.DocGen.Delegates;
using DataJuggler.UltimateHelper;
using ObjectLibrary.BusinessObjects;
using DataAccessComponent.DataGateway;
using DataAccessComponent.Connection;
using Microsoft.CodeAnalysis;

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
                // Show the controls
                ShowProgressControls(true);

                // Create a new instance of an 'UICallback' object.
                UICallback uICallback = new UICallback(UpdateBatchProgress, UpdateOverallProgress);

                // Retrieve the Solution
                Solution = await DocGenerator.AnalyzeSolution(SolutionSelector.Text, uICallback);

                // Enable the SaveButton
                SaveButton.Enabled = Solution.HasProjects;  

                // Display the Results
                ResultsLabel.Text = "Analysis Results";
                ResultsPanel.Visible = true;

                // Hide the controls
                ShowProgressControls(false);

                // Display what was found
                DisplaySolutionResults();
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
            // Show the controls
            ShowProgressControls(true);

            // if the value for HasSolution is true
            if (HasSolution)
            {
                // Set the properties
                Solution.Description = DescriptionControl.Text;
                Solution.Name = SolutionNameControl.Text;
                Solution.CreatedDate = DateTime.Now;

                // Create a new instance of an 'UICallback' object.
                UICallback uICallback = new UICallback(UpdateBatchProgress, UpdateOverallProgress);

                // if the project exists
                if (ListHelper.HasOneOrMoreItems(Solution.Projects))
                {
                    // Perform the Save
                    SaveResults savedResults = DocGenerator.Save(solution, uICallback);

                    // DisplayResults
                    SolutionsSavedLabel.Text = savedResults.VsSolutionsSaved.ToString();
                    ProjectsSavedLabel.Text = savedResults.VsProjectsSaved.ToString();
                    CodeFilesSavedLabel.Text = savedResults.CodeFilesSaved.ToString("#,##0");
                    ClassesSavedLabel.Text = savedResults.CodeClassesSaved.ToString("#,##0");
                    ParametersSavedLabel.Text = savedResults.CodeParametersSaved.ToString("#,##0");
                    MethodsSavedLabel.Text = savedResults.CodeMethodsSaved.ToString("#,##0");
                    EventHandlersSavedLabel.Text = savedResults.EventHandlersSaved.ToString("#,##0");
                    PropertiesSavedLabel.Text = savedResults.CodePropertiesSaved.ToString("#,##0");
                    ConstructorsSavedLabel.Text = savedResults.CodeConstructorsSaved.ToString("#,##0");
                    ExceptionsStatusLabel.Text = savedResults.Exceptions.Count.ToString("#,##0");
                    ReferencedBySavedLabel.Text = savedResults.ReferencedBysSaved.ToString("#,##0");
                    
                    // Hide the controls
                    ShowProgressControls(false);

                    // Show                    
                    ResultsLabel.Text = "Save Results";
                    ResultsPanel.Visible = true;

                    if (savedResults.Exceptions.Count > 0)
                    {
                        string temp = savedResults.Exceptions[0].Message;
                    }
                }
            }
        }
        #endregion
            
        #endregion

        #region Methods

            #region DisplaySolutionResults()
            /// <summary>
            /// Display Solution Results
            /// </summary>
            public void DisplaySolutionResults()
            {
                // if the value for HasSolution is true
                if (HasSolution)
                {
                    // DisplayResults
                    SolutionsSavedLabel.Text = "1";
                    ProjectsSavedLabel.Text = Solution.Projects.Count.ToString("#,##0");
                    CodeFilesSavedLabel.Text = Solution.Projects.SelectMany(p => p.CodeFiles).Count().ToString("#,##0");
                    ClassesSavedLabel.Text = Solution.Projects.SelectMany(p => p.CodeFiles).SelectMany(cf => cf.Classes).Count().ToString("#,##0");  
                    ParametersSavedLabel.Text = Solution.Projects.SelectMany(p => p.CodeFiles).SelectMany(cf => cf.Classes).SelectMany(cl => cl.Methods).SelectMany(cm => cm.Parameters).Count().ToString("#,##0");
                    MethodsSavedLabel.Text = Solution.Projects.SelectMany(p => p.CodeFiles).SelectMany(cf => cf.Classes).SelectMany(cl => cl.Methods).Count(m => !m.IsEventHandler).ToString("#,##0");
                    EventHandlersSavedLabel.Text = Solution.Projects.SelectMany(p => p.CodeFiles).SelectMany(cf => cf.Classes).SelectMany(cl => cl.Methods).Count(m => m.IsEventHandler).ToString("#,##0");
                    PropertiesSavedLabel.Text = Solution.Projects.SelectMany(p => p.CodeFiles).SelectMany(cf => cf.Classes).SelectMany(cl => cl.Properties).Count().ToString("#,##0");
                    ConstructorsSavedLabel.Text = Solution.Projects.SelectMany(p => p.CodeFiles).SelectMany(cf => cf.Classes).SelectMany(cl => cl.Constructors).Count().ToString("#,##0");
                    ExceptionsStatusLabel.Text = "0";
                    ReferencedBySavedLabel.Text = Solution.TotalReferencesCount.ToString("#,##0");
                }
            }
            #endregion
            
            #region Init()
            /// <summary>
            ///  This method performs initializations for this object.
            /// </summary>
            public void Init()
            {  
                // Create a new instance of a 'Gateway' object.
                Gateway = new Gateway(Connection.Name);

                // Dislay the version
                string temp = Application.ProductVersion;
                this.Text = "DocGen " + temp;
            }
            #endregion
           
            #region SetupCurrentProjectGraph(string statusText, int max, int value)
            /// <summary>
            /// Setup Current Project Graph
            /// </summary>
            public void SetupCurrentProjectGraph(string statusText, int max, int value)
            {
                // Display
                BatchStatusLabel.Text = statusText;

                // Setup Graph
                BatchGraph.Maximum = max;
                BatchGraph.Value = value;
            }
            #endregion
            
            #region SetupGraph(string statusText, int max, int value)
            /// <summary>
            /// Setup Graph
            /// </summary>
            public void SetupGraph(string statusText, int max, int value)
            {
                // Display
                OverallStatusLabel.Text = statusText;

                // Setup Graph
                OverallGraph.Maximum = max;
                OverallGraph.Value = value;
            }
            #endregion
            
            #region ShowProgressControls(bool visible)
            /// <summary>
            /// Show Progress Controls
            /// </summary>
            public void ShowProgressControls(bool visible)
            {
                // Show the labels and progress bars
                BatchStatusLabel.Visible = visible;
                OverallStatusLabel.Visible = visible;
                BatchGraph.Visible = visible;
                OverallGraph.Visible = visible;
            }
            #endregion
            
            #region UpdateBatchProgress(int max, int currentValue, string status)
            /// <summary>
            /// Update Batch Progress
            /// </summary>
            public void UpdateBatchProgress(int max, int currentValue, string status)
            {
                // Set the Text
                BatchStatusLabel.Text = status;

                // Setup the Progressbar
                BatchGraph.Maximum = max;
                BatchGraph.Value = currentValue;

                // Force an update
                Refresh();
                Application.DoEvents();
            }
            #endregion
            
            #region UpdateOverallProgress(int max, int currentValue, string status)
            /// <summary>
            /// Update Overall Progress
            /// </summary>
            public void UpdateOverallProgress(int max, int currentValue, string status)
            {
                // Set the Text
                OverallStatusLabel.Text = status;

                // Setup the Progressbar
                OverallGraph.Maximum = max;
                OverallGraph.Value = currentValue;

                // Force an update
                Refresh();
                Application.DoEvents();
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
