namespace Aspose.Tasks.Examples.CSharp.WorkingWithResourceAssignments
{
    using System;

    internal class GetResourceAssignmentBudget
    {
        public static void Run()
        {
            var dataDir = RunExamples.GetDataDir(System.Reflection.MethodBase.GetCurrentMethod());

            //ExStart:GetResourceAssignmentBudget
            //ExFor: Asn.BudgetWork
            //ExFor: Asn.BudgetCost
            //ExSummary: Shows how to read assignment's budget values.
            var project = new Project(dataDir + "ResourceAssignmentBudget.mpp");

            // Print assignment budget cost and budget work
            foreach (var ra in project.ResourceAssignments)
            {
                Console.WriteLine(ra.Get(Asn.BudgetWork).ToString());
                Console.WriteLine(ra.Get(Asn.BudgetCost));
            }
            //ExEnd:GetResourceAssignmentBudget
        }
    }
}
