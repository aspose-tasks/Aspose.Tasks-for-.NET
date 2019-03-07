using Aspose.Tasks.Saving;
using Aspose.Tasks.Visualization;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;

namespace Aspose.Tasks.Examples.CSharp.Articles
{
    class CustomizeTextWithTaskBars
    {
        public static void Run()
        {
            // The path to the documents directory.
            string dataDir = RunExamples.GetDataDir(System.Reflection.MethodBase.GetCurrentMethod().DeclaringType.FullName);

            // ExStart:CustomizeTextWithTaskBars
            Project project = new Project();

            Task task1 = project.RootTask.Children.Add("Task 1");
            Task task2 = project.RootTask.Children.Add("Task 2");

            task1.Set(Tsk.Duration, project.GetDuration(1, TimeUnitType.Day));
            task2.Set(Tsk.Duration, project.GetDuration(1, TimeUnitType.Day));

            TaskLink link = project.TaskLinks.Add(task1, task2, TaskLinkType.FinishToStart);

            Task task3 = project.RootTask.Children.Add("Task 3");
            Resource rsc1 = project.Resources.Add("Resource 1");
            Resource rsc2 = project.Resources.Add("Resource 2");
            Resource rsc3 = project.Resources.Add("Resource 3");

            ResourceAssignment assn1 = project.ResourceAssignments.Add(task1, rsc1);
            ResourceAssignment assn2 = project.ResourceAssignments.Add(task2, rsc2);
            ResourceAssignment assn3 = project.ResourceAssignments.Add(task3, rsc3);

            SaveOptions options = new PdfSaveOptions();
            options.Timescale = Timescale.ThirdsOfMonths;

            BarStyle style = new BarStyle();
            style.ItemType = BarItemType.CriticalTask;

            style.BarTextConverter = delegate (Task t)
            {
                return string.Format("This task is on critical path");
            };

            BarStyle style2 = new BarStyle();
            style2.BarColor = Color.DarkOrchid;
            style2.ItemType = BarItemType.Task;

            options.BarStyles = new List<BarStyle>();
            options.BarStyles.Add(style);
            options.BarStyles.Add(style2);

            project.Save(dataDir + "result2.pdf", options);
            // ExEnd:CustomizeTextWithTaskBars
        }
    }
}
