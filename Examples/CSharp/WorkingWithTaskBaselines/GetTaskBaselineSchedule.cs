namespace Aspose.Tasks.Examples.CSharp.WorkingWithTaskBaselines
{
    using System;

    internal class GetTaskBaselineSchedule
    {
        public static void Run()
        {
            //ExStart:GetTaskBaselineSchedule
            // Create project instance
            var project = new Project();
            
            // Creating TaskBaseline
            var task = project.RootTask.Children.Add("Task");
            project.SetBaseline(BaselineType.Baseline);

            // Display task baseline schedule
            var baseline = task.Baselines.ToList()[0];
            Console.WriteLine("Baseline duration is 1 day: {0}", baseline.Duration.ToString().Equals("1 day"));
            Console.WriteLine("BaselineStart is same as Task Start: {0}", baseline.Start.Equals(task.Get(Tsk.Start)));
            Console.WriteLine("BaselineFinish is same as Task Finish: {0}", baseline.Finish.Equals(task.Get(Tsk.Finish)));
            //ExEnd:GetTaskBaselineSchedule
        }
    }
}
