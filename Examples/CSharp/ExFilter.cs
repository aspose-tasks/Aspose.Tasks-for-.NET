/*
This project uses Automatic Package Restore feature of NuGet to resolve Aspose.Tasks for .NET API reference 
when the project is build. Please check https:// Docs.nuget.org/consume/nuget-faq for more information. 
If you do not wish to use NuGet, you can manually download Aspose.Tasks for .NET API from https://www.nuget.org/packages/Aspose.Tasks/, 
install it and then add its reference to this project. For any issues, questions or suggestions 
please feel free to contact us using https://forum.aspose.com/c/tasks
*/

using Aspose.Tasks.Saving;

namespace Aspose.Tasks.Examples.CSharp
{
    using System;
    using System.Collections.Generic;
    using NUnit.Framework;

    [TestFixture]
    internal class ExFilter : ApiExampleBase
    {
        [Test]
        public void ReadFilterDefinitionData()
        {
            // ExStart:ReadFilterDefinitionData
            // ExFor: Filter
            // ExFor: Filter.Uid
            // ExFor: Filter.Index
            // ExFor: Filter.Name
            // ExFor: Filter.FilterType
            // ExFor: Filter.ShowInMenu
            // ExFor: Filter.ShowRelatedSummaryRows
            // ExFor: ItemType
            // ExSummary: Shows how to work with filters.
            var project = new Project(DataDir + "ReadFilterDefinitionData.mpp");
            List<Filter> filters = project.TaskFilters.ToList();
            Console.WriteLine("Task filters count: " + filters.Count);
            foreach (var filter in filters)
            {
                Console.WriteLine("Uid: " + filter.Uid);
                Console.WriteLine("Index: " + filter.Index);
                Console.WriteLine("Name: " + filter.Name);
                Console.WriteLine("Type: " + filter.FilterType);
                Console.WriteLine("Show In Menu: " + filter.ShowInMenu);
                Console.WriteLine("Show Related Summary Rows: " + filter.ShowRelatedSummaryRows);
            }

            // check resource filters
            List<Filter> resourceFilters = project.ResourceFilters.ToList();
            Console.WriteLine("Project.ResourceFilters count: " + resourceFilters.Count);
            Console.WriteLine("Resource Filter Item Type: Item.ResourceType: " + resourceFilters[0].FilterType);
            Console.WriteLine("Resource filter ShowInMenu" + resourceFilters[0].ShowInMenu);
            Console.WriteLine("Resource filter ShowRelatedSummaryRows: " + resourceFilters[0].ShowRelatedSummaryRows);

            // ExEnd:ReadFilterDefinitionData
        }

        [Test]
        public static void ReadFilterCriteriaData()
        {
            // ExStart:ReadFilterCriteriaData
            // ExFor: Filter.Criteria
            // ExSummary: Shows how to read task filters.
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

            // ExEnd:ReadFilterCriteriaData
        }

        [Test]
        public void EqualsFilter()
        {
            // ExStart
            // ExFor: Filter.CompareTo(Filter)
            // ExFor: Filter.Equals(Filter)
            // ExFor: Filter.Equals(Object)
            // ExFor: Filter.op_Equality(Filter,Filter)
            // ExFor: Filter.op_GreaterThan(Filter,Filter)
            // ExFor: Filter.op_GreaterThanOrEqual(Filter,Filter)
            // ExFor: Filter.op_Inequality(Filter,Filter)
            // ExFor: Filter.op_LessThan(Filter,Filter)
            // ExFor: Filter.op_LessThanOrEqual(Filter,Filter)
            // ExSummary: Shows how to check filter equality.
            var project = new Project(DataDir + "ReadFilterDefinitionData.mpp");
            List<Filter> filters = project.TaskFilters.ToList();

            var filter1 = filters[0];
            var filter2 = filters[1];

            // the equality of filters is checked against to filter's UID.
            Console.WriteLine("Filter 1 UID: " + filter1.Uid);
            Console.WriteLine("Filter 2 UID: " + filter2.Uid);
            Console.WriteLine("Are filters equal: " + filter1.Equals(filter2));

            // ExEnd
        }

        [Test]
        public void AddFilterToProject()
        {
            // ExStart
            // ExFor: MPPSaveOptions.WriteFilters
            // ExSummary: Shows how to add and save new task filter to MPP project.
            Project project = new Project();

            project.TaskFilters.Clear();
            project.ResourceFilters.Clear();

            var filter = new Filter();
            filter.Name = "New Task Filter";
            filter.FilterType = ItemType.TaskItem;
            filter.ShowInMenu = true;
            filter.ShowRelatedSummaryRows = true;

            filter.Criteria = new FilterCriteria();

            var criteria1 = new FilterCriteria();
            criteria1.Field = Field.TaskNumber13;
            criteria1.Test = FilterComparisonType.IsLessThan;
            criteria1.Values[0] = 34.3D;

            filter.Criteria.CriteriaRows.Add(criteria1);
            project.TaskFilters.Add(filter);

            SimpleSaveOptions options = new MPPSaveOptions() { WriteFilters = true };
            project.Save(OutDir + "output_new_filter.mpp", options);

            // ExEnd
        }
    }
}