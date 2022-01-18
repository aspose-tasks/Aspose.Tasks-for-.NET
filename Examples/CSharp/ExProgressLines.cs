namespace Aspose.Tasks.Examples.CSharp
{
    using System;
    using System.Drawing;
    using NUnit.Framework;
    using Saving;
    using Visualization;

    [TestFixture]
    public class ExProgressLines : ApiExampleBase
    {
        [Test]
        public void WorkWithProgressLines()
        {
            try
            {
                // ExStart
                // ExFor: ProgressLines
                // ExFor: ProgressLines.BeginAtDate
                // ExFor: ProgressLines.BeginAtProjectStart
                // ExFor: ProgressLines.DateFormat
                // ExFor: ProgressLines.DisplayAtCurrentDate
                // ExFor: ProgressLines.DisplayAtRecurringIntervals
                // ExFor: ProgressLines.DisplaySelected
                // ExFor: ProgressLines.Font
                // ExFor: ProgressLines.IsBaselinePlan
                // ExFor: ProgressLines.LineColor
                // ExFor: ProgressLines.LinePattern
                // ExFor: ProgressLines.OtherLineColor
                // ExFor: ProgressLines.OtherLinePattern
                // ExFor: ProgressLines.OtherProgressPointColor
                // ExFor: ProgressLines.OtherProgressPointShape
                // ExFor: ProgressLines.ProgressPointColor
                // ExFor: ProgressLines.ProgressPointShape
                // ExFor: ProgressLines.RecurringInterval
                // ExFor: ProgressLines.SelectedDates
                // ExFor: ProgressLines.ShowDate
                // ExFor: GanttChartView.ProgressLines
                // ExFor: LinePattern
                // ExSummary: Shows how to work with progress lines.
                var project = new Project(DataDir + "Project2.mpp");
                project.Set(Prj.StatusDate, project.Get(Prj.StartDate));
                
                var view = (GanttChartView)project.Views.ToList()[0];
                
                // lets define progress line
                view.ProgressLines = new ProgressLines();
                var progressLines = view.ProgressLines;

                // set the date to display progress lines from. Lets set a project's status date.
                progressLines.BeginAtDate = project.Get(Prj.StatusDate);
                // set a value indicating whether to display progress lines from the beginning of the project start date
                progressLines.BeginAtProjectStart = true;
                // set the date format (<see cref="T:Aspose.Tasks.Visualization.DateLabel" />).
                progressLines.DateFormat = DateLabel.DayDddd;
                // set a value indicating whether to display progress line at current date.
                progressLines.DisplayAtCurrentDate = true;
                // set a value indicating whether to display progress line at recurring intervals.
                progressLines.DisplayAtRecurringIntervals = true;
                // set a value indicating whether to display progress lines at the selected dates
                progressLines.DisplaySelected = true;
                // set a value indicating whether to display progress lines for baseline plan or actual.
                progressLines.IsBaselinePlan = false;
                // set the font used for progress line label.
                progressLines.Font = new Font(new FontFamily("Arial"), 10);
                // set the line color for current progress line.
                progressLines.LineColor = Color.Aquamarine;
                // set the line pattern of current progress line.
                progressLines.LinePattern = LinePattern.Dashed;
                // set the color of other progress line.
                progressLines.OtherLineColor = Color.Azure;
                // set the line pattern for other progress line.
                progressLines.OtherLinePattern = LinePattern.Dotted;
                // set the color of other progress point.
                progressLines.OtherProgressPointColor = Color.Red;
                // set the progress point shape of other progress line.
                progressLines.OtherProgressPointShape = GanttBarEndShape.Circle;
                // set the color of progress point.
                progressLines.ProgressPointColor = Color.Orange;
                // set the progress point shape.
                progressLines.ProgressPointShape = GanttBarEndShape.Diamond;
                // set the recurring interval.
                progressLines.RecurringInterval = new RecurringInterval();
                // set the recurring interval.
                progressLines.RecurringInterval.Interval = Interval.Daily;
                // set the daily day number
                progressLines.RecurringInterval.DailyDayNumber = 1;
                // set a value indicating whether to show date for each progress line.
                progressLines.ShowDate = true;

                // lets check progress lines
                Console.WriteLine("Begin At Date: " + progressLines.BeginAtDate);
                Console.WriteLine("Begin At Project Start: " + progressLines.BeginAtProjectStart);
                Console.WriteLine("Date Format: " + progressLines.DateFormat);
                Console.WriteLine("Display At Current Date: " + progressLines.DisplayAtCurrentDate);
                Console.WriteLine("Display At Recurring Intervals: " + progressLines.DisplayAtRecurringIntervals);
                Console.WriteLine("Display Selected: " + progressLines.DisplaySelected);
                Console.WriteLine("Font: " + progressLines.Font);
                Console.WriteLine("Is Baseline Plan: " + progressLines.IsBaselinePlan);
                Console.WriteLine("Line Color: " + progressLines.LineColor);
                Console.WriteLine("Line Pattern: " + progressLines.LinePattern);
                Console.WriteLine("Other Line Color: " + progressLines.OtherLineColor);
                Console.WriteLine("Other Line Pattern: " + progressLines.OtherLinePattern);
                Console.WriteLine("Other Progress Point Color: " + progressLines.OtherProgressPointColor);
                Console.WriteLine("Other Progress Point Shape: " + progressLines.OtherProgressPointShape);
                Console.WriteLine("Progress Point Color: " + progressLines.ProgressPointColor);
                Console.WriteLine("Progress Point Shape: " + progressLines.ProgressPointShape);
                Console.WriteLine("Recurring Interval: " + progressLines.RecurringInterval.Interval);
                Console.WriteLine("Recurring Interval DailyDayNumber: " + progressLines.RecurringInterval.DailyDayNumber);
                Console.WriteLine("Selected Dates: ");
                foreach (var date in progressLines.SelectedDates)
                {
                    Console.WriteLine("Date: " + date);
                }
                Console.WriteLine("Show Date: " + progressLines.ShowDate);
                Console.WriteLine();
                
                project.Save(OutDir + "WorkWithProgressLines_out.mpp", SaveFileFormat.Mpp);
                // ExEnd
            }
            catch (NotSupportedException ex)
            {
                Console.WriteLine(ex.Message + "\nThis example will only work if you apply a valid Aspose License. You can purchase full license or get 30 day temporary license from http://www.aspose.com/purchase/default.aspx.");
            }
        }
    }
}