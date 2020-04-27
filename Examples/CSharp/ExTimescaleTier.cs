namespace Aspose.Tasks.Examples.CSharp
{
    using System;
    using NUnit.Framework;
    using Saving;
    using Visualization;

    [TestFixture]
    public class ExTimescaleTier : ApiExampleBase
    {
        [Test]
        public void CustomizeTimescaleTierLabels()
        {
            // ExStart:CustomizeTimescaleTierLabels
            // ExFor: TimescaleTier
            // ExFor: TimescaleTier.#ctor
            // ExFor: TimescaleTier.Unit
            // ExFor: TimescaleTier.DateTimeConverter
            // ExSummary: Shows how to customize timescale tier labels.
            var project = new Project(DataDir + "Project5.mpp");

            // Add task links
            project.TaskLinks.Add(project.RootTask.Children.Add("Task 1"), project.RootTask.Children.Add("Task 2"));

            var view = (GanttChartView)project.DefaultView;

            // This code is added for better visualization
            view.MiddleTimescaleTier.Unit = TimescaleUnit.Months;
            project.Set(Prj.TimescaleStart, new DateTime(2012, 8, 6));

            // Customize middle tier dates
            view.MiddleTimescaleTier.DateTimeConverter = date =>
                new[] { "Янв.", "Фев.", "Мар.", "Апр.", "Май", "Июнь", "Июль", "Авг.", "Сен.", "Окт.", "Ноя.", "Дек." }[date.Month - 1];
            project.Save(OutDir + "CustomizeTimescaleTierLabels_out.pdf", SaveFileFormat.PDF);

            // ExEnd:CustomizeTimescaleTierLabels
        }
    }
}