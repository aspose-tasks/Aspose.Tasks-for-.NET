using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Aspose.Tasks.Examples.CSharp.WorkingWithCalendarExceptions
{
    class DefineWeekdayExceptions
    {
        public static void Run()
        {
            // ExStart:DefineWeekdayExceptions
            string dataDir = RunExamples.GetDataDir(System.Reflection.MethodBase.GetCurrentMethod().DeclaringType.FullName);

            // Create a project instance
            Project prj = new Project();

            // Define Calendar
            Aspose.Tasks.Calendar cal = prj.Calendars.Add("Calendar1");

            // Define week days exception for a holiday
            CalendarException except = new CalendarException();
            except.EnteredByOccurrences = false;
            except.FromDate = new DateTime(2009, 12, 24, 0, 0, 0);
            except.ToDate = new DateTime(2009, 12, 31, 23, 59, 0);
            except.Type = CalendarExceptionType.Daily;
            except.DayWorking = false;
            cal.Exceptions.Add(except);

            // Save the Project
            prj.Save(dataDir + "Project_DefineWeekDayException_out.xml", Aspose.Tasks.Saving.SaveFileFormat.XML);
            // ExEnd:DefineWeekdayExceptions

        }
    }
}
