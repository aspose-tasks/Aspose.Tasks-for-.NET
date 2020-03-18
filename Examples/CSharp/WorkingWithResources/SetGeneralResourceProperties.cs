/*
This project uses Automatic Package Restore feature of NuGet to resolve Aspose.Tasks for .NET API reference 
when the project is build. Please check https:// Docs.nuget.org/consume/nuget-faq for more information. 
If you do not wish to use NuGet, you can manually download Aspose.Tasks for .NET API from https://www.nuget.org/packages/Aspose.Tasks/, 
install it and then add its reference to this project. For any issues, questions or suggestions 
please feel free to contact us using https://forum.aspose.com/c/tasks
*/

namespace Aspose.Tasks.Examples.CSharp.WorkingWithResources
{
    using Aspose.Tasks.Saving;

    internal class SetGeneralResourceProperties
    {
        public static void Run()
        {
            // The path to the documents directory.
            var dataDir = RunExamples.GetDataDir(System.Reflection.MethodBase.GetCurrentMethod().DeclaringType.FullName);

            //ExStart:SetGeneralResourceProperties
            // Create project instance
            var project = new Project();

            // Add resources
            var rsc1 = project.Resources.Add("Rsc");

            // Set resource properties, Resource properties are represented by static class Rsc
            rsc1.Set(Rsc.StandardRate, 15);
            rsc1.Set(Rsc.OvertimeRate, 20);
            //ExEnd:SetGeneralResourceProperties

            // Save project as XML
            project.Save(dataDir + "SetGeneralResourceProperties_out.xml", SaveFileFormat.XML);
        }
    }
}
