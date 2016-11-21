using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Aspose.Tasks.Examples.CSharp.WorkingWithResourceAssignments
{
    class GetResourceAssignmentOvertimes
    {
        public static void Run()
        {
            // The path to the documents directory.
            string dataDir = RunExamples.GetDataDir(System.Reflection.MethodBase.GetCurrentMethod().DeclaringType.FullName);

            // ExStart:GetResourceAssignmentOvertimes
            // Create project instance
            Project project1 = new Project(dataDir + "ResourceAssignmentOvertimes.mpp");

            // Print assignment overtimes
            foreach (ResourceAssignment ra in project1.ResourceAssignments)
            {
                Console.WriteLine(ra.Get(Asn.OvertimeCost));
                Console.WriteLine(ra.Get(Asn.OvertimeWork).ToString());
                Console.WriteLine(ra.Get(Asn.RemainingCost));
                Console.WriteLine(ra.Get(Asn.RemainingOvertimeCost));
                Console.WriteLine(ra.Get(Asn.RemainingOvertimeWork).ToString());
                Console.WriteLine(ra.Get(Asn.RemainingOvertimeWork).ToString());
            }
            // ExEnd:GetResourceAssignmentOvertimes
        }
    }
}
