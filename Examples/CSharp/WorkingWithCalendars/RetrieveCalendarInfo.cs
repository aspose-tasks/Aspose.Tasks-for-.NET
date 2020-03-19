namespace Aspose.Tasks.Examples.CSharp.WorkingWithCalendars
{
    using System;

    internal class RetrieveCalendarInfo
    {
        public static void Run()
        {
            // The path to the documents directory.
            var dataDir = RunExamples.GetDataDir(System.Reflection.MethodBase.GetCurrentMethod().DeclaringType.FullName);

            //ExStart:RetrieveCalendarInfo
            //ExFor: Calendar.Uid
            //ExFor: Calendar.Name
            //ExFor: Calendar.WeekDays
            //ExSummary: Shows how to retrieve calendar info.
            // Create a project instance
            var project = new Project(dataDir + "RetrieveCalendarInfo.mpp");

            // Retrieve Calendars Information
            foreach (var calendar in project.Calendars)
            {
                if (calendar.Name == null)
                {
                    continue;
                }

                Console.WriteLine("Calendar UID: " + calendar.Uid);
                Console.WriteLine("Calendar Name: " + calendar.Name);

                foreach (var weekDay in calendar.WeekDays)
                {
                    if (!weekDay.DayWorking) 
                    {
                        continue;
                    }

                    var workingTime = weekDay.GetWorkingTime();
                    Console.Write(weekDay.DayType + ": ");
                    Console.WriteLine(workingTime.ToString());
                }
            }
            //ExEnd:RetrieveCalendarInfo
        }
    }
}