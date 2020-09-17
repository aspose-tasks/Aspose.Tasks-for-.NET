namespace Aspose.Tasks.Examples.CSharp
{
    using System;
    using System.Collections.Generic;
    using System.Diagnostics.CodeAnalysis;
    using NUnit.Framework;
    using Util;

    [TestFixture]
    public class ExRemoveTask : ApiExampleBase
    {
        // ExStart
        // ExFor: RemoveTask
        // ExFor: RemoveTask.#ctor(Aspose.Tasks.Task)
        // ExFor: RemoveTask.Alg(Aspose.Tasks.Task,System.Int32)
        // ExFor: RemoveTask.PostAlg(Aspose.Tasks.Task,System.Int32)
        // ExFor: RemoveTask.PreAlg(Aspose.Tasks.Task,System.Int32)
        // ExSummary: Shows how to use <see cref="Aspose.Tasks.Util.RemoveTask" /> tree based algorithm.
        [Test] // ExSkip
        [SuppressMessage("ReSharper", "UnusedVariable", Justification = "Reviewed. Suppression is OK here.")] // ExSkip
        public void WorkWithRemoveTask()
        {
            var project = new Project(DataDir + "Project1.mpp");
            var task1 = project.RootTask.Children.Add("1");
            var task2 = project.RootTask.Children.Add("2");
            var task3 = project.RootTask.Children.Add("3");
            var task4 = project.RootTask.Children.Add("4");

            List<Task> tasks = new List<Task>(project.RootTask.SelectAllChildTasks());
            Console.WriteLine("Number of tasks before using the algorithm: " + tasks.Count);
            foreach (var task in project.RootTask.SelectAllChildTasks())
            {
                Console.WriteLine("Task Name: " + task.Get(Tsk.Name));
            }

            Console.WriteLine();

            // use tree based algorithm to delete task1 from the tree
            var algorithm = new RemoveTask(task1);

            // apply the algorithm to the task tree
            TaskUtils.Apply(project.RootTask, algorithm, 0);

            // check the results
            tasks = new List<Task>(project.RootTask.SelectAllChildTasks());
            Console.WriteLine("Number of tasks after using the algorithm: " + tasks.Count);
            foreach (var task in project.RootTask.SelectAllChildTasks())
            {
                Console.WriteLine("Task Name: " + task.Get(Tsk.Name));
            }

            // ...
        }

        // ExEnd
    }
}