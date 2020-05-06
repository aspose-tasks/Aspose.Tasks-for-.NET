using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aspose.Tasks
{
    class Program
    {
        static void Main(string[] args)
        {
            string FileName = @"E:\Aspose\Aspose Vs VSTO\Aspose.Tasks VS VSTO Projects\Sample Files\MyProject.mpp";

            Project MyProject = new Project(FileName);

            Task MyTask = MyProject.RootTask;
            // Stop a Task
            DateTime StoppedDate = MyTask.Stop;
            // Resume a Task
            DateTime ResumeDate = MyTask.Resume;
        }
    }
}
