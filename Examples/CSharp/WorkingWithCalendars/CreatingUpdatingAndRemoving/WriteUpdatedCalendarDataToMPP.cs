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
            //ExFor: CalendarException
            //ExFor: Calendar.MakeStandardCalendar(Calendar)
            //ExFor: CalendarExceptionCollection.Add(CalendarException)
            //ExSummary: Shows how to create a calendar with exception days.
            // Create project instance and access calendar
            var project = new Project(dataDir + "project_update_test.mpp");
            var calendar = project.Calendars.GetByUid(3);

            // Update the calendar information
            Calendar.MakeStandardCalendar(calendar);
            calendar.Name = "Test calendar";
            var exception = new CalendarException();
            exception.FromDate = DateTime.Now;
            exception.ToDate = DateTime.Now.AddDays(2);
            exception.DayWorking = true;

            var wt1 = new WorkingTime();
            wt1.FromTime = new DateTime(10, 1, 1, 9, 0, 0);
            wt1.ToTime = new DateTime(10, 1, 1, 13, 0, 0);

            var wt2 = new WorkingTime();
            wt2.FromTime = new DateTime(10, 1, 1, 14, 0, 0);
            wt2.ToTime = new DateTime(10, 1, 1, 19, 0, 0);

            var wt3 = new WorkingTime();
            wt3.FromTime = new DateTime(10, 1, 1, 20, 0, 0);
            wt3.ToTime = new DateTime(10, 1, 1, 21, 0, 0);

            exception.WorkingTimes.Add(wt1);
            exception.WorkingTimes.Add(wt2);
            exception.WorkingTimes.Add(wt3);
            calendar.Exceptions.Add(exception);

            var exception2 = new CalendarException();
            exception2.FromDate = DateTime.Now.AddDays(7);
            exception2.ToDate = exception2.FromDate;
            exception2.DayWorking = false;
            calendar.Exceptions.Add(exception2);

            project.Set(Prj.Calendar, calendar);

            // Save project
            project.Save(dataDir + "WriteUpdatedCalendarDataToMPP_out.mpp", SaveFileFormat.MPP);
            //ExEnd:WriteUpdatedCalendarDataToMPP
        }
    }
}
