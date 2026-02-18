namespace Aspose.Tasks.Examples.CSharp
{
    using System;
    using NUnit.Framework;

    [TestFixture]
    public class ExVbaModule : ApiExampleBase
    {
        [Test]
        public void ReadModulesInformation()
        {
            // ExStart:ReadModulesInformation
            // ExFor: VbaModule
            // ExFor: VbaModule.Name
            // ExFor: VbaModule.SourceCode
            // ExSummary: Shows how to read modules of VBA project.
            var project = new Project(DataDir + "VbaProject.mpp");

            Console.WriteLine("Total Modules Count: " + project.VbaProject.Modules.Count);

            foreach (var module in project.VbaProject.Modules)
            {
                Console.WriteLine("Module Name: " + module.Name);
                Console.WriteLine("Source Code: " + module.SourceCode);
            }

            // ExEnd:ReadModulesInformation
        }

        [Test]
        public void ReadModuleAttributesInformation()
        {
            // ExStart:ReadModuleAttributesInformation
            // ExFor: VbaModule.Attributes
            // ExSummary: Shows how to read VBA module's attributes.
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