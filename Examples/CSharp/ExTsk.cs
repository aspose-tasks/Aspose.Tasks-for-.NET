namespace Aspose.Tasks.Examples.CSharp
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
        public void EvaluationDateTimeLimitations()
        {
            //ExStart:DateTimeLimitations
            //ExFor: Tsk.ActualStart
            //ExFor: Tsk.ActualFinish
            //ExSummary: Shows that project' dates are reset in an evaluation mode.
            var project = new Project();

            // create new tasks
            var task1 = project.RootTask.Children.Add("Task1");
            task1.Set(Tsk.ActualStart, new DateTime(2000, 2, 10, 8, 0, 0));
            task1.Set(Tsk.ActualFinish, new DateTime(2000, 2, 10, 17, 0, 0));

            var task2 = project.RootTask.Children.Add("Task2");
            task2.Set(Tsk.ActualStart, new DateTime(2000, 2, 10, 8, 0, 0));
            task2.Set(Tsk.ActualFinish, new DateTime(2000, 2, 10, 17, 0, 0));

            project.Save(OutDir + "EvaluationDateTimeLimitations_out.xml", SaveFileFormat.XML);
            //ExEnd:DateTimeLimitations
        }
        [Test]
        public void ReadBudgetWorkCost()
        {
            //ExStart:ReadBudgetWorkAndCost
            //ExFor: Tsk.BudgetWork
            //ExFor: Tsk.BudgetCost
            //ExSummary: Shows how to read budget work/cost values of task/resource/assignment.
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
            //ExEnd:ReadBudgetWorkAndCost
        }
        
        [Test]
        public void ChangeTaskProgress()
        {
            //ExStart:ChangeTaskProgress
            //ExFor: Tsk.PercentComplete 
            //ExSummary: Shows how to change a task progress by updating of task percent complete.
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
            //ExEnd:ChangeTaskProgress
        }
        
        [Test]
        public void ReadWriteTaskProperties()
        {
            //ExStart:ReadWriteTaskProperties
            //ExFor: Tsk.Id
            //ExFor: Tsk.Uid
            //ExFor: Tsk.Name
            //ExFor: Tsk.Start
            //ExFor: Tsk.Finish
            //ExSummary: Shows how to read/write task properties.
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
            //ExEnd:ReadWriteTaskProperties
        }
        
        [Test]
        public void ReadActualTaskProperties()
        {
            //ExStart:ReadActualTaskProperties
            //ExFor: Tsk.ActualDuration
            //ExFor: Tsk.ActualCost
            //ExSummary: Shows how to read task's actual properties.
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
            //ExEnd:ReadActualTaskProperties
        }
        
        [Test]
        public void ReadTaskPriority()
        {
            //ExStart:ReadTaskPriority
            //ExFor: Tsk.Priority
            //ExSummary: Shows how to read a task priority.
            var project = new Project(DataDir + "TaskPriority.mpp");

            var collector = new ChildTasksCollector();
            TaskUtils.Apply(project.RootTask, collector, 0);

            // Display Priorities for all tasks
            foreach (var task in collector.Tasks)
            {
                Console.WriteLine(task.Get(Tsk.Name) + " - Priority : " + task.Get(Tsk.Priority));
            }
            //ExEnd:ReadTaskPriority
        }
        
        [Test]
        public void CreateSubProjectTask()
        {
            try
            {
                //ExStart:CreateSubProjectTask
                //ExFor: Tsk.SubprojectName
                //ExSummary: Shows how to create a subproject task.
                var project = new Project(DataDir + "SubProjectTask.mpp");

                // Add task
                var task = project.RootTask.Children.Add("Task 1");

                // Setting new subproject link
                task.Set(Tsk.SubprojectName, DataDir + "subProject.mpp");

                // Save project
                project.Save(OutDir + "CreateSubProjectTask_out.mpp", SaveFileFormat.MPP);
                //ExEnd:CreateSubProjectTask
            }
            catch (NotSupportedException ex)
            {
                Console.WriteLine(ex.Message + "\nThis example will only work if you apply a valid Aspose.Tasks License. You can purchase full license or get 30 day temporary license from http://www.aspose.com/purchase/default.aspx.");
            }
        }
        
        [Test]
        public void ReadWriteTaskCalendar()
        {
            //ExStart:ReadWriteTaskCalendar
            //ExFor: Tsk.Calendar
            //ExSummary: Shows how to read/write task calendars.
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
            //ExEnd:ReadWriteTaskCalendar
        }
        
        [Test]
        public void ReadTaskCosts()
        {
            //ExStart:ReadTaskCosts
            //ExFor: Tsk.Cost
            //ExFor: Tsk.RemainingCost
            //ExFor: Tsk.FixedCost
            //ExFor: Tsk.CostVariance
            //ExSummary: Shows how to read task costs.
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
            //ExEnd:ReadTaskCosts
        }
        
        [Test]
        public void ReadTaskOutlineProperties()
        {
            //ExStart:ReadTaskOutlineProperties
            //ExFor: Tsk.OutlineLevel
            //ExFor: Tsk.OutlineNumber
            //ExSummary: Shows how to read task outline properties.
            var project = new Project(DataDir + "TaskOutlineProperties.mpp");

            var collector = new ChildTasksCollector();
            TaskUtils.Apply(project.RootTask, collector, 0);

            // Parse through all the collected tasks
            foreach (var task in collector.Tasks)
            {
                Console.WriteLine(task.Get(Tsk.Name) + " - Outline Level : " + task.Get(Tsk.OutlineLevel));
                Console.WriteLine(task.Get(Tsk.Name) + " - Outline Number : " + task.Get(Tsk.OutlineNumber));
            }
            //ExEnd:ReadTaskOutlineProperties
        }
        
        [Test]
        public void ReadStopResumeDates()
        {
            //ExStart:ReadStopResumeDates
            //ExFor: Tsk.Stop
            //ExFor: Tsk.Resume
            //ExSummary: Shows how to read task's Stop/Resume dates.
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
            //ExEnd:ReadStopResumeDates
        }
        
        [Test]
        public void ReadTaskOvertimes()
        {
            //ExStart:ReadTaskOvertimes
            //ExFor: Tsk.OvertimeCost
            //ExFor: Tsk.OvertimeWork
            //ExSummary: Shows how to read task overtimes.
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
            //ExEnd:ReadTaskOvertimes
        }
        
        [Test]
        public void AddTaskDuration()
        {
            //ExStart:AddTaskDuration
            //ExFor: Tsk.Duration
            //ExFor: Tsk.DurationFormat
            //ExSummary: Shows how to set duration of the task. 
            var project = new Project();

            var task = project.RootTask.Children.Add("Task1");
            task.Set(Tsk.DurationFormat, TimeUnitType.Day);
            task.Set(Tsk.Start, new DateTime(2012, 8, 23, 8, 0, 0));
            task.Set(Tsk.Duration, project.GetDuration(24, TimeUnitType.Hour));
            task.Set(Tsk.ActualStart, new DateTime(2012, 8, 23, 8, 0, 0));

            project.Save(OutDir + "AddTaskDuration_out.xml", SaveFileFormat.XML);
            //ExEnd:AddTaskDuration        
        }
        
        [Test]
        public void TaskWarning()
        {
            //ExStart:TaskWarning
            //ExFor: Tsk.Warning
            //ExSummary: Shows how to read a task warning.
            var project = new Project(DataDir + "schedule-conflict.mpp");
            var task = project.RootTask.Children.GetById(1);
            Console.WriteLine(task.Get(Tsk.Warning));
            //ExEnd:TaskWarning
        }
        
        [Test]
        public void ReadTaskWBS()
        {
            //ExStart:ReadTaskWBS
            //ExFor: Tsk.WBS
            //ExFor: Tsk.WBSLevel
            //ExSummary: Shows how to read task's WBS codes.
            var project = new Project(DataDir + "TaskWBS.mpp");

            var collector = new ChildTasksCollector();
            TaskUtils.Apply(project.RootTask, collector, 0);

            // Parse through all the collected tasks
            foreach (var task in collector.Tasks)
            {
                Console.WriteLine(task.Get(Tsk.WBS));
                Console.WriteLine(task.Get(Tsk.WBSLevel));
            }
            //ExEnd:ReadTaskWBS
        }
        
        [Test]
        public void GetSetTaskConstraint()
        {
            //ExStart:GetSetTaskConstraint
            //ExFor: Tsk.ConstraintType
            //ExFor: Tsk.ConstraintDate
            //ExSummary: Shows how to get/set a constraint for a task.
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

            SaveOptions options = new PdfSaveOptions();
            options.StartDate = project.Get(Prj.StartDate);
            options.Timescale = Timescale.ThirdsOfMonths;
            
            project.Save(OutDir + "SetConstraintAsLateAsPossible_out.pdf", options);
            //ExEnd:GetSetTaskConstraint
        }
        
        [Test]
        public void FindCriticalEffortDrivenTasks()
        {
            //ExStart:FindCriticalEffortDrivenTasks
            //ExFor: Tsk.IsEffortDriven
            //ExFor: Tsk.IsCritical
            //ExSummary: Shows how to find critical and/or effort driven tasks.
            var project = new Project(DataDir + "CriticalEffortDrivenTasks.mpp");

            var collector = new ChildTasksCollector();
            TaskUtils.Apply(project.RootTask, collector, 0);

            // Parse through all the collected tasks
            foreach (var task in collector.Tasks)
            {
                var effortDriven = task.Get(Tsk.IsEffortDriven) ? "EffortDriven" : "Non-EffortDriven";
                var nonCritical = task.Get(Tsk.IsCritical) ? "Critical" : "Non-Critical";
                Console.WriteLine(task.Get(Tsk.Name) + " : " + effortDriven);
                Console.WriteLine(task.Get(Tsk.Name) + " : " + nonCritical);
            }
            //ExEnd:FindCriticalEffortDrivenTasks
        }
        
        [Test]
        public void FindEstimatedMilestoneTasks()
        {
            //ExStart:FindEstimatedMilestoneTasks
            //ExFor: Tsk.IsEstimated
            //ExFor: Tsk.IsMilestone
            //ExSummary: Shows how to find estimated and/or milestone tasks.
            var prj = new Project(DataDir + "EstimatedMilestoneTasks.mpp");

            var collector = new ChildTasksCollector();
            TaskUtils.Apply(prj.RootTask, collector, 0);

            // Iterate over the collected tasks
            foreach (var task in collector.Tasks)
            {
                var estimated = task.Get(Tsk.IsEstimated) ? "Estimated" : "Non-Estimated";
                var milestone = task.Get(Tsk.IsMilestone) ? "Milestone" : "Non-Milestone";
                Console.WriteLine(task.Get(Tsk.Name) + " : " + estimated);
                Console.WriteLine(task.Get(Tsk.Name) + " : " + milestone);
            }
            //ExEnd:FindEstimatedMilestoneTasks
        }
        
        [Test]
        public static void IdentifyCrossProjectTasks()
        {
            //ExStart:IdentifyCrossProjectTasks
            //ExFor: Tsk.ExternalId
            //ExSummary: Shows how to identify cross project tasks.
            var project = new Project(DataDir + "External.mpp");
            var externalTask = project.RootTask.Children.GetByUid(1);

            // Show ID of the task in the external project
            Console.WriteLine(externalTask.Get(Tsk.Id).ToString());
            
            // Show ID of the task in the original project
            Console.WriteLine(externalTask.Get(Tsk.ExternalId).ToString());
            //ExEnd:IdentifyCrossProjectTasks
        }
    }
}