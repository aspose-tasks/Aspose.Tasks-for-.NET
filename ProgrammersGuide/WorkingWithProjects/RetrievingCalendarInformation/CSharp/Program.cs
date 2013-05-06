//////////////////////////////////////////////////////////////////////////
// Copyright 2001-2013 Aspose Pty Ltd. All Rights Reserved.
//
// This file is part of Aspose.Tasks. The source code in this file
// is only intended as a supplement to the documentation, and is provided
// "as is", without warranty of any kind, either expressed or implied.
//////////////////////////////////////////////////////////////////////////
using System.IO;

using Aspose.Tasks;
using System.Collections;
using System;

namespace RetrievingCalendarInformation
{
    public class Program
    {
        public static void Main(string[] args)
        {
            // The path to the documents directory.
            string dataDir = Path.GetFullPath("../../../Data/");

            //Create a project reader instance
            ProjectReader rdr = new ProjectReader();

            //Call the Read method of project reader object to get project object
            FileStream St = new FileStream(dataDir + "project.mpp", FileMode.Open);
            Project prj = rdr.Read(St);
            St.Close();

            //Retrieve Calendars Information
            ArrayList alCals = prj.Calendars;
            foreach (Aspose.Tasks.Calendar cal in alCals)
            {
                if (cal.Name != null)
                {
                    Console.WriteLine("Calendar UID : " + cal.Uid);
                    Console.WriteLine("Calendar Name : " + cal.Name);
                    ArrayList alDays = cal.Days;
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
        }
    }
}