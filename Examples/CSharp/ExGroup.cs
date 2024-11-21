namespace Aspose.Tasks.Examples.CSharp
{
    using System;
    using Aspose.Tasks.Saving;
    using Aspose.Tasks.Visualization;
    using System.Drawing;
    using NUnit.Framework;

    [TestFixture]
    public class ExGroup : ApiExampleBase
    {
        [Test]
        public void WorkWithGroup()
        {
            // ExStart:WorkWithGroup
            // ExFor: Group
            // ExFor: Group.#ctor
            // ExFor: Group.Uid
            // ExFor: Group.Name
            // ExFor: Group.Index
            // ExFor: Group.GroupCriteria
            // ExFor: Group.MaintainHierarchy
            // ExFor: Group.ShowSummary
            // ExFor: Group.ShowInMenu
            // ExFor: Group.GroupAssignments
            // ExSummary: Shows how to work with groups.
            var project = new Project(DataDir + "ReadGroupDefinitionData.mpp");

            Console.WriteLine("Task Groups Count: " + project.TaskGroups.Count);
            var group = project.TaskGroups.ToList()[1];
            Console.WriteLine("Task Group Uid: " + group.Uid);
            Console.WriteLine("Task Group Index: " + group.Index);
            Console.WriteLine("Task Group Name: " + group.Name);
            Console.WriteLine("Is Task Group Maintain Hierarchy?: " + group.MaintainHierarchy);
            Console.WriteLine("Is Task Group Show In Menu?: " + group.ShowInMenu);
            Console.WriteLine("Is Task Group Show Summary?: " + group.ShowSummary);
            Console.WriteLine("Is Task Group should groups Assignments instead of Tasks?: " + group.GroupAssignments);
            Console.WriteLine("Task Group Criteria count: " + group.GroupCriteria.Count);
            Console.WriteLine("\n************* Retrieving Task Group's Criterion information *************");

            foreach (var criterion in group.GroupCriteria)
            {
                Console.WriteLine("Task Criterion Field: " + criterion.Field);
                Console.WriteLine("Task Criterion GroupOn: " + criterion.GroupOn);
                Console.WriteLine("Task Criterion Cell Color: " + criterion.CellColor);
                Console.WriteLine("Task Criterion Pattern: " + criterion.Pattern);

                if (group == criterion.ParentGroup)
                {
                    Console.WriteLine("Parent Group is equal to task Group.");
                }

                Console.WriteLine("Font Name: " + criterion.Font.FontFamily);
                Console.WriteLine("Font Size: " + criterion.Font.Size);
                Console.WriteLine("Font Style: " + criterion.Font.Style);
                Console.WriteLine("Ascending/Descending: " + criterion.Ascending);
            }

            // ExEnd:WorkWithGroup
        }

        [Test]
        public void CreateGroups()
        {
            // ExStart:CreateGroups
            // ExFor: Group
            // ExFor: Group.#ctor
            // ExFor: Group.GroupCriteria
            // ExFor: Project.TaskGroups
            // ExFor: Project.ResourceGroups
            // ExFor: MPPSaveOptions.WriteGroups
            // ExFor: GroupCriterion
            // ExFor: GroupCriterion.GroupOn
            // ExFor: GroupCriterion.StartAt
            // ExFor: GroupCriterion.GroupInterval
            // ExFor: GroupCriterion.Font
            // ExFor: GroupCriterion.Field
            // ExSummary: Shows how to add groups to a project.
            var p = new Project();

            {
                var group = new Group();
                group.Name = "My new task group";
                group.MaintainHierarchy = true;
                group.ShowSummary = true;

                var criterion = new GroupCriterion();
                criterion.Field = Field.TaskDuration1;
                criterion.Font = new FontDescriptor("Comic Sans MS", 13F, FontStyles.Italic);
                criterion.GroupOn = GroupOn.DurationMinutes;
                criterion.StartAt = 5;
                criterion.GroupInterval = 3D;
                criterion.Pattern = BackgroundPattern.DarkDiagonalLeft;
                group.GroupCriteria.Add(criterion);

                var criterion2 = new GroupCriterion();
                criterion2.Field = Field.TaskPercentComplete;
                criterion2.Font = new FontDescriptor("Bodoni MT", 17, FontStyles.Italic | FontStyles.Bold);
                criterion2.GroupOn = GroupOn.Pct199;
                criterion2.Pattern = BackgroundPattern.LightDither;
                criterion2.CellColor = Color.Green;
                criterion2.FontColor = Color.Red;
                group.GroupCriteria.Add(criterion2);
                group.GroupAssignments = true;
                p.TaskGroups.Add(group);
            }

            {
                var group = new Group();
                group.Name = "My new resource group";
                group.MaintainHierarchy = true;
                group.ShowSummary = true;

                var criterion = new GroupCriterion();
                criterion.Field = Field.ResourceDuration1;
                criterion.Font = new FontDescriptor("Comic Sans MS", 11F, FontStyles.Bold);
                criterion.GroupOn = GroupOn.DurationHours;
                criterion.StartAt = 1;
                criterion.GroupInterval = 2D;
                criterion.Pattern = BackgroundPattern.DarkDiagonalLeft;
                group.GroupCriteria.Add(criterion);

                var criterion2 = new GroupCriterion();
                criterion2.Field = Field.ResourceCost;
                criterion2.Font = new FontDescriptor("Bodoni MT", 12, FontStyles.Italic | FontStyles.Bold);
                criterion2.GroupOn = GroupOn.Interval;
                criterion2.StartAt = 1D;
                criterion2.GroupInterval = 10D;
                criterion2.Pattern = BackgroundPattern.LightDither;
                criterion2.CellColor = Color.Magenta;
                criterion2.FontColor = Color.Red;
                group.GroupCriteria.Add(criterion2);
                group.GroupAssignments = true;
                p.ResourceGroups.Add(group);
            }

            p.Save(OutDir + "output_CreateGroup.mpp", new MPPSaveOptions() { WriteGroups = true });
            // ExEnd:CreateGroups
        }
    }
}