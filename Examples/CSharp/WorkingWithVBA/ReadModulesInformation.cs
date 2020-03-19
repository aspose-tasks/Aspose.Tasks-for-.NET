/*
This project uses Automatic Package Restore feature of NuGet to resolve Aspose.Tasks for .NET API reference 
when the project is build. Please check https:// Docs.nuget.org/consume/nuget-faq for more information. 
If you do not wish to use NuGet, you can manually download Aspose.Tasks for .NET API from https://www.nuget.org/packages/Aspose.Tasks/, 
install it and then add its reference to this project. For any issues, questions or suggestions 
please feel free to contact us using https://forum.aspose.com/c/tasks
*/

namespace Aspose.Tasks.Examples.CSharp.WorkingWithVBA
{
    using System;

    internal class ReadModulesInformation
    {
        public static void Run()
        {
            // The path to the documents directory.
            var dataDir = RunExamples.GetDataDir(System.Reflection.MethodBase.GetCurrentMethod().DeclaringType.FullName);

            //ExStart:ReadModulesInformation
            //ExFor: Project.VbaProject.Modules
            //ExFor: VbaProject.Modules
            //ExSummary: Shows how to read modules of VBA project.
            var project = new Project(dataDir + "VbaProject1.mpp");

            var vbaProject = project.VbaProject;
            Console.WriteLine("Total Modules Count: " + vbaProject.Modules.Count);

            foreach (var module in vbaProject.Modules)
            {
                Console.WriteLine("Module Name: " + module.Name);
                Console.WriteLine("Source Code: " + module.SourceCode);
            }
            //ExEnd:ReadModulesInformation
        }
    }
}
