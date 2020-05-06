namespace Aspose.Tasks.Examples.CSharp
{
    using System;
    using NUnit.Framework;

    [TestFixture]
    public class ExTaskBaseline : ApiExampleBase
    {
        [Test]
        public void WorkWithTaskBaseline()
        {
            // ExStart:WorkWithTaskBaseline
            // ExFor: TaskBaseline
            // ExFor: TaskBaseline.Start
            // ExFor: TaskBaseline.Duration
            // ExFor: TaskBaseline.DurationFormat
            // ExFor: TaskBaseline.EstimatedDuration
            // ExFor: TaskBaseline.Finish
            // ExFor: TaskBaseline.FixedCost
            // ExFor: TaskBaseline.Interim
            // ExFor: TaskBaseline.TimephasedData
            // ExSummary: Shows how to get access to a baseline information.
            var project = new Project();

            // Creating TaskBaseline
            var task = project.RootTask.Children.Add("Task");
            project.SetBaseline(BaselineType.Baseline);

            // Display task baseline duration
            var baseline = task.Baselines.ToList()[0];
            Console.WriteLine("Baseline Start: {0}", baseline.Start);
            Console.WriteLine("Baseline duration: {0}", baseline.Duration);
            Console.WriteLine("Baseline duration format: {0}", baseline.DurationFormat);
            Console.WriteLine("Is it estimated duration?: {0}", baseline.EstimatedDuration);
            Console.WriteLine("Baseline Finish: {0}", baseline.Finish);

            // value indicating whether this is an Interim Baseline
            Console.WriteLine("Interim: {0}", baseline.Interim);
            Console.WriteLine("Fixed Cost: {0}", baseline.FixedCost);

            // print timephased data of task baseline
            Console.WriteLine("Number of timephased items: " + baseline.TimephasedData.Count);
            foreach (var data in baseline.TimephasedData)
            {
                Console.WriteLine(" Uid: " + data.Uid);
                Console.WriteLine(" Start: " + data.Start);
                Console.WriteLine(" Finish: " + data.Finish);
            }

            // ExEnd:WorkWithTaskBaseline            
        }

        [Test]
        public void EqualsTaskBaseline()
        {
            // ExStart
            // ExFor: TaskBaseline.CompareTo(TaskBaseline)
            // ExFor: TaskBaseline.Equals(TaskBaseline)
            // ExFor: TaskBaseline.Equals(Object)
            // ExSummary: Shows how to check equality of baselines. 
            var project = new Project();

            // creating TaskBaseline
            var task = project.RootTask.Children.Add("Task");
            project.SetBaseline(BaselineType.Baseline);

            // display task baseline duration
            var baseline1 = task.Baselines.ToList()[0];
            var baseline2 = task.Baselines.ToList()[0];

            // the equality of baselines is checked against to baseline's numbers.
            Console.WriteLine("Baseline Number 1: " + baseline1.BaselineNumber);
            Console.WriteLine("Baseline Number 2: " + baseline2.BaselineNumber);
            Console.WriteLine("Are baselines equal: " + baseline1.Equals(baseline2));

            // ExEnd            
        }

        [Test]
        public void GetHashCodeTaskBaseline()
        {
            // ExStart
            // ExFor: TaskBaseline.GetHashCode
            // ExSummary: Shows how to get hash code of a task baseline.
            var project = new Project();

            // creating TaskBaseline
            var task = project.RootTask.Children.Add("Task");
            project.SetBaseline(BaselineType.Baseline);

            // display task baseline duration
            var baseline1 = task.Baselines.ToList()[0];
            var baseline2 = task.Baselines.ToList()[0];

            // the hash code of a calendar is equal to baseline number 
            Console.WriteLine("Baseline 1 Number: {0} Hash Code: {1}", (int)baseline1.BaselineNumber, baseline1.GetHashCode());
            Console.WriteLine("Baseline 2 Number: {0} Hash Code: {1}", (int)baseline2.BaselineNumber, baseline2.GetHashCode());

            // ExEnd            
        }
    }
}