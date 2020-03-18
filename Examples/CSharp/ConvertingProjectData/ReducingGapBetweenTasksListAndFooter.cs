namespace Aspose.Tasks.Examples.CSharp.ConvertingProjectData
{
    using Aspose.Tasks.Saving;
    using Aspose.Tasks.Visualization;

    internal class ReducingGapBetweenTasksListAndFooter
    {
        public static void Run()
        {
            // The path to the documents directory.
            var dataDir = RunExamples.GetDataDir(System.Reflection.MethodBase.GetCurrentMethod().DeclaringType.FullName);

            //ExStart: ReducingGapBetweenTasksListAndFooter
            //ExFor: ImageSaveOptions.ReduceFooterGap
            //ExSummary: Shows how to set a value indicating whether a gap between last task and the footer must be reduced.

            var project = new Project(dataDir + "CreateProject2.mpp");

            //Use ReduceFooterGap property to reduce the gap between list of tasks and Footer
            var imageSaveOptions =
                new ImageSaveOptions(SaveFileFormat.PNG) { ReduceFooterGap = true, /* set to true */ SaveToSeparateFiles = true, PageSize = PageSize.A0, Timescale = Timescale.Days };
            project.Save(dataDir + "ReducingGapBetweenTasksListAndFooter_out.png", imageSaveOptions);

            var pdfSaveOptions = new PdfSaveOptions { ReduceFooterGap = true, /* set to true */ SaveToSeparateFiles = true, PageSize = PageSize.A0, Timescale = Timescale.Days };
            project.Save(dataDir + "ReducingGapBetweenTasksListAndFooter_out.pdf", pdfSaveOptions);

            var htmlSaveOptions = new HtmlSaveOptions
            {
                ReduceFooterGap = false, // set to true
                IncludeProjectNameInPageHeader = false,
                IncludeProjectNameInTitle = false,
                PageSize = PageSize.A0,
                Timescale = Timescale.Days
            };
            project.Save(dataDir + "ReducingGapBetweenTasksListAndFooter_out.html", htmlSaveOptions);
            //ExEnd: ReducingGapBetweenTasksListAndFooter
        }
    }
}
