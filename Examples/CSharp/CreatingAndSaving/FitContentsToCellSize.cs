using Aspose.Tasks.Saving;
using Aspose.Tasks.Visualization;

/*
This project uses Automatic Package Restore feature of NuGet to resolve Aspose.Tasks for .NET API reference 
when the project is build. Please check https:// Docs.nuget.org/consume/nuget-faq for more information. 
If you do not wish to use NuGet, you can manually download Aspose.Tasks for .NET API from http://www.aspose.com/downloads, 
install it and then add its reference to this project. For any issues, questions or suggestions 
please feel free to contact us using http://www.aspose.com/community/forums/default.aspx
*/

namespace Aspose.Tasks.Examples.CSharp.CreatingAndSaving
{
    public class FitContentsToCellSize
    {
        public static void Run()
        {
            // ExStart:FitContentsToCellSize
            // The path to the documents directory.
            string dataDir = RunExamples.GetDataDir_CreatingAndSaving();

            Project project = new Project(dataDir + "Project2.mpp");
            SaveOptions saveOptions = new PdfSaveOptions();
            // Set the row height to fit cell content
            saveOptions.FitContent = true;
            saveOptions.Timescale = Timescale.Months;
            saveOptions.PresentationFormat = PresentationFormat.TaskUsage;
            project.Save(dataDir + "FitContentsToCellSize_out.pdf", saveOptions);
            // ExEnd:FitContentsToCellSize
        }
    }
}