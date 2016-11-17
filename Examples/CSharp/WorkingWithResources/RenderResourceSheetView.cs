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

namespace Aspose.Tasks.Examples.CSharp.WorkingWithResources
{
    class RenderResourceSheetView
    {
        public static void Run()
        {
            // The path to the documents directory.
            string dataDir = RunExamples.GetDataDir(System.Reflection.MethodBase.GetCurrentMethod().DeclaringType.FullName);

            // ExStart:RenderResourceSheetView
            // Create project instance
            Project project1 = new Project(dataDir + "ResourceSheetView.mpp");
            
            // Set the Presentation Format to Resource Sheet
            PresentationFormat format = PresentationFormat.ResourceSheet;

            // Define rendering options
            PdfSaveOptions options = new PdfSaveOptions();
            options.PresentationFormat = format;
            project1.Save(dataDir + "ResourceSheetView_out.pdf", options);
            // ExEnd:RenderResourceSheetView
        }
    }
}
