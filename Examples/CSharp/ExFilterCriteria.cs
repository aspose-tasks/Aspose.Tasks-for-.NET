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
            //ExStart:ReadFilterCriteriaData
            //ExFor: FilterCriteria.Test
            //ExFor: FilterCriteria.Field
            //ExFor: FilterCriteria.Values
            //ExSummary: Shows how to read task filter criteria.
            var project = new Project(DataDir + "Project2003.mpp");

            var filter = project.TaskFilters.ToList()[1];
            Console.WriteLine(filter.Criteria.CriteriaRows.Count);
            Console.WriteLine(filter.Criteria.Operation.ToString());
            
            var criteria1 = filter.Criteria.CriteriaRows[0];
            Console.WriteLine(criteria1.Test.ToString());
            Console.WriteLine(criteria1.Field.ToString());
            Console.WriteLine(criteria1.Values[0].ToString());            
            
            var criteria2 = filter.Criteria.CriteriaRows[1];
            Console.WriteLine(criteria2.Operation.ToString());
            Console.WriteLine(criteria2.CriteriaRows.Count);            
            
            var criteria21 = criteria2.CriteriaRows[0];
            Console.WriteLine(criteria21.Test.ToString());
            Console.WriteLine(criteria21.Field.ToString());
            Console.WriteLine(criteria21.Values[0].ToString());            
            
            var criteria22 = criteria2.CriteriaRows[1];
            Console.WriteLine(criteria22.Test.ToString());
            Console.WriteLine(criteria22.Field.ToString());
            Console.WriteLine(criteria22.Values[0].ToString());            
            Console.WriteLine(filter.Criteria);
            //ExEnd:ReadFilterCriteriaData
        }
    }
}