using System;

namespace Aspose.Tasks.Examples.CSharp.WorkingWithCalendars
{
    public class RetrieveCalendarInfo
    {
        public static void Run()
        {
            // ExStart:RetrieveCalendarInfo
            // The path to the documents directory.
            string dataDir = RunExamples.GetDataDir(System.Reflection.MethodBase.GetCurrentMethod().DeclaringType);

            // Create a project instance
            Project project = new Project(dataDir + "RetrieveCalendarInfo.mpp");

            // Retrieve Calendars Information
            CalendarCollection alCals = project.Calendars;
            foreach (Calendar cal in alCals)
            {
                if (cal.Name != null)
                {
                    Console.WriteLine("Calendar UID : " + cal.Uid);
                    Console.WriteLine("Calendar Name : " + cal.Name);

                    WeekDayCollection alDays = cal.WeekDays;
                    foreach (WeekDay wd in alDays)
                    {
                        TimeSpan ts = wd.GetWorkingTime();
                        if (wd.DayWorking)
                        {
                            Console.WriteLine(wd.DayType.ToString() + ":");
                            Console.WriteLine(ts.ToString());
                        }
                    }
                }
            }
            // ExEnd:RetrieveCalendarInfo
        }
    }
}