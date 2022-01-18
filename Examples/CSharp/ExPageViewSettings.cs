namespace Aspose.Tasks.Examples.CSharp
{
    using NUnit.Framework;
    using Saving;

    [TestFixture]
    public class ExPageViewSettings : ApiExampleBase
    {
        [Test]
        public void WorkWithPageViewSettings()
        {
            // ExStart:RenderCommentsWhenConverting
            // ExFor: PageViewSettings
            // ExFor: PageViewSettings.PrintNotes
            // ExFor: PageViewSettings.FirstColumnsCount
            // ExFor: PageViewSettings.FitTimescaleToEndOfPage
            // ExFor: PageViewSettings.PrintAllSheetColumns
            // ExFor: PageViewSettings.PrintBlankPages
            // ExFor: PageViewSettings.PrintFirstColumnsCountOnAllPages
            // ExSummary: Shows how to print task, resource, assignment notes on a separate page.
            var project = new Project(DataDir + "Input.mpp");

            // set the number of first columns to be printed on all pages
            project.DefaultView.PageInfo.PageViewSettings.FirstColumnsCount = 2;
            
            // set a value indicating whether to print notes.
            project.DefaultView.PageInfo.PageViewSettings.PrintNotes = true;
            
            // set a value indicating whether to fit timescale to the end of a page when printing.
            project.DefaultView.PageInfo.PageViewSettings.FitTimescaleToEndOfPage = true;
            
            // set a value indicating whether to print all sheet columns of a view
            project.DefaultView.PageInfo.PageViewSettings.PrintAllSheetColumns = true;
            
            // set a value indicating whether to print blank pages of a view
            project.DefaultView.PageInfo.PageViewSettings.PrintBlankPages = false;
            
            // set a value indicating whether to print a specified number of first columns on all pages
            project.DefaultView.PageInfo.PageViewSettings.PrintFirstColumnsCountOnAllPages = true;
            
            project.Save(OutDir + "ProjectWithComments_out.pdf", SaveFileFormat.Pdf);

            // ExEnd:RenderCommentsWhenConverting
        }
    }
}