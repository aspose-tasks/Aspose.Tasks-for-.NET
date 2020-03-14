namespace Aspose.Tasks.Examples.CSharp.WorkingWithCalendarExceptions
{
    class HandleExceptionOccurrences
    {
        public static void Run()
        {            
            string dataDir = RunExamples.GetDataDir(System.Reflection.MethodBase.GetCurrentMethod().DeclaringType.FullName);

            // Create a project instance
            Project project = new Project();

            // Define Calendar
            var cal = project.Calendars.Add("Calendar1");

            //ExStart:HandleExceptionOccurences
            // Define exception and specify occurences
            CalendarException except = new CalendarException();
            except.EnteredByOccurrences = true;
            except.Occurrences = 5;
            except.Type = CalendarExceptionType.YearlyByDay;
            //ExEnd:HandleExceptionOccurences

            // Add exception to calendar and save the Project
            cal.Exceptions.Add(except);
            project.Save(dataDir + "Project_HandleExceptionOccurrences_out.xml", Saving.SaveFileFormat.XML);
        }
    }
}
