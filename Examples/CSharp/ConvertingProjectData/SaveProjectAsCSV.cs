/*
This project uses Automatic Package Restore feature of NuGet to resolve Aspose.Tasks for .NET API reference 
when the project is build. Please check https:// Docs.nuget.org/consume/nuget-faq for more information. 
If you do not wish to use NuGet, you can manually download Aspose.Tasks for .NET API from https://www.nuget.org/packages/Aspose.Tasks/, 
install it and then add its reference to this project. For any issues, questions or suggestions 
please feel free to contact us using https://forum.aspose.com/c/tasks
 * 
*/
namespace Aspose.Tasks.Examples.CSharp.ConvertingProjectData
{
    using Aspose.Tasks.Saving;

    internal class SaveProjectAsCSV
    {
        public static void Run()
        {
            var dataDir = RunExamples.GetDataDir(System.Reflection.MethodBase.GetCurrentMethod());

            //ExStart:SaveProjectAsCSV
            //ExFor: SaveFileFormat
            //ExSummary: Shows how to save a project in CSV format.
            var project = new Project(dataDir + "CreateProject1.mpp");
            project.Save(dataDir + "SaveProjectAsCSV_out.csv", SaveFileFormat.CSV);
            //ExEnd:SaveProjectAsCSV
        }
    }
}