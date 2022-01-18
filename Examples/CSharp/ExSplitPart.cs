namespace Aspose.Tasks.Examples.CSharp
{
    using System;
    using NUnit.Framework;

    [TestFixture]
    public class ExSplitPart : ApiExampleBase
    {
        [Test]
        public void WorkWithSplitPart()
        {
            // ExStart
            // ExFor: SplitPart
            // ExFor: SplitPart.Start
            // ExFor: SplitPart.Finish
            // ExSummary: Shows how to work with split parts of a splitted task.
            var project = new Project();
            project.Set(Prj.StartDate, new DateTime(2000, 3, 15, 8, 0, 0));
            project.Set(Prj.FinishDate, new DateTime(2000, 3, 21, 17, 0, 0));

            var task = project.RootTask.Children.Add("Task1");
            task.Set(Tsk.IsManual, false);
            task.Set(Tsk.Start, new DateTime(2000, 3, 15, 8, 0, 0));
            task.Set(Tsk.Duration, project.GetDuration(3));

            var assignment = project.ResourceAssignments.Add(task, project.Resources.Add("r1"));
            assignment.Set(Asn.Start, new DateTime(2000, 3, 15, 8, 0, 0));
            assignment.Set(Asn.Work, task.Get(Tsk.Work));
            assignment.Set(Asn.Finish, new DateTime(2000, 3, 19, 17, 0, 0));

            // have to generate resource assignment timephased data first
            assignment.TimephasedDataFromTaskDuration(project.Get(Prj.Calendar));

            // split the task.
            assignment.SplitTask(new DateTime(2000, 3, 16, 8, 0, 0), new DateTime(2000, 3, 17, 17, 0, 0), project.Get(Prj.Calendar));

            // iterate over split parts
            Console.WriteLine("Number of split parts: " + task.SplitParts.Count);
            foreach (var splitPart in task.SplitParts)
            {
                Console.WriteLine("  Split Part Start: " + splitPart.Start);
                Console.WriteLine("  Split Part Finish: " + splitPart.Finish);
                Console.WriteLine();
            }

            // ExEnd
        }

        [Test]
        public void EqualsSplitPart()
        {
            // ExStart
            // ExFor: SplitPart.Equals(Object)
            // ExSummary: Shows how to check split parts equality.
            var project = new Project();
            project.Set(Prj.StartDate, new DateTime(2000, 3, 15, 8, 0, 0));
            project.Set(Prj.FinishDate, new DateTime(2000, 3, 21, 17, 0, 0));

            var task = project.RootTask.Children.Add("Task");
            task.Set(Tsk.IsManual, false);
            task.Set(Tsk.Start, new DateTime(2000, 3, 15, 8, 0, 0));
            task.Set(Tsk.Duration, project.GetDuration(4));

            var assignment = project.ResourceAssignments.Add(task, project.Resources.Add("Resource"));
            assignment.Set(Asn.Start, new DateTime(2000, 3, 15, 8, 0, 0));
            assignment.Set(Asn.Work, task.Get(Tsk.Work));
            assignment.Set(Asn.Finish, new DateTime(2000, 3, 19, 17, 0, 0));

            // have to generate resource assignment timephased data first
            assignment.TimephasedDataFromTaskDuration(project.Get(Prj.Calendar));
            Console.WriteLine(assignment.Get(Asn.Finish));

            // split the task.
            assignment.SplitTask(new DateTime(2000, 3, 16, 8, 0, 0), new DateTime(2000, 3, 17, 17, 0, 0), project.Get(Prj.Calendar));

            // the equality of split parts is checked against to start, finish, and index of split parts.
            var part1 = task.SplitParts[0];
            var part2 = task.SplitParts[1];
            Console.WriteLine("Split Part 1 Start {0} Finish {1}", part1.Start, part1.Finish);
            Console.WriteLine("Split Part 2 Start {0} Finish {1}", part2.Start, part2.Finish);
            Console.WriteLine("Are split parts equal: " + part1.Equals(part2));

            // ExEnd
        }

        [Test]
        public void GetHashCodeSplitPart()
        {
            // ExStart
            // ExFor: SplitPart.GetHashCode
            // ExSummary: Shows how to get a hash code of a split part.
            var project = new Project();
            project.Set(Prj.StartDate, new DateTime(2000, 3, 15, 8, 0, 0));
            project.Set(Prj.FinishDate, new DateTime(2000, 3, 21, 17, 0, 0));

            var task = project.RootTask.Children.Add("Task1");
            task.Set(Tsk.IsManual, false);
            task.Set(Tsk.Start, new DateTime(2000, 3, 15, 8, 0, 0));
            task.Set(Tsk.Duration, project.GetDuration(3));

            var assignment = project.ResourceAssignments.Add(task, project.Resources.Add("r1"));
            assignment.Set(Asn.Start, new DateTime(2000, 3, 15, 8, 0, 0));
            assignment.Set(Asn.Work, task.Get(Tsk.Work));
            assignment.Set(Asn.Finish, new DateTime(2000, 3, 19, 17, 0, 0));

            // have to generate resource assignment timephased data first
            assignment.TimephasedDataFromTaskDuration(project.Get(Prj.Calendar));

            // split the task.
            assignment.SplitTask(new DateTime(2000, 3, 16, 8, 0, 0), new DateTime(2000, 3, 17, 17, 0, 0), project.Get(Prj.Calendar));

            // the equality of split parts is checked against to start, finish, and index of split parts.
            var part1 = task.SplitParts[0];
            var part2 = task.SplitParts[1];

            // the hash code of a split part based on start, finish, and index of a split part. 
            Console.WriteLine("Split Part 1 Start {0} Finish {1} HashCode {2}", part1.Start, part1.Finish, part1.GetHashCode());
            Console.WriteLine("Split Part 2 Start {0} Finish {1} HashCode {2}", part2.Start, part2.Finish, part2.GetHashCode());

            // ExEnd
        }
    }
}