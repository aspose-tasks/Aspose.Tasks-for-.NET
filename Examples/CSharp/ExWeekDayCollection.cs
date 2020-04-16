namespace Aspose.Tasks.Examples.CSharp
{
    using System;
    using System.Collections.Generic;
    using NUnit.Framework;

    [TestFixture]
    public class ExWeekDayCollection : ApiExampleBase
    {
        [Test]
        public void CreateCustomizedWeekDayCollection()
        {
            //ExStart
            //ExFor: WeekDayCollection
            //ExFor: WeekDayCollection.Add(WeekDay)
            //ExFor: WeekDayCollection.Clear
            //ExFor: WeekDayCollection.Contains(WeekDay)
            //ExFor: WeekDayCollection.Insert(Int32,WeekDay)
            //ExFor: WeekDayCollection.Item(Int32)
            //ExFor: WeekDayCollection.Count
            //ExFor: WeekDayCollection.GetEnumerator
            //ExFor: WeekDayCollection.ParentCalendar
            //ExFor: WeekDayCollection.Remove(WeekDay)
            //ExFor: WeekDayCollection.RemoveAt(Int32)
            //ExFor: WeekDayCollection.ToList
            //ExFor: WeekDayCollection.IndexOf(WeekDay)
            //ExFor: WeekDayCollection.CopyTo(WeekDay[],Int32)
            //ExSummary: Shows how to work week day collections.
            var project = new Project();
            var calendar = project.Calendars.GetByName("Standard");

            // clear week days
            calendar.WeekDays.Clear();

            calendar.WeekDays.Add(WeekDay.CreateDefaultWorkingDay(DayType.Monday));
            calendar.WeekDays.Add(WeekDay.CreateDefaultWorkingDay(DayType.Tuesday));
            calendar.WeekDays.Add(WeekDay.CreateDefaultWorkingDay(DayType.Wednesday));
            calendar.WeekDays.Add(WeekDay.CreateDefaultWorkingDay(DayType.Thursday));
            calendar.WeekDays.Add(WeekDay.CreateDefaultWorkingDay(DayType.Friday));
            var saturday = WeekDay.CreateDefaultWorkingDay(DayType.Saturday);
            var sunday = WeekDay.CreateDefaultWorkingDay(DayType.Sunday);
            
            calendar.WeekDays.Add(saturday);
            calendar.WeekDays.Add(sunday);

            var fridayWorkingTimes = new List<WorkingTime>
            {
                new WorkingTime(new DateTime(2020, 4, 13, 8, 0, 0), new DateTime(2020, 4, 13, 12, 0, 0))
            };
            
            var friday = new WeekDay(DayType.Friday, fridayWorkingTimes);
            if (calendar.WeekDays.Contains(friday))
            {
                calendar.WeekDays.Insert(4, friday);
            }

            Console.WriteLine("Calendar: " + calendar.WeekDays.ParentCalendar.Name);
            Console.WriteLine("Week days count: " + calendar.WeekDays.Count);
            foreach (var day in calendar.WeekDays)
            {
                Console.WriteLine(day.DayType);
                foreach (var workingTime in day.WorkingTimes)
                {
                    Console.WriteLine("From: " + workingTime.FromTime);
                    Console.WriteLine("To: " + workingTime.ToTime);
                    Console.WriteLine();
                }
            }
            
            // remove saturday week day
            calendar.WeekDays.RemoveAt(5);
            
            // remove sunday week day
            if (calendar.WeekDays.IndexOf(saturday) > 0)
            {
                calendar.WeekDays.Remove(sunday);
            }

            Console.WriteLine("Working times after weekend was removed: ");
            List<WeekDay> weekDays = calendar.WeekDays.ToList();
            foreach (var day in weekDays)
            {
                Console.WriteLine(day.DayType);
                foreach (var workingTime in day.WorkingTimes)
                {
                    Console.WriteLine("From: " + workingTime.FromTime);
                    Console.WriteLine("To: " + workingTime.ToTime);
                    Console.WriteLine();
                }
            }
            
            var hour24Calendar = project.Calendars.Add("24 Hours");
            Calendar.Make24HourCalendar(hour24Calendar);
            
            // copy week days
            var weekDaysArray = new WeekDay[calendar.WeekDays.Count];
            calendar.WeekDays.CopyTo(weekDaysArray, 0);
            
            foreach (var weekDay in weekDaysArray)
            {
                hour24Calendar.WeekDays.Add(weekDay);
            }
            //ExEnd
        }
    }
}