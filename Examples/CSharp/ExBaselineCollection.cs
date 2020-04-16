namespace Aspose.Tasks.Examples.CSharp
{
    using System;
    using System.Collections.Generic;
    using NUnit.Framework;

    [TestFixture]
    public class ExBaselineCollection : ApiExampleBase
    {
        [Test]
        public void WorkWithBaselineCollection()
        {
            //ExStart
            //ExFor: BaselineCollection
            //ExFor: BaselineCollection.ParentResource
            //ExFor: BaselineCollection.Count
            //ExFor: BaselineCollection.GetEnumerator
            //ExFor: BaselineCollection.Remove(Baseline)
            //ExFor: BaselineCollection.ToList
            //ExSummary: Shows how to work with baseline collections.
            var project = new Project(DataDir + "WorkWithBaselineCollection.mpp");
            var resource = project.Resources.GetByUid(1);

            Console.WriteLine("Count of assignment baselines: " + resource.Baselines.Count);
            Console.WriteLine("Parent Resource Name: " + resource.Baselines.ParentResource.Get(Rsc.Name));
            
            // read baseline information
            foreach (var baseline in resource.Baselines)
            {
                Console.WriteLine("Baseline Number: " + baseline.BaselineNumber);
                Console.WriteLine("Cost: " + baseline.Cost);
                Console.WriteLine("Work: " + baseline.Work);
                Console.WriteLine("BCWP: " + baseline.Bcwp);
                Console.WriteLine("BCWS: " + baseline.Bcws);
                Console.WriteLine();
            }

            Console.WriteLine("Delete all baselines: ");
            List<Baseline> baselines = resource.Baselines.ToList();
            foreach (var baseline in baselines)
            {
                Console.WriteLine("Delete baseline with name: " + baseline.BaselineNumber);
                resource.Baselines.Remove(baseline);
            }
            //ExEnd
        }
    }
}