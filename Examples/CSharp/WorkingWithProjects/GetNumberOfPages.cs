using Aspose.Tasks.Visualization;

/*
This project uses Automatic Package Restore feature of NuGet to resolve Aspose.Tasks for .NET API reference 
when the project is build. Please check https:// Docs.nuget.org/consume/nuget-faq for more information. 
If you do not wish to use NuGet, you can manually download Aspose.Tasks for .NET API from https://www.nuget.org/packages/Aspose.Tasks/, 
install it and then add its reference to this project. For any issues, questions or suggestions 
please feel free to contact us using https://forum.aspose.com/c/tasks
*/

namespace Aspose.Tasks.Examples.CSharp.WorkingWithProjects
{
    public class GetNumberOfPages
    {
        public static void Run()
        {
            //ExStart:GetNumberOfPages
            // The path to the documents directory.
            string dataDir = RunExamples.GetDataDir(System.Reflection.MethodBase.GetCurrentMethod().DeclaringType.FullName);

            // Read the input Project file
            Project project = new Project(dataDir + "GetNumberOfPages.mpp");

            // Get number of pages,  Timescale.Months, Timescale.ThirdsOfMonths
            int pageCount = project.GetPageCount();
            pageCount = project.GetPageCount(Timescale.Months);
            pageCount = project.GetPageCount(Timescale.ThirdsOfMonths);
            //ExEnd:GetNumberOfPages

        }
    }
}