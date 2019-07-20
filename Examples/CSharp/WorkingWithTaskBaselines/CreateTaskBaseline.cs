using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Aspose.Tasks.Examples.CSharp.WorkingWithTaskBaselines
{
    class CreateTaskBaseline
    {
        public static void Run()
        {
            // ExStart:CreateTaskBaseline
            // Create project instance
            Project project1 = new Project();

            // Creating TaskBaseline:
            Task task = project1.RootTask.Children.Add("Task");

            // Set baseline for specified tasks and entire project
            project1.SetBaseline(BaselineType.Baseline, new Task[] { task });
            project1.SetBaseline(BaselineType.Baseline);
            // ExEnd:CreateTaskBaseline
        }
    }
}
