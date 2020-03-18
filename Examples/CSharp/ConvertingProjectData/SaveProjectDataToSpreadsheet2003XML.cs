/*
This project uses Automatic Package Restore feature of NuGet to resolve Aspose.Tasks for .NET API reference 
when the project is build. Please check https:// Docs.nuget.org/consume/nuget-faq for more information. 
If you do not wish to use NuGet, you can manually download Aspose.Tasks for .NET API from https://www.nuget.org/packages/Aspose.Tasks/, 
install it and then add its reference to this project. For any issues, questions or suggestions 
please feel free to contact us using https://forum.aspose.com/c/tasks
*/

namespace Aspose.Tasks.Examples.CSharp.ConvertingProjectData
{
    using Aspose.Tasks.Saving;

    public class SaveProjectDataToSpreadsheet2003XML
    {
        public static void Run()
        {
            // The path to the documents directory.
            var dataDir = RunExamples.GetDataDir(System.Reflection.MethodBase.GetCurrentMethod().DeclaringType.FullName);

            //ExStart:SaveProjectDataToSpreadsheet2003XML
            //ExFor: SaveFileFormat.Spreadsheet2003
            //ExSummary: Shows how to save project as Spreadsheet2003 file.
            var project = new Project(dataDir + "CreateProject2.mpp");
            project.Save(dataDir + "SaveProjectDataToSpreadsheet2003XML_out.xml", SaveFileFormat.Spreadsheet2003);
            //ExEnd:SaveProjectDataToSpreadsheet2003XML
        }
    }
}