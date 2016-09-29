using Aspose.Tasks;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Aspose.Tasks.Examples.CSharp.WorkingWithCalendars
{
    class GeneralCalendarProperties
    {
        public static void Run()
        {
            // ExStart:ReadCalendarProps
            // This example shows how the API can be used to read calendars information from a MPP/XML file
            
            // Load an existing project
            string dataDir = RunExamples.GetDataDir_WorkingWithCalendars();
            Project project = new Project(dataDir + "Project.xml");

            foreach (Aspose.Tasks.Calendar cal in project.Calendars)
            {
                if (cal.Name != null)
                {
                    Console.WriteLine("UID : " + cal.Uid.ToString() + " Name: " + cal.Name);

                    // Show if it is has a base calendar
                    Console.Write("Base Calendar : ");
                    if (cal.IsBaseCalendar)
                        Console.WriteLine("Self");
                    else
                        Console.WriteLine(cal.BaseCalendar.Name);

                    // Get Time in hours on each working day
                    foreach (WeekDay wd in cal.WeekDays)
                    {
                        TimeSpan ts = wd.GetWorkingTime();
                        Console.WriteLine("Day Type: " + wd.DayType.ToString() + " Hours: " + ts.ToString());
                    }
                }
            }
            // ExEnd:ReadCalendarProps
        }
    }
}
