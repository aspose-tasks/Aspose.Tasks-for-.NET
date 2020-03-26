/*
This project uses Automatic Package Restore feature of NuGet to resolve Aspose.Tasks for .NET API reference 
when the project is build. Please check https:// Docs.nuget.org/consume/nuget-faq for more information. 
If you do not wish to use NuGet, you can manually download Aspose.Tasks for .NET API from https://www.nuget.org/packages/Aspose.Tasks/, 
install it and then add its reference to this project. For any issues, questions or suggestions 
please feel free to contact us using https://forum.aspose.com/c/tasks
*/

namespace Aspose.Tasks.Examples.CSharp.WorkingWithFormulas
{
    using System;

    internal class ReadFormulasExtendedAttributesFromMPP
    {
        public static void Run()
        {
            var dataDir = RunExamples.GetDataDir(System.Reflection.MethodBase.GetCurrentMethod());

            //ExStart:ReadFormulasExtendedAttributesFromMPP
            //ExFor: ExtendedAttributeDefinition.Formula
            //ExSummary: Shows how to read extended attribute formulas.
            var project = new Project(dataDir + "ReadFormulas.mpp"); // Attached test mpp
           
            // Read extended attribute formula
            var attribute = project.ExtendedAttributes[0];
            Console.WriteLine("Attribute Formula: " + attribute.Formula);
            //ExEnd:ReadFormulasExtendedAttributesFromMPP
        }
    }
}