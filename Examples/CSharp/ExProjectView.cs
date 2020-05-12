namespace Aspose.Tasks.Examples.CSharp
{
    using System;
    using System.Collections.Generic;
    using NUnit.Framework;
    using Saving;
    using Visualization;

    [TestFixture]
    public class ExProjectView : ApiExampleBase
    {
        [Test]
        public void WorkWithProjectView()
        {
            {
                // ExStart
                // ExFor: ProjectView
                // ExFor: ProjectView.GetDefaultAssignmentView
                // ExSummary: Shows how to save a project with assignment view.
                var project = new Project(DataDir + "Project2.mpp");
                SaveOptions options = new PdfSaveOptions
                {
                    Timescale = Timescale.Months,
                    View = ProjectView.GetDefaultAssignmentView()
                };

                project.Save(OutDir + "WorkWithProjectView_AssignmentView_out.pdf", options);
                // ExEnd
            }
            
            {
                // ExStart
                // ExFor: ProjectView.GetDefaultGanttChartView
                // ExSummary: Shows how to save a project with Gantt chart view.
                var project = new Project(DataDir + "Project2.mpp");
                SaveOptions options = new PdfSaveOptions
                {
                    Timescale = Timescale.Months,
                    View = ProjectView.GetDefaultGanttChartView()
                };

                project.Save(OutDir + "WorkWithProjectView_GanttChartView_out.pdf", options);
                // ExEnd
            }
            
            {
                // ExStart
                // ExFor: ProjectView.GetDefaultResourceSheetView
                // ExSummary: Shows how to save a project with resource sheet view.
                var project = new Project(DataDir + "Project2.mpp");
                SaveOptions options = new PdfSaveOptions
                {
                    Timescale = Timescale.Months,
                    View = ProjectView.GetDefaultResourceSheetView()
                };

                project.Save(OutDir + "WorkWithProjectView_ResourceSheetView_out.pdf", options);
                // ExEnd
            }
            
            {
                // ExStart
                // ExFor: ProjectView.GetDefaultResourceUsageView
                // ExSummary: Shows how to save a project with resource usage view.
                var project = new Project(DataDir + "Project2.mpp");
                SaveOptions options = new PdfSaveOptions
                {
                    Timescale = Timescale.Months,
                    View = ProjectView.GetDefaultResourceUsageView()
                };

                project.Save(OutDir + "WorkWithProjectView_ResourceUsageView_out.pdf", options);
                // ExEnd
            }
            
            {
                // ExStart
                // ExFor: ProjectView.GetDefaultTaskSheetView
                // ExSummary: Shows how to save a project with task sheet view.
                var project = new Project(DataDir + "Project2.mpp");
                SaveOptions options = new PdfSaveOptions
                {
                    Timescale = Timescale.Months,
                    View = ProjectView.GetDefaultTaskSheetView()
                };

                project.Save(OutDir + "WorkWithProjectView_TaskSheetView_out.pdf", options);
                // ExEnd
            }

            { 
                // ExStart
                // ExFor: ProjectView.#ctor(System.Collections.Generic.IEnumerable{Aspose.Tasks.Visualization.ViewColumn})
                // ExFor: ProjectView.Columns
                // ExSummary: Shows how to save a project with a view with custom set of columns.
                var project = new Project(DataDir + "Project2.mpp");
                var options = new PdfSaveOptions();
                var columns = new List<ViewColumn>
                {
                    new GanttChartColumn("Name", 100, Field.TaskName),
                    new GanttChartColumn("Start", 100, Field.TaskStart),
                    new GanttChartColumn("Finish", 100, Field.TaskFinish),
                    new GanttChartColumn("Cost2", 80, Field.TaskCost2),
                    new GanttChartColumn("Number6", 80, Field.TaskNumber6),
                    new GanttChartColumn("Date6", 80, Field.TaskDate6),
                    new GanttChartColumn("Flag6", 80, Field.TaskFlag6),
                    new GanttChartColumn("Flag18", 80, Field.TaskFlag18),
                    new GanttChartColumn("Duration6", 80, Field.TaskDuration6)
                };
                options.View = new ProjectView(columns);

                // iterate over view columns
                foreach (var column in options.View.Columns)
                {
                    Console.WriteLine("Column Name: " + column.Name);
                }
                
                options.PresentationFormat = PresentationFormat.TaskUsage;
                project.Save(OutDir + "TaskUsageProjectView_Columns.pdf", options);
                // ExEnd
            }
        }
    }
}