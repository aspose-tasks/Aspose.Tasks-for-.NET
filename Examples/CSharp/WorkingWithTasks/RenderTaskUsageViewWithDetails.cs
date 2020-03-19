/*
This project uses Automatic Package Restore feature of NuGet to resolve Aspose.Tasks for .NET API reference 
when the project is build. Please check https:// Docs.nuget.org/consume/nuget-faq for more information. 
If you do not wish to use NuGet, you can manually download Aspose.Tasks for .NET API from https://www.nuget.org/packages/Aspose.Tasks/, 
install it and then add its reference to this project. For any issues, questions or suggestions 
please feel free to contact us using https://forum.aspose.com/c/tasks
*/

namespace Aspose.Tasks.Examples.CSharp.WorkingWithTasks
{
    using System.Drawing;

    using Aspose.Tasks.Saving;

    internal class RenderTaskUsageViewWithDetails
    {
        public static void Run()
        {
            var dataDir = RunExamples.GetDataDir(System.Reflection.MethodBase.GetCurrentMethod().DeclaringType.FullName);

            //ExStart:RenderTaskUsageViewWithDetails
            //ExFor: Project.DefaultView
            //ExFor: UsageView.DisplayDetailsHeaderColumn
            //ExFor: UsageView.RepeatDetailsHeaderOnAllRows
            //ExFor: UsageView.AlignDetailsData
            //ExSummary: Shows how to render task usage view with details.
            // Create project instance
            var project = new Project(dataDir + "TaskUsageViewWithDetails.mpp");

            // Get Default view
            UsageView view = (TaskUsageView)project.DefaultView;

            // Details header column will not be displayed
            view.DisplayDetailsHeaderColumn = false;
            view.RepeatDetailsHeaderOnAllRows = false;
            view.AlignDetailsData = StringAlignment.Near;
            project.Save(dataDir + "task usage1_out.pdf", SaveFileFormat.PDF);

            // Display details header column
            view.DisplayDetailsHeaderColumn = true;

            // Repeat details header on all assignments rows
            view.RepeatDetailsHeaderOnAllRows = true;
            view.AlignDetailsData = StringAlignment.Far;
            project.Save(dataDir + "task usage2_out.pdf", SaveFileFormat.PDF);
            //ExEnd:RenderTaskUsageViewWithDetails
        }
    }
}
