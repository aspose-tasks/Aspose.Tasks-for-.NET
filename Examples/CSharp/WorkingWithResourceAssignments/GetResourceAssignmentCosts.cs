namespace Aspose.Tasks.Examples.CSharp.WorkingWithResourceAssignments
{
    using System;

    internal class GetResourceAssignmentCosts
    {
        public static void Run()
        {
            var dataDir = RunExamples.GetDataDir(System.Reflection.MethodBase.GetCurrentMethod());

            //ExStart:GetResourceAssignmentCosts
            //ExFor: Asn.Cost
            //ExFor: Asn.ACWP
            //ExFor: Asn.BCWP
            //ExFor: Asn.BCWS
            //ExSummary: Shows how to read assignment's costs.
            var project = new Project(dataDir + "ResourceAssignmentCosts.mpp");

            // Print resource assignment costs
            foreach (var ra in project.ResourceAssignments)
            {
                Console.WriteLine(ra.Get(Asn.Cost));
                Console.WriteLine(ra.Get(Asn.ACWP));
                Console.WriteLine(ra.Get(Asn.BCWP));
                Console.WriteLine(ra.Get(Asn.BCWS));
            }
            //ExEnd:GetResourceAssignmentCosts
        }
    }
}
