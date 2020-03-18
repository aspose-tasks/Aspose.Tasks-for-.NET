namespace Aspose.Tasks.Examples.CSharp.KnowledgeBase
{
    using System;

    using Aspose.Tasks.Saving;

    internal class LinkTasks
    {
        public static void Run()
        {
            try
            {
                var dataDir = RunExamples.GetDataDir(System.Reflection.MethodBase.GetCurrentMethod().DeclaringType.FullName);

                //ExStart:LinkTasks
                //ExFor: Project.TaskLinks.Add(Task, Task, TaskLinkType)
                //ExFor: TaskLink.PredTask
                //ExFor: TaskLink.SuccTask
                //ExSummary: Shows how to add task links.
                var project = new Project(dataDir + "SampleProject.mpp");

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
                var links = project.TaskLinks;
                foreach (var link in links)
                {
                    Console.WriteLine("From ID = " + link.PredTask.Get(Tsk.Id) + "=>To ID = " + link.SuccTask.Get(Tsk.Id));
                    Console.WriteLine("________________________________________");
                }
 
                // Save the project
                project.Save(dataDir + "LinkTasks_out.mpp", SaveFileFormat.MPP);
                //ExEnd:LinkTasks
            }
            catch (NotSupportedException ex)
            {
                Console.WriteLine(ex.Message + "\nThis example will only work if you apply a valid Aspose License. You can purchase full license or get 30 day temporary license from http://www.aspose.com/purchase/default.aspx.");
            }
        }
    }
}
