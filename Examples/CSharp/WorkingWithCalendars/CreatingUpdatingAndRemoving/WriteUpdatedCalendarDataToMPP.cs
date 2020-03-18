/*
This project uses Automatic Package Restore feature of NuGet to resolve Aspose.Tasks for .NET API reference 
when the project is build. Please check https:// Docs.nuget.org/consume/nuget-faq for more information. 
If you do not wish to use NuGet, you can manually download Aspose.Tasks for .NET API from https://www.nuget.org/packages/Aspose.Tasks/, 
install it and then add its reference to this project. For any issues, questions or suggestions 
please feel free to contact us using https://forum.aspose.com/c/tasks
*/

namespace Aspose.Tasks.Examples.CSharp.WorkingWithCalendars.CreatingUpdatingAndRemoving
{
    using System;

    using Aspose.Tasks.Saving;

    internal class WriteUpdatedCalendarDataToMPP
    {
        public static void Run()
        {
            var dataDir = RunExamples.GetDataDir(System.Reflection.MethodBase.GetCurrentMethod().DeclaringType.FullName);
            //ExStart:WriteUpdatedCalendarDataToMPP
            try
            {
                // Create project instance and access calendar
                var project = new Project(dataDir + "project_update_test.mpp");
                var cal = project.Calendars.GetByUid(3);

                // Update the calendar information
                Calendar.MakeStandardCalendar(cal);
                cal.Name = "Test calendar";
                var exc = new CalendarException();
                exc.FromDate = DateTime.Now;
                exc.ToDate = DateTime.Now.AddDays(2);
                exc.DayWorking = true;

                var wt1 = new WorkingTime();
                wt1.FromTime = new DateTime(10, 1, 1, 9, 0, 0);
                wt1.ToTime = new DateTime(10, 1, 1, 13, 0, 0);

                var wt2 = new WorkingTime();
                wt2.FromTime = new DateTime(10, 1, 1, 14, 0, 0);
                wt2.ToTime = new DateTime(10, 1, 1, 19, 0, 0);

                var wt3 = new WorkingTime();
                wt3.FromTime = new DateTime(10, 1, 1, 20, 0, 0);
                wt3.ToTime = new DateTime(10, 1, 1, 21, 0, 0);

                exc.WorkingTimes.Add(wt1);
                exc.WorkingTimes.Add(wt2);
                exc.WorkingTimes.Add(wt3);
                cal.Exceptions.Add(exc);

                var exc2 = new CalendarException();
                exc2.FromDate = DateTime.Now.AddDays(7);
                exc2.ToDate = exc2.FromDate;
                exc2.DayWorking = false;
                cal.Exceptions.Add(exc2);

                project.Set(Prj.Calendar, cal);

                // Save project
                project.Save(dataDir + "WriteUpdatedCalendarDataToMPP_out.mpp", SaveFileFormat.MPP);
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message + "\nThis example will only work if you apply a valid Aspose License. You can purchase full license or get 30 day temporary license from http:// Www.aspose.com/purchase/default.aspx.");
            }            
            //ExEnd:WriteUpdatedCalendarDataToMPP
        }
    }
}
