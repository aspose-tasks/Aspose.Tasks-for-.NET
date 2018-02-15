using Aspose.Tasks.Saving;
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

namespace Aspose.Tasks.Examples.CSharp.Articles
{
    class RenderMultipageTIFF
    {
        public static void Run()
        {
            // The path to the documents directory.
            string dataDir = RunExamples.GetDataDir(System.Reflection.MethodBase.GetCurrentMethod().DeclaringType.FullName);

            // ExStart:RenderMultipageTIFF
            // Source file to be converted to TIFF
            string file = "Project2.mpp";
            Project project = new Project(dataDir + file);

            // Save the project to TIFF
            project.Save(dataDir + "RenderMultipageTIFF_out.tif", SaveFileFormat.TIFF);

            // Save the project with CCITT4 compression
            ImageSaveOptions options = new ImageSaveOptions(SaveFileFormat.TIFF);
            options.TiffCompression = TiffCompression.Ccitt4;
            project.Save(dataDir + "RenderMultipageTIFF_options_out.tif", (SaveOptions)options);

            // Remove the compression
            options.TiffCompression = TiffCompression.None;
            project.Save(dataDir + "RenderMultipageTIFF_comp_none_out.tif", (SaveOptions)options);
            // ExEnd:RenderMultipageTIFF
        }
    }
}
