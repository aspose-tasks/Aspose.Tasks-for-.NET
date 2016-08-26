using System;
using System.Collections.Generic;

/*
This project uses Automatic Package Restore feature of NuGet to resolve Aspose.Tasks for .NET API reference 
when the project is build. Please check https:// Docs.nuget.org/consume/nuget-faq for more information. 
If you do not wish to use NuGet, you can manually download Aspose.Tasks for .NET API from http://www.aspose.com/downloads, 
install it and then add its reference to this project. For any issues, questions or suggestions 
please feel free to contact us using http://www.aspose.com/community/forums/default.aspx
*/

namespace Aspose.Tasks.Examples.CSharp.ManipulatingMPPFile
{
    public class ReadFilterDefinitionData
    {
        public static void Run()
        {
            // ExStart:ReadFilterDefinitionData
            // The path to the documents directory.
            string dataDir = RunExamples.GetDataDir_ManipulatingMPPFile();
            Project project = new Project(dataDir + "Project1.mpp");
            List<Filter> taskFilters = project.TaskFilters.ToList();
            Console.WriteLine("Task Filters Count: " + taskFilters.Count);
            Console.WriteLine("All Tasks: " + taskFilters[0].Name);
            Console.WriteLine("Task Item: " + taskFilters[0].FilterType);
            Console.WriteLine("Task Filters Show In Menu: " + taskFilters[0].ShowInMenu);
            Console.WriteLine("Task filter ShowRelatedSummaryRows: " + taskFilters[0].ShowRelatedSummaryRows);
            Console.WriteLine("Task filter type: " + taskFilters[1].ShowInMenu);
            Console.WriteLine("Task Filters Show In Menu: " + taskFilters[1].ShowInMenu);
            Console.WriteLine("Task filter ShowRelatedSummaryRows: " + taskFilters[1].ShowRelatedSummaryRows);
            Console.WriteLine("NEW FILTER", taskFilters[2].Name);
            Console.WriteLine("Task filter type: " + taskFilters[2].ShowInMenu);
            Console.WriteLine("Task Filters Show In Menu: " + taskFilters[2].ShowInMenu);
            Console.WriteLine("Task filter ShowRelatedSummaryRows: " + taskFilters[2].ShowRelatedSummaryRows);
            Console.WriteLine("Task FilterCriteria:m", taskFilters[2].Criteria);
            Console.WriteLine("(TaskName Contains T)", taskFilters[2].Criteria.ToString());
            List<Filter> rscFilters = project.ResourceFilters.ToList();
            Console.WriteLine("Project.ResourceFilters count: " + rscFilters.Count);
            Console.WriteLine("Resource Filter Item Type: Item.ResourceType: " + rscFilters[0].FilterType);
            Console.WriteLine("Resource filter ShowInMenu" + rscFilters[0].ShowInMenu);
            Console.WriteLine("Resource filter ShowRelatedSummaryRows: " + rscFilters[0].ShowRelatedSummaryRows);
            // ExEnd:ReadFilterDefinitionData
        }
    }
}