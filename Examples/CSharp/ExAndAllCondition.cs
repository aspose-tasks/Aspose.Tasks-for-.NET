namespace Aspose.Tasks.Examples.CSharp
{
    using System;
    using System.Collections.Generic;
    using NUnit.Framework;
    using Util;

    [TestFixture]
    public class ExAndAllCondition : ApiExampleBase
    {
        // ExStart
        // ExFor: Aspose.Tasks.Util.AndAllCondition`1
        // ExFor: Aspose.Tasks.Util.AndAllCondition`1.#ctor(System.Collections.Generic.List{Aspose.Tasks.Util.ICondition{`0}})
        // ExFor: Aspose.Tasks.Util.AndAllCondition`1.Check(`0)
        // ExSummary: Shows how to use <see cref="Aspose.Tasks.Util.AndAllCondition`1" /> condition.
        [Test] // ExSkip
        public void WorkWithAndAllCondition()
        {
            var project = new Project(DataDir + "Project2.mpp");

            // gather all project tasks
            var coll = new ChildTasksCollector();
            TaskUtils.Apply(project.RootTask, coll, 0);

            var conditions = new List<ICondition<Task>>
                                 {
                                     // create a filter condition that filters not null tasks
                                     new NotNullCondition(),

                                     // create a filter condition that filters summary tasks
                                     new SummaryCondition()
                                 };

            // and join them by applying <see cref="Aspose.Tasks.Util.AndAllCondition`1" /> condition
            var joinedCondition = new AndAllCondition<Task>(conditions);

            // apply the condition to the collected tasks
            List<Task> collection = Filter(coll.Tasks, joinedCondition);
            Console.WriteLine("Filtered tasks: ");
            foreach (var task in collection)
            {
                Console.WriteLine("  Name: " + task.Get(Tsk.Name));

                // work with other properties...
            }

            // ...
        }

        private static List<T> Filter<T>(IEnumerable<T> array, ICondition<T> cond)
        {
            var result = new List<T>();

            foreach (var item in array)
            {
                if (cond.Check(item))
                {
                    result.Add(item);
                }
            }

            return result;
        }

        private class NotNullCondition : ICondition<Task>
        {
            public bool Check(Task el)
            {
                return !el.Get(Tsk.IsNull).Value;
            }
        }

        private class SummaryCondition : ICondition<Task>
        {
            public bool Check(Task el)
            {
                return el.Get(Tsk.IsSummary);
            }
        }

        // ExEnd
    }
}