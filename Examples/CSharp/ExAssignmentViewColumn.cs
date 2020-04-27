namespace Aspose.Tasks.Examples.CSharp
{
    using System;
    using NUnit.Framework;
    using Saving;
    using Visualization;

    [TestFixture]
    public class ExAssignmentViewColumn : ApiExampleBase
    {
        [Test]
        public void UsingAssignmentViewColumn()
        {
            // ExStart:UsingSpreadsheet2003SaveOptions
            // ExFor: AssignmentViewColumn
            // ExFor: AssignmentViewColumn.#ctor(String,Int32,AssignmentToColumnTextConverter)
            // ExFor: AssignmentViewColumn.Field
            // ExSummary: Shows how to use add columns for assignment views.
            var project = new Project(DataDir + "CreateProject2.mpp");

            var options = new Spreadsheet2003SaveOptions();
            var ganttChartColumn = new GanttChartColumn("WBS", 100, delegate(Task task) { return task.Get(Tsk.WBS); });
            options.View.Columns.Add(ganttChartColumn);

            var resourceViewColumn = new ResourceViewColumn("Cost center", 100, delegate(Resource resource) { return resource.Get(Rsc.CostCenter); });
            options.ResourceView.Columns.Add(resourceViewColumn);

            var assignmentViewColumn = new AssignmentViewColumn("Notes", 200, delegate(ResourceAssignment assignment) { return assignment.Get(Asn.Notes); });
            options.AssignmentView.Columns.Add(assignmentViewColumn);

            foreach (var column in options.AssignmentView.Columns)
            {
                Console.WriteLine(column.Field);
            }

            project.Save(OutDir + "UsingSpreadsheet2003SaveOptions_out.xml", options);

            // ExEnd:UsingSpreadsheet2003SaveOptions
        }
    }
}