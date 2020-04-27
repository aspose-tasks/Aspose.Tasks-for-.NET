namespace Aspose.Tasks.Examples.CSharp
{
    using System;
    using System.Collections.Generic;
    using NUnit.Framework;
    using Util;

    [TestFixture]
    public class ExNot : ApiExampleBase
    {
        // ExStart
        // ExFor: Util.Not`1
        // ExFor: Util.Not`1.#ctor(ICondition{`0})
        // ExFor: Util.Not`1.Check(`0)
        // ExSummary: Shows how to use <see cref="Aspose.Tasks.Util.Not`1" /> condition.
        [Test] // ExSkip
        public void WorkWithNot()
        {
            var project = new Project(DataDir + "Project2.mpp");

            // gather all project tasks
            var coll = new ChildTasksCollector();
            TaskUtils.Apply(project.RootTask, coll, 0);

            // create a filter condition
            var filter = new NullCondition();

            // and reverse it by applying <see cref="Aspose.Tasks.Util.Not`1" /> condition
            var condition = new Not<Task>(filter);

            // apply the condition to the collected tasks
            List<Task> collection = Filter(coll.Tasks, condition);
            foreach (var task in collection)
            {
                Console.WriteLine("Name: " + task.Get(Tsk.Name));

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

        private class NullCondition : ICondition<Task>
        {
            public bool Check(Task el)
            {
                return el.Get(Tsk.IsNull).Value;
            }
        }

        // ExEnd
    }
}