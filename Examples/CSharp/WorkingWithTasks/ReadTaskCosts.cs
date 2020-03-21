namespace Aspose.Tasks.Examples.CSharp.WorkingWithTasks
{
    using System;

    internal class ReadTaskCosts
    {
        public static void Run()
        {
            //ExStart:ReadTaskCosts
            //ExFor: Tsk.Cost
            //ExFor: Tsk.RemainingCost
            //ExFor: Tsk.FixedCost
            //ExFor: Tsk.CostVariance
            //ExSummary: Shows how to read task costs.
            // Create new project
            var project = new Project();

            // Add task and set cost
            var task = project.RootTask.Children.Add("Task");
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
