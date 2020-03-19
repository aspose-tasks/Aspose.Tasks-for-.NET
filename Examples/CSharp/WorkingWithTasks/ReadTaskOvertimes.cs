namespace Aspose.Tasks.Examples.CSharp.WorkingWithTasks
{
    using System;
    using System.IO;

    internal class ReadTaskOvertimes
    {
        public static void Run()
        {
            var dataDir = RunExamples.GetDataDir(System.Reflection.MethodBase.GetCurrentMethod().DeclaringType.FullName);
            
            //ExStart:ReadTaskOvertimes
            //ExFor: Tsk.OvertimeCost
            //ExFor: Tsk.OvertimeWork
            //ExSummary: Shows how to read task overtimes.
            // Read project from file stream
            var project = new Project(dataDir + "TaskOvertimes.mpp");

            // Read overtime and percentage completion for tasks
            foreach (var task in project.RootTask.Children)
            {
                Console.WriteLine(task.Get(Tsk.OvertimeCost));
                Console.WriteLine(task.Get(Tsk.OvertimeWork));
                Console.WriteLine(task.Get(Tsk.PercentComplete));
                Console.WriteLine(task.Get(Tsk.PercentWorkComplete));
                Console.WriteLine(task.Get(Tsk.PhysicalPercentComplete));

                // Set percent complete
                task.Set(Tsk.PercentComplete, 100);
            }
            //ExEnd:ReadTaskOvertimes
        }
    }
}
