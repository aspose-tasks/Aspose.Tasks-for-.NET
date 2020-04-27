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
            // ExStart:ReadModuleAttributesInformation
            // ExFor: VbaModuleAttribute
            // ExFor: VbaModuleAttribute.Key
            // ExFor: VbaModuleAttribute.Value
            // ExSummary: Shows how to work with VBA module attributes.
            var project = new Project(DataDir + "VbaProject.mpp");

            foreach (var module in project.VbaProject.Modules)
            {
                Console.WriteLine("Attributes Count: " + module.Attributes.Count);
                foreach (var attribute in module.Attributes)
                {
                    Console.WriteLine("  VB Name: " + attribute.Key);
                    Console.WriteLine("  Module: " + attribute.Value);
                }
            }

            // ExEnd:ReadModuleAttributesInformation
        }

        [Test]
        public void EqualsVbaModuleAttribute()
        {
            // ExStart
            // ExFor: VbaModuleAttribute.Equals(VbaModuleAttribute)
            // ExFor: VbaModuleAttribute.Equals(Object)
            // ExSummary: Shows how to check VBA module attributes equality.
            var project = new Project(DataDir + "VbaProject.mpp");
            var module = project.VbaProject.Modules.ToList()[0];

            var attribute1 = module.Attributes.ToList()[0];
            var attribute2 = module.Attributes.ToList()[0];
            Console.WriteLine("Module attribute 1 Key: {0}, Value: {1}", attribute1.Key, attribute1.Value);
            Console.WriteLine("Module attribute 2 Key: {0}, Value: {1}", attribute2.Key, attribute2.Value);
            Console.WriteLine("Are module attributes equal: " + attribute1.Equals(attribute2));

            // ExEnd
        }

        [Test]
        public void GetHashCodeVbaModuleAttribute()
        {
            // ExStart
            // ExFor: VbaModuleAttribute.GetHashCode
            // ExSummary: Shows how to get a hash code of a VBA module attribute.
            var project = new Project(DataDir + "VbaProject.mpp");
            var module = project.VbaProject.Modules.ToList()[0];

            var attribute1 = module.Attributes.ToList()[0];
            var attribute2 = module.Attributes.ToList()[0];

            // print hash codes of a VBA module attributes
            Console.WriteLine("Hash codes of VBA module attributes are based on key and value hash codes.");
            Console.WriteLine("VBA module attribute 1 Hash Code: {0}", attribute1.GetHashCode());
            Console.WriteLine("VBA module attribute 2 Hash Code: {0}", attribute2.GetHashCode());

            // ExEnd
        }
    }
}