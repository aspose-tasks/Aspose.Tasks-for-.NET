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
    using System.IO;

    using Aspose.Tasks.Util;

    internal class ReadStopResumeDates
    {
        public static void Run()
        {
            var dataDir = RunExamples.GetDataDir(System.Reflection.MethodBase.GetCurrentMethod().DeclaringType.FullName);
            
            //ExStart:ReadStopResumeDates
            //ExFor: Tsk.Stop
            //ExFor: Tsk.Resume
            //ExSummary: Shows how to read task's Stop/Resume dates.
            // Read the project
            var project = new Project(dataDir + "StopResumeDates.mpp");

            // Create a ChildTasksCollector instance
            var collector = new ChildTasksCollector();

            // Collect all the tasks from RootTask using TaskUtils
            TaskUtils.Apply(project.RootTask, collector, 0);

            // Check Stop and Resume dates for all tasks
            foreach (var task in collector.Tasks)
            {
                if (task.Get(Tsk.Stop).ToShortDateString() == "1/1/2000")
                {
                    Console.WriteLine("Stop: NA");
                }
                else
                {
                    Console.WriteLine("Stop: " + task.Get(Tsk.Stop).ToShortDateString());
                }

                if (task.Get(Tsk.Resume).ToShortDateString() == "1/1/2000")
                {
                    Console.WriteLine("Resume: NA");
                }
                else
                {
                    Console.WriteLine("Resume: " + task.Get(Tsk.Resume).ToShortDateString());
                }
            }
            //ExEnd:ReadStopResumeDates
        }
    }
}
