using System;

namespace Aspose.Tasks.Examples.CSharp.WorkingWithTaskLinks
{
    class GetPredecessorSuccessorTasks
    {
        public static void Run()
        {
            //ExStart:GetPredecessorSuccessorTasks
            // Create project instance
            string dataDir = RunExamples.GetDataDir(System.Reflection.MethodBase.GetCurrentMethod().DeclaringType.FullName);
            Project project1 = new Project(dataDir + "GetPredecessorSuccessorTasks.mpp");

            // Display names of predecessor and successor tasks
            foreach (TaskLink taskLink in project1.TaskLinks)
            {
                Console.WriteLine("Predecessor " + taskLink.PredTask.Get(Tsk.Name));
                Console.WriteLine("Predecessor " + taskLink.SuccTask.Get(Tsk.Name));
            }
            //ExEnd:GetPredecessorSuccessorTasks
        }
    }
}
