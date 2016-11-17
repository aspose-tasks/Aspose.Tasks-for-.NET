using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Aspose.Tasks.Examples.CSharp.WorkingWithResourceAssignments
{
    class GetResourceAssignmentBudget
    {
        public static void Run()
        {
            // The path to the documents directory.
            string dataDir = RunExamples.GetDataDir(System.Reflection.MethodBase.GetCurrentMethod().DeclaringType.FullName);

            // ExStart:GetResourceAssignmentBudget
            // Create project instance
            Project project1 = new Project(dataDir + "ResourceAssignmentBudget.mpp");

            // Print assignment budget cost and budget work
            foreach (ResourceAssignment ra in project1.ResourceAssignments)
            {
                Console.WriteLine(ra.Get(Asn.BudgetCost));
                Console.WriteLine(ra.Get(Asn.BudgetWork).ToString());
            }
            // ExEnd:GetResourceAssignmentBudget
        }
    }
}
