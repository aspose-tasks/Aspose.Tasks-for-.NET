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
            string dataDir = RunExamples.GetDataDir(System.Reflection.MethodBase.GetCurrentMethod().DeclaringType);

            // Create a project instance
            Project prj = new Project();

            // Define Calendar
            Aspose.Tasks.Calendar cal = prj.Calendars.Add("Calendar1");

            // ExStart:HandleExceptionOccurences
            // Define week days exception for a holiday
            CalendarException except = new CalendarException();
            except.EnteredByOccurrences = true;
            except.Occurrences = 5;
            except.Type = CalendarExceptionType.YearlyByDay;
            // ExEnd:HandleExceptionOccurences

            // Add exception to calendar and save the Project
            cal.Exceptions.Add(except);
            prj.Save(dataDir + "Project_out.xml", Aspose.Tasks.Saving.SaveFileFormat.XML);
        }
    }
}
