namespace Aspose.Tasks.Examples.CSharp.SavingOptions
{
    using System.Collections.Generic;
    using NUnit.Framework;
    using Saving;
    using Visualization;

    [TestFixture]
    public class ExHtmlSaveOptions : ApiExampleBase
    {
        [Test]
        public void AddingCssStylePrefix()
        {
            // ExStart:AddingCssStylePrefix
            // ExFor: HtmlSaveOptions.CssStylePrefix
            // ExSummary: Shows how to set a common prefix for CSS styles are used during export to HTML.
            var project = new Project(DataDir + "CreateProject2.mpp");

            var options = new HtmlSaveOptions { CssStylePrefix = "test_prefix" };

            project.Save(OutDir + "TestCssStylePrefix_out.html", options);

            // ExEnd:AddingCssStylePrefix
        }

        [Test]
        public void ControlHeaderNameDuringHTMLExport()
        {
            // ExStart:ControlHeaderNameDuringHTMLExport
            // ExFor: HtmlSaveOptions.Pages
            // ExFor: HtmlSaveOptions.IncludeProjectNameInTitle
            // ExFor: HtmlSaveOptions.IncludeProjectNameInPageHeader
            // ExSummary: Shows how to set page HTML header/title by using <see cref="P:Aspose.Tasks.Saving.HtmlSaveOptions" /> options.
            var project = new Project(DataDir + "CreateProject2.mpp");
            var options = new HtmlSaveOptions
            {
                // Determines whether to include project name in HTML title (true by default)
                IncludeProjectNameInTitle = false,
                
                // Determines whether to include project name in HTML page header  (true by default)
                IncludeProjectNameInPageHeader = false,
                
                // set pages that will be exported
                Pages = new List<int>
                        {
                            1
                        }
            };
            project.Save(OutDir + "ControlHeaderNameDuringHTMLExport_out.html", options);

            // ExEnd:ControlHeaderNameDuringHTMLExport
        }

        [Test]
        public void WorkWithHtmlSaveOptions()
        {
            // ExStart:SaveProjectDataAsHTML
            // ExFor: HtmlSaveOptions
            // ExFor: HtmlSaveOptions.#ctor
            // ExSummary: Shows how to save a project in HTML format.
            var project = new Project(DataDir + "CreateProject2.mpp");
            var option = new HtmlSaveOptions();
            project.Save(OutDir + "SaveProjectDataAsHTML_out.html", option);

            // OR

            // Adding only one page (page number 2)
            option = new HtmlSaveOptions();
            option.Pages.Add(2);
            project.Save(OutDir + "SaveProjectDataAsHTML2_out.html", option);

            // ExEnd:SaveProjectDataAsHTML
        }

        [Test]
        public void SetDefaultFontDuringSavingAsHtml()
        {
            // ExStart:SetDefaultFontDuringSavingAsHtml
            // ExFor: HtmlSaveOptions.DefaultFontName
            // ExFor: HtmlSaveOptions.UseProjectDefaultFont
            // ExFor: HtmlSaveOptions.UseGradientBrush
            // ExSummary: Shows how to set custom font that will be used to export the project in HTML file.
            var project = new Project(DataDir + "EstimatedMilestoneTasks.mpp");

            var options = new HtmlSaveOptions
                              {
                                  PresentationFormat = PresentationFormat.GanttChart,
                                  FitContent = true,
                                  UseProjectDefaultFont = false,
                                  DefaultFontName = "Segoe UI Black"
                              };
            project.Save(OutDir + "AddDefaultFontDuringSavingAsHtml_out.html", options);

            // ExEnd:SetDefaultFontDuringSavingAsHtml
        }

        [Test]
        public void ReducingGapBetweenTasksListAndFooter()
        {
            // ExStart:ReducingGapBetweenTasksListAndFooter
            // ExFor: HtmlSaveOptions.ReduceFooterGap
            // ExSummary: Shows how to set a value indicating whether a gap between last task and the footer must be reduced in HTML output files.
            var project = new Project(DataDir + "EstimatedMilestoneTasks.mpp");

            var options = new HtmlSaveOptions
                              {
                                  ReduceFooterGap = true,
                                  IncludeProjectNameInPageHeader = false,
                                  IncludeProjectNameInTitle = false,
                                  PageSize = PageSize.A0,
                                  Timescale = Timescale.Days
                              };
            project.Save(OutDir + "ReducingGapBetweenTasksListAndFooter_out.html", options);

            // ExEnd:ReducingGapBetweenTasksListAndFooter
        }
    }
}