using System;

namespace Aspose.Tasks.Examples.CSharp.WorkingWithCalendarExceptions
{
    class RetrieveCalendarExceptions
    {
        public static void Run()
        {
            //ExStart:RetrieveCalendarExceptions
            string dataDir = RunExamples.GetDataDir(System.Reflection.MethodBase.GetCurrentMethod().DeclaringType.FullName);

            // Create project instance
            Project project1 = new Project(dataDir + "project_RetrieveExceptions_test.mpp");

            // Access calendars
            foreach (Aspose.Tasks.Calendar cal in project1.Calendars)
            {
                // Access calendar exceptions
                foreach (CalendarException calExc in cal.Exceptions)
                {
                    Console.WriteLine("From: " + calExc.FromDate.ToShortDateString());
                    Console.WriteLine("To: " + calExc.ToDate.ToShortDateString());
                }
            }
            //ExEnd:RetrieveCalendarExceptions
        }
    }
}
