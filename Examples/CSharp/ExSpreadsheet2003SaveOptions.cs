namespace Aspose.Tasks.Examples.CSharp
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
            //ExStart:UsingSpreadsheet2003SaveOptions
            //ExFor: Spreadsheet2003SaveOptions
            //ExFor: SaveOptions.View
            //ExFor: Spreadsheet2003SaveOptions.ResourceView
            //ExFor: Spreadsheet2003SaveOptions.AssignmentView
            //ExFor: AssignmentViewColumn
            //ExFor: ResourceViewColumn
            //ExSummary: Shows how to use add columns to be exported during export project into Spreadsheet2003 format.
            var project = new Project(DataDir + "CreateProject2.mpp");

            var options = new Spreadsheet2003SaveOptions();
            var ganttChartColumn = new GanttChartColumn(
                "WBS", 
                100,
                delegate(Task task)
                {
                    return task.Get(Tsk.WBS);
                });
            options.View.Columns.Add(ganttChartColumn);

            var resourceViewColumn = new ResourceViewColumn(
                "Cost center",
                100,
                delegate(Resource resource)
                {
                    return resource.Get(Rsc.CostCenter);
                });
            options.ResourceView.Columns.Add(resourceViewColumn);

            var assignmentViewColumn = new AssignmentViewColumn(
                "Notes",
                200,
                delegate(ResourceAssignment assignment)
                {
                    return assignment.Get(Asn.Notes);
                });
            options.AssignmentView.Columns.Add(assignmentViewColumn);

            project.Save(OutDir + "UsingSpreadsheet2003SaveOptions_out.xml", options);
            //ExEnd:UsingSpreadsheet2003SaveOptions
        }
        
        [Test]
        public void SaveProjectDataToSpreadsheet2003XML()
        {
            //ExStart:SaveProjectDataToSpreadsheet2003XML
            //ExFor: SaveFileFormat
            //ExSummary: Shows how to save a project in Spreadsheet2003 format.
            var project = new Project(DataDir + "CreateProject2.mpp");
            project.Save(OutDir + "SaveProjectDataToSpreadsheet2003XML_out.xml", SaveFileFormat.Spreadsheet2003);
            //ExEnd:SaveProjectDataToSpreadsheet2003XML
        }
    }
}