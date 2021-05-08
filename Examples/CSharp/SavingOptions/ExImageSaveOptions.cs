namespace Aspose.Tasks.Examples.CSharp.SavingOptions
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
            // ExStart:RenderProjectDataToFormat24bppRgb
            // ExFor: ImageSaveOptions.PixelFormat
            // ExFor: ImageSaveOptions.VerticalResolution
            // ExFor: ImageSaveOptions.HorizontalResolution
            // ExSummary: Shows how to set pixel format which is used during conversion into image formats. 
            var project = new Project(DataDir + "Project1.mpp");
            var options = new ImageSaveOptions(SaveFileFormat.TIFF);
            options.HorizontalResolution = 72;
            options.VerticalResolution = 72;
            options.PixelFormat = PixelFormat.Format24bppRgb;
            project.Save(OutDir + "RenderProjectDataToFormat24bppRgb_out.tif", options);

            // ExEnd:RenderProjectDataToFormat24bppRgb
        }

        [Test]
        public void SaveProjectAsJpeg()
        {
            // ExStart: SaveProjectAsJpeg
            // ExFor: ImageSaveOptions.JpegQuality
            // ExSummary: Shows how to set JPEG quality of output JPEG files.
            var project = new Project(DataDir + "CreateProject2.mpp");

            // in order to manipulate JPEG quality one can use ImageSaveOptions.JpegQuality property.
            // The allowed value range is 0..100.
            var options = new ImageSaveOptions(SaveFileFormat.JPEG) { JpegQuality = 50 };

            project.Save(OutDir + "SaveProjectAsJPEG_out.jpeg", options);

            // ExEnd:SaveProjectAsJpeg
        }

        [Test]
        public void SaveProjectAsTiff()
        {
            // ExStart: SaveProjectAsTiff
            // ExFor: ImageSaveOptions.TiffCompression
            // ExSummary: Shows how to set TIFF compression of the output TIFF files.
            var project = new Project(DataDir + "EstimatedMilestoneTasks.mpp");

            // in order to manipulate TIFF compression we can use ImageSaveOptions.TiffCompression property.
            // The allowed value range is 0..100.
            var options = new ImageSaveOptions(SaveFileFormat.TIFF) { TiffCompression = TiffCompression.Lzw };

            project.Save(OutDir + "SaveProjectAsTiff_out.tif", options);

            // ExEnd:SaveProjectAsTiff
        }

        [Test]
        public void SaveSelectedPagesImageSaveOptions()
        {
            // ExStart:SaveSelectedPagesImageSaveOptions
            // ExFor: ImageSaveOptions.Pages
            // ExFor: SaveOptions.RenderToSinglePage
            // ExSummary: Shows how to save selected pages in as an image.
            var project = new Project(DataDir + "EstimatedMilestoneTasks.mpp");

            var options = new ImageSaveOptions(SaveFileFormat.JPEG)
                              {
                                  RenderToSinglePage = false,
                                  StartDate = project.Get(Prj.StartDate),
                                  EndDate = project.Get(Prj.FinishDate),
                                  PageSize = PageSize.Letter
                              };
            options.Pages.Add(2);

            project.Save(OutDir + "SaveSelectedPagesImageSaveOptions_page2_out.jpeg", options);

            // ExEnd:SaveSelectedPagesImageSaveOptions
        }

        [Test]
        public void SaveToStreamWithOptions()
        {
            // ExStart:SaveToStreamWithOptions
            // ExFor: ImageSaveOptions
            // ExFor: ImageSaveOptions.#ctor(SaveFileFormat)
            // ExSummary: Shows how to save project into a stream as an image.
            var project = new Project();

            using (var stream = new FileStream(OutDir + "EmptyProjectSaveStream_out.xml", FileMode.Create, FileAccess.Write))
            {
                var options = new ImageSaveOptions(SaveFileFormat.PNG);

                // by using of ImageSaveOptions we save the project into image format
                project.Save(stream, options);
            }

            // ExEnd:SaveToStreamWithOptions
        }

        [Test]
        public void ReducingGapBetweenTasksListAndFooter()
        {
            // ExStart: ReducingGapBetweenTasksListAndFooter
            // ExFor: ImageSaveOptions.ReduceFooterGap
            // ExSummary: Shows how to set a value indicating whether a gap between last task and the footer must be reduced.
            var project = new Project(DataDir + "CreateProject2.mpp");

            // Use ReduceFooterGap property to reduce the gap between list of tasks and Footer
            var imageSaveOptions = new ImageSaveOptions(SaveFileFormat.PNG)
                                       {
                                           ReduceFooterGap = true, /* set to true */ SaveToSeparateFiles = true, PageSize = PageSize.A0, Timescale = Timescale.Days
                                       };
            project.Save(OutDir + "ReducingGapBetweenTasksListAndFooter_out.png", imageSaveOptions);

            // ExEnd:ReducingGapBetweenTasksListAndFooter
        }

        [Test]
        public void PrintProjectPagesToSeparateFiles()
        {
            // ExStart:PrintProjectPagesToSeparateFiles
            // ExFor: SaveOptions.Gridlines
            // ExFor: SaveOptions.StartDate
            // ExFor: SaveOptions.EndDate
            // ExFor: ImageSaveOptions.DefaultFontName
            // ExFor: ImageSaveOptions.UseProjectDefaultFont
            // ExSummary: Shows how to save layout to separate files. 
            var project = new Project(DataDir + "Homemoveplan.mpp");
            var options = new ImageSaveOptions(SaveFileFormat.PNG);
            options.StartDate = project.Get(Prj.StartDate).AddDays(-3);
            options.EndDate = project.Get(Prj.FinishDate);
            options.MarkCriticalTasks = true;
            options.LegendOnEachPage = false;
            options.DefaultFontName = "Segoe UI Black";
            options.UseProjectDefaultFont = false;
            options.PageSize = PageSize.Letter;

            options.Gridlines = new List<Gridline>();

            var gridline = new Gridline { GridlineType = GridlineType.GanttRow, Color = Color.CornflowerBlue, Pattern = LinePattern.Dashed };
            options.Gridlines.Add(gridline);

            project.Save(OutDir + "PrintProjectPagesToSeparateFiles1_out.png", options);

            // Save project layout to separate files
            options.RenderToSinglePage = false;
            // options.SaveToSeparateFiles = true;
            project.Save(OutDir + "PrintProjectPagesToSeparateFiles2_out.png", options);

            // ExEnd:PrintProjectPagesToSeparateFiles
        }
    }
}