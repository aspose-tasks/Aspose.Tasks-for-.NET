/*
This project uses Automatic Package Restore feature of NuGet to resolve Aspose.Tasks for .NET API reference 
when the project is build. Please check https:// Docs.nuget.org/consume/nuget-faq for more information. 
If you do not wish to use NuGet, you can manually download Aspose.Tasks for .NET API from https://www.nuget.org/packages/Aspose.Tasks/, 
install it and then add its reference to this project. For any issues, questions or suggestions 
please feel free to contact us using https://forum.aspose.com/c/tasks
*/

namespace Aspose.Tasks.Examples.CSharp.Articles
{
    using System;
    using System.Collections.Generic;

    using Aspose.Tasks.Saving;
    using Aspose.Tasks.Visualization;

    //ExStart:SortTasksByColumnInGanttChart
    //ExFor: SaveOptions.TasksComparer
    //ExSummary: Shows how to set a comparer to sort tasks on Gantt chart and/or Task Sheet chart.
    internal class SortTasksByColumnInGanttChart
    {
        // The path to the documents directory.
        private static readonly string dataDir = RunExamples.GetDataDir(System.Reflection.MethodBase.GetCurrentMethod().DeclaringType.FullName);
        
        public static void Run()
        {
            var project = new Project(dataDir + "Project2.mpp");
            SaveOptions options = new PdfSaveOptions();
            options.Timescale = Timescale.Months;

            options.TasksComparer = new TasksNameComparer();
            project.Save(dataDir + "SortedByNames_out.pdf", options);

            options.TasksComparer = new TasksDurationComparer();
            project.Save(dataDir + "SortedByDurations_out.pdf", options);
        }

        private class TasksNameComparer : IComparer<Task>
        {
            public int Compare(Task x, Task y)
            {
                // ReSharper disable once ConvertIfStatementToSwitchStatement
                if (x == null && y == null)
                {
                    return 0;
                }

                if (x == null)
                {
                    return -1;
                }

                return y == null ? 1 : string.Compare(x.Get(Tsk.Name), y.Get(Tsk.Name), StringComparison.Ordinal);
            }
        }

        private class TasksDurationComparer : IComparer<Task>
        {
            public int Compare(Task x, Task y)
            {
                // ReSharper disable once ConvertIfStatementToSwitchStatement
                if (x == null && y == null)
                {
                    return 0;
                }

                if (x == null)
                {
                    return -1;
                }

                if (y == null)
                {
                    return 1;
                }
                
                var durX = x.Get(Tsk.Duration);
                var durY = y.Get(Tsk.Duration);
                return durX.TimeSpan.CompareTo(durY.TimeSpan);
            }
        }
    }
    //ExEnd:SortTasksByColumnInGanttChart
}
