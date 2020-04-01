namespace Aspose.Tasks.Examples.CSharp
{
    using NUnit.Framework;
    using Saving;
    using Visualization;

    [TestFixture]
    public class ExTaskUsageView : ApiExampleBase
    {
        [Test]
        public void RenderTaskUsageView()
        {
            //ExStart:RenderTaskUsageView
            //ExFor: TaskUsageView
            //ExSummary: Shows how to render task usage view.
            var project = new Project(DataDir + "TaskUsageView.mpp");

            // Define the SaveOptions with required TimeScale settings as Days
            SaveOptions options = new PdfSaveOptions();
            options.Timescale = Timescale.Days;
            
            // Set the Presentation format to ResourceUsage
            options.PresentationFormat = PresentationFormat.TaskUsage;
                        
            var outputProject = "project_TaskUsageView_result_days_out.pdf";
            project.Save(OutDir + outputProject, options);

            // Set the Timescale settings to ThirdsOfMonths
            options.Timescale = Timescale.ThirdsOfMonths;
            
            outputProject = "project_TaskUsageView_result_thirdsOfMonths_out.pdf";
            project.Save(OutDir + outputProject, options);

            // Set the Timescale settings to Months
            options.Timescale = Timescale.Months;
            
            outputProject = "project_TaskUsageView_result_months_out.pdf";
            project.Save(OutDir + outputProject, options);
            //ExEnd:RenderTaskUsageView
        }
    }
}