namespace Aspose.Tasks.Examples.CSharp.WorkingWithResources
{
    using System;

    internal class GetResourceCalendar
    {
        public static void Run()
        {
            var dataDir = RunExamples.GetDataDir(System.Reflection.MethodBase.GetCurrentMethod());

            //ExStart:GetResourceCalendar
            //ExFor: Project.Resources
            //ExSummary: Shows how to read project resources.
            var project = new Project(dataDir + "ResourceCalendar.mpp");

            // Display base calendar name for all resources
            foreach (var resource in project.Resources)
            {
                if (resource.Get(Rsc.Name) != null)
                {
                    Console.WriteLine(resource.Get(Rsc.Calendar).BaseCalendar.Name);
                }
            }
            //ExEnd:GetResourceCalendar
        }
    }
}
