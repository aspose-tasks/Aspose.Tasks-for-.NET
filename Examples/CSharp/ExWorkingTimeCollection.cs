namespace Aspose.Tasks.Examples.CSharp
{
    using System;
    using System.Collections.Generic;
    using NUnit.Framework;

    [TestFixture]
    public class ExWorkingTimeCollection : ApiExampleBase
    {
        [Test]
        public void CreateCustomizedWorkingTimeCollection()
        {
            // ExStart
            // ExFor: WorkingTimeCollection
            // ExFor: WorkingTimeCollection.Add(WorkingTime)
            // ExFor: WorkingTimeCollection.Count
            // ExFor: WorkingTimeCollection.GetEnumerator
            // ExFor: WorkingTimeCollection.Remove(WorkingTime)
            // ExFor: WorkingTimeCollection.ToList
            // ExSummary: Shows how to work with working time collection.
            var project = new Project();
            var calendar = project.Calendars.Add("Custom Calendar");
            
            calendar.WeekDays.Add(WeekDay.CreateDefaultWorkingDay(DayType.Monday));
            calendar.WeekDays.Add(WeekDay.CreateDefaultWorkingDay(DayType.Tuesday));
            calendar.WeekDays.Add(WeekDay.CreateDefaultWorkingDay(DayType.Wednesday));
            calendar.WeekDays.Add(WeekDay.CreateDefaultWorkingDay(DayType.Thursday));
            calendar.WeekDays.Add(WeekDay.CreateDefaultWorkingDay(DayType.Friday));

            var saturdayWorkingTimes = new List<WorkingTime>
            {
                new WorkingTime(8, 12),
                new WorkingTime(13, 15)
            };
            var saturday = new WeekDay(DayType.Saturday);
            foreach (var time in saturdayWorkingTimes)
            {
                saturday.WorkingTimes.Add(time);
            }

            // print working times of Saturday
            Console.WriteLine("Saturday working period number: " + saturday.WorkingTimes.Count);
            foreach (var time in saturday.WorkingTimes)
            {
                Console.WriteLine("From Time: " + time.From);
                Console.WriteLine("To Time: " + time.To);
            }

            Console.WriteLine();

            var sundayWorkingTimes = new List<WorkingTime>
            {
                new WorkingTime(10, 15)
            };
            var sunday = new WeekDay(DayType.Sunday, sundayWorkingTimes);
            
            // print working times of sunday
            List<WorkingTime> workingTimes = sunday.WorkingTimes.ToList();
            Console.WriteLine("Sunday working period number: " + workingTimes.Count);
            for (var index = 0; index < workingTimes.Count; index++)
            {
                var time = workingTimes[index];
                Console.WriteLine("From Time: " + time.From);
                Console.WriteLine("To Time: " + time.To);
            }

            Console.WriteLine();

            calendar.WeekDays.Add(saturday);
            calendar.WeekDays.Add(sunday);

            foreach (var day in calendar.WeekDays)
            {
                Console.WriteLine(day.DayType + ": ");

                // You can further traverse through working times and display these
                foreach (var workingTime in day.WorkingTimes)
                {
                    Console.WriteLine(workingTime.From);
                    Console.WriteLine(workingTime.To);
                }

                Console.WriteLine();
            }

            // ExEnd
        }
    }
}