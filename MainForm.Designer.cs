

#region using statements


#endregion

namespace DocGen
{

    #region class MainForm
    /// <summary>
    /// This class [Enter Class Description]
    /// </summary>
    partial class MainForm
    {
        
        #region Private Variables
        private System.ComponentModel.IContainer components = null;
        private Label CurrentStatusLabel;
        private Label StatusLabel;
        private DataJuggler.Win.Controls.LabelTextBoxBrowserControl SolutionSelector;
        private DataJuggler.Win.Controls.Button AnalyzeButton;
        private DataJuggler.Win.Controls.ProgressBar Graph;
        private DataJuggler.Win.Controls.ProgressBar CurrentGraph;
        private DataJuggler.Win.Controls.LabelTextBoxControl SolutionNameControl;
        private DataJuggler.Win.Controls.Button OpenSolutionButton;
        private DataJuggler.Win.Controls.Button SaveButton;
        private DataJuggler.Win.Controls.LabelTextBoxControl DescriptionControl;
        #endregion
        
        #region Events
            
        #endregion
        
        #region Methods
            
            #region Dispose(bool disposing)
            /// <summary>
            ///  Clean up any resources being used.
            /// </summary>
            /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
            protected override void Dispose(bool disposing)
            {
                if (disposing && (components != null))
                {
                    components.Dispose();
                }
                base.Dispose(disposing);
            }
            #endregion
            
