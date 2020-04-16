namespace Aspose.Tasks.Examples.CSharp
{
    using System;
    using System.Collections.Generic;
    using NUnit.Framework;

    [TestFixture]
    public class ExTaskBaselineCollection
    {
        [Test]
        public void WorkWithBaselineCollection()
        {                        
            //ExStart
            //ExFor: TaskBaselineCollection
            //ExFor: TaskBaselineCollection.Count
            //ExFor: TaskBaselineCollection.GetEnumerator
            //ExFor: TaskBaselineCollection.ParentTask
            //ExFor: TaskBaselineCollection.Remove(TaskBaseline)
            //ExFor: TaskBaselineCollection.ToList
            //ExSummary: Shows how to work with task baseline collections.
            var project = new Project();

            // create project baselines
            var task = project.RootTask.Children.Add("Task");
            project.SetBaseline(BaselineType.Baseline);

            // print task baselines
            Console.WriteLine("Count of task baselines: " + task.Baselines.Count);
            Console.WriteLine("Parent task: " + task.Baselines.ParentTask);
            foreach (var baseline in task.Baselines)
            {
                Console.WriteLine("Baseline duration: {0}", baseline.Duration);
                Console.WriteLine("Baseline start: {0}", baseline.Start);
                Console.WriteLine("Baseline finish: {0}", baseline.Finish);
            }
            
            // lets clear all baselines
            List<TaskBaseline> baselines = task.Baselines.ToList();
            for (var i = 0; i < baselines.Count; i++)
            {
                task.Baselines.Remove(baselines[i]);
            }
            //ExEnd            
        }
    }
}