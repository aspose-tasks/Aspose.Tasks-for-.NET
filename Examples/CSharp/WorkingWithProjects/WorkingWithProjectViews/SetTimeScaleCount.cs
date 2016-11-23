using Aspose.Tasks.Saving;

namespace Aspose.Tasks.Examples.CSharp.WorkingWithProjects.WorkingWithProjectViews
{
    public class SetTimeScaleCount
    {
        public static void Run()
        {
            // The path to the documents directory.
            string dataDir = RunExamples.GetDataDir(System.Reflection.MethodBase.GetCurrentMethod().DeclaringType.FullName);

            // ExStart:SetTimeScaleCount
            Project project = new Project();

            // Init Gantt Chart View
            GanttChartView view = new GanttChartView();

            // Set Time Scale count
            view.BottomTimescaleTier.Count = 2;
            view.BottomTimescaleTier.ShowTicks = false; 
            view.MiddleTimescaleTier.Count = 2;
            view.MiddleTimescaleTier.ShowTicks = false;
            
            // Add Gantt Chart View to project
            project.Views.Add(view);

            // Add some test data to project
            Task task1 = project.RootTask.Children.Add("Task 1");
            Task task2 = project.RootTask.Children.Add("Task 2");
            task1.Set(Tsk.Duration, task1.ParentProject.GetDuration(24, TimeUnitType.Hour));
            task2.Set(Tsk.Duration, task1.ParentProject.GetDuration(40, TimeUnitType.Hour));
            project.Save(dataDir + "SetTimeScaleCount_out.pdf", SaveFileFormat.PDF); 
            // ExEnd:SetTimeScaleCount
        }
    }
}