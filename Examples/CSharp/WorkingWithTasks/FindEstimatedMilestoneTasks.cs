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

    internal class FindEstimatedMilestoneTasks
    {
        public static void Run()
        {
            var dataDir = RunExamples.GetDataDir(System.Reflection.MethodBase.GetCurrentMethod().DeclaringType.FullName);
            
            //ExStart:FindEstimatedMilestoneTasks
            //ExFor: Tsk.IsEstimated
            //ExFor: Tsk.IsMilestone
            //ExSummary: Shows how to find estimated and/or milestone tasks.
            // Read project from file stream
            var prj = new Project(dataDir + "EstimatedMilestoneTasks.mpp");

            // Create a ChildTasksCollector instance
            var collector = new ChildTasksCollector();

            // Collect all the tasks from RootTask using TaskUtils
            TaskUtils.Apply(prj.RootTask, collector, 0);

            // Iterate over the collected tasks
            foreach (var task in collector.Tasks)
            {
                var estimated = task.Get(Tsk.IsEstimated) ? "Estimated" : "Non-Estimated";
                var milestone = task.Get(Tsk.IsMilestone) ? "Milestone" : "Non-Milestone";
                Console.WriteLine(task.Get(Tsk.Name) + " : " + estimated);
                Console.WriteLine(task.Get(Tsk.Name) + " : " + milestone);
            }
            //ExEnd:FindEstimatedMilestoneTasks
        }
    }
}
