/*
This project uses Automatic Package Restore feature of NuGet to resolve Aspose.Tasks for .NET API reference 
when the project is build. Please check https:// Docs.nuget.org/consume/nuget-faq for more information. 
If you do not wish to use NuGet, you can manually download Aspose.Tasks for .NET API from https://www.nuget.org/packages/Aspose.Tasks/, 
install it and then add its reference to this project. For any issues, questions or suggestions 
please feel free to contact us using https://forum.aspose.com/c/tasks
*/

namespace Aspose.Tasks.Examples.CSharp.WorkingWithCalendars
{
    using System;

    internal class GeneralCalendarProperties
    {
        public static void Run()
        {
            var dataDir = RunExamples.GetDataDir(System.Reflection.MethodBase.GetCurrentMethod());

            //ExStart:ReadCalendarProps
            //ExFor: Project.Calendars
            //ExFor: Calendar.IsBaseCalendar
            //ExFor: Calendar.WeekDays
            //ExSummary: Shows how to read project calendars and their properties.
            // Load an existing project
            var project = new Project(dataDir + "Project_GeneralCalendarProperties.xml");

            foreach (var calendar in project.Calendars)
            {
                if (calendar.Name == null)
                {
                    continue;
                }

                Console.WriteLine("UID : " + calendar.Uid + " Name: " + calendar.Name);

                // Show if it is has a base calendar
                Console.Write("Base Calendar : ");
                Console.WriteLine(calendar.IsBaseCalendar ? "Self" : calendar.BaseCalendar.Name);

                // Get Time in hours on each working day
                foreach (var wd in calendar.WeekDays)
                {
                    var ts = wd.GetWorkingTime();
                    Console.WriteLine("Day Type: " + wd.DayType + " Hours: " + ts);
                }
            }
            //ExEnd:ReadCalendarProps
        }
    }
}
