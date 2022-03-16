namespace Aspose.Tasks.Examples.CSharp
{
    using System;
    using System.Collections.Generic;
    using NUnit.Framework;

    [TestFixture]
    public class ExGroupCriterion : ApiExampleBase
    {
        [Test]
        public void WorkWithGroupCriterion()
        {
            // ExStart:WorkWithGroupCriterion
            // ExFor: GroupCriterion
            // ExFor: GroupCriterion.Index
            // ExFor: GroupCriterion.Font
            // ExFor: GroupCriterion.Ascending
            // ExFor: GroupCriterion.CellColor
            // ExFor: GroupCriterion.Field
            // ExFor: GroupCriterion.FontColor
            // ExFor: GroupCriterion.GroupInterval
            // ExFor: GroupCriterion.GroupOn
            // ExFor: GroupCriterion.ParentGroup
            // ExFor: GroupCriterion.Pattern
            // ExFor: GroupCriterion.StartAt
            // ExFor: GroupOn
            // ExSummary: Shows how to work with a group criterion.
            var project = new Project(DataDir + "ReadGroupDefinitionData.mpp");

            Console.WriteLine("Task Groups Count: " + project.TaskGroups.Count);
            var group = project.TaskGroups.ToList()[1];
            Console.WriteLine("Task Group Name: " + group.Name);
            Console.WriteLine("Task Group Criteria count: " + group.GroupCriteria.Count);

            Console.WriteLine("\n************* Retrieving Task Group's Criterion information *************");
            var criterion = group.GroupCriteria.ToList()[0];
            Console.WriteLine("Task Criterion Index: " + criterion.Index);
            Console.WriteLine("Task Criterion Field: " + criterion.Field);
            Console.WriteLine("Task Criterion GroupOn: " + criterion.GroupOn);
            Console.WriteLine("Task Criterion Cell Color: " + criterion.CellColor);
            Console.WriteLine("Task Criterion Font Color: " + criterion.FontColor);
            Console.WriteLine("Task Criterion Group Interval: " + criterion.GroupInterval);
            Console.WriteLine("Task Criterion Start At: " + criterion.StartAt);

            // read the background pattern of the criterion  
            Console.WriteLine("Task Criterion Pattern: " + criterion.Pattern);

            if (group == criterion.ParentGroup)
            {
                Console.WriteLine("Parent Group is equal to task Group.");
            }

            Console.WriteLine("\n*********** Retrieving Criterion's Font Information ***********");
            Console.WriteLine("Font Name: " + criterion.Font.FontFamily);
            Console.WriteLine("Font Size: " + criterion.Font.Size);
            Console.WriteLine("Font Style: " + criterion.Font.Style);
            Console.WriteLine("Ascending/Descending: " + criterion.Ascending);

            // ExEnd:WorkWithGroupCriterion
        }

        [Test]
        public void GroupCriterionHashCode()
        {
            // ExStart
            // ExFor: GroupCriterion.GetHashCode
            // ExSummary: Shows how to use hash code of a group criterion.
            var project = new Project(DataDir + "ReadGroupDefinitionData.mpp");
            var group = project.TaskGroups.ToList()[1];
            
            // get the first group criteria
            var criterion = group.GroupCriteria.ToList()[0];
            
            // each GroupCriterion has internal GUID which hash code is based on
            Console.WriteLine("Task Criterion HashCode: " + criterion.GetHashCode());

            // work with group criteria...
            // ExEnd
        }
        
        [Test]
        public void GroupCriterionEquals()
        {
            // ExStart
            // ExFor: GroupCriterion.Equals(Object)
            // ExSummary: Shows how to check equality of group criteria.
            var project = new Project(DataDir + "ReadGroupDefinitionData.mpp");
            var group = project.TaskGroups.ToList()[1];

            // get the first group criteria
            List<GroupCriterion> groupCriteria = group.GroupCriteria.ToList();
            var criterion1 = groupCriteria[0];
            var criterion2 = groupCriteria[0];

            // group criteria equality is based on public member 'Field'  
            Console.WriteLine("Task Criterion 1 Field: " + criterion1.Field);
            Console.WriteLine("Task Criterion 2 Field: " + criterion2.Field);
            Console.WriteLine("Are the criteria equal: " + criterion1.Equals(criterion2));

            // ExEnd
        }
    }
}