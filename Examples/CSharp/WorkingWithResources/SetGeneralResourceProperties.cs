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
            var dataDir = RunExamples.GetDataDir(System.Reflection.MethodBase.GetCurrentMethod());

            //ExStart:SetGeneralResourceProperties
            //ExFor: Rsc.StandardRate
            //ExFor: Rsc.OvertimeRate
            //ExSummary: Shows how to read general resource properties.
            var project = new Project();

            // Add resources
            var resource = project.Resources.Add("Rsc");

            // Set resource properties, Resource properties are represented by static class Rsc
            resource.Set(Rsc.StandardRate, 15);
            resource.Set(Rsc.OvertimeRate, 20);
            //ExEnd:SetGeneralResourceProperties

            // Save project as XML
            project.Save(dataDir + "SetGeneralResourceProperties_out.xml", SaveFileFormat.XML);
        }
    }
}
