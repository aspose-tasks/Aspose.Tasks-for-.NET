namespace Aspose.Tasks.Examples.CSharp.KnowledgeBase
{
    using System;

    internal class ReadCriticalPath
    {
        public static void Run()
        {
            var dataDir = RunExamples.GetDataDir(System.Reflection.MethodBase.GetCurrentMethod());

            //ExStart:ReadCriticalPath
            //ExFor: Project.CriticalPath
            //ExSummary: Shows how to read the critical path.
            var project = new Project(dataDir + "Project1.mpp");

            // Get the critical path
            var criticalPath = project.CriticalPath;

            // Enumerate the tasks in the critical path
            foreach (var task in criticalPath)
            {
                Console.WriteLine(task.Get(Tsk.Id) + "  " + task.Get(Tsk.Name));
                Console.WriteLine(task.Get(Tsk.Start));
                Console.WriteLine(task.Get(Tsk.Finish) + "\n");
            }
            //ExEnd:ReadCriticalPath
        }
    }
}
