namespace Aspose.Tasks.Examples.CSharp.WorkingWithCalendarExceptions
{
    using System;

    internal class RetrieveCalendarExceptions
    {
        public static void Run()
        {
            var dataDir = RunExamples.GetDataDir(System.Reflection.MethodBase.GetCurrentMethod());

            //ExStart:RetrieveCalendarExceptions
            //ExFor: Calendar.Exceptions
            //ExSummary: Shows how to retrieve info about calendar exceptions.
            var project = new Project(dataDir + "project_RetrieveExceptions_test.mpp");

            // Iterate over calendars
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
