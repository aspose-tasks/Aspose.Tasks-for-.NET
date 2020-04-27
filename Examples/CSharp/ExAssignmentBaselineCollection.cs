namespace Aspose.Tasks.Examples.CSharp
{
    using System;
    using System.Collections.Generic;
    using Aspose.Tasks;
    using NUnit.Framework;

    [TestFixture]
    public class ExAssignmentBaselineCollection : ApiExampleBase
    {
        [Test]
        public void WorkWithAssignmentBaselineCollection()
        {
            // ExStart
            // ExFor: AssignmentBaselineCollection
            // ExFor: AssignmentBaselineCollection.ParentAssignment
            // ExFor: AssignmentBaselineCollection.Count
            // ExFor: AssignmentBaselineCollection.GetEnumerator
            // ExFor: AssignmentBaselineCollection.Remove(AssignmentBaseline)
            // ExFor: AssignmentBaselineCollection.ToList
            // ExSummary: Shows how to read assignment baselines.
            var project = new Project(DataDir + "AssignmentBaseline2007.mpp");

            // read assignment baseline information
            foreach (var assignment in project.ResourceAssignments)
            {
                var baselines = assignment.Baselines;
                Console.WriteLine("Count of assignment baselines: " + baselines.Count);
                Console.WriteLine("Parent Assignment: " + baselines.ParentAssignment);
                foreach (var baseline in baselines)
                {
                    Console.WriteLine("Baseline Start: " + baseline.Start);
                    Console.WriteLine("Baseline Finish: " + baseline.Finish);
                }

                Console.WriteLine();
            }

            Console.WriteLine("Delete all assignment baselines: ");

            // delete assignment baselines
            foreach (var assignment in project.ResourceAssignments)
            {
                List<AssignmentBaseline> baselines = assignment.Baselines.ToList();
                foreach (var baseline in baselines)
                {
                    assignment.Baselines.Remove(baseline);
                }
            }

            // ExEnd
        }
    }
}