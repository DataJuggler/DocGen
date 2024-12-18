﻿This is copied from the DocGen main ReadMe.md. This project is just the Object Library.
You can think of these similar to Entities in Entity Framework.

DataJuggler.DocGen analyzes and Saves a Visual Studio solution in SQL Server.

Code For The NuGet package and this project
https://github.com/DataJuggler/DocGen

The GitHub repo is here and has a Sample Windows Forms application. For now all it does
is analyze a solution and save all the details in SQL Server. Coming soon is a Blazor admin portal 
to allow a solution owner to manage the documentation including editing, hiding, showing and
creating code samples or images.

# Descriptions
For now, the descriptions for projects are read from the .csproject files.

All other descriptions are read from Summary Text if present.

    /// <summary>
    /// This class is the code behind for the CalendarComponent
    /// </summary>
    public partial class CalendarComponent : IBlazorComponent, IBlazorComponentParent

In the above example, the description would be parsed to 

    This class is the code behind for the CalendarComponent.

I am investigating if there is a free or very cheap way to have AI write descriptions if a description is not present.

Here is the code to analyze an entire solution

    // Create a new instance of an 'UICallback' object.
    UICallback uICallback = new UICallback(UpdateBatchProgress, UpdateOverallProgress);
    
    // Retrieve the Solution
    Solution = await DocGenerator.AnalyzeSolution(SolutionSelector.Text, uICallback);

UICallback is a class that contains two delegates:

The MainForm has two status labels and two progress bars. Overall Progress is for Projects and
the Batch Progress is for the Code Files of that project.

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

# Saving Results In SQL Server
To save a solution after Analyzing, create a System Environment Variable named DocGenConn, containing
a connection string to SQL Server. Create a database named DocGen and create a connection string.

# Example Connection Strings
 Replace out ServerName. You must have Encrypt=False in the connection string.

    SQL Server
    Data Source=ServerName;Initial Catalog=DocGen;Integrated Security=True;Encrypt=False;

	SQL Express
    Data Source=ServerName\SQLExpress;Initial Catalog=DocGen;Integrated Security=True;Encrypt=False;

# Future Updates
The next feature I will add is the ability to get a list of projects from the solution, in case you only want to generate
docs for certain projects. Then as I get time start working on a Blazor portal to generate and host documentation.

