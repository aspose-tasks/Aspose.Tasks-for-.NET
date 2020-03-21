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

    internal class ReadActualTaskProperties
    {
        public static void Run()
        {
            // The path to the documents directory.
            var dataDir = RunExamples.GetDataDir(System.Reflection.MethodBase.GetCurrentMethod().DeclaringType.FullName);
            
            //ExStart:ReadActualTaskProperties
            //ExFor: Tsk.ActualStart
            //ExFor: Tsk.ActualFinish
            //ExFor: Tsk.ActualDuration
            //ExFor: Tsk.ActualCost
            //ExSummary: Shows how to read task's actual properties.
            // Create Project instance
            var project = new Project(dataDir + "ActualTaskProperties.mpp");

            // Create a ChildTasksCollector instance
            var collector = new ChildTasksCollector();

            // Collect all the tasks from RootTask using TaskUtils
            TaskUtils.Apply(project.RootTask, collector, 0);

            // Parse through all the collected tasks
            foreach (var task in collector.Tasks)
            {
                Console.WriteLine("Task Name : " + task.Get(Tsk.Name));
                Console.WriteLine("Actual Start: " + task.Get(Tsk.ActualStart).ToLongDateString());
                Console.WriteLine("Actual Finish: " + task.Get(Tsk.ActualFinish).ToLongDateString());
                Console.WriteLine("Actual Duration: " + task.Get(Tsk.ActualDuration).TimeSpan.Hours);
                Console.WriteLine("Actual Cost: " + task.Get(Tsk.ActualCost));
                Console.WriteLine("---------------------------------------------");
            }
            //ExEnd:ReadActualTaskProperties
        }
    }
}
