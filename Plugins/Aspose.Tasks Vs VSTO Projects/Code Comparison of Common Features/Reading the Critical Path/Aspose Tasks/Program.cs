using Aspose.Tasks;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aspose_Tasks
{
    class Program
    {
        static void Main(string[] args)
        {
            //Open project file
            string fileName = "Project.mpp";
            ProjectReader reader = new ProjectReader();
            Project project = reader.Read(fileName);

            // Get the critical path
            ArrayList criticalPath = new ArrayList(project.GetCriticalPath());

            // Enumerate the tasks in the critical path
            foreach (Aspose.Tasks.Task task in criticalPath)
            {
                Console.WriteLine(task.Id + "  " + task.Name);
                Console.WriteLine(task.Start);
                Console.WriteLine(task.Finish + "\n");
            }
        }
    }
}
