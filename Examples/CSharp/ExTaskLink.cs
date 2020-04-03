namespace Aspose.Tasks.Examples.CSharp
{
    using System;
    using NUnit.Framework;

    [TestFixture]
    public class ExTaskLinks : ApiExampleBase
    {
        [Test]
        public void GetSetTaskLinkType()
        {
            //ExStart:GetSetTaskLinkType
            //ExFor: TaskLink.LinkType
            //ExSummary: Shows how to get/set a link type of a task link.
            var project = new Project();
            
            // Add new tasks
            var pred = project.RootTask.Children.Add("Task 1");
            var succ = project.RootTask.Children.Add("Task 2");

            // Link tasks with link type set to Start to Start
            var newLink = project.TaskLinks.Add(pred, succ);
            newLink.LinkType = TaskLinkType.StartToStart;
            
            foreach (var link in project.TaskLinks)
            {
                Console.WriteLine(link.LinkType.ToString());
            }
            //ExEnd:GetSetTaskLinkType
        }
        
        [Test]
        public void GetCrossProjectTaskLinks()
        {
            //ExStart:GetCrossProjectTaskLinks
            //ExFor: TaskLink.CrossProjectName
            //ExSummary: Shows how to find cross project task links. 
            var project = new Project(DataDir + "GetCrossProjectTaskLinks.mpp");

            // Check cross project task links
            foreach (var taskLink in project.TaskLinks)
            {
                if (taskLink.IsCrossProject)
                {
                    Console.WriteLine(taskLink.CrossProjectName);
                }
            }
            //ExEnd:GetCrossProjectTaskLinks
        }

        [Test]
        public static void WorkWithTaskLinks()
        {
            //ExStart:WorkWithTaskLinks
            //ExFor: TaskLink.PredTask
            //ExFor: TaskLink.SuccTask
            //ExSummary: Shows how to read project task links.
            var project = new Project(DataDir + "GetPredecessorSuccessorTasks.mpp");

            // Display names of predecessor and successor tasks
            foreach (var taskLink in project.TaskLinks)
            {
                Console.WriteLine("Predecessor " + taskLink.PredTask.Get(Tsk.Name));
                Console.WriteLine("Successor " + taskLink.SuccTask.Get(Tsk.Name));
            }
            //ExEnd:WorkWithTaskLinks
        }
    }
}