namespace Aspose.Tasks.Examples.CSharp.WorkingWithProjects.WorkingWithProjectViews
{
    using Aspose.Tasks.Saving;
    using Visualization;

    internal class SetTimeScaleCount
    {
        public static void Run()
        {
            var dataDir = RunExamples.GetDataDir(System.Reflection.MethodBase.GetCurrentMethod());

            //ExStart:SetTimeScaleCount
            //ExFor: GanttChartView.TopTimescaleTier
            //ExFor: GanttChartView.MiddleTimescaleTier
            //ExFor: GanttChartView.BottomTimescaleTier
            //ExSummary: Shows how to modify timescale tiers.
            var project = new Project();

            // Init Gantt Chart View
            var view = new GanttChartView();
            view.TopTimescaleTier = new TimescaleTier();
            view.MiddleTimescaleTier = new TimescaleTier();
            view.BottomTimescaleTier = new TimescaleTier();

            // Set Time Scale count
            view.TopTimescaleTier.Count = 2;
            view.TopTimescaleTier.ShowTicks = false;
            view.MiddleTimescaleTier.Count = 2;
            view.MiddleTimescaleTier.ShowTicks = false;
            view.BottomTimescaleTier.Count = 2;
            view.BottomTimescaleTier.ShowTicks = false;
            
            // Add Gantt Chart View to project
            project.Views.Add(view);

            // Add some test data to project
            var task1 = project.RootTask.Children.Add("Task 1");
            var task2 = project.RootTask.Children.Add("Task 2");
            task1.Set(Tsk.Duration, task1.ParentProject.GetDuration(24, TimeUnitType.Hour));
            task2.Set(Tsk.Duration, task1.ParentProject.GetDuration(40, TimeUnitType.Hour));
            project.Save(dataDir + "SetTimeScaleCount_out.pdf", SaveFileFormat.PDF); 
            //ExEnd:SetTimeScaleCount
        }
    }
}