using Aspose.Tasks.Util;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

/*
This project uses Automatic Package Restore feature of NuGet to resolve Aspose.Tasks for .NET API reference 
when the project is build. Please check https:// Docs.nuget.org/consume/nuget-faq for more information. 
If you do not wish to use NuGet, you can manually download Aspose.Tasks for .NET API from https://www.nuget.org/packages/Aspose.Tasks/, 
install it and then add its reference to this project. For any issues, questions or suggestions 
please feel free to contact us using https://forum.aspose.com/c/tasks
*/

namespace Aspose.Tasks.Examples.CSharp.WorkingWithTasks.WorkingWithTaskConstraints
{
    class GetConstraints
    {
        public static void Run()
        {
            // ExStart:GetConstraints
            string dataDir = RunExamples.GetDataDir(System.Reflection.MethodBase.GetCurrentMethod().DeclaringType.FullName);
            Project project1 = new Project(dataDir + "Project2.mpp");

            // Create a ChildTasksCollector instance
            ChildTasksCollector collector = new ChildTasksCollector();

            // Collect all the tasks from RootTask using TaskUtils
            TaskUtils.Apply(project1.RootTask, collector, 0);

            // Parse through all the collected tasks
            foreach (Aspose.Tasks.Task tsk1 in collector.Tasks)
            {
                if (tsk1.Get(Tsk.ConstraintDate).ToShortDateString() == "1/1/2000")
                    Console.WriteLine("NA");
                else
                    Console.WriteLine(tsk1.Get(Tsk.ConstraintDate).ToShortDateString());

                Console.WriteLine(tsk1.Get(Tsk.ConstraintType).ToString());
            }
            // ExEnd:GetConstraints
        }
    }
}
