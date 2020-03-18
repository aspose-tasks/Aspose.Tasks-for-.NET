namespace Aspose.Tasks.Examples.CSharp.WorkingWithCalendarExceptions
{
    using System;

    internal class RetrieveCalendarExceptions
    {
        public static void Run()
        {
            //ExStart:RetrieveCalendarExceptions
            var dataDir = RunExamples.GetDataDir(System.Reflection.MethodBase.GetCurrentMethod().DeclaringType.FullName);

            // Create project instance
            var project = new Project(dataDir + "project_RetrieveExceptions_test.mpp");

            // Access calendars
            foreach (var cal in project.Calendars)
            {
                // Access calendar exceptions
                foreach (var calExc in cal.Exceptions)
                {
                    Console.WriteLine("From: " + calExc.FromDate.ToShortDateString());
                    Console.WriteLine("To: " + calExc.ToDate.ToShortDateString());
                }
            }
            //ExEnd:RetrieveCalendarExceptions
        }
    }
}
