/*
This project uses Automatic Package Restore feature of NuGet to resolve Aspose.Tasks for .NET API reference 
when the project is build. Please check https:// Docs.nuget.org/consume/nuget-faq for more information. 
If you do not wish to use NuGet, you can manually download Aspose.Tasks for .NET API from https://www.nuget.org/packages/Aspose.Tasks/, 
install it and then add its reference to this project. For any issues, questions or suggestions 
please feel free to contact us using https://forum.aspose.com/c/tasks
*/

namespace Aspose.Tasks.Examples.CSharp.WorkingWithTasks
{
    using Aspose.Tasks.Saving;
    using Aspose.Tasks.Visualization;

    internal class RenderTaskUsageView
    {
        public static void Run()
        {
            var dataDir = RunExamples.GetDataDir(System.Reflection.MethodBase.GetCurrentMethod().DeclaringType.FullName);

            //ExStart:RenderTaskUsageView
            //ExFor: TaskUsageView
            //ExSummary: Shows how to render task usage view.
            // Create project instance
            var project = new Project(dataDir + "TaskUsageView.mpp");

            // Define the SaveOptions with required TimeScale settings as Days
            SaveOptions options = new PdfSaveOptions();
            options.Timescale = Timescale.Days;
            
            // Set the Presentation format to ResourceUsage
            options.PresentationFormat = PresentationFormat.TaskUsage;
                        
            // Save the Project
            var outputProject = "project_TaskUsageView_result_days_out.pdf";
            project.Save(dataDir + outputProject, options);

            // Set the Timescale settings to ThirdsOfMonths
            options.Timescale = Timescale.ThirdsOfMonths;            
            
            // Save the Project
            outputProject = "project_TaskUsageView_result_thirdsOfMonths_out.pdf";
            project.Save(dataDir + outputProject, options);

            // Set the Timescale settings to Months
            options.Timescale = Timescale.Months;
            
            // Save the project
            outputProject = "project_TaskUsageView_result_months_out.pdf";
            project.Save(dataDir + outputProject, options);
            //ExEnd:RenderTaskUsageView
        }
    }
}
