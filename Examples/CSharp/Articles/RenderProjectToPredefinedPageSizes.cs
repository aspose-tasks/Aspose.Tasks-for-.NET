/*
This project uses Automatic Package Restore feature of NuGet to resolve Aspose.Tasks for .NET API reference 
when the project is build. Please check https:// Docs.nuget.org/consume/nuget-faq for more information. 
If you do not wish to use NuGet, you can manually download Aspose.Tasks for .NET API from https://www.nuget.org/packages/Aspose.Tasks/, 
install it and then add its reference to this project. For any issues, questions or suggestions 
please feel free to contact us using https://forum.aspose.com/c/tasks
*/

namespace Aspose.Tasks.Examples.CSharp.Articles
{
    using System;

    using Aspose.Tasks.Saving;
    using Aspose.Tasks.Visualization;

    internal class RenderProjectToPredefinedPageSizes
    {
        public static void Run()
        {  
            // The path to the documents directory.
            var dataDir = RunExamples.GetDataDir(System.Reflection.MethodBase.GetCurrentMethod().DeclaringType.FullName);

            //ExStart:RenderProjectToPredefinedPageSizes
            //ExFor: SaveOptions.PageSize
            //ExSummary: Shows how to set page size (can be one of the values of the <see cref="P:Aspose.Tasks.Visualization.TiffCompression" /> enumeration).
            var project = new Project(dataDir + "Project2.mpp");

            const PresentationFormat Format = PresentationFormat.GanttChart;

            // Render the project to all Pre-Defined page sizes
            foreach (var pageSize in (PageSize[])Enum.GetValues(typeof(PageSize)))
            {
                var options = new PdfSaveOptions();
                options.PresentationFormat = Format;
                options.FitContent = true;
                options.PageSize = pageSize;
                var resultFile = "result_PredefinedPageSizes_" + Format + "_" + pageSize + "_out.pdf";
                project.Save(dataDir + resultFile, options);
            }
            //ExEnd:RenderProjectToPredefinedPageSizes
        }
    }
}
