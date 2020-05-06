namespace Aspose.Tasks.Examples.CSharp
{
    using System;
    using NUnit.Framework;
    using Saving;
    using Visualization;

    [TestFixture]
    public class ExRecurringInterval : ApiExampleBase
    {
        [Test]
        public void WorkWithRecurringInterval()
        {
            // ExStart
            // ExFor: RecurringInterval
            // ExFor: RecurringInterval.Interval
            // ExFor: RecurringInterval.MonthlyDay
            // ExFor: RecurringInterval.MonthlyDayDayNumber
            // ExFor: RecurringInterval.MonthlyDayMonthNumber
            // ExFor: RecurringInterval.MonthlyFirstLast
            // ExFor: RecurringInterval.MonthlyFirstLastDay
            // ExFor: RecurringInterval.MonthlyFirstLastMonthNumber
            // ExFor: RecurringInterval.WeeklyDays
            // ExFor: RecurringInterval.WeeklyWeekNumber
            // ExSummary: Shows how to work with recurring interval of progress lines.
            var project = new Project(DataDir + "Project2007.mpp");
            project.Set(Prj.StatusDate, project.Get(Prj.StartDate));
            
            var view = (GanttChartView)project.Views.ToList()[1];
            
            // lets read progress line
            var interval = view.ProgressLines.RecurringInterval;

            Console.WriteLine("Interval: " + interval.Interval);
            Console.WriteLine("Weekly Week Number: " + interval.WeeklyWeekNumber);
            foreach (var day in interval.WeeklyDays)
            {
                Console.WriteLine("Week day: " + day);
            }
            
            // lets redefine recurring interval
            var newInterval = new RecurringInterval();

            // set a value indicating whether to show monthly progress lines by day.
            interval.MonthlyDay = true;
            // set the day number of monthly progress lines.
            interval.MonthlyDayDayNumber = 1;
            // set the month number of monthly progress lines.
            interval.MonthlyDayMonthNumber = 1;
            // set a value indicating whether to show progress lines by first or last predefined day.
            interval.MonthlyFirstLast = true;
            // set the first or the last day type of monthly progress lines.
            interval.MonthlyFirstLastDay = RecurringInterval.DayType.Day;
            // set the month number of progress lines, which are shown by first or last predefined day.
            interval.MonthlyFirstLastMonthNumber = 1;
            
            view.ProgressLines.RecurringInterval = newInterval;
            
            project.Save(OutDir + "WorkWithRecurringInterval_out.pdf", SaveFileFormat.PDF);
            // ExEnd
        }
        
        [Test]
        public void WorkWithRecurringIntervalDaily()
        {
            // ExStart
            // ExFor: RecurringInterval.DailyDayNumber
            // ExFor: RecurringInterval.DailyWorkday
            // ExSummary: Shows how to add daily recurring interval of progress lines.
            var project = new Project(DataDir + "Project2007.mpp");
            project.Set(Prj.StatusDate, project.Get(Prj.StartDate));
            
            var view = (GanttChartView)project.Views.ToList()[1];
            
            view.ProgressLines.RecurringInterval = new RecurringInterval();
            // set the daily pattern day number
            view.ProgressLines.RecurringInterval.DailyDayNumber = 2;
            // set a value indicating whether a day is workday for daily progress lines.
            view.ProgressLines.RecurringInterval.DailyWorkday = true;
            // ExEnd
        }
    }
}