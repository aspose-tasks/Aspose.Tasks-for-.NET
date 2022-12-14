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
        public void CreateCrossProjectTaskLink()
        {
            // ExStart:CreateCrossProjectTaskLink
            // ExFor: TaskLink.CrossProjectName
            // ExFor: TaskLink.IsCrossProject
            // ExFor: Tsk.IsExternalTask
            // ExFor: Tsk.ExternalUid
            // ExFor: Tsk.ExternalId
            // ExFor: Task.ExternalUid
            // ExFor: Task.ExternalId
            // ExSummary: Shows how to create cross project task link - link to task in another (external) project.
            Project project = new Project();
            var summary = project.RootTask.Children.Add("Summary Task");

            // In order to create a link to a task from another project we should create
            // its duplicate (or "external") task in the current project.

            Task t2 = summary.Children.Add("External Task");
            t2.Set(Tsk.ExternalTaskProject, "ExternalProject.mpp"); // here we set path to external project's MPP file.
            t2.Set(Tsk.ExternalId, 1); // Set External task's Id.
            t2.Set(Tsk.ExternalUid, 2); // External task's Unique Id should be set.
            t2.Set(Tsk.IsExternalTask, true);
            t2.Set(Tsk.IsManual, new NullableBool(false));
            t2.Set(Tsk.IsSummary, false);

            Task t = summary.Children.Add("Task");
            TaskLink link = project.TaskLinks.Add(t2, t);
            link.IsCrossProject = true;
            link.LinkType = TaskLinkType.FinishToStart;
            link.CrossProjectName = "ExternalProject.mpp\\\\1"; // <- here external task's Id is used.
            // ExEnd:CreateCrossProjectTaskLink
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
    }
}