using Aspose.Tasks;
using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aspose_Tasks
{
    class Program
    {
        static void Main(string[] args)
        {
            //Load a project
            ProjectReader rdr = new ProjectReader();
            FileStream St = new FileStream("Project.mpp", FileMode.Open);
            Project prj = rdr.Read(St);
            St.Close();

            //Link the tasks
            TaskLink tsklnk = new TaskLink(prj.RootTask.Children[0] as Aspose.Tasks.Task, prj.RootTask.Children[1] as Aspose.Tasks.Task, TaskLinkType.FinishToStart);
            prj.AddTaskLink(tsklnk);
            tsklnk = new TaskLink(prj.RootTask.Children[1] as Aspose.Tasks.Task, prj.RootTask.Children[2] as Aspose.Tasks.Task, TaskLinkType.FinishToStart);
            prj.AddTaskLink(tsklnk);
            tsklnk = new TaskLink(prj.RootTask.Children[2] as Aspose.Tasks.Task, prj.RootTask.Children[3] as Aspose.Tasks.Task, TaskLinkType.FinishToStart);
            prj.AddTaskLink(tsklnk);
            tsklnk = new TaskLink(prj.RootTask.Children[3] as Aspose.Tasks.Task, prj.RootTask.Children[4] as Aspose.Tasks.Task, TaskLinkType.FinishToStart);
            prj.AddTaskLink(tsklnk);
            tsklnk = new TaskLink(prj.RootTask.Children[1] as Aspose.Tasks.Task, prj.RootTask.Children[4] as Aspose.Tasks.Task, TaskLinkType.FinishToStart);
            prj.AddTaskLink(tsklnk);

            //Display links among the tasks
            ArrayList allinks = new ArrayList(prj.TaskLinks);
            foreach (TaskLink tasklnk in allinks)
            {
                Console.WriteLine("From ID = " + tasklnk.PredTask.Id + "=>To ID = " + tasklnk.SuccTask.Id);
                Console.WriteLine("________________________________________");
            }
            //Save the project
            prj.Save("Project1.mpp", Aspose.Tasks.Saving.SaveFileFormat.MPP);
        }
    }
}
