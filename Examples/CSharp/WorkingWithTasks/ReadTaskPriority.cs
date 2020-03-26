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

    internal class ReadTaskPriority
    {
        public static void Run()
        {
            var dataDir = RunExamples.GetDataDir(System.Reflection.MethodBase.GetCurrentMethod());
            
            //ExStart:ReadTaskPriority
            //ExFor: Tsk.Priority
            //ExSummary: Shows how to read a task priority.
            // Read project 
            var project = new Project(dataDir + "TaskPriority.mpp");

            // Create a ChildTasksCollector instance
            var collector = new ChildTasksCollector();

            // Collect all the tasks from RootTask using TaskUtils
            TaskUtils.Apply(project.RootTask, collector, 0);

            // Display Priorities for all tasks
            foreach (var task in collector.Tasks)
            {
                Console.WriteLine(task.Get(Tsk.Name) + " - Priority : " + task.Get(Tsk.Priority));
            }
            //ExEnd:ReadTaskPriority
        }
    }
}
