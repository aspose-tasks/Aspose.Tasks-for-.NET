namespace Aspose.Tasks.Examples.CSharp
{
    using System;
    using NUnit.Framework;
    using Saving;

    [TestFixture]
    public class ExPrj : ApiExampleBase
    {
        [Test]
        public void GetSetActualsInSync()
        {
            //ExStart
            //ExFor: Prj.ActualsInSync
            //ExFor: PrjKey.ActualsInSync
            //ExSummary: Shows how to read/write Prj.ActualsInSync property.
            var project = new Project();

            project.Set(Prj.ActualsInSync, true);

            Console.WriteLine("Actuals In Sync: " + project.Get(Prj.ActualsInSync));
            //ExEnd
        }

        [Test]
        public void GetSetAdminProject()
        {
            //ExStart
            //ExFor: Prj.AdminProject
            //ExFor: PrjKey.AdminProject
            //ExSummary: Shows how to read/write Prj.AdminProject property.
            var project = new Project();

            project.Set(Prj.AdminProject, true);

            Console.WriteLine("Admin Project: " + project.Get(Prj.AdminProject));
            //ExEnd
        }

        [Test]
        public void GetSetAreEditableActualCosts()
        {
            //ExStart
            //ExFor: Prj.AreEditableActualCosts
            //ExFor: PrjKey.AreEditableActualCosts
            //ExSummary: Shows how to read/write Prj.AreEditableActualCosts property.
            var project = new Project();

            project.Set(Prj.AreEditableActualCosts, true);

            Console.WriteLine("Are Editable Actual Costs: " + project.Get(Prj.AreEditableActualCosts));
            //ExEnd
        }

        [Test]
        public void GetSetAutoAddNewResourcesAndTasks()
        {
            //ExStart
            //ExFor: Prj.AutoAddNewResourcesAndTasks
            //ExFor: PrjKey.AutoAddNewResourcesAndTasks
            //ExSummary: Shows how to read/write Prj.AutoAddNewResourcesAndTasks property.
            var project = new Project();

            project.Set(Prj.AutoAddNewResourcesAndTasks, true);

            Console.WriteLine("Auto Add New Resources And Tasks: " + project.Get(Prj.AutoAddNewResourcesAndTasks));
            //ExEnd
        }

        [Test]
        public void GetSetAutolink()
        {
            //ExStart
            //ExFor: Prj.Autolink
            //ExFor: PrjKey.Autolink
            //ExSummary: Shows how to read/write Prj.Autolink property.
            var project = new Project();

            project.Set(Prj.Autolink, true);

            Console.WriteLine("Autolink: " + project.Get(Prj.Autolink));
            //ExEnd
        }

        [Test]
        public void GetSetBaselineForEarnedValue()
        {
            //ExStart
            //ExFor: Prj.BaselineForEarnedValue
            //ExFor: PrjKey.BaselineForEarnedValue
            //ExSummary: Shows how to read/write Prj.BaselineForEarnedValue property.
            var project = new Project();

            project.Set(Prj.BaselineForEarnedValue, BaselineType.Baseline);

            Console.WriteLine("Baseline For Earned Value: " + project.Get(Prj.BaselineForEarnedValue));
            //ExEnd
        }

        [Test]
        public void GetSetCalendar()
        {
            //ExStart
            //ExFor: Prj.Calendar
            //ExFor: PrjKey.Calendar
            //ExSummary: Shows how to read/write Prj.Calendar property.
            var project = new Project();
            var calendar = project.Calendars.Add("Standard");
            Calendar.MakeStandardCalendar(calendar);

            project.Set(Prj.Calendar, calendar);

            Console.WriteLine("Calendar: " + project.Get(Prj.Calendar).Name);
            foreach (var weekDay in calendar.WeekDays)
            {
                Console.WriteLine(weekDay.FromDate);
                Console.WriteLine(weekDay.ToDate);
            }
            //ExEnd
        }

        [Test]
        public void GetSetCategory()
        {
            //ExStart
            //ExFor: Prj.Category
            //ExFor: PrjKey.Category
            //ExSummary: Shows how to read/write Prj.Category property.
            var project = new Project();

            project.Set(Prj.Category, "Special");

            Console.WriteLine("Category: " + project.Get(Prj.Category));
            //ExEnd
        }

        [Test]
        public void GetSetCompany()
        {
            //ExStart
            //ExFor: Prj.Company
            //ExFor: PrjKey.Company
            //ExSummary: Shows how to read/write Prj.Company property.
            var project = new Project();

            project.Set(Prj.Company, "Aspose");

            Console.WriteLine("Company: " + project.Get(Prj.Company));
            //ExEnd
        }

        [Test]
        public void GetSetCreationDate()
        {
            //ExStart
            //ExFor: Prj.CreationDate
            //ExFor: PrjKey.CreationDate
            //ExSummary: Shows how to read/write Prj.CreationDate property.
            var project = new Project();

            project.Set(Prj.CreationDate, new DateTime(2020, 4, 10, 8, 0, 0));

            Console.WriteLine("Creation Date: " + project.Get(Prj.CreationDate));
            //ExEnd
        }

        [Test]
        public void GetSetCriticalSlackLimit()
        {
            //ExStart
            //ExFor: Prj.CriticalSlackLimit
            //ExFor: PrjKey.CriticalSlackLimit
            //ExSummary: Shows how to read/write Prj.CriticalSlackLimit property.
            var project = new Project();

            project.Set(Prj.CriticalSlackLimit, 2);

            Console.WriteLine("Critical Slack Limit: " + project.Get(Prj.CriticalSlackLimit));
            //ExEnd
        }

        [Test]
        public void GetSetCurrentDate()
        {
            //ExStart
            //ExFor: Prj.CurrentDate
            //ExFor: PrjKey.CurrentDate
            //ExSummary: Shows how to read/write Prj.CurrentDate property.
            var project = new Project();

            project.Set(Prj.CurrentDate, new DateTime(2020, 4, 10, 8, 0, 0));

            Console.WriteLine("Current Date: " + project.Get(Prj.CurrentDate));
            //ExEnd
        }

        [Test]
        public void GetSetCustomDateFormat()
        {
            //ExStart
            //ExFor: Prj.CustomDateFormat
            //ExFor: PrjKey.CustomDateFormat
            //ExSummary: Shows how to read/write Prj.CustomDateFormat property.
            var project = new Project();

            project.Set(Prj.CustomDateFormat, "dd MMMM yyyy H:mm");

            Console.WriteLine("Custom Date Format: " + project.Get(Prj.CustomDateFormat));
            //ExEnd
        }

        [Test]
        public void GetSetDateFormat()
        {
            //ExStart
            //ExFor: Prj.DateFormat
            //ExFor: PrjKey.DateFormat
            //ExSummary: Shows how to read/write Prj.DateFormat property.
            var project = new Project();

            project.Set(Prj.DateFormat, DateFormat.DateDd);

            Console.WriteLine("Date Format: " + project.Get(Prj.DateFormat));
            //ExEnd
        }

        [Test]
        public void GetSetDefaultFinishTime()
        {
            //ExStart
            //ExFor: Prj.DefaultFinishTime
            //ExFor: PrjKey.DefaultFinishTime
            //ExSummary: Shows how to read/write Prj.DefaultFinishTime property.
            var project = new Project();

            project.Set(Prj.DefaultFinishTime, new DateTime(2000, 1, 3, 10, 0, 0));

            Console.WriteLine("Default Finish Time: " + project.Get(Prj.DefaultFinishTime));
            //ExEnd
        }

        [Test]
        public void GetSetDurationFormat()
        {
            //ExStart
            //ExFor: Prj.DurationFormat
            //ExFor: PrjKey.DurationFormat
            //ExSummary: Shows how to read/write Prj.DurationFormat property.
            var project = new Project();

            project.Set(Prj.DurationFormat, TimeUnitType.Day);

            Console.WriteLine("Duration Format: " + project.Get(Prj.DurationFormat));
            //ExEnd
        }

        [Test]
        public void GetSetEarnedValueMethod()
        {
            //ExStart
            //ExFor: Prj.EarnedValueMethod
            //ExFor: PrjKey.EarnedValueMethod
            //ExSummary: Shows how to read/write Prj.EarnedValueMethod property.
            var project = new Project();

            project.Set(Prj.EarnedValueMethod, EarnedValueMethodType.PhysicalPercentComplete);

            Console.WriteLine("Earned Value Method: " + project.Get(Prj.EarnedValueMethod));
            //ExEnd
        }

        [Test]
        public void GetSetExtendedCreationDate()
        {
            //ExStart
            //ExFor: Prj.ExtendedCreationDate
            //ExFor: PrjKey.ExtendedCreationDate
            //ExSummary: Shows how to read/write Prj.ExtendedCreationDate property.
            var project = new Project();

            project.Set(Prj.ExtendedCreationDate, new DateTime(2020, 4, 10, 9, 0, 0));

            Console.WriteLine("Extended Creation Date: " + project.Get(Prj.ExtendedCreationDate));
            //ExEnd
        }

        [Test]
        public void GetSetGuid()
        {
            //ExStart
            //ExFor: Prj.Guid
            //ExFor: PrjKey.Guid
            //ExSummary: Shows how to read/write Prj.Guid property.
            var project = new Project();

            project.Set(Prj.Guid, new Guid("efcc0d63-d8e0-4a34-9f3e-9f973f50238a"));

            Console.WriteLine("Guid: " + project.Get(Prj.Guid));
            //ExEnd
        }

        [Test]
        public void GetSetHonorConstraints()
        {
            //ExStart
            //ExFor: Prj.HonorConstraints
            //ExFor: PrjKey.HonorConstraints
            //ExSummary: Shows how to read/write Prj.HonorConstraints property.
            var project = new Project();

            project.Set(Prj.HonorConstraints, true);

            Console.WriteLine("Honor Constraints: " + project.Get(Prj.HonorConstraints));
            //ExEnd
        }

        [Test]
        public void GetSetHyperlinkBase()
        {
            //ExStart
            //ExFor: Prj.HyperlinkBase
            //ExFor: PrjKey.HyperlinkBase
            //ExSummary: Shows how to read/write Prj.HyperlinkBase property.
            var project = new Project();

            project.Set(Prj.HyperlinkBase, "www.aspose.com");

            Console.WriteLine("Hyperlink Base: " + project.Get(Prj.HyperlinkBase));
            //ExEnd
        }

        [Test]
        public void GetSetInsertedProjectsLikeSummary()
        {
            //ExStart
            //ExFor: Prj.InsertedProjectsLikeSummary
            //ExFor: PrjKey.InsertedProjectsLikeSummary
            //ExSummary: Shows how to read/write Prj.InsertedProjectsLikeSummary property.
            var project = new Project();

            project.Set(Prj.InsertedProjectsLikeSummary, true);

            Console.WriteLine("Inserted Projects Like Summary: " + project.Get(Prj.InsertedProjectsLikeSummary));
            //ExEnd
        }

        [Test]
        public void GetSetKeepTaskOnNearestWorkingTimeWhenMadeAutoScheduled()
        {
            //ExStart
            //ExFor: Prj.KeepTaskOnNearestWorkingTimeWhenMadeAutoScheduled
            //ExFor: PrjKey.KeepTaskOnNearestWorkingTimeWhenMadeAutoScheduled
            //ExSummary: Shows how to read/write Prj.KeepTaskOnNearestWorkingTimeWhenMadeAutoScheduled property.
            var project = new Project();

            project.Set(Prj.KeepTaskOnNearestWorkingTimeWhenMadeAutoScheduled, true);

            Console.WriteLine("Keep Task On Nearest Working Time When Made Auto Scheduled: " + project.Get(Prj.KeepTaskOnNearestWorkingTimeWhenMadeAutoScheduled));
            //ExEnd
        }

        [Test]
        public void GetSetLastPrinted()
        {
            //ExStart
            //ExFor: Prj.LastPrinted
            //ExFor: PrjKey.LastPrinted
            //ExSummary: Shows how to read/write Prj.LastPrinted property.
            var project = new Project();

            project.Set(Prj.LastPrinted, new DateTime(2020, 4, 10, 13, 0, 0));

            Console.WriteLine("Last Printed: " + project.Get(Prj.LastPrinted));
            //ExEnd
        }

        [Test]
        public void GetSetManager()
        {
            //ExStart
            //ExFor: Prj.Manager
            //ExFor: PrjKey.Manager
            //ExSummary: Shows how to read/write Prj.Manager property.
            var project = new Project();

            project.Set(Prj.Manager, "Steve");

            Console.WriteLine("Manager: " + project.Get(Prj.Manager));
            //ExEnd
        }

        [Test]
        public void GetSetMicrosoftProjectServerURL()
        {
            //ExStart
            //ExFor: Prj.MicrosoftProjectServerURL
            //ExFor: PrjKey.MicrosoftProjectServerURL
            //ExSummary: Shows how to read/write Prj.MicrosoftProjectServerURL property.
            var project = new Project();

            project.Set(Prj.MicrosoftProjectServerURL, true);

            Console.WriteLine("Microsoft Project Server U R L: " + project.Get(Prj.MicrosoftProjectServerURL));
            //ExEnd
        }

        [Test]
        public void GetSetMoveCompletedEndsBack()
        {
            //ExStart
            //ExFor: Prj.MoveCompletedEndsBack
            //ExFor: PrjKey.MoveCompletedEndsBack
            //ExSummary: Shows how to read/write Prj.MoveCompletedEndsBack property.
            var project = new Project();

            project.Set(Prj.MoveCompletedEndsBack, true);

            Console.WriteLine("Move Completed Ends Back: " + project.Get(Prj.MoveCompletedEndsBack));
            //ExEnd
        }

        [Test]
        public void GetSetMoveCompletedEndsForward()
        {
            //ExStart
            //ExFor: Prj.MoveCompletedEndsForward
            //ExFor: PrjKey.MoveCompletedEndsForward
            //ExSummary: Shows how to read/write Prj.MoveCompletedEndsForward property.
            var project = new Project();

            project.Set(Prj.MoveCompletedEndsForward, true);

            Console.WriteLine("Move Completed Ends Forward: " + project.Get(Prj.MoveCompletedEndsForward));
            //ExEnd
        }

        [Test]
        public void GetSetMoveRemainingStartsBack()
        {
            //ExStart
            //ExFor: Prj.MoveRemainingStartsBack
            //ExFor: PrjKey.MoveRemainingStartsBack
            //ExSummary: Shows how to read/write Prj.MoveRemainingStartsBack property.
            var project = new Project();

            project.Set(Prj.MoveRemainingStartsBack, true);

            Console.WriteLine("Move Remaining Starts Back: " + project.Get(Prj.MoveRemainingStartsBack));
            //ExEnd
        }

        [Test]
        public void GetSetMoveRemainingStartsForward()
        {
            //ExStart
            //ExFor: Prj.MoveRemainingStartsForward
            //ExFor: PrjKey.MoveRemainingStartsForward
            //ExSummary: Shows how to read/write Prj.MoveRemainingStartsForward property.
            var project = new Project();

            project.Set(Prj.MoveRemainingStartsForward, true);

            Console.WriteLine("Move Remaining Starts Forward: " + project.Get(Prj.MoveRemainingStartsForward));
            //ExEnd
        }

        [Test]
        public void GetSetMultipleCriticalPaths()
        {
            //ExStart
            //ExFor: Prj.MultipleCriticalPaths
            //ExFor: PrjKey.MultipleCriticalPaths
            //ExSummary: Shows how to read/write Prj.MultipleCriticalPaths property.
            var project = new Project();

            project.Set(Prj.MultipleCriticalPaths, true);

            Console.WriteLine("Multiple Critical Paths: " + project.Get(Prj.MultipleCriticalPaths));
            //ExEnd
        }

        [Test]
        public void GetSetNewTasksAreManual()
        {
            //ExStart
            //ExFor: Prj.NewTasksAreManual
            //ExFor: PrjKey.NewTasksAreManual
            //ExSummary: Shows how to read/write Prj.NewTasksAreManual property.
            var project = new Project();

            project.Set(Prj.NewTasksAreManual, true);

            Console.WriteLine("New Tasks Are Manual: " + project.Get(Prj.NewTasksAreManual));
            //ExEnd
        }

        [Test]
        public void GetSetNewTasksEffortDriven()
        {
            //ExStart
            //ExFor: Prj.NewTasksEffortDriven
            //ExFor: PrjKey.NewTasksEffortDriven
            //ExSummary: Shows how to read/write Prj.NewTasksEffortDriven property.
            var project = new Project();

            project.Set(Prj.NewTasksEffortDriven, true);

            Console.WriteLine("New Tasks Effort Driven: " + project.Get(Prj.NewTasksEffortDriven));
            //ExEnd
        }

        [Test]
        public void GetSetNewTasksEstimated()
        {
            //ExStart
            //ExFor: Prj.NewTasksEstimated
            //ExFor: PrjKey.NewTasksEstimated
            //ExSummary: Shows how to read/write Prj.NewTasksEstimated property.
            var project = new Project();

            project.Set(Prj.NewTasksEstimated, true);

            Console.WriteLine("New Tasks Estimated: " + project.Get(Prj.NewTasksEstimated));
            //ExEnd
        }

        [Test]
        public void GetSetProjectExternallyEdited()
        {
            //ExStart
            //ExFor: Prj.ProjectExternallyEdited
            //ExFor: PrjKey.ProjectExternallyEdited
            //ExSummary: Shows how to read/write Prj.ProjectExternallyEdited property.
            var project = new Project();

            project.Set(Prj.ProjectExternallyEdited, true);

            Console.WriteLine("Project Externally Edited: " + project.Get(Prj.ProjectExternallyEdited));
            //ExEnd
        }

        [Test]
        public void GetSetRemoveFileProperties()
        {
            //ExStart
            //ExFor: Prj.RemoveFileProperties
            //ExFor: PrjKey.RemoveFileProperties
            //ExSummary: Shows how to read/write Prj.RemoveFileProperties property.
            var project = new Project();

            project.Set(Prj.RemoveFileProperties, true);

            Console.WriteLine("Remove File Properties: " + project.Get(Prj.RemoveFileProperties));
            //ExEnd
        }

        [Test]
        public void GetSetShowProjectSummaryTask()
        {
            //ExStart
            //ExFor: Prj.ShowProjectSummaryTask
            //ExFor: PrjKey.ShowProjectSummaryTask
            //ExSummary: Shows how to read/write Prj.ShowProjectSummaryTask property.
            var project = new Project();

            project.Set(Prj.ShowProjectSummaryTask, true);

            Console.WriteLine("Show Project Summary Task: " + project.Get(Prj.ShowProjectSummaryTask));
            //ExEnd
        }

        [Test]
        public void GetSetSplitsInProgressTasks()
        {
            //ExStart
            //ExFor: Prj.SplitsInProgressTasks
            //ExFor: PrjKey.SplitsInProgressTasks
            //ExSummary: Shows how to read/write Prj.SplitsInProgressTasks property.
            var project = new Project();

            project.Set(Prj.SplitsInProgressTasks, true);

            Console.WriteLine("Splits In Progress Tasks: " + project.Get(Prj.SplitsInProgressTasks));
            //ExEnd
        }

        [Test]
        public void GetSetSpreadActualCost()
        {
            //ExStart
            //ExFor: Prj.SpreadActualCost
            //ExFor: PrjKey.SpreadActualCosts
            //ExSummary: Shows how to read/write Prj.SpreadActualCost property.
            var project = new Project();

            project.Set(Prj.SpreadActualCost, true);

            Console.WriteLine("Spread Actual Cost: " + project.Get(Prj.SpreadActualCost));
            //ExEnd
        }

        [Test]
        public void GetSetSpreadPercentComplete()
        {
            //ExStart
            //ExFor: Prj.SpreadPercentComplete
            //ExFor: PrjKey.SpreadPercentComplete
            //ExSummary: Shows how to read/write Prj.SpreadPercentComplete property.
            var project = new Project();

            project.Set(Prj.SpreadPercentComplete, true);

            Console.WriteLine("Spread Percent Complete: " + project.Get(Prj.SpreadPercentComplete));
            //ExEnd
        }

        [Test]
        public void GetSetStartDate()
        {
            //ExStart
            //ExFor: Prj.StartDate
            //ExFor: PrjKey.StartDate
            //ExSummary: Shows how to read/write Prj.StartDate property.
            var project = new Project();

            project.Set(Prj.StartDate, new DateTime(2020, 4, 19, 8, 0, 0));

            Console.WriteLine("Start Date: " + project.Get(Prj.StartDate));
            //ExEnd
        }

        [Test]
        public void GetSetStatusDate()
        {
            //ExStart
            //ExFor: Prj.StatusDate
            //ExFor: PrjKey.StatusDate
            //ExSummary: Shows how to read/write Prj.StatusDate property.
            var project = new Project();

            project.Set(Prj.StatusDate, new DateTime(2020, 4, 19, 8, 0, 0));

            Console.WriteLine("Status Date: " + project.Get(Prj.StatusDate));
            //ExEnd
        }

        [Test]
        public void GetSetSubject()
        {
            //ExStart
            //ExFor: Prj.Subject
            //ExFor: PrjKey.Subject
            //ExSummary: Shows how to read/write Prj.Subject property.
            var project = new Project();

            project.Set(Prj.Subject, "Subject");

            Console.WriteLine("Subject: " + project.Get(Prj.Subject));
            //ExEnd
        }

        [Test]
        public void GetSetTaskUpdatesResource()
        {
            //ExStart
            //ExFor: Prj.TaskUpdatesResource
            //ExFor: PrjKey.TaskUpdatesResource
            //ExSummary: Shows how to read/write Prj.TaskUpdatesResource property.
            var project = new Project();

            project.Set(Prj.TaskUpdatesResource, true);

            Console.WriteLine("Task Updates Resource: " + project.Get(Prj.TaskUpdatesResource));
            //ExEnd
        }

        [Test]
        public void GetSetTemplate()
        {
            //ExStart
            //ExFor: Prj.Template
            //ExFor: PrjKey.Template
            //ExSummary: Shows how to read/write Prj.Template property.
            var project = new Project();

            project.Set(Prj.Template, "Custom Template");

            Console.WriteLine("Template: " + project.Get(Prj.Template));
            //ExEnd
        }

        [Test]
        public void GetSetTimescaleFinish()
        {
            //ExStart
            //ExFor: Prj.TimescaleFinish
            //ExFor: PrjKey.TimescaleFinish
            //ExSummary: Shows how to read/write Prj.TimescaleFinish property.
            var project = new Project();

            project.Set(Prj.TimescaleFinish, new DateTime(2020, 4, 10, 9, 0, 0));

            Console.WriteLine("Timescale Finish: " + project.Get(Prj.TimescaleFinish));
            //ExEnd
        }

        [Test]
        public void GetSetTitle()
        {
            //ExStart
            //ExFor: Prj.Title
            //ExFor: PrjKey.Title
            //ExSummary: Shows how to read/write Prj.Title property.
            var project = new Project();

            project.Set(Prj.Title, "MS Project");

            Console.WriteLine("Title: " + project.Get(Prj.Title));
            //ExEnd
        }

        [Test]
        public void GetSetUid()
        {
            //ExStart
            //ExFor: Prj.Uid
            //ExFor: PrjKey.Uid
            //ExSummary: Shows how to read/write Prj.Uid property.
            var project = new Project();

            project.Set(Prj.Uid, "1234");

            Console.WriteLine("Uid: " + project.Get(Prj.Uid));
            //ExEnd
        }

        [Test]
        public void GetSetUpdateManuallyScheduledTasksWhenEditingLinks()
        {
            //ExStart
            //ExFor: Prj.UpdateManuallyScheduledTasksWhenEditingLinks
            //ExFor: PrjKey.UpdateManuallyScheduledTasksWhenEditingLinks
            //ExSummary: Shows how to read/write Prj.UpdateManuallyScheduledTasksWhenEditingLinks property.
            var project = new Project();

            project.Set(Prj.UpdateManuallyScheduledTasksWhenEditingLinks, true);

            Console.WriteLine("Update Manually Scheduled Tasks When Editing Links: " + project.Get(Prj.UpdateManuallyScheduledTasksWhenEditingLinks));
            //ExEnd
        }
        
        [Test]
        public void GetSetProjectName()
        {
            //ExStart
            //ExFor: Prj
            //ExFor: Prj.Name
            //ExFor: PrjKey.Name
            //ExSummary: Shows how to read/write project name.
            var project = new Project(DataDir + "Blank2010.mpp");

            project.Set(Prj.Name, "Custom Project Name");
            
            Console.WriteLine("Project name: " + project.Get(Prj.Name));
            //ExEnd
        }
        
        [Test]
        public void GetSetWorkFormatFormat()
        {
            //ExStart
            //ExFor: Prj.WorkFormat
            //ExFor: PrjKey.WorkFormat
            //ExSummary: Shows how to get a duration with default work format.
            var project = new Project(DataDir + "Blank2010.mpp");

            Console.WriteLine("Project's work format: " + project.Get(Prj.WorkFormat));

            // create a work value with project's default work format
            var work = project.GetWork(2);
            Console.WriteLine("Work: " + work.TimeSpan);
            Console.WriteLine("Time unit: " + work.TimeUnit);
            //ExEnd
        }
        
        [Test]
        public void SetGanttChartViewStartDate()
        {            
            //ExStart
            //ExFor: Prj.TimescaleStart
            //ExFor: PrjKey.TimescaleStart
            //ExSummary: Shows how to set timescale start date to tune the date where the view should start.
            var project = new Project(DataDir + "Project2.mpp");
            project.Set(Prj.TimescaleStart, new DateTime(2012, 4, 30));

            Console.WriteLine("Timescale Start: " + project.Get(Prj.TimescaleStart));
            //ExEnd
        }
        
        [Test]
        public void RescheduleProjectFromFinishDate()
        {
            //ExStart:RescheduleProjectFromFinishDate
            //ExFor: Prj.ScheduleFromStart
            //ExFor: Prj.FinishDate
            //ExFor: PrjKey.ScheduleFromStart
            //ExFor: PrjKey.FinishDate
            //ExSummary: Shows how to reschedule the project from finish date instead of the start one.
            var project = new Project(DataDir + "Project2.mpp");
            project.Set(Prj.ScheduleFromStart, false);
            project.Set(Prj.FinishDate, new DateTime(2020, 1, 1));

            // Now all tasks dates (Start, Finish, EarlyStart, EarlyFinish, LateStart, LateFinish) are calculated. To get the critical path we need to calculate slacks (can be invoked in separate thread, but only after calculation of all early/late dates)
            project.Recalculate();

            foreach (var task in project.CriticalPath)
            {
                Console.WriteLine(task.Get(Tsk.Id));
                Console.WriteLine(task.Get(Tsk.Name));
            }
            //ExEnd:RescheduleProjectFromFinishDate
        }
        
        [Test]
        public void DetermineProjectVersion()
        {
            //ExStart:DetermineProjectVersion
            //ExFor: Prj.LastSaved
            //ExFor: Prj.SaveVersion
            //ExFor: PrjKey.LastSaved
            //ExFor: PrjKey.SaveVersion
            //ExSummary: Shows how to check project's save version and save date.
            var project = new Project(DataDir + "DetermineProjectVersion.mpp");

            // Display project version
            Console.WriteLine("Project Version : " + project.Get(Prj.SaveVersion));
            Console.WriteLine("Last Saved : " + project.Get(Prj.LastSaved).ToShortDateString());
            //ExEnd:DetermineProjectVersion
        }
        
        [Test]
        public void ReadWriteCurrencyProperties()
        {
            //ExStart:ReadWriteCurrencyProperties
            //ExFor: Prj.CurrencyCode
            //ExFor: Prj.CurrencyDigits
            //ExFor: Prj.CurrencySymbol
            //ExFor: Prj.CurrencySymbolPosition
            //ExFor: PrjKey.CurrencyCode
            //ExFor: PrjKey.CurrencyDigits
            //ExFor: PrjKey.CurrencySymbol
            //ExFor: PrjKey.CurrencySymbolPosition
            //ExSummary: Shows how to write project's currency properties.
            var project = new Project(DataDir + "WriteCurrencyProperties.mpp");

            // Set currency properties
            project.Set(Prj.CurrencyCode, "AUD");
            project.Set(Prj.CurrencyDigits, 2);
            project.Set(Prj.CurrencySymbol, "$");
            project.Set(Prj.CurrencySymbolPosition, CurrencySymbolPositionType.After);
            
            // Display currency properties
            Console.WriteLine("Currency Code: " + project.Get(Prj.CurrencyCode));
            Console.WriteLine("Currency Digits: " + project.Get(Prj.CurrencyDigits));
            Console.WriteLine("Currency Symbol: " + project.Get(Prj.CurrencySymbol));
            Console.WriteLine("Currency Symbol Position: " + project.Get(Prj.CurrencySymbolPosition));

            project.Save(OutDir + "WriteCurrencyProperties_out.xml", SaveFileFormat.XML);
            //ExEnd:ReadWriteCurrencyProperties
        }
        
        [Test]
        public void ReadWriteProjectInfo()
        {    
            //ExStart:ReadWriteProjectInfo
            //ExFor: Prj.Author
            //ExFor: Prj.LastAuthor
            //ExFor: Prj.Revision
            //ExFor: Prj.Keywords
            //ExFor: Prj.Comments
            //ExFor: PrjKey.Author
            //ExFor: PrjKey.LastAuthor
            //ExFor: PrjKey.Revision
            //ExFor: PrjKey.Keywords
            //ExFor: PrjKey.Comments
            //ExSummary: Shows how to set project meta information.
            var project = new Project(DataDir + "WriteProjectInfo.mpp");
            
            // Set project information
            project.Set(Prj.Author, "Author");
            project.Set(Prj.LastAuthor, "Last Author");
            project.Set(Prj.Revision, 15);
            project.Set(Prj.Keywords, "MSP Aspose");
            project.Set(Prj.Comments, "Comments");
            
            Console.WriteLine(project.Get(Prj.Author));
            Console.WriteLine(project.Get(Prj.LastAuthor));
            Console.WriteLine(project.Get(Prj.Revision));
            Console.WriteLine(project.Get(Prj.Keywords));
            Console.WriteLine(project.Get(Prj.Comments));
            //ExEnd:ReadWriteProjectInfo
        }
        
        [Test]
        public void ReadWriteWeekdayProperties()
        {
            //ExStart:ReadWriteWeekdayProperties
            //ExFor: Prj.WeekStartDay
            //ExFor: Prj.DaysPerMonth
            //ExFor: Prj.MinutesPerDay
            //ExFor: Prj.MinutesPerWeek
            //ExFor: PrjKey.WeekStartDay
            //ExFor: PrjKey.DaysPerMonth
            //ExFor: PrjKey.MinutesPerDay
            //ExFor: PrjKey.MinutesPerWeek
            //ExSummary: Shows how to read/write project's weekday properties.
            var project = new Project(DataDir + "WriteWeekdayProperties.mpp");

            // Set week days properties
            project.Set(Prj.WeekStartDay, DayType.Monday);
            project.Set(Prj.DaysPerMonth, 24);
            project.Set(Prj.MinutesPerDay, 540);
            project.Set(Prj.MinutesPerWeek, 3240);

            // Display week days properties
            Console.WriteLine("Week Start Date: " + project.Get(Prj.WeekStartDay));
            Console.WriteLine("Days Per Month: " + project.Get(Prj.DaysPerMonth));
            Console.WriteLine("Minutes Per Day: " + project.Get(Prj.MinutesPerDay));
            Console.WriteLine("Minutes Per Week: " + project.Get(Prj.MinutesPerWeek));
            //ExEnd:ReadWriteWeekdayProperties            
        }
        
        [Test]
        public void ReadWriteFiscalYearProperties()
        {
            //ExStart:ReadWriteFiscalYearProperties
            //ExFor: Prj.FyStartDate
            //ExFor: Prj.FiscalYearStart
            //ExFor: PrjKey.FyStartDate
            //ExFor: PrjKey.FiscalYearStart
            //ExSummary: Shows how to write fiscal year properties. 
            var project = new Project(DataDir + "WriteFiscalYearProperties.mpp");

            // Set fiscal year properties
            project.Set(Prj.FyStartDate, Month.July);
            project.Set(Prj.FiscalYearStart, true);
            
            // Display fiscal year properties
            Console.WriteLine("Fiscal Year Start Date: " + project.Get(Prj.FyStartDate));
            Console.WriteLine("Fiscal Year Numbering: " + project.Get(Prj.FiscalYearStart));
            //ExEnd:ReadWriteFiscalYearProperties
        }
        
        [Test]
        public void ReadWriteDefaultProperties()
        {
            //ExStart:ReadWriteDefaultProperties
            //ExFor: Prj.DefaultStartTime
            //ExFor: Prj.DefaultTaskType
            //ExFor: Prj.DefaultStandardRate
            //ExFor: Prj.DefaultOvertimeRate
            //ExFor: Prj.DefaultTaskEVMethod
            //ExFor: Prj.DefaultFixedCostAccrual
            //ExFor: PrjKey.DefaultStartTime
            //ExFor: PrjKey.DefaultTaskType
            //ExFor: PrjKey.DefaultStandardRate
            //ExFor: PrjKey.DefaultOvertimeRate
            //ExFor: PrjKey.DefaultTaskEVMethod
            //ExFor: PrjKey.DefaultFixedCostAccrual
            //ExSummary: Shows how to read project's default properties.
            var project = new Project(DataDir + "DefaultProperties.mpp");
            
            // Set default properties
            project.Set(Prj.ScheduleFromStart, true);
            project.Set(Prj.StartDate, DateTime.Now);
            project.Set(Prj.DefaultStartTime, project.Get(Prj.StartDate));
            project.Set(Prj.DefaultTaskType, TaskType.FixedDuration);
            project.Set(Prj.DefaultStandardRate, 15);
            project.Set(Prj.DefaultOvertimeRate, 12);
            project.Set(Prj.DefaultTaskEVMethod, EarnedValueMethodType.PercentComplete);
            project.Set(Prj.DefaultFixedCostAccrual, CostAccrualType.Prorated);

            // Display default properties
            Console.WriteLine("New Task Default Start: " + project.Get(Prj.DefaultStartTime).ToShortDateString());
            Console.WriteLine("New Task Default Type: " + project.Get(Prj.DefaultTaskType));
            Console.WriteLine("Resource Default Standard Rate: " + project.Get(Prj.DefaultStandardRate));
            Console.WriteLine("Resource Default Overtime Rate: " + project.Get(Prj.DefaultOvertimeRate));
            Console.WriteLine("Default Task EV Method: " + project.Get(Prj.DefaultTaskEVMethod));
            Console.WriteLine("Default Cost Accrual: " + project.Get(Prj.DefaultFixedCostAccrual));
            //ExEnd:ReadWriteDefaultProperties
        }
        
        [Test]
        public void PrjNewTaskStartDate()
        {
            //ExStart:SetAttributesForNewTasks
            //ExFor: PrjKey
            //ExFor: Prj.NewTaskStartDate
            //ExFor: PrjKey.NewTaskStartDate
            //ExSummary: Shows how to set attributes for new tasks.
            var project = new Project();
            project.Set(Prj.NewTaskStartDate, TaskStartDateType.CurrentDate);

            Console.WriteLine("New Task Start Date: " + project.Get(Prj.NewTaskStartDate));
            //ExEnd:SetAttributesForNewTasks
        }
    }
}