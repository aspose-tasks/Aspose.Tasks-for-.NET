namespace Aspose.Tasks.Examples.CSharp
{
    using System;
    using System.Diagnostics.CodeAnalysis;

    using NUnit.Framework;

    [TestFixture]
    public class ExSplitPartCollection : ApiExampleBase
    {
        [Test]
        [SuppressMessage("ReSharper", "UnusedVariable", Justification = "Reviewed. Suppression is OK here.")] // ExSkip
        public void WorkWithSplitPartCollection()
        {
            // ExStart
            // ExFor: SplitPartCollection
            // ExFor: SplitPartCollection.Count
            // ExFor: SplitPartCollection.GetEnumerator
            // ExFor: SplitPartCollection.Item(Int32)
            // ExFor: SplitPartCollection.ToArray
            // ExSummary: Shows how to work with split part collections.
            var project = new Project(DataDir + "Splits.mpp");

            var task = project.RootTask.Children.GetById(1);

            // iterate over split parts
            Console.WriteLine("Iterate over split parts");
            Console.WriteLine("Split parts count:" + task.SplitParts.Count);
            foreach (var splitPart in task.SplitParts)
            {
                Console.WriteLine("Start: " + splitPart.Start);
                Console.WriteLine("Finish: " + splitPart.Finish);
            }

            // get the part by index
            var split = task.SplitParts[0];
            Console.WriteLine("Split start: " + split.Start);

            // make some work with the first split part of the task

            // ExEnd            
        }
    }
}