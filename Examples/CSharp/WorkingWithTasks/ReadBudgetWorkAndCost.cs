namespace Aspose.Tasks.Examples.CSharp.WorkingWithTasks
{
    using System;

    internal class ReadBudgetWorkAndCost
    {
        public static void Run()
        {
            var dataDir = RunExamples.GetDataDir(System.Reflection.MethodBase.GetCurrentMethod());

            //ExStart:ReadBudgetWorkAndCost
            //ExFor: Tsk.BudgetWork
            //ExFor: Tsk.BudgetCost
            //ExFor: Rsc.BudgetWork
            //ExFor: Rsc.BudgetCost
            //ExFor: Asn.BudgetWork
            //ExFor: Asn.BudgetCost
            //ExSummary: Shows how to read budget work/cost values of task/resource/assignment.
            var project = new Project(dataDir + "BudgetWorkAndCost.mpp");

            // Display budget work and budget cost for project summary task
            Console.WriteLine("projSummary.BudgetWork = " + project.RootTask.Get(Tsk.BudgetWork));
            Console.WriteLine("projSummary.BudgetCost = " + project.RootTask.Get(Tsk.BudgetCost));

            // Display resource budget work
            var rsc = project.Resources.GetByUid(6);            
            Console.WriteLine("Resource BudgetWork = " + rsc.Get(Rsc.BudgetWork));

            // Display resource budget cost
            rsc = project.Resources.GetByUid(7);
            Console.WriteLine("Resource BudgetCost = " + rsc.Get(Rsc.BudgetCost));

            // Display assignment budget work and budget cost
            foreach (var assn in project.RootTask.Assignments)
            {
                if (assn.Get(Asn.Resource).Get(Rsc.Type) == ResourceType.Work)
                {
                    Console.WriteLine("Assignment BudgetWork = " + assn.Get(Asn.BudgetWork));
                }
                else
                {
                    Console.WriteLine("Assignment BudgetCost = " + assn.Get(Asn.BudgetCost));
                }
            }
            //ExEnd:ReadBudgetWorkAndCost
        }
    }
}
