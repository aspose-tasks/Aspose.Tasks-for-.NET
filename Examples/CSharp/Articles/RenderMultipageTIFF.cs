/*
This project uses Automatic Package Restore feature of NuGet to resolve Aspose.Tasks for .NET API reference 
when the project is build. Please check https:// Docs.nuget.org/consume/nuget-faq for more information. 
If you do not wish to use NuGet, you can manually download Aspose.Tasks for .NET API from https://www.nuget.org/packages/Aspose.Tasks/, 
install it and then add its reference to this project. For any issues, questions or suggestions 
please feel free to contact us using https://forum.aspose.com/c/tasks
*/

namespace Aspose.Tasks.Examples.CSharp.Articles
{
    using Aspose.Tasks.Saving;

    internal class RenderMultipageTIFF
    {
        public static void Run()
        {
            // The path to the documents directory.
            var dataDir = RunExamples.GetDataDir(System.Reflection.MethodBase.GetCurrentMethod().DeclaringType.FullName);

            //ExStart:RenderMultipageTIFF
            //ExFor: SaveFileFormat
            //ExFor: TiffCompression
            //ExSummary: Shows how to set TIFF compression mode (can be one of the values of the <see cref="P:Aspose.Tasks.Saving.PageSize" /> enumeration).
            var project = new Project(dataDir + "Project2.mpp");

            // Save the project to TIFF
            project.Save(dataDir + "RenderMultipageTIFF_out.tif", SaveFileFormat.TIFF);

            // Save the project with Rle compression
            var options = new ImageSaveOptions(SaveFileFormat.TIFF);
            options.TiffCompression = TiffCompression.Rle;
            project.Save(dataDir + "RenderMultipageTIFF_comp_rle_out.tif", options);
            
            // Save the project with CCITT3 compression
            options.TiffCompression = TiffCompression.Ccitt3;
            project.Save(dataDir + "RenderMultipageTIFF_comp_rle_out.tif", options);
            
            // Save the project with CCITT4 compression
            options.TiffCompression = TiffCompression.Ccitt4;
            project.Save(dataDir + "RenderMultipageTIFF_comp_ccitt4_out.tif", options);
            
            // Save the project with CCITT4 compression
            options.TiffCompression = TiffCompression.Lzw;
            project.Save(dataDir + "RenderMultipageTIFF_comp_lzw_out.tif", options);

            // Remove the compression
            options.TiffCompression = TiffCompression.None;
            project.Save(dataDir + "RenderMultipageTIFF_comp_none_out.tif", options);
            //ExEnd:RenderMultipageTIFF
        }
    }
}
