namespace Aspose.Tasks.Examples.CSharp
{
    using System;
    using NUnit.Framework;
    using Util;

    [TestFixture]
    public class ExChildTasksCollector : ApiExampleBase
    {
        [Test]
        public void WorkWithChildTasksCollector()
        {
            // ExStart:ReadParentChildTasks
            // ExFor: ChildTasksCollector
            // ExFor: ChildTasksCollector.#ctor
            // ExFor: ChildTasksCollector.Tasks
            // ExFor: ChildTasksCollector.Alg(Task,Int32)
            // ExFor: ChildTasksCollector.PostAlg(Task,Int32)
            // ExFor: ChildTasksCollector.PreAlg(Task,Int32)
            // ExSummary: Shows how to iterate over all tasks in a project as a plain list. 
            var project = new Project(DataDir + "ParentChildTasks.mpp");

            var collector = new ChildTasksCollector();
            TaskUtils.Apply(project.RootTask, collector, 0);

            // Parse through all the collected tasks
            foreach (var task in collector.Tasks)
            {
                Console.WriteLine(task.Get(Tsk.Name));
            }

            // ExEnd:ReadParentChildTasks
        }
    }
}