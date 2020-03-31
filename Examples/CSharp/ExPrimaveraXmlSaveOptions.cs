namespace Aspose.Tasks.Examples.CSharp
{
    using NUnit.Framework;
    using Saving;

    [TestFixture]
    public class ExPrimaveraXmlSaveOptions : ApiExampleBase
    {
        [Test]
        public void ExportProjectDataToPrimaveraXML()
        {
            //ExStart:ExportProjectDataToPrimaveraXML
            //ExFor: PrimaveraXmlSaveOptions
            //ExFor: PrimaveraXmlSaveOptions.SaveRootTask
            //ExSummary: Shows how to export the to Primavera XML file.
            var project = new Project(DataDir + "project.xml");

            var options = new PrimaveraXmlSaveOptions();
            options.SaveRootTask = false;
            project.Save(OutDir + "UsingPrimaveraXMLSaveOptions_out.xml", options);
            //ExEnd:ExportProjectDataToPrimaveraXML
        }
    }
}