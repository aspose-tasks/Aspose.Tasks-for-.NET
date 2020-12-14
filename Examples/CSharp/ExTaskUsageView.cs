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
        public void RenderTaskUsageViewWithPredefinedTimescales()
        {
            // ExStart:RenderTaskUsageView
            // ExFor: TaskUsageView
            // ExSummary: Shows how to render task usage view with predefined timescale settings.
            var project = new Project(DataDir + "TaskUsageView.mpp");

            // Define the SaveOptions and specify predefined TimeScale settings 'Days'.
            SaveOptions options = new PdfSaveOptions
            {
                Timescale = Timescale.Days,

                // Set the Presentation format to TaskUsage
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
        public void RenderTaskUsageViewWithTimescaleDefinedInView()
        {
            // ExStart:RenderTaskUsageViewCustomTimescale
            // ExFor: TaskUsageView
            // ExFor: TaskUsageView.TopTimescaleTier
            // ExFor: TaskUsageView.MiddleTimescaleTier
            // ExFor: TaskUsageView.BottomTimescaleTier
            // ExFor: SaveOptions.PresentationFormat
            // ExFor: SaveOptions.Timescale
            // ExSummary: Shows how to render task usage view with timescale settings defined in view settings.
            var project = new Project(DataDir + "TaskUsageView.mpp");

            var view = project.Views.ToList()[2] as TaskUsageView;

            view.TopTimescaleTier.Unit = TimescaleUnit.None;
            
            view.MiddleTimescaleTier.Unit = TimescaleUnit.Weeks;
            view.MiddleTimescaleTier.Label = DateLabel.WeekDddMDd;
            view.MiddleTimescaleTier.Count = 1;
            
            view.BottomTimescaleTier.Unit = TimescaleUnit.Days;
            view.BottomTimescaleTier.Label = DateLabel.DayMmDd;
            view.BottomTimescaleTier.Count = 1;

            // Define the SaveOptions and specify that TaskUsageView timescale settings should be used.
            SaveOptions options = new PdfSaveOptions
            {
                Timescale = Timescale.DefinedInView,
                PresentationFormat = PresentationFormat.TaskUsage
            };

            project.Save(OutDir + "TaskUsageView_CustomTimescale_out.pdf", options);

            // ExEnd:RenderTaskUsageViewCustomTimescale
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