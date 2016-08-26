using Aspose.Tasks.Saving;

namespace Aspose.Tasks.Examples.CSharp.ModifyingCreatedProject
{
    public class SetTimeScaleCount
    {
        public static void Run()
        {
            // ExStart:SetTimeScaleCount
            // The path to the documents directory.
            string dataDir = RunExamples.GetDataDir_ModifyingCreatedProject();
            Project project = new Project();
            GanttChartView view = new GanttChartView();
            view.BottomTimescaleTier.Count = 2;
            view.BottomTimescaleTier.ShowTicks = false; // Tick lines check box in MSP
            view.MiddleTimescaleTier.Count = 2;
            view.MiddleTimescaleTier.ShowTicks = false;
            project.Views.Add(view);
            // Add some test data to project
            Task task1 = project.RootTask.Children.Add("Task 1");
            Task task2 = project.RootTask.Children.Add("Task 2");
            task1.Set(Tsk.Duration, task1.ParentProject.GetDuration(24, TimeUnitType.Hour));
            task2.Set(Tsk.Duration, task1.ParentProject.GetDuration(40, TimeUnitType.Hour));
            project.Save(dataDir + "SetTimeScaleCount_out.pdf", SaveFileFormat.PDF); // Result is in attached screenshot
            // ExEnd:SetTimeScaleCount
        }
    }
}