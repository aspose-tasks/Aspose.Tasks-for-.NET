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
 * 
*/
namespace Aspose.Tasks.Examples.CSharp.ConvertingProjectData
{
    class AddDefaultFontDuringSavingAsPDF
    {
        public static void Run()
        {
            string dataDir = RunExamples.GetDataDir(System.Reflection.MethodBase.GetCurrentMethod().DeclaringType.FullName);

            //ExStart: AddDefaultFontDuringSavingAsPDF
            Project project = new Project(dataDir + "CreateProject2.mpp");

            var options = new PdfSaveOptions
            {
                PresentationFormat = PresentationFormat.GanttChart,
                FitContent = true,
                UseProjectDefaultFont = false,
                DefaultFontName = "Segoe UI Black"
            };
            project.Save(dataDir + "CreateProject2_out.pdf", options);
            //ExEnd: AddDefaultFontDuringSavingAsPDF
        }
    }
}
