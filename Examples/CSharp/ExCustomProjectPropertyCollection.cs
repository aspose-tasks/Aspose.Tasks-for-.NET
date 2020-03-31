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
            //ExStart:ReadProjectMetaProperties
            //ExFor: CustomProjectPropertyCollection
            //ExSummary: Shows how to read project meta properties.
            var project = new Project(DataDir + "ReadProjectInfo.mpp");

            // custom properties are available through the typed collection
            foreach (var property in project.CustomProps)
            {
                Console.WriteLine(property.Type);
                Console.WriteLine(property.Name);
                Console.WriteLine(property.Value);
            }

            // built-in properties are available directly
            Console.WriteLine(project.BuiltInProps.Author);
            Console.WriteLine(project.BuiltInProps.Title);

            // or as an item of built-in property collection
            foreach (var property in project.BuiltInProps)
            {
                Console.WriteLine(property.Name);
                Console.WriteLine(property.Value);
            }
            //ExEnd:ReadProjectMetaProperties
        }   
    }
}