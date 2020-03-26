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

    internal class ReadVBAProjectInformation
    {
        public static void Run()
        {
            var dataDir = RunExamples.GetDataDir(System.Reflection.MethodBase.GetCurrentMethod());

            //ExStart:ReadVBAProjectInformation
            //ExFor: Project.VbaProject
            //ExFor: VbaProject.Name
            //ExFor: VbaProject.Description
            //ExFor: VbaProject.CompilationArguments
            //ExFor: VbaProject.HelpContextId
            //ExSummary: Shows how to read VBA project information.
            // Loading project file
            var project = new Project(dataDir + "VbaProject1.mpp");

            var vbaProject = project.VbaProject;

            Console.WriteLine("VbaProject.Name " + vbaProject.Name);
            Console.WriteLine("VbaProject.Description " + vbaProject.Description);
            Console.WriteLine("VbaProject.CompilationArguments" + vbaProject.CompilationArguments);
            Console.WriteLine("VbaProject.HelpContextId" + vbaProject.HelpContextId);
            Console.WriteLine("VbaProject.HelpFile" + vbaProject.HelpFile);
            //ExEnd:ReadVBAProjectInformation
        }
    }
}
