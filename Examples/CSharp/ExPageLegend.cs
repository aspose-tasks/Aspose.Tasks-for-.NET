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
                // ExFor: PageLegend.LeftImage
                // ExFor: PageLegend.LeftText
                // ExFor: PageLegend.CenteredImage
                // ExFor: PageLegend.CenteredText
                // ExFor: PageLegend.RightImage
                // ExFor: PageLegend.RightText
                // ExFor: Legend
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
            
                project.Save(OutDir + "WorkWithPageLegend_out.mpp", SaveFileFormat.MPP);
                // ExEnd:WorkWithPageLegend
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