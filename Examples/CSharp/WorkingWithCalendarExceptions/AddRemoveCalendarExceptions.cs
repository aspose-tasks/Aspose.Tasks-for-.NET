namespace Aspose.Tasks.Examples.CSharp.WorkingWithCalendarExceptions
{
    using System;

    internal class AddRemoveCalendarExceptions
    {
        public static void Run()
        {
            var dataDir = RunExamples.GetDataDir(System.Reflection.MethodBase.GetCurrentMethod().DeclaringType.FullName);
            
            //ExStart:AddRemoveCalendarExceptions
            //ExFor: CalendarException
            //ExFor: Calendar.Exceptions
            //ExSummary: Shows how to add/remove calendar exceptions. 
            var project = new Project(dataDir + "project_test.mpp");

            // Remove an exception
            var calendar = project.Calendars.ToList()[0];
            if (calendar.Exceptions.Count > 1)
            {
                var exception = calendar.Exceptions.ToList()[0];
                calendar.Exceptions.Remove(exception);
            }

            // Add an exception
            var calendarException = new CalendarException();
            calendarException.FromDate = new System.DateTime(2009, 1, 1);
            calendarException.ToDate = new System.DateTime(2009, 1, 3);
            calendar.Exceptions.Add(calendarException);

            // Display exceptions
            foreach (var exception in calendar.Exceptions)
            {
                Console.WriteLine("From" + exception.FromDate.ToShortDateString());
                Console.WriteLine("To" + exception.ToDate.ToShortDateString());
            }

            //ExEnd:AddRemoveCalendarExceptions
        }
    }
}
