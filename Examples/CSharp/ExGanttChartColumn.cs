namespace Aspose.Tasks.Examples.CSharp
{
    using System;
    using System.Collections.Generic;
    using System.Globalization;
    using NUnit.Framework;
    using Saving;
    using Visualization;

    [TestFixture]
    public class ExGanttChartColumn : ApiExampleBase
    {
        [Test]
        public void WorkWithGanttChartColumn()
        {
            // ExStart:WorkWithGanttChartColumn 
            // ExFor: GanttChartColumn
            // ExFor: GanttChartColumn.#ctor(Int32,Field)
            // ExFor: GanttChartColumn.#ctor(String,Int32,Field)
            // ExFor: GanttChartColumn.#ctor(String,Int32,TaskToColumnTextConverter)
            // ExFor: GanttChartColumn.#ctor(String,Int32,TaskToColumnTextConverter,Field)
            // ExFor: GanttChartColumn.Field
            // ExFor: GanttChartColumn.GetColumnText(Task)
            // ExFor: TaskToColumnTextConverter
            // ExSummary: Shows how to add Gantt chart view columns to be exported.
            var project = new Project(DataDir + "Project2.mpp");
            var task = project.RootTask.Children.GetById(1);
            
            var columns = new List<ViewColumn>
            {
                new GanttChartColumn(20, Field.TaskUniqueID),
                new GanttChartColumn("Name", 150, Field.TaskName),
                new GanttChartColumn("Start", 100, Field.TaskStart),
                new GanttChartColumn("End", 100, Field.TaskFinish),
                new GanttChartColumn("R-Initials", 100, Field.TaskResourceInitials),
                new GanttChartColumn("R-Names", 100, Field.TaskResourceNames),
                new GanttChartColumn("Work", 50, Field.TaskWork),
                new GanttChartColumn(
                    "Cost", 
                    80,
                    delegate(Task t)
                    {
                        return t.Get(Tsk.Cost).ToString(CultureInfo.InvariantCulture);
                    }),
                new GanttChartColumn(
                    "Actual Cost", 
                    80,
                    delegate(Task t)
                    {
                        return t.Get(Tsk.ActualCost).ToString(CultureInfo.InvariantCulture);
                    },
                    Field.TaskActualCost)
            };

            // iterate over columns
            foreach (var column in columns)
            {
                var col = (GanttChartColumn)column;
                Console.WriteLine("Column Name: " + col.Name);
                Console.WriteLine("Column Field: " + col.Field);
                Console.WriteLine("Column Text: " + col.GetColumnText(task));
                Console.WriteLine();
            }
            
            var options = new CsvOptions
            {
                View = new ProjectView(columns),
                PresentationFormat = PresentationFormat.GanttChart
            };

            project.Save(OutDir + "WorkWithGanttChartColumn_out.csv", options);

            // ExEnd:WorkWithGanttChartColumn 
        }
    }
    
    [TestFixture]
    public class ExPageInfo : ApiExampleBase
    {
        [Test]
        public void WorkWithPageInfo()
        {
            // ExStart:WorkWithPageInfo 
            // ExFor: PageInfo
            // ExFor: PageInfo.#ctor
            // ExFor: PageInfo.Name
            // ExFor: PageInfo.Header
            // ExFor: PageInfo.Legend
            // ExFor: PageInfo.Footer
            // ExFor: PageInfo.Margins
            // ExFor: PageInfo.PageSettings
            // ExFor: PageInfo.PageViewSettings
            // ExFor: PrinterPaperSize
            // ExSummary: Shows how to work with page info of MS Project view.
            var project = new Project(DataDir + "Project2.mpp");
            
            // lets modify the default view
            var info = project.DefaultView.PageInfo;

            Console.WriteLine("Modify Page Info: " + info.Name);

            // lets modify margins
            info.Margins.Left = 10d;
            info.Margins.Top = 10d;
            info.Margins.Right = 10d;
            info.Margins.Bottom = 10d;
            
            // lets modify page settings
            info.PageSettings.IsPortrait = true;
            info.PageSettings.PaperSize = PrinterPaperSize.PaperA4;
            
            // lets modify page view settings
            // set a value indicating whether to print notes.
            info.PageViewSettings.PrintNotes = true;

            var header = new HeaderFooterInfo
            {
                LeftText = "Left header text",
                CenteredText = "Centered header text",
                RightText = "Right header text"
            };
            var legend = new PageLegend
            {
                LeftText =  "Left legend text",
                CenteredText = "Centered legend text",
                RightText = "Right legend text"
            };
            var footer = new HeaderFooterInfo
            {
                LeftText = "Left footer text",
                CenteredText = "Centered footer text",
                RightText = "Right footer text"
            };

            info.Header = header;
            info.Legend = legend;
            info.Footer = footer;
            
            project.Save(OutDir + "WorkWithPageInfo_out.mpp", SaveFileFormat.MPP);
            // ExEnd:WorkWithPageInfo 
        }
    }
}