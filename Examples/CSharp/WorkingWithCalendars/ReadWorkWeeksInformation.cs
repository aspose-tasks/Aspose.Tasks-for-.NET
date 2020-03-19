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

    internal class ReadWorkWeeksInformation
    {
        public static void Run()
        {
            var dataDir = RunExamples.GetDataDir(System.Reflection.MethodBase.GetCurrentMethod().DeclaringType.FullName);
            
            //ExStart:ReadWorkWeeksInformation
            //ExFor: WorkWeekCollection
            //ExFor: Calendar.WorkWeeks
            //ExSummary: Shows how to read work week information.
            // Create project instance and access calendar and work weeks collection
            var project = new Project(dataDir + "ReadWorkWeeksInformation.mpp");
            var calendar = project.Calendars.GetByUid(3);
            var workWeeks = calendar.WorkWeeks;

            foreach (var workWeek in workWeeks)
            {
                // Display work week name, from and to dates
                var name = workWeek.Name;  
                var fromDate = workWeek.FromDate;  
                var toDate = workWeek.ToDate;
                Console.WriteLine("Name: " + name);
                Console.WriteLine("From Date: " + fromDate);
                Console.WriteLine("To Date: " + toDate);

                // This data is all about "Details." button you can set special working times for special WeekDay or even make it nonworking
                var weekDays = workWeek.WeekDays;  
                foreach (var day in weekDays) 
                {
                    // You can further traverse through working times and display these
                    var workingTimes = day.WorkingTimes;
                    foreach (var workingTime in workingTimes)
                    {
                        Console.WriteLine(workingTime.FromTime);
                        Console.WriteLine(workingTime.ToTime);
                    }
                }
            }
            //ExEnd:ReadWorkWeeksInformation
        }
    }
}
