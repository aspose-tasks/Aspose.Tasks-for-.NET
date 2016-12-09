using Aspose.Tasks.Saving;
using Aspose.Tasks.Visualization;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

/*
This project uses Automatic Package Restore feature of NuGet to resolve Aspose.Tasks for .NET API reference 
when the project is build. Please check https:// Docs.nuget.org/consume/nuget-faq for more information. 
If you do not wish to use NuGet, you can manually download Aspose.Tasks for .NET API from http://www.aspose.com/downloads, 
install it and then add its reference to this project. For any issues, questions or suggestions 
please feel free to contact us using http://www.aspose.com/community/forums/default.aspx
*/

namespace Aspose.Tasks.Examples.CSharp.Articles
{
    class RenderProjectToPredefinedPageSizes
    {
        public static void Run()
        {  
            // The path to the documents directory.
            string dataDir = RunExamples.GetDataDir(System.Reflection.MethodBase.GetCurrentMethod().DeclaringType.FullName);

            // ExStart:RenderProjectToPredefinedPageSizes
            // Source File to Render
            string fileName = "Project2.mpp";

            // Read the Project
            Project project1 = new Project(dataDir + fileName);

            // Select a Presentation format
            PresentationFormat format = PresentationFormat.GanttChart;

            // Render the project to all Pre-Defined page sizes
            foreach (PageSize pageSize in (PageSize[])Enum.GetValues(typeof(PageSize)))
            {
                PdfSaveOptions options = new PdfSaveOptions();
                options.PresentationFormat = format;
                options.FitContent = true;
                options.PageSize = pageSize;
                string resultFile = "result_PredefinedPageSizes_" + format.ToString() + "_" + pageSize.ToString() + "_out.pdf";
                project1.Save(dataDir + resultFile, options);
            }
            // ExEnd:RenderProjectToPredefinedPageSizes
        }
    }
}
