namespace Aspose.Tasks.Examples.CSharp.WorkingWithProjects.Rescheduling
{
    using System;

    internal class ProjectRecalculateResourceStartFinish
    {
        public static void Run()
        {
            //ExStart:ProjectRecalculateResourceStartFinish
            //ExFor: Project.RecalculateResourceStartFinish
            //ExSummary: Shows how to recalculate resource start/finish dates.
            var project = new Project();
            project.CalculationMode = CalculationMode.None;
            
            var task = project.RootTask.Children.Add("Task");
            task.Set(Tsk.Start, new DateTime(2020, 3, 26, 8, 0, 0));
            task.Set(Tsk.Duration, project.GetDuration(1d, TimeUnitType.Day));
            task.Set(Tsk.Finish, new DateTime(2020, 3, 26, 17, 0, 0));

            var resource = project.Resources.Add("Res1");
            resource.Set(Rsc.Start, new DateTime(2020, 3, 26, 8, 0, 0));
            resource.Set(Rsc.Finish, new DateTime(2020, 3, 26, 17, 0, 0));

            var resourceAssignment = project.ResourceAssignments.Add(task, resource);
            resourceAssignment.Set(Asn.Start, new DateTime(2020, 3, 25, 8, 0, 0));
            resourceAssignment.Set(Asn.Finish, new DateTime(2020, 3, 27, 8, 0, 0));

            Console.WriteLine("Resource Start (before): " + resource.Get(Rsc.Start));
            Console.WriteLine("Resource Finish (before): " + resource.Get(Rsc.Finish));
            
            // Recalculates Start and Finish of resources
            project.RecalculateResourceStartFinish();
            
            Console.WriteLine("Resource Start (after): " + resource.Get(Rsc.Start));
            Console.WriteLine("Resource Finish (after): " + resource.Get(Rsc.Finish));
            //ExEnd:ProjectRecalculateResourceStartFinish
        }
    }
}