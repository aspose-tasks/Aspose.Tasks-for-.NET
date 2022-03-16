namespace Aspose.Tasks.Examples.CSharp
{
    using System;
    using System.Collections.Generic;
    using System.Diagnostics.CodeAnalysis;

    using NUnit.Framework;

    [TestFixture]
    [SuppressMessage("ReSharper", "StyleCop.SA1600", Justification = "Reviewed. Suppression is OK here.")]
    [SuppressMessage("ReSharper", "MemberCanBePrivate.Global", Justification = "Reviewed. Suppression is OK here.")]
    public class ExWorkingTime : ApiExampleBase
    {
        // ExStart
        // ExFor: WorkingTime
        // ExFor: WorkingTime.#ctor
        // ExFor: WorkingTime.#ctor(System.DateTime,System.DateTime)
        // ExFor: WorkingTime.From
        // ExFor: WorkingTime.To
        // ExSummary: Shows how to work with working time information.
        [Test] // ExSkip
        public void WorkWithWorkingTime()
        {
            var project = new Project();
            var calendar = CreateCalendar(project);
            project.Set(Prj.Calendar, calendar);

            Console.WriteLine("Work Week Number: " + calendar.WeekDays.Count);

            // This data is all about "Details." button you can set special working times for special WeekDay or even make it nonworking
            List<WeekDay> weekDays = calendar.WeekDays.ToList();
            foreach (var day in weekDays)
            {
                Console.WriteLine(day.DayType.ToString());

                // You can further traverse through working times and display these
                foreach (var workingTime in day.WorkingTimes)
                {
                    Console.WriteLine(workingTime.From);
                    Console.WriteLine(workingTime.To);
                }
            }
        }

        public static Calendar CreateCalendar(Project project)
        {
            var calendar = project.Calendars.Add("MyCalendar", project.Calendars.GetByName("Standard"));
            var workingTimes = new List<WorkingTime>
                                   {
                                       new WorkingTime(new DateTime(1, 1, 1, 9, 0, 0), new DateTime(1, 1, 1, 12, 0, 0)),
                                       new WorkingTime(new DateTime(1, 1, 1, 13, 0, 0), new DateTime(1, 1, 1, 18, 0, 0))
                                   };

            calendar.WeekDays.Add(new WeekDay(DayType.Monday, workingTimes));
            calendar.WeekDays.Add(new WeekDay(DayType.Tuesday, workingTimes));
            calendar.WeekDays.Add(new WeekDay(DayType.Wednesday, workingTimes));
            calendar.WeekDays.Add(new WeekDay(DayType.Thursday, workingTimes));
            calendar.WeekDays.Add(new WeekDay(DayType.Friday, workingTimes));
            calendar.WeekDays.Add(new WeekDay(DayType.Saturday));
            calendar.WeekDays.Add(new WeekDay(DayType.Sunday));

            return calendar;
        }

        // ExEnd
        [Test]
        public void WorkingTimeEquals()
        {
            // ExStart
            // ExFor: WorkingTime.Equals(Object)
            // ExFor: WorkingTime.#ctor(Int32,Int32)
            // ExSummary: Shows how to check working time equality.
            var workingTime1 = new WorkingTime(9, 12);
            var workingTime2 = new WorkingTime(13, 17);

            // the equality of calendars is checked against to working time's from and to dates.
            Console.WriteLine("Working Time 1 (From): " + workingTime1.From);
            Console.WriteLine("Working Time 1 (To): " + workingTime1.To);

            Console.WriteLine("Working Time 2 (From): " + workingTime2.From);
            Console.WriteLine("Working Time 2 (To): " + workingTime2.To);
            Console.WriteLine("Are working times equal: " + workingTime1.Equals(workingTime2));

            // ExEnd
        }
    }
}