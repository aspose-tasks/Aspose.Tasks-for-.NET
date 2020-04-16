namespace Aspose.Tasks.Examples.CSharp
{
    using System;
    using System.Collections.Generic;
    using NUnit.Framework;

    [TestFixture]
    public class ExVbaModuleCollection : ApiExampleBase
    {
        [Test]
        public void ReadModulesInformation()
        {
            //ExStart:ReadModulesInformation
            //ExFor: VbaModuleCollection
            //ExFor: ReadOnlyCollectionBase`1
            //ExFor: ReadOnlyCollectionBase`1.Count
            //ExFor: ReadOnlyCollectionBase`1.GetEnumerator
            //ExFor: ReadOnlyCollectionBase`1.ToList
            //ExSummary: Shows how to iterate over VBA modules.
            var project = new Project(DataDir + "VbaProject.mpp");
            var vbaProject = project.VbaProject;
            
            Console.WriteLine("Total Modules Count: " + vbaProject.Modules.Count);
            foreach (var module in vbaProject.Modules)
            {
                Console.WriteLine("Module Name: " + module.Name);
                Console.WriteLine("Source Code: " + module.SourceCode);
                Console.WriteLine();
            }
            
            // the collection can be converted into a plain list
            List<VbaModule> modules = vbaProject.Modules.ToList();
            foreach (var unused in modules)
            {
                // work with modules
            }
            //ExEnd:ReadModulesInformation
        }
    }
}