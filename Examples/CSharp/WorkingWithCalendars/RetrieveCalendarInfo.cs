using System;

namespace Aspose.Tasks.Examples.CSharp.WorkingWithCalendars
{
    public class RetrieveCalendarInfo
    {
        public static void Run()
        {
            //ExStart:RetrieveCalendarInfo
            // The path to the documents directory.
            string dataDir = RunExamples.GetDataDir(System.Reflection.MethodBase.GetCurrentMethod().DeclaringType.FullName);

            // Create a project instance
            Project project = new Project(dataDir + "RetrieveCalendarInfo.mpp");

            // Retrieve Calendars Information
            CalendarCollection calendars = project.Calendars;
            foreach (Calendar cal in calendars)
            {
                if (cal.Name == null)
                {
                    continue;
                }

                Console.WriteLine("Calendar UID : " + cal.Uid);
                Console.WriteLine("Calendar Name : " + cal.Name);

                WeekDayCollection days = cal.WeekDays;
                foreach (WeekDay wd in days)
                {
                    TimeSpan ts = wd.GetWorkingTime();
                    if (wd.DayWorking)
                    {
                        Console.WriteLine(wd.DayType + ":");
                        Console.WriteLine(ts.ToString());
                    }
                }
            }
            //ExEnd:RetrieveCalendarInfo
        }
    }
}