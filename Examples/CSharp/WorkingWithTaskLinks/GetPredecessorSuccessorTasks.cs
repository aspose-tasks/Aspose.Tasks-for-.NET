namespace Aspose.Tasks.Examples.CSharp.WorkingWithTaskLinks
{
    using System;

    internal class GetPredecessorSuccessorTasks
    {
        public static void Run()
        {
            //ExStart:GetPredecessorSuccessorTasks
            // Create project instance
            var dataDir = RunExamples.GetDataDir(System.Reflection.MethodBase.GetCurrentMethod().DeclaringType.FullName);
            var project = new Project(dataDir + "GetPredecessorSuccessorTasks.mpp");

            // Display names of predecessor and successor tasks
            foreach (var taskLink in project.TaskLinks)
            {
                Console.WriteLine("Predecessor " + taskLink.PredTask.Get(Tsk.Name));
                Console.WriteLine("Predecessor " + taskLink.SuccTask.Get(Tsk.Name));
            }
            //ExEnd:GetPredecessorSuccessorTasks
        }
    }
}
