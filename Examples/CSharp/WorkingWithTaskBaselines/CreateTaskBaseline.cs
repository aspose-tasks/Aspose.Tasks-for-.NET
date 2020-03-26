namespace Aspose.Tasks.Examples.CSharp.WorkingWithTaskBaselines
{
    internal class CreateTaskBaseline
    {
        public static void Run()
        {
            {
                //ExStart:CreateTaskBaselineForTasks
                //ExFor: Project.SetBaseline(BaselineType,IEnumerable{Aspose.Tasks.Task})
                //ExSummary: Shows how to create set baselines for specific tasks.
                var project = new Project();

                // Adding tasks
                var task = project.RootTask.Children.Add("Task");
                var task2 = project.RootTask.Children.Add("Task2");

                // Set baseline for specified tasks
                project.SetBaseline(BaselineType.Baseline, new[] { task, task2 });
                //ExEnd:CreateTaskBaselineForTasks
            }

            {
                //ExStart:CreateTaskBaseline
                //ExFor: Project.SetBaseline(BaselineType)
                //ExSummary: Shows how to create baselines for a whole project.
                var project = new Project();

                // Adding tasks
                project.RootTask.Children.Add("Task");
                project.RootTask.Children.Add("Task2");

                // Set baseline for specified tasks
                project.SetBaseline(BaselineType.Baseline);
                //ExEnd:CreateTaskBaseline
            }
        }
    }
}
