namespace Aspose.Tasks.Examples.CSharp
{
    using System;
    using NUnit.Framework;
    using Saving;

    [TestFixture]
    public class ExWeekDay : ApiExampleBase
    {
        [Test]
        public void DefineWeekdaysForCalendar()
        {
            //ExStart
            //ExFor: WeekDay
            //ExFor: WeekDay.#ctor(DayType)
            //ExFor: WeekDay.CreateDefaultWorkingDay(DayType)
            //ExFor: WeekDay.WorkingTimes
            //ExFor: WeekDay.DayWorking
            //ExSummary: Shows how to create a new calendar by defining of week days. 
            var project = new Project();

            // Define a calendar
            var calendar = project.Calendars.Add("Calendar1");

            // Add working days monday through thursday with default timings
            calendar.WeekDays.Add(WeekDay.CreateDefaultWorkingDay(DayType.Monday));
            calendar.WeekDays.Add(WeekDay.CreateDefaultWorkingDay(DayType.Tuesday));
            calendar.WeekDays.Add(WeekDay.CreateDefaultWorkingDay(DayType.Wednesday));
            calendar.WeekDays.Add(WeekDay.CreateDefaultWorkingDay(DayType.Thursday));
            calendar.WeekDays.Add(new WeekDay(DayType.Saturday));
            calendar.WeekDays.Add(new WeekDay(DayType.Sunday));

            // Set friday as short working day
            var weekDay = new WeekDay(DayType.Friday);

            // Sets working time. Only time part of DateTime is important
            var workingTime = new WorkingTime();
            workingTime.FromTime = new DateTime(1, 1, 1, 9, 0, 0, 0);
            workingTime.ToTime = new DateTime(1, 1, 1, 12, 0, 0, 0);
            var workingTime2 = new WorkingTime();
            workingTime2.FromTime = new DateTime(1, 1, 1, 13, 0, 0, 0);
            workingTime2.ToTime = new DateTime(1, 1, 1, 16, 0, 0, 0);
            weekDay.WorkingTimes.Add(workingTime);
            weekDay.WorkingTimes.Add(workingTime2);
            weekDay.DayWorking = true;
            calendar.WeekDays.Add(weekDay);
            //ExEnd
            
            project.Save(OutDir + "DefineCalendarWeekdays_out.xml", SaveFileFormat.XML);
        }
    }
}