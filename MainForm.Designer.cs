

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
        private Label BatchStatusLabel;
        private Label OverallStatusLabel;
        private DataJuggler.Win.Controls.LabelTextBoxBrowserControl SolutionSelector;
        private DataJuggler.Win.Controls.Button AnalyzeButton;
        private DataJuggler.Win.Controls.ProgressBar OverallGraph;
        private DataJuggler.Win.Controls.ProgressBar BatchGraph;
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
            OverallGraph = new DataJuggler.Win.Controls.ProgressBar();
            OverallStatusLabel = new Label();
            BatchStatusLabel = new Label();
            BatchGraph = new DataJuggler.Win.Controls.ProgressBar();
            SolutionNameControl = new DataJuggler.Win.Controls.LabelTextBoxControl();
            OpenSolutionButton = new DataJuggler.Win.Controls.Button();
            SaveButton = new DataJuggler.Win.Controls.Button();
            DescriptionControl = new DataJuggler.Win.Controls.LabelTextBoxControl();
            ResultsPanel = new DataJuggler.Win.Controls.Objects.PanelExtender();
            ExceptionsStatusLabel = new DataJuggler.Win.Controls.LabelLabelControl();
            EventHandlersSavedLabel = new DataJuggler.Win.Controls.LabelLabelControl();
            ResultsLabel = new Label();
            ReferencedBySavedLabel = new DataJuggler.Win.Controls.LabelLabelControl();
            SolutionsSavedLabel = new DataJuggler.Win.Controls.LabelLabelControl();
            ParametersSavedLabel = new DataJuggler.Win.Controls.LabelLabelControl();
            ConstructorsSavedLabel = new DataJuggler.Win.Controls.LabelLabelControl();
            PropertiesSavedLabel = new DataJuggler.Win.Controls.LabelLabelControl();
            MethodsSavedLabel = new DataJuggler.Win.Controls.LabelLabelControl();
            ClassesSavedLabel = new DataJuggler.Win.Controls.LabelLabelControl();
            CodeFilesSavedLabel = new DataJuggler.Win.Controls.LabelLabelControl();
            ProjectsSavedLabel = new DataJuggler.Win.Controls.LabelLabelControl();
            ResultsPanel.SuspendLayout();
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
            SolutionSelector.Filter = "Solution Files (*.sln)|*.sln;";
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
            AnalyzeButton.Location = new Point(502, 256);
            AnalyzeButton.Name = "AnalyzeButton";
            AnalyzeButton.Size = new Size(120, 44);
            AnalyzeButton.TabIndex = 1;
            AnalyzeButton.Theme = DataJuggler.Win.Controls.Enumerations.ThemeEnum.Dark;
            AnalyzeButton.Click += AnalyzeButton_Click;
            // 
            // OverallGraph
            // 
            OverallGraph.BackColor = Color.DarkGray;
            OverallGraph.BackgroundColor = Color.DarkGray;
            OverallGraph.BorderStyle = BorderStyle.FixedSingle;
            OverallGraph.ForeColor = Color.DodgerBlue;
            OverallGraph.Location = new Point(21, 633);
            OverallGraph.Maximum = 100;
            OverallGraph.Name = "OverallGraph";
            OverallGraph.SetOverflowToMax = true;
            OverallGraph.Size = new Size(758, 22);
            OverallGraph.TabIndex = 2;
            OverallGraph.Value = 0;
            OverallGraph.Visible = false;
            // 
            // OverallStatusLabel
            // 
            OverallStatusLabel.BackColor = Color.Transparent;
            OverallStatusLabel.Font = new Font("Verdana", 13F);
            OverallStatusLabel.ForeColor = Color.LemonChiffon;
            OverallStatusLabel.Location = new Point(19, 607);
            OverallStatusLabel.Name = "OverallStatusLabel";
            OverallStatusLabel.Size = new Size(760, 20);
            OverallStatusLabel.TabIndex = 3;
            OverallStatusLabel.Text = "Status:";
            OverallStatusLabel.Visible = false;
            // 
            // BatchStatusLabel
            // 
            BatchStatusLabel.BackColor = Color.Transparent;
            BatchStatusLabel.Font = new Font("Verdana", 13F);
            BatchStatusLabel.ForeColor = Color.LemonChiffon;
            BatchStatusLabel.Location = new Point(19, 534);
            BatchStatusLabel.Name = "BatchStatusLabel";
            BatchStatusLabel.Size = new Size(760, 20);
            BatchStatusLabel.TabIndex = 5;
            BatchStatusLabel.Text = "Status:";
            BatchStatusLabel.Visible = false;
            // 
            // BatchGraph
            // 
            BatchGraph.BackColor = Color.DarkGray;
            BatchGraph.BackgroundColor = Color.DarkGray;
            BatchGraph.BorderStyle = BorderStyle.FixedSingle;
            BatchGraph.ForeColor = Color.DodgerBlue;
            BatchGraph.Location = new Point(21, 561);
            BatchGraph.Maximum = 100;
            BatchGraph.Name = "BatchGraph";
            BatchGraph.SetOverflowToMax = true;
            BatchGraph.Size = new Size(758, 22);
            BatchGraph.TabIndex = 4;
            BatchGraph.Value = 0;
            BatchGraph.Visible = false;
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
            OpenSolutionButton.Location = new Point(423, 69);
            OpenSolutionButton.Name = "OpenSolutionButton";
            OpenSolutionButton.Size = new Size(159, 44);
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
            SaveButton.Location = new Point(640, 256);
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
            DescriptionControl.Size = new Size(720, 113);
            DescriptionControl.TabIndex = 9;
            DescriptionControl.TextBoxBottomMargin = 0;
            DescriptionControl.TextBoxDisabledColor = Color.LightGray;
            DescriptionControl.TextBoxEditableColor = Color.White;
            DescriptionControl.TextBoxFont = new Font("Verdana", 12F);
            DescriptionControl.TextBoxTopMargin = 0;
            DescriptionControl.Theme = DataJuggler.Win.Controls.Enumerations.ThemeEnum.Dark;
            // 
            // ResultsPanel
            // 
            ResultsPanel.BackColor = Color.Transparent;
            ResultsPanel.Controls.Add(ExceptionsStatusLabel);
            ResultsPanel.Controls.Add(EventHandlersSavedLabel);
            ResultsPanel.Controls.Add(ResultsLabel);
            ResultsPanel.Controls.Add(ReferencedBySavedLabel);
            ResultsPanel.Controls.Add(SolutionsSavedLabel);
            ResultsPanel.Controls.Add(ParametersSavedLabel);
            ResultsPanel.Controls.Add(ConstructorsSavedLabel);
            ResultsPanel.Controls.Add(PropertiesSavedLabel);
            ResultsPanel.Controls.Add(MethodsSavedLabel);
            ResultsPanel.Controls.Add(ClassesSavedLabel);
            ResultsPanel.Controls.Add(CodeFilesSavedLabel);
            ResultsPanel.Controls.Add(ProjectsSavedLabel);
            ResultsPanel.Location = new Point(21, 281);
            ResultsPanel.Name = "ResultsPanel";
            ResultsPanel.Size = new Size(758, 230);
            ResultsPanel.TabIndex = 10;
            ResultsPanel.Visible = false;
            // 
            // ExceptionsStatusLabel
            // 
            ExceptionsStatusLabel.BackColor = Color.Transparent;
            ExceptionsStatusLabel.Font = new Font("Verdana", 12F);
            ExceptionsStatusLabel.ForeColor = Color.LemonChiffon;
            ExceptionsStatusLabel.LabelColor = Color.LemonChiffon;
            ExceptionsStatusLabel.LabelFont = new Font("Verdana", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            ExceptionsStatusLabel.LabelText = "Exceptions:";
            ExceptionsStatusLabel.LabelWidth = 160;
            ExceptionsStatusLabel.Location = new Point(481, 43);
            ExceptionsStatusLabel.Margin = new Padding(6, 5, 6, 5);
            ExceptionsStatusLabel.Name = "ExceptionsStatusLabel";
            ExceptionsStatusLabel.Size = new Size(220, 28);
            ExceptionsStatusLabel.TabIndex = 33;
            ExceptionsStatusLabel.ValueLabelColor = Color.LemonChiffon;
            ExceptionsStatusLabel.ValueLabelFont = new Font("Verdana", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            // 
            // EventHandlersSavedLabel
            // 
            EventHandlersSavedLabel.BackColor = Color.Transparent;
            EventHandlersSavedLabel.Font = new Font("Verdana", 12F);
            EventHandlersSavedLabel.ForeColor = Color.LemonChiffon;
            EventHandlersSavedLabel.LabelColor = Color.LemonChiffon;
            EventHandlersSavedLabel.LabelFont = new Font("Verdana", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            EventHandlersSavedLabel.LabelText = "Event Handlers:";
            EventHandlersSavedLabel.LabelWidth = 160;
            EventHandlersSavedLabel.Location = new Point(254, 195);
            EventHandlersSavedLabel.Margin = new Padding(6, 5, 6, 5);
            EventHandlersSavedLabel.Name = "EventHandlersSavedLabel";
            EventHandlersSavedLabel.Size = new Size(246, 28);
            EventHandlersSavedLabel.TabIndex = 32;
            EventHandlersSavedLabel.ValueLabelColor = Color.LemonChiffon;
            EventHandlersSavedLabel.ValueLabelFont = new Font("Verdana", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            // 
            // ResultsLabel
            // 
            ResultsLabel.BackColor = Color.Transparent;
            ResultsLabel.ForeColor = Color.LemonChiffon;
            ResultsLabel.Location = new Point(22, 8);
            ResultsLabel.Name = "ResultsLabel";
            ResultsLabel.Size = new Size(154, 20);
            ResultsLabel.TabIndex = 31;
            ResultsLabel.Text = "Saved Results:";
            // 
            // ReferencedBySavedLabel
            // 
            ReferencedBySavedLabel.BackColor = Color.Transparent;
            ReferencedBySavedLabel.Font = new Font("Verdana", 12F);
            ReferencedBySavedLabel.ForeColor = Color.LemonChiffon;
            ReferencedBySavedLabel.LabelColor = Color.LemonChiffon;
            ReferencedBySavedLabel.LabelFont = new Font("Verdana", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            ReferencedBySavedLabel.LabelText = "Referenced By:";
            ReferencedBySavedLabel.LabelWidth = 160;
            ReferencedBySavedLabel.Location = new Point(254, 43);
            ReferencedBySavedLabel.Margin = new Padding(6, 5, 6, 5);
            ReferencedBySavedLabel.Name = "ReferencedBySavedLabel";
            ReferencedBySavedLabel.Size = new Size(246, 28);
            ReferencedBySavedLabel.TabIndex = 30;
            ReferencedBySavedLabel.ValueLabelColor = Color.LemonChiffon;
            ReferencedBySavedLabel.ValueLabelFont = new Font("Verdana", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            // 
            // SolutionsSavedLabel
            // 
            SolutionsSavedLabel.BackColor = Color.Transparent;
            SolutionsSavedLabel.Font = new Font("Verdana", 12F);
            SolutionsSavedLabel.ForeColor = Color.LemonChiffon;
            SolutionsSavedLabel.LabelColor = Color.LemonChiffon;
            SolutionsSavedLabel.LabelFont = new Font("Verdana", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            SolutionsSavedLabel.LabelText = "Solutions:";
            SolutionsSavedLabel.LabelWidth = 160;
            SolutionsSavedLabel.Location = new Point(1, 43);
            SolutionsSavedLabel.Margin = new Padding(6, 5, 6, 5);
            SolutionsSavedLabel.Name = "SolutionsSavedLabel";
            SolutionsSavedLabel.Size = new Size(220, 28);
            SolutionsSavedLabel.TabIndex = 29;
            SolutionsSavedLabel.ValueLabelColor = Color.LemonChiffon;
            SolutionsSavedLabel.ValueLabelFont = new Font("Verdana", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            // 
            // ParametersSavedLabel
            // 
            ParametersSavedLabel.BackColor = Color.Transparent;
            ParametersSavedLabel.Font = new Font("Verdana", 12F);
            ParametersSavedLabel.ForeColor = Color.LemonChiffon;
            ParametersSavedLabel.LabelColor = Color.LemonChiffon;
            ParametersSavedLabel.LabelFont = new Font("Verdana", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            ParametersSavedLabel.LabelText = "Parameters:";
            ParametersSavedLabel.LabelWidth = 160;
            ParametersSavedLabel.Location = new Point(254, 156);
            ParametersSavedLabel.Margin = new Padding(6, 5, 6, 5);
            ParametersSavedLabel.Name = "ParametersSavedLabel";
            ParametersSavedLabel.Size = new Size(246, 28);
            ParametersSavedLabel.TabIndex = 28;
            ParametersSavedLabel.ValueLabelColor = Color.LemonChiffon;
            ParametersSavedLabel.ValueLabelFont = new Font("Verdana", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            // 
            // ConstructorsSavedLabel
            // 
            ConstructorsSavedLabel.BackColor = Color.Transparent;
            ConstructorsSavedLabel.Font = new Font("Verdana", 12F);
            ConstructorsSavedLabel.ForeColor = Color.LemonChiffon;
            ConstructorsSavedLabel.LabelColor = Color.LemonChiffon;
            ConstructorsSavedLabel.LabelFont = new Font("Verdana", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            ConstructorsSavedLabel.LabelText = "Constructors:";
            ConstructorsSavedLabel.LabelWidth = 160;
            ConstructorsSavedLabel.Location = new Point(254, 118);
            ConstructorsSavedLabel.Margin = new Padding(6, 5, 6, 5);
            ConstructorsSavedLabel.Name = "ConstructorsSavedLabel";
            ConstructorsSavedLabel.Size = new Size(246, 28);
            ConstructorsSavedLabel.TabIndex = 27;
            ConstructorsSavedLabel.ValueLabelColor = Color.LemonChiffon;
            ConstructorsSavedLabel.ValueLabelFont = new Font("Verdana", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            // 
            // PropertiesSavedLabel
            // 
            PropertiesSavedLabel.BackColor = Color.Transparent;
            PropertiesSavedLabel.Font = new Font("Verdana", 12F);
            PropertiesSavedLabel.ForeColor = Color.LemonChiffon;
            PropertiesSavedLabel.LabelColor = Color.LemonChiffon;
            PropertiesSavedLabel.LabelFont = new Font("Verdana", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            PropertiesSavedLabel.LabelText = "Properties:";
            PropertiesSavedLabel.LabelWidth = 160;
            PropertiesSavedLabel.Location = new Point(254, 81);
            PropertiesSavedLabel.Margin = new Padding(6, 5, 6, 5);
            PropertiesSavedLabel.Name = "PropertiesSavedLabel";
            PropertiesSavedLabel.Size = new Size(246, 28);
            PropertiesSavedLabel.TabIndex = 25;
            PropertiesSavedLabel.ValueLabelColor = Color.LemonChiffon;
            PropertiesSavedLabel.ValueLabelFont = new Font("Verdana", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            // 
            // MethodsSavedLabel
            // 
            MethodsSavedLabel.BackColor = Color.Transparent;
            MethodsSavedLabel.Font = new Font("Verdana", 12F);
            MethodsSavedLabel.ForeColor = Color.LemonChiffon;
            MethodsSavedLabel.LabelColor = Color.LemonChiffon;
            MethodsSavedLabel.LabelFont = new Font("Verdana", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            MethodsSavedLabel.LabelText = "Methods:";
            MethodsSavedLabel.LabelWidth = 160;
            MethodsSavedLabel.Location = new Point(1, 195);
            MethodsSavedLabel.Margin = new Padding(6, 5, 6, 5);
            MethodsSavedLabel.Name = "MethodsSavedLabel";
            MethodsSavedLabel.Size = new Size(241, 28);
            MethodsSavedLabel.TabIndex = 24;
            MethodsSavedLabel.ValueLabelColor = Color.LemonChiffon;
            MethodsSavedLabel.ValueLabelFont = new Font("Verdana", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            // 
            // ClassesSavedLabel
            // 
            ClassesSavedLabel.BackColor = Color.Transparent;
            ClassesSavedLabel.Font = new Font("Verdana", 12F);
            ClassesSavedLabel.ForeColor = Color.LemonChiffon;
            ClassesSavedLabel.LabelColor = Color.LemonChiffon;
            ClassesSavedLabel.LabelFont = new Font("Verdana", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            ClassesSavedLabel.LabelText = "Classes:";
            ClassesSavedLabel.LabelWidth = 160;
            ClassesSavedLabel.Location = new Point(1, 157);
            ClassesSavedLabel.Margin = new Padding(6, 5, 6, 5);
            ClassesSavedLabel.Name = "ClassesSavedLabel";
            ClassesSavedLabel.Size = new Size(241, 28);
            ClassesSavedLabel.TabIndex = 23;
            ClassesSavedLabel.ValueLabelColor = Color.LemonChiffon;
            ClassesSavedLabel.ValueLabelFont = new Font("Verdana", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            // 
            // CodeFilesSavedLabel
            // 
            CodeFilesSavedLabel.BackColor = Color.Transparent;
            CodeFilesSavedLabel.Font = new Font("Verdana", 12F);
            CodeFilesSavedLabel.ForeColor = Color.LemonChiffon;
            CodeFilesSavedLabel.LabelColor = Color.LemonChiffon;
            CodeFilesSavedLabel.LabelFont = new Font("Verdana", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            CodeFilesSavedLabel.LabelText = "Code Files:";
            CodeFilesSavedLabel.LabelWidth = 160;
            CodeFilesSavedLabel.Location = new Point(1, 119);
            CodeFilesSavedLabel.Margin = new Padding(6, 5, 6, 5);
            CodeFilesSavedLabel.Name = "CodeFilesSavedLabel";
            CodeFilesSavedLabel.Size = new Size(241, 28);
            CodeFilesSavedLabel.TabIndex = 22;
            CodeFilesSavedLabel.ValueLabelColor = Color.LemonChiffon;
            CodeFilesSavedLabel.ValueLabelFont = new Font("Verdana", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            // 
            // ProjectsSavedLabel
            // 
            ProjectsSavedLabel.BackColor = Color.Transparent;
            ProjectsSavedLabel.Font = new Font("Verdana", 12F);
            ProjectsSavedLabel.ForeColor = Color.LemonChiffon;
            ProjectsSavedLabel.LabelColor = Color.LemonChiffon;
            ProjectsSavedLabel.LabelFont = new Font("Verdana", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            ProjectsSavedLabel.LabelText = "Projects:";
            ProjectsSavedLabel.LabelWidth = 160;
            ProjectsSavedLabel.Location = new Point(1, 81);
            ProjectsSavedLabel.Margin = new Padding(6, 5, 6, 5);
            ProjectsSavedLabel.Name = "ProjectsSavedLabel";
            ProjectsSavedLabel.Size = new Size(220, 28);
            ProjectsSavedLabel.TabIndex = 21;
            ProjectsSavedLabel.ValueLabelColor = Color.LemonChiffon;
            ProjectsSavedLabel.ValueLabelFont = new Font("Verdana", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            // 
            // MainForm
            // 
            AutoScaleMode = AutoScaleMode.None;
            BackgroundImage = Properties.Resources.BlackImage;
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(800, 680);
            Controls.Add(AnalyzeButton);
            Controls.Add(DescriptionControl);
            Controls.Add(SaveButton);
            Controls.Add(OpenSolutionButton);
            Controls.Add(SolutionNameControl);
            Controls.Add(BatchStatusLabel);
            Controls.Add(BatchGraph);
            Controls.Add(OverallStatusLabel);
            Controls.Add(OverallGraph);
            Controls.Add(SolutionSelector);
            Controls.Add(ResultsPanel);
            DoubleBuffered = true;
            Font = new Font("Verdana", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "MainForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Doc Gen";
            ResultsPanel.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion
        #endregion

        private DataJuggler.Win.Controls.Objects.PanelExtender ResultsPanel;
        private Label ResultsLabel;
        private DataJuggler.Win.Controls.LabelLabelControl ReferencedBySavedLabel;
        private DataJuggler.Win.Controls.LabelLabelControl SolutionsSavedLabel;
        private DataJuggler.Win.Controls.LabelLabelControl ParametersSavedLabel;
        private DataJuggler.Win.Controls.LabelLabelControl ConstructorsSavedLabel;
        private DataJuggler.Win.Controls.LabelLabelControl PropertiesSavedLabel;
        private DataJuggler.Win.Controls.LabelLabelControl MethodsSavedLabel;
        private DataJuggler.Win.Controls.LabelLabelControl ClassesSavedLabel;
        private DataJuggler.Win.Controls.LabelLabelControl CodeFilesSavedLabel;
        private DataJuggler.Win.Controls.LabelLabelControl ProjectsSavedLabel;
        private DataJuggler.Win.Controls.LabelLabelControl EventHandlersSavedLabel;
        private DataJuggler.Win.Controls.LabelLabelControl ExceptionsStatusLabel;
    }
    #endregion

}
