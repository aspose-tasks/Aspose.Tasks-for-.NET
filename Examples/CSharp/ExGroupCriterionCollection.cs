namespace Aspose.Tasks.Examples.CSharp
{
    using System;
    using System.Collections.Generic;
    using NUnit.Framework;

    [TestFixture]
    public class ExGroupCriterionCollection : ApiExampleBase
    {
        [Test]
        public void WorkWithGroupCriterionCollection()
        {
            //ExStart:WorkWithGroupCriterionCollection
            //ExFor: GroupCriterionCollection
            //ExFor: GroupCriterionCollection.Add(GroupCriterion)
            //ExFor: GroupCriterionCollection.Clear
            //ExFor: GroupCriterionCollection.Contains(GroupCriterion)
            //ExFor: GroupCriterionCollection.CopyTo(GroupCriterion[],Int32)
            //ExFor: GroupCriterionCollection.Count
            //ExFor: GroupCriterionCollection.GetEnumerator
            //ExFor: GroupCriterionCollection.IsReadOnly 
            //ExFor: GroupCriterionCollection.ParentGroup
            //ExFor: GroupCriterionCollection.Remove(GroupCriterion)
            //ExFor: GroupCriterionCollection.ToList
            //ExSummary: Shows how to work with a collection of group criterion.
            var project = new Project(DataDir + "ReadGroupDefinitionData.mpp");

            var group = project.TaskGroups.ToList()[0];
            
            // iterate over group criterion
            Console.WriteLine("Print group criteria of {0} group: ", group.GroupCriteria.ParentGroup.Name);
            Console.WriteLine("Group criterion count: " + group.GroupCriteria.Count);
            foreach (var criterion in group.GroupCriteria)
            {
                Console.WriteLine("Index: " + criterion.Index);
                Console.WriteLine("Field: " + criterion.Field);
                Console.WriteLine("Group On: " + criterion.GroupOn);
                Console.WriteLine();
            }
            
            group.GroupCriteria.Clear();

            if (!group.GroupCriteria.IsReadOnly)
            {
                List<GroupCriterion> groupCriteria = group.GroupCriteria.ToList();
                foreach (var criterion in groupCriteria)
                {
                    group.GroupCriteria.Remove(criterion);
                }
            }
            
            var criterionToAdd = new GroupCriterion();
            criterionToAdd.Ascending = true;
            criterionToAdd.Field = Field.TaskActive;

            if (!group.GroupCriteria.Contains(criterionToAdd))
            {
                group.GroupCriteria.Add(criterionToAdd);
            }
            
            // copy criteria to other group
            var otherGroup = project.TaskGroups.ToList()[0];
            
            var criteria = new GroupCriterion[group.GroupCriteria.Count];
            group.GroupCriteria.CopyTo(criteria, 0);
            foreach (var criterion in criteria)
            {
                otherGroup.GroupCriteria.Add(criterion);
            }
            //ExEnd:WorkWithGroupCriterionCollection
        }
    }
}