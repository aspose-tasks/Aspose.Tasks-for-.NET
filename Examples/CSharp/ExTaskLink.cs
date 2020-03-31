namespace Aspose.Tasks.Examples.CSharp
{
    using System;
    using NUnit.Framework;
    using Saving;

    [TestFixture]
    public class ExTaskLinks : ApiExampleBase
    {
        [Test]
        public void AddTaskLinks()
        {
            try
            {
                //ExStart:AddTaskLinks
                //ExFor: TaskLinkCollection
                //ExFor: TaskLinkCollection.Add(Task, Task, TaskLinkType)
                //ExSummary: Shows how to add task links.
                var project = new Project(DataDir + "SampleProject.mpp");

                var task1 = project.RootTask.Children.GetById(1);
                var task2 = project.RootTask.Children.GetById(2);
                var task3 = project.RootTask.Children.GetById(3);
                var task4 = project.RootTask.Children.GetById(4);
                var task5 = project.RootTask.Children.GetById(5);

                // Link the tasks
                project.TaskLinks.Add(task1, task2, TaskLinkType.FinishToStart);
                project.TaskLinks.Add(task2, task3, TaskLinkType.FinishToStart);
                project.TaskLinks.Add(task3, task4, TaskLinkType.FinishToStart);               
                project.TaskLinks.Add(task4, task5, TaskLinkType.FinishToStart);
                project.TaskLinks.Add(task2, task5, TaskLinkType.FinishToStart);
                
                // Display links among the tasks
                foreach (var link in project.TaskLinks)
                {
                    Console.WriteLine("From ID = " + link.PredTask.Get(Tsk.Id) + "=>To ID = " + link.SuccTask.Get(Tsk.Id));
                    Console.WriteLine("________________________________________");
                }
 
                project.Save(OutDir + "AddTaskLinks_out.mpp", SaveFileFormat.MPP);
                //ExEnd:AddTaskLinks
            }
            catch (NotSupportedException ex)
            {
                Console.WriteLine(ex.Message + "\nThis example will only work if you apply a valid Aspose License. You can purchase full license or get 30 day temporary license from http://www.aspose.com/purchase/default.aspx.");
            }
        }
        
        [Test]
        public void CreateTaskLinks()
        {
            //ExStart:CreateTaskLinks
            //ExFor: Project.TaskLinks
            //ExSummary: Shows how to create task links.
            var project = new Project();
            
            // Add new tasks
            var pred = project.RootTask.Children.Add("Task 1");
            var succ = project.RootTask.Children.Add("Task 2");

            // Links tasks
            project.TaskLinks.Add(pred, succ);
            
            foreach (var link in project.TaskLinks)
            {
                Console.WriteLine("Predecessor Task: " + link.PredTask);
                Console.WriteLine("Successor Task: " + link.SuccTask);
                Console.WriteLine("LagFormat: " + link.LagFormat);
                Console.WriteLine("LinkType: " + link.LinkType);
                Console.WriteLine("LinkLag: " + link.LinkLag);
                Console.WriteLine("CrossProjectName: " + link.CrossProjectName);
                Console.WriteLine("IsCrossProject: " + link.IsCrossProject);
            }
            //ExEnd:CreateTaskLinks
        }
        
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
        public static void IdentifyCrossProjectTasks()
        {
            //ExStart:IdentifyCrossProjectTasks
            //ExFor: Tsk.ExternalId
            //ExSummary: Shows how to identify cross project tasks.
            var project = new Project(DataDir + "External.mpp");
            var externalTask = project.RootTask.Children.GetByUid(1);

            // Show ID of the task in the external project
            Console.WriteLine(externalTask.Get(Tsk.Id).ToString());
            
            // Show ID of the task in the original project
            Console.WriteLine(externalTask.Get(Tsk.ExternalId).ToString());
            //ExEnd:IdentifyCrossProjectTasks
        }
        
        [Test]
        public static void WorkWithPredecessors()
        {
            //ExStart:WorkWithPredecessors
            //ExFor: Project.GetPredecessors(Task)
            //ExSummary: Shows how to get predecessors for the specific task.
            var project = new Project(DataDir + "GetPredecessorSuccessorTasks.mpp");
            var task = project.RootTask.Children.GetById(10);

            var predecessors = project.GetPredecessors(task);
            
            // Display names of predecessor and successor tasks
            foreach (var predecessor in predecessors)
            {
                Console.WriteLine("Predecessor " + predecessor.PredTask.Get(Tsk.Name));
                Console.WriteLine("Successor " + predecessor.SuccTask.Get(Tsk.Name));
            }
            //ExEnd:WorkWithPredecessors
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