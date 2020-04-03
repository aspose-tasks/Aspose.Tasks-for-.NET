namespace Aspose.Tasks.Examples.CSharp
{
    using System;
    using NUnit.Framework;

    [TestFixture]
    public class ExVbaProject : ApiExampleBase
    {
        [Test]
        public void ReadModulesInformation()
        {
            //ExStart:ReadModulesInformation
            //ExFor: VbaProject.Modules
            //ExSummary: Shows how to iterate over VBS modules of the project.
            var project = new Project(DataDir + "VbaProject.mpp");

            Console.WriteLine("Total Modules Count: " + project.VbaProject.Modules.Count);

            foreach (var module in project.VbaProject.Modules)
            {
                Console.WriteLine("Module Name: " + module.Name);
                Console.WriteLine("Source Code: " + module.SourceCode);
            }
            //ExEnd:ReadModulesInformation
        }
        
        [Test]
        public void ReadVbaProjectInformation()
        {
            //ExStart:ReadVbaProjectInformation
            //ExFor: VbaProject
            //ExFor: VbaProject.Name
            //ExFor: VbaProject.Description
            //ExFor: VbaProject.CompilationArguments
            //ExFor: VbaProject.HelpContextId
            //ExFor: VbaProject.HelpFile
            //ExSummary: Shows how to read VBA project properties.
            var project = new Project(DataDir + "VbaProject.mpp");

            Console.WriteLine("VbaProject.Name " + project.VbaProject.Name);
            Console.WriteLine("VbaProject.Description " + project.VbaProject.Description);
            Console.WriteLine("VbaProject.CompilationArguments" + project.VbaProject.CompilationArguments);
            Console.WriteLine("VbaProject.HelpContextId" + project.VbaProject.HelpContextId);
            Console.WriteLine("VbaProject.HelpFile" + project.VbaProject.HelpFile);
            //ExEnd:ReadVbaProjectInformation
        }
        
        [Test]
        public void ReadReferencesInformation()
        {
            //ExStart:ReadReferencesInformation
            //ExFor: VbaProject.References
            //ExSummary: Shows how to read VBA project reference information.
            var project = new Project(DataDir + "VbaProject.mpp");

            Console.WriteLine("Reference count " + project.VbaProject.References.Count);

            foreach (var reference in project.VbaProject.References)
            {
                Console.WriteLine("Identifier: " + reference.LibIdentifier);
                Console.WriteLine("Name: " + reference.Name);
            }
            //ExEnd:ReadReferencesInformation
        }
    }
}