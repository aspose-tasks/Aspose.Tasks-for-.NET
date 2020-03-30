namespace Aspose.Tasks.Examples.CSharp.WorkingWithTaskLinks
{
    using System;

    internal class WorkWithPredecessors
    {
        public static void Run()
        {
            var dataDir = RunExamples.GetDataDir(System.Reflection.MethodBase.GetCurrentMethod());
            
            //ExStart:WorkWithPredecessors
            //ExFor: Project.GetPredecessors(Task)
            //ExSummary: Shows how to get predecessors for the specific task.
            var project = new Project(dataDir + "GetPredecessorSuccessorTasks.mpp");
            var task = project.RootTask.Children.GetById(10);

            var predecessors = project.GetPredecessors(task);
            
            // Display names of predecessor and successor tasks
            foreach (var predecessor in predecessors)
            {
                Console.WriteLine("Predecessor " + predecessor.PredTask.Get(Tsk.Name));
                Console.WriteLine("Successor " + predecessor.SuccTask.Get(Tsk.Name));
            }
            //ExEnd:WorkWithPredecessors
        }
    }
}