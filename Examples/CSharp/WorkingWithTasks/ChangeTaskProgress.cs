using System;

namespace Aspose.Tasks.Examples.CSharp.WorkingWithTasks
{
    class ChangeTaskProgress
    {
        public static void Run()
        {
            //ExStart:ChangeTaskProgress
            Project project = new Project();
            Console.WriteLine("Project Calculation mode is Automatic: {0}", project.CalculationMode.Equals(CalculationMode.Automatic));

            Task task = project.RootTask.Children.Add("Task");
            task.Set(Tsk.Duration, project.GetDuration(2));
            task.Set(Tsk.PercentComplete, 50);
            //ExEnd:ChangeTaskProgress
        }
    }
}
