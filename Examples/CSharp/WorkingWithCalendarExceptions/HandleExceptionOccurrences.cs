namespace Aspose.Tasks.Examples.CSharp.WorkingWithCalendarExceptions
{
    internal class HandleExceptionOccurrences
    {
        public static void Run()
        {            
            var dataDir = RunExamples.GetDataDir(System.Reflection.MethodBase.GetCurrentMethod().DeclaringType.FullName);

            // Create a project instance
            var project = new Project();

            // Define Calendar
            var cal = project.Calendars.Add("Calendar1");

            //ExStart:HandleExceptionOccurrences
            // Define exception and specify occurrences
            var except = new CalendarException();
            except.EnteredByOccurrences = true;
            except.Occurrences = 5;
            except.Type = CalendarExceptionType.YearlyByDay;
            //ExEnd:HandleExceptionOccurrences

            // Add exception to calendar and save the Project
            cal.Exceptions.Add(except);
            project.Save(dataDir + "Project_HandleExceptionOccurrences_out.xml", Saving.SaveFileFormat.XML);
        }
    }
}
