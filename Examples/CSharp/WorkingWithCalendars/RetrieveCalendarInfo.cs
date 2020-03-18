namespace Aspose.Tasks.Examples.CSharp.WorkingWithCalendars
{
    using System;

    public class RetrieveCalendarInfo
    {
        public static void Run()
        {
            //ExStart:RetrieveCalendarInfo
            // The path to the documents directory.
            var dataDir = RunExamples.GetDataDir(System.Reflection.MethodBase.GetCurrentMethod().DeclaringType.FullName);

            // Create a project instance
            var project = new Project(dataDir + "RetrieveCalendarInfo.mpp");

            // Retrieve Calendars Information
            var calendars = project.Calendars;
            foreach (var cal in calendars)
            {
                if (cal.Name == null)
                {
                    continue;
                }

                Console.WriteLine("Calendar UID : " + cal.Uid);
                Console.WriteLine("Calendar Name : " + cal.Name);

                var days = cal.WeekDays;
                foreach (var wd in days)
                {
                    var ts = wd.GetWorkingTime();
                    if (!wd.DayWorking) 
                    {
                        continue;
                    }

                    Console.WriteLine(wd.DayType + ":");
                    Console.WriteLine(ts.ToString());
                }
            }
            //ExEnd:RetrieveCalendarInfo
        }
    }
}