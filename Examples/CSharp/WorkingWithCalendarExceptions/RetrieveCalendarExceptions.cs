using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Aspose.Tasks.Examples.CSharp.WorkingWithCalendarExceptions
{
    class RetrieveCalendarExceptions
    {
        public static void Run()
        {
            // ExStart:RetrieveCalendarExceptions
            string dataDir = RunExamples.GetDataDir(System.Reflection.MethodBase.GetCurrentMethod().DeclaringType);

            // Create project instance
            Project prj = new Project(dataDir + "project_test.mpp");

            // Access calendars
            foreach (Aspose.Tasks.Calendar cal in prj.Calendars)
            {
                // Access calendar exceptions
                foreach (CalendarException calExc in cal.Exceptions)
                {
                    Console.WriteLine("From: " + calExc.FromDate.ToShortDateString());
                    Console.WriteLine("To: " + calExc.ToDate.ToShortDateString());
                }
            }
            // ExEnd:RetrieveCalendarExceptions
        }
    }
}
