/*
This project uses Automatic Package Restore feature of NuGet to resolve Aspose.Tasks for .NET API reference 
when the project is build. Please check https:// Docs.nuget.org/consume/nuget-faq for more information. 
If you do not wish to use NuGet, you can manually download Aspose.Tasks for .NET API from https://www.nuget.org/packages/Aspose.Tasks/, 
install it and then add its reference to this project. For any issues, questions or suggestions 
please feel free to contact us using https://forum.aspose.com/c/tasks
*/

namespace Aspose.Tasks.Examples.CSharp.WorkingWithProjects.CreatingReadingAndSaving
{
    using System;

    internal class ReadPasswordProtectedProjectFile
    {
        public static void Run()
        {
            var dataDir = RunExamples.GetDataDir(System.Reflection.MethodBase.GetCurrentMethod());
            
            //ExStart:ReadingPasswordProtectedProjectFile
            //ExFor: Project.#ctor(String,String)
            //ExSummary: Shows how to read password protected MPP files.
            var project = new Project(dataDir + "PasswordProtectedProject.mpp", "password");
            Console.WriteLine(project.Get(Prj.Name));
            //ExEnd:ReadingPasswordProtectedProjectFile
        }
    }
}