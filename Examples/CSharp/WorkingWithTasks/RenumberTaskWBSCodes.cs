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
    using System.Collections.Generic;
    using System.Linq;

    internal class RenumberTaskWBSCodes
    {
        public static void Run()
        {
            var dataDir = RunExamples.GetDataDir(System.Reflection.MethodBase.GetCurrentMethod());
            
            //ExStart: RenumberTaskWBSCodes
            //ExFor: Tsk.WBS
            //ExFor: Project.RenumberWBSCode
            //ExSummary: Shows how to renumber tasks' WBS codes.
            var project = new Project(dataDir + "RenumberExample.mpp");

            List<Task> tasks = project.RootTask.SelectAllChildTasks().ToList();

            Console.WriteLine("WBS codes before: ");

            // output: ""; "1"; "2"; "4"
            foreach (var task in tasks)
            {
                Console.WriteLine("\"" + task.Get(Tsk.WBS) + "\"" + "; ");
            }

            // project.RenumberWBSCode(); // this overload could have used too
            project.RenumberWBSCode(new List<int> { 1, 2, 3 });

            Console.WriteLine("\nWBS codes after: ");

            // output: ""; "1"; "2"; "3"
            foreach (var task in tasks)
            {
                Console.WriteLine("\"" + task.Get(Tsk.WBS) + "\"" + "; ");
            }
            //ExEnd: RenumberTaskWBSCodes
        }
    }
}
