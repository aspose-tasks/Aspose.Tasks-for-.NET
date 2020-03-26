/*
This project uses Automatic Package Restore feature of NuGet to resolve Aspose.Tasks for .NET API reference 
when the project is build. Please check https:// Docs.nuget.org/consume/nuget-faq for more information. 
If you do not wish to use NuGet, you can manually download Aspose.Tasks for .NET API from https://www.nuget.org/packages/Aspose.Tasks/, 
install it and then add its reference to this project. For any issues, questions or suggestions 
please feel free to contact us using https://forum.aspose.com/c/tasks
*/

namespace Aspose.Tasks.Examples.CSharp.WorkingWithTasks
{
    using System;

    using Aspose.Tasks.Util;

    internal class ReadTaskProperties
    {
        public static void Run()
        {
            var dataDir = RunExamples.GetDataDir(System.Reflection.MethodBase.GetCurrentMethod());
            
            //ExStart:ReadTaskProperties
            //ExFor: ChildTasksCollector.Tasks
            //ExFor: Tsk.Id
            //ExFor: Tsk.Uid
            //ExFor: Tsk.Name
            //ExFor: Tsk.Start
            //ExFor: Tsk.Finish
            //ExSummary: Shows how to read task properties.
            var prj = new Project(dataDir + "ReadTaskProperties.mpp");

            // Create a ChildTasksCollector instance
            var collector = new ChildTasksCollector();

            // Collect all the tasks from RootTask using TaskUtils
            TaskUtils.Apply(prj.RootTask, collector, 0);

            // Parse through all the collected tasks
            foreach (var tsk in collector.Tasks)
            {
                Console.WriteLine("Task Id: {0}", tsk.Get(Tsk.Id));
                Console.WriteLine("Task Uid: {0}", tsk.Get(Tsk.Uid));
                Console.WriteLine("Task Name: {0}", tsk.Get(Tsk.Name));
                Console.WriteLine("Task Start: {0}", tsk.Get(Tsk.Start));
                Console.WriteLine("Task Finish: {0}", tsk.Get(Tsk.Finish));
            }
            //ExEnd:ReadTaskProperties
        }
    }
}
