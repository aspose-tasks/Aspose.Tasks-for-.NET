using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Aspose.Tasks.Examples.CSharp.WorkingWithCalendarExceptions
{
    class HandleExceptionOccurences
    {
        public static void Run()
        {            
            string dataDir = RunExamples.GetDataDir(System.Reflection.MethodBase.GetCurrentMethod().DeclaringType.FullName);

            // Create a project instance
            Project project1 = new Project();

            // Define Calendar
            Aspose.Tasks.Calendar cal = project1.Calendars.Add("Calendar1");

            // ExStart:HandleExceptionOccurences
            // Define exception and specify occurences
            CalendarException except = new CalendarException();
            except.EnteredByOccurrences = true;
            except.Occurrences = 5;
            except.Type = CalendarExceptionType.YearlyByDay;
            // ExEnd:HandleExceptionOccurences

            // Add exception to calendar and save the Project
            cal.Exceptions.Add(except);
            project1.Save(dataDir + "Project_HandleExceptionOccurences_out.xml", Aspose.Tasks.Saving.SaveFileFormat.XML);
        }
    }
}
