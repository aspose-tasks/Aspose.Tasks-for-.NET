namespace Aspose.Tasks.Examples.CSharp.WorkingWithTaskLinks
{
    using System;

    internal class WorkWithTaskLinks
    {
        public static void Run()
        {
            var dataDir = RunExamples.GetDataDir(System.Reflection.MethodBase.GetCurrentMethod());
            
            //ExStart:WorkWithTaskLinks
            //ExFor: Project.TaskLinks
            //ExFor: TaskLink.PredTask
            //ExFor: TaskLink.SuccTask
            //ExSummary: Shows how to read project task links.
            var project = new Project(dataDir + "GetPredecessorSuccessorTasks.mpp");

            // Display names of predecessor and successor tasks
            foreach (var taskLink in project.TaskLinks)
            {
                Console.WriteLine("Predecessor " + taskLink.PredTask.Get(Tsk.Name));
                Console.WriteLine("Successor " + taskLink.SuccTask.Get(Tsk.Name));
            }
            //ExEnd:WorkWithTaskLinks
        }
    }
}
