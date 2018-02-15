using Aspose.Tasks.Saving;
using Aspose.Tasks.Visualization;
using System;
using System.Collections.Generic;
using System.Drawing;
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
    class AlignCellContents
    {
        public static void Run()
        {  
            // The path to the documents directory.
            string dataDir = RunExamples.GetDataDir(System.Reflection.MethodBase.GetCurrentMethod().DeclaringType.FullName);

            // ExStart:AlignCellContents
            Project project = new Project(dataDir + "Project2.mpp");
            SaveOptions options = new PdfSaveOptions();
            options.Timescale = Timescale.Months;
            options.View = ProjectView.GetDefaultGanttChartView();

            GanttChartColumn column1 = options.View.Columns[2] as GanttChartColumn;
            column1.StringAlignment = StringAlignment.Center;
            column1 = options.View.Columns[3] as GanttChartColumn;
            column1.StringAlignment = StringAlignment.Far;
            column1 = options.View.Columns[4] as GanttChartColumn;
            column1.StringAlignment = StringAlignment.Far;

            project.Save(dataDir + "AlignCellContents_GanttChart_out.pdf", options);

            options.PresentationFormat = PresentationFormat.ResourceSheet;
            options.View = ProjectView.GetDefaultResourceSheetView();

            ResourceViewColumn column2 = options.View.Columns[2] as ResourceViewColumn;
            column2.StringAlignment = StringAlignment.Center;
            column2 = options.View.Columns[3] as ResourceViewColumn;
            column2.StringAlignment = StringAlignment.Far;
            column2 = options.View.Columns[4] as ResourceViewColumn;
            column2.StringAlignment = StringAlignment.Far;

            project.Save(dataDir + "AlignCellContents_ResourceSheet_out.pdf", options);
            // ExEnd:AlignCellContents
        }
    }
}
