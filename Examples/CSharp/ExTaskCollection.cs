namespace Aspose.Tasks.Examples.CSharp
{
    using System;
    using NUnit.Framework;
    using Saving;

    [TestFixture]
    public class ExTaskCollection : ApiExampleBase
    {
        [Test]
        public void UpdateTaskData()
        {
            try
            {
                //ExStart:UpdateTaskData
                //ExFor: TaskCollection.Add(String)
                //ExSummary: Shows how to build parent-child relation of tasks.
                var project = new Project(DataDir + "UpdateTaskData.mpp");

                // Set project start date
                project.Set(Prj.StartDate, new DateTime(2012, 07, 29, 8, 0, 0));

                // Add summary task and set its properties
                var summary = project.RootTask.Children.Add("Summary task");
                var task = summary.Children.Add("First task");
                task.Set(Tsk.Duration, project.GetDuration(3));
                task.Set(Tsk.Deadline, task.Get(Tsk.Start).AddDays(10));
                task.Set(Tsk.NotesText, "The first task.");
                task.Set(Tsk.DurationFormat, TimeUnitType.MinuteEstimated);
                task.Set(Tsk.ConstraintType, ConstraintType.FinishNoLaterThan);
                task.Set(Tsk.ConstraintDate, task.Get(Tsk.Deadline).AddDays(-1));

                // Create 10 new sub tasks for summary task
                for (var i = 0; i < 10; i++)
                {
                    var child = summary.Children.Add(string.Format("Task {0}", i + 2));
                    child.Set(Tsk.Duration, task.Get(Tsk.Duration).Add(project.GetDuration(i + 1)));
                    child.Set(Tsk.DurationFormat, TimeUnitType.Day);
                    child.Set(Tsk.Deadline, task.Get(Tsk.Deadline).AddDays(i + 1));
                }

                project.Save(OutDir + "project_UpdateTaskData_updated_out.mpp", SaveFileFormat.MPP);
                //ExEnd:UpdateTaskData
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message + "\nThis example will only work if you apply a valid Aspose License. You can purchase full license or get 30 day temporary license from http://www.aspose.com/purchase/default.aspx.");
            }
        }
        
        [Test]
        public void CreateTasks()
        {
            try
            {
                //ExStart:CreateTasks
                //ExFor: Task.Children
                //ExSummary: Shows how to use task collection to add a task.
                var project = new Project();

                // Add task, sub task and save project
                var task = project.RootTask.Children.Add("Summary1");
                task.Children.Add("Subtask1");
                project.Save(OutDir + "CreateTasks_out.xml", SaveFileFormat.XML);
                //ExEnd:CreateTasks
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message + "\nThis example will only work if you apply a valid Aspose License. You can purchase full license or get 30 day temporary license from http://www.aspose.com/purchase/default.aspx.");
            }
        }
        
        [Test]
        public void MoveTaskUnderAnotherParent()
        {        
            try
            {
                //ExStart:MoveTaskUnderAnotherParent
                //ExFor: TaskCollection.Add(Task)
                //ExSummary: Shows how to move a task under another parent.
                var project = new Project(DataDir + "MoveTask.mpp")
                {
                    CalculationMode = CalculationMode.Automatic
                };

                // Get Tasks by Ids
                var task = project.RootTask.Children.GetByUid(6);
                var task2 = project.RootTask.Children.GetByUid(3);

                // Adding Task 6 to another parent
                task2.Children.Add(task);

                project.Save(OutDir + "MoveTaskUnderAnotherParent_out.mpp", SaveFileFormat.MPP);
                //ExEnd:MoveTaskUnderAnotherParent
            }
            catch (Exception exception)
            {
                Console.WriteLine(exception.Message + "\nThis example will only work if you apply a valid Aspose.Tasks License. You can purchase full license or get 30 day temporary license from http://www.aspose.com/purchase/default.aspx.");  
            }
        }
    }
}