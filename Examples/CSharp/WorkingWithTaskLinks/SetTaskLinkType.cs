namespace Aspose.Tasks.Examples.CSharp.WorkingWithTaskLinks
{
    internal class SetTaskLinkType
    {
        public static void Run()
        {
            //ExStart:SetTaskLinkType                        
            // Create new project and add tasks
            var project = new Project();
            var pred = project.RootTask.Children.Add("Task 1");
            var succ = project.RootTask.Children.Add("Task 2");

            // Link tasks with link type set to Start to Start
            var link = project.TaskLinks.Add(pred, succ);
            link.LinkType = TaskLinkType.StartToStart;
            //ExEnd:SetTaskLinkType
        }
    }
}
