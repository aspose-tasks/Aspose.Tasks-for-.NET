using System.Collections.Generic;
using System.Drawing;
using Aspose.Tasks.Saving;
using Aspose.Tasks.Visualization;

/*
This project uses Automatic Package Restore feature of NuGet to resolve Aspose.Tasks for .NET API reference 
when the project is build. Please check https:// Docs.nuget.org/consume/nuget-faq for more information. 
If you do not wish to use NuGet, you can manually download Aspose.Tasks for .NET API from http://www.aspose.com/downloads, 
install it and then add its reference to this project. For any issues, questions or suggestions 
please feel free to contact us using http://www.aspose.com/community/forums/default.aspx
*/

namespace Aspose.Tasks.Examples.CSharp.WorkingWithProjects.Printing
{
    public class PrintProjectPagesToSeparateFiles
    {
        public static void Run()
        {
            // ExStart:PrintProjectPagesToSeparateFiles
            // The path to the documents directory.
            string dataDir = RunExamples.GetDataDir_PrintingAndExporting();
            Project project = new Project(dataDir + "Project5.mpp");
            ImageSaveOptions saveOptions = new ImageSaveOptions(SaveFileFormat.PNG);
            saveOptions.StartDate = project.Get(Prj.StartDate).AddDays(-3);
            saveOptions.EndDate = project.Get(Prj.FinishDate);
            saveOptions.MarkCriticalTasks = true;
            saveOptions.LegendOnEachPage = false;
            saveOptions.Gridlines = new List<Gridline>();
            Gridline gridline = new Gridline();
            gridline.GridlineType = GridlineType.GanttRow;
            gridline.Color = Color.CornflowerBlue;
            gridline.Pattern = LinePattern.Dashed;
            saveOptions.Gridlines.Add(gridline);
            // Save the whole project layout to one file
            project.Save(dataDir + "CustomerFeedback1_out.png", saveOptions);
            // Save project layout to separate files
            saveOptions.SaveToSeparateFiles = true;
            project.Save(dataDir + "CustomerFeedback2_out.png", saveOptions);
            // ExEnd:PrintProjectPagesToSeparateFiles
        }
    }
}