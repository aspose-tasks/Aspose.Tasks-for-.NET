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
 * 
*/
namespace Aspose.Tasks.Examples.CSharp.ConvertingProjectData
{
    class SaveProjectAsJPEG
    {
        public static void Run()
        {
            string dataDir = RunExamples.GetDataDir(System.Reflection.MethodBase.GetCurrentMethod().DeclaringType.FullName);
			//ExStart: SaveProjectAsJPEG
            Project project = new Project(dataDir + "CreateProject2.mpp");

            // in order to manipulate JPEG quality one can use ImageSaveOptions.JpegQuality property.
            // The allowed value range is 0..100.
            var options = new ImageSaveOptions(SaveFileFormat.JPEG) { JpegQuality = 50 };

            project.Save(dataDir + "image_out.jpeg", (SaveOptions)options);
			//ExEnd: SaveProjectAsJPEG
        }
    }
}
