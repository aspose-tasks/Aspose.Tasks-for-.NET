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

namespace GettingWorkingHours
{
    public class Program
    {
        public static void Main(string[] args)
        {
            // The path to the documents directory.
            string dataDir = Path.GetFullPath("../../../Data/");

            ProjectReader reader = new ProjectReader();
            Project project = reader.Read(dataDir + "Project.mpp");

            Task task = project.GetTaskById(1);

            Aspose.Tasks.Calendar taskCalendar = task.Calendar;
            DateTime startDate = task.Start;
            DateTime endDate = task.Finish;
            DateTime tempDate = startDate;

            Resource resource = project.GetResourceByUid(1);
            Aspose.Tasks.Calendar resourceCalendar = resource.Calendar;

            TimeSpan timeSpan;

            //Get Duration in Minutes
            double durationInMins = 0;

            while (tempDate < endDate)
            {
                if (taskCalendar.IsDayWorking(tempDate) && resourceCalendar.IsDayWorking(tempDate))
                {
                    timeSpan = taskCalendar.GetWorkingHours(tempDate);
                    durationInMins = durationInMins + timeSpan.TotalMinutes;
                }
                tempDate = tempDate.AddDays(1);
            }
            tempDate = startDate;

            //Get Duration in Hours

            double durationInHours = 0;

            while (tempDate < endDate)
            {
                if (taskCalendar.IsDayWorking(tempDate) && resourceCalendar.IsDayWorking(tempDate))
                {
                    timeSpan = taskCalendar.GetWorkingHours(tempDate);
                    durationInHours = durationInHours + timeSpan.TotalHours;
                }
                tempDate = tempDate.AddDays(1);
            }
            tempDate = startDate;

            //Get Duration in Days
            double durationInDays = 0;

            while (tempDate < endDate)
            {
                if (taskCalendar.IsDayWorking(tempDate) && resourceCalendar.IsDayWorking(tempDate))
                {
                    timeSpan = taskCalendar.GetWorkingHours(tempDate);
                    if (timeSpan.TotalHours > 0)
                        durationInDays = durationInDays + timeSpan.TotalDays * (24 / (timeSpan.TotalHours));
                }
                tempDate = tempDate.AddDays(1);
            }
            tempDate = startDate;

            Console.WriteLine("Duration in Minutes = " + durationInMins);
            Console.WriteLine("Duration in Hours = " + durationInHours);
            Console.WriteLine("Duration in Days = " + durationInDays);
            Console.ReadLine();

        }
    }
}