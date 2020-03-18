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

    internal class ControlHeaderNameDuringHTMLExport
    {
        public static void Run()
        {
            // The path to the documents directory.
            var dataDir = RunExamples.GetDataDir(System.Reflection.MethodBase.GetCurrentMethod().DeclaringType.FullName);

            //ExStart:ControlHeaderNameDuringHTMLExport
            //ExFor: HtmlSaveOptions.IncludeProjectNameInTitle
            //ExFor: HtmlSaveOptions.IncludeProjectNameInPageHeader
            //ExFor: HtmlSaveOptions.Pages
            //ExSummary: Shows how to set page HTML header/title by using <see cref="P:Aspose.Tasks.Saving.HtmlSaveOptions" /> options.
            var project = new Project(dataDir + "CreateProject2.mpp");
            var options = new HtmlSaveOptions();

            // Determines whether to include project name in HTML title (true by default)
            options.IncludeProjectNameInTitle = false;

            // Determines whether to include project name in HTML page header  (true by default)
            options.IncludeProjectNameInPageHeader = false;
            
            options.Pages = new List<int>();
            options.Pages.Add(1);
            project.Save(dataDir + "ControlHeaderNameDuringHTMLExport_out.html", options);
            //ExEnd:ControlHeaderNameDuringHTMLExport
        }
    }
}
