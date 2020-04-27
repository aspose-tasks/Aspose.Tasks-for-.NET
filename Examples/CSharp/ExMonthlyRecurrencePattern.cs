namespace Aspose.Tasks.Examples.CSharp
{
    using System;
    using NUnit.Framework;
    using Saving;

    [TestFixture]
    public class ExMonthlyRecurrencePattern : ApiExampleBase
    {
        [Test]
        public void WorkWithMonthlyRecurrencePattern()
        {
            try
            {
                // ExStart
                // ExFor: MonthlyRecurrencePattern
                // ExFor: MonthlyRecurrencePattern.#ctor
                // ExFor: MonthlyRecurrencePattern.Repetition
                // ExFor: MonthlyRepetitionBase
                // ExFor: MonthlyRepetitionBase.#ctor
                // ExFor: MonthlyRepetitionBase.RepetitionInterval
                // ExSummary: Shows how to work with monthly recurrence pattern repetitions while create recurring tasks.
                var project = new Project(DataDir + "Project1.mpp");
                var parameters = new RecurringTaskParameters
                                     {
                                         TaskName = "t1",
                                         Duration = project.GetDuration(1, TimeUnitType.Day),
                                         RecurrencePattern = new MonthlyRecurrencePattern
                                                                 {
                                                                     Repetition = new ByMonthDayRepetition { DayPosition = 1, RepetitionInterval = 2 },
                                                                     RecurrenceRange = new EndByRecurrenceRange
                                                                                           {
                                                                                               Start = new DateTime(2018, 7, 1, 8, 0, 0),
                                                                                               Finish = new DateTime(2018, 9, 30, 17, 0, 0)
                                                                                           }
                                                                 }
                                     };
                project.RootTask.Children.Add(parameters);

                project.Save(OutDir + "CanAddRecurringTask_Months_EndByRecurrenceRange_Test_out.mpp", SaveFileFormat.MPP);

                // ExEnd
            }
            catch (NotSupportedException ex)
            {
                Console.WriteLine(ex.Message + "\nThis example will only work if you apply a valid Aspose License. You can purchase full license or get 30 day temporary license from http://www.aspose.com/purchase/default.aspx.");
            }
        }
    }
}