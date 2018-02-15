using Aspose.Tasks.Saving;
using Aspose.Tasks.Visualization;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

/*
This project uses Automatic Package Restore feature of NuGet to resolve Aspose.Tasks for .NET API reference 
when the project is build. Please check https:// Docs.nuget.org/consume/nuget-faq for more information. 
If you do not wish to use NuGet, you can manually download Aspose.Tasks for .NET API from https://www.nuget.org/packages/Aspose.Tasks/, 
install it and then add its reference to this project. For any issues, questions or suggestions 
please feel free to contact us using https://forum.aspose.com/c/tasks
*/

namespace Aspose.Tasks.Examples.CSharp.WorkingWithResources
{
    class RenderResourceUsageView
    {
        public static void Run()
        {
            // The path to the documents directory.
            string dataDir = RunExamples.GetDataDir(System.Reflection.MethodBase.GetCurrentMethod().DeclaringType.FullName);

            // ExStart:RenderResourceUsageView
            // Create project instance
            Project project1 = new Project(dataDir + "ResourceUsageView.mpp");
                        
            // Define the SaveOptions with required TimeScale settings as Days
            SaveOptions options = new PdfSaveOptions();
            options.Timescale = Timescale.Days;

            // Set the Presentation format to ResourceUsage
            options.PresentationFormat = PresentationFormat.ResourceUsage;

            // Save the Project
            string outputFile = "result_ResourceUsageView_days_out.pdf";
            project1.Save(dataDir + outputFile, options);

            // Set the Tiemscale settings to ThirdsOfMonths and save the Project
            options.Timescale = Timescale.ThirdsOfMonths;
            outputFile = "result_ResourceUsageView_thirdsOfMonths_out.pdf";
            project1.Save(dataDir + outputFile, options);

            // Set the Timescale settings to Months and save the Project
            options.Timescale = Timescale.Months;
            outputFile = "result_ResourceUsageView_months_out.pdf";
            project1.Save(dataDir + outputFile, options);
            // ExEnd:RenderResourceUsageView
        }
    }
}
