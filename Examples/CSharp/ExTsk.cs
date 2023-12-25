﻿namespace Aspose.Tasks.Examples.CSharp
{
    using System;
    using NUnit.Framework;
    using Saving;
    using Util;
    using Visualization;

    [TestFixture]
    public class ExTsk : ApiExampleBase
    {
        [Test]
        public void GetSetActualOvertimeCost()
        {
            // ExStart
            // ExFor: Tsk.ActualOvertimeCost
            // ExSummary: Shows how to read/write Tsk.ActualOvertimeCost property.
            var project = new Project();

            var task = project.RootTask.Children.Add("Task");

            task.Set(Tsk.ActualOvertimeCost, 10m);

            Console.WriteLine("Actual Overtime Cost: " + task.Get(Tsk.ActualOvertimeCost));

            // ExEnd
        }

        [Test]
        public void GetSetActualOvertimeWork()
        {
            // ExStart
            // ExFor: Tsk.ActualOvertimeWork
            // ExSummary: Shows how to read/write Tsk.ActualOvertimeWork property.
            var project = new Project();
            project.Set(Prj.WorkFormat, TimeUnitType.Day);

            var task = project.RootTask.Children.Add("Task");

            task.Set(Tsk.ActualOvertimeWork, project.GetWork(1));

            Console.WriteLine("Actual Overtime Work: " + task.Get(Tsk.ActualOvertimeWork));

            // ExEnd
        }

        [Test]
        public void GetSetActualOvertimeWorkProtected()
        {
            // ExStart
            // ExFor: Tsk.ActualOvertimeWorkProtected
            // ExSummary: Shows how to read/write Tsk.ActualOvertimeWorkProtected property.
            var project = new Project();
            project.Set(Prj.WorkFormat, TimeUnitType.Day);

            var task = project.RootTask.Children.Add("Task");

            task.Set(Tsk.ActualOvertimeWorkProtected, project.GetWork(1));

            Console.WriteLine("Actual Overtime Work Protected: " + task.Get(Tsk.ActualOvertimeWorkProtected));

            // ExEnd
        }

        [Test]
        public void GetSetActualWork()
        {
            // ExStart
            // ExFor: Tsk.ActualWork
            // ExSummary: Shows how to read/write Tsk.ActualWork property.
            var project = new Project();
            project.Set(Prj.WorkFormat, TimeUnitType.Day);

            var task = project.RootTask.Children.Add("Task");

            task.Set(Tsk.ActualWork, project.GetWork(1));

            Console.WriteLine("Actual Work: " + task.Get(Tsk.ActualWork));

            // ExEnd
        }

        [Test]
        public void GetSetActualWorkProtected()
        {
            // ExStart
            // ExFor: Tsk.ActualWorkProtected
            // ExSummary: Shows how to read/write Tsk.ActualWorkProtected property.
            var project = new Project();
            project.Set(Prj.WorkFormat, TimeUnitType.Day);

            var task = project.RootTask.Children.Add("Task");

            task.Set(Tsk.ActualWorkProtected, project.GetWork(1));

            Console.WriteLine("Actual Work Protected: " + task.Get(Tsk.ActualWorkProtected));

            // ExEnd
        }

        [Test]
        public void GetSetCommitmentFinish()
        {
            // ExStart
            // ExFor: Tsk.CommitmentFinish
            // ExSummary: Shows how to read/write Tsk.CommitmentFinish property.
            var project = new Project();

            var task = project.RootTask.Children.Add("Task");

            task.Set(Tsk.CommitmentFinish, new DateTime(2020, 4, 10, 8, 0, 0));

            Console.WriteLine("Commitment Finish: " + task.Get(Tsk.CommitmentFinish));

            // ExEnd
        }

        [Test]
        public void GetSetCommitmentStart()
        {
            // ExStart
            // ExFor: Tsk.CommitmentStart
            // ExSummary: Shows how to read/write Tsk.CommitmentStart property.
            var project = new Project();

            var task = project.RootTask.Children.Add("Task");

            task.Set(Tsk.CommitmentStart, new DateTime(2020, 4, 10, 8, 0, 0));

            Console.WriteLine("Commitment Start: " + task.Get(Tsk.CommitmentStart));

            // ExEnd
        }

        [Test]
        public void GetSetCommitmentType()
        {
            // ExStart
            // ExFor: Tsk.CommitmentType
            // ExSummary: Shows how to read/write Tsk.CommitmentType property.
            var project = new Project();

            var task = project.RootTask.Children.Add("Task");

            task.Set(Tsk.CommitmentType, 2);

            Console.WriteLine("Commitment Type: " + task.Get(Tsk.CommitmentType));

            // ExEnd
        }

        [Test]
        public void GetSetContact()
        {
            // ExStart
            // ExFor: Tsk.Contact
            // ExSummary: Shows how to read/write Tsk.Contact property.
            var project = new Project();

            var task = project.RootTask.Children.Add("Task");

            task.Set(Tsk.Contact, "John Smith");

            Console.WriteLine("Contact: " + task.Get(Tsk.Contact));

            // ExEnd
        }

        [Test]
        public void GetSetCreated()
        {
            // ExStart
            // ExFor: Tsk.Created
            // ExSummary: Shows how to read/write Tsk.Created property.
            var project = new Project();

            var task = project.RootTask.Children.Add("Task");

            task.Set(Tsk.Created, new DateTime(2020, 4, 10, 8, 0, 0));

            Console.WriteLine("Created: " + task.Get(Tsk.Created));

            // ExEnd
        }

        [Test]
        public void GetSetDeadline()
        {
            // ExStart
            // ExFor: Tsk.Deadline
            // ExSummary: Shows how to read/write Tsk.Deadline property.
            var project = new Project();

            var task = project.RootTask.Children.Add("Task");

            task.Set(Tsk.Deadline, new DateTime(2020, 4, 10, 8, 0, 0));

            Console.WriteLine("Deadline: " + task.Get(Tsk.Deadline));

            // ExEnd
        }

        [Test]
        public void GetSetDisplayAsSummary()
        {
            // ExStart
            // ExFor: Tsk.DisplayAsSummary
            // ExSummary: Shows how to read/write Tsk.DisplayAsSummary property.
            var project = new Project();

            var task = project.RootTask.Children.Add("Task");

            task.Set(Tsk.DisplayAsSummary, true);

            Console.WriteLine("Display As Summary: " + task.Get(Tsk.DisplayAsSummary));

            // ExEnd
        }

        [Test]
        public void GetSetDisplayOnTimeline()
        {
            // ExStart
            // ExFor: Tsk.DisplayOnTimeline
            // ExSummary: Shows how to read/write Tsk.DisplayOnTimeline property.
            var project = new Project();

            var task = project.RootTask.Children.Add("Task");

            task.Set(Tsk.DisplayOnTimeline, true);

            Console.WriteLine("Display On Timeline: " + task.Get(Tsk.DisplayOnTimeline));

            // ExEnd
        }

        [Test]
        public void GetSetDurationText()
        {
            // ExStart
            // ExFor: Tsk.DurationText
            // ExSummary: Shows how to read/write Tsk.DurationText property.
            var project = new Project();

            var task = project.RootTask.Children.Add("Task");

            task.Set(Tsk.DurationText, "Not A Duration");

            Console.WriteLine("Duration Text: " + task.Get(Tsk.DurationText));

            // ExEnd
        }

        [Test]
        public void GetSetDurationVariance()
        {
            // ExStart
            // ExFor: Tsk.DurationVariance
            // ExSummary: Shows how to read/write Tsk.DurationVariance property.
            var project = new Project();
            project.Set(Prj.WorkFormat, TimeUnitType.Hour);

            var task = project.RootTask.Children.Add("Task");

            task.Set(Tsk.DurationVariance, project.GetWork(1));

            Console.WriteLine("Duration Variance: " + task.Get(Tsk.DurationVariance));

            // ExEnd
        }

        [Test]
        public void GetSetEarlyFinish()
        {
            // ExStart
            // ExFor: Tsk.EarlyFinish
            // ExSummary: Shows how to read/write Tsk.EarlyFinish property.
            var project = new Project();

            var task = project.RootTask.Children.Add("Task");

            task.Set(Tsk.EarlyFinish, new DateTime(2020, 4, 10, 8, 0, 0));

            Console.WriteLine("Early Finish: " + task.Get(Tsk.EarlyFinish));

            // ExEnd
        }

        [Test]
        public void GetSetEarlyStart()
        {
            // ExStart
            // ExFor: Tsk.EarlyStart
            // ExSummary: Shows how to read/write Tsk.EarlyStart property.
            var project = new Project();

            var task = project.RootTask.Children.Add("Task");

            task.Set(Tsk.EarlyStart, new DateTime(2020, 4, 10, 8, 0, 0));

            Console.WriteLine("Early Start: " + task.Get(Tsk.EarlyStart));

            // ExEnd
        }

        [Test]
        public void GetSetEarnedValueMethod()
        {
            // ExStart
            // ExFor: Tsk.EarnedValueMethod
            // ExSummary: Shows how to read/write Tsk.EarnedValueMethod property.
            var project = new Project();

            var task = project.RootTask.Children.Add("Task");

            task.Set(Tsk.EarnedValueMethod, EarnedValueMethodType.PercentComplete);

            Console.WriteLine("Earned Value Method: " + task.Get(Tsk.EarnedValueMethod));

            // ExEnd
        }

        [Test]
        public void GetSetFinishSlack()
        {
            // ExStart
            // ExFor: Tsk.FinishSlackTimeSpan
            // ExSummary: Shows how to read Tsk.FinishSlackTimeSpan property. The property is calculated, so usually there is no need to set it explicitly.
            var project = new Project();

            var task = project.RootTask.Children.Add("Task");

            Console.WriteLine("Finish Slack: " + task.Get(Tsk.FinishSlackTimeSpan));
            // ExEnd
        }

        [Test]
        public void GetSetFinishText()
        {
            // ExStart
            // ExFor: Tsk.FinishText
            // ExSummary: Shows how to read/write Tsk.FinishText property.
            var project = new Project();

            var task = project.RootTask.Children.Add("Task");

            task.Set(Tsk.FinishText, "Not A Finish");

            Console.WriteLine("Finish Text: " + task.Get(Tsk.FinishText));

            // ExEnd
        }

        [Test]
        public void GetSetFinishVariance()
        {
            // ExStart
            // ExFor: Tsk.FinishVariance
            // ExSummary: Shows how to read/write Tsk.FinishVariance property.
            var project = new Project();

            var task = project.RootTask.Children.Add("Task");

            task.Set(Tsk.FinishVariance, project.GetDuration(1, TimeUnitType.Hour));

            Console.WriteLine("Finish Variance: " + task.Get(Tsk.FinishVariance));

            // ExEnd
        }

        [Test]
        public void GetSetFixedCostAccrual()
        {
            // ExStart
            // ExFor: Tsk.FixedCostAccrual
            // ExSummary: Shows how to read/write Tsk.FixedCostAccrual property.
            var project = new Project();

            var task = project.RootTask.Children.Add("Task");

            task.Set(Tsk.FixedCostAccrual, CostAccrualType.Prorated);

            Console.WriteLine("Fixed Cost Accrual: " + task.Get(Tsk.FixedCostAccrual));

            // ExEnd
        }

        [Test]
        public void GetSetFreeSlack()
        {
            // ExStart
            // ExFor: Tsk.FreeSlackTimeSpan
            // ExSummary: Shows how to read Tsk.FreeSlackTimeSpan property. The property is calculated, so usually there is no need to set it explicitly.
            var project = new Project();

            var task = project.RootTask.Children.Add("Task");

            Console.WriteLine("Free Slack: " + task.Get(Tsk.FreeSlackTimeSpan));

            // ExEnd
        }

        [Test]
        public void GetSetGuid()
        {
            // ExStart
            // ExFor: Tsk.Guid
            // ExSummary: Shows how to read/write Tsk.Guid property.
            var project = new Project();

            var task = project.RootTask.Children.Add("Task");

            task.Set(Tsk.Guid, "60648d59-9c2b-4dc6-bfdb-bfd38f331d61");

            Console.WriteLine("Guid: " + task.Get(Tsk.Guid));

            // ExEnd
        }

        [Test]
        public void GetSetHideBar()
        {
            // ExStart
            // ExFor: Tsk.HideBar
            // ExSummary: Shows how to read/write Tsk.HideBar property.
            var project = new Project();

            var task = project.RootTask.Children.Add("Task");

            task.Set(Tsk.HideBar, true);

            Console.WriteLine("Hide Bar: " + task.Get(Tsk.HideBar));

            // ExEnd
        }

        [Test]
        public void GetSetHyperlinkProperties()
        {
            // ExStart
            // ExFor: Tsk.Hyperlink
            // ExFor: Tsk.HyperlinkAddress
            // ExFor: Tsk.HyperlinkSubAddress
            // ExSummary: Shows how to read/write Tsk.Hyperlink properties.
            var project = new Project();

            var task = project.RootTask.Children.Add("Task");

            task.Set(Tsk.Hyperlink, "Click here to visit our site");
            task.Set(Tsk.HyperlinkAddress, "https://products.aspose.com");
            task.Set(Tsk.HyperlinkSubAddress, "/total/net");

            Console.WriteLine("Hyperlink: " + task.Get(Tsk.Hyperlink));
            Console.WriteLine("Hyperlink Address: " + task.Get(Tsk.HyperlinkAddress));
            Console.WriteLine("Hyperlink Sub Address: " + task.Get(Tsk.HyperlinkSubAddress));

            // ExEnd
        }

        [Test]
        public void GetSetIgnoreResourceCalendar()
        {
            // ExStart
            // ExFor: Tsk.IgnoreResourceCalendar
            // ExSummary: Shows how to read/write Tsk.IgnoreResourceCalendar property.
            var project = new Project();

            var task = project.RootTask.Children.Add("Task");

            task.Set(Tsk.IgnoreResourceCalendar, true);

            Console.WriteLine("Ignore Resource Calendar: " + task.Get(Tsk.IgnoreResourceCalendar));

            // ExEnd
        }

        [Test]
        public void GetSetIgnoreWarnings()
        {
            // ExStart
            // ExFor: Tsk.IgnoreWarnings
            // ExSummary: Shows how to read/write Tsk.IgnoreWarnings property.
            var project = new Project();

            var task = project.RootTask.Children.Add("Task");

            task.Set(Tsk.IgnoreWarnings, true);

            Console.WriteLine("Ignore Warnings: " + task.Get(Tsk.IgnoreWarnings));

            // ExEnd
        }

        [Test]
        public void GetSetIsActive()
        {
            // ExStart
            // ExFor: Tsk.IsActive
            // ExSummary: Shows how to read/write Tsk.IsActive property.
            var project = new Project();

            var task = project.RootTask.Children.Add("Task");

            task.Set(Tsk.IsActive, true);

            Console.WriteLine("Is Active: " + task.Get(Tsk.IsActive));

            // ExEnd
        }

        [Test]
        public void GetSetIsExpanded()
        {
            // ExStart
            // ExFor: Tsk.IsExpanded
            // ExSummary: Shows how to read/write Tsk.IsExpanded property.
            var project = new Project();

            var task = project.RootTask.Children.Add("Task");

            task.Set(Tsk.IsExpanded, true);

            Console.WriteLine("Is Expanded: " + task.Get(Tsk.IsExpanded));

            // ExEnd
        }

        [Test]
        public void GetSetIsExternalTask()
        {
            // ExStart
            // ExFor: Tsk.IsExternalTask
            // ExSummary: Shows how to read/write Tsk.IsExternalTask property.
            var project = new Project();

            var task = project.RootTask.Children.Add("Task");

            task.Set(Tsk.IsExternalTask, true);

            Console.WriteLine("Is External Task: " + task.Get(Tsk.IsExternalTask));

            // ExEnd
        }

        [Test]
        public void GetSetIsManual()
        {
            // ExStart
            // ExFor: Tsk.IsManual
            // ExSummary: Shows how to read/write Tsk.IsManual property.
            var project = new Project();

            var task = project.RootTask.Children.Add("Task");

            task.Set(Tsk.IsManual, true);

            Console.WriteLine("Is Manual: " + task.Get(Tsk.IsManual));

            // ExEnd
        }

        [Test]
        public void GetSetIsMarked()
        {
            // ExStart
            // ExFor: Tsk.IsMarked
            // ExSummary: Shows how to read/write Tsk.IsMarked property.
            var project = new Project();

            var task = project.RootTask.Children.Add("Task");

            task.Set(Tsk.IsMarked, true);

            Console.WriteLine("Is Marked: " + task.Get(Tsk.IsMarked));

            // ExEnd
        }

        [Test]
        public void GetSetIsNull()
        {
            // ExStart
            // ExFor: Tsk.IsNull
            // ExSummary: Shows how to read/write Tsk.IsNull property.
            var project = new Project();

            var task = project.RootTask.Children.Add("Task");

            task.Set(Tsk.IsNull, true);

            Console.WriteLine("Is Null: " + task.Get(Tsk.IsNull));

            // ExEnd
        }

        [Test]
        public void GetSetIsOverallocated()
        {
            // ExStart
            // ExFor: Tsk.IsOverallocated
            // ExFor: Tsk.HasOverallocatedResource
            // ExFor: Asn.Overallocated
            // ExFor: Rsc.Overallocated
            // ExSummary: Shows how to read Tsk.IsOverallocated, Tsk.HasOverallocatedResource,
            // Rsc.Overallocated and Asn.Overallocated properties.
            var project = new Project();

            var task1 = project.RootTask.Children.Add("Task1");
            var task2 = project.RootTask.Children.Add("Task2");

            var resource1 = project.Resources.Add("Resource1");
            var resource2 = project.Resources.Add("Resource2");

            project.CalculationMode = CalculationMode.None;
            task1.Set(Tsk.Type, TaskType.FixedDuration);
            var assignment11 = project.ResourceAssignments.Add(task1, resource1);
            assignment11.Set(Asn.Work, project.GetDuration(9, TimeUnitType.Hour));
            assignment11.Set(Asn.Start, task1.Get(Tsk.Start));
            assignment11.Set(Asn.Finish, task1.Get(Tsk.Start).AddHours(9));
            task1.Set(Tsk.Duration, project.GetDuration(8, TimeUnitType.Hour));
            task1.Set(Tsk.Work, project.GetDuration(9, TimeUnitType.Hour));
            var assignment21 = project.ResourceAssignments.Add(task2, resource1);
            var assignment22 = project.ResourceAssignments.Add(task2, resource2);

            assignment21.Set(Asn.Work, project.GetDuration(1, TimeUnitType.Hour));

            project.CalculationMode = CalculationMode.Automatic;
            project.Recalculate();

            Console.WriteLine("Task1: Is Overallocated: " + task1.Get(Tsk.IsOverallocated));
            Console.WriteLine("Task2: Is Overallocated: " + task2.Get(Tsk.IsOverallocated));

            Console.WriteLine("Task1: Has Overallocated Resource: " + task1.Get(Tsk.HasOverallocatedResource));
            Console.WriteLine("Task2: Has Overallocated Resource: " + task2.Get(Tsk.HasOverallocatedResource));

            Console.WriteLine("Resource1: Is Overallocated: " + resource1.Get(Rsc.Overallocated));
            Console.WriteLine("Resource2: Is Overallocated: " + resource2.Get(Rsc.Overallocated));

            Console.WriteLine("Assignment11: Is Overallocated: " + assignment11.Get(Asn.Overallocated));
            Console.WriteLine("Assignment21: Is Overallocated: " + assignment21.Get(Asn.Overallocated));
            Console.WriteLine("Assignment22: Is Overallocated: " + assignment22.Get(Asn.Overallocated));

            // ExEnd
        }

        [Test]
        public void GetSetIsPublished()
        {
            // ExStart
            // ExFor: Tsk.IsPublished
            // ExSummary: Shows how to read/write Tsk.IsPublished property.
            var project = new Project();

            var task = project.RootTask.Children.Add("Task");

            task.Set(Tsk.IsPublished, true);

            Console.WriteLine("Is Published: " + task.Get(Tsk.IsPublished));

            // ExEnd
        }

        [Test]
        public void GetSetIsRecurring()
        {
            // ExStart
            // ExFor: Tsk.IsRecurring
            // ExSummary: Shows how to read/write Tsk.IsRecurring property.
            var project = new Project();

            var task = project.RootTask.Children.Add("Task");

            task.Set(Tsk.IsRecurring, true);

            Console.WriteLine("Is Recurring: " + task.Get(Tsk.IsRecurring));

            // ExEnd
        }

        [Test]
        public void GetSetIsResumeValid()
        {
            // ExStart
            // ExFor: Tsk.IsResumeValid
            // ExSummary: Shows how to read/write Tsk.IsResumeValid property.
            var project = new Project();

            var task = project.RootTask.Children.Add("Task");

            task.Set(Tsk.IsResumeValid, true);

            Console.WriteLine("Is Resume Valid: " + task.Get(Tsk.IsResumeValid));

            // ExEnd
        }

        [Test]
        public void GetSetIsRollup()
        {
            // ExStart
            // ExFor: Tsk.IsRollup
            // ExSummary: Shows how to read/write Tsk.IsRollup property.
            var project = new Project();

            var task = project.RootTask.Children.Add("Task");

            task.Set(Tsk.IsRollup, true);

            Console.WriteLine("Is Rollup: " + task.Get(Tsk.IsRollup));

            // ExEnd
        }

        [Test]
        public void GetSetIsSubproject()
        {
            // ExStart
            // ExFor: Tsk.IsSubproject
            // ExSummary: Shows how to read/write Tsk.IsSubproject property.
            var project = new Project();

            var task = project.RootTask.Children.Add("Task");

            task.Set(Tsk.IsSubproject, true);

            Console.WriteLine("Is Subproject: " + task.Get(Tsk.IsSubproject));

            // ExEnd
        }

        [Test]
        public void GetSetIsSubprojectReadOnly()
        {
            // ExStart
            // ExFor: Tsk.IsSubprojectReadOnly
            // ExSummary: Shows how to read/write Tsk.IsSubprojectReadOnly property.
            var project = new Project();

            var task = project.RootTask.Children.Add("Task");

            task.Set(Tsk.IsSubprojectReadOnly, true);

            Console.WriteLine("Is Subproject Read Only: " + task.Get(Tsk.IsSubprojectReadOnly));

            // ExEnd
        }

        [Test]
        public void GetSetIsSummary()
        {
            // ExStart
            // ExFor: Tsk.IsSummary
            // ExSummary: Shows how to read/write Tsk.IsSummary property.
            var project = new Project();

            var task = project.RootTask.Children.Add("Task");

            task.Set(Tsk.IsSummary, true);

            Console.WriteLine("Is Summary: " + task.Get(Tsk.IsSummary));

            // ExEnd
        }

        [Test]
        public void GetSetLateFinish()
        {
            // ExStart
            // ExFor: Tsk.LateFinish
            // ExSummary: Shows how to read/write Tsk.LateFinish property.
            var project = new Project();

            var task = project.RootTask.Children.Add("Task");

            task.Set(Tsk.LateFinish, new DateTime(2020, 4, 10, 8, 0, 0));

            Console.WriteLine("Late Finish: " + task.Get(Tsk.LateFinish));

            // ExEnd
        }

        [Test]
        public void GetSetLateStart()
        {
            // ExStart
            // ExFor: Tsk.LateStart
            // ExSummary: Shows how to read/write Tsk.LateStart property.
            var project = new Project();

            var task = project.RootTask.Children.Add("Task");

            task.Set(Tsk.LateStart, new DateTime(2020, 4, 10, 8, 0, 0));

            Console.WriteLine("Late Start: " + task.Get(Tsk.LateStart));

            // ExEnd
        }

        [Test]
        public void GetSetLevelAssignments()
        {
            // ExStart
            // ExFor: Tsk.LevelAssignments
            // ExSummary: Shows how to read/write Tsk.LevelAssignments property.
            var project = new Project();

            var task = project.RootTask.Children.Add("Task");

            task.Set(Tsk.LevelAssignments, true);

            Console.WriteLine("Level Assignments: " + task.Get(Tsk.LevelAssignments));

            // ExEnd
        }

        [Test]
        public void GetSetLevelingCanSplit()
        {
            // ExStart
            // ExFor: Tsk.LevelingCanSplit
            // ExSummary: Shows how to read/write Tsk.LevelingCanSplit property.
            var project = new Project();

            var task = project.RootTask.Children.Add("Task");

            task.Set(Tsk.LevelingCanSplit, true);

            Console.WriteLine("Leveling Can Split: " + task.Get(Tsk.LevelingCanSplit));

            // ExEnd
        }

        [Test]
        public void GetSetLevelingDelay()
        {
            // ExStart
            // ExFor: Tsk.LevelingDelay
            // ExSummary: Shows how to read/write Tsk.LevelingDelay property.
            var project = new Project();

            var task = project.RootTask.Children.Add("Task");

            task.Set(Tsk.LevelingDelay, project.GetDuration(1, TimeUnitType.Hour));

            Console.WriteLine("Leveling Delay: " + task.Get(Tsk.LevelingDelay));

            // ExEnd
        }

        [Test]
        public void GetSetManualDuration()
        {
            // ExStart
            // ExFor: Tsk.ManualDuration
            // ExSummary: Shows how to read/write Tsk.ManualDuration property.
            var project = new Project();

            var task = project.RootTask.Children.Add("Task");

            task.Set(Tsk.ManualDuration, project.GetDuration(1, TimeUnitType.Hour));

            Console.WriteLine("Manual Duration: " + task.Get(Tsk.ManualDuration));

            // ExEnd
        }

        [Test]
        public void GetSetManualFinish()
        {
            // ExStart
            // ExFor: Tsk.ManualFinish
            // ExSummary: Shows how to read/write Tsk.ManualFinish property.
            var project = new Project();

            var task = project.RootTask.Children.Add("Task");

            task.Set(Tsk.ManualFinish, new DateTime(2020, 4, 10, 8, 0, 0));

            Console.WriteLine("Manual Finish: " + task.Get(Tsk.ManualFinish));

            // ExEnd
        }

        [Test]
        public void GetSetManualStart()
        {
            // ExStart
            // ExFor: Tsk.ManualStart
            // ExSummary: Shows how to read/write Tsk.ManualStart property.
            var project = new Project();

            var task = project.RootTask.Children.Add("Task");

            task.Set(Tsk.ManualStart, new DateTime(2020, 4, 10, 8, 0, 0));

            Console.WriteLine("Manual Start: " + task.Get(Tsk.ManualStart));

            // ExEnd
        }

        [Test]
        public void GetSetNotesRtf()
        {
            // ExStart
            // ExFor: Tsk.NotesRTF
            // ExSummary: Shows how to read/write Tsk.NotesRTF property.
            var project = new Project();

            var task = project.RootTask.Children.Add("Task");

            const string rtf = @"{\rtf1\ansi\ansicpg1252\deff0\deflang1033{\fonttbl{\f0\fnil\fcharset134 SimSun;}{\f1\fnil\fcharset0 Calibri;}}
{\*\generator Msftedit 5.41.21.2510;}\viewkind4\uc1\pard\sa200\sl276\slmult1\lang9\f0\fs22\'d4\'e7\'c9\'cf\'ba\'c3\f1\par
}
 "; // 早上好

            task.Set(Tsk.NotesRTF, rtf);

            Console.WriteLine("Notes RTF: " + task.Get(Tsk.NotesRTF));

            // ExEnd
        }

        [Test]
        public void GetSetNotesText()
        {
            // ExStart
            // ExFor: Tsk.NotesText
            // ExSummary: Shows how to read/write Tsk.NotesText property.
            var project = new Project();

            var task = project.RootTask.Children.Add("Task");

            task.Set(Tsk.NotesText, "Notes");

            Console.WriteLine("Notes Text: " + task.Get(Tsk.NotesText));

            // ExEnd
        }

        [Test]
        public void GetSetPercentWorkComplete()
        {
            // ExStart
            // ExFor: Tsk.PercentWorkComplete
            // ExSummary: Shows how to read/write Tsk.PercentWorkComplete property.
            var project = new Project();

            var task = project.RootTask.Children.Add("Task");

            task.Set(Tsk.PercentWorkComplete, 10);

            Console.WriteLine("Percent Work Complete: " + task.Get(Tsk.PercentWorkComplete));

            // ExEnd
        }

        [Test]
        public void GetSetPhysicalPercentComplete()
        {
            // ExStart
            // ExFor: Tsk.PhysicalPercentComplete
            // ExSummary: Shows how to read/write Tsk.PhysicalPercentComplete property.
            var project = new Project();

            var task = project.RootTask.Children.Add("Task");

            task.Set(Tsk.PhysicalPercentComplete, 10);

            Console.WriteLine("Physical Percent Complete: " + task.Get(Tsk.PhysicalPercentComplete));

            // ExEnd
        }

        [Test]
        public void GetSetPreleveledFinish()
        {
            // ExStart
            // ExFor: Tsk.PreleveledFinish
            // ExSummary: Shows how to read/write Tsk.PreleveledFinish property.
            var project = new Project();

            var task = project.RootTask.Children.Add("Task");

            task.Set(Tsk.PreleveledFinish, new DateTime(2020, 4, 10, 8, 0, 0));

            Console.WriteLine("Preleveled Finish: " + task.Get(Tsk.PreleveledFinish));

            // ExEnd
        }

        [Test]
        public void GetSetPreleveledStart()
        {
            // ExStart
            // ExFor: Tsk.PreleveledStart
            // ExSummary: Shows how to read/write Tsk.PreleveledStart property.
            var project = new Project();

            var task = project.RootTask.Children.Add("Task");

            task.Set(Tsk.PreleveledStart, new DateTime(2020, 4, 10, 8, 0, 0));

            Console.WriteLine("Preleveled Start: " + task.Get(Tsk.PreleveledStart));

            // ExEnd
        }

        [Test]
        public void GetSetRegularWork()
        {
            // ExStart
            // ExFor: Tsk.RegularWork
            // ExSummary: Shows how to read/write Tsk.RegularWork property.
            var project = new Project();
            project.Set(Prj.WorkFormat, TimeUnitType.Hour);

            var task = project.RootTask.Children.Add("Task");

            task.Set(Tsk.RegularWork, project.GetWork(1));

            Console.WriteLine("Regular Work: " + task.Get(Tsk.RegularWork));

            // ExEnd
        }

        [Test]
        public void GetSetRemainingDuration()
        {
            // ExStart
            // ExFor: Tsk.RemainingDuration
            // ExSummary: Shows how to read/write Tsk.RemainingDuration property.
            var project = new Project();

            var task = project.RootTask.Children.Add("Task");

            task.Set(Tsk.RemainingDuration, project.GetDuration(1, TimeUnitType.Hour));

            Console.WriteLine("Remaining Duration: " + task.Get(Tsk.RemainingDuration));

            // ExEnd
        }

        [Test]
        public void GetSetRemainingOvertimeCost()
        {
            // ExStart
            // ExFor: Tsk.RemainingOvertimeCost
            // ExSummary: Shows how to read/write Tsk.RemainingOvertimeCost property.
            var project = new Project();

            var task = project.RootTask.Children.Add("Task");

            task.Set(Tsk.RemainingOvertimeCost, 2m);

            Console.WriteLine("Remaining Overtime Cost: " + task.Get(Tsk.RemainingOvertimeCost));

            // ExEnd
        }

        [Test]
        public void GetSetRemainingOvertimeWork()
        {
            // ExStart
            // ExFor: Tsk.RemainingOvertimeWork
            // ExSummary: Shows how to read/write Tsk.RemainingOvertimeWork property.
            var project = new Project();
            project.Set(Prj.WorkFormat, TimeUnitType.Hour);

            var task = project.RootTask.Children.Add("Task");

            task.Set(Tsk.RemainingOvertimeWork, project.GetWork(1));

            Console.WriteLine("Remaining Overtime Work: " + task.Get(Tsk.RemainingOvertimeWork));

            // ExEnd
        }

        [Test]
        public void GetSetRemainingWork()
        {
            // ExStart
            // ExFor: Tsk.RemainingWork
            // ExSummary: Shows how to read/write Tsk.RemainingWork property.
            var project = new Project();
            project.Set(Prj.WorkFormat, TimeUnitType.Hour);

            var task = project.RootTask.Children.Add("Task");

            task.Set(Tsk.RemainingWork, project.GetWork(1));

            Console.WriteLine("Remaining Work: " + task.Get(Tsk.RemainingWork));

            // ExEnd
        }

        [Test]
        public void GetSetStartSlack()
        {
            // ExStart
            // ExFor: Tsk.StartSlackTimeSpan
            // ExSummary: Shows how to read Tsk.StartSlackTimeSpan property. The property is calculated, so usually there is no need to set it explicitly.
            var project = new Project();

            var task = project.RootTask.Children.Add("Task");

            Console.WriteLine("Start Slack: " + task.Get(Tsk.StartSlackTimeSpan));

            // ExEnd
        }

        [Test]
        public void GetSetStartText()
        {
            // ExStart
            // ExFor: Tsk.StartText
            // ExSummary: Shows how to read/write Tsk.StartText property.
            var project = new Project();

            var task = project.RootTask.Children.Add("Task");

            task.Set(Tsk.StartText, "Start Task Text");

            Console.WriteLine("Start Text: " + task.Get(Tsk.StartText));

            // ExEnd
        }

        [Test]
        public void GetSetStartVariance()
        {
            // ExStart
            // ExFor: Tsk.StartVariance
            // ExSummary: Shows how to read/write Tsk.StartVariance property.
            var project = new Project();

            var task = project.RootTask.Children.Add("Task");

            task.Set(Tsk.StartVariance, project.GetDuration(1, TimeUnitType.Hour));

            Console.WriteLine("Start Variance: " + task.Get(Tsk.StartVariance));

            // ExEnd
        }

        [Test]
        public void GetSetStatusManager()
        {
            // ExStart
            // ExFor: Tsk.StatusManager
            // ExSummary: Shows how to read/write Tsk.StatusManager property.
            var project = new Project();

            var task = project.RootTask.Children.Add("Task");

            task.Set(Tsk.StatusManager, "John Smith");

            Console.WriteLine("Status Manager: " + task.Get(Tsk.StatusManager));

            // ExEnd
        }

        [Test]
        public void GetSetTotalSlack()
        {
            // ExStart
            // ExFor: Tsk.TotalSlackTimeSpan
            // ExSummary: Shows how to read Tsk.TotalSlackTimeSpan property. The property is calculated, so usually there is no need to set it explicitly.
            var project = new Project();

            var task = project.RootTask.Children.Add("Task");

            Console.WriteLine("Total Slack: " + task.Get(Tsk.TotalSlackTimeSpan));
            // ExEnd
        }

        [Test]
        public void GetSetType()
        {
            // ExStart
            // ExFor: Tsk.Type
            // ExSummary: Shows how to read/write Tsk.Type property.
            var project = new Project();

            var task = project.RootTask.Children.Add("Task");

            task.Set(Tsk.Type, TaskType.FixedDuration);

            Console.WriteLine("Type: " + task.Get(Tsk.Type));

            // ExEnd
        }

        [Test]
        public void GetSetWork()
        {
            // ExStart
            // ExFor: Tsk.Work
            // ExSummary: Shows how to read/write Tsk.Work property.
            var project = new Project();
            project.Set(Prj.WorkFormat, TimeUnitType.Hour);

            var task = project.RootTask.Children.Add("Task");

            task.Set(Tsk.Work, project.GetWork(1));

            Console.WriteLine("Work: " + task.Get(Tsk.Work));

            // ExEnd
        }

        [Test]
        public void GetSetWorkVariance()
        {
            // ExStart
            // ExFor: Tsk.WorkVariance
            // ExSummary: Shows how to read/write Tsk.WorkVariance property.
            var project = new Project();

            var task = project.RootTask.Children.Add("Task");

            task.Set(Tsk.WorkVariance, project.GetDuration(1));

            Console.WriteLine("Work Variance: " + task.Get(Tsk.WorkVariance));

            // ExEnd
        }

        [Test]
        public void EvaluationDateTimeLimitations()
        {
            // ExStart:DateTimeLimitations
            // ExFor: Tsk.ActualStart
            // ExFor: Tsk.ActualFinish
            // ExSummary: Shows that project' dates are reset in an evaluation mode.
            var project = new Project();

            // create new tasks
            var task1 = project.RootTask.Children.Add("Task1");
            task1.Set(Tsk.ActualStart, new DateTime(2000, 2, 10, 8, 0, 0));
            task1.Set(Tsk.ActualFinish, new DateTime(2000, 2, 10, 17, 0, 0));

            var task2 = project.RootTask.Children.Add("Task2");
            task2.Set(Tsk.ActualStart, new DateTime(2000, 2, 10, 8, 0, 0));
            task2.Set(Tsk.ActualFinish, new DateTime(2000, 2, 10, 17, 0, 0));

            project.Save(OutDir + "EvaluationDateTimeLimitations_out.xml", SaveFileFormat.Xml);

            // ExEnd:DateTimeLimitations
        }

        [Test]
        public void ReadBudgetWorkCost()
        {
            // ExStart:ReadBudgetWorkAndCost
            // ExFor: Tsk.BudgetWork
            // ExFor: Tsk.BudgetCost
            // ExSummary: Shows how to read budget work/cost values of task/resource/assignment.
            var project = new Project(DataDir + "BudgetWorkAndCost.mpp");

            // Display budget work and budget cost for project summary task
            Console.WriteLine("projSummary.BudgetWork = " + project.RootTask.Get(Tsk.BudgetWork));
            Console.WriteLine("projSummary.BudgetCost = " + project.RootTask.Get(Tsk.BudgetCost));

            // Display resource budget work
            var rsc = project.Resources.GetByUid(6);
            Console.WriteLine("Resource BudgetWork = " + rsc.Get(Rsc.BudgetWork));

            // Display resource budget cost
            rsc = project.Resources.GetByUid(7);
            Console.WriteLine("Resource BudgetCost = " + rsc.Get(Rsc.BudgetCost));

            var collector = new ChildTasksCollector();
            TaskUtils.Apply(project.RootTask, collector, 0);
            foreach (var tsk in collector.Tasks)
            {
                // Display assignment budget work and budget cost
                foreach (var assignment in tsk.Assignments)
                {
                    var resource = assignment.Get(Asn.Resource);
                    if (resource == null)
                    {
                        continue;
                    }

                    if (resource.Get(Rsc.Type) == ResourceType.Work)
                    {
                        Console.WriteLine("Assignment BudgetWork = " + assignment.Get(Asn.BudgetWork));
                    }
                    else
                    {
                        Console.WriteLine("Assignment BudgetCost = " + assignment.Get(Asn.BudgetCost));
                    }
                }
            }

            // ExEnd:ReadBudgetWorkAndCost
        }

        [Test]
        public void ChangeTaskProgress()
        {
            // ExStart:ChangeTaskProgress
            // ExFor: Tsk.PercentComplete 
            // ExSummary: Shows how to change a task progress by updating of task percent complete.
            var project = new Project();
            Console.WriteLine("Project Calculation mode is Automatic: {0}", project.CalculationMode.Equals(CalculationMode.Automatic));

            var task = project.RootTask.Children.Add("Task");
            task.Set(Tsk.Duration, project.GetDuration(2));
            task.Set(Tsk.PercentComplete, 50);

            // Access tasks and display percentage completion
            foreach (var tsk in project.RootTask.Children)
            {
                Console.WriteLine(tsk.Get(Tsk.PercentComplete));
                Console.WriteLine(tsk.Get(Tsk.PercentWorkComplete));
                Console.WriteLine(tsk.Get(Tsk.PhysicalPercentComplete));
            }

            // ExEnd:ChangeTaskProgress
        }

        [Test]
        public void ReadWriteTaskProperties()
        {
            // ExStart:ReadWriteTaskProperties
            // ExFor: Tsk
            // ExFor: Tsk.Id
            // ExFor: Tsk.Uid
            // ExFor: Tsk.Name
            // ExFor: Tsk.Start
            // ExFor: Tsk.Finish
            // ExFor: TaskKey
            // ExSummary: Shows how to read/write task properties.
            var project = new Project();

            // Add task and set task properties
            var task = project.RootTask.Children.Add();
            task.Set(Tsk.Name, "Task1");
            task.Set(Tsk.Start, new DateTime(2020, 3, 31, 8, 0, 0));
            task.Set(Tsk.Finish, new DateTime(2020, 3, 31, 17, 0, 0));

            var collector = new ChildTasksCollector();
            TaskUtils.Apply(project.RootTask, collector, 0);

            // Parse through all the collected tasks
            foreach (var tsk in collector.Tasks)
            {
                Console.WriteLine("Task Id: {0}", tsk.Get(Tsk.Id));
                Console.WriteLine("Task Uid: {0}", tsk.Get(Tsk.Uid));
                Console.WriteLine("Task Name: {0}", tsk.Get(Tsk.Name));
                Console.WriteLine("Task Start: {0}", tsk.Get(Tsk.Start));
                Console.WriteLine("Task Finish: {0}", tsk.Get(Tsk.Finish));
            }

            // ExEnd:ReadWriteTaskProperties
        }

        [Test]
        public void ReadActualTaskProperties()
        {
            // ExStart:ReadActualTaskProperties
            // ExFor: Tsk.ActualCost
            // ExFor: Tsk.ActualDuration
            // ExSummary: Shows how to read task's actual properties.
            var project = new Project(DataDir + "ActualTaskProperties.mpp");

            var collector = new ChildTasksCollector();
            TaskUtils.Apply(project.RootTask, collector, 0);

            // Parse through all the collected tasks
            foreach (var task in collector.Tasks)
            {
                Console.WriteLine("Task Name : " + task.Get(Tsk.Name));
                Console.WriteLine("Actual Start: " + task.Get(Tsk.ActualStart).ToLongDateString());
                Console.WriteLine("Actual Finish: " + task.Get(Tsk.ActualFinish).ToLongDateString());
                Console.WriteLine("Actual Duration: " + task.Get(Tsk.ActualDuration).TimeSpan.Hours);
                Console.WriteLine("Actual Cost: " + task.Get(Tsk.ActualCost));
            }

            // ExEnd:ReadActualTaskProperties
        }

        [Test]
        public void ReadTaskPriority()
        {
            // ExStart:ReadTaskPriority
            // ExFor: Tsk.Priority
            // ExSummary: Shows how to read a task priority.
            var project = new Project(DataDir + "TaskPriority.mpp");

            var collector = new ChildTasksCollector();
            TaskUtils.Apply(project.RootTask, collector, 0);

            // Display Priorities for all tasks
            foreach (var task in collector.Tasks)
            {
                Console.WriteLine(task.Get(Tsk.Name) + " - Priority : " + task.Get(Tsk.Priority));
            }

            // ExEnd:ReadTaskPriority
        }

        [Test]
        public void CreateSubProjectTask()
        {
            try
            {
                // ExStart:CreateSubProjectTask
                // ExFor: Tsk.SubprojectName
                // ExSummary: Shows how to create a subproject task.
                var project = new Project(DataDir + "SubProjectTask.mpp");

                // Add task
                var task = project.RootTask.Children.Add("Task 1");

                // Setting new subproject link
                task.Set(Tsk.SubprojectName, DataDir + "subProject.mpp");

                project.Save(OutDir + "CreateSubProjectTask_out.mpp", SaveFileFormat.Mpp);

                // ExEnd:CreateSubProjectTask
            }
            catch (NotSupportedException ex)
            {
                Console.WriteLine(ex.Message + "\nThis example will only work if you apply a valid Aspose.Tasks License. You can purchase full license or get 30 day temporary license from http://www.aspose.com/purchase/default.aspx.");
            }
        }
        
        [Test]
        public void ReadWriteTaskCalendar()
        {
            // ExStart:ReadWriteTaskCalendar
            // ExFor: Tsk.Calendar
            // ExSummary: Shows how to read/write task calendars.
            var project = new Project(DataDir + "ReadTaskCalendar.mpp");
            var task = project.RootTask.Children.Add("Task1");

            // Create calendar and assign to task
            var newCalendar = project.Calendars.Add("TaskCal1");
            task.Set(Tsk.Calendar, newCalendar);

            var collector = new ChildTasksCollector();
            TaskUtils.Apply(project.RootTask, collector, 0);

            // Parse all the recursive children
            foreach (var tsk in collector.Tasks)
            {
                var calendar = tsk.Get(Tsk.Calendar);
                Console.WriteLine("Task calendar name: {0}", calendar == null ? "None" : calendar.Name);
            }

            // ExEnd:ReadWriteTaskCalendar
        }

        [Test]
        public void ReadTaskCosts()
        {
            // ExStart:ReadTaskCosts
            // ExFor: Tsk.Cost
            // ExFor: Tsk.RemainingCost
            // ExFor: Tsk.FixedCost
            // ExFor: Tsk.CostVariance
            // ExSummary: Shows how to read task costs.
            var project = new Project();

            // Add task and set cost
            var task = project.RootTask.Children.Add("Task");
            task.Set(Tsk.Cost, 800);

            // Display cost related properties of task
            Console.WriteLine(task.Get(Tsk.RemainingCost));
            Console.WriteLine(task.Get(Tsk.FixedCost));
            Console.WriteLine(task.Get(Tsk.CostVariance));
            Console.WriteLine(project.RootTask.Get(Tsk.Cost));
            Console.WriteLine(project.RootTask.Get(Tsk.FixedCost));
            Console.WriteLine(project.RootTask.Get(Tsk.RemainingCost));
            Console.WriteLine(project.RootTask.Get(Tsk.CostVariance));

            // ExEnd:ReadTaskCosts
        }

        [Test]
        public void ReadTaskOutlineProperties()
        {
            // ExStart:ReadTaskOutlineProperties
            // ExFor: Tsk.OutlineLevel
            // ExFor: Tsk.OutlineNumber
            // ExSummary: Shows how to read task outline properties.
            var project = new Project(DataDir + "TaskOutlineProperties.mpp");

            var collector = new ChildTasksCollector();
            TaskUtils.Apply(project.RootTask, collector, 0);

            // Parse through all the collected tasks
            foreach (var task in collector.Tasks)
            {
                Console.WriteLine(task.Get(Tsk.Name) + " - Outline Level : " + task.Get(Tsk.OutlineLevel));
                Console.WriteLine(task.Get(Tsk.Name) + " - Outline Number : " + task.Get(Tsk.OutlineNumber));
            }

            // ExEnd:ReadTaskOutlineProperties
        }

        [Test]
        public void ReadStopResumeDates()
        {
            // ExStart:ReadStopResumeDates
            // ExFor: Tsk.Stop
            // ExFor: Tsk.Resume
            // ExSummary: Shows how to read task's Stop/Resume dates.
            var project = new Project(DataDir + "StopResumeDates.mpp");

            var collector = new ChildTasksCollector();
            TaskUtils.Apply(project.RootTask, collector, 0);

            // Check Stop and Resume dates for all tasks
            foreach (var task in collector.Tasks)
            {
                if (task.Get(Tsk.Stop).ToShortDateString() == "1/1/2000")
                {
                    Console.WriteLine("Stop: NA");
                }
                else
                {
                    Console.WriteLine("Stop: " + task.Get(Tsk.Stop).ToShortDateString());
                }

                if (task.Get(Tsk.Resume).ToShortDateString() == "1/1/2000")
                {
                    Console.WriteLine("Resume: NA");
                }
                else
                {
                    Console.WriteLine("Resume: " + task.Get(Tsk.Resume).ToShortDateString());
                }
            }

            // ExEnd:ReadStopResumeDates
        }

        [Test]
        public void ReadTaskOvertimes()
        {
            // ExStart:ReadTaskOvertimes
            // ExFor: Tsk.OvertimeCost
            // ExFor: Tsk.OvertimeWork
            // ExSummary: Shows how to read task overtimes.
            var project = new Project(DataDir + "TaskOvertimes.mpp");

            // Read overtime and percentage completion for tasks
            foreach (var task in project.RootTask.Children)
            {
                Console.WriteLine(task.Get(Tsk.OvertimeCost));
                Console.WriteLine(task.Get(Tsk.OvertimeWork));
                Console.WriteLine(task.Get(Tsk.PercentComplete));
                Console.WriteLine(task.Get(Tsk.PercentWorkComplete));
                Console.WriteLine(task.Get(Tsk.PhysicalPercentComplete));

                // Set percent complete
                task.Set(Tsk.PercentComplete, 100);
            }

            // ExEnd:ReadTaskOvertimes
        }

        [Test]
        public void AddTaskDuration()
        {
            // ExStart:AddTaskDuration
            // ExFor: Tsk.Duration
            // ExFor: Tsk.DurationFormat
            // ExSummary: Shows how to set duration of the task. 
            var project = new Project();

            var task = project.RootTask.Children.Add("Task1");
            task.Set(Tsk.Start, new DateTime(2012, 8, 23, 8, 0, 0));
            task.Set(Tsk.Duration, project.GetDuration(24, TimeUnitType.Hour));
            task.Set(Tsk.ActualStart, new DateTime(2012, 8, 23, 8, 0, 0));

            project.Save(OutDir + "AddTaskDuration_out.xml", SaveFileFormat.Xml);

            // ExEnd:AddTaskDuration        
        }

        [Test]
        public void TaskWarning()
        {
            // ExStart:TaskWarning
            // ExFor: Tsk.Warning
            // ExSummary: Shows how to read a task warning.
            var project = new Project(DataDir + "schedule-conflict.mpp");
            var task = project.RootTask.Children.GetById(1);
            Console.WriteLine(task.Get(Tsk.Warning));

            // ExEnd:TaskWarning
        }

        [Test]
        public void ReadTaskWbs()
        {
            // ExStart:ReadTaskWBS
            // ExFor: Tsk.WBS
            // ExFor: Tsk.WBSLevel
            // ExSummary: Shows how to read task's WBS codes.
            var project = new Project(DataDir + "TaskWBS.mpp");

            var collector = new ChildTasksCollector();
            TaskUtils.Apply(project.RootTask, collector, 0);

            // Parse through all the collected tasks
            foreach (var task in collector.Tasks)
            {
                Console.WriteLine(task.Get(Tsk.WBS));
                Console.WriteLine(task.Get(Tsk.WBSLevel));
            }

            // ExEnd:ReadTaskWBS
        }

        [Test]
        public void GetSetTaskConstraint()
        {
            // ExStart:GetSetTaskConstraint
            // ExFor: Tsk.ConstraintType
            // ExFor: Tsk.ConstraintDate
            // ExSummary: Shows how to get/set a constraint for a task.
            var project = new Project(DataDir + "ConstraintAsLateAsPossible.mpp");

            // Set constraint As Late As Possible for task with Id 11
            var newTask = project.RootTask.Children.GetById(11);
            newTask.Set(Tsk.ConstraintType, ConstraintType.AsLateAsPossible);

            var collector = new ChildTasksCollector();
            TaskUtils.Apply(project.RootTask, collector, 0);

            // Parse through all the collected tasks
            foreach (var task in collector.Tasks)
            {
                Console.WriteLine(task.Get(Tsk.ConstraintType).ToString());
                Console.WriteLine(task.Get(Tsk.ConstraintDate).ToShortDateString() == "1/1/2000" ? "NA" : task.Get(Tsk.ConstraintDate).ToShortDateString());
            }

            SaveOptions options = new PdfSaveOptions
            {
                StartDate = project.Get(Prj.StartDate),
                Timescale = Timescale.ThirdsOfMonths
            };

            project.Save(OutDir + "SetConstraintAsLateAsPossible_out.pdf", options);

            // ExEnd:GetSetTaskConstraint
        }

        [Test]
        public void FindCriticalEffortDrivenTasks()
        {
            // ExStart:FindCriticalEffortDrivenTasks
            // ExFor: Tsk.IsCritical
            // ExFor: Tsk.IsEffortDriven
            // ExSummary: Shows how to find critical and/or effort driven tasks.
            var project = new Project(DataDir + "CriticalEffortDrivenTasks.mpp");

            var collector = new ChildTasksCollector();
            TaskUtils.Apply(project.RootTask, collector, 0);

            // Parse through all the collected tasks
            foreach (var task in collector.Tasks)
            {
                var effortDriven = task.Get(Tsk.IsEffortDriven).Value ? "EffortDriven" : "Non-EffortDriven";
                var nonCritical = task.Get(Tsk.IsCritical).Value ? "Critical" : "Non-Critical";
                Console.WriteLine(task.Get(Tsk.Name) + " : " + effortDriven);
                Console.WriteLine(task.Get(Tsk.Name) + " : " + nonCritical);
            }

            // ExEnd:FindCriticalEffortDrivenTasks
        }

        [Test]
        public void FindEstimatedMilestoneTasks()
        {
            // ExStart:FindEstimatedMilestoneTasks
            // ExFor: Tsk.IsEstimated
            // ExFor: Tsk.IsMilestone
            // ExSummary: Shows how to find estimated and/or milestone tasks.
            var prj = new Project(DataDir + "EstimatedMilestoneTasks.mpp");

            var collector = new ChildTasksCollector();
            TaskUtils.Apply(prj.RootTask, collector, 0);

            // Iterate over the collected tasks
            foreach (var task in collector.Tasks)
            {
                var estimated = task.Get(Tsk.IsEstimated).Value ? "Estimated" : "Non-Estimated";
                var milestone = task.Get(Tsk.IsMilestone).Value ? "Milestone" : "Non-Milestone";
                Console.WriteLine(task.Get(Tsk.Name) + " : " + estimated);
                Console.WriteLine(task.Get(Tsk.Name) + " : " + milestone);
            }

            // ExEnd:FindEstimatedMilestoneTasks
        }

        [Test]
        public static void IdentifyCrossProjectTasks()
        {
            // ExStart:IdentifyCrossProjectTasks
            // ExFor: Tsk.ExternalId
            // ExSummary: Shows how to identify cross project tasks.
            var project = new Project(DataDir + "External.mpp");
            var externalTask = project.RootTask.Children.GetByUid(1);

            // Show ID of the task in the external project
            Console.WriteLine(externalTask.Get(Tsk.Id).ToString());

            // Show ID of the task in the original project
            Console.WriteLine(externalTask.Get(Tsk.ExternalId).ToString());

            // ExEnd:IdentifyCrossProjectTasks
        }

        [Test]
        public void GetTaskCosts()
        {
            // ExStart
            // ExFor: Tsk.ACWP
            // ExFor: Tsk.BCWP
            // ExFor: Tsk.BCWS
            // ExFor: Tsk.CV
            // ExSummary: Shows how to read task cost values.
            var project = new Project(DataDir + "ResourceAssignmentCosts.mpp");

            var collector = new ChildTasksCollector();
            TaskUtils.Apply(project.RootTask, collector, 0);

            foreach (var task in collector.Tasks)
            {
                Console.WriteLine("Cost: " + task.Get(Tsk.Cost));
                Console.WriteLine("ACWP: " + task.Get(Tsk.ACWP));
                Console.WriteLine("BCWP: " + task.Get(Tsk.BCWP));
                Console.WriteLine("BCWS: " + task.Get(Tsk.BCWS));

                // CV = BCWP - ACWP
                Console.WriteLine("CV: " + task.Get(Tsk.CV));
                Console.WriteLine();
            }

            // ExEnd
        }
    }
}