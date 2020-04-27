namespace Aspose.Tasks.Examples.CSharp
{
    using System;
    using NUnit.Framework;
    using Saving;

    [TestFixture]
    public class ExProjectDisplayOptions : ApiExampleBase
    {
        [Test]
        public void WorkWithProjectDisplayOptions()
        {
            try
            {
                // ExStart:ProjectDisplayOptionsUsage
                // ExFor: ProjectDisplayOptions
                // ExFor: ProjectDisplayOptions.#ctor
                // ExFor: ProjectDisplayOptions.AddSpaceBeforeLabel
                // ExFor: ProjectDisplayOptions.MinuteLabel
                // ExFor: ProjectDisplayOptions.HourLabel
                // ExFor: ProjectDisplayOptions.DayLabel
                // ExFor: ProjectDisplayOptions.WeekLabel
                // ExFor: ProjectDisplayOptions.MonthLabel
                // ExFor: ProjectDisplayOptions.YearLabel
                // ExFor: ProjectDisplayOptions.ShowProjectSummaryTask
                // ExFor: ProjectDisplayOptions.ShowTaskScheduleWarnings
                // ExFor: ProjectDisplayOptions.ShowTaskScheduleSuggestions
                // ExFor: ProjectDisplayOptions.UnderlineHyperlinks
                // ExSummary: Shows how to use project's display options.
                var project = new Project(DataDir + "EstimatedMilestoneTasks.mpp");

                // Set a value indicating whether to show warnings when Project identifies a possible scheduling conflict with a manually scheduled task.
                // This option is available for Project 2010 version and later.
                project.DisplayOptions.ShowTaskScheduleWarnings = false;

                // a value indicating whether to add a space before the number value and the time abbreviation (1 wk as opposed to 1wk)
                project.DisplayOptions.AddSpaceBeforeLabel = true;

                // set how the minute label is displayed
                project.DisplayOptions.MinuteLabel = MinuteLabelDisplay.Min;

                // set how the hour label is displayed
                project.DisplayOptions.HourLabel = HourLabelDisplay.Hr;

                // set how the day label is displayed
                project.DisplayOptions.DayLabel = DayLabelDisplay.Dy;

                // set how the week label is displayed
                project.DisplayOptions.WeekLabel = WeekLabelDisplay.Week;

                // set how the month label is displayed
                project.DisplayOptions.MonthLabel = MonthLabelDisplay.Mon;

                // set how the year label is displayed
                project.DisplayOptions.YearLabel = YearLabelDisplay.Year;

                // set a value indicating whether to display summary information about an entire project on a single row with its own summary task bar at the top of the Gantt Chart view.
                project.DisplayOptions.ShowProjectSummaryTask = true;

                // set a value indicating whether to show suggestions when Project identifies a possible scheduling conflict with a manually scheduled task.
                project.DisplayOptions.ShowTaskScheduleSuggestions = true;

                // set a value indicating whether to underline hyperlinks.
                project.DisplayOptions.UnderlineHyperlinks = true;

                project.Save(OutDir + "WorkWithProjectDisplayOptions.mpp", SaveFileFormat.MPP);

                // ExEnd:ProjectDisplayOptionsUsage
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