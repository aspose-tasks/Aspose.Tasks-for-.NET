using System;

namespace Aspose.Tasks.Examples.CSharp.WorkingWithTasks
{
    class CalculateSplitTaskFinishDate
    {
        public static void Run()
        {
            //ExStart:CalculateSplitTaskFinishDate
            // Read project            
            string dataDir = RunExamples.GetDataDir(System.Reflection.MethodBase.GetCurrentMethod().DeclaringType.FullName);
            string projectName = "SplitTaskFinishDate.mpp";
            Project project = new Project(dataDir + projectName);

            // Find a split task
            Task splitTask = project.RootTask.Children.GetByUid(4);

            // Find the project calendar
            Calendar calendar = project.Get(Prj.Calendar);

            // Calculate task's finish date with different durations
            Console.WriteLine("Start Date: " + splitTask.Get(Tsk.Start).ToShortDateString() + "\n+ Duration 8 hours\nFinish Date: " + calendar.GetTaskFinishDateFromDuration(splitTask, new TimeSpan(8, 0, 0)));
            Console.WriteLine("Start Date: " + splitTask.Get(Tsk.Start).ToShortDateString() + "\n+ Duration 16 hours\nFinish Date: " + calendar.GetTaskFinishDateFromDuration(splitTask, new TimeSpan(16, 0, 0)));
            Console.WriteLine("Start Date: " + splitTask.Get(Tsk.Start).ToShortDateString() + "\n+ Duration 24 hours\nFinish Date: " + calendar.GetTaskFinishDateFromDuration(splitTask, new TimeSpan(24, 0, 0)));
            Console.WriteLine("Start Date: " + splitTask.Get(Tsk.Start).ToShortDateString() + "\n+ Duration 28 hours\nFinish Date: " + calendar.GetTaskFinishDateFromDuration(splitTask, new TimeSpan(28, 0, 0)));
            Console.WriteLine("Start Date: " + splitTask.Get(Tsk.Start).ToShortDateString() + "\n+ Duration 32 hours\nFinish Date: " + calendar.GetTaskFinishDateFromDuration(splitTask, new TimeSpan(32, 0, 0)));
            Console.WriteLine("Start Date: " + splitTask.Get(Tsk.Start).ToShortDateString() + "\n+ Duration 46 hours\nFinish Date: " + calendar.GetTaskFinishDateFromDuration(splitTask, new TimeSpan(46, 0, 0)));
            Console.WriteLine("Start Date: " + splitTask.Get(Tsk.Start).ToShortDateString() + "\n+ Duration 61 hours\nFinish Date: " + calendar.GetTaskFinishDateFromDuration(splitTask, new TimeSpan(61, 0, 0)));
            Console.WriteLine("Start Date: " + splitTask.Get(Tsk.Start).ToShortDateString() + "\n+ Duration 75 hours\nFinish Date: " + calendar.GetTaskFinishDateFromDuration(splitTask, new TimeSpan(75, 0, 0)));
            Console.WriteLine("Start Date: " + splitTask.Get(Tsk.Start).ToShortDateString() + "\n+ Duration 80 hours\nFinish Date: " + calendar.GetTaskFinishDateFromDuration(splitTask, new TimeSpan(80, 0, 0)));
            Console.WriteLine("Start Date: " + splitTask.Get(Tsk.Start).ToShortDateString() + "\n+ Duration 120 hours\nFinish Date: " + calendar.GetTaskFinishDateFromDuration(splitTask, new TimeSpan(120, 0, 0)));
            Console.WriteLine("Start Date: " + splitTask.Get(Tsk.Start).ToShortDateString() + "\n+ Duration 150 hours\nFinish Date: " + calendar.GetTaskFinishDateFromDuration(splitTask, new TimeSpan(150, 0, 0)));
            //ExEnd:CalculateSplitTaskFinishDate
        }
    }
}
