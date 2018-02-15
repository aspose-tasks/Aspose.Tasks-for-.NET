using Aspose.Tasks.Saving;
using Aspose.Tasks.Visualization;
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

namespace Aspose.Tasks.Examples.CSharp.Articles
{
    // ExStart:SortTasksByColumnInGanttChart
    class SortTasksByColumnInGanttChart
    {
        public static void Run()
        {
            // The path to the documents directory.
            string dataDir = RunExamples.GetDataDir(System.Reflection.MethodBase.GetCurrentMethod().DeclaringType.FullName);

            Project project = new Project(dataDir + "Project2.mpp");
            SaveOptions options = new PdfSaveOptions();
            options.Timescale = Timescale.Months;

            options.TasksComparer = new TasksNameComparer();
            project.Save(dataDir + "SortedByNames_out.pdf", options);

            options.TasksComparer = new TasksDurationComparer();
            project.Save(dataDir + "SortedByDurations_out.pdf", options);
        }

        public class TasksNameComparer : IComparer<Task>
        {
            public int Compare(Task x, Task y)
            {                
                return x.Get(Tsk.Name).CompareTo(y.Get(Tsk.Name));
            }
        }

        public class TasksDurationComparer : IComparer<Task>
        {
            public int Compare(Task x, Task y)
            {
                Duration durX = x.Get(Tsk.Duration);
                Duration durY = y.Get(Tsk.Duration);
                return durX.TimeSpan.CompareTo(durY.TimeSpan);
            }
        }
    }
    // ExEnd:SortTasksByColumnInGanttChart
}
