namespace Aspose.Tasks.Examples.CSharp
{
    using System;
    using System.Collections.Generic;
    using NUnit.Framework;

    [TestFixture]
    public class ExTaskUsageViewFieldCollection : ApiExampleBase
    {
        [Test]
        public void WorkWithTaskUsageViewFieldCollection()
        {
            // ExStart
            // ExFor: TaskUsageViewFieldCollection
            // ExFor: TaskUsageViewFieldCollection.GetEnumerator
            // ExFor: TaskUsageViewFieldCollection.ToList
            // ExSummary: Shows how to work field collection of a TaskUsageView instance.
            var project = new Project(DataDir + "TaskUsageView.mpp");

            var view = (TaskUsageView)project.Views.ToList()[2];
            foreach (var field in view.FieldCollection)
            {
                Console.WriteLine("Field: " + field);
            }

            // one can transform collection into a list of TaskUsageViewField
            IList<TaskUsageViewField> fields = view.FieldCollection.ToList();
            foreach (var field in fields)
            {
                Console.WriteLine("Field (from the list): " + field);
            }

            // ExEnd
        }
    }
}