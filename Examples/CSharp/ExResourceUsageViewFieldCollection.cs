namespace Aspose.Tasks.Examples.CSharp
{
    using System;
    using System.Collections.Generic;
    using NUnit.Framework;

    [TestFixture]
    public class ExResourceUsageViewFieldCollection : ApiExampleBase
    {
        [Test]
        public void WorkWithResourceUsageViewFieldCollection()
        {
            // ExStart
            // ExFor: ResourceUsageViewFieldCollection
            // ExFor: ResourceUsageViewFieldCollection.GetEnumerator
            // ExFor: ResourceUsageViewFieldCollection.ToList
            // ExSummary: Shows how to work field collection of a ResourceUsageView instance.
            var project = new Project(DataDir + "ResourceUsageView.mpp");

            var view = (ResourceUsageView)project.Views.ToList()[2];
            foreach (var field in view.FieldCollection)
            {
                Console.WriteLine("Field: " + field);
            }

            // one can transform collection into a list of ResourceUsageViewField
            IList<ResourceUsageViewField> fields = view.FieldCollection.ToList();
            foreach (var field in fields)
            {
                Console.WriteLine("Field (from the list): " + field);
            }

            // ExEnd
        }
    }
}