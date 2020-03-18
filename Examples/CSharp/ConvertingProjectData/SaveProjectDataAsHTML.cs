/*
This project uses Automatic Package Restore feature of NuGet to resolve Aspose.Tasks for .NET API reference 
when the project is build. Please check https:// Docs.nuget.org/consume/nuget-faq for more information. 
If you do not wish to use NuGet, you can manually download Aspose.Tasks for .NET API from https://www.nuget.org/packages/Aspose.Tasks/, 
install it and then add its reference to this project. For any issues, questions or suggestions 
please feel free to contact us using https://forum.aspose.com/c/tasks
*/

namespace Aspose.Tasks.Examples.CSharp.ConvertingProjectData
{
    using Aspose.Tasks.Saving;

    public class SaveProjectDataAsHTML
    {
        public static void Run()
        {
            // The path to the documents directory.
            var dataDir = RunExamples.GetDataDir(System.Reflection.MethodBase.GetCurrentMethod().DeclaringType.FullName);

            //ExStart:SaveProjectDataAsHTML
            //ExFor: SaveFileFormat.HTML
            //ExSummary: Shows how to save a project in HTML format.
            var project = new Project(dataDir + "CreateProject2.mpp");
            var option = new HtmlSaveOptions();
            project.Save(dataDir + "SaveProjectDataAsHTML_out.html", option);

            // OR

            // Adding only one page (page number 2)
            option = new HtmlSaveOptions();            
            option.Pages.Add(2); 
            project.Save(dataDir + "SaveProjectDataAsHTML2_out.html", option);
            //ExEnd:SaveProjectDataAsHTML
        }
    }
}