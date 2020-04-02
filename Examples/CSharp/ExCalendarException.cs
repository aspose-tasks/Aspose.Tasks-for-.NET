namespace Aspose.Tasks.Examples.CSharp
{
    using System;
    using NUnit.Framework;
    using Saving;

    [TestFixture]
    public class ExCalendarException : ApiExampleBase
    {
        [Test]
        public void DefineCalendarExceptions()
        {
            //ExStart:DefineCalendarExceptions
            //ExFor: CalendarException
            //ExFor: CalendarException.#ctor
            //ExFor: CalendarException.FromDate
            //ExFor: CalendarException.ToDate
            //ExFor: CalendarException.Type
            //ExFor: CalendarException.DayWorking
            //ExSummary: Shows how to add/remove calendar exceptions.
            var project = new Project(DataDir + "project_test.mpp");

            // create a calendar
            var calendar = project.Calendars.Add("Calendar1");

            // create week days exception for a holiday
            var newException = new CalendarException();
            newException.EnteredByOccurrences = false;
            newException.FromDate = new DateTime(2009, 12, 24, 0, 0, 0);
            newException.ToDate = new DateTime(2009, 12, 31, 23, 59, 0);
            newException.Type = CalendarExceptionType.Daily;
            newException.DayWorking = false;
            calendar.Exceptions.Add(newException);
            
            // remove an exception
            var cal = project.Calendars.ToList()[0];
            if (cal.Exceptions.Count > 1)
            {
                var excToRemove = cal.Exceptions.ToList()[0];
                cal.Exceptions.Remove(excToRemove);
            }

            // add an exception
            var calendarException = new CalendarException();
            calendarException.FromDate = new System.DateTime(2009, 1, 1);
            calendarException.ToDate = new System.DateTime(2009, 1, 3);
            cal.Exceptions.Add(calendarException);

            // print exceptions
            foreach (var exception in cal.Exceptions)
            {
                Console.WriteLine("From" + exception.FromDate.ToShortDateString());
                Console.WriteLine("To" + exception.ToDate.ToShortDateString());
            }

            project.Save(OutDir + "DefineCalendarExceptions_out.xml", SaveFileFormat.XML);
            //ExEnd:DefineCalendarExceptions
        }
        
        [Test]
        public void HandleExceptionOccurrences()
        {            
            //ExStart:HandleExceptionOccurrences
            //ExFor: CalendarException.EnteredByOccurrences
            //ExFor: CalendarException.Occurrences
            //ExSummary: Shows how to define a calendar exception by occurrences.
            var project = new Project();
            
            // Define a calendar
            var calendar = project.Calendars.Add("Calendar1");
            
            // Define exception and specify occurrences
            var exception = new CalendarException();
            exception.EnteredByOccurrences = true;
            exception.Occurrences = 5;
            exception.Type = CalendarExceptionType.YearlyByDay;
            
            // Add exception to calendar and save the Project
            calendar.Exceptions.Add(exception);
            project.Save(OutDir + "HandleExceptionOccurrences_out.xml", SaveFileFormat.XML);
            //ExEnd:HandleExceptionOccurrences
        }
    }
}