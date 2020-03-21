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

    internal class CreateResources
    {
        public static void Run()
        {
            // The path to the documents directory.
            var dataDir = RunExamples.GetDataDir(System.Reflection.MethodBase.GetCurrentMethod().DeclaringType.FullName);

            //ExStart:CreateResources
            //ExFor: Project.Resources
            //ExSummary: Shows how to create project resources.
            // Create project instance
            var project = new Project();

            // Add resources
            project.Resources.Add("Rsc");

            // Save project as XML
            project.Save(dataDir + "CreateResources_out.xml", SaveFileFormat.XML);
            //ExEnd:CreateResources
        }
    }
}
