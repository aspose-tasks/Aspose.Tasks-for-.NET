namespace Aspose.Tasks.Examples.CSharp
{
    using System;
    using NUnit.Framework;

    [TestFixture]
    public class ExCalendarException : ApiExampleBase
    {
        [Test]
        public void ExceptionDelete()
        {
            // ExStart
            // ExFor: CalendarException.Delete
            // ExSummary: Shows how to delete a calendar exception.
            var project = new Project(DataDir + "CalendarExceptions.mpp");

            var calendar = project.Calendars.ToList()[0];

            Console.WriteLine("Calendar Name: " + calendar.Name);
            Console.WriteLine("Calendar Exception Count: " + calendar.Exceptions.Count);

            // remove the exception
            calendar.Exceptions.ToList()[0].Delete();

            Console.WriteLine("Calendar Exception Count: " + calendar.Exceptions.Count);

            // ExEnd
        }

        [Test]
        public void ExceptionGetWorkingTime()
        {
            // ExStart
            // ExFor: CalendarException.GetWorkingTime
            // ExFor: CalendarException.WorkingTimes
            // ExSummary: Shows how to get a working time of a calendar exception.
            var project = new Project(DataDir + "CalendarExceptions.mpp");

            var calendar = project.Calendars.ToList()[0];
            var exception = calendar.Exceptions.ToList()[0];

            Console.WriteLine("Calendar Name: " + calendar.Name);
            Console.WriteLine("Calendar Exception Count: " + calendar.Exceptions.Count);
            Console.WriteLine("Calendar Exception Name: " + exception.Name);
            Console.WriteLine();

            var workingTime = exception.GetWorkingTime();
            Console.WriteLine("Exception Working Time: " + workingTime);

            foreach (var time in exception.WorkingTimes)
            {
                Console.WriteLine("Working Time Start: " + time.FromTime);
                Console.WriteLine("Working Time Finish: " + time.ToTime);
            }

            // ExEnd
            Assert.AreEqual(4, workingTime.TotalHours);
        }

        [Test]
        public void DefineCalendarExceptions()
        {
            // ExStart:DefineCalendarExceptions
            // ExFor: CalendarException
            // ExFor: CalendarException.#ctor
            // ExFor: CalendarException.FromDate
            // ExFor: CalendarException.ToDate
            // ExFor: CalendarException.Type
            // ExFor: CalendarException.DayWorking
            // ExFor: CalendarException.Name
            // ExFor: CalendarException.CheckException(DateTime)
            // ExSummary: Shows how to add/remove calendar exceptions.
            var project = new Project(DataDir + "project_test.mpp");

            // create a calendar
            var calendar = project.Calendars.Add("Calendar1");

            // create week days exception for a holiday
            var exception = new CalendarException();
            exception.Name = "New Calendar Exception";
            exception.EnteredByOccurrences = false;
            exception.FromDate = new DateTime(2009, 12, 24, 0, 0, 0);
            exception.ToDate = new DateTime(2009, 12, 31, 23, 59, 0);
            exception.Type = CalendarExceptionType.Daily;
            exception.Month = Month.December;

            exception.DayWorking = false;

            // check that date is exceptional
            Console.WriteLine("Is date an exception date: " + exception.CheckException(new DateTime(2009, 12, 26, 8, 0, 0)));

            calendar.Exceptions.Add(exception);

            // remove an exception
            var cal = project.Calendars.ToList()[0];
            if (cal.Exceptions.Count > 1)
            {
                var excToRemove = cal.Exceptions.ToList()[0];
                cal.Exceptions.Remove(excToRemove);
            }

            // add an exception
            var exception2 = new CalendarException();
            exception2.FromDate = new System.DateTime(2009, 1, 1);
            exception2.ToDate = new System.DateTime(2009, 1, 3);
            cal.Exceptions.Add(exception2);

            // print exceptions
            foreach (var exc in cal.Exceptions)
            {
                Console.WriteLine("Name: " + exc.Name);
                Console.WriteLine("From: " + exc.FromDate.ToShortDateString());
                Console.WriteLine("To: " + exc.ToDate.ToShortDateString());
                Console.WriteLine("Parent Calendar Name: " + exc.ParentCalendar.Name);
            }

            // ExEnd:DefineCalendarExceptions
        }

        [Test]
        public void ExceptionByDayType()
        {
            // ExStart
            // ExFor: CalendarException.DaysOfWeek
            // ExFor: CalendarException.ParentCalendar
            // ExSummary: Shows how to define calendar exception by week day.
            var project = new Project(DataDir + "project_test.mpp");

            // create a calendar
            var calendar = project.Calendars.Add("Calendar1");

            // create calendar exception for every friday
            var exception = new CalendarException();
            exception.Type = CalendarExceptionType.Weekly;
            exception.FromDate = new DateTime(2020, 4, 6);
            exception.ToDate = new DateTime(2020, 4, 12);
            exception.DaysOfWeek.Add(DayType.Friday);

            // check that aa friday is exceptional
            Console.WriteLine("Is date an exception date: " + exception.CheckException(new DateTime(2020, 4, 10)));

            // add the exception to the calendar
            calendar.Exceptions.Add(exception);

            Console.WriteLine("Parent calendar name: " + exception.ParentCalendar.Name);

            // ExEnd
            Assert.IsTrue(exception.CheckException(new DateTime(2020, 4, 10)));
        }

        [Test]
        public void ExceptionByMonth()
        {
            // ExStart
            // ExFor: CalendarException.Month
            // ExFor: CalendarException.MonthDay
            // ExFor: CalendarException.MonthItem
            // ExFor: CalendarException.MonthPosition
            // ExFor: CalendarException.Period
            // ExFor: MonthItemType
            // ExFor: MonthPosition
            // ExSummary: Shows how to define calendar exception by month day.
            var project = new Project(DataDir + "project_test.mpp");

            // create a calendar
            var calendar = project.Calendars.Add("Calendar1");

            // create calendar exception for every friday
            var exception = new CalendarException();
            exception.Type = CalendarExceptionType.MonthlyByDay;
            exception.FromDate = new DateTime(2010, 1, 1);
            exception.ToDate = new DateTime(2020, 12, 31);
            exception.Month = Month.December;
            exception.MonthDay = 1;
            exception.MonthItem = MonthItemType.Undefined;
            exception.MonthPosition = MonthPosition.Last;
            exception.Period = 5;

            // check that aa friday is exceptional
            Console.WriteLine("Is date an exception date: " + exception.CheckException(new DateTime(2012, 12, 1)));

            // add the exception to the calendar
            calendar.Exceptions.Add(exception);

            // ExEnd
            Assert.IsTrue(exception.CheckException(new DateTime(2012, 12, 1)));
        }

        [Test]
        public void HandleExceptionOccurrences()
        {
            // ExStart:HandleExceptionOccurrences
            // ExFor: CalendarExceptionType
            // ExFor: CalendarException.EnteredByOccurrences
            // ExFor: CalendarException.Occurrences
            // ExSummary: Shows how to define a calendar exception by occurrences.
            var project = new Project();

            // Define a calendar
            var calendar = project.Calendars.Add("Calendar1");

            // Define exception and specify occurrences
            var exception = new CalendarException();
            exception.EnteredByOccurrences = true;
            exception.Occurrences = 5;
            exception.Type = CalendarExceptionType.YearlyByDay;
            exception.MonthDay = 22;
            exception.Month = Month.April;

            // Add exception to calendar
            calendar.Exceptions.Add(exception);

            // ExEnd:HandleExceptionOccurrences
        }
    }
}