namespace Aspose.Tasks.Examples.CSharp
{
    using System;
    using NUnit.Framework;

    [TestFixture]
    public class ExVbaModuleAttributeCollection : ApiExampleBase
    {
        [Test]
        public void ReadModuleAttributesInformation()
        {
            // ExStart:ReadModuleAttributesInformation
            // ExFor: VbaModuleAttributeCollection
            // ExSummary: Shows how to iterate over VBA module collection.
            var project = new Project(DataDir + "VbaProject.mpp");

            foreach (var module in project.VbaProject.Modules)
            {
                Console.WriteLine("Attributes Count: " + module.Attributes.Count);
                foreach (var attribute in module.Attributes)
                {
                    Console.WriteLine("VB Name: " + attribute.Key);
                    Console.WriteLine("Module: " + attribute.Value);
                }
            }

            // ExEnd:ReadModuleAttributesInformation
        }
    }
}