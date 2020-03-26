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

    internal class FindCriticalEffortDrivenTasks
    {
        public static void Run()
        {
            var dataDir = RunExamples.GetDataDir(System.Reflection.MethodBase.GetCurrentMethod());
            
            //ExStart:FindCriticalEffortDrivenTasks
            //ExFor: Tsk.IsEffortDriven
            //ExFor: Tsk.IsCritical
            //ExSummary: Shows how to find critical and/or effort driven tasks.
            // Read project from file stream
            
            var project = new Project(dataDir + "CriticalEffortDrivenTasks.mpp");

            // Create a ChildTasksCollector instance
            var collector = new ChildTasksCollector();

            // Collect all the tasks from RootTask using TaskUtils
            TaskUtils.Apply(project.RootTask, collector, 0);

            // Parse through all the collected tasks
            foreach (var task in collector.Tasks)
            {
                var effortDriven = task.Get(Tsk.IsEffortDriven) ? "EffortDriven" : "Non-EffortDriven";
                var nonCritical = task.Get(Tsk.IsCritical) ? "Critical" : "Non-Critical";
                Console.WriteLine(task.Get(Tsk.Name) + " : " + effortDriven);
                Console.WriteLine(task.Get(Tsk.Name) + " : " + nonCritical);
            }
            //ExEnd:FindCriticalEffortDrivenTasks
        }
    }
}
