using Aspose.Tasks;
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
            //Load MPP file using project reader
            ProjectReader reader = new ProjectReader();
            Project project = reader.Read("Project.mpp");

            //Load all tasks
            ArrayList allTasks = new ArrayList(project.RootTask.Children);


            //Loop through each task and read information related to tasks
            foreach (Aspose.Tasks.Task task in allTasks)
            {
                Console.WriteLine("Reading Task " + task.Name);
                Console.WriteLine("\nID: " + task.Id);
                Console.WriteLine("Start: " + task.Start);
                Console.WriteLine("Finish: " + task.Finish);
                Console.WriteLine("\n===========================\n");

                //Read any other information you need
            }

            //Loop through each resource and read information related to resources
            foreach (Resource resource in project.Resources)
            {
                string resourceType = null;
                switch (resource.Type)
                {
                    case ResourceType.Material:
                        resourceType = "Material";
                        break;
                    case ResourceType.Work:
                        resourceType = "Work";
                        break;
                    default:
                        resourceType = "Cost";
                        break;
                }
                Console.WriteLine("Reading Resource " + resource.Name);
                Console.WriteLine("\nID: " + resource.Id);
                Console.WriteLine("Type: " + resourceType);
                Console.WriteLine("\n===========================\n");

                //Read any other information you need
            }

            Console.ReadLine();

        }
    }
}
