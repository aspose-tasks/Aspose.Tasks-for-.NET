namespace Aspose.Tasks.Examples.CSharp
{
    using System;
    using System.Collections.Generic;
    using NUnit.Framework;

    [TestFixture]
    public class ExWeekDay : ApiExampleBase
    {
        [Test]
        public void WeekDayClone()
        {
            // ExStart
            // ExFor: WeekDay.Clone
            // ExSummary: Shows how to clone a week day.
            var project = new Project(DataDir + "Project2.mpp");

            var calendar = project.Calendars.GetByUid(1);
            var weekDay1 = calendar.WeekDays[0];
            
            // create a deep copy week day
            var weekDay2 = weekDay1.Clone();

            // the equality of calendars is checked against to weekday's properties:
            // weekday.DayType
            // weekday.DayWorking
            // weekday.FromDate
            // weekday.ToDate
            // weekday.WorkingTimes
            Console.WriteLine("WeekDay 1 Day Type: " + weekDay1.DayType);
            Console.WriteLine("WeekDay 1 Day Working: " + weekDay1.DayWorking);
            Console.WriteLine("WeekDay 1 From Date: " + weekDay1.FromDate);
            Console.WriteLine("WeekDay 1 From Date: " + weekDay1.ToDate);
            Console.WriteLine("WeekDay 1 WorkingTimes: " + weekDay1.WorkingTimes);
            Console.WriteLine("WeekDay 2 Day Type: " + weekDay2.DayType);
            Console.WriteLine("WeekDay 2 Day Working: " + weekDay2.DayWorking);
            Console.WriteLine("WeekDay 2 From Date: " + weekDay2.FromDate);
            Console.WriteLine("WeekDay 2 From Date: " + weekDay2.ToDate);
            Console.WriteLine("WeekDay 2 WorkingTimes: " + weekDay2.WorkingTimes);
            Console.WriteLine("Are weekdays equal: " + weekDay1.Equals(weekDay2));
            Console.WriteLine("Are weekdays equal (by reference): " + ReferenceEquals(weekDay1, weekDay2));

            // ExEnd
        }

        [Test]
        public void WorkWithWeekDay()
        {
            // ExStart
            // ExFor: WeekDay
            // ExFor: WeekDay.#ctor
            // ExFor: WeekDay.#ctor(DayType)
            // ExFor: WeekDay.#ctor(DayType,IEnumerable{Aspose.Tasks.WorkingTime})
            // ExFor: WeekDay.CreateDefaultWorkingDay(DayType)
            // ExFor: WeekDay.WorkingTimes
            // ExFor: WeekDay.GetWorkingTime()
            // ExFor: WeekDay.DayWorking
            // ExFor: WeekDay.CastToDayType(DayOfWeek)
            // ExFor: WeekDay.DayType
            // ExFor: WeekDay.FromDate
            // ExFor: WeekDay.ToDate
            // ExSummary: Shows how to create a new calendar by defining of week days. 
            var project = new Project();

            // Define a calendar
            var calendar = project.Calendars.Add("Calendar1");

            // Add working days monday through thursday with default timings
            calendar.WeekDays.Add(WeekDay.CreateDefaultWorkingDay(DayType.Monday));
            calendar.WeekDays.Add(new WeekDay(DayType.Tuesday, new WorkingTime(9, 11), new WorkingTime(12, 18)));
            calendar.WeekDays.Add(WeekDay.CreateDefaultWorkingDay(DayType.Wednesday));
            calendar.WeekDays.Add(WeekDay.CreateDefaultWorkingDay(DayType.Thursday));

            var exceptionDay = WeekDay.CreateDefaultWorkingDay(DayType.Exception);
            exceptionDay.FromDate = new DateTime(2020, 4, 27, 0, 0, 0);
            exceptionDay.ToDate = new DateTime(2020, 4, 30, 0, 0, 0);
            exceptionDay.DayWorking = false;
            calendar.WeekDays.Add(exceptionDay);
            
            // check from and to dates of the exception day
            Console.WriteLine("The from date is: " + exceptionDay.FromDate);
            Console.WriteLine("The to date is: " + exceptionDay.ToDate);
            Console.WriteLine();
            
            calendar.WeekDays.Add(new WeekDay(DayType.Saturday));
            calendar.WeekDays.Add(new WeekDay(DayType.Sunday));

            // Set friday as short working day

            // Sets working time. 
            var workingTimes = new List<WorkingTime> { new WorkingTime(9, 12), new WorkingTime(13, 16) };
            
            // there is a way to convert <see cref="DayOfWeek" /> to <see cref="Aspose.Tasks.DayType" />.
            var dayType = WeekDay.CastToDayType(DayOfWeek.Friday);
            
            var weekDay = new WeekDay(dayType, workingTimes);
            weekDay.DayWorking = true;
            Console.WriteLine("The day type is: " + weekDay.DayType);
            Console.WriteLine("The from date is: " + weekDay.FromDate);
            Console.WriteLine("The to date is: " + weekDay.ToDate);
            
            calendar.WeekDays.Add(weekDay);
            
            // lets print all working times
            foreach (var day in calendar.WeekDays)
            {
                Console.WriteLine("Day Type: " + day.DayType); 
                Console.WriteLine("Is working day: " + day.DayWorking); 
                Console.WriteLine("Working Time (Hours): " + day.GetWorkingTime().TotalHours);
                Console.WriteLine();
            }

            // ExEnd
        }
        
        [Test]
        public void WorkWithSetDefaultWorkingTime()
        {
            // ExStart
            // ExFor: WeekDay.SetDefaultWorkingTime(WeekDay)
            // ExSummary: Shows how to set a default working time for a day. 
            var project = new Project();

            // Define a calendar
            var calendar = project.Calendars.Add("Calendar1");
            calendar.WeekDays.Clear();

            // Add working days monday through thursday with default timings
            var monday = new WeekDay(DayType.Monday);
            WeekDay.SetDefaultWorkingTime(monday);
            calendar.WeekDays.Add(monday);
            var tuesday = new WeekDay(DayType.Tuesday);
            WeekDay.SetDefaultWorkingTime(tuesday);
            calendar.WeekDays.Add(tuesday);
            var wednesday = new WeekDay(DayType.Wednesday);
            WeekDay.SetDefaultWorkingTime(wednesday);
            calendar.WeekDays.Add(wednesday);
            var thursday = new WeekDay(DayType.Thursday);
            WeekDay.SetDefaultWorkingTime(thursday);
            calendar.WeekDays.Add(thursday);
            var friday = new WeekDay(DayType.Friday);
            WeekDay.SetDefaultWorkingTime(friday);
            calendar.WeekDays.Add(friday);
            
            var saturday = new WeekDay(DayType.Saturday);
            saturday.DayWorking = false;
            calendar.WeekDays.Add(saturday);
            var sunday = new WeekDay(DayType.Sunday);
            sunday.DayWorking = false;
            calendar.WeekDays.Add(sunday);

            // lets print all working times
            foreach (var day in calendar.WeekDays)
            {
                Console.WriteLine("Day Type: " + day.DayType); 
                Console.WriteLine("Is working day: " + day.DayWorking); 
                Console.WriteLine("Working Time (Hours): " + day.GetWorkingTime().TotalHours);
                Console.WriteLine();
            }

            // ExEnd
        }
    }
}