namespace Aspose.Tasks.Examples.CSharp
{
    using System;
    using NUnit.Framework;

    [TestFixture]
    public class ExVbaProject : ApiExampleBase
    {
        [Test]
        public void ReadVbaProjectInformation()
        {
            //ExStart:ReadVbaProjectInformation
            //ExFor: VbaProject.Name
            //ExFor: VbaProject.Description
            //ExFor: VbaProject.CompilationArguments
            //ExFor: VbaProject.HelpContextId
            //ExFor: VbaProject.HelpFile
            //ExSummary: Shows how to read VBA project information.
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
            //ExFor: VbaReferenceCollection
            //ExFor: VbaReference
            //ExFor: VbaReference.Name
            //ExFor: VbaReference.LibIdentifier
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
        
        [Test]
        public void ReadModulesInformation()
        {
            //ExStart:ReadModulesInformation
            //ExFor: VbaProject.Modules
            //ExFor: VbaModuleCollection
            //ExFor: VbaModule
            //ExFor: VbaModule.Name
            //ExFor: VbaModule.SourceCode
            //ExSummary: Shows how to read modules of VBA project.
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
        public void ReadModuleAttributesInformation()
        {
            //ExStart:ReadModuleAttributesInformation
            //ExFor: VbaModule.Attributes
            //ExFor: VbaModuleAttributeCollection
            //ExFor: VbaModuleAttribute
            //ExFor: VbaModuleAttribute.Key
            //ExFor: VbaModuleAttribute.Value
            //ExSummary: Shows how to read VBA module's attributes.
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