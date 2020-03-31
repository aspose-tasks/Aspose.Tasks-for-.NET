namespace Aspose.Tasks.Examples.CSharp
{
    using System.Drawing.Imaging;
    using System.IO;
    using NUnit.Framework;
    using Saving;
    using Visualization;

    [TestFixture]
    public class ExImageSaveOptions : ApiExampleBase
    {
        [Test]
        public void TimescaleSettingsExample()
        {
            //ExStart:TimescaleSettings
            //ExFor: SaveOptions.Timescale
            //ExSummary: Shows how to set the minimal time period to render. The default value is <see cref="P:Aspose.Tasks.Saving.SaveOptions.Timescale">Days</see>.
            var project = new Project(DataDir + "Project2.mpp");

            // Save to one page image (Timescale.days by default)
            project.Save(OutDir + "NewProductDevDays_out.jpeg", new ImageSaveOptions(SaveFileFormat.JPEG));

            // Save to one page image (Timescale.ThirdsOfMonths)
            var options = new ImageSaveOptions(SaveFileFormat.JPEG);
            options.Timescale = Timescale.ThirdsOfMonths;

            project.Save(OutDir + "NewProductDevThirdsOfMonths_out.jpeg", options);

            // Save to one page image (Timescale.Months)
            options.Timescale = Timescale.Months;
            project.Save(OutDir + "NewProductDevMonths_out.jpeg", options);
            //ExEnd:TimescaleSettings
        }
        
        [Test]
        public void RenderProjectDataToFormat24bppRgb()
        {
            //ExStart:RenderProjectDataToFormat24bppRgb
            //ExFor: ImageSaveOptions.PixelFormat
            //ExSummary: Shows how to set pixel format which is used during conversion into image formats. 
            var project = new Project(DataDir + "TestProject1.mpp");
            var options = new ImageSaveOptions(SaveFileFormat.TIFF);
            options.HorizontalResolution = 72;
            options.VerticalResolution = 72;
            options.PixelFormat = PixelFormat.Format24bppRgb;
            project.Save(OutDir + "RenderProjectDataToFormat24bppRgb_out.tif", options);
            //ExEnd:RenderProjectDataToFormat24bppRgb
        }
        
        [Test]
        public void SaveProjectAsJPEG()
        {
            //ExStart: SaveProjectAsJPEG
            //ExFor: ImageSaveOptions.JpegQuality
            //ExSummary: Shows how to set JPEG quality of output JPEG files.
            var project = new Project(DataDir + "CreateProject2.mpp");

            // in order to manipulate JPEG quality one can use ImageSaveOptions.JpegQuality property.
            // The allowed value range is 0..100.
            var options = new ImageSaveOptions(SaveFileFormat.JPEG) { JpegQuality = 50 };

            project.Save(OutDir + "SaveProjectAsJPEG_out.jpeg", options);
            //ExEnd:SaveProjectAsJPEG
        }
        
        [Test]
        public void SaveToStreamWithOptions()
        {
            //ExStart:SaveToStreamWithOptions
            //ExFor: ImageSaveOptions
            //ExFor: ImageSaveOptions.#ctor(SaveFileFormat)
            //ExSummary: Shows how to save project into a stream as an image.
            var project = new Project();

            using (var stream = new FileStream(DataDir + "EmptyProjectSaveStream_out.xml", FileMode.Create, FileAccess.Write))
            {
                var options = new ImageSaveOptions(SaveFileFormat.PNG);

                // by using of ImageSaveOptions we save the project into image format
                project.Save(stream, options);
            }
            //ExEnd:SaveToStreamWithOptions
        }
    }
}