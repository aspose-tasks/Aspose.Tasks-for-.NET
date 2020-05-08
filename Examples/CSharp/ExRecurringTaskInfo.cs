namespace Aspose.Tasks.Examples.CSharp
{
    using System;
    using NUnit.Framework;

    [TestFixture]
    public class ExRecurringTaskInfo : ApiExampleBase
    {
        [Test]
        public void WorkWithRecurringInfo()
        {
            // ExStart
            // ExFor: RecurringTaskInfo
            // ExFor: RecurringTaskInfo.StartDate
            // ExFor: RecurringTaskInfo.Duration
            // ExFor: RecurringTaskInfo.EndDate
            // ExFor: RecurringTaskInfo.DailyRepetitions
            // ExFor: RecurringTaskInfo.DailyUseWorkdays
            // ExFor: RecurringTaskInfo.MonthlyDay
            // ExFor: RecurringTaskInfo.MonthlyOrdinalDay
            // ExFor: RecurringTaskInfo.MonthlyOrdinalNumber
            // ExFor: RecurringTaskInfo.MonthlyOrdinalRepetitions
            // ExFor: RecurringTaskInfo.MonthlyRepetitions
            // ExFor: RecurringTaskInfo.MonthlyUseOrdinalDay
            // ExFor: RecurringTaskInfo.Occurrences
            // ExFor: RecurringTaskInfo.RecurrencePattern
            // ExFor: RecurringTaskInfo.Task
            // ExFor: RecurringTaskInfo.UseEndDate
            // ExFor: RecurringTaskInfo.WeeklyDays
            // ExFor: RecurringTaskInfo.WeeklyRepetitions
            // ExFor: RecurringTaskInfo.YearlyDate
            // ExFor: RecurringTaskInfo.YearlyOrdinalDay
            // ExFor: RecurringTaskInfo.YearlyOrdinalMonth
            // ExFor: RecurringTaskInfo.YearlyOrdinalNumber
            // ExFor: RecurringTaskInfo.YearlyUseOrdinalDay
            // ExFor: OrdinalNumber
            // ExSummary: Shows how to read with recurring info of tasks.
            var project = new Project(DataDir + "TestRecurringTask2016.mpp");

            // read recurring information of tasks
            foreach (var task in project.RootTask.SelectAllChildTasks())
            {
                var info = task.RecurringInfo;
                if (info == null)
                {
                    continue;
                }

                Console.WriteLine("Start Date: " + info.StartDate);
                Console.WriteLine("Duration: " + info.Duration);
                Console.WriteLine("End Date: " + info.EndDate);
                Console.WriteLine("Daily Repetitions: " + info.DailyRepetitions);
                Console.WriteLine("Daily Use Workdays: " + info.DailyUseWorkdays);
                Console.WriteLine("Monthly Day: " + info.MonthlyDay);
                Console.WriteLine("Monthly Ordinal Day: " + info.MonthlyOrdinalDay);
                Console.WriteLine("Monthly Ordinal Number: " + info.MonthlyOrdinalNumber);
                Console.WriteLine("Monthly Ordinal Repetitions: " + info.MonthlyOrdinalRepetitions);
                Console.WriteLine("Monthly Repetitions: " + info.MonthlyRepetitions);
                Console.WriteLine("Monthly Use Ordinal Day: " + info.MonthlyUseOrdinalDay);
                Console.WriteLine("Occurrences: " + info.Occurrences);
                Console.WriteLine("Recurrence Pattern: " + info.RecurrencePattern);
                Console.WriteLine("Parent Task: " + info.Task.Get(Tsk.Name));
                Console.WriteLine("Use End Date: " + info.UseEndDate);
                Console.WriteLine("Weekly Days: " + info.WeeklyDays);
                Console.WriteLine("Weekly Repetitions: " + info.WeeklyRepetitions);
                Console.WriteLine("Yearly Date: " + info.YearlyDate);
                Console.WriteLine("Yearly Ordinal Day: " + info.YearlyOrdinalDay);
                Console.WriteLine("Yearly Ordinal Month: " + info.YearlyOrdinalMonth);
                Console.WriteLine("Yearly Ordinal Number: " + info.YearlyOrdinalNumber);
                Console.WriteLine("Yearly Use Ordinal Day: " + info.YearlyUseOrdinalDay);
                Console.WriteLine();
            }

            // ExEnd
        }
    }
}