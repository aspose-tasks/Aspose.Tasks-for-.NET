using Aspose.Tasks.Saving;
using Aspose.Tasks.Visualization;
using System.IO;

/*
This project uses Automatic Package Restore feature of NuGet to resolve Aspose.Tasks for .NET API reference 
when the project is build. Please check https:// Docs.nuget.org/consume/nuget-faq for more information. 
If you do not wish to use NuGet, you can manually download Aspose.Tasks for .NET API from https://www.nuget.org/packages/Aspose.Tasks/, 
install it and then add its reference to this project. For any issues, questions or suggestions 
please feel free to contact us using https://forum.aspose.com/c/tasks
*/

namespace Aspose.Tasks.Examples.CSharp.Articles
{
    class RenderGanttChartWithBarsRolledUp
    {
        public static void Run()
        {
            // The path to the documents directory.
            string dataDir = RunExamples.GetDataDir(System.Reflection.MethodBase.GetCurrentMethod().DeclaringType.FullName);
            string fileName = "Project2.mpp";

            //ExStart:RenderGanttChartWithBarsRolledUp
            //ExFor: SaveOptions.RollUpGanttBars
            //ExSummary: Shows how to set a value indicating that subtasks on the summary task bar must be rolled up.
            PdfSaveOptions options = new PdfSaveOptions();
            options.PresentationFormat = PresentationFormat.GanttChart;
            options.FitContent = true;
            options.RollUpGanttBars = true;
            options.DrawNonWorkingTime = true;
            options.PageSize = PageSize.A3;

            Project project = new Project(Path.Combine(dataDir, fileName));
            project.Save(Path.Combine(dataDir, "RenderGanttChartWithBarsRolledUp_out.pdf"), options);
            //ExEnd:RenderGanttChartWithBarsRolledUp
        }
    }
}
