namespace Aspose.Tasks.Examples.CSharp
{
    using NUnit.Framework;
    using Saving;
    using Visualization;

    [TestFixture]
    public class ExPresentationFormat : ApiExampleBase
    {
        [Test]
        public void RenderResourceSheetView()
        {
            //ExStart:RenderResourceSheetView
            //ExFor: PresentationFormat.ResourceSheet
            //ExSummary: Shows how to render resource sheet view.
            var project = new Project(DataDir + "ResourceSheetView.mpp");

            SaveOptions options = new PdfSaveOptions();

            // Set the Presentation Format to Resource Sheet
            options.PresentationFormat = PresentationFormat.ResourceSheet;
            project.Save(OutDir + "ResourceSheetView_out.pdf", options);
            //ExEnd:RenderResourceSheetView
        }
        
        [Test]
        public void RenderDifferentPresentationFormatsToXAML()
        {
            //ExStart:RenderDifferentPresentationFormatsToXAML
            //ExFor: PresentationFormat.GanttChart
            //ExSummary: Shows how to set the presentation format view to be rendered to XAML.
            var project = new Project(DataDir + "Project2.mpp");

            SaveOptions options = new XamlOptions();
            options.PresentationFormat = PresentationFormat.GanttChart;

            project.Save(OutDir + "RenderDifferentPresentationFormatsToXAML_out.xaml", options);
            //ExEnd:RenderDifferentPresentationFormatsToXAML
        }
        
        [Test]
        public void RenderResourceUsageView()
        {
            //ExStart:RenderResourceUsageView
            //ExFor: PresentationFormat.ResourceUsage
            //ExSummary: Shows how to use presentation formats to print views of Microsoft Project.
            var project = new Project(DataDir + "ResourceUsageView.mpp");
                        
            // Define the SaveOptions with required TimeScale settings as Days
            SaveOptions options = new PdfSaveOptions();
            options.Timescale = Timescale.Days;

            // Set the Presentation format to ResourceUsage
            options.PresentationFormat = PresentationFormat.ResourceUsage;
            project.Save(OutDir + "ResourceUsageView_days_out.pdf", options);

            // Set the Timescale settings to ThirdsOfMonths
            options.Timescale = Timescale.ThirdsOfMonths;
            project.Save(OutDir + "ResourceUsageView_thirdsOfMonths_out.pdf", options);

            // Set the Timescale settings to Months
            options.Timescale = Timescale.Months;
            project.Save(OutDir + "ResourceUsageView_months_out.pdf", options);
            //ExEnd:RenderResourceUsageView
        }
        
        [Test]
        public void RenderTaskSheetView()
        {
            //ExStart:RenderTaskSheetView
            //ExFor: PresentationFormat.TaskSheet
            //ExSummary: Shows how to render task sheet view.
            var project = new Project(DataDir + "TaskSheetView.mpp");

            // Set presentation format Task Sheet and save project as PDF
            SaveOptions options = new PdfSaveOptions();
            options.PresentationFormat = PresentationFormat.TaskSheet;

            project.Save(OutDir + "TaskSheetView_out.pdf", options);
            //ExEnd:RenderTaskSheetView
        }
    }
}