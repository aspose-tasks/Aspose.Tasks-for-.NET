namespace Aspose.Tasks.Examples.CSharp
{
    using System;
    using NUnit.Framework;
    using Saving;
    using Visualization;

    [TestFixture]
    public class ExTaskUsageView : ApiExampleBase
    {
        [Test]
        public void RenderTaskUsageView()
        {
            // ExStart:RenderTaskUsageView
            // ExFor: TaskUsageView
            // ExSummary: Shows how to work with  task usage view.
            var project = new Project(DataDir + "TaskUsageView.mpp");

            // Define the SaveOptions with required TimeScale settings as Days
            SaveOptions options = new PdfSaveOptions
            {
                Timescale = Timescale.Days,

                // Set the Presentation format to ResourceUsage
                PresentationFormat = PresentationFormat.TaskUsage
            };

            var outputProject = "TaskUsageView_result_days_out.pdf";
            project.Save(OutDir + outputProject, options);

            // Set the Timescale settings to ThirdsOfMonths
            options.Timescale = Timescale.ThirdsOfMonths;

            outputProject = "TaskUsageView_result_thirdsOfMonths_out.pdf";
            project.Save(OutDir + outputProject, options);

            // Set the Timescale settings to Months
            options.Timescale = Timescale.Months;

            outputProject = "TaskUsageView_result_months_out.pdf";
            project.Save(OutDir + outputProject, options);

            // ExEnd:RenderTaskUsageView
        }

        [Test]
        public void ReadFieldCollectionOfTaskUsageView()
        {
            // ExStart
            // ExFor: TaskUsageView.FieldCollection
            // ExSummary: Shows how to read task usage view fields.
            var project = new Project(DataDir + "TaskUsageView.mpp");

            var view = (TaskUsageView)project.Views.ToList()[2];
            foreach (var field in view.FieldCollection)
            {
                Console.WriteLine("Field: " + field);
            }

            // ExEnd
        }
    }
}