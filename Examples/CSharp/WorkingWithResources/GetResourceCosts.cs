namespace Aspose.Tasks.Examples.CSharp.WorkingWithResources
{
    using System;

    internal class GetResourceCosts
    {
        public static void Run()
        {
            var dataDir = RunExamples.GetDataDir(System.Reflection.MethodBase.GetCurrentMethod());

            //ExStart:GetResourceCosts
            //ExFor: Rsc.Cost
            //ExFor: Rsc.ACWP
            //ExFor: Rsc.BCWS
            //ExFor: Rsc.BCWP
            //ExSummary: Shows how to read resource costs.
            var project = new Project(dataDir + "ResourceCosts.mpp");

            // Display all resources costs
            foreach (var res in project.Resources)
            {
                if (res.Get(Rsc.Name) == null)
                {
                    continue;
                }

                Console.WriteLine(res.Get(Rsc.Cost));
                Console.WriteLine(res.Get(Rsc.ACWP));
                Console.WriteLine(res.Get(Rsc.BCWS));
                Console.WriteLine(res.Get(Rsc.BCWP));
            }
            //ExEnd:GetResourceCosts
        }
    }
}
