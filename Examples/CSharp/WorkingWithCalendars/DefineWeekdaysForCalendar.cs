using Aspose.Tasks;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Aspose.Tasks.Examples.CSharp.WorkingWithCalendars
{
    class DefineWeekdaysForCalendar
    {
        public static void Run()
        {
            // ExStart:DefineWeekdaysForCalendar
            // This example shows how Aspose.Tasks API can be used to define a new Calendar, add week days to it and define working times for days
            // Create a project instance
            Project project = new Project();

            // Define Calendar
            Aspose.Tasks.Calendar cal = project.Calendars.Add("Calendar1");

            // Add working days monday through thursday with default timings
            cal.WeekDays.Add(WeekDay.CreateDefaultWorkingDay(DayType.Monday));
            cal.WeekDays.Add(WeekDay.CreateDefaultWorkingDay(DayType.Tuesday));
            cal.WeekDays.Add(WeekDay.CreateDefaultWorkingDay(DayType.Wednesday));
            cal.WeekDays.Add(WeekDay.CreateDefaultWorkingDay(DayType.Thursday));
            cal.WeekDays.Add(new WeekDay(DayType.Saturday));
            cal.WeekDays.Add(new WeekDay(DayType.Sunday));

            // Set friday as short working day
            WeekDay myWeekDay = new WeekDay(DayType.Friday);

            // Sets working time. Only time part of DateTime is important
            WorkingTime wt1 = new WorkingTime();
            wt1.FromTime = new DateTime(1, 1, 1, 9, 0, 0, 0);
            wt1.ToTime = new DateTime(1, 1, 1, 12, 0, 0, 0);
            WorkingTime wt2 = new WorkingTime();
            wt2.FromTime = new DateTime(1, 1, 1, 13, 0, 0, 0);
            wt2.ToTime = new DateTime(1, 1, 1, 16, 0, 0, 0);
            myWeekDay.WorkingTimes.Add(wt1);
            myWeekDay.WorkingTimes.Add(wt2);
            myWeekDay.DayWorking = true;
            cal.WeekDays.Add(myWeekDay);


            // Save the Project
            string dataDir = RunExamples.GetDataDir_Projects();
            project.Save("Project.xml", Aspose.Tasks.Saving.SaveFileFormat.XML);
            // ExEnd:DefineWeekdaysForCalendar
        }
    }
}
