namespace Aspose.Tasks.Examples.CSharp.WorkingWithTasks
{
    using System;

    internal class ReadTaskPercentageCompletion
    {
        public static void Run()
        {
            //ExStart:ReadTaskPercentageCompletion
            // Create project instance
            var dataDir = RunExamples.GetDataDir(System.Reflection.MethodBase.GetCurrentMethod().DeclaringType.FullName);
            var project = new Project(dataDir + "TaskPercentageCompletion.mpp");

            // Access tasks and display percentage completion
            var tasks = project.RootTask.Children;
            foreach (var tsk1 in tasks)
            {
                Console.WriteLine(tsk1.Get(Tsk.PercentComplete));
                Console.WriteLine(tsk1.Get(Tsk.PercentWorkComplete).ToString());
                Console.WriteLine(tsk1.Get(Tsk.PhysicalPercentComplete).ToString());
            }
            //ExEnd:ReadTaskPercentageCompletion
        }
    }
}
