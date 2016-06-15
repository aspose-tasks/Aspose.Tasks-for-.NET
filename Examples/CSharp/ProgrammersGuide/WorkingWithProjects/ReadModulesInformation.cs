using System;
using Aspose.Tasks;

/*
This project uses Automatic Package Restore feature of NuGet to resolve Aspose.Tasks for .NET API reference 
when the project is build. Please check https://docs.nuget.org/consume/nuget-faq for more information. 
If you do not wish to use NuGet, you can manually download Aspose.Tasks for .NET API from http://www.aspose.com/downloads, 
install it and then add its reference to this project. For any issues, questions or suggestions 
please feel free to contact us using http://www.aspose.com/community/forums/default.aspx
*/

namespace Aspose.Tasks.Examples.CSharp.WorkingWithProjects
{
    public class ReadModulesInformation
    {
        public static void Run()
        {
            // The path to the documents directory.
            string dataDir = RunExamples.GetDataDir_Projects();

            Project project = new Project(dataDir + "VbaProject1.mpp");

            VbaProject vbaProject = project.VbaProject;
            Console.WriteLine("Total Modules Count: " + vbaProject.Modules.Count);

            IVbaModule vbaModule = vbaProject.Modules.ToList()[0];
            Console.WriteLine("Module Name: " + vbaModule.Name);
            Console.WriteLine("Source Code: " + vbaModule.SourceCode);
        }
    }
}
