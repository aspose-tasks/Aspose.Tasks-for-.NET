namespace Aspose.Tasks.Examples.CSharp
{
    using System;
    using NUnit.Framework;

    [TestFixture]
    public class ExTaskBaseline
    {
        [Test]
        public void GetTaskBaselineDuration()
        {                        
            //ExStart:GetTaskBaselineDuration
            //ExFor: TaskBaseline.Duration
            //ExFor: TaskBaseline.Start
            //ExFor: TaskBaseline.Finish
            //ExFor: BaselineType
            //ExFor: BaselineType.Baseline
            //ExFor: BaselineType.Baseline1
            //ExFor: BaselineType.Baseline2
            //ExFor: BaselineType.Baseline3
            //ExFor: BaselineType.Baseline4
            //ExFor: BaselineType.Baseline5
            //ExFor: BaselineType.Baseline6
            //ExFor: BaselineType.Baseline7
            //ExFor: BaselineType.Baseline8
            //ExFor: BaselineType.Baseline9
            //ExFor: BaselineType.Baseline10
            //ExFor: BaselineType.Undefined
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