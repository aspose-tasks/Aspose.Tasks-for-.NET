namespace Aspose.Tasks.Examples.CSharp
{
    using System;
    using NUnit.Framework;

    [TestFixture]
    internal class ExFilterCriteria : ApiExampleBase
    {
        [Test]
        public static void ReadFilterCriteriaData()
        {
            // ExStart:ReadFilterCriteriaData
            // ExFor: FilterCriteria
            // ExFor: FilterCriteria.Test
            // ExFor: FilterCriteria.Field
            // ExFor: FilterCriteria.Values
            // ExFor: FilterCriteria.CriteriaRows
            // ExFor: FilterCriteria.Operation
            // ExFor: FilterCriteria.ToString
            // ExFor: FilterComparisonType
            // ExFor: FilterOperation
            // ExSummary: Shows how to read task filter criteria.
            var project = new Project(DataDir + "Project2003.mpp");

            var filter = project.TaskFilters.ToList()[1];
            Console.WriteLine("Count of criteria rows: " + filter.Criteria.CriteriaRows.Count);
            foreach (var row in filter.Criteria.CriteriaRows)
            {
                Console.WriteLine("Field: " + row.Field);
                Console.WriteLine("Operation: " + row.Operation);
                Console.WriteLine("Test: " + row.Test);
            }

            // print filter criteria as a string 
            Console.WriteLine(filter.Criteria.Operation.ToString());

            var criteria1 = filter.Criteria.CriteriaRows[0];
            Console.WriteLine("Criteria filter 1:");
            Console.WriteLine(criteria1.ToString());

            var criteria2 = filter.Criteria.CriteriaRows[1];
            Console.WriteLine(criteria2.Operation.ToString());
            Console.WriteLine(criteria2.CriteriaRows.Count);
            Console.WriteLine("Criteria filter 2:");
            Console.WriteLine(criteria2.ToString());

            var criteria21 = criteria2.CriteriaRows[0];
            Console.WriteLine("Criteria filter 21:");
            Console.WriteLine(criteria21.ToString());

            var criteria22 = criteria2.CriteriaRows[1];
            Console.WriteLine("Criteria filter 22:");
            Console.WriteLine(criteria22.ToString());

            // ExEnd:ReadFilterCriteriaData
        }
    }
}