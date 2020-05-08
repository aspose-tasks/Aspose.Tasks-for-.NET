namespace Aspose.Tasks.Examples.CSharp
{
    using System;
    using System.Collections.Generic;
    using System.Drawing;
    using NUnit.Framework;
    using Saving;
    using Visualization;

    [TestFixture]
    public class ExViewColumn : ApiExampleBase
    {
        [Test]
        public void AlignCellContents()
        {
            // ExStart:AlignCellContents
            // ExFor: ViewColumn.StringAlignment
            // ExSummary: Shows how to set a alignment of the text in a column (can be one of the values of the <see cref="P:Aspose.Tasks.Visualization.ViewColumn.StringAlignment" /> enumeration).
            var project = new Project(DataDir + "Project2.mpp");
            SaveOptions options = new PdfSaveOptions();
            options.Timescale = Timescale.Months;
            options.View = ProjectView.GetDefaultGanttChartView();

            var column1 = (GanttChartColumn)options.View.Columns[2];
            column1.StringAlignment = StringAlignment.Center;
            var column2 = (GanttChartColumn)options.View.Columns[3];
            column2.StringAlignment = StringAlignment.Far;
            var column3 = (GanttChartColumn)options.View.Columns[4];
            column3.StringAlignment = StringAlignment.Far;

            project.Save(OutDir + "AlignCellContents_GanttChart_out.pdf", options);

            options.PresentationFormat = PresentationFormat.ResourceSheet;
            options.View = ProjectView.GetDefaultResourceSheetView();

            var column4 = (ResourceViewColumn)options.View.Columns[2];
            column4.StringAlignment = StringAlignment.Center;
            var column5 = (ResourceViewColumn)options.View.Columns[3];
            column5.StringAlignment = StringAlignment.Far;
            var column6 = (ResourceViewColumn)options.View.Columns[4];
            column6.StringAlignment = StringAlignment.Far;

            project.Save(OutDir + "AlignCellContents_ResourceSheet_out.pdf", options);

            // ExEnd:AlignCellContents
        }
        
        // ExStart:WorkWithViewColumn
        // ExFor: ViewColumn
        // ExFor: ViewColumn.#ctor(String,Int32)
        // ExFor: ViewColumn.Name
        // ExFor: ViewColumn.Field
        // ExFor: ViewColumn.Width
        // ExFor: ViewColumn.TextStyleModificationCallback
        // ExFor: ITextStyleModificationCallback
        // ExFor: ITextStyleModificationCallback.BeforeTaskTextStyleApplied(TaskTextStyleEventArgs)
        // ExFor: TaskTextStyleEventArgs
        // ExFor: TaskTextStyleEventArgs.CellTextStyle
        // ExFor: TaskTextStyleEventArgs.Column
        // ExFor: TaskTextStyleEventArgs.Task
        // ExSummary: Shows how to add view columns to be exported.
        [Test] // ExSkip
        public void WorkWithViewColumn()
        {
            var project = new Project(DataDir + "Project2.mpp");

            var options = new PdfSaveOptions();
            var columns = new List<ViewColumn>
            {
                new ResourceViewColumn(100, Field.ResourceName),
                new ResourceViewColumn(100, Field.ResourceActualWork),
                new ResourceViewColumn(100, Field.ResourceCost)
            };
            
            columns[0].TextStyleModificationCallback = new MyTextStyleCallback();
            
            // iterate over columns
            foreach (var column in columns)
            {
                Console.WriteLine("Column Name: " + column.Name);
                Console.WriteLine("Column Field: " + column.Field);
                Console.WriteLine("Column Width: " + column.Width);
                Console.WriteLine("Column Callback: " + column.TextStyleModificationCallback);
                Console.WriteLine();
            }

            options.View = new ProjectView(columns);
            options.PresentationFormat = PresentationFormat.ResourceUsage;
            
            project.Save(OutDir + "WorkWithViewColumn_out.pdf", options);
        }
        
        private class MyTextStyleCallback : ITextStyleModificationCallback
        {
            /// <summary>
            /// The method to be called before rendering of a table cell for a task row in the following views:
            /// 'Gantt Chart', 'Task Sheet', 'Task Usage'.
            /// </summary>
            /// <param name="args">The <see cref="T:Aspose.Tasks.Visualization.TaskTextStyleEventArgs" /> object.</param>
            public void BeforeTaskTextStyleApplied(TaskTextStyleEventArgs args)
            {
                if (args.Task.Get(Tsk.Uid) % 2 == 0)
                {
                    args.CellTextStyle.BackgroundColor = 
                        args.Column.StringAlignment == StringAlignment.Center 
                        ? Color.Cyan : Color.Red;
                    args.CellTextStyle.BackgroundPattern = BackgroundPattern.SolidFill;
                }
                else
                {
                    args.CellTextStyle.Color = Color.DarkGreen;
                }
            }
        }
        // ExEnd:WorkWithViewColumn
    }
}