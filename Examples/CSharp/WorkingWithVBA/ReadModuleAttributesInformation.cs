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

    internal class ReadModuleAttributesInformation
    {
        public static void Run()
        {
            var dataDir = RunExamples.GetDataDir(System.Reflection.MethodBase.GetCurrentMethod());

            //ExStart:ReadModuleAttributesInformation
            //ExFor: VbaModule.Attributes
            //ExSummary: Shows how to read VBA module's attributes.
            var project = new Project(dataDir + "VbaProject1.mpp");
            var vbaProject = project.VbaProject;

            foreach (var module in vbaProject.Modules)
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
