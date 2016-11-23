using Aspose.Tasks.Saving;

/*
This project uses Automatic Package Restore feature of NuGet to resolve Aspose.Tasks for .NET API reference 
when the project is build. Please check https:// Docs.nuget.org/consume/nuget-faq for more information. 
If you do not wish to use NuGet, you can manually download Aspose.Tasks for .NET API from http://www.aspose.com/downloads, 
install it and then add its reference to this project. For any issues, questions or suggestions 
please feel free to contact us using http://www.aspose.com/community/forums/default.aspx
*/

namespace Aspose.Tasks.Examples.CSharp.WorkingWithProjects.ImportingAndExporting
{
    public class ExportProjectDataToPrimaveraMPXFormat
    {
        public static void Run()
        {
            // The path to the documents directory.
            string dataDir = RunExamples.GetDataDir(System.Reflection.MethodBase.GetCurrentMethod().DeclaringType.FullName);

            // ExStart:ExportProjectDataToPrimaveraMPXFormat
            Project project = new Project(dataDir + "Project1.mpp");

            // Save project in desired format
            project.Save(dataDir + "ExportProjectDataToPrimaveraMPXFormat_out.xml", SaveFileFormat.MPX);
            // ExEnd:ExportProjectDataToPrimaveraMPXFormat
        }
    }
}