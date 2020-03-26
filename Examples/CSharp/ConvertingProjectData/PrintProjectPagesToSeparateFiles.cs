/*
This project uses Automatic Package Restore feature of NuGet to resolve Aspose.Tasks for .NET API reference 
when the project is build. Please check https:// Docs.nuget.org/consume/nuget-faq for more information. 
If you do not wish to use NuGet, you can manually download Aspose.Tasks for .NET API from https://www.nuget.org/packages/Aspose.Tasks/, 
install it and then add its reference to this project. For any issues, questions or suggestions 
please feel free to contact us using https://forum.aspose.com/c/tasks
*/

namespace Aspose.Tasks.Examples.CSharp.ConvertingProjectData
{
    using System.Collections.Generic;
    using System.Drawing;

    using Aspose.Tasks.Saving;
    using Aspose.Tasks.Visualization;

    internal class PrintProjectPagesToSeparateFiles
    {
        public static void Run()
        {
            var dataDir = RunExamples.GetDataDir(System.Reflection.MethodBase.GetCurrentMethod());

            //ExStart:PrintProjectPagesToSeparateFiles
            //ExFor: Gridline
            //ExFor: ImageSaveOptions.SaveToSeparateFiles
            //ExFor: SaveOptions.MarkCriticalTasks
            //ExSummary: Shows how to save project layout to separate files. 
            var project = new Project(dataDir + "CreateProject2.mpp");
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
 
            // Save the whole project layout to one file
            project.Save(dataDir + "PrintProjectPagesToSeparateFiles1_out.png", options);
            
            // Save project layout to separate files
            options.SaveToSeparateFiles = true;
            project.Save(dataDir + "PrintProjectPagesToSeparateFiles2_out.png", options);
            //ExEnd:PrintProjectPagesToSeparateFiles
        }
    }
}