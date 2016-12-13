using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Aspose.Tasks.Examples.CSharp.KnowledgeBase
{
    class ReadCriticalPath
    {
        public static void Run()
        {
            string dataDir = RunExamples.GetDataDir(System.Reflection.MethodBase.GetCurrentMethod().DeclaringType.FullName);

            // ExStart:ReadCriticalPath
            // Load MPP file
            Project project = new Project(dataDir + "Project1.mpp");

            // Get the critical path
            TaskCollection criticalPath = project.CriticalPath;

            // Enumerate the tasks in the critical path
            foreach (Task task in criticalPath)
            {
                Console.WriteLine(task.Get(Tsk.Id) + "  " + task.Get(Tsk.Name));
                Console.WriteLine(task.Get(Tsk.Start));
                Console.WriteLine(task.Get(Tsk.Finish) + "\n");
            }
            // ExEnd:ReadCriticalPath
        }
    }
}
