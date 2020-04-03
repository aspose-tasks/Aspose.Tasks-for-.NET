namespace Aspose.Tasks.Examples.CSharp
{
    using System;
    using NUnit.Framework;

    [TestFixture]
    public class ExVbaModuleAttribute : ApiExampleBase
    {
        [Test]
        public void ReadModuleAttributesInformation()
        {
            //ExStart:ReadModuleAttributesInformation
            //ExFor: VbaModuleAttribute
            //ExFor: VbaModuleAttribute.Key
            //ExFor: VbaModuleAttribute.Value
            //ExSummary: Shows how to work with VBA module attributes.
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
            //ExEnd:ReadModuleAttributesInformation
        }
    }
}