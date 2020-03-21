/*
This project uses Automatic Package Restore feature of NuGet to resolve Aspose.Tasks for .NET API reference 
when the project is build. Please check https:// Docs.nuget.org/consume/nuget-faq for more information. 
If you do not wish to use NuGet, you can manually download Aspose.Tasks for .NET API from https://www.nuget.org/packages/Aspose.Tasks/, 
install it and then add its reference to this project. For any issues, questions or suggestions 
please feel free to contact us using https://forum.aspose.com/c/tasks
*/

namespace Aspose.Tasks.Examples.CSharp.WorkingWithProjects
{
    using System;

    using Aspose.Tasks.Visualization;

    internal class GetPageCountOnStartAndEndDates
    {
        public static void Run()
        {
            var dataDir = RunExamples.GetDataDir(System.Reflection.MethodBase.GetCurrentMethod().DeclaringType.FullName);
            
            //ExStart: GetPageCountOnStartAndEndDates
            //ExFor: Project.GetPageCount(PageSize,Timescale,DateTime,DateTime)
            //ExSummary: Shows how to get count of pages by page size, timescale, start and finish dates.
            var project = new Project(dataDir + "GetNumberOfPages.mpp");
            var pageCount = project.GetPageCount(
                PageSize.A3,
                Timescale.Months,
                project.Get(Prj.StartDate) - TimeSpan.FromDays(10),
                project.Get(Prj.FinishDate) + TimeSpan.FromDays(30));

            Console.WriteLine(pageCount);
            //ExEnd: GetPageCountOnStartAndEndDates
        }
    }
}
