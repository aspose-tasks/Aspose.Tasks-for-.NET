namespace Aspose.Tasks.Examples.CSharp
{
    using NUnit.Framework;
    using Saving;
    using Visualization;

    [TestFixture]
    public class ExPresentationFormat : ApiExampleBase
    {
        [Test]
        public void RenderResourceSheetView()
        {
            // ExStart:RenderResourceSheetView
            // ExFor: PresentationFormat
            // ExSummary: Shows how to render resource sheet view.
            var project = new Project(DataDir + "ResourceSheetView.mpp");

            SaveOptions options = new PdfSaveOptions();

            // Set the Presentation Format to Resource Sheet
            options.PresentationFormat = PresentationFormat.ResourceSheet;
            project.Save(OutDir + "ResourceSheetView_out.pdf", options);

            // ExEnd:RenderResourceSheetView
        }
    }
}