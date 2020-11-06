namespace Aspose.Tasks.Examples.CSharp
{
    using System;
    using NUnit.Framework;

    [TestFixture]
    public class ExView : ApiExampleBase
    {
        [Test]
        public void WorkWithView()
        {
            // ExStart:WorkWithView
            // ExFor: View
            // ExFor: View.#ctor
            // ExFor: View.PageInfo
            // ExFor: View.Filter
            // ExFor: View.Group 
            // ExFor: View.Index
            // ExFor: View.Name
            // ExFor: View.ParentProject
            // ExFor: View.Screen
            // ExFor: View.HighlightFilter
            // ExFor: View.ShowInMenu
            // ExFor: View.Table
            // ExFor: View.Type
            // ExFor: View.Uid
            // ExFor: ViewScreen
            // ExSummary: Shows how to work with MS Project views.
            
            // create an empty project without views 
            var project = new Project();
            project.Set(Prj.Name, "Test View Project");
            
            // create a standard Gantt chart view
            View view = new GanttChartView();
            
            // set some view properties
            // set a value indicating whether Microsoft Project shows the single view name in the View or the Other Views drop-down lists in the Ribbon
            view.ShowInMenu = true;
            // set a value indicating whether Microsoft Project highlights the filter for a single view
            view.HighlightFilter = true;
            
            // the writing of the next properties is not supported
            // sets the filter used in a single view
            view.Filter = null;
            // sets the group of the single view
            view.Group = null;
            // sets the table of the single view
            view.Table = null;
            
            // lets tune some view settings
            // set the number of first columns to be printed on all pages
            view.PageInfo.PageViewSettings.FirstColumnsCount = 4;
            // set a value indicating whether to print a specified number of first columns on all pages
            view.PageInfo.PageViewSettings.PrintFirstColumnsCountOnAllPages = true;

            // add the view to the our project
            project.Views.Add(view);
            // lets check some properties of the newly added view
            // print the unique identifier of a view
            Console.WriteLine("View Uid: " + view.Uid);
            // print the screen type for the single view
            Console.WriteLine("View Screen: " + view.Screen);
            Console.WriteLine("View Type: " + view.Type);
            Console.WriteLine("Parent Project of the view: " + view.ParentProject.Get(Prj.Name));
            // ExEnd:WorkWithView
        }

        [Test]
        public void EqualsView()
        {
            // ExStart:EqualsView
            // ExFor: View.CompareTo(View)
            // ExFor: View.Equals(Object)
            // ExFor: View.op_Equality(View,View)
            // ExFor: View.op_GreaterThan(View,View)
            // ExFor: View.op_GreaterThanOrEqual(View,View)
            // ExFor: View.op_Inequality(View,View)
            // ExFor: View.op_LessThan(View,View)
            // ExFor: View.op_LessThanOrEqual(View,View)
            // ExSummary: Shows how to check equality of MS Project views.
            // create an empty project without views 
            var project = new Project(DataDir + "Project2003.mpp");

            var view1 = project.Views.ToList()[0];
            var view2 = project.Views.ToList()[1];
            
            // the equality of views is checked against to view's UID.
            Console.WriteLine("View 1 UID: " + view1.Uid);
            Console.WriteLine("View 2 UID: " + view2.Uid);
            Console.WriteLine("Are views equal: " + view1.Equals(view2));

            // ExEnd:EqualsView
        }
        
        [Test]
        public void GetHashCodeView()
        {
            // ExStart:GetHashCodeView
            // ExFor: View.GetHashCode
            // ExSummary: Shows how to get a hash code of an MS Project view.
            
            // create an empty project without views 
            var project = new Project(DataDir + "Project2003.mpp");

            var view1 = project.Views.ToList()[0];
            var view2 = project.Views.ToList()[1];
            
            // the equality of views is checked against to view's UID.
            Console.WriteLine("View 1 UID: " + view1.Uid);
            Console.WriteLine("View 2 UID: " + view2.Uid);
            Console.WriteLine("Are views equal: " + view1.Equals(view2));
            
            // the hash code of a view is equal to view UID 
            Console.WriteLine("View UID: {0} Hash Code: {1}", view1.Uid, view2.GetHashCode());
            Console.WriteLine("View UID: {0} Hash Code: {1}", view1.Uid, view2.GetHashCode());
  
            // ExEnd:GetHashCodeView
        }
    }
}