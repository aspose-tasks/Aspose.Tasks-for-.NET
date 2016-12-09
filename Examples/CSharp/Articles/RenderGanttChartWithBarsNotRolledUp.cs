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
If you do not wish to use NuGet, you can manually download Aspose.Tasks for .NET API from http://www.aspose.com/downloads, 
install it and then add its reference to this project. For any issues, questions or suggestions 
please feel free to contact us using http://www.aspose.com/community/forums/default.aspx
*/

namespace Aspose.Tasks.Examples.CSharp.Articles
{
    class RenderGanttChartWithBarsNotRolledUp
    {
        public static void Run()
        {
            // The path to the documents directory.
            string dataDir = RunExamples.GetDataDir(System.Reflection.MethodBase.GetCurrentMethod().DeclaringType.FullName);
            string fileName = "Project2.mpp";

            // ExStart:RenderGanttChartWithBarsNotRolledUp
            PdfSaveOptions options = new PdfSaveOptions();
            options.PresentationFormat = PresentationFormat.GanttChart;
            options.FitContent = true;
            options.RollUpGanttBars = false;
            options.DrawNonWorkingTime = false;
            options.PageSize = PageSize.A3;

            string file = Path.Combine(dataDir, fileName);
            string resultFile = Path.Combine(dataDir, "RenderGanttChartWithBarsNotRolledUp_out.pdf");
            Project project = new Project(file);
            project.Save(resultFile, options);
            // ExEnd:RenderGanttChartWithBarsNotRolledUp
        }
    }
}
