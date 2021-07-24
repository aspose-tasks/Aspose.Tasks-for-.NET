namespace Aspose.Tasks.Examples.CSharp
{
    using System;
    using System.Collections.Generic;
    using NUnit.Framework;

    [TestFixture]
    public class ExWorkWeek : ApiExampleBase
    {
        [Test]
        public static void WorkWithWorkWeek()
        {
            // ExStart
            // ExFor: WorkWeek
            // ExFor: WorkWeek.#ctor
            // ExFor: WorkWeek.Name
            // ExFor: WorkWeek.FromDate
            // ExFor: WorkWeek.ToDate
            // ExFor: WorkWeek.WeekDays
            // ExSummary: Shows how to read work week information from the project.
            var project = new Project();
            var calendar = project.Calendars.Add("Standard");
            Calendar.MakeStandardCalendar(calendar);

            var item = new WorkWeek(calendar);
            item.Name = "My Work Week";
            item.FromDate = new DateTime(2020, 4, 13, 8, 0, 0);
            item.ToDate = new DateTime(2020, 4, 17, 17, 0, 0);
            item.WeekDays.Add(WeekDay.CreateDefaultWorkingDay(DayType.Monday));
            item.WeekDays.Add(WeekDay.CreateDefaultWorkingDay(DayType.Tuesday));
            item.WeekDays.Add(WeekDay.CreateDefaultWorkingDay(DayType.Wednesday));
            item.WeekDays.Add(WeekDay.CreateDefaultWorkingDay(DayType.Thursday));
            item.WeekDays.Add(WeekDay.CreateDefaultWorkingDay(DayType.Friday));
            item.WeekDays.Add(new WeekDay(DayType.Saturday));
            item.WeekDays.Add(new WeekDay(DayType.Sunday));
            calendar.WorkWeeks.Add(item);

            Console.WriteLine("Work Week Number: " + calendar.WeekDays.Count);
            foreach (var workWeek in calendar.WorkWeeks)
            {
                // Display work week name, parent calendar name, from, and to dates
                Console.WriteLine("Name: " + workWeek.Name);
                Console.WriteLine("Parent calendar name: " + calendar.Name);
                Console.WriteLine("From Date: " + workWeek.FromDate);
                Console.WriteLine("To Date: " + workWeek.ToDate);
                Console.WriteLine();

                // This data is all about "Details." button you can set special working times for special WeekDay or even make it nonworking
                List<WeekDay> weekDays = workWeek.WeekDays.ToList();
                foreach (var day in weekDays)
                {
                    Console.WriteLine(day.DayType.ToString());

                    // You can further traverse through working times and display these
                    foreach (var workingTime in day.WorkingTimes)
                    {
                        Console.WriteLine(workingTime.FromTime);
                        Console.WriteLine(workingTime.ToTime);
                    }
                }

                Console.WriteLine();
            }

            // ExEnd
        }
    }
}