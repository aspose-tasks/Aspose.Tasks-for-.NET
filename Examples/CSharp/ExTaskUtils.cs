namespace Aspose.Tasks.Examples.CSharp
{
    using System;
    using NUnit.Framework;
    using Util;

    [TestFixture]
    public class ExTaskUtils : ApiExampleBase
    {
        [Test]
        public void WorkWithApply()
        {
            // ExStart
            // ExFor: Util.TaskUtils
            // ExFor: Util.TaskUtils.Apply(Aspose.Tasks.Task,Aspose.Tasks.Util.ITreeAlgorithm{Aspose.Tasks.Task},System.Int32)
            // ExSummary: Shows how to work with a tree algorithm.
            var project = new Project(DataDir + "Project2.mpp");

            // gather all project tasks
            var coll = new ChildTasksCollector();
            TaskUtils.Apply(project.RootTask, coll, 0);
            
            // work with tasks as with a plain list
            foreach (var task in coll.Tasks)
            {
                Console.WriteLine("Task Name: " + task.Get(Tsk.Name));
            }
            // ExEnd
        }
        
        // ExStart
        // ExFor: Util.TaskUtils.Filter(Aspose.Tasks.Task,Aspose.Tasks.Util.ICondition{Aspose.Tasks.Task})
        // ExSummary: Shows how to work with a condition.
        [Test] //ExSkip
        public void WorkWithFilter()
        {
            var project = new Project(DataDir + "Project2.mpp");

            // builds new tree of tasks which satisfy the condition 
            var task = TaskUtils.Filter(project.RootTask, new FilterByDuration(2));
            
            // gather tasks from a tree
            var coll = new ChildTasksCollector();
            TaskUtils.Apply(task, coll, 0);

            // iterate over plain list of tasks 
            // which durations are greater or equal than 2 working days
            foreach (var collTask in coll.Tasks)
            {
                Console.WriteLine("Name: " + collTask.Get(Tsk.Name) + "Duration: " + collTask.Get(Tsk.Duration).TimeSpan);
            }
        }
        
        public class FilterByDuration : ICondition<Task>
        {
            private readonly int days;

            public FilterByDuration(int days)
            {
                this.days = days;
            }

            /// <summary>
            /// Returns true if the specified object satisfy the conditions.
            /// </summary>
            /// <param name="el">The object to check.</param>
            /// <returns>True if the object satisfy the conditions.</returns>
            /// <inheritdoc />
            public bool Check(Task el)
            {
                return el.Get(Tsk.Duration).TimeSpan >= TimeSpan.FromHours(this.days * 8);
            }
        }
        // ExEnd
        
        // ExStart
        // ExFor: Util.TaskUtils.Find(Aspose.Tasks.Task,Aspose.Tasks.Util.ICondition{Aspose.Tasks.Task})
        // ExSummary: Shows how to use <see cref="Aspose.Tasks.Util.TaskUtils.Find" /> method.
        [Test] // ExSkip
        public void WorkWithFind()
        {
            var project = new Project(DataDir + "Project2.mpp");

            // builds new tree of tasks which satisfy the condition 
            var task = TaskUtils.Filter(project.RootTask, new FindByName("Task8"));
            
            // gather tasks from a tree
            var coll = new ChildTasksCollector();
            TaskUtils.Apply(task, coll, 0);

            // iterate over plain list of tasks 
            // which durations are greater or equal than 2 working days
            foreach (var collTask in coll.Tasks)
            {
                Console.WriteLine("Name: " + collTask.Get(Tsk.Name) + "Duration: " + collTask.Get(Tsk.Duration).TimeSpan);
            }
        }
        
        public class FindByName : ICondition<Task>
        {
            private readonly string name;

            public FindByName(string name)
            {
                this.name = name;
            }

            /// <summary>
            /// Returns true if the specified object satisfy the conditions.
            /// </summary>
            /// <param name="el">The object to check.</param>
            /// <returns>True if the object satisfy the conditions.</returns>
            /// <inheritdoc />
            public bool Check(Task el)
            {
                return el.Get(Tsk.Name) == this.name;
            }
        }
        // ExEnd
        
        [Test]
        public void WorkWithTaskChildrenCount()
        {
            // ExStart
            // ExFor: Util.TaskUtils.TaskChildrenCount(Aspose.Tasks.Task)
            // ExSummary: Shows how to use <see cref="Aspose.Tasks.Util.TaskUtils.TaskChildrenCount" /> method.
            var project = new Project(DataDir + "Project2.mpp");

            // recursively calculates a number of task's children tasks through all levels
            var count = TaskUtils.TaskChildrenCount(project.RootTask);

            Console.WriteLine("Number of tasks: " + count);
            // ExEnd
        }
    }
}