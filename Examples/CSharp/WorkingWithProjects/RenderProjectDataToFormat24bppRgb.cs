using System.Drawing.Imaging;
using Aspose.Tasks.Saving;

/*
This project uses Automatic Package Restore feature of NuGet to resolve Aspose.Tasks for .NET API reference 
when the project is build. Please check https:// Docs.nuget.org/consume/nuget-faq for more information. 
If you do not wish to use NuGet, you can manually download Aspose.Tasks for .NET API from http://www.aspose.com/downloads, 
install it and then add its reference to this project. For any issues, questions or suggestions 
please feel free to contact us using http://www.aspose.com/community/forums/default.aspx
*/

namespace Aspose.Tasks.Examples.CSharp.WorkingWithProjects
{
    public class RenderProjectDataToFormat24bppRgb
    {
        public static void Run()
        {
            // ExStart:RenderProjectDataToFormat24bppRgb
            // The path to the documents directory.
            string dataDir = RunExamples.GetDataDir(System.Reflection.MethodBase.GetCurrentMethod().DeclaringType.FullName);
            Project project = new Project(dataDir + "TestProject1.mpp");
            ImageSaveOptions options = new ImageSaveOptions(SaveFileFormat.TIFF);
            options.HorizontalResolution = 72;
            options.VerticalResolution = 72;
            options.PixelFormat = PixelFormat.Format24bppRgb;
            project.Save(dataDir + "RenderProjectDataToFormat24bppRgb_out.tif", options);
            // ExEnd:RenderProjectDataToFormat24bppRgb
        }
    }
}