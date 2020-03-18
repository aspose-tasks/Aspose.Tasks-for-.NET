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
            // Read project from file stream
            var project = new Project(new FileStream(dataDir + "TaskOvertimes.mpp", FileMode.Open));

            // Read overtime and percentage completion for tasks
            foreach (var tsk1 in project.RootTask.Children)
            {
                Console.WriteLine(tsk1.Get(Tsk.OvertimeCost));
                Console.WriteLine(tsk1.Get(Tsk.OvertimeWork).ToString());
                Console.WriteLine(tsk1.Get(Tsk.PercentComplete));
                Console.WriteLine(tsk1.Get(Tsk.PercentWorkComplete).ToString());
                Console.WriteLine(tsk1.Get(Tsk.PhysicalPercentComplete).ToString());

                // Set percent complete
                tsk1.Set(Tsk.PercentComplete, 100);
            }
            //ExEnd:ReadTaskOvertimes
        }
    }
}
