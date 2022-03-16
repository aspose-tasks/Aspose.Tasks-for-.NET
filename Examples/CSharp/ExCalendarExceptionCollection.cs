namespace Aspose.Tasks.Examples.CSharp
{
    using System;
    using System.Collections.Generic;
    using NUnit.Framework;

    [TestFixture]
    public class ExCalendarExceptionCollection : ApiExampleBase
    {
        [Test]
        public void WorkWithCalendarExceptionCollection()
        {
            // ExStart:UseCalendarExceptionCollection
            // ExFor: CalendarExceptionCollection
            // ExFor: CalendarExceptionCollection.Add(CalendarException)
            // ExFor: CalendarExceptionCollection.AddRange(IEnumerable{Aspose.Tasks.CalendarException})
            // ExFor: CalendarExceptionCollection.Clear
            // ExFor: CalendarExceptionCollection.Count
            // ExFor: CalendarExceptionCollection.GetEnumerator
            // ExFor: CalendarExceptionCollection.ParentCalendar
            // ExFor: CalendarExceptionCollection.Remove(CalendarException)
            // ExFor: CalendarExceptionCollection.ToList
            // ExSummary: Shows how to use calendar exception collection to define calendar exceptions.
            var project = new Project(DataDir + "project_update_test.mpp");
            var calendar = project.Calendars.GetByUid(3);

            calendar.Exceptions.Clear();
            Calendar.MakeStandardCalendar(calendar);

            var exception = new CalendarException();
            exception.FromDate = new DateTime(2020, 3, 30, 8, 0, 0);
            exception.ToDate = new DateTime(2020, 4, 3, 17, 0, 0);
            exception.DayWorking = true;
            exception.Name = "Exception 1";

            var wt1 = new WorkingTime(9, 13);
            var wt2 = new WorkingTime(14, 19);

            exception.WorkingTimes.Add(wt1);
            exception.WorkingTimes.Add(wt2);
            calendar.Exceptions.Add(exception);

            var nonWorkingExceptions = new CalendarException[2];
            nonWorkingExceptions[0] = new CalendarException();
            nonWorkingExceptions[0].FromDate = new DateTime(2020, 4, 13, 8, 0, 0);
            nonWorkingExceptions[0].ToDate = new DateTime(2020, 4, 18, 17, 0, 0);
            nonWorkingExceptions[0].DayWorking = false;
            nonWorkingExceptions[0].Name = "Exception 2";
            nonWorkingExceptions[1] = new CalendarException();
            nonWorkingExceptions[1].FromDate = new DateTime(2020, 4, 6, 8, 0, 0);
            nonWorkingExceptions[1].ToDate = new DateTime(2020, 4, 10, 17, 0, 0);
            nonWorkingExceptions[1].DayWorking = false;
            nonWorkingExceptions[1].Name = "Exception 3";
            calendar.Exceptions.AddRange(nonWorkingExceptions);

            Console.WriteLine("Exceptions of calendar {0}: ", calendar.Exceptions.ParentCalendar.Name);
            Console.WriteLine("Exceptions count: {0}", calendar.Exceptions.Count);
            Console.WriteLine();
            foreach (var calendarException in calendar.Exceptions)
            {
                Console.WriteLine("Name: " + calendarException.Name);
                Console.WriteLine("From Date: " + calendarException.FromDate);
                Console.WriteLine("To Date: " + calendarException.ToDate);
                Console.WriteLine("Is day working: " + calendarException.DayWorking);
                Console.WriteLine();
            }

            // remove all exceptions
            Console.WriteLine("Remove calendar exceptions...");
            List<CalendarException> exceptions = calendar.Exceptions.ToList();
            foreach (var calendarException in exceptions)
            {
                Console.WriteLine("Remove exception: " + calendarException.Name);
                Console.WriteLine();
                calendar.Exceptions.Remove(calendarException);
            }

            // ExEnd:UseCalendarExceptionCollection
        }
    }
}