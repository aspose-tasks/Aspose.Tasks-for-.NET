namespace Aspose.Tasks.Examples.CSharp
{
    using System;
    using NUnit.Framework;

    [TestFixture]
    public class ExCalculationType : ApiExampleBase
    {
        [Test]
        public void WorkWithCalculationType()
        {
            // ExStart
            // ExFor: CalculationType
            // ExFor: ExtendedAttributeDefinition.CalculationType
            // ExFor: SummaryRowsCalculationType
            // ExFor: ExtendedAttributeDefinition.SummaryRowsCalculationType
            // ExFor: ExtendedAttributeDefinition.RollupType
            // ExFor: RollupType
            // ExSummary: Shows how to work with calculation type of an extended attribute definition.
            var project = new Project();

            var task = project.RootTask.Children.Add("Task");
            task.Set(Tsk.Start, new DateTime(2020, 4, 16, 8, 0, 0));
            task.Set(Tsk.Duration, project.GetDuration(1, TimeUnitType.Day));

            // create attribute definition with 'Formula' type where values for leaf tasks and summary tasks are calculated using formula.
            var calculation = ExtendedAttributeDefinition.CreateTaskDefinition(ExtendedAttributeTask.Date5, null);
            calculation.CalculationType = CalculationType.Formula;
            calculation.SummaryRowsCalculationType = SummaryRowsCalculationType.UseFormula;
            calculation.Formula = "[stARt]";
            project.ExtendedAttributes.Add(calculation);

            // create attribute definition where values for summary tasks are calculated using 'Average' rollup type.
            var lookup = ExtendedAttributeDefinition.CreateTaskDefinition(ExtendedAttributeTask.Cost1, null);
            lookup.SummaryRowsCalculationType = SummaryRowsCalculationType.Rollup;
            lookup.RollupType = RollupType.Average;
            project.ExtendedAttributes.Add(lookup);

            // ExEnd
        }
    }
}