using System.Runtime.CompilerServices;

namespace Aspose.Tasks.Examples.CSharp
{
    using System;
    using NUnit.Framework;
    using Aspose.Tasks;
    using Aspose.Tasks.Saving;

    [TestFixture]
    public class ExGraphicalIndicators : ApiExampleBase
    {
        [Test]
        public static void PrintGraphicalIndicatorsInfo()
        {
            // ExStart:PrintGraphicalIndicatorsInfo
            // ExFor: GraphicalIndicatorCriteria
            // ExFor: GraphicalIndicatorCriteria.RowType
            // ExFor: GraphicalIndicatorCriteria.Test
            // ExFor: GraphicalIndicatorCriteria.Value1
            // ExFor: GraphicalIndicatorCriteria.Value2
            // ExFor: GraphicalIndicatorCriteriaValue
            // ExSummary: Shows how to retrieve calendar info.

            Project project = new Project(DataDir + "graphical_indicators.mpp");

            foreach (var ea in project.ExtendedAttributes)
            {
                if (ea.GraphicalIndicator == null)
                {
                    continue;
                }

                Console.WriteLine("GI for field '{0}':", ea.FieldName);

                foreach (var criterion in ea.GraphicalIndicator.Criteria)
                {
                    Console.WriteLine("Row type: {0}", criterion.RowType);
                    Console.WriteLine("Image index: {0}", criterion.ImageIndex);
                    Console.Write(criterion.Test);
                    if (criterion.Value1 != null)
                    {
                        Console.Write(" ");
                        Console.Write(criterion.Value1.RawValue);
                    }

                    if (criterion.Value2 != null)
                    {
                        Console.Write(" ");
                        Console.WriteLine(criterion.Value2.RawValue);
                    }

                    Console.WriteLine();
                }
            }

            // ExEnd:PrintGraphicalIndicatorsInfo
        }

        [Test]
        public static void CreateGraphicalIndicators()
        {
            // ExStart:CreateGraphicalIndicators
            // ExFor: ExtendedAttributeDefinition.GraphicalIndicator
            // ExFor: GraphicalIndicatorCriteriaType
            // ExFor: GraphicalIndicatorCriteria
            // ExFor: GraphicalIndicatorCriteriaValue
            // ExFor: GraphicalIndicatorsInfo
            // ExSummary: Shows how to retrieve calendar info.

            Project project = new Project();

            var def = ExtendedAttributeDefinition.CreateTaskDefinition(ExtendedAttributeTask.Number1, "Number field");
            project.ExtendedAttributes.Add(def);
            def.GraphicalIndicator = new GraphicalIndicatorsInfo();

            GraphicalIndicatorCriteria criteria1 = new GraphicalIndicatorCriteria(
                GraphicalIndicatorCriteriaType.SummaryRows,
                FilterComparisonType.IsLessThan,
                2,
                new GraphicalIndicatorCriteriaValue(100m));


            // 'IsWithin' criteria requires 2 values.
            GraphicalIndicatorCriteria criteria2 = new GraphicalIndicatorCriteria(
                GraphicalIndicatorCriteriaType.SummaryRows,
                FilterComparisonType.IsWithin,
                4,
                new GraphicalIndicatorCriteriaValue(101),
                new GraphicalIndicatorCriteriaValue(1000m));

            // 'IsAnyValue' criteria doesn't require values.
            GraphicalIndicatorCriteria criteria3 = new GraphicalIndicatorCriteria(
                GraphicalIndicatorCriteriaType.SummaryRows,
                FilterComparisonType.IsAnyValue,
                4,
                null);

            def.GraphicalIndicator.Criteria.Add(criteria1);
            def.GraphicalIndicator.Criteria.Add(criteria2);
            def.GraphicalIndicator.Criteria.Add(criteria3);

            def.GraphicalIndicator.ProjectSummaryInheritFromNonSummaryRows = true;
            def.GraphicalIndicator.SummaryRowsInheritFromNonSummaryRows = true;
            def.GraphicalIndicator.ShowDataValuesInTooltip = false;

            project.Save(OutDir + "CreateGraphicalIndicators_out.mpp", SaveFileFormat.Mpp);

            // ExEnd:CreateGraphicalIndicators
        }
    }
}