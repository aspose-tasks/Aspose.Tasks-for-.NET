namespace Aspose.Tasks.Examples.CSharp
{
    using System;
    using NUnit.Framework;
    using Saving;

    [TestFixture]
    public class ExTaskLinkCollection : ApiExampleBase
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
    }
}