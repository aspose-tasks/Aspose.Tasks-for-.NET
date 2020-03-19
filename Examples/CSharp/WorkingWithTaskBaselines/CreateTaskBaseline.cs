namespace Aspose.Tasks.Examples.CSharp.WorkingWithTaskBaselines
{
    internal class CreateTaskBaseline
    {
        public static void Run()
        {
            //ExStart:CreateTaskBaseline
            //ExFor: Project.SetBaseline(BaselineType)
            //ExFor: Project.SetBaseline(BaselineType,IEnumerable<Task>)
            //ExSummary: Shows how to create task baselines.
            // Create project instance
            var project = new Project();

            // Creating TaskBaseline:
            var task = project.RootTask.Children.Add("Task");

            // Set baseline for specified tasks and entire project
            project.SetBaseline(BaselineType.Baseline, new[] { task });
            project.SetBaseline(BaselineType.Baseline);
            //ExEnd:CreateTaskBaseline
        }
    }
}
