using Aspose.Tasks.Saving;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;

/*
This project uses Automatic Package Restore feature of NuGet to resolve Aspose.Tasks for .NET API reference 
when the project is build. Please check https:// Docs.nuget.org/consume/nuget-faq for more information. 
If you do not wish to use NuGet, you can manually download Aspose.Tasks for .NET API from http://www.aspose.com/downloads, 
install it and then add its reference to this project. For any issues, questions or suggestions 
please feel free to contact us using http://www.aspose.com/community/forums/default.aspx
*/

namespace Aspose.Tasks.Examples.CSharp.WorkingWithTasks
{
    class RenderTaskUsageViewWithDetails
    {
        public static void Run()
        {
            // ExStart:RenderTaskUsageViewWithDetails
            // Create project instance
            string dataDir = RunExamples.GetDataDir(System.Reflection.MethodBase.GetCurrentMethod().DeclaringType);
            Project project1 = new Project(dataDir + "project.mpp");

            // Get Default view
            UsageView view = project1.DefaultView as TaskUsageView;

            // Details header column will not be displayed
            view.DisplayDetailsHeaderColumn = false;
            view.RepeatDetailsHeaderOnAllRows = false;
            view.AlignDetailsData = StringAlignment.Near;
            project1.Save(dataDir + "task usage1_out.pdf", SaveFileFormat.PDF);

            // Display details header column
            view.DisplayDetailsHeaderColumn = true;

            // Repeat details header on all assignments rows
            view.RepeatDetailsHeaderOnAllRows = true;
            view.AlignDetailsData = StringAlignment.Far;
            project1.Save(dataDir + "task usage2_out.pdf", SaveFileFormat.PDF);
            // ExEnd:RenderTaskUsageViewWithDetails
        }
    }
}
