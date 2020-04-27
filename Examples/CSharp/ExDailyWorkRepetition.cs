namespace Aspose.Tasks.Examples.CSharp
{
    using System;
    using System.Diagnostics.CodeAnalysis;
    using NUnit.Framework;

    [TestFixture]
    public class ExDailyWorkRepetition : ApiExampleBase
    {
        [Test]
        [SuppressMessage("ReSharper", "UnusedVariable", Justification = "Reviewed. Suppression is OK here.")]
        public void WorkWithDailyWorkRepetition()
        {
            // ExStart
            // ExFor: DailyWorkRepetition
            // ExFor: DailyWorkRepetition.#ctor
            // ExFor: DailyRepetitionBase
            // ExFor: DailyRepetitionBase.#ctor
            // ExFor: DailyRepetitionBase.RepetitionInterval
            // ExFor: DailyRecurrencePattern
            // ExFor: DailyRecurrencePattern.#ctor
            // ExFor: DailyRecurrencePattern.Repetition
            // ExFor: EndAfterRecurrenceRange
            // ExFor: EndAfterRecurrenceRange.#ctor
            // ExFor: EndAfterRecurrenceRange.OccurrenceNumber
            // ExFor: RecurrenceRangeBase
            // ExFor: RecurrenceRangeBase.#ctor
            // ExFor: RecurrenceRangeBase.Start
            // ExFor: RecurrencePatternBase
            // ExFor: RecurrencePatternBase.#ctor
            // ExFor: RecurrencePatternBase.RecurrenceRange
            // ExSummary: Shows how to work with daily work repetition pattern repetitions while create recurring tasks.
            var project = new Project(DataDir + "Project1.mpp");
            var parameters = new RecurringTaskParameters
                                 {
                                     TaskName = "New recurrent task",
                                     RecurrencePattern = new DailyRecurrencePattern
                                                             {
                                                                 RecurrenceRange = new EndAfterRecurrenceRange
                                                                                       {
                                                                                           Start = new DateTime(2018, 1, 1, 8, 0, 0), OccurrenceNumber = 9
                                                                                       },
                                                                 Repetition = new DailyWorkRepetition { RepetitionInterval = 1 }
                                                             },
                                     Duration = project.GetDuration(1, TimeUnitType.Hour)
                                 };
            parameters.SetCalendar(project, "Standard");

            var task = project.RootTask.Children.Add(parameters);
            task.Set(Tsk.Start, new DateTime(2020, 4, 27, 8, 0, 0));

            // work with the project further...
            // ...
            // ExEnd
        }
    }
}