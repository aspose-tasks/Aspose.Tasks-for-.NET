namespace Aspose.Tasks.Examples.CSharp
{
    using NUnit.Framework;
    using Saving;

    [TestFixture]
    public class ExTiffCompression : ApiExampleBase
    {
        [Test]
        public void RenderMultipageTiff()
        {
            // ExStart:RenderMultipageTIFF
            // ExFor: TiffCompression
            // ExSummary: Shows how to render in TIFF format by using RLE compression mode.
            var project = new Project(DataDir + "Project2.mpp");

            var options = new ImageSaveOptions(SaveFileFormat.Tiff);

            // Save the project with Rle compression
            options.TiffCompression = TiffCompression.Rle;
            project.Save(OutDir + "RenderMultipageTIFF_comp_rle_out.tif", options);

            // ExEnd:RenderMultipageTIFF
        }
    }
}