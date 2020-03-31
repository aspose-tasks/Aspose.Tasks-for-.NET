/*
This project uses Automatic Package Restore feature of NuGet to resolve Aspose.Tasks for .NET API reference 
when the project is build. Please check https:// Docs.nuget.org/consume/nuget-faq for more information. 
If you do not wish to use NuGet, you can manually download Aspose.Tasks for .NET API from https://www.nuget.org/packages/Aspose.Tasks/, 
install it and then add its reference to this project. For any issues, questions or suggestions 
please feel free to contact us using https://forum.aspose.com/c/tasks
*/

namespace Aspose.Tasks.Examples.CSharp
{
    using System;
    using System.Collections.Generic;
    using NUnit.Framework;

    [TestFixture]
    internal class ExFilter : ApiExampleBase
    {
        [Test]
        public static void ReadFilterCriteriaData()
        {
            //ExStart:ReadFilterCriteriaData
            //ExFor: Filter.Criteria
            //ExSummary: Shows how to read task filters.
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
        
        [Test]
        public void ReadFilterDefinitionData()
        {
            //ExStart:ReadFilterDefinitionData
            //ExFor: Filter
            //ExSummary: Shows how to work with filters.
            var project = new Project(DataDir + "ReadFilterDefinitionData.mpp");
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