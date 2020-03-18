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
            // Create project instance
            var project = new Project(dataDir + "ResourceCalendar.mpp");

            // Display base calendar name for all resources
            foreach (var res in project.Resources)
            {
                if (res.Get(Rsc.Name) != null)
                {
                    Console.WriteLine(res.Get(Rsc.Calendar).BaseCalendar.Name);
                }
            }
            //ExEnd:GetResourceCalendar
        }
    }
}
