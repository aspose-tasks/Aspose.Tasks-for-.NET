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
            var dataDir = RunExamples.GetDataDir(System.Reflection.MethodBase.GetCurrentMethod());

            {
                //ExStart:ReadTaskGroupDefinitionData
                //ExFor: Project.TaskGroups
                //ExFor: Project.ResourceGroups
                //ExFor: GroupCollection
                //ExFor: GroupCriterionCollection
                //ExFor: Group
                //ExFor: GroupCriterion
                //ExFor: GroupCriterion.Font
                //ExSummary: Shows how to read task groups.
                var project = new Project(dataDir + "ReadGroupDefinitionData.mpp"); 
                
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
            
            {
                //ExStart:ReadResourceGroupDefinitionData
                //ExFor: Project.ResourceGroups
                //ExSummary: Shows how to read resource groups.
                var project = new Project(dataDir + "ReadGroupDefinitionData.mpp"); 
                
                Console.WriteLine("Resource Groups Count: " + project.ResourceGroups.Count);
                var resGroup = project.TaskGroups.ToList()[1];
                Console.WriteLine("Resource Group Name: " + resGroup.Name);
                Console.WriteLine("Resource Group Criteria count: " + resGroup.GroupCriteria.Count);
                Console.WriteLine("\n************* Retrieving Resource Group's Criterion information *************");
                var resCriterion = resGroup.GroupCriteria.ToList()[0];
                Console.WriteLine("Resource Criterion Field: " + resCriterion.Field);
                Console.WriteLine("Resource Criterion GroupOn: " + resCriterion.GroupOn);
                Console.WriteLine("Resource Criterion Cell Color: " + resCriterion.CellColor);
                Console.WriteLine("Resource Criterion Pattern: " + resCriterion.Pattern);

                Console.WriteLine("\n*********** Retrieving Resource Criterion's Font Information ***********");
                Console.WriteLine("Resource Font Name: " + resCriterion.Font.Name);
                Console.WriteLine("Resource Font Size: " + resCriterion.Font.Size);
                Console.WriteLine("Resource Font Style: " + resCriterion.Font.Style);
                Console.WriteLine("Resource Ascending/Descending: " + resCriterion.Ascending);
                //ExEnd:ReadResourceGroupDefinitionData
            }
        }
    }
}