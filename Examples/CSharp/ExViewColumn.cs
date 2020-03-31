namespace Aspose.Tasks.Examples.CSharp
{
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
            //ExStart:AlignCellContents
            //ExFor: ViewColumn.StringAlignment
            //ExSummary: Shows how to set a alignment of the text in a column (can be one of the values of the <see cref="P:Aspose.Tasks.Visualization.ViewColumn.StringAlignment" /> enumeration).
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
            //ExEnd:AlignCellContents
        }
    }
}