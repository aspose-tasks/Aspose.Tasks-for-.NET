using System;

/*
This project uses Automatic Package Restore feature of NuGet to resolve Aspose.Tasks for .NET API reference 
when the project is build. Please check https:// Docs.nuget.org/consume/nuget-faq for more information. 
If you do not wish to use NuGet, you can manually download Aspose.Tasks for .NET API from http://www.aspose.com/downloads, 
install it and then add its reference to this project. For any issues, questions or suggestions 
please feel free to contact us using http://www.aspose.com/community/forums/default.aspx
*/

namespace Aspose.Tasks.Examples.CSharp.WorkingWithProjects.Miscellaneous
{
    public class ReadGroupDefinitionData
    {
        public static void Run()
        {
            // ExStart:ReadGroupDefinitionData
            // The path to the documents directory.
            string dataDir = RunExamples.GetDataDir(System.Reflection.MethodBase.GetCurrentMethod().DeclaringType);

            Project project = new Project(dataDir + "Project1.mpp"); 
            
            Console.WriteLine("Task Groups Count: " + project.TaskGroups.Count);
            Group taskGroup = project.TaskGroups.ToList()[1];
            Console.WriteLine("Group Name:", taskGroup.Name);
            Console.WriteLine("Group Criteria count: " + taskGroup.GroupCriteria.Count);
            Console.WriteLine("\n************* Retrieving Task Group's Criterion information *************");
            GroupCriterion criterion = taskGroup.GroupCriteria.ToList()[0];
            Console.WriteLine("Criterion Field: " + criterion.Field.ToString());
            Console.WriteLine("Criterion GroupOn: " + criterion.GroupOn.ToString());
            Console.WriteLine("Criterion Cell Color: " + criterion.CellColor);
            Console.WriteLine("Criterion Pattern: " + criterion.Pattern.ToString());

            if (taskGroup == criterion.ParentGroup)
                Console.WriteLine("Parent Group is equval to task Group.");

            Console.WriteLine("\n*********** Retreivnig Criterion's Font Information ***********");
            Console.WriteLine("Font Name: " + criterion.Font.Name);
            Console.WriteLine("Font Size: " + criterion.Font.Size);
            Console.WriteLine("Font Style: " + criterion.Font.Style);
            Console.WriteLine("Ascending/Dscending: " + criterion.Ascending);
            // ExEnd:ReadGroupDefinitionData
        }
    }
}