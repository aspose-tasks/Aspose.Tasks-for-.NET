namespace Aspose.Tasks.Examples.CSharp
{
    using NUnit.Framework;

    [TestFixture]
    public class ExLabelDisplay : ApiExampleBase
    {
        [Test]
        public void WorkWithMinuteLabelDisplay()
        {
            {
                // ExStart
                // ExFor: Aspose.Tasks.MinuteLabelDisplay
                // ExSummary: Shows how to set the minute label of project's display options (case 1).
                var project = new Project(DataDir + "EstimatedMilestoneTasks.mpp");

                // ...
                // set how the minute label is displayed
                project.DisplayOptions.MinuteLabel = MinuteLabelDisplay.M;

                // ...
                // ExEnd
            }
        }
        
        [Test]
        public void WorkWithHourLabelDisplay()
        {
            {
                // ExStart
                // ExFor: Aspose.Tasks.HourLabelDisplay
                // ExSummary: Shows how to set the hour label of project's display options (case 1).
                var project = new Project(DataDir + "EstimatedMilestoneTasks.mpp");

                // ...
                // set how the hour label is displayed
                project.DisplayOptions.HourLabel = HourLabelDisplay.H;

                // ...
                // ExEnd
            }
        }
        
        [Test]
        public void WorkWithDayLabelDisplay()
        {
            {
                // ExStart
                // ExFor: Aspose.Tasks.DayLabelDisplay
                // ExSummary: Shows how to set the day label of project's display options (case 1).
                var project = new Project(DataDir + "EstimatedMilestoneTasks.mpp");

                // ...
                // set how the day label is displayed
                project.DisplayOptions.DayLabel = DayLabelDisplay.D;

                // ...
                // ExEnd
            }
        }
        
        [Test]
        public void WorkWithWeekLabelDisplay()
        {
            {
                // ExStart
                // ExFor: Aspose.Tasks.WeekLabelDisplay
                // ExSummary: Shows how to set the week label of project's display options (case 1).
                var project = new Project(DataDir + "EstimatedMilestoneTasks.mpp");

                // ...
                // set how the week label is displayed
                project.DisplayOptions.WeekLabel = WeekLabelDisplay.W;

                // ...
                // ExEnd
            }
        }
        
        [Test]
        public void WorkWithMonthLabelDisplay()
        {
            {
                // ExStart
                // ExFor: Aspose.Tasks.MonthLabelDisplay
                // ExSummary: Shows how to set the month label of project's display options (case 1).
                var project = new Project(DataDir + "EstimatedMilestoneTasks.mpp");

                // ...
                // set how the month label is displayed
                project.DisplayOptions.MonthLabel = MonthLabelDisplay.Mo;

                // ...
                // ExEnd
            }
        }
        
        [Test]
        public void WorkWithYearLabelDisplay()
        {
            {
                // ExStart
                // ExFor: Aspose.Tasks.YearLabelDisplay
                // ExSummary: Shows how to set the year label of project's display options (case 1).
                var project = new Project(DataDir + "EstimatedMilestoneTasks.mpp");

                // ...
                // set how the year label is displayed
                project.DisplayOptions.YearLabel = YearLabelDisplay.Y;

                // ...
                // ExEnd
            }
        }
    }
}