namespace Aspose.Tasks.Examples.CSharp.WorkingWithCalendars
{
    using System;

    internal class CalculateWorkHours
    {
        public static void Run()
        {
            var dataDir = RunExamples.GetDataDir(System.Reflection.MethodBase.GetCurrentMethod().DeclaringType.FullName);

            //ExStart:CalculateWorkHours
            //ExFor: Tsk.Calendar
            //ExFor: Rsc.Calendar
            //ExSummary: Shows how to calculate working hours.
            // Load an existing project
            var project = new Project(dataDir + "CalculateWorkHours.mpp");

            // Access Task By Id
            var task = project.RootTask.Children.GetById(1);

            // Access Calendar and it's start and end dates
            var taskCalendar = task.Get(Tsk.Calendar);
            var startDate = task.Get(Tsk.Start);
            var endDate = task.Get(Tsk.Finish);

            // Access resource and their calendar
            var resource = project.Resources.GetByUid(1);
            var resourceCalendar = resource.Get(Rsc.Calendar);

            TimeSpan timeSpan;

            // Get Duration in Minutes
            double durationInMins = 0;
            var tempDate = startDate;
            while (tempDate < endDate)
            {
                if (taskCalendar.IsDayWorking(tempDate) && resourceCalendar.IsDayWorking(tempDate))
                {
                    timeSpan = taskCalendar.GetWorkingHours(tempDate);
                    durationInMins += timeSpan.TotalMinutes;
                }

                tempDate = tempDate.AddDays(1);
            }

            tempDate = startDate;

            // Get Duration in Hours
            double durationInHours = 0;
            while (tempDate < endDate)
            {
                if (taskCalendar.IsDayWorking(tempDate) && resourceCalendar.IsDayWorking(tempDate))
                {
                    timeSpan = taskCalendar.GetWorkingHours(tempDate);
                    durationInHours += timeSpan.TotalHours;
                }

                tempDate = tempDate.AddDays(1);
            }

            // Get Duration in Days
            double durationInDays = 0;
            tempDate = startDate;
            while (tempDate < endDate)
            {
                if (taskCalendar.IsDayWorking(tempDate) && resourceCalendar.IsDayWorking(tempDate))
                {
                    timeSpan = taskCalendar.GetWorkingHours(tempDate);
                    if (timeSpan.TotalHours > 0)
                    {
                        durationInDays += timeSpan.TotalDays * (24 / timeSpan.TotalHours);
                    }
                }

                tempDate = tempDate.AddDays(1);
            }

            Console.WriteLine("Duration in Minutes = " + durationInMins);
            Console.WriteLine("Duration in Hours = " + durationInHours);
            Console.WriteLine("Duration in Days = " + durationInDays);
            //ExEnd:CalculateWorkHours
        }
    }
}
