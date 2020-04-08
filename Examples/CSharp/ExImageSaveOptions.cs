namespace Aspose.Tasks.Examples.CSharp
{
    using System.Collections.Generic;
    using System.Drawing;
    using System.Drawing.Imaging;
    using System.IO;
    using NUnit.Framework;
    using Saving;
    using Visualization;

    [TestFixture]
    public class ExImageSaveOptions : ApiExampleBase
    {
        [Test]
        public void RenderProjectDataToFormat24bppRgb()
        {
            //ExStart:RenderProjectDataToFormat24bppRgb
            //ExFor: ImageSaveOptions.PixelFormat
            //ExSummary: Shows how to set pixel format which is used during conversion into image formats. 
            var project = new Project(DataDir + "Project1.mpp");
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
        
        [Test]
        public void ReducingGapBetweenTasksListAndFooter()
        {
            //ExStart: ReducingGapBetweenTasksListAndFooter
            //ExFor: ImageSaveOptions.ReduceFooterGap
            //ExSummary: Shows how to set a value indicating whether a gap between last task and the footer must be reduced.
            var project = new Project(DataDir + "CreateProject2.mpp");

            //Use ReduceFooterGap property to reduce the gap between list of tasks and Footer
            var imageSaveOptions =
                new ImageSaveOptions(SaveFileFormat.PNG) { ReduceFooterGap = true, /* set to true */ SaveToSeparateFiles = true, PageSize = PageSize.A0, Timescale = Timescale.Days };
            project.Save(OutDir + "ReducingGapBetweenTasksListAndFooter_out.png", imageSaveOptions);

            var pdfSaveOptions = new PdfSaveOptions { ReduceFooterGap = true, /* set to true */ SaveToSeparateFiles = true, PageSize = PageSize.A0, Timescale = Timescale.Days };
            project.Save(OutDir + "ReducingGapBetweenTasksListAndFooter_out.pdf", pdfSaveOptions);

            var htmlSaveOptions = new HtmlSaveOptions
            {
                ReduceFooterGap = false, // set to true
                IncludeProjectNameInPageHeader = false,
                IncludeProjectNameInTitle = false,
                PageSize = PageSize.A0,
                Timescale = Timescale.Days
            };
            project.Save(OutDir + "ReducingGapBetweenTasksListAndFooter_out.html", htmlSaveOptions);
            //ExEnd:ReducingGapBetweenTasksListAndFooter
        }
        
        [Test]
        public void PrintProjectPagesToSeparateFiles()
        {
            //ExStart:PrintProjectPagesToSeparateFiles
            //ExFor: ImageSaveOptions.SaveToSeparateFiles
            //ExSummary: Shows how to save layout to separate files. 
            var project = new Project(DataDir + "CreateProject2.mpp");
            var options = new ImageSaveOptions(SaveFileFormat.PNG);
            options.StartDate = project.Get(Prj.StartDate).AddDays(-3);
            options.EndDate = project.Get(Prj.FinishDate);
            options.MarkCriticalTasks = true;
            options.LegendOnEachPage = false;
            
            options.Gridlines = new List<Gridline>();

            var gridline = new Gridline
            {
                GridlineType = GridlineType.GanttRow, 
                Color = Color.CornflowerBlue, 
                Pattern = LinePattern.Dashed
            };
            options.Gridlines.Add(gridline);
 
            project.Save(OutDir + "PrintProjectPagesToSeparateFiles1_out.png", options);
            
            // Save project layout to separate files
            options.SaveToSeparateFiles = true;
            project.Save(OutDir + "PrintProjectPagesToSeparateFiles2_out.png", options);
            //ExEnd:PrintProjectPagesToSeparateFiles
        }
    }
}