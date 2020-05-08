namespace Aspose.Tasks.Examples.CSharp
{
    using System;
    using System.Diagnostics.CodeAnalysis;
    using NUnit.Framework;

    [TestFixture]
    public class ExDuration : ApiExampleBase
    {
        [Test]
        [SuppressMessage("ReSharper", "RedundantToStringCallForValueType", Justification = "Reviewed. Suppression is OK here.")]
        public void WorkWithDurations()
        {
            {
                // ExStart:UpdateDurationOfTasks
                // ExFor: Duration
                // ExFor: Duration.Add(Duration)
                // ExFor: Duration.Add(Double)
                // ExFor: Duration.TimeUnit
                // ExSummary: Shows how to update a duration of tasks.
                var project = new Project(DataDir + "TaskDurations.mpp");

                // get a task
                var task1 = project.RootTask.Children.GetById(1);

                // update the task duration
                var duration1 = task1.Get(Tsk.Duration);

                // add one day to the task 1
                duration1 = duration1.Add(project.GetDuration(1, TimeUnitType.Day));

                // set a new duration to the task
                task1.Set(Tsk.Duration, duration1);
                Console.WriteLine("The duration of task 1: " + task1.Get(Tsk.Duration));

                // get another task
                var task2 = project.RootTask.Children.GetById(2);
                var duration2 = task2.Get(Tsk.Duration);

                // change the duration by using actual time unit type
                Console.WriteLine("The time unit of duration: " + duration2.TimeUnit);
                duration2 = duration2.Add(1d /* the time unit type of duration2 will be used */);

                // set a new duration to the task
                task2.Set(Tsk.Duration, duration2);
                Console.WriteLine("The duration of task 2: " + task1.Get(Tsk.Duration));

                // ExEnd:UpdateDurationOfTasks
            }

            {
                // ExStart:SubtractDurationOfTasks
                // ExFor: Duration.Subtract(Double)
                // ExFor: Duration.Subtract(Duration)
                // ExSummary: Shows how to change a duration of tasks.
                var project = new Project(DataDir + "TaskDurations.mpp");

                // get a task
                var task1 = project.RootTask.Children.GetById(1);

                // update the task duration
                var duration1 = task1.Get(Tsk.Duration);

                // subtract one day to the task 1
                duration1 = duration1.Subtract(project.GetDuration(1, TimeUnitType.Day));

                // set a new duration to the task
                task1.Set(Tsk.Duration, duration1);
                Console.WriteLine("The duration of task 1: " + task1.Get(Tsk.Duration));

                // get another task
                var task2 = project.RootTask.Children.GetById(2);
                var duration2 = task2.Get(Tsk.Duration);

                // change the duration by using actual time unit type
                Console.WriteLine("The time unit of duration: " + duration2.TimeUnit);
                duration2 = duration2.Subtract(1d /* the time unit type of duration2 will be used */);

                // set a new duration to the task
                task2.Set(Tsk.Duration, duration2);
                Console.WriteLine("The duration of task 2: " + task2.Get(Tsk.Duration));

                // ExEnd:UpdateDurationOfTasks
            }

            {
                // ExStart:ConvertDurationToTimeSpan
                // ExFor: Duration.TimeSpan
                // ExSummary: Shows how to convert a duration to a time span.
                var project = new Project(DataDir + "TaskDurations.mpp");
                var task = project.RootTask.Children.GetById(1);

                // get the task duration
                var duration = task.Get(Tsk.Duration);
                Console.WriteLine("Time span of duration: " + duration.TimeSpan);

                // ExEnd:ConvertDurationToTimeSpan
            }

            {
                // ExStart:ConvertDurationToString
                // ExFor: Duration.ToString
                // ExSummary: Shows how to convert a duration to a string.
                var project = new Project(DataDir + "TaskDurations.mpp");
                var task = project.RootTask.Children.GetById(1);

                // get the task duration
                var duration = task.Get(Tsk.Duration);
                Console.WriteLine("The duration as a string: " + duration.ToString());

                // ExEnd:ConvertDurationToString
            }
        }

        [Test]
        public void TestDurationParseTimeSpan()
        {
            // ExStart:ConvertTimeSpanFromString
            // ExFor: Duration.ParseTimeSpan(String)
            // ExSummary: Shows how to convert a string into a time span.
            var timeSpan = Duration.ParseTimeSpan("PT1H10M30S");
            Console.WriteLine("The parsed time span: " + timeSpan);

            // ExEnd:ConvertTimeSpanFromString
        }

        [Test]
        public void TestDurationParse()
        {
            // ExStart:TestDurationParse
            // ExFor: Duration.Parse(Project,String)
            // ExFor: Duration.IsElapsed
            // ExFor: Duration.IsEstimated
            // ExSummary: Shows how to parse a string from a specially formatted string.
            var project = new Project();

            // examples of durations:
            // "1d", "1dy", "1d?", "1day", "1 dy", "1 edy? ", "8hr", "8 hour", "8hours", "0.2w?", "0.2wk", "0.2 eweek", "0.2ew?"
            // where 1 - number of items (day, week, etc), d - day (h - hour, w - week) ? - estimated flag, e - elapsed flag

            // try to parse an estimated duration
            var duration1 = Duration.Parse(project, "1d?");
            Console.WriteLine("The parsed time span: " + duration1.TimeSpan);
            Console.WriteLine("The parsed time unit: " + duration1.TimeUnit);
            Console.WriteLine("Is estimated duration?: " + duration1.IsEstimated);
            Console.WriteLine("Is elapsed duration?: " + duration1.IsElapsed);
            Console.WriteLine();

            // try to parse an estimated duration
            var duration2 = Duration.Parse(project, "0.2 eweek");
            Console.WriteLine("The parsed time span: " + duration2.TimeSpan);
            Console.WriteLine("The parsed time unit: " + duration2.TimeUnit);
            Console.WriteLine("Is estimated duration?: " + duration2.IsEstimated);
            Console.WriteLine("Is elapsed duration?: " + duration2.IsElapsed);

            // ExEnd:ConvertTimeSpanFromString
            Assert.IsTrue(duration1.IsEstimated);
            Assert.IsFalse(duration1.IsElapsed);

            Assert.IsFalse(duration2.IsEstimated);
            Assert.IsTrue(duration2.IsElapsed);
        }

        [Test]
        public void GetDurationHashCode()
        {
            // ExStart
            // ExFor: Duration.GetHashCode
            // ExSummary: Shows how to get a hash code of a duration.
            var project = new Project();

            var duration1 = project.GetDuration(1, TimeUnitType.Day);
            var duration2 = project.GetDuration(1, TimeUnitType.Day);
            var duration3 = project.GetDuration(1, TimeUnitType.Hour);

            // the hash code of a calendar is based on time unit type and initial value of duration
            // so next hash codes are equal
            Console.WriteLine("Duration 1 Hash Code: {0}", duration1.GetHashCode());
            Console.WriteLine("Duration 2 Hash Code: {0}", duration2.GetHashCode());
            Console.WriteLine("Are duration's hash codes of duration 1 and duration 2 equal: {0}", duration1.GetHashCode().Equals(duration2.GetHashCode()));

            // but hash codes of duration 1 and 3 is not
            Console.WriteLine("Duration 1 Hash Code: {0}", duration1.GetHashCode());
            Console.WriteLine("Duration 3 Hash Code: {0}", duration3.GetHashCode());
            Console.WriteLine("Are duration's hash codes of duration 1 and duration 2 equal: {0}", duration1.GetHashCode().Equals(duration3.GetHashCode()));

            // ExEnd
            Assert.AreEqual(duration1.GetHashCode(), duration2.GetHashCode());
            Assert.AreNotEqual(duration3.GetHashCode(), duration1.GetHashCode());
            Assert.AreNotEqual(duration3.GetHashCode(), duration2.GetHashCode());
        }

        [Test]
        public void DurationEquals()
        {
            // ExStart
            // ExFor: Duration.Equals(Duration)
            // ExFor: Duration.Equals(Object)
            // ExFor: Duration.op_Equality(Duration,Duration)
            // ExFor: Duration.op_Inequality(Duration,Duration)
            // ExSummary: Shows how to check duration equality.
            var project = new Project();

            var duration1 = project.GetDuration(1, TimeUnitType.Day);
            var duration2 = project.GetDuration(1, TimeUnitType.Day);
            var duration3 = project.GetDuration(1, TimeUnitType.Hour);

            // the equality of duration is checked against to underlying timespan
            Console.WriteLine("Duration 1: " + duration1.TimeSpan);
            Console.WriteLine("Duration 2: " + duration2.TimeSpan);
            Console.WriteLine("Duration 3: " + duration3.TimeSpan);
            Console.WriteLine("Are durations 1 and 2 equal: " + duration1.Equals(duration2));
            Console.WriteLine("Are durations 1 and 3 equal: " + duration1.Equals(duration3));

            // ExEnd
        }

        [Test]
        public void CalculateTaskDurations()
        {
            // ExStart:CalculateTaskDurations
            // ExFor: Duration.ToDouble
            // ExFor: Duration.Convert(TimeUnitType)
            // ExFor: TimeUnitType
            // ExSummary: Shows how to convert a duration into different time unit types.
            var project = new Project(DataDir + "TaskDurations.mpp");

            // Get a task to calculate its duration in different formats
            var task = project.RootTask.Children.GetById(1);

            // Get the duration in Minutes, Days, Hours, Weeks and Months
            var mins = task.Get(Tsk.Duration).Convert(TimeUnitType.Minute).ToDouble();
            Console.WriteLine("Duration in Mins: {0}", mins);
            var days = task.Get(Tsk.Duration).Convert(TimeUnitType.Day).ToDouble();
            Console.WriteLine("Duration in Days: {0}", days);
            var hours = task.Get(Tsk.Duration).Convert(TimeUnitType.Hour).ToDouble();
            Console.WriteLine("Duration in Hours: {0}", hours);
            var weeks = task.Get(Tsk.Duration).Convert(TimeUnitType.Week).ToDouble();
            Console.WriteLine("Duration in Weeks: {0}", weeks);
            var months = task.Get(Tsk.Duration).Convert(TimeUnitType.Month).ToDouble();
            Console.WriteLine("Duration in Months: {0}", months);

            // ExEnd:CalculateTaskDurations
        }
    }
}