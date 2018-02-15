using System.Collections.Generic;
using System.Drawing;
using Aspose.Tasks.Saving;
using Aspose.Tasks.Visualization;

/*
This project uses Automatic Package Restore feature of NuGet to resolve Aspose.Tasks for .NET API reference 
when the project is build. Please check https:// Docs.nuget.org/consume/nuget-faq for more information. 
If you do not wish to use NuGet, you can manually download Aspose.Tasks for .NET API from https://www.nuget.org/packages/Aspose.Tasks/, 
install it and then add its reference to this project. For any issues, questions or suggestions 
please feel free to contact us using https://forum.aspose.com/c/tasks
*/

namespace Aspose.Tasks.Examples.CSharp.ConvertingProjectData
{
    public class PrintProjectPagesToSeparateFiles
    {
        public static void Run()
        {
            // The path to the documents directory.
            string dataDir = RunExamples.GetDataDir(System.Reflection.MethodBase.GetCurrentMethod().DeclaringType.FullName);

            // ExStart:PrintProjectPagesToSeparateFiles
            Project project = new Project(dataDir + "CreateProject2.mpp");
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
            project.Save(dataDir + "PrintProjectPagesToSeparateFiles1_out.png", (SaveOptions)saveOptions);
            
            // Save project layout to separate files
            saveOptions.SaveToSeparateFiles = true;
            project.Save(dataDir + "PrintProjectPagesToSeparateFiles2_out.png", (SaveOptions)saveOptions);
            // ExEnd:PrintProjectPagesToSeparateFiles
        }
    }
}