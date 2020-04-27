namespace Aspose.Tasks.Examples.CSharp
{
    using System;
    using System.Collections.Generic;
    using NUnit.Framework;

    [TestFixture]
    public class ExTaskCollection : ApiExampleBase
    {
        [Test]
        public void MoveTaskUnderAnotherParent()
        {
            // ExStart:MoveTaskUnderAnotherParent
            // ExFor: TaskCollection.Add(Task)
            // ExSummary: Shows how to move a task under another parent.
            var project = new Project(DataDir + "MoveTask.mpp") { CalculationMode = CalculationMode.Automatic };

            // Get Tasks by Ids
            var task = project.RootTask.Children.GetByUid(6);
            var task2 = project.RootTask.Children.GetByUid(3);

            // Adding Task 6 to another parent
            task2.Children.Add(task);

            // ExEnd:MoveTaskUnderAnotherParent
        }

        [Test]
        public void WorkWithTaskCollection()
        {
            // ExStart:WorkWithTaskCollection
            // ExFor: TaskCollection
            // ExFor: TaskCollection.Add
            // ExFor: TaskCollection.Add(String)
            // ExFor: TaskCollection.Add(RecurringTaskParameters)
            // ExFor: TaskCollection.Add(String,Int32)
            // ExFor: TaskCollection.Count
            // ExFor: TaskCollection.GetById(Int32)
            // ExFor: TaskCollection.GetByUid(Int32)
            // ExFor: TaskCollection.GetEnumerator
            // ExFor: TaskCollection.IsReadOnly
            // ExFor: TaskCollection.ParentProject
            // ExFor: TaskCollection.ToList
            // ExSummary: Shows how to work with task collections.
            var project = new Project();

            // the task collection is not read-only and can be extended
            Console.WriteLine("Is task collection read - only: " + project.RootTask.Children.IsReadOnly);

            // create tasks
            var task1 = project.RootTask.Children.Add();
            task1.Set(Tsk.Name, "Task 1");
            task1.Set(Tsk.Start, new DateTime(2020, 4, 15, 8, 0, 0));
            task1.Set(Tsk.Duration, project.GetDuration(1, TimeUnitType.Day));
            task1.Set(Tsk.Finish, new DateTime(2020, 4, 15, 17, 0, 0));
            var task3 = project.RootTask.Children.Add("Task 3");
            task3.Set(Tsk.Start, new DateTime(2020, 4, 15, 8, 0, 0));
            task3.Set(Tsk.Duration, project.GetDuration(1, TimeUnitType.Day));
            task3.Set(Tsk.Finish, new DateTime(2020, 4, 15, 17, 0, 0));
            var task2 = project.RootTask.Children.Add("Task 2", 2);
            task2.Set(Tsk.Start, new DateTime(2020, 4, 15, 8, 0, 0));
            task2.Set(Tsk.Duration, project.GetDuration(1, TimeUnitType.Day));

            // print project tasks
            Console.WriteLine("Count of tasks: " + project.RootTask.Children.Count);
            foreach (var child in project.RootTask.Children)
            {
                Console.WriteLine("Parent Project: " + project.RootTask.ParentProject.Get(Prj.Name));
                Console.WriteLine("Task name: " + child.Get(Tsk.Name));
                Console.WriteLine("Task start: " + child.Get(Tsk.Start));
                Console.WriteLine("Task duration: " + child.Get(Tsk.Duration));
                Console.WriteLine("Task finish: " + child.Get(Tsk.Finish));
                Console.WriteLine();
            }

            // a task can be taken from the collection by ID
            var task1ToEdit = project.RootTask.Children.GetById(1);
            task1ToEdit.Set(Tsk.Name, "Task 1 (Edited)");

            // or by UID
            var taskToEdit2 = project.RootTask.Children.GetByUid(2);
            taskToEdit2.Set(Tsk.Name, "Task 2 (Edited)");

            // also one can add a recurring task
            var parameters = new RecurringTaskParameters
                                 {
                                     TaskName = "t1",
                                     Duration = project.GetDuration(1, TimeUnitType.Day),
                                     RecurrencePattern = new DailyRecurrencePattern
                                                             {
                                                                 Repetition = new DailyCalendarRepetition { RepetitionInterval = 1 },
                                                                 RecurrenceRange = new EndByRecurrenceRange
                                                                                       {
                                                                                           Start = new DateTime(2020, 4, 13, 8, 0, 0),
                                                                                           Finish = new DateTime(2021, 4, 13, 17, 0, 0)
                                                                                       }
                                                             }
                                 };

            // the first task in a sequence is returned
            var recurring = project.RootTask.Children.Add(parameters);
            Console.WriteLine("Task name: " + recurring.Get(Tsk.Name));

            // the collection can be converted into a plain list
            List<Task> tasks = project.RootTask.Children.ToList();
            foreach (var task in tasks)
            {
                task.Delete();
            }

            // ExEnd:WorkWithTaskCollection
        }
    }
}