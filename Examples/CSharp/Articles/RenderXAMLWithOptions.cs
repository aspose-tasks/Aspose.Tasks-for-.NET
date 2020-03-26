/*
This project uses Automatic Package Restore feature of NuGet to resolve Aspose.Tasks for .NET API reference 
when the project is build. Please check https:// Docs.nuget.org/consume/nuget-faq for more information. 
If you do not wish to use NuGet, you can manually download Aspose.Tasks for .NET API from https://www.nuget.org/packages/Aspose.Tasks/, 
install it and then add its reference to this project. For any issues, questions or suggestions 
please feel free to contact us using https://forum.aspose.com/c/tasks
*/

namespace Aspose.Tasks.Examples.CSharp.Articles
{
    using Aspose.Tasks.Saving;
    using Aspose.Tasks.Visualization;

    internal class RenderXAMLWithOptions
    {
        public static void Run()
        {
            var dataDir = RunExamples.GetDataDir(System.Reflection.MethodBase.GetCurrentMethod());

            //ExStart:RenderXAMLWithOptions
            //ExFor: XamlOptions
            //ExSummary: Shows how to save project to XAML file by using <see cref="P:Aspose.Tasks.Saving.XamlOptions" /> options.
            var project = new Project(dataDir + "Project2.mpp");
            SaveOptions options = new XamlOptions();
            options.FitContent = true;
            options.LegendOnEachPage = false;
            options.Timescale = Timescale.ThirdsOfMonths;
            project.Save(dataDir + "RenderXAMLWithOptions_out.xaml", options);
            //ExEnd:RenderXAMLWithOptions
        }
    }
}
