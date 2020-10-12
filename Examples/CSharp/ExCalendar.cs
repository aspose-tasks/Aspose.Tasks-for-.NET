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
            // ExStart:RetrieveCalendarInfo
            // ExFor: Calendar.Uid
            // ExFor: Calendar.Name
            // ExSummary: Shows how to retrieve calendar info.
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

            // ExEnd:RetrieveCalendarInfo
        }

        [Test]
        public static void ReadWorkWeeksInformation()
        {
            // ExStart:WorkWithWorkWeekCollection
            // ExFor: Calendar.WorkWeeks
            // ExSummary: Shows how to read work week information.
            var project = new Project(DataDir + "WorkWithWorkWeekCollection.mpp");
            var calendar = project.Calendars.GetByUid(1);

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

            // ExEnd:WorkWithWorkWeekCollection
        }

        [Test]
        public void ReadCalendarProps()
        {
            // ExStart:ReadCalendarProps
            // ExFor: Calendar.IsBaseCalendar
            // ExSummary: Shows how to read project calendars and their properties.
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

            // ExEnd:ReadCalendarProps
        }

        [Test]
        public void CalculateWorkHours()
        {
            // ExStart:CalculateWorkHours
            // ExFor: Calendar.IsDayWorking(DateTime)
            // ExSummary: Shows how to calculate working hours.
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

            // ExEnd:CalculateWorkHours
        }

        [Test]
        public void DefineWeekdaysForCalendar()
        {
            // ExStart:DefineWeekdaysForCalendar
            // ExFor: Calendar
            // ExFor: Calendar.WeekDays
            // ExFor: Aspose.Tasks.DayType
            // ExSummary: Shows how to define a new calendar, add week days to it and define working times for days.
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
            
            // working with the project...
            // ExEnd:DefineWeekdaysForCalendar
        }

        [Test]
        public void WriteUpdatedCalendarDataToMPP()
        {
            try
            {
                // ExStart:WriteUpdatedCalendarDataToMPP
                // ExFor: Calendar.MakeStandardCalendar(Calendar)
                // ExSummary: Shows how to create a calendar with exception days.
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

                // ExEnd:WriteUpdatedCalendarDataToMPP
            }
            catch (NotSupportedException ex)
            {
                Console.WriteLine(ex.Message + "\nThis example will only work if you apply a valid Aspose License. You can purchase full license or get 30 day temporary license from http://www.aspose.com/purchase/default.aspx.");
            }
        }
        
        [Test]
        public void CalculateSplitTaskFinishDate()
        {
            // ExStart:CalculateSplitTaskFinishDate
            // ExFor: Calendar.GetTaskFinishDateFromDuration(Task, TimeSpan)
            // ExSummary: Shows how to calculate finish date of a task by a custom duration.
            var project = new Project(DataDir + "SplitTaskFinishDate.mpp");

            // Find a split task
            var task = project.RootTask.Children.GetByUid(4);

            // Find the project calendar
            var calendar = project.Get(Prj.Calendar);

            // Calculate task's finish date with different durations
            Console.WriteLine(
                "Start Date: " + task.Get(Tsk.Start).ToShortDateString() + "\n+ Duration 8 hours\nFinish Date: "
                + calendar.GetTaskFinishDateFromDuration(task, new TimeSpan(8, 0, 0)));
            Console.WriteLine(
                "Start Date: " + task.Get(Tsk.Start).ToShortDateString() + "\n+ Duration 16 hours\nFinish Date: "
                + calendar.GetTaskFinishDateFromDuration(task, new TimeSpan(16, 0, 0)));
            Console.WriteLine(
                "Start Date: " + task.Get(Tsk.Start).ToShortDateString() + "\n+ Duration 24 hours\nFinish Date: "
                + calendar.GetTaskFinishDateFromDuration(task, new TimeSpan(24, 0, 0)));
            Console.WriteLine(
                "Start Date: " + task.Get(Tsk.Start).ToShortDateString() + "\n+ Duration 28 hours\nFinish Date: "
                + calendar.GetTaskFinishDateFromDuration(task, new TimeSpan(28, 0, 0)));
            Console.WriteLine(
                "Start Date: " + task.Get(Tsk.Start).ToShortDateString() + "\n+ Duration 32 hours\nFinish Date: "
                + calendar.GetTaskFinishDateFromDuration(task, new TimeSpan(32, 0, 0)));
            Console.WriteLine(
                "Start Date: " + task.Get(Tsk.Start).ToShortDateString() + "\n+ Duration 46 hours\nFinish Date: "
                + calendar.GetTaskFinishDateFromDuration(task, new TimeSpan(46, 0, 0)));
            Console.WriteLine(
                "Start Date: " + task.Get(Tsk.Start).ToShortDateString() + "\n+ Duration 61 hours\nFinish Date: "
                + calendar.GetTaskFinishDateFromDuration(task, new TimeSpan(61, 0, 0)));
            Console.WriteLine(
                "Start Date: " + task.Get(Tsk.Start).ToShortDateString() + "\n+ Duration 75 hours\nFinish Date: "
                + calendar.GetTaskFinishDateFromDuration(task, new TimeSpan(75, 0, 0)));
            Console.WriteLine(
                "Start Date: " + task.Get(Tsk.Start).ToShortDateString() + "\n+ Duration 80 hours\nFinish Date: "
                + calendar.GetTaskFinishDateFromDuration(task, new TimeSpan(80, 0, 0)));
            Console.WriteLine(
                "Start Date: " + task.Get(Tsk.Start).ToShortDateString() + "\n+ Duration 120 hours\nFinish Date: "
                + calendar.GetTaskFinishDateFromDuration(task, new TimeSpan(120, 0, 0)));
            Console.WriteLine(
                "Start Date: " + task.Get(Tsk.Start).ToShortDateString() + "\n+ Duration 150 hours\nFinish Date: "
                + calendar.GetTaskFinishDateFromDuration(task, new TimeSpan(150, 0, 0)));

            // ExEnd:CalculateSplitTaskFinishDate
        }

        [Test]
        public void RetrieveCalendarExceptions()
        {
            // ExStart:RetrieveCalendarExceptions
            // ExFor: Calendar.Exceptions
            // ExSummary: Shows how to retrieve info about calendar exceptions.
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

            // ExEnd:RetrieveCalendarExceptions
        }

        [Test]
        public void GetBaseResourceCalendar()
        {
            // ExStart:GetBaseResourceCalendar
            // ExFor: Calendar.BaseCalendar
            // ExSummary: Shows how to work with a base calendar of the resource's calendar.
            var project = new Project(DataDir + "ResourceCalendar.mpp");
            var resource = project.Resources.Add("Resource1");

            // Add standard calendar and assign to resource
            var calendar = project.Calendars.Add("Resource1");
            resource.Set(Rsc.Calendar, calendar);

            // Display base calendar name for all resources
            foreach (var rsc in project.Resources)
            {
                if (rsc.Get(Rsc.Name) != null)
                {
                    Console.WriteLine(rsc.Get(Rsc.Calendar).BaseCalendar.Name);
                }
            }

            // ExEnd:GetBaseResourceCalendar
        }

        [Test]
        public void DeleteCalendar()
        {
            // ExStart:DeleteCalendar
            // ExFor: Calendar.Delete
            // ExSummary: Shows how to delete a calendar from a project.
            var project = new Project(DataDir + "BrokenCalendar.mpp");

            // get the calendar by name
            var calendar = project.Calendars.GetByName("Broken Calendar");

            // delete the calendar
            calendar.Delete();

            // ExEnd:DeleteCalendar
            Assert.AreEqual(1, project.Calendars.Count);
        }

        [Test]
        public void GetFinishDateByStartAndWork()
        {
            // ExStart:GetFinishDateByStartAndWork
            // ExFor: Calendar.GetFinishDateByStartAndWork(DateTime,Duration)
            // ExSummary: Shows how to calculate a finish date by start date and work using a calendar instance.
            var project = new Project(DataDir + "Blank2010.mpp");

            var calendar = project.Calendars.GetByName("Standard");

            var start = new DateTime(2017, 10, 26, 8, 0, 0);
            var work = project.GetWork(7);

            // calculate finish date by using a standard calendar
            var finish = calendar.GetFinishDateByStartAndWork(start, work);

            Console.WriteLine("Task start date: " + start);
            Console.WriteLine("Task work: " + work);
            Console.WriteLine("Task finish date: " + finish);

            // ExEnd:GetFinishDateByStartAndWork
        }

        [Test]
        public void GetFinishDateByStartAndWork2()
        {
            // ExStart:GetFinishDateByStartAndWork
            // ExFor: Calendar.GetFinishDateByStartAndWork(DateTime,TimeSpan)
            // ExSummary: Shows how to calculate a finish date by start date and work (as a time span) using a calendar instance.
            var project = new Project(DataDir + "Blank2010.mpp");

            var calendar = project.Calendars.GetByName("Standard");

            var start = new DateTime(2017, 10, 26, 8, 0, 0);
            var work = project.GetWork(7);

            // calculate finish date by using a standard calendar
            var finish = calendar.GetFinishDateByStartAndWork(start, work.TimeSpan);

            Console.WriteLine("Task start date: " + start);
            Console.WriteLine("Task work: " + work);
            Console.WriteLine("Task finish date: " + finish);

            // ExEnd:GetFinishDateByStartAndWork
        }

        [Test]
        public void CalendarEquals()
        {
            // ExStart
            // ExFor: Calendar.Equals(Object)
            // ExSummary: Shows how to check calendar equality.
            var project = new Project(DataDir + "Project2.mpp");

            var calendar1 = project.Calendars.GetByUid(1);
            var calendar2 = project.Calendars.GetByUid(3);

            // the equality of calendars is checked against to calendar's UID.
            Console.WriteLine("Calendar 1 UID: " + calendar1.Uid);
            Console.WriteLine("Calendar 2 UID: " + calendar2.Uid);
            Console.WriteLine("Are calendars equal: " + calendar1.Equals(calendar2));

            // ExEnd
        }

        [Test]
        public void GetCalendarHashCode()
        {
            // ExStart
            // ExFor: Calendar.GetHashCode
            // ExSummary: Shows how to get a hash code of a calendar.
            var project = new Project(DataDir + "Project2.mpp");

            var calendar1 = project.Calendars.GetByUid(1);
            var calendar2 = project.Calendars.GetByUid(3);

            // the hash code of a calendar is equal to calendar UID 
            Console.WriteLine("Calendar UID: {0} Hash Code: {1}", calendar1.Uid, calendar1.GetHashCode());
            Console.WriteLine("Calendar UID: {0} Hash Code: {1}", calendar2.Uid, calendar2.GetHashCode());

            // ExEnd
        }

        [Test]
        public void GetNextWorkingDayStart()
        {
            // ExStart
            // ExFor: Calendar.GetNextWorkingDayStart(DateTime)
            // ExSummary: Shows how to get a next working day start by using a calendar.
            var project = new Project(DataDir + "Project1.mpp");

            var calendar = project.Calendars.GetByUid(1);

            // get next working day start (weekend is skipped)
            var nextWorkingDayStart = calendar.GetNextWorkingDayStart(new DateTime(2020, 4, 10, 13, 0, 0));

            // 13 April 2020 9:00 AM will be printed
            Console.WriteLine(nextWorkingDayStart);

            // ExEnd
        }

        [Test]
        public void GetPreviousWorkingDayEnd()
        {
            // ExStart
            // ExFor: Calendar.GetPreviousWorkingDayEnd(DateTime)
            // ExSummary: Shows how to get a previous working day end by using a calendar.
            var project = new Project(DataDir + "Project1.mpp");

            var calendar = project.Calendars.GetByUid(1);

            // get previous working day end
            var previousWorkingDayEnd = calendar.GetPreviousWorkingDayEnd(new DateTime(2020, 4, 10, 13, 0, 0));

            // 9 April 2020 18:00 PM will be printed
            Console.WriteLine(previousWorkingDayEnd);

            // ExEnd
        }

        [Test]
        public void GetStartDateFromFinishAndDuration()
        {
            // ExStart
            // ExFor: Calendar.GetStartDateFromFinishAndDuration(DateTime,Duration)
            // ExSummary: Shows how to get a start date by finish date and duration.
            var project = new Project(DataDir + "Project1.mpp");

            var calendar = project.Calendars.GetByUid(1);

            // get start date by finish date and a duration
            var startDate = calendar.GetStartDateFromFinishAndDuration(new DateTime(2020, 4, 10, 9, 0, 0), project.GetDuration(16, TimeUnitType.Hour));

            // 8 April 2020 9:00 AM will be printed
            Console.WriteLine(startDate);

            // ExEnd
        }

        [Test]
        public void GetStartDateFromFinishAndDuration2()
        {
            // ExStart
            // ExFor: Calendar.GetStartDateFromFinishAndDuration(DateTime,TimeSpan)
            // ExSummary: Shows how to get a start date by finish date and duration (as a time span).
            var project = new Project(DataDir + "Project1.mpp");

            var calendar = project.Calendars.GetByUid(1);

            // get start date by finish date and a duration
            var startDate = calendar.GetStartDateFromFinishAndDuration(new DateTime(2020, 4, 10, 9, 0, 0), TimeSpan.FromHours(16));

            // 8 April 2020 9:00 AM will be printed
            Console.WriteLine(startDate);

            // ExEnd
        }

        [Test]
        public void GetWorkingHours()
        {
            // ExStart
            // ExFor: Calendar.GetWorkingHours(DateTime)
            // ExSummary: Shows how to get working hours for a specific date.
            var project = new Project(DataDir + "Project1.mpp");

            var calendar = project.Calendars.GetByUid(1);

            // get working hours for specific date
            var workingHours = calendar.GetWorkingHours(new DateTime(2020, 4, 10));

            // 8 hours will be printed
            Console.WriteLine(workingHours.Hours);

            // ExEnd
            Assert.AreEqual(8, workingHours.Hours);
        }

        [Test]
        public void GetWorkingHours2()
        {
            // ExStart
            // ExFor: Calendar.GetWorkingHours(DateTime,DateTime)
            // ExSummary: Shows how to get working hours for specific dates.
            var project = new Project(DataDir + "Project1.mpp");

            var calendar = project.Calendars.GetByUid(1);

            // get working hours for specific date
            var workUnit = calendar.GetWorkingHours(new DateTime(2020, 4, 8, 8, 0, 0), new DateTime(2020, 4, 9, 17, 0, 0));

            // 16 hours will be printed
            Console.WriteLine(workUnit.WorkingHours);

            // ExEnd
            Assert.AreEqual(16, workUnit.WorkingHours.TotalHours);
        }

        [Test]
        public void GetWorkingTimes()
        {
            // ExStart
            // ExFor: Calendar.GetWorkingTimes(DateTime)
            // ExSummary: Shows how to get working times for a specific date.
            var project = new Project(DataDir + "Project1.mpp");

            var calendar = project.Calendars.GetByUid(1);

            // get working times for specific date
            var workingTimes = calendar.GetWorkingTimes(new DateTime(2020, 4, 8, 8, 0, 0));

            // 16 hours will be printed
            foreach (var workingTime in workingTimes)
            {
                Console.WriteLine("From: " + workingTime.FromTime);
                Console.WriteLine("To: " + workingTime.ToTime);
            }

            // ExEnd
            Assert.AreEqual(2, workingTimes.Count);
        }

        [Test]
        public void IsBaselineCalendar()
        {
            // ExStart
            // ExFor: Calendar.IsBaselineCalendar
            // ExSummary: Shows how to check whether a calendar is baseline calendar or not.
            var project = new Project(DataDir + "IsBaselineCalendar.mpp");

            var calendar = project.Calendars.GetByUid(3);

            Console.WriteLine("Is baseline calendar: " + calendar.IsBaselineCalendar);

            // ExEnd
        }

        [Test]
        public void Make24HourCalendar()
        {
            // ExStart
            // ExFor: Calendar.Make24HourCalendar
            // ExSummary: Shows how to create a 24 hours calendar.
            var calendar = Calendar.Make24HourCalendar();

            var workingHours = calendar.GetWorkingHours(new DateTime(2020, 4, 8, 8, 0, 0));

            // 24 hours will be printed
            Console.WriteLine("Hours: " + workingHours.TotalHours);

            // ExEnd
        }

        [Test]
        public void Make24HourCalendar2()
        {
            // ExStart
            // ExFor: Calendar.Make24HourCalendar(Calendar)
            // ExSummary: Shows how to transform a new calendar into a 24 hours calendar.
            var project = new Project();

            var calendar = project.Calendars.Add("24 Hours");
            calendar = Calendar.Make24HourCalendar(calendar);

            var workingHours = calendar.GetWorkingHours(new DateTime(2020, 4, 8, 8, 0, 0));

            // 24 hours will be printed
            Console.WriteLine("Hours: " + workingHours.TotalHours);

            // ExEnd
        }

        [Test]
        public void MakeNightShiftCalendar()
        {
            // ExStart
            // ExFor: Calendar.MakeNightShiftCalendar
            // ExSummary: Shows how to create a night shift calendar.
            var calendar = Calendar.MakeNightShiftCalendar();

            var workingHours = calendar.GetWorkingTimes(new DateTime(2020, 4, 8));

            // show working hours
            foreach (var wh in workingHours)
            {
                Console.WriteLine("From: " + wh.FromTime);
                Console.WriteLine("To: " + wh.ToTime);
            }

            // ExEnd
        }

        [Test]
        public void MakeNightShiftCalendar2()
        {
            // ExStart
            // ExFor: Calendar.MakeNightShiftCalendar(Calendar)
            // ExSummary: Shows how to transform a calendar into a night shift calendar.
            var project = new Project();

            var calendar = project.Calendars.Add("Night Shift");
            calendar = Calendar.MakeNightShiftCalendar(calendar);

            var workingHours = calendar.GetWorkingTimes(new DateTime(2020, 4, 8));

            // show working hours
            foreach (var wh in workingHours)
            {
                Console.WriteLine("From: " + wh.FromTime);
                Console.WriteLine("To: " + wh.ToTime);
            }

            // ExEnd
        }

        [Test]
        public void MakeStandardCalendar()
        {
            // ExStart
            // ExFor: Calendar.MakeStandardCalendar
            // ExSummary: Shows how to create a standard calendar.
            var calendar = Calendar.MakeStandardCalendar();

            var workingHours = calendar.GetWorkingTimes(new DateTime(2020, 4, 8));

            // show working hours
            foreach (var wh in workingHours)
            {
                Console.WriteLine("From: " + wh.FromTime);
                Console.WriteLine("To: " + wh.ToTime);
            }

            // ExEnd
        }

        [Test]
        public void CalendarParentProject()
        {
            // ExStart
            // ExFor: Calendar.ParentProject
            // ExSummary: Shows how to use parent project of a calendar.
            var project = new Project();
            var calendar = project.Calendars.Add("Calendar");

            var task = project.RootTask.Children.Add("Task");

            // set a duration for the task by using default project time unit type.
            task.Set(Tsk.Duration, calendar.ParentProject.GetDuration(1));

            Console.WriteLine(task.Get(Tsk.Duration));

            // ExEnd
        }
    }
}