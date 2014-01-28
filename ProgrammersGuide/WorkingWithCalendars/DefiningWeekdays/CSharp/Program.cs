//////////////////////////////////////////////////////////////////////////
// Copyright 2001-2013 Aspose Pty Ltd. All Rights Reserved.
//
// This file is part of Aspose.Tasks. The source code in this file
// is only intended as a supplement to the documentation, and is provided
// "as is", without warranty of any kind, either expressed or implied.
//////////////////////////////////////////////////////////////////////////
using System.IO;

using Aspose.Tasks;
using System;

namespace DefiningWeekdays
{
    public class Program
    {
        public static void Main(string[] args)
        {
            // The path to the documents directory.
            string dataDir = Path.GetFullPath("../../../Data/");

            // Create directory if it is not already present.
            bool IsExists = System.IO.Directory.Exists(dataDir);
            if (!IsExists)
                System.IO.Directory.CreateDirectory(dataDir);

            //Create a project instance
            Project prj = new Project();

            //Define Calendar
            Aspose.Tasks.Calendar cal = new Aspose.Tasks.Calendar();
            cal.Uid = 1;
            cal.Name = "Calendar1";
            prj.Calendars.Add(cal);

            //Add working days monday through thursday with default timings
            cal.Days.Add(WeekDay.CreateDefaultWorkingDay(DayType.Monday));
            cal.Days.Add(WeekDay.CreateDefaultWorkingDay(DayType.Tuesday));
            cal.Days.Add(WeekDay.CreateDefaultWorkingDay(DayType.Wednesday));
            cal.Days.Add(WeekDay.CreateDefaultWorkingDay(DayType.Thursday));
            cal.Days.Add(new WeekDay(DayType.Saturday));
            cal.Days.Add(new WeekDay(DayType.Sunday));

            //Set friday as short working day
            WeekDay myWeekDay = new WeekDay(DayType.Friday);

            //Sets working time. Only time part of DateTime is important
            WorkingTime wt1 = new WorkingTime();
            wt1.FromTime = new DateTime(1, 1, 1, 9, 0, 0, 0);
            wt1.ToTime = new DateTime(1, 1, 1, 12, 0, 0, 0);
            WorkingTime wt2 = new WorkingTime();
            wt2.FromTime = new DateTime(1, 1, 1, 13, 0, 0, 0);
            wt2.ToTime = new DateTime(1, 1, 1, 16, 0, 0, 0);
            myWeekDay.WorkingTimes.Add(wt1);
            myWeekDay.WorkingTimes.Add(wt2);
            myWeekDay.DayWorking = true;
            cal.Days.Add(myWeekDay);
            prj.CalcCalendarUids();

            //Save the Project
            prj.Save(dataDir + "Project.Xml", Aspose.Tasks.Saving.SaveFileFormat.XML);

            
        }
    }
}