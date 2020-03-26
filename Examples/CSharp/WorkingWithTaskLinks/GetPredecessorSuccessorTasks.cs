namespace Aspose.Tasks.Examples.CSharp.WorkingWithTaskLinks
{
    using System;

    internal class GetPredecessorSuccessorTasks
    {
        public static void Run()
        {
            var dataDir = RunExamples.GetDataDir(System.Reflection.MethodBase.GetCurrentMethod());
            
            //ExStart:GetPredecessorSuccessorTasks
            //ExFor: TaskLink.PredTask
            //ExFor: TaskLink.SuccTask
            //ExSummary: Shows how to read predecessor/successor by task links.
            var project = new Project(dataDir + "GetPredecessorSuccessorTasks.mpp");

            // Display names of predecessor and successor tasks
            foreach (var taskLink in project.TaskLinks)
            {
                Console.WriteLine("Predecessor " + taskLink.PredTask.Get(Tsk.Name));
                Console.WriteLine("Successor " + taskLink.SuccTask.Get(Tsk.Name));
            }
            //ExEnd:GetPredecessorSuccessorTasks
        }
    }
}
