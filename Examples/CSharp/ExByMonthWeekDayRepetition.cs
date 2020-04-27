namespace Aspose.Tasks.Examples.CSharp
{
    using System;
    using NUnit.Framework;
    using Saving;

    [TestFixture]
    public class ExByMonthWeekDayRepetition : ApiExampleBase
    {
        [Test]
        public void WorkWithByMonthDayRepetition()
        {
            try
            {
                // ExStart
                // ExFor: ByMonthWeekDayRepetition
                // ExFor: ByMonthWeekDayRepetition.#ctor
                // ExFor: ByMonthWeekDayRepetition.Position
                // ExFor: ByMonthWeekDayRepetition.WeekDay
                // ExSummary: Shows how to work with month weekday repetitions while create a new recurring tasks.
                var project = new Project(DataDir + "Project1.mpp");
                var parameters = new RecurringTaskParameters
                                     {
                                         TaskName = "t1",
                                         Duration = project.GetDuration(1, TimeUnitType.Day),
                                         RecurrencePattern = new MonthlyRecurrencePattern
                                                                 {
                                                                     Repetition = new ByMonthWeekDayRepetition
                                                                                      {
                                                                                          Position = OrdinalNumber.First,
                                                                                          WeekDay = DayOfWeek.Sunday,
                                                                                          RepetitionInterval = 2
                                                                                      },
                                                                     RecurrenceRange = new EndByRecurrenceRange
                                                                                           {
                                                                                               Start = new DateTime(2018, 7, 1, 8, 0, 0),
                                                                                               Finish = new DateTime(2018, 9, 2, 17, 0, 0)
                                                                                           }
                                                                 }
                                     };
                project.RootTask.Children.Add(parameters);
                project.Save(OutDir + "CanAddRecurringTask_Months_WeekDay_EndByRecurrenceRange_Test_out.mpp", SaveFileFormat.MPP);

                // ExEnd
            }
            catch (NotSupportedException ex)
            {
                Console.WriteLine(ex.Message + "\nThis example will only work if you apply a valid Aspose License. You can purchase full license or get 30 day temporary license from http://www.aspose.com/purchase/default.aspx.");
            }
        }
    }
}