namespace Aspose.Tasks.Examples.CSharp
{
    using System;
    using System.Drawing;
    using NUnit.Framework;
    using Saving;
    using Visualization;

    [TestFixture]
    public class ExGridlines : ApiExampleBase
    {
        [Test]
        public void WorkWithGridlines()
        {
            try
            {
                // ExStart
                // ExFor: Gridlines
                // ExFor: Gridlines.Interval
                // ExFor: Gridlines.IntervalColor
                // ExFor: Gridlines.IntervalPattern
                // ExFor: Gridlines.NormalColor
                // ExFor: Gridlines.NormalPattern
                // ExFor: Gridlines.Type
                // ExFor: GanttChartView.Gridlines
                // ExSummary: Shows how to work with gridlines.
                var project = new Project(DataDir + "Project2.mpp");
            
                var view = (GanttChartView)project.Views.ToList()[0];
            
                // lets tune the first gridline of the view
                var gridlines = view.Gridlines[0];
                // set the number from 0 to 99 that specifies the interval between gridlines.
                gridlines.Interval = 2;
                // set the color of secondary gridlines.
                gridlines.IntervalColor = Color.Red;
                // set the line pattern for secondary gridlines
                gridlines.IntervalPattern = LinePattern.Solid;
                // set the color of normal gridlines
                gridlines.NormalColor = Color.Blue;
                // set the line pattern for normal gridlines
                gridlines.NormalPattern = LinePattern.CloseDot;
                // set the gridline type
                gridlines.Type = GridlineType.GanttRow;
            
                project.Save(OutDir + "WorkWithGridlines_out.mpp", SaveFileFormat.MPP);
                // ExEnd
            }
            catch (NotSupportedException ex)
            {
                Console.WriteLine(ex.Message + "\nThis example will only work if you apply a valid Aspose License. You can purchase full license or get 30 day temporary license from http://www.aspose.com/purchase/default.aspx.");
            }
        }
    }
}