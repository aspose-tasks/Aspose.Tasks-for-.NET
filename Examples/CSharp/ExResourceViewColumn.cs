namespace Aspose.Tasks.Examples.CSharp
{
    using NUnit.Framework;
    using Saving;
    using Visualization;

    [TestFixture]
    public class ExResourceViewColumn : ApiExampleBase
    {
        [Test]
        public void UsingAssignmentViewColumn()
        {
            // ExStart:UsingSpreadsheet2003SaveOptions
            // ExFor: ResourceViewColumn
            // ExSummary: Shows how to use add resource view columns to be exported.
            var project = new Project(DataDir + "CreateProject2.mpp");

            var options = new Spreadsheet2003SaveOptions();
            var ganttChartColumn = new GanttChartColumn("WBS", 100, delegate(Task task) { return task.Get(Tsk.WBS); });
            options.View.Columns.Add(ganttChartColumn);

            var resourceViewColumn = new ResourceViewColumn("Cost center", 100, delegate(Resource resource) { return resource.Get(Rsc.CostCenter); });
            options.ResourceView.Columns.Add(resourceViewColumn);

            var assignmentViewColumn = new AssignmentViewColumn("Notes", 200, delegate(ResourceAssignment assignment) { return assignment.Get(Asn.Notes); });
            options.AssignmentView.Columns.Add(assignmentViewColumn);

            project.Save(OutDir + "UsingSpreadsheet2003SaveOptions_out.xml", options);

            // ExEnd:UsingSpreadsheet2003SaveOptions
        }
    }
}