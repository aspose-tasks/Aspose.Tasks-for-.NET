/*
This project uses Automatic Package Restore feature of NuGet to resolve Aspose.Tasks for .NET API reference 
when the project is build. Please check https:// Docs.nuget.org/consume/nuget-faq for more information. 
If you do not wish to use NuGet, you can manually download Aspose.Tasks for .NET API from https://www.nuget.org/packages/Aspose.Tasks/, 
install it and then add its reference to this project. For any issues, questions or suggestions 
please feel free to contact us using https://forum.aspose.com/c/tasks
*/

namespace Aspose.Tasks.Examples.CSharp.Articles
{
    using System.IO;

    using Aspose.Tasks.Saving;
    using Aspose.Tasks.Visualization;

    internal class RenderGanttChartWithBarsNotRolledUp
    {
        public static void Run()
        {
            // The path to the documents directory.
            var dataDir = RunExamples.GetDataDir(System.Reflection.MethodBase.GetCurrentMethod().DeclaringType.FullName);

            //ExStart:RenderGanttChartWithBarsNotRolledUp
            //ExFor: SaveOptions.RollUpGanttBars
            //ExSummary: Shows how to set a value indicating that subtasks on the summary task bar must not be rolled up.
            var options = new PdfSaveOptions();
            options.PresentationFormat = PresentationFormat.GanttChart;
            options.FitContent = true;
            options.RollUpGanttBars = false;
            options.DrawNonWorkingTime = true;
            options.PageSize = PageSize.A3;

            var project = new Project(Path.Combine(dataDir, "Project2.mpp"));
            project.Save(Path.Combine(dataDir, "RenderGanttChartWithBarsNotRolledUp_out.pdf"), options);
            //ExEnd:RenderGanttChartWithBarsNotRolledUp
        }
    }
}
