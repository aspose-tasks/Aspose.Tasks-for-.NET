using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Aspose.Tasks.Examples.CSharp.WorkingWithTaskLinks
{
    class GetPredecessorSuccessorTasks
    {
        public static void Run()
        {
            // ExStart:GetPredecessorSuccessorTasks
            // Create project instance
            string dataDir = RunExamples.GetDataDir(System.Reflection.MethodBase.GetCurrentMethod().DeclaringType);
            Project project1 = new Project(dataDir + "project.mpp");

            // Display names of predecessor and successor tasks
            foreach (TaskLink tsklnk in project1.TaskLinks)
            {
                Console.WriteLine("Predecessor " + tsklnk.PredTask.Get(Tsk.Name));
                Console.WriteLine("Predecessor " + tsklnk.SuccTask.Get(Tsk.Name));
            }
            // ExEnd:GetPredecessorSuccessorTasks
        }
    }
}
