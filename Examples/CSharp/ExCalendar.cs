namespace Aspose.Tasks.Examples.CSharp
{
    using System;
    using NUnit.Framework;
    using Saving;

    [TestFixture]
    public class ExCalendar : ApiExampleBase
    {
        [Test]
        public static void RetrieveCalendarInfo()
        {
            //ExStart:RetrieveCalendarInfo
            //ExFor: Calendar.Uid
            //ExFor: Calendar.Name
            //ExSummary: Shows how to retrieve calendar info.
            var project = new Project(DataDir + "RetrieveCalendarInfo.mpp");

            // Retrieve Calendars Information
            foreach (var calendar in project.Calendars)
            {
                if (calendar.Name == null)
                {
                    continue;
                }

                Console.WriteLine("Calendar UID: " + calendar.Uid);
                Console.WriteLine("Calendar Name: " + calendar.Name);
            }
            //ExEnd:RetrieveCalendarInfo
        }
        
        [Test]
        public static void ReadWorkWeeksInformation()
        {
            //ExStart:ReadWorkWeeksInformation
            //ExFor: Calendar.WorkWeeks
            //ExSummary: Shows how to read work week information.
            var project = new Project(DataDir + "ReadWorkWeeksInformation.mpp");
            var calendar = project.Calendars.GetByUid(3);

            foreach (var workWeek in calendar.WorkWeeks)
            {
                // Display work week name, from and to dates
                var name = workWeek.Name;  
                var fromDate = workWeek.FromDate;  
                var toDate = workWeek.ToDate;
                Console.WriteLine("Name: " + name);
                Console.WriteLine("From Date: " + fromDate);
                Console.WriteLine("To Date: " + toDate);

                // This data is all about "Details." button you can set special working times for special WeekDay or even make it nonworking
                foreach (var day in workWeek.WeekDays) 
                {
                    // You can further traverse through working times and display these
                    foreach (var workingTime in day.WorkingTimes)
                    {
                        Console.WriteLine(workingTime.FromTime);
                        Console.WriteLine(workingTime.ToTime);
                    }
                }
            }
            //ExEnd:ReadWorkWeeksInformation
        }
        
        [Test]
        public void ReadCalendarProps()
        {
            //ExStart:ReadCalendarProps
            //ExFor: Calendar.IsBaseCalendar
            //ExSummary: Shows how to read project calendars and their properties.
            var project = new Project(DataDir + "Project_GeneralCalendarProperties.xml");

            foreach (var calendar in project.Calendars)
            {
                if (calendar.Name == null)
                {
                    continue;
                }

                Console.WriteLine("UID : " + calendar.Uid + " Name: " + calendar.Name);

                // Show if it is has a base calendar
                Console.Write("Base Calendar : ");
                Console.WriteLine(calendar.IsBaseCalendar ? "Self" : calendar.BaseCalendar.Name);

                // Get Time in hours on each working day
                foreach (var wd in calendar.WeekDays)
                {
                    var ts = wd.GetWorkingTime();
                    Console.WriteLine("Day Type: " + wd.DayType + " Hours: " + ts);
                }
            }
            //ExEnd:ReadCalendarProps
        }
        
        [Test]
        public void CalculateWorkHours()
        {
            //ExStart:CalculateWorkHours
            //ExFor: Calendar.IsDayWorking(DateTime)
            //ExSummary: Shows how to calculate working hours.
            var project = new Project(DataDir + "CalculateWorkHours.mpp");

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

        [Test]
        public void DefineWeekdaysForCalendar()
        {
            //ExStart:DefineWeekdaysForCalendar
            //ExFor: Calendar.WeekDays
            //ExSummary: Shows how to define a new calendar, add week days to it and define working times for days.
            var project = new Project();

            // Define a calendar
            var calendar = project.Calendars.Add("Calendar1");

            // Add working days monday through thursday with default timings
            calendar.WeekDays.Add(WeekDay.CreateDefaultWorkingDay(DayType.Monday));
            calendar.WeekDays.Add(WeekDay.CreateDefaultWorkingDay(DayType.Tuesday));
            calendar.WeekDays.Add(WeekDay.CreateDefaultWorkingDay(DayType.Wednesday));
            calendar.WeekDays.Add(WeekDay.CreateDefaultWorkingDay(DayType.Thursday));
            calendar.WeekDays.Add(new WeekDay(DayType.Saturday));
            calendar.WeekDays.Add(new WeekDay(DayType.Sunday));

            // Set friday as short working day
            var weekDay = new WeekDay(DayType.Friday);

            // Sets working time. Only time part of DateTime is important
            var workingTime = new WorkingTime();
            workingTime.FromTime = new DateTime(1, 1, 1, 9, 0, 0, 0);
            workingTime.ToTime = new DateTime(1, 1, 1, 12, 0, 0, 0);
            var workingTime2 = new WorkingTime();
            workingTime2.FromTime = new DateTime(1, 1, 1, 13, 0, 0, 0);
            workingTime2.ToTime = new DateTime(1, 1, 1, 16, 0, 0, 0);
            weekDay.WorkingTimes.Add(workingTime);
            weekDay.WorkingTimes.Add(workingTime2);
            weekDay.DayWorking = true;
            calendar.WeekDays.Add(weekDay);

            project.Save(OutDir + "DefineCalendarWeekdays_out.xml", SaveFileFormat.XML);
            //ExEnd:DefineWeekdaysForCalendar
        }

        [Test]
        public void WriteUpdatedCalendarDataToMPP()
        {
            try
            {
                //ExStart:WriteUpdatedCalendarDataToMPP
                //ExFor: Calendar.MakeStandardCalendar(Calendar)
                //ExSummary: Shows how to create a calendar with exception days.
                var project = new Project(DataDir + "project_update_test.mpp");
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

                project.Save(OutDir + "WriteUpdatedCalendarDataToMPP_out.mpp", SaveFileFormat.MPP);
                //ExEnd:WriteUpdatedCalendarDataToMPP
            }
            catch (NotSupportedException ex)
            {
                Console.WriteLine(ex.Message + "\nThis example will only work if you apply a valid Aspose License. You can purchase full license or get 30 day temporary license from http://www.aspose.com/purchase/default.aspx.");
            }
        }
        
        [Test]
        public void CalculateSplitTaskFinishDate()
        {
            //ExStart:CalculateSplitTaskFinishDate
            //ExFor: Calendar.GetTaskFinishDateFromDuration(Task, TimeSpan)
            //ExSummary: Shows how to calculate finish date of a task by a custom duration.
            var project = new Project(DataDir + "SplitTaskFinishDate.mpp");

            // Find a split task
            var task = project.RootTask.Children.GetByUid(4);

            // Find the project calendar
            var calendar = project.Get(Prj.Calendar);

            // Calculate task's finish date with different durations
            Console.WriteLine("Start Date: " + task.Get(Tsk.Start).ToShortDateString() + "\n+ Duration 8 hours\nFinish Date: " + calendar.GetTaskFinishDateFromDuration(task, new TimeSpan(8, 0, 0)));
            Console.WriteLine("Start Date: " + task.Get(Tsk.Start).ToShortDateString() + "\n+ Duration 16 hours\nFinish Date: " + calendar.GetTaskFinishDateFromDuration(task, new TimeSpan(16, 0, 0)));
            Console.WriteLine("Start Date: " + task.Get(Tsk.Start).ToShortDateString() + "\n+ Duration 24 hours\nFinish Date: " + calendar.GetTaskFinishDateFromDuration(task, new TimeSpan(24, 0, 0)));
            Console.WriteLine("Start Date: " + task.Get(Tsk.Start).ToShortDateString() + "\n+ Duration 28 hours\nFinish Date: " + calendar.GetTaskFinishDateFromDuration(task, new TimeSpan(28, 0, 0)));
            Console.WriteLine("Start Date: " + task.Get(Tsk.Start).ToShortDateString() + "\n+ Duration 32 hours\nFinish Date: " + calendar.GetTaskFinishDateFromDuration(task, new TimeSpan(32, 0, 0)));
            Console.WriteLine("Start Date: " + task.Get(Tsk.Start).ToShortDateString() + "\n+ Duration 46 hours\nFinish Date: " + calendar.GetTaskFinishDateFromDuration(task, new TimeSpan(46, 0, 0)));
            Console.WriteLine("Start Date: " + task.Get(Tsk.Start).ToShortDateString() + "\n+ Duration 61 hours\nFinish Date: " + calendar.GetTaskFinishDateFromDuration(task, new TimeSpan(61, 0, 0)));
            Console.WriteLine("Start Date: " + task.Get(Tsk.Start).ToShortDateString() + "\n+ Duration 75 hours\nFinish Date: " + calendar.GetTaskFinishDateFromDuration(task, new TimeSpan(75, 0, 0)));
            Console.WriteLine("Start Date: " + task.Get(Tsk.Start).ToShortDateString() + "\n+ Duration 80 hours\nFinish Date: " + calendar.GetTaskFinishDateFromDuration(task, new TimeSpan(80, 0, 0)));
            Console.WriteLine("Start Date: " + task.Get(Tsk.Start).ToShortDateString() + "\n+ Duration 120 hours\nFinish Date: " + calendar.GetTaskFinishDateFromDuration(task, new TimeSpan(120, 0, 0)));
            Console.WriteLine("Start Date: " + task.Get(Tsk.Start).ToShortDateString() + "\n+ Duration 150 hours\nFinish Date: " + calendar.GetTaskFinishDateFromDuration(task, new TimeSpan(150, 0, 0)));
            //ExEnd:CalculateSplitTaskFinishDate
        }
        
        [Test]
        public void RetrieveCalendarExceptions()
        {
            //ExStart:RetrieveCalendarExceptions
            //ExFor: Calendar.Exceptions
            //ExSummary: Shows how to retrieve info about calendar exceptions.
            var project = new Project(DataDir + "project_RetrieveExceptions_test.mpp");

            // Iterate over calendars
            foreach (var calendar in project.Calendars)
            {
                // Access calendar exceptions
                foreach (var exception in calendar.Exceptions)
                {
                    Console.WriteLine("From: " + exception.FromDate.ToShortDateString());
                    Console.WriteLine("To: " + exception.ToDate.ToShortDateString());
                }
            }
            //ExEnd:RetrieveCalendarExceptions
        }
        
        [Test]
        public void GetBaseResourceCalendar()
        {
            //ExStart:GetBaseResourceCalendar
            //ExFor: Calendar.BaseCalendar
            //ExSummary: Shows how to work with a base calendar of the resource's calendar.
            var project = new Project(DataDir + "ResourceCalendar.mpp");
            var res = project.Resources.Add("Resource1");
            
            // Add standard calendar and assign to resource
            var cal = project.Calendars.Add("Resource1");
            res.Set(Rsc.Calendar, cal);
            
            // Display base calendar name for all resources
            foreach (var resource in project.Resources)
            {
                if (resource.Get(Rsc.Name) != null)
                {
                    Console.WriteLine(resource.Get(Rsc.Calendar).BaseCalendar.Name);
                }
            }
            //ExEnd:GetBaseResourceCalendar
        }
    }
}