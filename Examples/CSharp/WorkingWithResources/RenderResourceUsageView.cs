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
    using Aspose.Tasks.Visualization;

    internal class RenderResourceUsageView
    {
        public static void Run()
        {
            var dataDir = RunExamples.GetDataDir(System.Reflection.MethodBase.GetCurrentMethod());

            //ExStart:RenderResourceUsageView
            //ExFor: SaveOptions.Timescale
            //ExFor: SaveOptions.PresentationFormat
            //ExSummary: Shows how to render resource usage view.
            var project = new Project(dataDir + "ResourceUsageView.mpp");
                        
            // Define the SaveOptions with required TimeScale settings as Days
            SaveOptions options = new PdfSaveOptions();
            options.Timescale = Timescale.Days;

            // Set the Presentation format to ResourceUsage
            options.PresentationFormat = PresentationFormat.ResourceUsage;

            // Save the Project
            var outputFile = "result_ResourceUsageView_days_out.pdf";
            project.Save(dataDir + outputFile, options);

            // Set the Timescale settings to ThirdsOfMonths and save the Project
            options.Timescale = Timescale.ThirdsOfMonths;
            outputFile = "result_ResourceUsageView_thirdsOfMonths_out.pdf";
            project.Save(dataDir + outputFile, options);

            // Set the Timescale settings to Months and save the Project
            options.Timescale = Timescale.Months;
            outputFile = "result_ResourceUsageView_months_out.pdf";
            project.Save(dataDir + outputFile, options);
            //ExEnd:RenderResourceUsageView
        }
    }
}
