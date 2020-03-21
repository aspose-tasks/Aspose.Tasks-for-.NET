/*
This project uses Automatic Package Restore feature of NuGet to resolve Aspose.Tasks for .NET API reference 
when the project is build. Please check https:// Docs.nuget.org/consume/nuget-faq for more information. 
If you do not wish to use NuGet, you can manually download Aspose.Tasks for .NET API from https://www.nuget.org/packages/Aspose.Tasks/, 
install it and then add its reference to this project. For any issues, questions or suggestions 
please feel free to contact us using https://forum.aspose.com/c/tasks
*/

namespace Aspose.Tasks.Examples.CSharp.WorkingWithProjects.CreatingReadingAndSaving
{
    using Aspose.Tasks.Saving;

    internal class CreateEmptyProjectSaveXML
    {
        public static void Run()
        {            
            // The path to the documents directory.
            var dataDir = RunExamples.GetDataDir(System.Reflection.MethodBase.GetCurrentMethod().DeclaringType.FullName);

            //ExStart:CreateEmptyProjectSaveXML
            //ExFor: Project.Save(string, SaveFileFormat)
            //ExSummary: Shows how to create an empty project and save it into MS Project XML format.
            // Create empty project
            var project = new Project();

            // Save project as xml 
            project.Save(dataDir + "EmptyProjectSaveXML_out.xml", SaveFileFormat.XML);
            //ExEnd:CreateEmptyProjectSaveXML
        }
    }
}