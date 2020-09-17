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
            // ExSummary: Shows how to customize timescale tier labels.
            var project = new Project(DataDir + "CreateProject1.mpp");

            // Add task links
            project.TaskLinks.Add(project.RootTask.Children.Add("Task 1"), project.RootTask.Children.Add("Task 2"));

            var view = (GanttChartView)project.DefaultView;
            
            // tune timescale tiers
            
            // tune the top tier
            // set the top timescale tier of the Gantt Chart view.
            view.TopTimescaleTier = new TimescaleTier();
            // set timescale unit <see cref="T:Aspose.Tasks.Visualization.TimescaleUnit" /> for the timescale tier.
            view.TopTimescaleTier.Unit = TimescaleUnit.Months;
            // set the time unit interval in which to show labels for the tier.
            view.TopTimescaleTier.Count = 1;
            // set date label <see cref="T:Aspose.Tasks.Visualization.DateLabel" /> for the timescale tier.
            view.TopTimescaleTier.Label = DateLabel.DayDdd;
            // set how to align labels within each time period of the tier (<see cref="T:System.Drawing.StringAlignment" />).
            view.TopTimescaleTier.Alignment = StringAlignment.Center;
            // set a value indicating whether whether to show tick marks that separate time periods in the tier.
            view.TopTimescaleTier.ShowTicks = true;
            // set a value indicating whether to base the tier labels on the fiscal year.
            view.TopTimescaleTier.UsesFiscalYear = true;

            // added for better visualization
            view.MiddleTimescaleTier = new TimescaleTier(TimescaleUnit.Months, 1);
            project.Set(Prj.TimescaleStart, new DateTime(2012, 8, 6));

            // customize middle tier dates
            view.MiddleTimescaleTier.DateTimeConverter = date =>
                new[] { "Янв.", "Фев.", "Мар.", "Апр.", "Май", "Июнь", "Июль", "Авг.", "Сен.", "Окт.", "Ноя.", "Дек." }[date.Month - 1];
            
            project.Save(OutDir + "CustomizeTimescaleTierLabels_out.pdf", SaveFileFormat.PDF);

            // ExEnd:CustomizeTimescaleTierLabels
        }
    }
}