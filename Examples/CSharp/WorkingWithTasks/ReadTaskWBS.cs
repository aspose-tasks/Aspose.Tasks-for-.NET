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

    using Aspose.Tasks.Saving;
    using Aspose.Tasks.Util;

    internal class ReadTaskWBS
    {
        public static void Run()
        {
            var dataDir = RunExamples.GetDataDir(System.Reflection.MethodBase.GetCurrentMethod());
            
            //ExStart:ReadTaskWBS
            //ExFor: Tsk.WBS
            //ExFor: Tsk.WBSLevel
            //ExSummary: Shows how to read task's WBS codes.
            // Read project
            var project = new Project(dataDir + "TaskWBS.mpp");

            // Create a ChildTasksCollector instance
            var collector = new ChildTasksCollector();

            // Collect all the tasks from RootTask using TaskUtils
            TaskUtils.Apply(project.RootTask, collector, 0);

            // Parse through all the collected tasks
            foreach (var task in collector.Tasks)
            {
                Console.WriteLine(task.Get(Tsk.WBS));
                Console.WriteLine(task.Get(Tsk.WBSLevel));
            }
            //ExEnd:ReadTaskWBS

            // Save project as PDF
            project.Save(dataDir + "TaskWBS_out.pdf", SaveFileFormat.PDF);
        }
    }
}
