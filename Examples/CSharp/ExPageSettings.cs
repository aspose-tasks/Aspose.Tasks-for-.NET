using System.Linq;

namespace Aspose.Tasks.Examples.CSharp
{
    using System;
    using NUnit.Framework;
    using Saving;
    using Visualization;

    [TestFixture]
    public class ExPageSettings : ApiExampleBase
    {
        [Test]
        public void WorkWithPageSetting()
        {
            try
            {
                // ExStart
                // ExFor: Aspose.Tasks.Visualization.PageSettings
                // ExFor: Aspose.Tasks.Visualization.PageSettings.#ctor
                // ExFor: Aspose.Tasks.Visualization.PageSettings.FirstPageNumber
                // ExFor: Aspose.Tasks.Visualization.PageSettings.IsPortrait
                // ExFor: Aspose.Tasks.Visualization.PageSettings.PaperSize
                // ExSummary: Shows how to work with <see cref="Aspose.Tasks.Visualization.PageSettings" />.
                var project = new Project(DataDir + "Project2.mpp");
                
                // get the settings
                var settings = project.DefaultView.PageInfo.PageSettings;
                // lets tune some properties
                // set a value indicating whether the page orientation is portrait; returns false if the page orientation is landscape.
                settings.IsPortrait = true;
                // set a number of pages in width to be printed.
                settings.PagesInWidth = 5;
                // set a number of pages in height to be printed.
                settings.PagesInHeight = 7;
                // set a percentage of normal size to adjust printing to.
                settings.PercentOfNormalSize = 200;
                // set a paper size. Can be one of the values of the <see cref="T:Aspose.Tasks.Visualization.PrinterPaperSize" /> enumeration.
                settings.PaperSize = PrinterPaperSize.PaperB4;
                // set a first page number for printing.
                settings.FirstPageNumber = 3;
            
                var options = new MPPSaveOptions
                {
                    WriteViewData = true
                };
            
                project.Save(OutDir + "TestCanWritePageSettings.mpp", options);
                // ExEnd
            }
            catch (NotSupportedException ex)
            {
                Console.WriteLine(ex.Message + "\nThis example will only work if you apply a valid Aspose License. You can purchase full license or get 30 day temporary license from http://www.aspose.com/purchase/default.aspx.");
            }
        }

        [Test]
        public void PrintViewWithSpecifiedScaleFactor()
        {
            // ExStart:PrintViewWithSpecifiedScaleFactor
            // ExFor: PageSettings.AdjustToPercentOfNormalSize
            // ExFor: PageSettings.PercentOfNormalSize
            // ExSummary: Shows how to render view with the specified scale factor.
            var project = new Project(DataDir + "Input.mpp");

            var view = project.Views.First(v => v.Screen == ViewScreen.Gantt);

            // set a value indicating that view should be scaled using the specified scale factor
            view.PageInfo.PageSettings.AdjustToPercentOfNormalSize = true;
            // specify the scale factor
            view.PageInfo.PageSettings.PercentOfNormalSize = 33;


            PdfSaveOptions saveOptions = new PdfSaveOptions()
            {
                ViewSettings = view,
                Timescale = Timescale.DefinedInView
            };

            project.Save(OutDir + "PrintViewWithSpecifiedScaleFactor_out.pdf", saveOptions);
            // ExEnd:PrintViewWithSpecifiedScaleFactor
        }

        [Test]
        public void PrintViewWithFitToPages()
        {
            // ExStart:PrintViewWithFitToPages
            // ExFor: PageSettings.PagesInHeight
            // ExFor: PageSettings.PagesInWidth
            // ExSummary: Shows how to render view with 'Fit X to Y pages' option.
            var project = new Project(DataDir + "TaskUsageView.mpp");

            var view = project.Views.First(v => v.Screen == ViewScreen.TaskUsage);

            view.PageInfo.PageSettings.AdjustToPercentOfNormalSize = false;
            // specify that view should be rendered in 2 pages or less in height
            view.PageInfo.PageSettings.PagesInHeight = 2;
            // specify that view should be rendered in 1 page in width
            view.PageInfo.PageSettings.PagesInWidth = 1;

            PdfSaveOptions saveOptions = new PdfSaveOptions()
            {
                ViewSettings = view,
                Timescale = Timescale.DefinedInView,
                StartDate =  new DateTime(2000, 04, 1),
                EndDate = new DateTime(2000, 12, 31)
            };

            project.Save(OutDir + "PrintViewWithFitToPages_out.pdf", saveOptions);
            // ExEnd:PrintViewWithFitToPages
        }
    }
}