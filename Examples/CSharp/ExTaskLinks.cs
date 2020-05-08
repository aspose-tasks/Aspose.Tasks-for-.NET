namespace Aspose.Tasks.Examples.CSharp
{
    using System;
    using System.Diagnostics.CodeAnalysis;

    using NUnit.Framework;

    [TestFixture]
    [SuppressMessage("ReSharper", "RedundantToStringCall", Justification = "Reviewed. Suppression is OK here.")]
    public class ExTaskLinks : ApiExampleBase
    {
        [Test]
        [SuppressMessage("ReSharper", "RedundantToStringCallForValueType", Justification = "Reviewed. Suppression is OK here.")]
        public void GetSetTaskLinkType()
        {
            // ExStart:GetSetTaskLinkType
            // ExFor: TaskLink.LinkType
            // ExFor: TaskLinkType
            // ExSummary: Shows how to get/set a link type of a task link.
            var project = new Project();

            // Add new tasks
            var pred = project.RootTask.Children.Add("Task 1");
            var succ = project.RootTask.Children.Add("Task 2");

            // Link tasks with link type set to Start to Start
            var newLink = project.TaskLinks.Add(pred, succ);
            newLink.LinkType = TaskLinkType.StartToStart;

            foreach (var link in project.TaskLinks)
            {
                Console.WriteLine("Task Link Type: " + link.LinkType.ToString());
            }

            // ExEnd:GetSetTaskLinkType
        }

        [Test]
        public void GetCrossProjectTaskLinks()
        {
            // ExStart:GetCrossProjectTaskLinks
            // ExFor: TaskLink.CrossProjectName
            // ExFor: TaskLink.IsCrossProject
            // ExFor: TaskLink.ToString
            // ExSummary: Shows how to find cross project task links. 
            var project = new Project(DataDir + "GetCrossProjectTaskLinks.mpp");

            // Check cross project task links
            foreach (var taskLink in project.TaskLinks)
            {
                Console.WriteLine("Task Link: " + taskLink.ToString());
                if (taskLink.IsCrossProject)
                {
                    Console.WriteLine(taskLink.CrossProjectName);
                }
            }

            // ExEnd:GetCrossProjectTaskLinks
        }

        [Test]
        public static void WorkWithTaskLinks()
        {
            // ExStart:WorkWithTaskLinks
            // ExFor: TaskLink
            // ExFor: TaskLink.PredTask
            // ExFor: TaskLink.SuccTask
            // ExFor: TaskLink.LagFormat
            // ExFor: TaskLink.LinkLag
            // ExSummary: Shows how to read project task links.
            var project = new Project(DataDir + "GetPredecessorSuccessorTasks.mpp");

            // Display names of predecessor and successor tasks
            foreach (var taskLink in project.TaskLinks)
            {
                Console.WriteLine("Predecessor: " + taskLink.PredTask.Get(Tsk.Name));
                Console.WriteLine("Successor: " + taskLink.SuccTask.Get(Tsk.Name));
                Console.WriteLine("Lag Format: " + taskLink.LagFormat);
                Console.WriteLine("Link Lag: " + taskLink.LinkLag);
                Console.WriteLine();
            }

            // ExEnd:WorkWithTaskLinks
        }

        [Test]
        public static void EqualsTaskLink()
        {
            // ExStart
            // ExFor: TaskLink.Equals(TaskLink)
            // ExFor: TaskLink.Equals(Object)
            // ExSummary: Shows how to check equality of task links.
            var project = new Project(DataDir + "GetPredecessorSuccessorTasks.mpp");

            var link1 = project.TaskLinks[0];
            var link2 = project.TaskLinks[1];

            // the equality of task links is based on pred and succ tasks.
            Console.Write("Link 1 Pred: " + link1.PredTask.ToString());
            Console.Write("Link 1 Succ: " + link1.SuccTask.ToString());
            Console.Write("Link 2 Pred: " + link2.PredTask.ToString());
            Console.Write("Link 2 Succ: " + link2.SuccTask.ToString());
            Console.Write("Are task links equal: " + link1.Equals(link2));

            // ExEnd
        }

        [Test]
        public static void GetHashCodeTaskLink()
        {
            // ExStart
            // ExFor: TaskLink.GetHashCode
            // ExSummary: Shows how to get a hash code of a task link.
            var project = new Project(DataDir + "GetPredecessorSuccessorTasks.mpp");

            var link1 = project.TaskLinks[0];
            var link2 = project.TaskLinks[1];

            // the hash code of a task link is based on hashes of predecessor and successor task 
            Console.WriteLine(
                "Task Link 1 Pred Hash Code: {0} Succ Hash Code: {1} Hash Code: {2}",
                link1.PredTask.GetHashCode(),
                link1.SuccTask.GetHashCode(),
                link1.GetHashCode());
            Console.WriteLine(
                "Task Link 2 Pred Hash Code: {0} Succ Hash Code: {1} Hash Code: {2}",
                link2.PredTask.GetHashCode(),
                link2.SuccTask.GetHashCode(),
                link2.GetHashCode());

            // ExEnd
        }
    }
}