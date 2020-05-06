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
        public void WorkWithAssignmentViewColumn()
        {
            // ExStart
            // ExFor: AssignmentViewColumn
            // ExFor: AssignmentViewColumn.#ctor(String,Int32,AssignmentToColumnTextConverter)
            // ExFor: AssignmentViewColumn.Field
            // ExFor: AssignmentViewColumn.GetColumnText(ResourceAssignment)
            // ExFor: AssignmentToColumnTextConverter
            // ExSummary: Shows how to add columns for assignment views.
            var project = new Project(DataDir + "CreateProject2.mpp");

            var options = new Spreadsheet2003SaveOptions();

            var column = new AssignmentViewColumn("Notes", 200, delegate(ResourceAssignment assignment) { return assignment.Get(Asn.Notes); });
            options.AssignmentView.Columns.Add(column);

            foreach (var assignment in project.ResourceAssignments)
            {
                foreach (var col in options.AssignmentView.Columns)
                {
                    var assnCol = (AssignmentViewColumn)col;
                    Console.WriteLine("Column Field: " + assnCol.Field);
                    Console.WriteLine("Column Text ( converted ): " + assnCol.GetColumnText(assignment));
                    Console.WriteLine();
                }
            }

            project.Save(OutDir + "UsingSpreadsheet2003SaveOptions_out.xml", options);

            // ExEnd
        }
    }
}