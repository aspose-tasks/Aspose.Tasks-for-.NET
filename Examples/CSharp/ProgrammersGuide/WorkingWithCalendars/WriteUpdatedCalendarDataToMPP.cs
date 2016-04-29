//////////////////////////////////////////////////////////////////////////
// Copyright 2001-2016 Aspose Pty Ltd. All Rights Reserved.
//
// This file is part of Aspose.Tasks. The source code in this file
// is only intended as a supplement to the documentation, and is provided
// "as is", without warranty of any kind, either expressed or implied.
//////////////////////////////////////////////////////////////////////////
using Aspose.Tasks;
using Aspose.Tasks.Saving;
using CSharp;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Examples.ProgrammersGuide.WorkingWithCalendars
{
    class WriteUpdatedCalendarDataToMPP
    {
        public static void Run()
        {
            //ExStart: WriteUpdatedCalendarDataToMPP
            string resultFile = "OutputMPP.mpp";
            string newFile = "SampleMPP.mpp";
            string dataDir = RunExamples.GetDataDir_Projects();

            Project project = new Project(dataDir + newFile);

            Calendar cal = project.Calendars.GetByUid(3);

            //Update the calendar information
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

            project.Save(dataDir + resultFile, SaveFileFormat.MPP);
            //ExEnd: WriteUpdatedCalendarDataToMPP
        }
    }
}
