namespace Aspose.Tasks.Examples.CSharp
{
    using System;
    using NUnit.Framework;
    using Saving;

    [TestFixture]
    public class ExByYearWeekDayRepetition : ApiExampleBase
    {
        [Test]
        public void WorkWithByYearWeekDayRepetition()
        {
            try
            {
                //ExStart
                //ExFor: ByYearWeekDayRepetition
                //ExFor: ByYearWeekDayRepetition.#ctor
                //ExFor: ByYearWeekDayRepetition.Month
                //ExFor: ByYearWeekDayRepetition.Position
                //ExFor: ByYearWeekDayRepetition.WeekDay
                //ExSummary: Shows how to work with year weekday repetitions while create a new recurring tasks.
                var project = new Project(DataDir + "Blank2010.mpp");
                var parameters = new RecurringTaskParameters
                {
                    TaskName = "t1",
                    Duration = project.GetDuration(1, TimeUnitType.Day),
                    RecurrencePattern =
                        new YearlyRecurrencePattern
                        {
                            Repetition = new ByYearWeekDayRepetition
                            {
                                Month = Month.July,
                                WeekDay = DayOfWeek.Sunday,
                                Position = OrdinalNumber.First
                            },
                            RecurrenceRange =
                                new EndByRecurrenceRange
                                {
                                    Start = new DateTime(2018, 7, 1, 8, 0, 0),
                                    Finish = new DateTime(2019, 7, 31, 17, 0, 0)
                                }
                        }
                };
                project.RootTask.Children.Add(parameters);

                project.Save(OutDir + "CanAddRecurringTask_Years_YearWeekDay_EndByRecurrenceRange_Test.mpp", SaveFileFormat.MPP);
                //ExEnd
            }
            catch (NotSupportedException ex)
            {
                Console.WriteLine(ex.Message + "\nThis example will only work if you apply a valid Aspose License. You can purchase full license or get 30 day temporary license from http://www.aspose.com/purchase/default.aspx.");
            }
        }
    }
}