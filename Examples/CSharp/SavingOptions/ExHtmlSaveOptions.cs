namespace Aspose.Tasks.Examples.CSharp.SavingOptions
{
    using System.Collections.Generic;
    using NUnit.Framework;
    using Saving;

    [TestFixture]
    public class ExHtmlSaveOptions : ApiExampleBase
    {
        [Test]
        public void AddingCssStylePrefix()
        {
            //ExStart:AddingCssStylePrefix
            //ExFor: HtmlSaveOptions.CssStylePrefix
            //ExSummary: Shows how to set a common prefix for CSS styles are used during export to HTML.
            var project = new Project(DataDir + "CreateProject2.mpp");

            var options = new HtmlSaveOptions
            {
                CssStylePrefix = "test_prefix"
            };

            project.Save(OutDir + "TestCssStylePrefix_out.html", options);
            //ExEnd:AddingCssStylePrefix
        }
        
        [Test]
        public void ControlHeaderNameDuringHTMLExport()
        {
            //ExStart:ControlHeaderNameDuringHTMLExport
            //ExFor: HtmlSaveOptions.Pages
            //ExFor: HtmlSaveOptions.IncludeProjectNameInTitle
            //ExFor: HtmlSaveOptions.IncludeProjectNameInPageHeader
            //ExSummary: Shows how to set page HTML header/title by using <see cref="P:Aspose.Tasks.Saving.HtmlSaveOptions" /> options.
            var project = new Project(DataDir + "CreateProject2.mpp");
            var options = new HtmlSaveOptions();

            // Determines whether to include project name in HTML title (true by default)
            options.IncludeProjectNameInTitle = false;

            // Determines whether to include project name in HTML page header  (true by default)
            options.IncludeProjectNameInPageHeader = false;
            
            options.Pages = new List<int>();
            options.Pages.Add(1);
            project.Save(OutDir + "ControlHeaderNameDuringHTMLExport_out.html", options);
            //ExEnd:ControlHeaderNameDuringHTMLExport
        }

        [Test]
        public void SaveProjectDataAsHTML()
        {
            //ExStart:SaveProjectDataAsHTML
            //ExFor: HtmlSaveOptions
            //ExFor: HtmlSaveOptions.#ctor
            //ExSummary: Shows how to save a project in HTML format.
            var project = new Project(DataDir + "CreateProject2.mpp");
            var option = new HtmlSaveOptions();
            project.Save(OutDir + "SaveProjectDataAsHTML_out.html", option);

            // OR

            // Adding only one page (page number 2)
            option = new HtmlSaveOptions();            
            option.Pages.Add(2); 
            project.Save(OutDir + "SaveProjectDataAsHTML2_out.html", option);
            //ExEnd:SaveProjectDataAsHTML
        }
    }
}