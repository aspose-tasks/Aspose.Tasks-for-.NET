namespace Aspose.Tasks.Examples.CSharp
{
    using System;
    using System.Collections.Generic;
    using NUnit.Framework;

    [TestFixture]
    public class ExWorkingTime : ApiExampleBase
    {
        //ExStart
        //ExFor: WorkingTime
        //ExFor: WorkingTime.#ctor
        //ExFor: WorkingTime.#ctor(System.DateTime,System.DateTime)
        //ExFor: WorkingTime.FromTime
        //ExFor: WorkingTime.ToTime
        //ExSummary: Shows how to work with working time information.
        [Test]//ExSkip
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
                    Console.WriteLine(workingTime.FromTime);
                    Console.WriteLine(workingTime.ToTime);
                }
            }
        }
        
        private Calendar CreateCalendar(Project project)
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
        //ExEnd
        
        [Test]
        public void WorkingTimeEquals()
        {
            //ExStart
            //ExFor: WorkingTime.Equals(Object)
            //ExSummary: Shows how to check working time equality.
            var workingTime1 = new WorkingTime(new DateTime(1, 1, 1, 9, 0, 0), new DateTime(1, 1, 1, 12, 0, 0));
            var workingTime2 = new WorkingTime(new DateTime(1, 1, 1, 13, 0, 0), new DateTime(1, 1, 1, 17, 0, 0));

            // the equality of calendars is checked against to working time's from and to dates.
            Console.WriteLine("Working Time 1 (From): " + workingTime1.FromTime);
            Console.WriteLine("Working Time 1 (To): " + workingTime1.ToTime);
            
            Console.WriteLine("Working Time 2 (From): " + workingTime2.FromTime);
            Console.WriteLine("Working Time 2 (To): " + workingTime2.ToTime);
            Console.WriteLine("Are working times equal: " + workingTime1.Equals(workingTime2));
            //ExEnd
        }
        
        [Test]
        public void GetWorkingTimeHashCode()
        {
            //ExStart
            //ExFor: WorkingTime.GetHashCode
            //ExSummary: Shows how to get a hash code of a working time.
            var workingTime1 = new WorkingTime(new DateTime(1, 1, 1, 9, 0, 0), new DateTime(1, 1, 1, 12, 0, 0));
            var workingTime2 = new WorkingTime(new DateTime(1, 1, 1, 13, 0, 0), new DateTime(1, 1, 1, 17, 0, 0));

            // the hash code of a working time is based on from and to dates
            Console.WriteLine("Working Time 1 (From): " + workingTime1.FromTime);
            Console.WriteLine("Working Time 1 (To): " + workingTime1.ToTime);
            
            Console.WriteLine("Working Time 2 (From): " + workingTime2.FromTime);
            Console.WriteLine("Working Time 2 (To): " + workingTime2.ToTime);

            Console.WriteLine();
            
            // the hash code of a calendar is equal to calendar UID 
            Console.WriteLine("Hash Code of working time 1: {0}", workingTime1.GetHashCode());
            Console.WriteLine("Hash Code of working time 2: {0}", workingTime2.GetHashCode());
            
            //ExEnd
        }
    }
}