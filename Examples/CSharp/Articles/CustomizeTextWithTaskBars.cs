namespace Aspose.Tasks.Examples.CSharp.Articles
{
    using System.Collections.Generic;
    using System.Drawing;

    using Aspose.Tasks.Saving;
    using Aspose.Tasks.Visualization;

    internal class CustomizeTextWithTaskBars
    {
        public static void Run()
        {
            // The path to the documents directory.
            var dataDir = RunExamples.GetDataDir(System.Reflection.MethodBase.GetCurrentMethod().DeclaringType.FullName);

            //ExStart:CustomizeTextWithTaskBars
            //ExFor: SaveOptions.BarStyles
            //ExSummary: Shows how to customize task bars by using <see cref="Aspose.Tasks.Visualization.BarStyle" />s.
            var project = new Project();

            var task1 = project.RootTask.Children.Add("Task 1");
            var task2 = project.RootTask.Children.Add("Task 2");

            task1.Set(Tsk.Duration, project.GetDuration(1, TimeUnitType.Day));
            task2.Set(Tsk.Duration, project.GetDuration(1, TimeUnitType.Day));

            project.TaskLinks.Add(task1, task2, TaskLinkType.FinishToStart);

            var task3 = project.RootTask.Children.Add("Task 3");
            var rsc1 = project.Resources.Add("Resource 1");
            var rsc2 = project.Resources.Add("Resource 2");
            var rsc3 = project.Resources.Add("Resource 3");

            project.ResourceAssignments.Add(task1, rsc1);
            project.ResourceAssignments.Add(task2, rsc2);
            project.ResourceAssignments.Add(task3, rsc3);

            SaveOptions options = new PdfSaveOptions();
            options.Timescale = Timescale.ThirdsOfMonths;

            var style = new BarStyle
                            {
                                ItemType = BarItemType.CriticalTask,
                                BarTextConverter = delegate(Task t)
                                    {
                                        return string.Format("This task (ID = {0}) is on critical path", t.Get(Tsk.Id));
                                    }
                            };

            var style2 = new BarStyle
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
