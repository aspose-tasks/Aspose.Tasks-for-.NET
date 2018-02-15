using Aspose.Tasks.Util;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;

/*
This project uses Automatic Package Restore feature of NuGet to resolve Aspose.Tasks for .NET API reference 
when the project is build. Please check https:// Docs.nuget.org/consume/nuget-faq for more information. 
If you do not wish to use NuGet, you can manually download Aspose.Tasks for .NET API from https://www.nuget.org/packages/Aspose.Tasks/, 
install it and then add its reference to this project. For any issues, questions or suggestions 
please feel free to contact us using https://forum.aspose.com/c/tasks
*/

namespace Aspose.Tasks.Examples.CSharp.WorkingWithTasks
{
    class ReadStopResumeDates
    {
        public static void Run()
        {
            // ExStart:ReadStopResumeDates
            // Read project from file stream
            string dataDir = RunExamples.GetDataDir(System.Reflection.MethodBase.GetCurrentMethod().DeclaringType.FullName);
            FileStream fs = new FileStream(dataDir + "StopResumeDates.mpp", FileMode.Open);
            Project prj = new Project(fs);
            fs.Close();

            // Create a ChildTasksCollector instance
            ChildTasksCollector collector = new ChildTasksCollector();

            // Collect all the tasks from RootTask using TaskUtils
            TaskUtils.Apply(prj.RootTask, collector, 0);

            // Check Stop and Resume dates for all tasks
            foreach (Task tsk1 in collector.Tasks)
            {
                if (tsk1.Get(Tsk.Stop).ToShortDateString() == "1/1/2000")
                    Console.WriteLine("Stop: NA");
                else
                    Console.WriteLine("Stop: " + tsk1.Get(Tsk.Stop).ToShortDateString());

                if (tsk1.Get(Tsk.Resume).ToShortDateString() == "1/1/2000")
                    Console.WriteLine("Resume: NA");
                else
                    Console.WriteLine("Resume: " + tsk1.Get(Tsk.Resume).ToShortDateString());
            }
            // ExEnd:ReadStopResumeDates
        }
    }
}
