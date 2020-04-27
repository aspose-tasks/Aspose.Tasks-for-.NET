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
                // ExFor: Aspose.Tasks.MinuteLabelDisplay.M
                // ExSummary: Shows how to set the minute label of project's display options (case 1).
                var project = new Project(DataDir + "EstimatedMilestoneTasks.mpp");

                // ...
                // set how the minute label is displayed
                project.DisplayOptions.MinuteLabel = MinuteLabelDisplay.M;

                // ...
                // ExEnd
            }

            {
                // ExStart
                // ExFor: Aspose.Tasks.MinuteLabelDisplay.Min
                // ExSummary: Shows how to set the minute label of project's display options (case 2).
                var project = new Project(DataDir + "EstimatedMilestoneTasks.mpp");

                // ...
                // set how the minute label is displayed
                project.DisplayOptions.MinuteLabel = MinuteLabelDisplay.Min;

                // ...
                // ExEnd
            }

            {
                // ExStart
                // ExFor: Aspose.Tasks.MinuteLabelDisplay.Minute
                // ExSummary: Shows how to set the minute label of project's display options (case 3).
                var project = new Project(DataDir + "EstimatedMilestoneTasks.mpp");

                // ...
                // set how the minute label is displayed
                project.DisplayOptions.MinuteLabel = MinuteLabelDisplay.Minute;

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
                // ExFor: Aspose.Tasks.HourLabelDisplay.H
                // ExSummary: Shows how to set the hour label of project's display options (case 1).
                var project = new Project(DataDir + "EstimatedMilestoneTasks.mpp");

                // ...
                // set how the hour label is displayed
                project.DisplayOptions.HourLabel = HourLabelDisplay.H;

                // ...
                // ExEnd
            }

            {
                // ExStart
                // ExFor: Aspose.Tasks.HourLabelDisplay.Hr
                // ExSummary: Shows how to set the hour label of project's display options (case 2).
                var project = new Project(DataDir + "EstimatedMilestoneTasks.mpp");

                // ...
                // set how the hour label is displayed
                project.DisplayOptions.HourLabel = HourLabelDisplay.Hr;

                // ...
                // ExEnd
            }

            {
                // ExStart
                // ExFor: Aspose.Tasks.HourLabelDisplay.Hour
                // ExSummary: Shows how to set the hour label of project's display options (case 3).
                var project = new Project(DataDir + "EstimatedMilestoneTasks.mpp");

                // ...
                // set how the hour label is displayed
                project.DisplayOptions.HourLabel = HourLabelDisplay.Hour;

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
                // ExFor: Aspose.Tasks.DayLabelDisplay.D
                // ExSummary: Shows how to set the day label of project's display options (case 1).
                var project = new Project(DataDir + "EstimatedMilestoneTasks.mpp");

                // ...
                // set how the day label is displayed
                project.DisplayOptions.DayLabel = DayLabelDisplay.D;

                // ...
                // ExEnd
            }

            {
                // ExStart
                // ExFor: Aspose.Tasks.DayLabelDisplay.Dy
                // ExSummary: Shows how to set the day label of project's display options (case 2).
                var project = new Project(DataDir + "EstimatedMilestoneTasks.mpp");

                // ...
                // set how the day label is displayed
                project.DisplayOptions.DayLabel = DayLabelDisplay.Dy;

                // ...
                // ExEnd
            }

            {
                // ExStart
                // ExFor: Aspose.Tasks.DayLabelDisplay.Day
                // ExSummary: Shows how to set the day label of project's display options (case 3).
                var project = new Project(DataDir + "EstimatedMilestoneTasks.mpp");

                // ...
                // set how the day label is displayed
                project.DisplayOptions.DayLabel = DayLabelDisplay.Day;

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
                // ExFor: Aspose.Tasks.WeekLabelDisplay.W
                // ExSummary: Shows how to set the week label of project's display options (case 1).
                var project = new Project(DataDir + "EstimatedMilestoneTasks.mpp");

                // ...
                // set how the week label is displayed
                project.DisplayOptions.WeekLabel = WeekLabelDisplay.W;

                // ...
                // ExEnd
            }

            {
                // ExStart
                // ExFor: Aspose.Tasks.WeekLabelDisplay.Wk
                // ExSummary: Shows how to set the week label of project's display options (case 2).
                var project = new Project(DataDir + "EstimatedMilestoneTasks.mpp");

                // ...
                // set how the week label is displayed
                project.DisplayOptions.WeekLabel = WeekLabelDisplay.Wk;

                // ...
                // ExEnd
            }

            {
                // ExStart
                // ExFor: Aspose.Tasks.WeekLabelDisplay.Week
                // ExSummary: Shows how to set the week label of project's display options (case 3).
                var project = new Project(DataDir + "EstimatedMilestoneTasks.mpp");

                // ...
                // set how the week label is displayed
                project.DisplayOptions.WeekLabel = WeekLabelDisplay.Week;

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
                // ExFor: Aspose.Tasks.MonthLabelDisplay.Mo
                // ExSummary: Shows how to set the month label of project's display options (case 1).
                var project = new Project(DataDir + "EstimatedMilestoneTasks.mpp");

                // ...
                // set how the month label is displayed
                project.DisplayOptions.MonthLabel = MonthLabelDisplay.Mo;

                // ...
                // ExEnd
            }

            {
                // ExStart
                // ExFor: Aspose.Tasks.MonthLabelDisplay.Mon
                // ExSummary: Shows how to set the month label of project's display options (case 2).
                var project = new Project(DataDir + "EstimatedMilestoneTasks.mpp");

                // ...
                // set how the month label is displayed
                project.DisplayOptions.MonthLabel = MonthLabelDisplay.Mon;

                // ...
                // ExEnd
            }

            {
                // ExStart
                // ExFor: Aspose.Tasks.MonthLabelDisplay.Month
                // ExSummary: Shows how to set the month label of project's display options (case 3).
                var project = new Project(DataDir + "EstimatedMilestoneTasks.mpp");

                // ...
                // set how the month label is displayed
                project.DisplayOptions.MonthLabel = MonthLabelDisplay.Month;

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
                // ExFor: Aspose.Tasks.YearLabelDisplay.Y
                // ExSummary: Shows how to set the year label of project's display options (case 1).
                var project = new Project(DataDir + "EstimatedMilestoneTasks.mpp");

                // ...
                // set how the year label is displayed
                project.DisplayOptions.YearLabel = YearLabelDisplay.Y;

                // ...
                // ExEnd
            }

            {
                // ExStart
                // ExFor: Aspose.Tasks.YearLabelDisplay.Yr
                // ExSummary: Shows how to set the year label of project's display options (case 2).
                var project = new Project(DataDir + "EstimatedMilestoneTasks.mpp");

                // ...
                // set how the year label is displayed
                project.DisplayOptions.YearLabel = YearLabelDisplay.Yr;

                // ...
                // ExEnd
            }

            {
                // ExStart
                // ExFor: Aspose.Tasks.YearLabelDisplay.Year
                // ExSummary: Shows how to set the year label of project's display options (case 3).
                var project = new Project(DataDir + "EstimatedMilestoneTasks.mpp");

                // ...
                // set how the year label is displayed
                project.DisplayOptions.YearLabel = YearLabelDisplay.Year;

                // ...
                // ExEnd
            }
        }
    }
}