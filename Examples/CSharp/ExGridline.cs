namespace Aspose.Tasks.Examples.CSharp
{
    using System.Collections.Generic;
    using System.Drawing;
    using NUnit.Framework;
    using Saving;
    using Visualization;

    [TestFixture]
    public class ExGridline : ApiExampleBase
    {
        [Test]
        public void PrintProjectPagesToSeparateFiles()
        {
            //ExStart:PrintProjectPagesToSeparateFiles
            //ExFor: Gridline
            //ExSummary: Shows how to use gridlines. 
            var project = new Project(DataDir + "CreateProject2.mpp");
            var options = new ImageSaveOptions(SaveFileFormat.PNG);
            options.StartDate = project.Get(Prj.StartDate).AddDays(-3);
            options.EndDate = project.Get(Prj.FinishDate);
            options.MarkCriticalTasks = true;
            options.LegendOnEachPage = false;
            
            options.Gridlines = new List<Gridline>();

            var gridline = new Gridline
            {
                GridlineType = GridlineType.GanttRow, 
                Color = Color.CornflowerBlue, 
                Pattern = LinePattern.Dashed
            };
            options.Gridlines.Add(gridline);
 
            project.Save(OutDir + "PrintProjectPagesToSeparateFiles1_out.png", options);
            
            // Save project layout to separate files
            options.SaveToSeparateFiles = true;
            project.Save(OutDir + "PrintProjectPagesToSeparateFiles2_out.png", options);
            //ExEnd:PrintProjectPagesToSeparateFiles
        }
    }
}