//////////////////////////////////////////////////////////////////////////
// Copyright 2001-2015 Aspose Pty Ltd. All Rights Reserved.
//
// This file is part of Aspose.Tasks. The source code in this file
// is only intended as a supplement to the documentation, and is provided
// "as is", without warranty of any kind, either expressed or implied.
//////////////////////////////////////////////////////////////////////////
using System.IO;

using Aspose.Tasks;
using System.Collections;
using System;
using System.Collections.Generic;

namespace CSharp.Projects
{
    public class RetrieveCalendarInfo
    {
        public static void Run()
        {
            //ExStart: RetrieveCalendarInfo
            // The path to the documents directory.
            string dataDir = RunExamples.GetDataDir_Projects();

            //Create a project reader instance
            Project project = new Project(dataDir + "RetrieveCalendarInfo.mpp");

            //Retrieve Calendars Information
            CalendarCollection alCals = project.Calendars;
            foreach (Aspose.Tasks.Calendar cal in alCals)
            {
                if (cal.Name != null)
                {
                    Console.WriteLine("Calendar UID : " + cal.Uid);
                    Console.WriteLine("Calendar Name : " + cal.Name);

                    WeekDayCollection alDays = cal.WeekDays;
                    foreach (WeekDay wd in alDays)
                    {
                        TimeSpan ts = wd.GetWorkingTime();
                        if (wd.DayWorking)
                        {
                            Console.WriteLine(wd.DayType.ToString() + ":");
                            Console.WriteLine(ts.ToString());
                        }
                    }
                }
            }
            //ExEnd: RetrieveCalendarInfo
        }
    }
}