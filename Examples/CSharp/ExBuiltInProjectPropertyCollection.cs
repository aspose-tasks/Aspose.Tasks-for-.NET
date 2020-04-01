namespace Aspose.Tasks.Examples.CSharp
{
    using System;
    using NUnit.Framework;

    [TestFixture]
    internal class ExBuiltInProjectPropertyCollection : ApiExampleBase
    {
        [Test]
        public void ReadProjectMetaProperties()
        {
            //ExStart:ReadProjectMetaProperties
            //ExFor: BuiltInProjectPropertyCollection
            //ExSummary: Shows how to read project builtin properties.
            var project = new Project(DataDir + "ReadProjectInfo.mpp");

            // iterate over built-in property collection
            foreach (var property in project.BuiltInProps)
            {
                Console.WriteLine(property.Name);
                Console.WriteLine(property.Value);
            }
            //ExEnd:ReadProjectMetaProperties
        }   
    }
}
