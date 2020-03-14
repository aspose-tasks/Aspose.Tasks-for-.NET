using System;

namespace Aspose.Tasks.Examples.CSharp.KnowledgeBase
{
    class ReadTaskAndResources
    {
        public static void Run()
        {
            string dataDir = RunExamples.GetDataDir(System.Reflection.MethodBase.GetCurrentMethod().DeclaringType.FullName);

            //ExStart:ReadTaskAndResources
            // Load MPP file
            Project project = new Project(dataDir + "Project1.mpp");

            // Load all tasks
            TaskCollection allTasks = project.RootTask.Children;

            // Loop through each task and read information related to tasks
            foreach (Task task in allTasks)
            {
                Console.WriteLine("Reading Task " + task.Get(Tsk.Name));
                Console.WriteLine("\nID: " + task.Get(Tsk.Id));
                Console.WriteLine("Start: " + task.Get(Tsk.Start));
                Console.WriteLine("Finish: " + task.Get(Tsk.Finish));
                Console.WriteLine("\n===========================\n");
            }

            // Loop through each resource and read information related to resources
            foreach (Resource resource in project.Resources)
            {
                string resourceType;
                switch (resource.Get(Rsc.Type))
                {
                    case ResourceType.Material:
                        resourceType = "Material";
                        break;
                    case ResourceType.Work:
                        resourceType = "Work";
                        break;
                    case ResourceType.Cost:
                        resourceType = "Cost";
                        break;
                    default:
                        throw new ArgumentOutOfRangeException();
                }

                Console.WriteLine("Reading Resource " + resource.Get(Rsc.Name));
                Console.WriteLine("\nID: " + resource.Get(Rsc.Id));
                Console.WriteLine("Type: " + resourceType);
                Console.WriteLine("\n===========================\n");
            }
            //ExEnd:ReadTaskAndResources
        }
    }
}
