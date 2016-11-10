using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Aspose.Tasks.Examples.CSharp.WorkingWithTaskLinks
{
    class SetTaskLinkType
    {
        public static void Run()
        {
            // ExStart:SetTaskLinkType                        
            // Create new project and add tasks
            Project project = new Project();
            Task pred = project.RootTask.Children.Add("Task 1");
            Task succ = project.RootTask.Children.Add("Task 2");

            // Link tasks with link type set to Start to Start
            TaskLink link = project.TaskLinks.Add(pred, succ);
            link.LinkType = TaskLinkType.StartToStart;
            // ExEnd:SetTaskLinkType
        }
    }
}
