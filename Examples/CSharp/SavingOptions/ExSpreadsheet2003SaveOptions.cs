namespace Aspose.Tasks.Examples.CSharp.SavingOptions
{
    using NUnit.Framework;
    using Saving;
    using Visualization;

    [TestFixture]
    public class ExSpreadsheet2003SaveOptions : ApiExampleBase
    {
        [Test]
        public void UsingSpreadsheet2003SaveOptions()
        {
            // ExStart:UsingSpreadsheet2003SaveOptions
            // ExFor: Spreadsheet2003SaveOptions
            // ExFor: Spreadsheet2003SaveOptions.#ctor
            // ExFor: Spreadsheet2003SaveOptions.ResourceView
            // ExFor: Spreadsheet2003SaveOptions.AssignmentView
            // ExSummary: Shows how to add columns to be exported during export project into Spreadsheet2003 format.
            var project = new Project(DataDir + "CreateProject2.mpp");

            var options = new Spreadsheet2003SaveOptions();
            var ganttChartColumn = new GanttChartColumn("WBS", 100, delegate(Task task) { return task.Get(Tsk.WBS); });
            options.View.Columns.Add(ganttChartColumn);

            var resourceViewColumn = new ResourceViewColumn("Cost center", 100, delegate(Resource resource) { return resource.Get(Rsc.CostCenter); });
            options.ResourceView.Columns.Add(resourceViewColumn);

            var assignmentViewColumn = new AssignmentViewColumn("Notes", 200, delegate(ResourceAssignment assignment) { return assignment.Get(Asn.NotesText); });
            options.AssignmentView.Columns.Add(assignmentViewColumn);

            project.Save(OutDir + "UsingSpreadsheet2003SaveOptions_out.xml", options);

            // ExEnd:UsingSpreadsheet2003SaveOptions
        }
    }
}