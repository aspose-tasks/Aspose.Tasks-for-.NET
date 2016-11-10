using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Aspose.Tasks.Examples.CSharp.WorkingWithTaskLinks
{
    class CreateTaskLinks
    {
        public static void Run()
        {
            // ExStart:CreateTaskLinks
            // Create new project and add tasks
            Project project1 = new Project();
            Task pred = project1.RootTask.Children.Add("Task 1");
            Task succ = project1.RootTask.Children.Add("Task 2");

            // Links tasks
            TaskLink link = project1.TaskLinks.Add(pred, succ);
            // ExEnd:CreateTaskLinks
        }
    }
}
