namespace Aspose.Tasks.Examples.CSharp
{
    using System;
    using System.Collections.Generic;
    using NUnit.Framework;

    [TestFixture]
    public class ExTaskLinkCollection : ApiExampleBase
    {
        [Test]
        public void WorkWithTaskLinkCollection()
        {
            // ExStart:WorkWithTaskLinkCollection
            // ExFor: TaskLinkCollection
            // ExFor: TaskLinkCollection.Add(Task,Task)
            // ExFor: TaskLinkCollection.Add(Task,Task,TaskLinkType)
            // ExFor: TaskLinkCollection.Add(Task,Task,TaskLinkType,Duration)
            // ExFor: TaskLinkCollection.Count
            // ExFor: TaskLinkCollection.GetEnumerator
            // ExFor: TaskLinkCollection.Item(Int32)
            // ExFor: TaskLinkCollection.ParentProject
            // ExFor: TaskLinkCollection.Remove(TaskLink)
            // ExFor: TaskLinkCollection.ToList
            // ExSummary: Shows how to work with task link collections.
            var project = new Project(DataDir + "SampleProject.mpp");

            // get tasks
            var task1 = project.RootTask.Children.GetById(1);
            var task2 = project.RootTask.Children.GetById(2);
            var task3 = project.RootTask.Children.GetById(3);
            var task4 = project.RootTask.Children.GetById(4);
            var task5 = project.RootTask.Children.GetById(5);

            // link the tasks
            project.TaskLinks.Add(task1, task2);
            project.TaskLinks.Add(task2, task3, TaskLinkType.FinishToStart);
            project.TaskLinks.Add(task3, task4, TaskLinkType.FinishToStart);
            project.TaskLinks.Add(task4, task5, TaskLinkType.FinishToStart, project.GetDuration(1, TimeUnitType.Day));
            project.TaskLinks.Add(task2, task5, TaskLinkType.FinishToStart, project.GetDuration(2, TimeUnitType.Day));

            // print links among the tasks
            Console.WriteLine("Print task links of " + project.TaskLinks.ParentProject.Get(Prj.Name) + " project.");
            Console.WriteLine("Task links count: " + project.TaskLinks.Count);
            foreach (var link in project.TaskLinks)
            {
                Console.WriteLine("From ID = " + link.PredTask.Get(Tsk.Id) + " => To ID = " + link.SuccTask.Get(Tsk.Id));
                Console.WriteLine();
            }

            // edit link by index access
            project.TaskLinks[0].LagFormat = TimeUnitType.Hour;

            // remove all task links
            List<TaskLink> taskLinks = project.TaskLinks.ToList();
            foreach (var link in taskLinks)
            {
                project.TaskLinks.Remove(link);
            }

            // ExEnd:WorkWithTaskLinkCollection
        }
    }
}