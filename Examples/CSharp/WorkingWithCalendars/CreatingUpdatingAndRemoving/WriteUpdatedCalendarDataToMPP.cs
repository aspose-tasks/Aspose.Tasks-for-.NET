using Aspose.Tasks;
using Aspose.Tasks.Saving;
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

namespace Aspose.Tasks.Examples.CSharp.WorkingWithCalendars.CreatingUpdatingAndRemoving
{
    class WriteUpdatedCalendarDataToMPP
    {
        public static void Run()
        {
            // ExStart:WriteUpdatedCalendarDataToMPP
            string resultFile = "result_out.mpp";
            string newFile = "project_test.mpp";
            string dataDir = RunExamples.GetDataDir(System.Reflection.MethodBase.GetCurrentMethod().DeclaringType);

            try
            {
                // Create project instance and access calendar
                Project project = new Project(dataDir + newFile);
                Calendar cal = project.Calendars.GetByUid(3);

                // Update the calendar information
                Calendar.MakeStandardCalendar(cal);
                cal.Name = "Test calendar";
                CalendarException exc = new CalendarException();
                exc.FromDate = DateTime.Now;
                exc.ToDate = DateTime.Now.AddDays(2);
                exc.DayWorking = true;

                WorkingTime wt1 = new WorkingTime();
                wt1.FromTime = new DateTime(10, 1, 1, 9, 0, 0);
                wt1.ToTime = new DateTime(10, 1, 1, 13, 0, 0);

                WorkingTime wt2 = new WorkingTime();
                wt2.FromTime = new DateTime(10, 1, 1, 14, 0, 0);
                wt2.ToTime = new DateTime(10, 1, 1, 19, 0, 0);

                WorkingTime wt3 = new WorkingTime();
                wt3.FromTime = new DateTime(10, 1, 1, 20, 0, 0);
                wt3.ToTime = new DateTime(10, 1, 1, 21, 0, 0);

                exc.WorkingTimes.Add(wt1);
                exc.WorkingTimes.Add(wt2);
                exc.WorkingTimes.Add(wt3);
                cal.Exceptions.Add(exc);

                CalendarException exc2 = new CalendarException();
                exc2.FromDate = DateTime.Now.AddDays(7);
                exc2.ToDate = exc2.FromDate;
                exc2.DayWorking = false;
                cal.Exceptions.Add(exc2);

                project.Set(Prj.Calendar, cal);

                // Save project
                project.Save(dataDir + resultFile, SaveFileFormat.MPP);
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message + "\nThis example will only work if you apply a valid Aspose License. You can purchase full license or get 30 day temporary license from http:// Www.aspose.com/purchase/default.aspx.");
            }            
            // ExEnd:WriteUpdatedCalendarDataToMPP
        }
    }
}
