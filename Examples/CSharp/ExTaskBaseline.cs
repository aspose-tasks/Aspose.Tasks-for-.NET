namespace Aspose.Tasks.Examples.CSharp
{
    using System;
    using NUnit.Framework;

    public class ExTaskBaseline
    {
        [Test]
        public void CreateTaskBaselineForTasks()
        {
            //ExStart:CreateTaskBaselineForTasks
            //ExFor: Project.SetBaseline(BaselineType,IEnumerable{Aspose.Tasks.Task})
            //ExSummary: Shows how to create set baselines for specific tasks.
            var project = new Project();

            // Adding tasks
            var task = project.RootTask.Children.Add("Task");
            var task2 = project.RootTask.Children.Add("Task2");

            // Set baseline for specified tasks
            project.SetBaseline(BaselineType.Baseline, new[] {task, task2});
            //ExEnd:CreateTaskBaselineForTasks
        }

        [Test]
        public void CreateTaskBaseline()
        {
            //ExStart:CreateTaskBaseline
            //ExFor: Project.SetBaseline(BaselineType)
            //ExSummary: Shows how to create baselines for a whole project.
            var project = new Project();

            // Adding tasks
            project.RootTask.Children.Add("Task");
            project.RootTask.Children.Add("Task2");

            // Set baseline for specified tasks
            project.SetBaseline(BaselineType.Baseline);
            //ExEnd:CreateTaskBaseline
        }
        
        [Test]
        public void GetTaskBaselineDuration()
        {                        
            //ExStart:GetTaskBaselineDuration
            //ExFor: TaskBaseline.Duration
            //ExFor: TaskBaseline.Start
            //ExFor: TaskBaseline.Finish
            //ExSummary: Shows how to get access to a baseline information.
            var project = new Project();

            // Creating TaskBaseline
            var task = project.RootTask.Children.Add("Task");
            project.SetBaseline(BaselineType.Baseline);

            // Display task baseline duration
            var baseline = task.Baselines.ToList()[0];
            Console.WriteLine("Baseline duration is 1 day: {0}", baseline.Duration.ToString().Equals("1 day"));
            Console.WriteLine("BaselineStart is same as Task Start: {0}", baseline.Start.Equals(task.Get(Tsk.Start)));
            Console.WriteLine("BaselineFinish is same as Task Finish: {0}", baseline.Finish.Equals(task.Get(Tsk.Finish)));
            //ExEnd:GetTaskBaselineDuration            
        }
    }
}