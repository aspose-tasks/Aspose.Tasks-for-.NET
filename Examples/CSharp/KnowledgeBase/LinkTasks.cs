using Aspose.Tasks.Saving;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Aspose.Tasks.Examples.CSharp.KnowledgeBase
{
    class LinkTasks
    {
        public static void Run()
        {
            try
            {
                string dataDir = RunExamples.GetDataDir(System.Reflection.MethodBase.GetCurrentMethod().DeclaringType.FullName);

                // ExStart:LinkTasks            
                Project project = new Project(dataDir + "SampleProject.mpp");

                Task task1 = project.RootTask.Children.GetById(1);
                Task task2 = project.RootTask.Children.GetById(2);
                Task task3 = project.RootTask.Children.GetById(3);
                Task task4 = project.RootTask.Children.GetById(4);
                Task task5 = project.RootTask.Children.GetById(5);

                // Link the tasks
                TaskLink tsklnk = project.TaskLinks.Add(task1, task2, TaskLinkType.FinishToStart);
                tsklnk = project.TaskLinks.Add(task2, task3, TaskLinkType.FinishToStart);
                tsklnk = project.TaskLinks.Add(task3, task4, TaskLinkType.FinishToStart);               
                tsklnk = project.TaskLinks.Add(task4, task5, TaskLinkType.FinishToStart);
                tsklnk = project.TaskLinks.Add(task2, task5, TaskLinkType.FinishToStart);
                
                // Display links among the tasks
                TaskLinkCollection allinks = project.TaskLinks;
                foreach (TaskLink tasklnk in allinks)
                {
                    Console.WriteLine("From ID = " + tasklnk.PredTask.Get(Tsk.Id) + "=>To ID = " + tasklnk.SuccTask.Get(Tsk.Id));
                    Console.WriteLine("________________________________________");
                }
 
                // Save the project
                project.Save(dataDir + "LinkTasks_out.mpp", SaveFileFormat.MPP);
                // ExEnd:LinkTasks
            }
            catch (NotSupportedException ex)
            {
                Console.WriteLine(ex.Message + "\nThis example will only work if you apply a valid Aspose License. You can purchase full license or get 30 day temporary license from http://www.aspose.com/purchase/default.aspx.");
            }
        }
    }
}
