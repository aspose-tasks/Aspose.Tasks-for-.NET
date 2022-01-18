namespace Aspose.Tasks.Examples.CSharp
{
    using System;
    using NUnit.Framework;
    using Saving;

    [TestFixture]
    public class ExYearlyRecurrencePattern : ApiExampleBase
    {
        [Test]
        public void WorkWithYearlyRecurrencePattern()
        {
            try
            {
                // ExStart
                // ExFor: YearlyRecurrencePattern
                // ExFor: YearlyRecurrencePattern.#ctor
                // ExFor: YearlyRecurrencePattern.Repetition
                // ExSummary: Shows how to work with year year recurrence patterns while creating recurring tasks.
                var project = new Project(DataDir + "Project1.mpp");
                var parameters = new RecurringTaskParameters
                                     {
                                         TaskName = "t1",
                                         Duration = project.GetDuration(1, TimeUnitType.Day),
                                         RecurrencePattern = new YearlyRecurrencePattern
                                                                 {
                                                                     Repetition = new ByYearDayRepetition { DayPosition = 1, Month = Month.July },
                                                                     RecurrenceRange = new EndByRecurrenceRange
                                                                                           {
                                                                                               Start = new DateTime(2018, 7, 1, 8, 0, 0),
                                                                                               Finish = new DateTime(2019, 7, 1, 17, 0, 0)
                                                                                           }
                                                                 }
                                     };
                project.RootTask.Children.Add(parameters);

                project.Save(OutDir + "WorkWithYearlyRecurrencePattern_out.mpp", SaveFileFormat.Mpp);

                // ExEnd
            }
            catch (NotSupportedException ex)
            {
                Console.WriteLine(ex.Message + "\nThis example will only work if you apply a valid Aspose License. You can purchase full license or get 30 day temporary license from http://www.aspose.com/purchase/default.aspx.");
            }
        }
    }
}