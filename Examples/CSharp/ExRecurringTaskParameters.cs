namespace Aspose.Tasks.Examples.CSharp
{
    using System;
    using NUnit.Framework;

    [TestFixture]
    public class ExRecurringTaskParameters : ApiExampleBase
    {
        [Test]
        public void CreateRecurringTask()
        {
            try
            {
                // ExStart:CreateRecurringTask
                // ExFor: RecurringTaskParameters
                // ExFor: RecurringTaskParameters.#ctor
                // ExFor: RecurringTaskParameters.Duration
                // ExFor: RecurringTaskParameters.RecurrencePattern
                // ExFor: RecurringTaskParameters.IgnoreResourceCalendar
                // ExFor: RecurringTaskParameters.TaskName
                // ExFor: RecurringTaskParameters.SetCalendar(Project,String)
                // ExFor: WeeklyRecurrencePattern
                // ExFor: WeeklyRecurrencePattern.#ctor
                // ExFor: WeeklyRecurrencePattern.Repetition
                // ExFor: EndByRecurrenceRange
                // ExFor: EndByRecurrenceRange.#ctor
                // ExFor: EndByRecurrenceRange.Finish
                // ExFor: WeeklyRepetition
                // ExFor: WeeklyRepetition.#ctor
                // ExFor: WeeklyRepetition.WeekDays
                // ExFor: WeeklyRepetitionBase
                // ExFor: WeeklyRepetitionBase.#ctor
                // ExFor: WeeklyRepetitionBase.RepetitionInterval
                // ExFor: WeekdayType
                // ExFor: RecurrencePattern
                // ExSummary: Shows how to create a recurring task.
                var project = new Project(DataDir + "Blank2010.mpp");
                var parameters = new RecurringTaskParameters
                                     {
                                         TaskName = "Recurring task",
                                         Duration = project.GetDuration(1, TimeUnitType.Day),
                                         RecurrencePattern = new WeeklyRecurrencePattern
                                                                 {
                                                                     Repetition = new WeeklyRepetition
                                                                                      {
                                                                                          RepetitionInterval = 2,
                                                                                          WeekDays = WeekdayType.Sunday | WeekdayType.Monday | WeekdayType.Friday
                                                                                      },
                                                                     RecurrenceRange = new EndByRecurrenceRange
                                                                                           {
                                                                                               Start = new DateTime(2018, 7, 1, 8, 0, 0),
                                                                                               Finish = new DateTime(2018, 7, 20, 17, 0, 0)
                                                                                           }
                                                                 },
                                         IgnoreResourceCalendar = false
                                     };

                parameters.SetCalendar(project, "Standard");

                project.RootTask.Children.Add(parameters);

                // ExEnd:CreateRecurringTask
            }
            catch (NotSupportedException ex)
            {
                Console.WriteLine(ex.Message + "\nThis example will only work if you apply a valid Aspose License. You can purchase full license or get 30 day temporary license from http://www.aspose.com/purchase/default.aspx.");
            }
        }
    }
}