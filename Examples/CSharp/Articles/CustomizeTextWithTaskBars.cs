using Aspose.Tasks.Saving;
using Aspose.Tasks.Visualization;
using System.Collections.Generic;
using System.Drawing;

namespace Aspose.Tasks.Examples.CSharp.Articles
{
    class CustomizeTextWithTaskBars
    {
        public static void Run()
        {
            // The path to the documents directory.
            string dataDir = RunExamples.GetDataDir(System.Reflection.MethodBase.GetCurrentMethod().DeclaringType.FullName);

            //ExStart:CustomizeTextWithTaskBars
            //ExFor: SaveOptions.BarStyles
            //ExSummary: Shows how to customize task bars by using <see cref="T:Aspose.Tasks.Visualization.BarStyle" />s.
            Project project = new Project();

            Task task1 = project.RootTask.Children.Add("Task 1");
            Task task2 = project.RootTask.Children.Add("Task 2");

            task1.Set(Tsk.Duration, project.GetDuration(1, TimeUnitType.Day));
            task2.Set(Tsk.Duration, project.GetDuration(1, TimeUnitType.Day));

            project.TaskLinks.Add(task1, task2, TaskLinkType.FinishToStart);

            Task task3 = project.RootTask.Children.Add("Task 3");
            Resource rsc1 = project.Resources.Add("Resource 1");
            Resource rsc2 = project.Resources.Add("Resource 2");
            Resource rsc3 = project.Resources.Add("Resource 3");

            project.ResourceAssignments.Add(task1, rsc1);
            project.ResourceAssignments.Add(task2, rsc2);
            project.ResourceAssignments.Add(task3, rsc3);

            SaveOptions options = new PdfSaveOptions();
            options.Timescale = Timescale.ThirdsOfMonths;

            BarStyle style = new BarStyle
            {
                ItemType = BarItemType.CriticalTask,
                BarTextConverter = delegate(Task t)
                {
                    return string.Format("This task (ID = {0}) is on critical path", t.Get(Tsk.Id));
                }
            };

            BarStyle style2 = new BarStyle
            {
                BarColor = Color.DarkOrchid, 
                ItemType = BarItemType.Task
            };

            options.BarStyles = new List<BarStyle>
            {
                style, 
                style2
            };

            project.Save(dataDir + "CustomizeTextWithTaskBars.pdf", options);
            //ExEnd:CustomizeTextWithTaskBars
        }
    }
}
