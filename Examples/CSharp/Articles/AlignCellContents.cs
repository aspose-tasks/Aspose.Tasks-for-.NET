/*
This project uses Automatic Package Restore feature of NuGet to resolve Aspose.Tasks for .NET API reference 
when the project is build. Please check https:// Docs.nuget.org/consume/nuget-faq for more information. 
If you do not wish to use NuGet, you can manually download Aspose.Tasks for .NET API from https://www.nuget.org/packages/Aspose.Tasks/, 
install it and then add its reference to this project. For any issues, questions or suggestions 
please feel free to contact us using https://forum.aspose.com/c/tasks
*/

namespace Aspose.Tasks.Examples.CSharp.Articles
{
    using System.Drawing;

    using Aspose.Tasks.Saving;
    using Aspose.Tasks.Visualization;

    internal class AlignCellContents
    {
        public static void Run()
        {  
            // The path to the documents directory.
            var dataDir = RunExamples.GetDataDir(System.Reflection.MethodBase.GetCurrentMethod().DeclaringType.FullName);

            //ExStart:AlignCellContents
            //ExFor: ViewColumn.StringAlignment
            //ExSummary: Shows how to set a alignment of the text in a column (can be one of the values of the <see cref="P:Aspose.Tasks.Visualization.ViewColumn.StringAlignment" /> enumeration).
            var project = new Project(dataDir + "Project2.mpp");
            SaveOptions options = new PdfSaveOptions();
            options.Timescale = Timescale.Months;
            options.View = ProjectView.GetDefaultGanttChartView();

            var column1 = (GanttChartColumn)options.View.Columns[2];
            column1.StringAlignment = StringAlignment.Center;
            var column2 = (GanttChartColumn)options.View.Columns[3];
            column2.StringAlignment = StringAlignment.Far;
            var column3 = (GanttChartColumn)options.View.Columns[4];
            column3.StringAlignment = StringAlignment.Far;

            project.Save(dataDir + "AlignCellContents_GanttChart_out.pdf", options);

            options.PresentationFormat = PresentationFormat.ResourceSheet;
            options.View = ProjectView.GetDefaultResourceSheetView();

            var column4 = (ResourceViewColumn)options.View.Columns[2];
            column4.StringAlignment = StringAlignment.Center;
            var column5 = (ResourceViewColumn)options.View.Columns[3];
            column5.StringAlignment = StringAlignment.Far;
            var column6 = (ResourceViewColumn)options.View.Columns[4];
            column6.StringAlignment = StringAlignment.Far;

            project.Save(dataDir + "AlignCellContents_ResourceSheet_out.pdf", options);
            //ExEnd:AlignCellContents
        }
    }
}
