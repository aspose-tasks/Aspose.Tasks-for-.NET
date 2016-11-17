using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Aspose.Tasks.Examples.CSharp.WorkingWithTasks
{
    class CalculateTaskDurations
    {
        public static void Run()
        {
            // ExStart:CalculateTaskDurations
            // Create project instance
            string dataDir = RunExamples.GetDataDir(System.Reflection.MethodBase.GetCurrentMethod().DeclaringType.FullName);
            Project project1 = new Project(dataDir + "TaskDurations.mpp");

            // Get a task to calculate its duration in different formats
            Task task = project1.RootTask.Children.GetById(1);

            // Get the duration in Minutes, Days, Hours, Weeks and Months
            double mins = task.Get(Tsk.Duration).Convert(TimeUnitType.Minute).ToDouble();
            Console.WriteLine("Duration in Mins: {0}", mins);
            double days = task.Get(Tsk.Duration).Convert(TimeUnitType.Day).ToDouble();
            Console.WriteLine("Duration in Days: {0}", days);
            double hours = task.Get(Tsk.Duration).Convert(TimeUnitType.Hour).ToDouble();
            Console.WriteLine("Duration in Hours: {0}", hours);
            double weeks = task.Get(Tsk.Duration).Convert(TimeUnitType.Week).ToDouble();
            Console.WriteLine("Duration in Weeks: {0}", weeks);
            double months = task.Get(Tsk.Duration).Convert(TimeUnitType.Month).ToDouble();
            Console.WriteLine("Duration in Months: {0}", months);
            // ExStart:CalculateTaskDurations
        }
    }
}
