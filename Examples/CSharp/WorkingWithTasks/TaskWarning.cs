namespace Aspose.Tasks.Examples.CSharp.WorkingWithTasks
{
    using System;

    internal class TaskWarning
    {
        public static void Run()
        {
            var dataDir = RunExamples.GetDataDir(System.Reflection.MethodBase.GetCurrentMethod());
            
            //ExStart:TaskWarning
            //ExFor: Tsk.Warning
            //ExSummary: Shows how to read a task warning.
            var project = new Project(dataDir + "schedule-conflict.mpp");
            var task = project.RootTask.Children.GetById(1);
            Console.WriteLine(task.Get(Tsk.Warning));
            //ExEnd:TaskWarning
        }
    }
}
