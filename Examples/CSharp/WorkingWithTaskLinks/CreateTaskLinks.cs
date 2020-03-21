namespace Aspose.Tasks.Examples.CSharp.WorkingWithTaskLinks
{
    internal class CreateTaskLinks
    {
        public static void Run()
        {
            //ExStart:CreateTaskLinks
            //ExFor: Project.TaskLinks
            //ExSummary: Shows how to create task links.
            // Create new project and add tasks
            var project = new Project();
            var pred = project.RootTask.Children.Add("Task 1");
            var succ = project.RootTask.Children.Add("Task 2");

            // Links tasks
            project.TaskLinks.Add(pred, succ);
            //ExEnd:CreateTaskLinks
        }
    }
}
