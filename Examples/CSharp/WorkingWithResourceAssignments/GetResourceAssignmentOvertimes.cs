namespace Aspose.Tasks.Examples.CSharp.WorkingWithResourceAssignments
{
    using System;

    internal class GetResourceAssignmentOvertimes
    {
        public static void Run()
        {
            // The path to the documents directory.
            var dataDir = RunExamples.GetDataDir(System.Reflection.MethodBase.GetCurrentMethod().DeclaringType.FullName);

            //ExStart:GetResourceAssignmentOvertimes
            //ExFor: Asn.OvertimeWork
            //ExFor: Asn.OvertimeCost
            //ExFor: Asn.RemainingWork
            //ExFor: Asn.RemainingCost
            //ExFor: Asn.RemainingOvertimeWork
            //ExFor: Asn.RemainingOvertimeCost
            //ExSummary: Shows how to read overtime/remaining works/costs of an assignment.
            // Create project instance
            var project = new Project(dataDir + "ResourceAssignmentOvertimes.mpp");

            // Print assignment overtimes
            foreach (var ra in project.ResourceAssignments)
            {
                Console.WriteLine(ra.Get(Asn.OvertimeWork).ToString());
                Console.WriteLine(ra.Get(Asn.OvertimeCost));
                Console.WriteLine(ra.Get(Asn.RemainingWork).ToString());
                Console.WriteLine(ra.Get(Asn.RemainingCost));
                Console.WriteLine(ra.Get(Asn.RemainingOvertimeWork).ToString());
                Console.WriteLine(ra.Get(Asn.RemainingOvertimeCost));
            }
            //ExEnd:GetResourceAssignmentOvertimes
        }
    }
}
