using System;
using Aspose.Tasks.Saving;
using Aspose.Tasks.Visualization;

namespace Aspose.Tasks.Examples.CSharp.WorkingWithProjects.WorkingWithProjectViews
{
    public class CustomizeTimescaleTierLabels
    {
        public static void Run()
        {
            // ExStart:CustomizeTimescaleTierLabels
            // The path to the documents directory.
            string dataDir = RunExamples.GetDataDir(System.Reflection.MethodBase.GetCurrentMethod().DeclaringType.FullName);
            
            Project project = new Project(dataDir + "Project5.mpp");

            // Here is just some test data
            project.TaskLinks.Add(project.RootTask.Children.Add("Task 1"), project.RootTask.Children.Add("Task 2"));
            GanttChartView view = (GanttChartView)project.DefaultView;
            
            // This code is added for better visualization
            view.MiddleTimescaleTier.Unit = TimescaleUnit.Months;
            project.Set(Prj.TimescaleStart, new DateTime(2012, 8, 6));
            
            // Customize middle tier dates
            view.MiddleTimescaleTier.DateTimeConverter =
            date => new[] { "Янв.", "Фев.", "Мар.", "Апр.", "Май", "Июнь", "Июль", "Авг.", "Сен.", "Окт.", "Ноя.", "Дек." }[date.Month - 1];
            project.Save(dataDir + "CustomizeTimescaleTierLabels_out.pdf", SaveFileFormat.PDF);
            // ExEnd:CustomizeTimescaleTierLabels
        }
    }
}