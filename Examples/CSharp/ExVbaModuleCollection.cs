namespace Aspose.Tasks.Examples.CSharp
{
    using System;
    using Aspose.Tasks;
    using System.Collections.Generic;
    using NUnit.Framework;

    [TestFixture]
    public class ExVbaModuleCollection : ApiExampleBase
    {
        [Test]
        public void ReadModulesInformation()
        {
            // ExStart:ReadModulesInformation
            // ExFor: VbaModuleCollection
            // ExFor: VbaModuleCollection.Count
            // ExFor: VbaModuleCollection.GetEnumerator
            // ExFor: VbaModuleCollection.ToList
            // ExSummary: Shows how to iterate over VBA modules.
            var project = new Project(DataDir + "VbaProject.mpp");
            var vbaProject = project.VbaProject;

            Console.WriteLine("Total Modules Count: " + vbaProject.Modules.Count);
            foreach (VbaModule module in vbaProject.Modules)
            {
                Console.WriteLine("Module Name: " + module.Name);
                Console.WriteLine("Module Type: " + module.Type);
                Console.WriteLine("Source Code: " + module.SourceCode);
                Console.WriteLine();
            }

            // ExEnd:ReadModulesInformation
        }
    }
}