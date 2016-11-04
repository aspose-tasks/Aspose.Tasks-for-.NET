using Aspose.Tasks;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

/*
This project uses Automatic Package Restore feature of NuGet to resolve Aspose.Tasks for .NET API reference 
when the project is build. Please check https:// Docs.nuget.org/consume/nuget-faq for more information. 
If you do not wish to use NuGet, you can manually download Aspose.Tasks for .NET API from http://www.aspose.com/downloads, 
install it and then add its reference to this project. For any issues, questions or suggestions 
please feel free to contact us using http://www.aspose.com/community/forums/default.aspx
*/

namespace Aspose.Tasks.Examples.CSharp.WorkingWithCalendars
{
    class ReadWorkWeeksInformation
    {
        public static void Run()
        {
            // ExStart:ReadWorkWeeksInformation       
            string dataDir = RunExamples.GetDataDir(System.Reflection.MethodBase.GetCurrentMethod().DeclaringType);
            
            // Create project instance and access calendar and work weeks collection
            Project project = new Project(dataDir + "project.mpp");
            Calendar calendar = project.Calendars.GetByUid(3);
            WorkWeekCollection collection = calendar.WorkWeeks;

            foreach (WorkWeek workWeek in collection)
            {
                // Display work week name, from and to dates
                string Name = workWeek.Name;  
                DateTime fromDate = workWeek.FromDate;  
                DateTime toDate = workWeek.ToDate;      

                // This data is all about "Details." button you can set special working times for special WeekDay or even make it nonworking
                WeekDayCollection weekDays = workWeek.WeekDays;  
                foreach (WeekDay day in weekDays) 
                {
                    // You can further traverse through working times and display these
                    WorkingTimeCollection workingTimes = day.WorkingTimes;                     
                }
            }
            // ExEnd:ReadWorkWeeksInformation
        }
    }
}
