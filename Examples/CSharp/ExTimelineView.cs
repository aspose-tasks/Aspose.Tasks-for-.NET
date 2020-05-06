namespace Aspose.Tasks.Examples.CSharp
{
    using System;
    using NUnit.Framework;
    using Saving;

    [TestFixture]
    public class ExTimelineView : ApiExampleBase
    {
        [Test]
        public void WorkWithTimelineView()
        {
            // ExStart
            // ExFor: TimelineView
            // ExFor: TimelineView.#ctor
            // ExFor: TimelineView.DateFormat
            // ExFor: TimelineView.DisplayOverlapped
            // ExFor: TimelineView.ShowDates
            // ExFor: TimelineView.ShowPanZoom
            // ExFor: TimelineView.ShowTimescale
            // ExFor: TimelineView.ShowToday
            // ExFor: TimelineView.TextLinesCount
            // ExSummary: Shows how to work with <see cref="Aspose.Tasks.TimelineView" />.
            var project = new Project();

            // initialize a timeline view
            var view = new TimelineView();

            // set a value indicating how to format dates on the Timeline view.
            view.DateFormat = DateFormat.DateDddDd;
            // set a value indicating whether to display overlapped tasks on multiple rows.
            view.DisplayOverlapped = true;
            // set a value indicating whether to show pan and zoom control.
            view.ShowPanZoom = true;
            // set a value indicating whether to show timescale.
            view.ShowTimescale = true;
            // set a value indicating whether to display a line representing today.
            view.ShowToday = true;
            // set a value indicating how many lines are used to display task in a timeline.
            view.TextLinesCount = 2;
            
            // gets a value indicating whether to display overlapped tasks on multiple rows.
            Console.WriteLine("Show Dates: " + view.ShowDates);

            // add the view to the project
            project.Views.Add(view);

            // add some test data to project
            var task1 = project.RootTask.Children.Add("Task 1");
            task1.Set(Tsk.Start, new DateTime(2020, 4, 29, 8, 0, 0));
            task1.Set(Tsk.Duration, task1.ParentProject.GetDuration(24, TimeUnitType.Hour));
            var task2 = project.RootTask.Children.Add("Task 2");
            task2.Set(Tsk.Start, new DateTime(2020, 4, 29, 8, 0, 0));
            task2.Set(Tsk.Duration, task1.ParentProject.GetDuration(40, TimeUnitType.Hour));
            
            project.Save(OutDir + "SetTimeScaleCount_out.pdf", SaveFileFormat.PDF);
            // ExEnd
        }
    }
}