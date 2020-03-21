namespace Aspose.Tasks.Examples.CSharp.WorkingWithResources
{
    using System;

    internal class GetResourceCalendar
    {
        public static void Run()
        {
            // The path to the documents directory.
            var dataDir = RunExamples.GetDataDir(System.Reflection.MethodBase.GetCurrentMethod().DeclaringType.FullName);

            //ExStart:GetResourceCalendar
            //ExFor: Project.Resources
            //ExSummary: Shows how to read project resources.
            // Create project instance
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
