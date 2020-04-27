namespace Aspose.Tasks.Examples.CSharp
{
    using System;
    using System.Collections.Generic;
    using NUnit.Framework;

    [TestFixture]
    public class ExResourceCollection : ApiExampleBase
    {
        [Test]
        public void WorkWithResourceCollection()
        {
            // ExStart:WorkWithResourceCollection
            // ExFor: ResourceCollection
            // ExFor: ResourceCollection.Add
            // ExFor: ResourceCollection.Add(String)
            // ExFor: ResourceCollection.Add(String,Int32)
            // ExFor: ResourceCollection.Clear
            // ExFor: ResourceCollection.Count
            // ExFor: ResourceCollection.GetById(Int32)
            // ExFor: ResourceCollection.GetByUid(Int32)
            // ExFor: ResourceCollection.GetEnumerator
            // ExFor: ResourceCollection.ParentProject
            // ExFor: ResourceCollection.ToList
            // ExSummary: Shows how to work with resource collections.
            var project = new Project(DataDir + "SampleProject.mpp");

            // add empty resource
            var resource = project.Resources.Add();
            resource.Set(Rsc.Type, ResourceType.Work);

            // add resource with a name
            var developer = project.Resources.Add("Developer");
            developer.Set(Rsc.Type, ResourceType.Work);

            // add resource before the resource with specified ID
            var manager = project.Resources.Add("Manager", developer.Get(Rsc.Id));
            manager.Set(Rsc.Type, ResourceType.Work);

            var devResource = project.Resources.GetById(4);
            devResource.Set(Rsc.Code, "12345");

            var manResource = project.Resources.GetByUid(4);
            manResource.Set(Rsc.Code, "54321");

            // get resource by id
            project.Resources.GetById(1);

            Console.WriteLine("Print the resources of " + project.Resources.ParentProject.Get(Prj.Name) + " project.");
            Console.WriteLine("Count of resources: " + project.Resources.Count);
            foreach (var rsc in project.Resources)
            {
                Console.WriteLine("Resource Name: " + rsc.Get(Rsc.Name));
            }

            Console.WriteLine();

            // resource collections does not support Clear operation
            // project.Resources.Clear();
            // use next code sample instead
            List<Resource> list = project.Resources.ToList();
            foreach (var rsc in list)
            {
                rsc.Delete();
            }

            // ExEnd:WorkWithResourceCollection
        }
    }
}