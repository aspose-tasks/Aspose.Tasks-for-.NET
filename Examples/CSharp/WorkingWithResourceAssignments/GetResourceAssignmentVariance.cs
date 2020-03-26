namespace Aspose.Tasks.Examples.CSharp.WorkingWithResourceAssignments
{
    using System;

    internal class GetResourceAssignmentVariance
    {
        public static void Run()
        {
            var dataDir = RunExamples.GetDataDir(System.Reflection.MethodBase.GetCurrentMethod());

            //ExStart:GetResourceAssignmentVariance
            //ExFor: Asn.WorkVariance
            //ExFor: Asn.CostVariance
            //ExFor: Asn.StartVariance
            //ExFor: Asn.FinishVariance
            //ExSummary: Shows how to read assignment's variances.
            var project = new Project(dataDir + "ResourceAssignmentVariance.mpp");

            // Print assignment variances
            foreach (var ra in project.ResourceAssignments)
            {
                Console.WriteLine(ra.Get(Asn.WorkVariance));
                Console.WriteLine(ra.Get(Asn.CostVariance));
                Console.WriteLine(ra.Get(Asn.StartVariance));
                Console.WriteLine(ra.Get(Asn.FinishVariance));
            }
            //ExEnd:GetResourceAssignmentVariance
        }
    }
}
