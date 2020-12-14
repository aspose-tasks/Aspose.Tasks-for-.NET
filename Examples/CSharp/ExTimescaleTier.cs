namespace Aspose.Tasks.Examples.CSharp
{
    using System;
    using System.Drawing;
    using NUnit.Framework;
    using Saving;
    using Visualization;

    [TestFixture]
    public class ExTimescaleTier : ApiExampleBase
    {
        [Test]
        public void WorkWithTimescaleTier()
        {
            // ExStart:CustomizeTimescaleTierLabels
            // ExFor: TimescaleTier
            // ExFor: TimescaleTier.#ctor
            // ExFor: TimescaleTier.#ctor(TimescaleUnit,Int32)
            // ExFor: TimescaleTier.Unit
            // ExFor: TimescaleTier.DateTimeConverter
            // ExFor: TimescaleTier.Alignment
            // ExFor: TimescaleTier.Count
            // ExFor: TimescaleTier.Label
            // ExFor: TimescaleTier.ShowTicks
            // ExFor: TimescaleTier.UsesFiscalYear
            // ExFor: TimescaleUnit
            // ExFor: DateLabel
            // ExFor: DateTimeConverter
            // ExFor: GanttChartView.TopTimescaleTier
            // ExFor: GanttChartView.MiddleTimescaleTier
            // ExFor: Timescale.DefinedInView
            // ExSummary: Shows how to customize timescale tier labels.
            var project = new Project(DataDir + "CreateProject1.mpp");

            // Add task links
            project.TaskLinks.Add(project.RootTask.Children.Add("Task 1"), project.RootTask.Children.Add("Task 2"));

            var view = (GanttChartView)project.DefaultView;
            
            // tune timescale tiers
            
            // tune the top tier
            // set the top timescale tier of the Gantt Chart view.
            view.MiddleTimescaleTier = new TimescaleTier();
            // set timescale unit <see cref="T:Aspose.Tasks.Visualization.TimescaleUnit" /> for the timescale tier.
            view.MiddleTimescaleTier.Unit = TimescaleUnit.Weeks;
            // set the time unit interval in which to show labels for the tier.
            view.MiddleTimescaleTier.Count = 1;
            // set date label <see cref="T:Aspose.Tasks.Visualization.DateLabel" /> for the timescale tier.
            view.MiddleTimescaleTier.Label = DateLabel.WeekDddDd;
            // set how to align labels within each time period of the tier (<see cref="T:System.Drawing.StringAlignment" />).
            view.MiddleTimescaleTier.Alignment = StringAlignment.Center;
            // set a value indicating whether whether to show tick marks that separate time periods in the tier.
            view.MiddleTimescaleTier.ShowTicks = true;
            // set a value indicating whether to base the tier labels on the fiscal year.
            view.MiddleTimescaleTier.UsesFiscalYear = true;

            // added for better visualization
            view.TopTimescaleTier = new TimescaleTier(TimescaleUnit.Months, 1);

            // customize middle tier dates
            view.TopTimescaleTier.DateTimeConverter = date =>
                new[] { "Янв.", "Фев.", "Мар.", "Апр.", "Май", "Июнь", "Июль", "Авг.", "Сен.", "Окт.", "Ноя.", "Дек." }[date.Month - 1];
            
            project.Set(Prj.TimescaleStart, new DateTime(2012, 7, 30));
            project.Set(Prj.TimescaleFinish, new DateTime(2012, 10, 6));

            // Use 'Timescale.DefinedInView' option to render timescales using timescale settings defined in view (view.TopTimescaleTier, view.MiddleTimescaleTier, view.BottomTimescaleTier). 
            var pdfSaveOptions = new PdfSaveOptions
            {
                Timescale = Timescale.DefinedInView
            };
            
            project.Save(OutDir + "CustomizeTimescaleTierLabels_out.pdf", pdfSaveOptions);

            // ExEnd:CustomizeTimescaleTierLabels
        }
    }
}