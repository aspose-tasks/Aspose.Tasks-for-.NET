namespace Aspose.Tasks.Examples.CSharp.WorkingWithTasks
{
    using System;

    internal class ReadTaskPercentageCompletion
    {
        public static void Run()
        {
            var dataDir = RunExamples.GetDataDir(System.Reflection.MethodBase.GetCurrentMethod());
            
            //ExStart:ReadTaskPercentageCompletion
            //ExFor: Tsk.PercentComplete
            //ExFor: Tsk.PercentWorkComplete
            //ExFor: Tsk.PhysicalPercentComplete
            //ExSummary: Shows how to read task's percentages.
            var project = new Project(dataDir + "TaskPercentageCompletion.mpp");

            // Access tasks and display percentage completion
            var tasks = project.RootTask.Children;
            foreach (var task in tasks)
            {
                Console.WriteLine(task.Get(Tsk.PercentComplete));
                Console.WriteLine(task.Get(Tsk.PercentWorkComplete));
                Console.WriteLine(task.Get(Tsk.PhysicalPercentComplete));
            }
            //ExEnd:ReadTaskPercentageCompletion
        }
    }
}
