using Aspose.Tasks.Saving;
using Aspose.Tasks.Visualization;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;

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

            // ExStart:RenderGanttChartWithBarsRolledUp
            PdfSaveOptions options = new PdfSaveOptions();
            options.PresentationFormat = PresentationFormat.GanttChart;
            options.FitContent = true;
            options.RollUpGanttBars = true;
            options.DrawNonWorkingTime = true;
            options.PageSize = PageSize.A3;

            string file = Path.Combine(dataDir, fileName);
            string resultFile = Path.Combine(dataDir, "RenderGanttChartWithBarsNotRolledUp_out.pdf");

            Project project = new Project(file);
            //for (int i = 14; i <= 23; i++)
            //    project.GetTaskById(i).HideBar = false;
            project.Save(resultFile, (SaveOptions)options);
            // ExEnd:RenderGanttChartWithBarsRolledUp
        }
    }
}
