namespace Aspose.Tasks.Examples.CSharp.WorkingWithProjects.Rescheduling
{
    using System;

    internal class ProjectRecalculateWithValidation
    {
        public static void Run()
        {
            //ExStart:ProjectRecalculateWithValidation
            //ExFor: Project.Recalculate(Boolean)
            //ExSummary: Shows how to recalculate the project with post validation.
            var project = new Project();
            var task = project.RootTask.Children.Add("t1");
            task.Set(Tsk.CommitmentStart, new DateTime(2017, 6, 19, 8, 0, 0));
            task.Set(Tsk.CommitmentFinish, new DateTime(2017, 6, 18, 17, 0, 0));
            
            try
            {
                // recalculate the project with post validation
                project.Recalculate(true);
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
            //ExEnd:ProjectRecalculateWithValidation
        }
    }
}