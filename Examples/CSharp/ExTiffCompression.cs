namespace Aspose.Tasks.Examples.CSharp
{
    using NUnit.Framework;
    using Saving;

    [TestFixture]
    public class ExTiffCompression : ApiExampleBase
    {
        [Test]
        public void RenderMultipageTIFF()
        {
            //ExStart:RenderMultipageTIFF
            //ExFor: SaveFileFormat
            //ExFor: TiffCompression
            //ExSummary: Shows how to set TIFF compression mode (can be one of the values of the <see cref="P:Aspose.Tasks.Saving.PageSize" /> enumeration).
            var project = new Project(DataDir + "Project2.mpp");

            // Save the project to TIFF
            project.Save(OutDir + "RenderMultipageTIFF_out.tif", SaveFileFormat.TIFF);

            // Save the project with Rle compression
            var options = new ImageSaveOptions(SaveFileFormat.TIFF);
            options.TiffCompression = TiffCompression.Rle;
            project.Save(OutDir + "RenderMultipageTIFF_comp_rle_out.tif", options);
            
            // Save the project with CCITT3 compression
            options.TiffCompression = TiffCompression.Ccitt3;
            project.Save(OutDir + "RenderMultipageTIFF_comp_rle_out.tif", options);
            
            // Save the project with CCITT4 compression
            options.TiffCompression = TiffCompression.Ccitt4;
            project.Save(OutDir + "RenderMultipageTIFF_comp_ccitt4_out.tif", options);
            
            // Save the project with CCITT4 compression
            options.TiffCompression = TiffCompression.Lzw;
            project.Save(OutDir + "RenderMultipageTIFF_comp_lzw_out.tif", options);

            // Remove the compression
            options.TiffCompression = TiffCompression.None;
            project.Save(OutDir + "RenderMultipageTIFF_comp_none_out.tif", options);
            //ExEnd:RenderMultipageTIFF
        }
    }
}