using Aspose.Tasks.Saving;

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
            // ExStart:ReadModulesInformation
            // ExFor: VbaProject.Modules
            // ExSummary: Shows how to iterate over VBS modules of the project.
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
        public void ReadVbaProjectInformation()
        {
            // ExStart:ReadVbaProjectInformation
            // ExFor: VbaProject
            // ExFor: VbaProject.Name
            // ExFor: VbaProject.Description
            // ExFor: VbaProject.CompilationArguments
            // ExFor: VbaProject.HelpContextId
            // ExFor: VbaProject.HelpFile
            // ExSummary: Shows how to read VBA project properties.
            var project = new Project(DataDir + "VbaProject.mpp");

            Console.WriteLine("VbaProject.Name " + project.VbaProject.Name);
            Console.WriteLine("VbaProject.Description " + project.VbaProject.Description);
            Console.WriteLine("VbaProject.CompilationArguments" + project.VbaProject.CompilationArguments);
            Console.WriteLine("VbaProject.HelpContextId" + project.VbaProject.HelpContextId);
            Console.WriteLine("VbaProject.HelpFile" + project.VbaProject.HelpFile);

            // ExEnd:ReadVbaProjectInformation
        }

        [Test]
        public void ReadReferencesInformation()
        {
            // ExStart:ReadReferencesInformation
            // ExFor: VbaProject.References
            // ExSummary: Shows how to read VBA project reference information.
            var project = new Project(DataDir + "VbaProject.mpp");

            Console.WriteLine("Reference count " + project.VbaProject.References.Count);

            foreach (var reference in project.VbaProject.References)
            {
                Console.WriteLine("Identifier: " + reference.LibIdentifier);
                Console.WriteLine("Name: " + reference.Name);
            }

            // ExEnd:ReadReferencesInformation
        }

        [Test]
        public void ClearVbaInformation()
        {
            // ExStart:ClearVbaInformation
            // ExFor: MPPSaveOptions.ClearVba
            // ExFor: Project.VbaProject
            // ExSummary: Shows how to remove VBA macros from MPP file.
            var project = new Project(DataDir + "VbaProject.mpp");
            project.Save(OutDir + "Vba.cleared.mpp", new MPPSaveOptions() { ClearVba = true });
            // ExEnd:ClearVbaInformation
        }

        [Test]
        public void ModifyVbaProjectModules()
        {
            // ExStart:ModifyVbaProjectModules
            // ExFor: MPPSaveOptions.WriteVba
            // ExFor: Project.VbaProject
            // ExFor: VbaProject.Modules
            // ExFor: VbaModule.SourceCode
            // ExFor: VbaModule.CreateProceduralModule
            // ExFor: VbaModule.CreateClassModule
            // ExFor: VbaModuleCollection.Add
            // ExFor: VbaModuleCollection.Remove
            // ExSummary: Shows how to add/delete VBA macros to/from the existing VbaProject in MPP file.
            var project = new Project(DataDir + "VbaProject.mpp");

            var newModule = VbaModule.CreateProceduralModule("Module20");
            newModule.SourceCode = @"Sub TestMacro()
#If conUnicode Then
Dim p As Project
Set p = Application.ActiveProject
MsgBox ""This is a message from a new macro. Current project: "" & p.Name
#End If
End Sub

Private Sub Project_BeforePrint(ByVal pj As Project)

End Sub";
            project.VbaProject.Modules.Add(newModule);

            var moduleToDelete = project.VbaProject.Modules["EventCode"];
            project.VbaProject.Modules.Remove(moduleToDelete);

            project.Save(OutDir + "VbaProject.AddedModule.mpp", new MPPSaveOptions() { WriteVba = true });
            // ExEnd:ModifyVbaProjectModules
        }
    }
}