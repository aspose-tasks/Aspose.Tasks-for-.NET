using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Aspose.Tasks.Examples.CSharp.WorkingWithResources
{
    class GetResourceCalendar
    {
        public static void Run()
        {
            // The path to the documents directory.
            string dataDir = RunExamples.GetDataDir(System.Reflection.MethodBase.GetCurrentMethod().DeclaringType.FullName);

            // ExStart:GetResourceCalendar
            // Create project instance
            Project project1 = new Project(dataDir + "ResourceCalendar.mpp");

            // Display base calendar name for all resources
            foreach (Resource res in project1.Resources)
            {
                if (res.Get(Rsc.Name) != null)
                {
                    Console.WriteLine(res.Get(Rsc.Calendar).BaseCalendar.Name);
                }
            }
            // ExEnd:GetResourceCalendar
        }
    }
}
