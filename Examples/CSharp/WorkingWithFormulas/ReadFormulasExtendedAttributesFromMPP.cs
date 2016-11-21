using System;

/*
This project uses Automatic Package Restore feature of NuGet to resolve Aspose.Tasks for .NET API reference 
when the project is build. Please check https:// Docs.nuget.org/consume/nuget-faq for more information. 
If you do not wish to use NuGet, you can manually download Aspose.Tasks for .NET API from http://www.aspose.com/downloads, 
install it and then add its reference to this project. For any issues, questions or suggestions 
please feel free to contact us using http://www.aspose.com/community/forums/default.aspx
*/

namespace Aspose.Tasks.Examples.CSharp.WorkingWithFormulas
{
    public class ReadFormulasExtendedAttributesFromMPP
    {
        public static void Run()
        {
            // ExStart:ReadFormulasExtendedAttributesFromMPP
            // The path to the documents directory.
            // Create project instance
            string dataDir = RunExamples.GetDataDir(System.Reflection.MethodBase.GetCurrentMethod().DeclaringType.FullName);
            Project project1 = new Project(dataDir + "ReadFormulas.mpp"); // attached test mpp
           
            // Read extended attribute formula
            ExtendedAttributeDefinition attr = project1.ExtendedAttributes[0];
            Console.WriteLine("Attribute Formula: " + attr.Formula);
            // ExEnd:ReadFormulasExtendedAttributesFromMPP
        }
    }
}