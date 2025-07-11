using Aspose.Tasks.Visualization;

namespace Aspose.Tasks.Examples.CSharp
{
    using System;
    using NUnit.Framework;
    using Saving;

    [TestFixture]
    public class ExPageLegend : ApiExampleBase
    {
        [Test]
        public void WorkWithPageLegend()
        {
            try
            {
                // ExStart:WorkWithPageLegend
                // ExFor: PageLegend
                // ExFor: PageLegend.Width
                // ExFor: PageLegend.LegendOn
                // ExFor: PageInfo.Legend
                // ExSummary: Shows how to work with page legend information.
                var project = new Project(DataDir + "Blank2010.mpp");
            
                // lets read page legend information
                var legend = project.DefaultView.PageInfo.Legend;

                Console.WriteLine("Legend left text: {0} ", legend.LeftText);
                Console.WriteLine("Legend left image: {0} ", legend.LeftImage);
                Console.WriteLine("Legend center text: {0} ", legend.CenteredText);
                Console.WriteLine("Legend center image: {0} ", legend.CenteredImage);
                Console.WriteLine("Legend right text: {0} ", legend.RightText);
                Console.WriteLine("Legend right image: {0} ", legend.RightImage);
                Console.WriteLine("Legend On: {0} ", legend.LegendOn);
                Console.WriteLine("Legend Width: {0} ", legend.Width);
            
                // also modification of a legend is supported
                legend.LeftText = "New Left Text";
            
                project.Save(OutDir + "WorkWithPageLegend_out.mpp", SaveFileFormat.Mpp);
                // ExEnd:WorkWithPageLegend
            }
            catch (NotSupportedException ex)
            {
                Console.WriteLine(
                    ex.Message
                    + "\nThis example will only work if you apply a valid Aspose License. You can purchase full license or get 30 day temporary license from http://www.aspose.com/purchase/default.aspx.");
            }
        }

        [Test]
        public void CustomizePageLegendItems()
        {
            try
            {
                // ExStart:CustomizePageLegendItems
                // ExFor: SaveOptions.LegendDrawingOptions
                // ExFor: SaveOptions.LegendItems
                // ExFor: PageLegendItem
                // ExSummary: Shows how to customize task bars in page legend of Gantt chart.
                var project = new Project(DataDir + "Blank2010.mpp");

                var pdfSaveOptions = new PdfSaveOptions();
                pdfSaveOptions.StartDate = project.StartDate;
                pdfSaveOptions.EndDate = project.FinishDate;
                pdfSaveOptions.PageSize = PageSize.A4;
                pdfSaveOptions.LegendDrawingOptions = LegendDrawingOptions.OnEveryPage;
                pdfSaveOptions.ViewSettings = project.Views.GetByName("&Gantt Chart");

                pdfSaveOptions.LegendItems = new PageLegendItem[]
                {
                    new PageLegendItem(BarItemType.Task, "Task"),
                    new PageLegendItem(BarItemType.ExternalMilestone, "External Milestone"),
                    new PageLegendItem(BarItemType.SummaryRollup, "Summary Rollup"),
                    new PageLegendItem(BarItemType.InactiveTask, "Inactive Task"),
                    new PageLegendItem(BarItemType.ManualSummary, "Manual Summary")
                };

                project.Save(OutDir + "CustomizePageLegendItems_out.pdf", pdfSaveOptions);
                // ExEnd:CustomizePageLegendItems
            }
            catch (NotSupportedException ex)
            {
                Console.WriteLine(
                    ex.Message
                    + "\nThis example will only work if you apply a valid Aspose License. You can purchase full license or get 30 day temporary license from http://www.aspose.com/purchase/default.aspx.");
            }
        }
    }
}