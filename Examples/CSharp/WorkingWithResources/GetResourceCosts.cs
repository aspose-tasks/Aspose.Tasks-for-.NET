using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Aspose.Tasks.Examples.CSharp.WorkingWithResources
{
    class GetResourceCosts
    {
        public static void Run()
        {
            // The path to the documents directory.
            string dataDir = RunExamples.GetDataDir(System.Reflection.MethodBase.GetCurrentMethod().DeclaringType.FullName);

            // ExStart:GetResourceCosts
            // Create project instance
            Project project1 = new Project(dataDir + "ResourceCosts.mpp");

            // Display all resources costs
            foreach (Resource res in project1.Resources)
            {
                if (res.Get(Rsc.Name) != null)
                {
                    Console.WriteLine(res.Get(Rsc.Cost));
                    Console.WriteLine(res.Get(Rsc.ACWP));
                    Console.WriteLine(res.Get(Rsc.BCWS));
                    Console.WriteLine(res.Get(Rsc.BCWP));
                }
            }
            // ExEnd:GetResourceCosts
        }
    }
}
