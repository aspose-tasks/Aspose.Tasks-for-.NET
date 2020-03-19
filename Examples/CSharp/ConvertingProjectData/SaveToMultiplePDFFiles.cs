/*
This project uses Automatic Package Restore feature of NuGet to resolve Aspose.Tasks for .NET API reference 
when the project is build. Please check https:// Docs.nuget.org/consume/nuget-faq for more information. 
If you do not wish to use NuGet, you can manually download Aspose.Tasks for .NET API from https://www.nuget.org/packages/Aspose.Tasks/, 
install it and then add its reference to this project. For any issues, questions or suggestions 
please feel free to contact us using https://forum.aspose.com/c/tasks
*/

namespace Aspose.Tasks.Examples.CSharp.ConvertingProjectData
{
    using System.Collections.Generic;

    using Aspose.Tasks.Saving;

    internal class SaveToMultiplePDFFiles
    {
        public static void Run()
        {
            // The path to the documents directory.
            var dataDir = RunExamples.GetDataDir(System.Reflection.MethodBase.GetCurrentMethod().DeclaringType.FullName);

            //ExStart:SaveToMultiplePDFFiles
            //ExFor: PdfSaveOptions
            //ExFor: PdfSaveOptions.SaveToSeparateFiles
            //ExFor: PdfSaveOptions.Pages
            //ExSummary: Shows how to save selected pages of a project into PDF file. 
            var project = new Project(dataDir + "Software Development Plan.mpp");
            var saveOptions = new PdfSaveOptions();
            saveOptions.SaveToSeparateFiles = true;
            saveOptions.Pages = new List<int>();
            saveOptions.Pages.Add(1);
            saveOptions.Pages.Add(4);
            project.Save(dataDir + "SaveToMultiplePDFFiles_out.pdf", saveOptions);
            //ExEnd:SaveToMultiplePDFFiles
        }
    }
}