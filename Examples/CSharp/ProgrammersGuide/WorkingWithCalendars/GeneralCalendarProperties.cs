//////////////////////////////////////////////////////////////////////////
// Copyright 2001-2016 Aspose Pty Ltd. All Rights Reserved.
//
// This file is part of Aspose.Tasks. The source code in this file
// is only intended as a supplement to the documentation, and is provided
// "as is", without warranty of any kind, either expressed or implied.
//////////////////////////////////////////////////////////////////////////using Aspose.Tasks;
using Aspose.Tasks;
using CSharp;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Examples.ProgrammersGuide.WorkingWithCalendars
{
    class GeneralCalendarProperties
    {
        public static void Run()
        {
            //ExStart: ReadCalendarProps
            //This example shows how the API can be used to read calendars information from a MPP/XML file
            
            //load an existing project
            string dataDir = RunExamples.GetDataDir_Projects();
            Project project = new Project("Existing Project.mpp");

            foreach (Aspose.Tasks.Calendar cal in project.Calendars)
            {
                if (cal.Name != null)
                {
                    Console.WriteLine("UID : " + cal.Uid.ToString() + " Name: " + cal.Name);

                    //Show if it is has a base calendar
                    Console.Write("Base Calendar : ");
                    if (cal.IsBaseCalendar)
                        Console.WriteLine("Self");
                    else
                        Console.WriteLine(cal.BaseCalendar.Name);

                    //Get Time in hours on each working day
                    foreach (WeekDay wd in cal.WeekDays)
                    {
                        TimeSpan ts = wd.GetWorkingTime();
                        Console.WriteLine("Day Type: " + wd.DayType.ToString() + " Hours: " + ts.ToString());
                    }
                }
            }
            //ExEnd: ReadCalendarProps
        }
    }
}
