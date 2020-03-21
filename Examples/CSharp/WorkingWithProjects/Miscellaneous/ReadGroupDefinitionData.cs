/*
This project uses Automatic Package Restore feature of NuGet to resolve Aspose.Tasks for .NET API reference 
when the project is build. Please check https:// Docs.nuget.org/consume/nuget-faq for more information. 
If you do not wish to use NuGet, you can manually download Aspose.Tasks for .NET API from https://www.nuget.org/packages/Aspose.Tasks/, 
install it and then add its reference to this project. For any issues, questions or suggestions 
please feel free to contact us using https://forum.aspose.com/c/tasks
*/

namespace Aspose.Tasks.Examples.CSharp.WorkingWithProjects.Miscellaneous
{
    using System;

    internal class ReadGroupDefinitionData
    {
        public static void Run()
        {
            // The path to the documents directory.
            var dataDir = RunExamples.GetDataDir(System.Reflection.MethodBase.GetCurrentMethod().DeclaringType.FullName);

            //ExStart:ReadGroupDefinitionData
            //ExFor: GroupCollection
            //ExFor: GroupCriterionCollection
            //ExFor: Group
            //ExFor: GroupCriterion
            //ExFor: GroupCriterion.Font
            //ExSummary: Shows how to read task groups.
            var project = new Project(dataDir + "ReadGroupDefinitionData.mpp"); 
            
            Console.WriteLine("Task Groups Count: " + project.TaskGroups.Count);
            var taskGroup = project.TaskGroups.ToList()[1];
            Console.WriteLine("Group Name: " + taskGroup.Name);
            Console.WriteLine("Group Criteria count: " + taskGroup.GroupCriteria.Count);
            Console.WriteLine("\n************* Retrieving Task Group's Criterion information *************");
            var criterion = taskGroup.GroupCriteria.ToList()[0];
            Console.WriteLine("Criterion Field: " + criterion.Field);
            Console.WriteLine("Criterion GroupOn: " + criterion.GroupOn);
            Console.WriteLine("Criterion Cell Color: " + criterion.CellColor);
            Console.WriteLine("Criterion Pattern: " + criterion.Pattern);

            if (taskGroup == criterion.ParentGroup)
            {
                Console.WriteLine("Parent Group is equal to task Group.");
            }

            Console.WriteLine("\n*********** Retrieving Criterion's Font Information ***********");
            Console.WriteLine("Font Name: " + criterion.Font.Name);
            Console.WriteLine("Font Size: " + criterion.Font.Size);
            Console.WriteLine("Font Style: " + criterion.Font.Style);
            Console.WriteLine("Ascending/Descending: " + criterion.Ascending);
            //ExEnd:ReadGroupDefinitionData
        }
    }
}