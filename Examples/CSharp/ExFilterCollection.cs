namespace Aspose.Tasks.Examples.CSharp
{
    using System;
    using System.Collections.Generic;
    using NUnit.Framework;

    [TestFixture]
    internal class ExFilterCollection : ApiExampleBase
    {
        [Test]
        public void WorkWithFilterCollection()
        {
            //ExStart
            //ExFor: FilterCollection
            //ExFor: FilterCollection.Add(Filter)
            //ExFor: FilterCollection.Clear
            //ExFor: FilterCollection.Contains(Filter)
            //ExFor: FilterCollection.CopyTo(Filter[],Int32)
            //ExFor: FilterCollection.Count
            //ExFor: FilterCollection.GetEnumerator
            //ExFor: FilterCollection.IsReadOnly
            //ExFor: FilterCollection.ParentProject
            //ExFor: FilterCollection.Remove(Filter)
            //ExFor: FilterCollection.ToList
            //ExSummary: Shows how to work with filter collections.
            var project = new Project(DataDir + "ReadFilterDefinitionData.mpp");
            
            // iterate over task filters
            Console.WriteLine("Print task filters of {0} project: ", project.TaskFilters.ParentProject.Get(Prj.Name));
            Console.WriteLine("Task Filters Count: " + project.TaskFilters.Count);
            foreach (var filter in project.TaskFilters)
            {
                Console.WriteLine("All Tasks: " + filter.Name);
                Console.WriteLine("Task Item: " + filter.FilterType);
                Console.WriteLine("Task Filters Show In Menu: " + filter.ShowInMenu);
                Console.WriteLine("Task filter ShowRelatedSummaryRows: " + filter.ShowRelatedSummaryRows);
                Console.WriteLine();
            }

            // iterate over resource filters
            Console.WriteLine("Project.ResourceFilters count: " + project.ResourceFilters.Count);
            foreach (var filter in project.ResourceFilters)
            {
                Console.WriteLine("Resource Filter Item Type: Item.ResourceType: " + filter.FilterType);
                Console.WriteLine("Resource filter ShowInMenu" + filter.ShowInMenu);
                Console.WriteLine("Resource filter ShowRelatedSummaryRows: " + filter.ShowRelatedSummaryRows);
            }
            
            var otherProject = new Project(DataDir + "Blank2010.mpp");

            // clear other project's filters
            otherProject.TaskFilters.Clear();
            
            // copy filters to other project
            var filters = new Filter[project.TaskFilters.Count];
            project.TaskFilters.CopyTo(filters, 0);

            foreach (var filter in filters)
            {
                otherProject.TaskFilters.Add(filter);
            }

            // add custom task filter
            var customFilter = new Filter();
            customFilter.Name = "Custom Filter";
            customFilter.ShowInMenu = true;
            customFilter.ShowRelatedSummaryRows = true;

            if (!otherProject.TaskFilters.Contains(customFilter))
            {
                if (!otherProject.TaskFilters.IsReadOnly)
                {
                    otherProject.TaskFilters.Add(customFilter);
                }
            }

            // remove all filters
            List<Filter> filtersToDelete = otherProject.TaskFilters.ToList();
            foreach (var filter in filtersToDelete)
            {
                otherProject.TaskFilters.Remove(filter);
            }
            //ExEnd
        }
    }
}