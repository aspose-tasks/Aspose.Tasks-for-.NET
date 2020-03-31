namespace Aspose.Tasks.Examples.CSharp
{
    using NUnit.Framework;
    using Saving;
    using Visualization;

    [TestFixture]
    public class ExXlsxOptions : ApiExampleBase
    {
        [Test]
        public void UsingXlsxOptions()
        {
            //ExStart:UsingXlsxOptions
            //ExFor: XlsxOptions
            //ExSummary: Shows how to save a project into XLSX file by using <see cref="P:Aspose.Tasks.Saving.XlsxOptions">Days</see> options.
            var project = new Project(DataDir + "CreateProject2.mpp");
                                   
            var options = new XlsxOptions();

            // Add desired Gantt Chart columns
            var col = new GanttChartColumn("WBS", 100, delegate(Task task) { return task.Get(Tsk.WBS); });
            options.View.Columns.Add(col);

            // Add desired resource view columns
            var rscCol = new ResourceViewColumn(
                "Cost center",
                100,
                delegate(Resource resource)
                {
                    return resource.Get(Rsc.CostCenter);
                });
            options.ResourceView.Columns.Add(rscCol);

            // Add desired assignment view columns
            var assnCol = new AssignmentViewColumn("Notes", 200, delegate(ResourceAssignment assignment) { return assignment.Get(Asn.Notes); });
            options.AssignmentView.Columns.Add(assnCol);

            project.Save(OutDir + "UsingXlsxOptions_out.xlsx", options);
            //ExEnd:UsingXlsxOptions
        }
    }
}