namespace Aspose.Tasks.Examples.CSharp.SavingOptions
{
    using NUnit.Framework;
    using Saving;

    [TestFixture]
    public class ExPrimaveraXmlSaveOptions : ApiExampleBase
    {
        [Test]
        public void ExportProjectDataToPrimaveraXML()
        {
            // ExStart:ExportProjectDataToPrimaveraXML
            // ExFor: PrimaveraXmlSaveOptions
            // ExFor: PrimaveraXmlSaveOptions.#ctor
            // ExFor: PrimaveraXmlSaveOptions.SaveRootTask
            // ExSummary: Shows how to export the to Primavera XML file.
            var project = new Project(DataDir + "project.xml");

            var options = new PrimaveraXmlSaveOptions();
            options.SaveRootTask = false;
            project.Save(OutDir + "UsingPrimaveraXMLSaveOptions_out.xml", options);

            // ExEnd:ExportProjectDataToPrimaveraXML
        }

        [Test]
        public void UseSkipSummaryAssignments()
        {
            // ExStart:ExportProjectDataToPrimaveraXML_SkipSummaryAssignments
            // ExFor: PrimaveraXmlSaveOptions.SkipSummaryAssignments
            // ExFor: PrimaveraSaveOptions.SkipSummaryAssignments
            // ExSummary: Shows how to use SkipSummaryAssignments flag.
            var project = new Project(DataDir + "Blank2010.mpp");

            var resource = project.Resources.Add("Resource");

            var summaryTask = project.RootTask.Children.Add("Summary");
            summaryTask.Children.Add("Task");

            // Primavera doesn't support assignments of resources to summary tasks.
            // So exporting such assignments to Primavera format may result in files that cannot be imported to Primavera.
            var assignment = project.ResourceAssignments.Add(summaryTask, resource);

            var options = new PrimaveraXmlSaveOptions();
            options.SkipSummaryAssignments = true;
            project.Save(OutDir + "UseSkipSummaryAssignments_out.xml", options);

            // ExEnd:ExportProjectDataToPrimaveraXML
        }
    }
}