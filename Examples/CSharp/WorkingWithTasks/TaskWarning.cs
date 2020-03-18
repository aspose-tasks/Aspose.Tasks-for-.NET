namespace Aspose.Tasks.Examples.CSharp.WorkingWithTasks
{
    using System;

    internal class TaskWarning
    {
        public static void Run()
        {
            //ExStart:TaskWarning
            // Create project instance
            var dataDir = RunExamples.GetDataDir(System.Reflection.MethodBase.GetCurrentMethod().DeclaringType.FullName);
            
            var project = new Project(dataDir + "schedule-conflict.mpp");
            var task = project.RootTask.Children.GetById(1);
            Console.WriteLine(task.Get(Tsk.Warning));
            //ExEnd:TaskWarning
        }
    }
}