            #region InitializeComponent()
            /// <summary>
            ///  Required method for Designer support - do not modify
            ///  the contents of this method with the code editor.
            /// </summary>
            private void InitializeComponent()
            {
                System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
                SolutionSelector = new DataJuggler.Win.Controls.LabelTextBoxBrowserControl();
                AnalyzeButton = new DataJuggler.Win.Controls.Button();
                Graph = new DataJuggler.Win.Controls.ProgressBar();
                StatusLabel = new Label();
                CurrentStatusLabel = new Label();
                CurrentGraph = new DataJuggler.Win.Controls.ProgressBar();
                SolutionNameControl = new DataJuggler.Win.Controls.LabelTextBoxControl();
                OpenSolutionButton = new DataJuggler.Win.Controls.Button();
                SaveButton = new DataJuggler.Win.Controls.Button();
                DescriptionControl = new DataJuggler.Win.Controls.LabelTextBoxControl();
                SuspendLayout();
                //
                // SolutionSelector
                //
                SolutionSelector.BackColor = Color.Transparent;
                SolutionSelector.BrowseType = DataJuggler.Win.Controls.Enumerations.BrowseTypeEnum.File;
                SolutionSelector.ButtonColor = Color.LemonChiffon;
                SolutionSelector.ButtonImage = (Image)resources.GetObject("SolutionSelector.ButtonImage");
                SolutionSelector.ButtonWidth = 48;
                SolutionSelector.DarkMode = false;
                SolutionSelector.DisabledLabelColor = Color.Empty;
                SolutionSelector.Editable = true;
                SolutionSelector.EnabledLabelColor = Color.Empty;
                SolutionSelector.Filter = null;
                SolutionSelector.Font = new Font("Verdana", 12F);
                SolutionSelector.HideBrowseButton = false;
                SolutionSelector.LabelBottomMargin = 0;
                SolutionSelector.LabelColor = Color.LemonChiffon;
                SolutionSelector.LabelFont = new Font("Verdana", 12F, FontStyle.Bold);
                SolutionSelector.LabelText = "VS Solution:";
                SolutionSelector.LabelTopMargin = 0;
                SolutionSelector.LabelWidth = 148;
                SolutionSelector.Location = new Point(40, 22);
                SolutionSelector.Name = "SolutionSelector";
                SolutionSelector.OnTextChangedListener = null;
                SolutionSelector.OpenCallback = null;
                SolutionSelector.ScrollBars = ScrollBars.None;
                SolutionSelector.SelectedPath = null;
                SolutionSelector.Size = new Size(720, 32);
                SolutionSelector.StartPath = null;
                SolutionSelector.TabIndex = 0;
                SolutionSelector.TextBoxBottomMargin = 0;
                SolutionSelector.TextBoxDisabledColor = Color.Empty;
                SolutionSelector.TextBoxEditableColor = Color.Empty;
                SolutionSelector.TextBoxFont = new Font("Verdana", 12F);
                SolutionSelector.TextBoxTopMargin = 0;
                SolutionSelector.Theme = DataJuggler.Win.Controls.Enumerations.ThemeEnum.Dark;
                //
                // AnalyzeButton
                //
                AnalyzeButton.BackColor = Color.Transparent;
                AnalyzeButton.ButtonText = "Analyze";
                AnalyzeButton.FlatStyle = FlatStyle.Flat;
                AnalyzeButton.ForeColor = Color.LemonChiffon;
                AnalyzeButton.Location = new Point(500, 294);
                AnalyzeButton.Name = "AnalyzeButton";
                AnalyzeButton.Size = new Size(120, 44);
                AnalyzeButton.TabIndex = 1;
                AnalyzeButton.Theme = DataJuggler.Win.Controls.Enumerations.ThemeEnum.Dark;
                AnalyzeButton.Click += AnalyzeButton_Click;
                //
                // Graph
                //
                Graph.BackColor = Color.DarkGray;
                Graph.BackgroundColor = Color.DarkGray;
                Graph.BorderStyle = BorderStyle.FixedSingle;
                Graph.ForeColor = Color.DodgerBlue;
                Graph.Location = new Point(21, 544);
                Graph.Maximum = 100;
                Graph.Name = "Graph";
                Graph.SetOverflowToMax = true;
                Graph.Size = new Size(758, 22);
                Graph.TabIndex = 2;
                Graph.Value = 0;
                Graph.Visible = false;
                //
                // StatusLabel
                //
                StatusLabel.BackColor = Color.Transparent;
                StatusLabel.ForeColor = Color.LemonChiffon;
                StatusLabel.Location = new Point(19, 514);
                StatusLabel.Name = "StatusLabel";
                StatusLabel.Size = new Size(760, 20);
                StatusLabel.TabIndex = 3;
                StatusLabel.Text = "Status:";
                StatusLabel.Visible = false;
                //
                // CurrentStatusLabel
                //
                CurrentStatusLabel.BackColor = Color.Transparent;
                CurrentStatusLabel.ForeColor = Color.LemonChiffon;
                CurrentStatusLabel.Location = new Point(19, 442);
                CurrentStatusLabel.Name = "CurrentStatusLabel";
                CurrentStatusLabel.Size = new Size(760, 20);
                CurrentStatusLabel.TabIndex = 5;
                CurrentStatusLabel.Text = "Status:";
                CurrentStatusLabel.Visible = false;
                //
                // CurrentGraph
                //
                CurrentGraph.BackColor = Color.DarkGray;
                CurrentGraph.BackgroundColor = Color.DarkGray;
                CurrentGraph.BorderStyle = BorderStyle.FixedSingle;
                CurrentGraph.ForeColor = Color.DodgerBlue;
                CurrentGraph.Location = new Point(21, 472);
                CurrentGraph.Maximum = 100;
                CurrentGraph.Name = "CurrentGraph";
                CurrentGraph.SetOverflowToMax = true;
                CurrentGraph.Size = new Size(758, 22);
                CurrentGraph.TabIndex = 4;
                CurrentGraph.Value = 0;
                CurrentGraph.Visible = false;
                //
                // SolutionNameControl
                //
                SolutionNameControl.BackColor = Color.Transparent;
                SolutionNameControl.BottomMargin = 0;
                SolutionNameControl.Editable = false;
                SolutionNameControl.Encrypted = false;
                SolutionNameControl.Font = new Font("Verdana", 12F, FontStyle.Bold);
                SolutionNameControl.Inititialized = true;
                SolutionNameControl.LabelBottomMargin = 0;
                SolutionNameControl.LabelColor = Color.LemonChiffon;
                SolutionNameControl.LabelFont = new Font("Verdana", 12F, FontStyle.Bold);
                SolutionNameControl.LabelText = "Solution Name:";
                SolutionNameControl.LabelTopMargin = 0;
                SolutionNameControl.LabelWidth = 148;
                SolutionNameControl.Location = new Point(40, 75);
                SolutionNameControl.MultiLine = false;
                SolutionNameControl.Name = "SolutionNameControl";
                SolutionNameControl.OnTextChangedListener = null;
                SolutionNameControl.PasswordMode = false;
                SolutionNameControl.ScrollBars = ScrollBars.None;
                SolutionNameControl.Size = new Size(360, 32);
                SolutionNameControl.TabIndex = 6;
                SolutionNameControl.TextBoxBottomMargin = 0;
                SolutionNameControl.TextBoxDisabledColor = Color.LightGray;
                SolutionNameControl.TextBoxEditableColor = Color.White;
                SolutionNameControl.TextBoxFont = new Font("Verdana", 12F);
                SolutionNameControl.TextBoxTopMargin = 0;
                SolutionNameControl.Theme = DataJuggler.Win.Controls.Enumerations.ThemeEnum.Dark;
                //
                // OpenSolutionButton
                //
                OpenSolutionButton.BackColor = Color.Transparent;
                OpenSolutionButton.ButtonText = "Open Solution";
                OpenSolutionButton.FlatStyle = FlatStyle.Flat;
                OpenSolutionButton.ForeColor = Color.LemonChiffon;
                OpenSolutionButton.Location = new Point(424, 69);
                OpenSolutionButton.Name = "OpenSolutionButton";
                OpenSolutionButton.Size = new Size(160, 44);
                OpenSolutionButton.TabIndex = 7;
                OpenSolutionButton.Theme = DataJuggler.Win.Controls.Enumerations.ThemeEnum.Dark;
                OpenSolutionButton.Click += OpenSolutionButton_Click;
                //
                // SaveButton
                //
                SaveButton.BackColor = Color.Transparent;
                SaveButton.ButtonText = "Save";
                SaveButton.Enabled = false;
                SaveButton.FlatStyle = FlatStyle.Flat;
                SaveButton.ForeColor = Color.LemonChiffon;
                SaveButton.Location = new Point(640, 294);
                SaveButton.Name = "SaveButton";
                SaveButton.Size = new Size(120, 44);
                SaveButton.TabIndex = 8;
                SaveButton.Theme = DataJuggler.Win.Controls.Enumerations.ThemeEnum.Dark;
                SaveButton.Click += SaveButton_Click;
                //
                // DescriptionControl
                //
                DescriptionControl.BackColor = Color.Transparent;
                DescriptionControl.BottomMargin = 0;
                DescriptionControl.Editable = true;
                DescriptionControl.Encrypted = false;
                DescriptionControl.Font = new Font("Verdana", 12F, FontStyle.Bold);
                DescriptionControl.Inititialized = true;
                DescriptionControl.LabelBottomMargin = 0;
                DescriptionControl.LabelColor = Color.LemonChiffon;
                DescriptionControl.LabelFont = new Font("Verdana", 12F, FontStyle.Bold);
                DescriptionControl.LabelText = "Description:";
                DescriptionControl.LabelTopMargin = 0;
                DescriptionControl.LabelWidth = 148;
                DescriptionControl.Location = new Point(40, 128);
                DescriptionControl.MultiLine = true;
                DescriptionControl.Name = "DescriptionControl";
                DescriptionControl.OnTextChangedListener = null;
                DescriptionControl.PasswordMode = false;
                DescriptionControl.ScrollBars = ScrollBars.None;
                DescriptionControl.Size = new Size(720, 143);
                DescriptionControl.TabIndex = 9;
                DescriptionControl.TextBoxBottomMargin = 0;
                DescriptionControl.TextBoxDisabledColor = Color.LightGray;
                DescriptionControl.TextBoxEditableColor = Color.White;
                DescriptionControl.TextBoxFont = new Font("Verdana", 12F);
                DescriptionControl.TextBoxTopMargin = 0;
                DescriptionControl.Theme = DataJuggler.Win.Controls.Enumerations.ThemeEnum.Dark;
                //
                // MainForm
                //
                AutoScaleMode = AutoScaleMode.None;
                BackgroundImage = Properties.Resources.BlackImage;
                BackgroundImageLayout = ImageLayout.Stretch;
                ClientSize = new Size(800, 590);
                Controls.Add(DescriptionControl);
                Controls.Add(SaveButton);
                Controls.Add(OpenSolutionButton);
                Controls.Add(SolutionNameControl);
                Controls.Add(CurrentStatusLabel);
                Controls.Add(CurrentGraph);
                Controls.Add(StatusLabel);
                Controls.Add(Graph);
                Controls.Add(AnalyzeButton);
                Controls.Add(SolutionSelector);
                DoubleBuffered = true;
                Font = new Font("Verdana", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
                Icon = (Icon)resources.GetObject("$this.Icon");
                Name = "MainForm";
                StartPosition = FormStartPosition.CenterScreen;
                Text = "Doc Gen";
                ResumeLayout(false);
            }
            #endregion
            
        #endregion
        
        #region Properties
            
        #endregion
        
    }
    #endregion

}
