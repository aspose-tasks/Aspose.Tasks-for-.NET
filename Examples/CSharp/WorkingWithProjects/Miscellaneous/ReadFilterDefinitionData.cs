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
    using System.Collections.Generic;

    internal class ReadFilterDefinitionData
    {
        public static void Run()
        {
            var dataDir = RunExamples.GetDataDir(System.Reflection.MethodBase.GetCurrentMethod());

            //ExStart:ReadFilterDefinitionData
            //ExFor: Project.TaskFilters
            //ExFor: Project.ResourceFilters
            //ExFor: Filter
            //ExSummary: Shows how to read task/resource filter definitions.
            // Instantiate project and access task filters
            var project = new Project(dataDir + "ReadFilterDefinitionData.mpp");
            List<Filter> taskFilters = project.TaskFilters.ToList();
            Console.WriteLine("Task Filters Count: " + taskFilters.Count);
            Console.WriteLine("All Tasks: " + taskFilters[0].Name);
            Console.WriteLine("Task Item: " + taskFilters[0].FilterType);
            Console.WriteLine("Task Filters Show In Menu: " + taskFilters[0].ShowInMenu);
            Console.WriteLine("Task filter ShowRelatedSummaryRows: " + taskFilters[0].ShowRelatedSummaryRows);

            // Access resource filters
            List<Filter> rscFilters = project.ResourceFilters.ToList();
            Console.WriteLine("Project.ResourceFilters count: " + rscFilters.Count);
            Console.WriteLine("Resource Filter Item Type: Item.ResourceType: " + rscFilters[0].FilterType);
            Console.WriteLine("Resource filter ShowInMenu" + rscFilters[0].ShowInMenu);
            Console.WriteLine("Resource filter ShowRelatedSummaryRows: " + rscFilters[0].ShowRelatedSummaryRows);
            //ExEnd:ReadFilterDefinitionData
        }
    }
}