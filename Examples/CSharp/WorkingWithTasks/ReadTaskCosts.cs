using System;

namespace Aspose.Tasks.Examples.CSharp.WorkingWithTasks
{
    class ReadTaskCosts
    {
        public static void Run()
        {
            //ExStart:ReadTaskCosts
            // Create new project
            Project project = new Project();

            // Add task and set cost
            Task task = project.RootTask.Children.Add("Task");
            task.Set(Tsk.Cost, 800);

            // Display cost related properties of task
            Console.WriteLine(task.Get(Tsk.RemainingCost));
            Console.WriteLine(task.Get(Tsk.FixedCost));
            Console.WriteLine(task.Get(Tsk.CostVariance));
            Console.WriteLine(project.RootTask.Get(Tsk.Cost));
            Console.WriteLine(project.RootTask.Get(Tsk.FixedCost));
            Console.WriteLine(project.RootTask.Get(Tsk.RemainingCost));
            Console.WriteLine(project.RootTask.Get(Tsk.CostVariance));
            //ExEnd:ReadTaskCosts
        }
    }
}
