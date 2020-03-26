namespace Aspose.Tasks.Examples.CSharp.WorkingWithCalendarExceptions
{
    using System;

    internal class DefineWeekdayExceptions
    {
        public static void Run()
        {
            var dataDir = RunExamples.GetDataDir(System.Reflection.MethodBase.GetCurrentMethod());
            
            //ExStart:DefineWeekdayExceptions
            //ExFor: CalendarException
            //ExSummary: Shows how to add typed calendar exceptions.
            var prj = new Project();

            // Define a calendar
            var cal = prj.Calendars.Add("Calendar1");

            // Define week days exception for a holiday
            var exception = new CalendarException();
            exception.EnteredByOccurrences = false;
            exception.FromDate = new DateTime(2009, 12, 24, 0, 0, 0);
            exception.ToDate = new DateTime(2009, 12, 31, 23, 59, 0);
            exception.Type = CalendarExceptionType.Daily;
            exception.DayWorking = false;
            cal.Exceptions.Add(exception);

            // Save the Project
            prj.Save(dataDir + "Project_DefineWeekDayException_out.xml", Saving.SaveFileFormat.XML);
            //ExEnd:DefineWeekdayExceptions
        }
    }
}
