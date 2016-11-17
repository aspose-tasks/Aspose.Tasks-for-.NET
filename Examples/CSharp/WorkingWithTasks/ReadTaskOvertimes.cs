using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;

namespace Aspose.Tasks.Examples.CSharp.WorkingWithTasks
{
    class ReadTaskOvertimes
    {
        public static void Run()
        {
            // ExStart:ReadTaskOvertimes
            // Read project from file stream
            string dataDir = RunExamples.GetDataDir(System.Reflection.MethodBase.GetCurrentMethod().DeclaringType.FullName);
            FileStream fs = new FileStream(dataDir + "TaskOvertimes.mpp", FileMode.Open);
            Project project1 = new Project(fs);
            fs.Close();

            // Read overtime and percentage completion for tasks
            foreach (Task tsk1 in project1.RootTask.Children)
            {
                Console.WriteLine(tsk1.Get(Tsk.OvertimeCost));
                Console.WriteLine(tsk1.Get(Tsk.OvertimeWork).ToString());
                Console.WriteLine(tsk1.Get(Tsk.PercentComplete));
                Console.WriteLine(tsk1.Get(Tsk.PercentWorkComplete).ToString());
                Console.WriteLine(tsk1.Get(Tsk.PhysicalPercentComplete).ToString());

                // Set percent complete
                tsk1.Set(Tsk.PercentComplete, 100);
            }
            // ExEnd:ReadTaskOvertimes
        }
    }
}
