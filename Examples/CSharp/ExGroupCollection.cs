namespace Aspose.Tasks.Examples.CSharp
{
    using System;
    using NUnit.Framework;

    [TestFixture]
    public class ExGroupCollection : ApiExampleBase
    {
        [Test]
        public void ReadTaskGroupDefinitionData()
        {
            //ExStart:ReadTaskGroupDefinitionData
            //ExFor: GroupCollection
            //ExSummary: Shows how to work wit collection of groups.
            var project = new Project(DataDir + "ReadGroupDefinitionData.mpp");

            Console.WriteLine("Task Groups Count: " + project.TaskGroups.Count);
            var taskGroup = project.TaskGroups.ToList()[1];
            Console.WriteLine("Task Group Name: " + taskGroup.Name);
            Console.WriteLine("Task Group Criteria count: " + taskGroup.GroupCriteria.Count);
            Console.WriteLine("\n************* Retrieving Task Group's Criterion information *************");
            var taskCriterion = taskGroup.GroupCriteria.ToList()[0];
            Console.WriteLine("Task Criterion Field: " + taskCriterion.Field);
            Console.WriteLine("Task Criterion GroupOn: " + taskCriterion.GroupOn);
            Console.WriteLine("Task Criterion Cell Color: " + taskCriterion.CellColor);
            Console.WriteLine("Task Criterion Pattern: " + taskCriterion.Pattern);

            if (taskGroup == taskCriterion.ParentGroup)
            {
                Console.WriteLine("Parent Group is equal to task Group.");
            }

            Console.WriteLine("\n*********** Retrieving Criterion's Font Information ***********");
            Console.WriteLine("Font Name: " + taskCriterion.Font.Name);
            Console.WriteLine("Font Size: " + taskCriterion.Font.Size);
            Console.WriteLine("Font Style: " + taskCriterion.Font.Style);
            Console.WriteLine("Ascending/Descending: " + taskCriterion.Ascending);
            //ExEnd:ReadTaskGroupDefinitionData
        }
    }
}