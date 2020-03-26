namespace Aspose.Tasks.Examples.CSharp.Miscellaneous
{
    using System;

    public class WorkWithDurations
    {
        public static void Run()
        {
            {
                //ExStart:GetDefaultDurationFromProject
                //ExFor: Project.GetDuration(Double)
                //ExSummary: Shows how to create a <see cref="Aspose.Tasks.Duration" /> instance with default project's duration format by using project fabric methods.
                var project = new Project();

                // get a duration with default project format.
                var duration = project.GetDuration(1);

                Console.WriteLine("Default project duration time unit type: " + project.Get(Prj.DurationFormat));
                Console.WriteLine("Created duration time unit type: " + duration.TimeUnit);
                //ExEnd:GetDefaultDurationFromProject
            }
            
            {
                //ExStart:GetDurationFromProject
                //ExFor: Project.GetDuration(Double,TimeUnitType)
                //ExSummary: Shows how to create a <see cref="Aspose.Tasks.Duration" /> instance by using project fabric methods.
                var project = new Project();

                // get a duration with default project format.
                var duration = project.GetDuration(1, TimeUnitType.Minute);

                Console.WriteLine("Created duration: " + duration);
                //ExEnd:GetDurationFromProject
            }
        }
    }
}