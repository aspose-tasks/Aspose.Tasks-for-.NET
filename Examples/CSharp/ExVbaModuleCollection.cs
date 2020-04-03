namespace Aspose.Tasks.Examples.CSharp
{
    using System;
    using NUnit.Framework;

    [TestFixture]
    public class ExVbaModuleCollection : ApiExampleBase
    {
        [Test]
        public void ReadModulesInformation()
        {
            //ExStart:ReadModulesInformation
            //ExFor: VbaModuleCollection
            //ExSummary: Shows how to iterate over VBA modules.
            var project = new Project(DataDir + "VbaProject.mpp");

            Console.WriteLine("Total Modules Count: " + project.VbaProject.Modules.Count);

            foreach (var module in project.VbaProject.Modules)
            {
                Console.WriteLine("Module Name: " + module.Name);
                Console.WriteLine("Source Code: " + module.SourceCode);
            }
            //ExEnd:ReadModulesInformation
        }
    }
}