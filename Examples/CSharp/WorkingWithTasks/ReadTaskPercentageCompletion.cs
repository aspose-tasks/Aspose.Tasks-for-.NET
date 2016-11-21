using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Aspose.Tasks.Examples.CSharp.WorkingWithTasks
{
    class ReadTaskPercentageCompletion
    {
        public static void Run()
        {
            // ExStart:ReadTaskPercentageCompletion
            // Create project instance
            string dataDir = RunExamples.GetDataDir(System.Reflection.MethodBase.GetCurrentMethod().DeclaringType.FullName);
            Project project1 = new Project(dataDir + "TaskPercentageCompletion.mpp");

            // Access tasks and display percentage completion
            var tasks = project1.RootTask.Children;
            foreach (Task tsk1 in tasks)
            {
                Console.WriteLine(tsk1.Get(Tsk.PercentComplete));
                Console.WriteLine(tsk1.Get(Tsk.PercentWorkComplete).ToString());
                Console.WriteLine(tsk1.Get(Tsk.PhysicalPercentComplete).ToString());
            }
            // ExEnd:ReadTaskPercentageCompletion
        }
    }
}
