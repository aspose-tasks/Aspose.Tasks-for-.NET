namespace Aspose.Tasks.Examples.CSharp
{
    using System;
    using NUnit.Framework;

    [TestFixture]
    public class ExAssignmentBaseline : ApiExampleBase
    {
        [Test]
        public void WorkWithAssignmentBaseline()
        {
            // ExStart
            // ExFor: AssignmentBaseline
            // ExFor: AssignmentBaseline.CompareTo(AssignmentBaseline)
            // ExFor: AssignmentBaseline.Equals(AssignmentBaseline)
            // ExFor: AssignmentBaseline.Equals(Object)
            // ExFor: AssignmentBaseline.GetHashCode
            // ExFor: AssignmentBaseline.Finish
            // ExFor: AssignmentBaseline.Start
            // ExFor: AssignmentBaseline.TimephasedData
            // ExFor: Baseline
            // ExFor: Baseline.BaselineNumber
            // ExFor: Baseline.Bcwp
            // ExFor: Baseline.Bcws
            // ExFor: Baseline.Cost
            // ExFor: Baseline.Work
            // ExFor: Baseline.GetHashCode
            // ExFor: Baseline.Equals(Object)
            // ExFor: Baseline.Equals(Baseline)
            // ExFor: Baseline.CompareTo(Baseline)
            // ExFor: Baseline.op_Equality(Baseline,Baseline)
            // ExFor: Baseline.op_GreaterThan(Baseline,Baseline)
            // ExFor: Baseline.op_GreaterThanOrEqual(Baseline,Baseline)
            // ExFor: Baseline.op_Inequality(Baseline,Baseline)
            // ExFor: Baseline.op_LessThan(Baseline,Baseline)
            // ExFor: Baseline.op_LessThanOrEqual(Baseline,Baseline)
            // ExSummary: Shows how to work with baselines of assignments.
            var project = new Project(DataDir + "AssignmentBaseline2007.mpp");

            // assignment baselines are set when one sets the baseline on whole project
            project.SetBaseline(BaselineType.Baseline);

            // read assignment baseline information
            foreach (var assignment in project.ResourceAssignments)
            {
                foreach (var baseline in assignment.Baselines)
                {
                    Console.WriteLine("Baseline Start: " + baseline.Start);
                    Console.WriteLine("Baseline Finish: " + baseline.Finish);
                    Console.WriteLine("Baseline Number: " + baseline.BaselineNumber);
                    Console.WriteLine("Bcwp: " + baseline.Bcwp);
                    Console.WriteLine("Bcws: " + baseline.Bcws);
                    Console.WriteLine("Cost: " + baseline.Cost);
                    Console.WriteLine("Work: " + baseline.Work);
                    if (baseline.TimephasedData != null)
                    {
                        foreach (var td in baseline.TimephasedData)
                        {
                            Console.WriteLine("TD Start: " + td.Start);
                            Console.WriteLine("TD Finish: " + td.Finish);
                            Console.WriteLine("TD Timephased Data Type: " + td.TimephasedDataType);
                            Console.WriteLine();
                        }
                    }

                    Console.WriteLine();
                }

                Console.WriteLine();
            }

            // check baseline equality
            var assn1 = project.ResourceAssignments.GetByUid(5);
            var assn2 = project.ResourceAssignments.GetByUid(7);

            var assignmentBaseline1 = assn1.Baselines.ToList()[0];
            var assignmentBaseline2 = assn2.Baselines.ToList()[0];

            // baselines can be compared by using 'Equals' method overloads
            Console.WriteLine("Are baselines equal: " + assignmentBaseline1.Equals(assignmentBaseline2));

            // or by using overloaded arithmetic operation
            Console.WriteLine("Is baseline 1 less than baseline 2: " + (assignmentBaseline1 < assignmentBaseline2));

            // the baseline hashcode is based on baseline number
            Console.WriteLine("Assignment baseline 1 hashcode: " + assignmentBaseline1.GetHashCode());
            Console.WriteLine("Assignment baseline 2 hashcode: " + assignmentBaseline2.GetHashCode());

            // ExEnd
        }
    }
}