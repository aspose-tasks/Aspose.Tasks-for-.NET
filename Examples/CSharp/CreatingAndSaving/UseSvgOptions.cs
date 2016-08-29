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
    public class UseSvgOptions
    {
        public static void Run()
        {
            // ExStart:UseSvgOptions

            // The path to the documents directory.
            string dataDir = RunExamples.GetDataDir_CreatingAndSaving();

            // Read the input Project file
            Project project = new Project(dataDir + "Project2.mpp");
            SaveOptions saveOptions = new SvgOptions();
            saveOptions.FitContent = true;
            saveOptions.Timescale = Timescale.ThirdsOfMonths;
            project.Save(dataDir + "UseSvgOptions_out.svg", saveOptions);
            // ExEnd:UseSvgOptions
        }
    }
}