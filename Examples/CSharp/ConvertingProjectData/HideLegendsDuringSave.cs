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

    internal class HideLegendsDuringSave
    {
        public static void Run()
        {
            var dataDir = RunExamples.GetDataDir(System.Reflection.MethodBase.GetCurrentMethod());
                        
            //ExStart:HideLegendsDuringSave
            //ExFor: SaveOptions.LegendOnEachPage
            //ExSummary: Shows how to hide page legends.
            var project = new Project(dataDir + "CreateProject2.mpp");
            SaveOptions options = new PdfSaveOptions();

            // Set the LegendOnEachPage property to false to hide legends
            options.LegendOnEachPage = false;

            project.Save(dataDir + "HideLegendsDuringSave_out.pdf", options);
            //ExEnd:HideLegendsDuringSave
        }
    }
}
