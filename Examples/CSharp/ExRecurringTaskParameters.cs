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
                //ExStart:CreateRecurringTask
                //ExFor: RecurringTaskParameters
                //ExSummary: Shows how to create a recurring task.
                var project = new Project(DataDir + "Blank2010.mpp");
                var parameters = new RecurringTaskParameters
                {
                    TaskName = "Recurring task",
                    Duration = project.GetDuration(1, TimeUnitType.Day),
                    RecurrencePattern =
                                             new WeeklyRecurrencePattern
                                             {
                                                 Repetition = new WeeklyRepetition
                                                 {
                                                     RepetitionInterval = 2,
                                                     WeekDays =
                                                                              WeekdayType.Sunday | WeekdayType.Monday
                                                                                                 | WeekdayType.Friday
                                                 },
                                                 RecurrenceRange =
                                                         new EndByRecurrenceRange
                                                         {
                                                             Start = new DateTime(2018, 7, 1, 8, 0, 0),
                                                             Finish = new DateTime(2018, 7, 20, 17, 0, 0)
                                                         }
                                             }
                };
                project.RootTask.Children.Add(parameters);
                //ExEnd:CreateRecurringTask
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message + "\nThis example will only work if you apply a valid Aspose License. You can purchase full license or get 30 day temporary license from http://www.aspose.com/purchase/default.aspx.");
            }
        }
    }
}