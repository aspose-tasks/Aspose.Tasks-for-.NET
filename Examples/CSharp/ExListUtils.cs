namespace Aspose.Tasks.Examples.CSharp
{
    using System;
    using System.Collections.Generic;
    using System.Diagnostics.CodeAnalysis;

    using NUnit.Framework;
    using Util;

    [TestFixture]
    [SuppressMessage("ReSharper", "MemberCanBePrivate.Global", Justification = "Reviewed. Suppression is OK here.")]
    [SuppressMessage("ReSharper", "StyleCop.SA1600", Justification = "Reviewed. Suppression is OK here.")]
    [SuppressMessage("ReSharper", "StyleCop.SA1201", Justification = "Reviewed. Suppression is OK here.")]
    internal class ExListUtils : ApiExampleBase
    {
        // ExStart:WorkWithListUtilsFind
        // ExFor: ListUtils
        // ExFor: ListUtils.Find``1(IList{``0},ICondition{``0})
        // ExSummary: Shows how to work with list util Find method.
        [Test] // ExSkip
        public void WorkWithListUtilsFind()
        {
            var project = new Project(DataDir + "Project2003.mpp");
            List<Filter> taskFilters = project.TaskFilters.ToList();

            Assert.AreEqual(3, taskFilters.Count, "Project.TaskFilters count");

            var filter = ListUtils.Find(taskFilters, new FilterByName("&All Tasks"));

            Console.WriteLine("Name: " + filter.Name);
            Console.WriteLine("Filter Type: " + filter.FilterType);
            Console.WriteLine("Show In Menu: " + filter.ShowInMenu);
            Console.WriteLine("Show Related Summary Rows: " + filter.ShowRelatedSummaryRows);
        }

        public class FilterByName : ICondition<Filter>
        {
            private readonly string name;

            public FilterByName(string name)
            {
                this.name = name;
            }

            /// <summary>
            /// Returns true if the specified object satisfy the conditions.
            /// </summary>
            /// <param name="el">The object to check.</param>
            /// <returns>True if the object satisfy the conditions.</returns>
            /// <inheritdoc />
            public bool Check(Filter el)
            {
                return el.Name == this.name;
            }
        }

        // ExEnd:WorkWithListUtilsFind

        // ExStart:WorkWithListUtilsFilter
        // ExFor: ICondition`1
        // ExFor: ICondition`1.Check(`0)
        // ExFor: ListUtils.Filter``1(IList{``0},ICondition{``0})
        // ExSummary: Shows how to work with list util Filter method.
        [Test] // ExSkip
        public void WorkWithListUtilsFilter()
        {
            var project = new Project(DataDir + "Project2003.mpp");
            List<Filter> filters = project.TaskFilters.ToList();

            Assert.AreEqual(3, filters.Count, "Project.TaskFilters count");

            ListUtils.Filter(filters, new FilterByIndex(1));

            foreach (var filter in filters)
            {
                Console.WriteLine("Name: " + filter.Name);
                Console.WriteLine("Filter Type: " + filter.FilterType);
                Console.WriteLine("Show In Menu: " + filter.ShowInMenu);
                Console.WriteLine("Show Related Summary Rows: " + filter.ShowRelatedSummaryRows);
                Console.WriteLine();
            }
        }

        public class FilterByIndex : ICondition<Filter>
        {
            private readonly int index;

            public FilterByIndex(int index)
            {
                this.index = index;
            }

            /// <summary>
            /// Returns true if the specified object satisfy the conditions.
            /// </summary>
            /// <param name="el">The object to check.</param>
            /// <returns>True if the object satisfy the conditions.</returns>
            /// <inheritdoc />
            public bool Check(Filter el)
            {
                return el.Index == this.index;
            }
        }

        // ExEnd:WorkWithListUtilsFilter

        // ExStart:WorkWithListUtilsApply
        // ExFor: ListUtils.Apply``1(IList{``0},IAlgorithm{``0},Int32)
        // ExFor: IAlgorithm`1
        // ExFor: IAlgorithm`1.Alg(`0,Int32)
        // ExFor: IAlgorithm`1.PostAlg(`0,Int32)
        // ExFor: IAlgorithm`1.PreAlg(`0,Int32)
        // ExSummary: Shows how to work with list util Apply method.
        [Test] // ExSkip
        public void WorkWithListUtilsApply()
        {
            var project = new Project(DataDir + "Project2003.mpp");
            List<Filter> filters = project.TaskFilters.ToList();

            Assert.AreEqual(3, filters.Count, "Project.TaskFilters count");

            ListUtils.Apply(filters, new RenameAlgorithm(), 0);

            foreach (var filter in filters)
            {
                Console.WriteLine("Name: " + filter.Name);
                Console.WriteLine("Filter Type: " + filter.FilterType);
                Console.WriteLine("Show In Menu: " + filter.ShowInMenu);
                Console.WriteLine("Show Related Summary Rows: " + filter.ShowRelatedSummaryRows);
                Console.WriteLine();
            }
        }

        private class RenameAlgorithm : IAlgorithm<Filter>
        {
            private int current;

            public RenameAlgorithm()
            {
                this.current = 0;
            }

            public void PreAlg(Filter el, int index)
            {
                this.current++;
            }

            public void Alg(Filter el, int index)
            {
                el.Name = el.Name + " " + this.current;
            }

            public void PostAlg(Filter el, int index)
            {
            }
        }

        // ExEnd:WorkWithListUtilsApply
    }
}