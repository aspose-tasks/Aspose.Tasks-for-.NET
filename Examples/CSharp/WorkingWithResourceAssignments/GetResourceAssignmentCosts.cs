using System;

namespace Aspose.Tasks.Examples.CSharp.WorkingWithResourceAssignments
{
    class GetResourceAssignmentCosts
    {
        public static void Run()
        {
            // The path to the documents directory.
            string dataDir = RunExamples.GetDataDir(System.Reflection.MethodBase.GetCurrentMethod().DeclaringType.FullName);

            //ExStart:GetResourceAssignmentCosts
            // Create project instance
            Project project1 = new Project(dataDir + "ResourceAssignmentCosts.mpp");

            // Print resource assignment costs
            foreach (ResourceAssignment ra in project1.ResourceAssignments)
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
