namespace Aspose.Tasks.Examples.CSharp
{
    using NUnit.Framework;

    [TestFixture]
    public class ExCostAccrualType : ApiExampleBase
    {
        [Test]
        public void WorkWithCostAccrualType()
        {
            // ExStart
            // ExFor: CostAccrualType
            // ExSummary: Shows how and when resource standard and overtime costs are to be charged, or accrued (accrual method: Determines when the cost for a resource is incurred and when actual costs are charged to a project. You can incur costs at the start [Start] or finish [End] of a task or prorate them [Prorated] during the task.), to the cost of a task (CostAccrualType.End).
            var project = new Project(DataDir + "Project2.mpp");
            var resource = project.Resources.GetById(1);
            // set cost accrual type
            // if you select the End option, costs are not accrued until remaining work is zero.
            resource.Set(Rsc.AccrueAt, CostAccrualType.End);
            // work with the project...
            // ExEnd
        }
    }
}