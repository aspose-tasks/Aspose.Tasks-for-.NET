namespace Aspose.Tasks.Examples.CSharp
{
    using System;
    using System.Collections.Generic;
    using NUnit.Framework;

    [TestFixture]
    public class ExViewCollection : ApiExampleBase
    {
        [Test]
        public void WorkWithViewCollection()
        {
            // ExStart
            // ExFor: ViewCollection
            // ExFor: ViewCollection.Add(View)
            // ExFor: ViewCollection.Clear
            // ExFor: ViewCollection.Contains(View)
            // ExFor: ViewCollection.CopyTo(View[],Int32)
            // ExFor: ViewCollection.Count
            // ExFor: ViewCollection.GetEnumerator
            // ExFor: ViewCollection.IsReadOnly
            // ExFor: ViewCollection.ParentProject
            // ExFor: ViewCollection.Remove(View)
            // ExFor: ViewCollection.ToList
            // ExSummary: Shows how to work with view collections.
            var project = new Project(DataDir + "Project1.mpp");

            // convert to a plain list of views
            List<View> list = project.Views.ToList();
            for (var index = 0; index < list.Count; index++)
            {
                var viewToChange = list[index];
                viewToChange.PageInfo.Header.CenteredText = "Header " + index;
            }

            // add a new view
            var view = new GanttChartView();
            if (!project.Views.IsReadOnly)
            {
                project.Views.Add(view);
            }

            // iterate over views
            Console.WriteLine("Iterate over views of " + project.Views.ParentProject.Get(Prj.Name) + " project.");
            Console.WriteLine("Project view count: " + project.Views.Count);
            Console.WriteLine();
            foreach (var projectView in project.Views)
            {
                Console.WriteLine("Name: " + projectView.Name);
            }

            // remove all views at once
            project.Views.Clear();

            // or one by one
            {
                // approach 1
                List<View> listToDelete = project.Views.ToList();
                foreach (var v in listToDelete)
                {
                    if (project.Views.Contains(v))
                    {
                        project.Views.Remove(v);
                    }
                }
            }

            {
                // approach 2
                var array = new View[project.Views.Count];
                project.Views.CopyTo(array, 0);
                foreach (var v in array)
                {
                    if (project.Views.Contains(v))
                    {
                        project.Views.Remove(v);
                    }
                }
            }

            // ExEnd
        }
    }
}