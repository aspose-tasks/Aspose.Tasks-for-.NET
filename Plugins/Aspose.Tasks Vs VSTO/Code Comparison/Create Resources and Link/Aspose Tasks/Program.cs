using Aspose.Tasks;
using Aspose.Tasks.Util;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aspose_Tasks
{
    class Program
    {
        static void Main(string[] args)
        {
            Project prj = new Project("Project.mpp");

            //Declare ChildTasksCollector class object
            ChildTasksCollector collector = new ChildTasksCollector();

            //Use TaskUtils to get all children tasks in RootTask
            TaskUtils.Apply(prj.RootTask, collector, 0);

            //Define Resources
            ArrayList resources = new ArrayList();
            for (int i = 1; i <= 5; i++)
            {
                string devloper = "Developer0" + i;
                //Create resource
                Resource rec = new Resource(devloper);
                rec.Type = ResourceType.Work;

                //Add resource to project
                prj.Resources.Add(rec);

                //define assignment
                ResourceAssignment ra = new ResourceAssignment((Aspose.Tasks.Task)collector.Tasks[i], rec);
                prj.ResourceAssignments.Add(ra);
            }

            prj.CalcResourceUids();
            prj.CalcResourceIds();
            prj.CalcResourceFields();
            prj.CalcResourceAssignmentUids();
            prj.CalcResourceAssignmentIds();

            prj.Save("Project1_CSharp_Aspose.mpp", Aspose.Tasks.Saving.SaveFileFormat.MPP);
            Console.WriteLine("Press any key to continue...");
            Console.ReadKey();
        }
    }
}
