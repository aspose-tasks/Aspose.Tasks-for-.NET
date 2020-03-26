namespace Aspose.Tasks.Examples.CSharp.KnowledgeBase
{
    using System;

    internal class ReadTaskAndResources
    {
        public static void Run()
        {
            var dataDir = RunExamples.GetDataDir(System.Reflection.MethodBase.GetCurrentMethod());

            //ExStart:ReadTaskAndResources
            //ExFor: Project.Resources
            //ExFor: Task.Children
            //ExFor: Tsk.Name
            //ExFor: Rsc.Type
            //ExFor: Rsc.Name
            //ExSummary: Shows how to read task and resources.
            var project = new Project(dataDir + "Project1.mpp");

            // Load all tasks
            var tasks = project.RootTask.Children;

            Console.WriteLine();
            Console.WriteLine("===========================");
            
            // Loop through each task and read information related to tasks
            foreach (var task in tasks)
            {
                Console.WriteLine("Reading Task " + task.Get(Tsk.Name));
                Console.WriteLine("ID: " + task.Get(Tsk.Id));
                Console.WriteLine("Start: " + task.Get(Tsk.Start));
                Console.WriteLine("Finish: " + task.Get(Tsk.Finish));
                Console.WriteLine("===========================");
            }

            Console.WriteLine();
            Console.WriteLine("===========================");
            
            // Loop through each resource and read information related to resources
            foreach (var resource in project.Resources)
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
                Console.WriteLine("ID: " + resource.Get(Rsc.Id));
                Console.WriteLine("Type: " + resourceType);
                Console.WriteLine("===========================");
            }
            //ExEnd:ReadTaskAndResources
        }
    }
}
