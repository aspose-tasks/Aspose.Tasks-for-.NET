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
    public class ReadModuleAttributesInforamtion
    {
        public static void Run()
        {
            // The path to the documents directory.
            string dataDir = RunExamples.GetDataDir_Projects();

            Project project = new Project(dataDir + "VbaProject1.mpp");

            VbaProject vbaProject = project.VbaProject;
            IVbaModule vbaModule = vbaProject.Modules.ToList()[0];

            Console.WriteLine("Attributes Count: " + vbaModule.Attributes.Count);
            Console.WriteLine("VB_Name: " + vbaModule.Attributes.ToList()[0].Key);
            Console.WriteLine("Module1: " + vbaModule.Attributes.ToList()[0].Value);
            
        }
    }
}
