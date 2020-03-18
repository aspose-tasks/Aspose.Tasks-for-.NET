/*
This project uses Automatic Package Restore feature of NuGet to resolve Aspose.Tasks for .NET API reference 
when the project is build. Please check https:// Docs.nuget.org/consume/nuget-faq for more information. 
If you do not wish to use NuGet, you can manually download Aspose.Tasks for .NET API from https://www.nuget.org/packages/Aspose.Tasks/, 
install it and then add its reference to this project. For any issues, questions or suggestions 
please feel free to contact us using https://forum.aspose.com/c/tasks
*/

namespace Aspose.Tasks.Examples.CSharp.Miscellaneous
{
    using Aspose.Tasks.Visualization;

    internal class SaveCashFlowReport
    {
        public static void Run()
        {
            var dataDir = RunExamples.GetDataDir(System.Reflection.MethodBase.GetCurrentMethod().DeclaringType.FullName);

            //ExStart:SaveCashFlowReport
            var project = new Project(dataDir + "OzBuild 16 Orig.mpp");
            project.SaveReport(dataDir + "CashFlow_out.pdf", ReportType.CashFlow);
            //ExEnd:SaveCashFlowReport
        }
    }
}
