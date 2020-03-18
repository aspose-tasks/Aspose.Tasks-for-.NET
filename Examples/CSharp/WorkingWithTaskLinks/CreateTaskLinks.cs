namespace Aspose.Tasks.Examples.CSharp.WorkingWithTaskLinks
{
    internal class CreateTaskLinks
    {
        public static void Run()
        {
            //ExStart:CreateTaskLinks
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
