using Aspose.Tasks;
//////////////////////////////////////////////////////////////////////////
// Copyright 2001-2016 Aspose Pty Ltd. All Rights Reserved.
//
// This file is part of Aspose.Tasks. The source code in this file
// is only intended as a supplement to the documentation, and is provided
// "as is", without warranty of any kind, either expressed or implied.
//////////////////////////////////////////////////////////////////////////
using CSharp;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Examples.ProgrammersGuide.WorkingWithCalendars
{
    class ReadWorkWeeksInformation
    {
        public static void Run()
        {
            //ExStart: ReadWorkWeeksInformation
            //This example demonstrates how to read calendar work weeks infomraiton from a Project file

            string dataDir = RunExamples.GetDataDir_Projects();

            Project project = new Project("TestWorkWeek.mpp");
            
            Calendar calendar = project.Calendars.GetByUid(3);
            
            WorkWeekCollection collection = calendar.WorkWeeks;

            foreach (WorkWeek workWeek in collection)
            {
                string Name = workWeek.Name;  //name
                
                DateTime fromDate = workWeek.FromDate;  //start
                
                DateTime toDate = workWeek.ToDate;      //finish

                //This data is all about "Details.." button you can set special working times for special WeekDay or even make nonworking
                WeekDayCollection weekDays = workWeek.WeekDays;   //Aspose.Tasks.WeekDayCollection
                foreach (WeekDay day in weekDays)   //Aspose.Tasks.WeekDay
                {
                    WorkingTimeCollection workingTimes = day.WorkingTimes;  //Aspose.Tasks.WorkingTimeCollection

                    //You can further traverse through working times and display these
                }
            }
            //ExEnd: ReadWorkWeeksInformation
        }
    }
}
