/*
This project uses Automatic Package Restore feature of NuGet to resolve Aspose.Tasks for .NET API reference 
when the project is build. Please check https:// Docs.nuget.org/consume/nuget-faq for more information. 
If you do not wish to use NuGet, you can manually download Aspose.Tasks for .NET API from https://www.nuget.org/packages/Aspose.Tasks/, 
install it and then add its reference to this project. For any issues, questions or suggestions 
please feel free to contact us using https://forum.aspose.com/c/tasks
*/

namespace Aspose.Tasks.Examples.CSharp.Miscellaneous
{
    using System.IO;

    internal class SaveProjectOverviewReport
    {
        public static void Run()
        {
            var dataDir = RunExamples.GetDataDir(System.Reflection.MethodBase.GetCurrentMethod());

            //ExStart:SaveProjectOverviewReport
            //ExFor: Project.SaveReport(String)
            //ExFor: Project.SaveReport(Stream)
            //ExSummary: Shows how to save the project overview report to PDF file.
            var project = new Project(dataDir + "Cyclic stucture.mpp");
            
            // one can save the overview report to PDF file to the specified path
            project.SaveReport(dataDir + "ProjectOverView_out.pdf");
            
            // or save the overview report to PDF file to the specified stream.
            using (var stream = new FileStream(dataDir + "ProjectOverView2_out.pdf", FileMode.Create))
            {
                project.SaveReport(stream);
            }
            //ExEnd:SaveProjectOverviewReport
        }
    }
}
