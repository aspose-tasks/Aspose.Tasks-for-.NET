namespace Aspose.Tasks.Examples.CSharp.WorkingWithCalendarExceptions
{
    internal class HandleExceptionOccurrences
    {
        public static void Run()
        {            
            var dataDir = RunExamples.GetDataDir(System.Reflection.MethodBase.GetCurrentMethod());

            // Create a project instance
            var project = new Project();

            // Define a calendar
            var cal = project.Calendars.Add("Calendar1");

            //ExStart:HandleExceptionOccurrences
            //ExFor: CalendarException.EnteredByOccurrences
            //ExFor: CalendarException.Occurrences
            //ExFor: CalendarException.Type
            //ExSummary: Shows how to define a calendar exception by occurrences.
            // Define exception and specify occurrences
            var exception = new CalendarException();
            exception.EnteredByOccurrences = true;
            exception.Occurrences = 5;
            exception.Type = CalendarExceptionType.YearlyByDay;
            //ExEnd:HandleExceptionOccurrences

            // Add exception to calendar and save the Project
            cal.Exceptions.Add(exception);
            project.Save(dataDir + "Project_HandleExceptionOccurrences_out.xml", Saving.SaveFileFormat.XML);
        }
    }
}
