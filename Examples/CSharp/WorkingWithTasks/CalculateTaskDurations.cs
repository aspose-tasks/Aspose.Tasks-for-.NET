namespace Aspose.Tasks.Examples.CSharp.WorkingWithTasks
{
    using System;

    internal class CalculateTaskDurations
    {
        public static void Run()
        {
            var dataDir = RunExamples.GetDataDir(System.Reflection.MethodBase.GetCurrentMethod().DeclaringType.FullName);

            //ExStart:CalculateTaskDurations
            //ExFor: Duration.Convert(TimeUnitType)
            //ExSummary: Shows how to convert a duration into different time unit types.
            // Create project instance
            var project = new Project(dataDir + "TaskDurations.mpp");

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
            //ExEnd:CalculateTaskDurations
        }
    }
}
