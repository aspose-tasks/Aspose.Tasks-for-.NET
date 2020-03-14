using System;

/*
This project uses Automatic Package Restore feature of NuGet to resolve Aspose.Tasks for .NET API reference 
when the project is build. Please check https:// Docs.nuget.org/consume/nuget-faq for more information. 
If you do not wish to use NuGet, you can manually download Aspose.Tasks for .NET API from https://www.nuget.org/packages/Aspose.Tasks/, 
install it and then add its reference to this project. For any issues, questions or suggestions 
please feel free to contact us using https://forum.aspose.com/c/tasks
*/

namespace Aspose.Tasks.Examples.CSharp.WorkingWithCalendars
{
    class GeneralCalendarProperties
    {
        public static void Run()
        {
            //ExStart:ReadCalendarProps            
            // Load an existing project
            string dataDir = RunExamples.GetDataDir(System.Reflection.MethodBase.GetCurrentMethod().DeclaringType.FullName);
            Project project = new Project(dataDir + "Project_GeneralCalendarProperties.xml");

            foreach (Aspose.Tasks.Calendar cal in project.Calendars)
            {
                if (cal.Name != null)
                {
                    Console.WriteLine("UID : " + cal.Uid + " Name: " + cal.Name);

                    // Show if it is has a base calendar
                    Console.Write("Base Calendar : ");
                    Console.WriteLine(cal.IsBaseCalendar ? "Self" : cal.BaseCalendar.Name);

                    // Get Time in hours on each working day
                    foreach (WeekDay wd in cal.WeekDays)
                    {
                        TimeSpan ts = wd.GetWorkingTime();
                        Console.WriteLine("Day Type: " + wd.DayType + " Hours: " + ts);
                    }
                }
            }
            //ExEnd:ReadCalendarProps
        }
    }
}
