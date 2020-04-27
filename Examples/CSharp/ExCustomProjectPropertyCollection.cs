namespace Aspose.Tasks.Examples.CSharp
{
    using System;
    using NUnit.Framework;

    [TestFixture]
    internal class ExCustomProjectPropertyCollection : ApiExampleBase
    {
        [Test]
        public void ReadProjectMetaProperties()
        {
            // ExStart:ReadProjectMetaProperties
            // ExFor: CustomProjectPropertyCollection
            // ExFor: CustomProjectPropertyCollection.#ctor
            // ExFor: CustomProjectPropertyCollection.Add(String,Boolean)
            // ExFor: CustomProjectPropertyCollection.Add(String,DateTime)
            // ExFor: CustomProjectPropertyCollection.Add(String,Double)
            // ExFor: CustomProjectPropertyCollection.Add(String,String)
            // ExFor: CustomProjectPropertyCollection.Clear
            // ExFor: CustomProjectPropertyCollection.IsReadOnly
            // ExFor: CustomProjectPropertyCollection.Remove(String)
            // ExFor: PropertyKeyedCollection`1
            // ExFor: PropertyKeyedCollection`1.#ctor
            // ExFor: PropertyKeyedCollection`1.Add(`0)
            // ExFor: PropertyKeyedCollection`1.Contains(String)
            // ExFor: PropertyKeyedCollection`1.Count
            // ExFor: PropertyKeyedCollection`1.IsReadOnly
            // ExFor: PropertyKeyedCollection`1.Item(String)
            // ExFor: PropertyKeyedCollection`1.Names
            // ExFor: PropertyCollection`1
            // ExFor: PropertyCollection`1.#ctor
            // ExSummary: Shows how to work with custom project property collections.
            var project = new Project(DataDir + "ReadProjectInfo.mpp");

            Console.WriteLine("Is custom properties collection read-only?: " + project.CustomProps.IsReadOnly);

            // lets add new custom properties
            // collection support Boolean, DateTime, Double, String types
            project.CustomProps.Add("IsEnterprise", true);
            project.CustomProps.Add("Project Start Date", new DateTime(2020, 4, 16, 8, 0, 0));
            project.CustomProps.Add("Precision", 10d);
            project.CustomProps.Add("Custom Name", "MyProject");

            // custom properties are available through the typed collection
            Console.WriteLine("Count of custom properties: " + project.CustomProps.Count);
            foreach (var property in project.CustomProps)
            {
                Console.WriteLine(property.Type);
                Console.WriteLine(property.Name);
                Console.WriteLine(property.Value);
                Console.WriteLine();
            }

            // get a custom property value
            Console.WriteLine("Custom Name: " + project.CustomProps["Custom Name"]);

            // iterate over names of custom properties
            foreach (var propsName in project.CustomProps.Names)
            {
                Console.WriteLine("Name: " + propsName);
                Console.WriteLine();
            }

            // one can delete a value by string key
            if (project.CustomProps.Contains("Custom Name"))
            {
                project.CustomProps.Remove("Custom Name");
            }

            // or one can clear collection completely
            project.CustomProps.Clear();

            // ExEnd:ReadProjectMetaProperties
        }
    }
}