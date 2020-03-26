namespace Aspose.Tasks.Examples.CSharp.WorkingWithTasks
{
    using System;

    internal class CalculateSplitTaskFinishDate
    {
        public static void Run()
        {
            var dataDir = RunExamples.GetDataDir(System.Reflection.MethodBase.GetCurrentMethod());

            //ExStart:CalculateSplitTaskFinishDate
            //ExFor: Calendar.GetTaskFinishDateFromDuration(Task, TimeSpan)
            //ExSummary: Shows how to calculate finish date of a task by a custom duration.
            var project = new Project(dataDir + "SplitTaskFinishDate.mpp");

            // Find a split task
            var task = project.RootTask.Children.GetByUid(4);

            // Find the project calendar
            var calendar = project.Get(Prj.Calendar);

            // Calculate task's finish date with different durations
            Console.WriteLine("Start Date: " + task.Get(Tsk.Start).ToShortDateString() + "\n+ Duration 8 hours\nFinish Date: " + calendar.GetTaskFinishDateFromDuration(task, new TimeSpan(8, 0, 0)));
            Console.WriteLine("Start Date: " + task.Get(Tsk.Start).ToShortDateString() + "\n+ Duration 16 hours\nFinish Date: " + calendar.GetTaskFinishDateFromDuration(task, new TimeSpan(16, 0, 0)));
            Console.WriteLine("Start Date: " + task.Get(Tsk.Start).ToShortDateString() + "\n+ Duration 24 hours\nFinish Date: " + calendar.GetTaskFinishDateFromDuration(task, new TimeSpan(24, 0, 0)));
            Console.WriteLine("Start Date: " + task.Get(Tsk.Start).ToShortDateString() + "\n+ Duration 28 hours\nFinish Date: " + calendar.GetTaskFinishDateFromDuration(task, new TimeSpan(28, 0, 0)));
            Console.WriteLine("Start Date: " + task.Get(Tsk.Start).ToShortDateString() + "\n+ Duration 32 hours\nFinish Date: " + calendar.GetTaskFinishDateFromDuration(task, new TimeSpan(32, 0, 0)));
            Console.WriteLine("Start Date: " + task.Get(Tsk.Start).ToShortDateString() + "\n+ Duration 46 hours\nFinish Date: " + calendar.GetTaskFinishDateFromDuration(task, new TimeSpan(46, 0, 0)));
            Console.WriteLine("Start Date: " + task.Get(Tsk.Start).ToShortDateString() + "\n+ Duration 61 hours\nFinish Date: " + calendar.GetTaskFinishDateFromDuration(task, new TimeSpan(61, 0, 0)));
            Console.WriteLine("Start Date: " + task.Get(Tsk.Start).ToShortDateString() + "\n+ Duration 75 hours\nFinish Date: " + calendar.GetTaskFinishDateFromDuration(task, new TimeSpan(75, 0, 0)));
            Console.WriteLine("Start Date: " + task.Get(Tsk.Start).ToShortDateString() + "\n+ Duration 80 hours\nFinish Date: " + calendar.GetTaskFinishDateFromDuration(task, new TimeSpan(80, 0, 0)));
            Console.WriteLine("Start Date: " + task.Get(Tsk.Start).ToShortDateString() + "\n+ Duration 120 hours\nFinish Date: " + calendar.GetTaskFinishDateFromDuration(task, new TimeSpan(120, 0, 0)));
            Console.WriteLine("Start Date: " + task.Get(Tsk.Start).ToShortDateString() + "\n+ Duration 150 hours\nFinish Date: " + calendar.GetTaskFinishDateFromDuration(task, new TimeSpan(150, 0, 0)));
            //ExEnd:CalculateSplitTaskFinishDate
        }
    }
}
