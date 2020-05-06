namespace Aspose.Tasks.Examples.CSharp
{
    using NUnit.Framework;

    [TestFixture]
    public class ExCostAccrualType : ApiExampleBase
    {
        [Test]
        public void WorkWithCostAccrualType()
        {
            {
                // ExStart
                // ExFor: CostAccrualType
                // ExFor: CostAccrualType.End
                // ExSummary: Shows how and when resource standard and overtime costs are to be charged, or accrued (accrual method: Determines when the cost for a resource is incurred and when actual costs are charged to a project. You can incur costs at the start [Start] or finish [End] of a task or prorate them [Prorated] during the task.), to the cost of a task (CostAccrualType.End).
                var project = new Project(DataDir + "Project2.mpp");
                var resource = project.Resources.GetById(1);
                // set cost accrual type
                // if you select the End option, costs are not accrued until remaining work is zero.
                resource.Set(Rsc.AccrueAt, CostAccrualType.End);
                // work with the project...
                // ExEnd
            }
            
            {
                // ExStart
                // ExFor: CostAccrualType.Start
                // ExSummary: Shows how and when resource standard and overtime costs are to be charged, or accrued (accrual method: Determines when the cost for a resource is incurred and when actual costs are charged to a project. You can incur costs at the start [Start] or finish [End] of a task or prorate them [Prorated] during the task.), to the cost of a task (CostAccrualType.Start).
                var project = new Project(DataDir + "Project2.mpp");
                var resource = project.Resources.GetById(1);
                // set cost accrual type
                // if you select the Start option, costs are accrued as soon as a task starts, as indicated by a date entered in the Actual Start field.
                resource.Set(Rsc.AccrueAt, CostAccrualType.Start);
                // work with the project...
                // ExEnd
            }
            
            {
                // ExStart
                // ExFor: CostAccrualType.Prorated
                // ExSummary: Shows how and when resource standard and overtime costs are to be charged, or accrued (accrual method: Determines when the cost for a resource is incurred and when actual costs are charged to a project. You can incur costs at the start [Start] or finish [End] of a task or prorate them [Prorated] during the task.), to the cost of a task (CostAccrualType.Prorated).
                var project = new Project(DataDir + "Project2.mpp");
                var resource = project.Resources.GetById(1);
                // set cost accrual type
                // if you select the Prorated option, the costs accrue as work is scheduled to occur and as actual work is reported, and are calculated by multiplying unit costs by work.
                resource.Set(Rsc.AccrueAt, CostAccrualType.Prorated);
                // work with the project...
                // ExEnd
            }
            
            {
                // ExStart
                // ExFor: CostAccrualType.Invalid
                // ExSummary: Shows how and when resource standard and overtime costs are to be charged, or accrued (accrual method: Determines when the cost for a resource is incurred and when actual costs are charged to a project. You can incur costs at the start [Start] or finish [End] of a task or prorate them [Prorated] during the task.), to the cost of a task (CostAccrualType.Invalid).
                var project = new Project(DataDir + "Project2.mpp");
                var resource = project.Resources.GetById(1);
                // set cost accrual type
                resource.Set(Rsc.AccrueAt, CostAccrualType.Invalid);
                // work with the project...
                // ExEnd
            }
            
            {
                // ExStart
                // ExFor: CostAccrualType.Undefined
                // ExSummary: Shows how and when resource standard and overtime costs are to be charged, or accrued (accrual method: Determines when the cost for a resource is incurred and when actual costs are charged to a project. You can incur costs at the start [Start] or finish [End] of a task or prorate them [Prorated] during the task.), to the cost of a task (CostAccrualType.Undefined).
                var project = new Project(DataDir + "Project2.mpp");
                var resource = project.Resources.GetById(1);
                // set cost accrual type
                resource.Set(Rsc.AccrueAt, CostAccrualType.Undefined);
                // work with the project...
                // ExEnd
            }
        }
    }
}