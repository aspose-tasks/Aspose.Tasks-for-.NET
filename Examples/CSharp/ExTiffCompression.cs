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
            //ExFor: TiffCompression
            //ExSummary: Shows how to render in TIFF format by using RLE compression mode.
            var project = new Project(DataDir + "Project2.mpp");

            var options = new ImageSaveOptions(SaveFileFormat.TIFF);
            // Save the project with Rle compression
            options.TiffCompression = TiffCompression.Rle;
            project.Save(OutDir + "RenderMultipageTIFF_comp_rle_out.tif", options);
            //ExEnd:RenderMultipageTIFF
        }
        
        [Test]
        public void RenderMultipageTIFF2()
        {
            //ExStart:RenderMultipageTIFFCcitt3
            //ExFor: TiffCompression.Ccitt3
            //ExSummary: Shows how to render in TIFF format by using Ccitt3 compression mode.
            var project = new Project(DataDir + "Project2.mpp");

            var options = new ImageSaveOptions(SaveFileFormat.TIFF);
            
            // Save the project with CCITT3 compression
            options.TiffCompression = TiffCompression.Ccitt3;
            project.Save(OutDir + "RenderMultipageTIFF_comp_rle_out.tif", options);
            //ExEnd:RenderMultipageTIFFCcitt3
        }
        
        [Test]
        public void RenderMultipageTIFF3()
        {
            //ExStart:RenderMultipageTIFFCcitt4
            //ExFor: TiffCompression.Ccitt4
            //ExSummary: Shows how to render in TIFF format by using Ccitt4 compression mode.
            var project = new Project(DataDir + "Project2.mpp");

            var options = new ImageSaveOptions(SaveFileFormat.TIFF);
            
            // Save the project with CCITT4 compression
            options.TiffCompression = TiffCompression.Ccitt4;
            project.Save(OutDir + "RenderMultipageTIFF_comp_rle_out.tif", options);
            //ExEnd:RenderMultipageTIFFCcitt4
        }
        
        [Test]
        public void RenderMultipageTIFF4()
        {
            //ExStart:RenderMultipageTIFFLzw
            //ExFor: TiffCompression.Lzw
            //ExSummary: Shows how to render in TIFF format by using Lzw compression mode.
            var project = new Project(DataDir + "Project2.mpp");

            var options = new ImageSaveOptions(SaveFileFormat.TIFF);
            // Save the project with Lzw compression
            options.TiffCompression = TiffCompression.Lzw;
            
            project.Save(OutDir + "RenderMultipageTIFF_comp_lzw_out.tif", options);
            //ExEnd:RenderMultipageTIFFLzw
        }
        
        [Test]
        public void RenderMultipageTIFF5()
        {
            //ExStart:RenderMultipageTIFFNone
            //ExFor: TiffCompression.None
            //ExSummary: Shows how to render in TIFF format without compression mode.
            var project = new Project(DataDir + "Project2.mpp");

            var options = new ImageSaveOptions(SaveFileFormat.TIFF);
            
            // Remove the compression
            options.TiffCompression = TiffCompression.None;
            project.Save(OutDir + "RenderMultipageTIFF_comp_none_out.tif", options);
            //ExEnd:RenderMultipageTIFFNone
        }
    }
}