using Aspose.Tasks.Saving;
using Aspose.Tasks.Visualization;
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

namespace Aspose.Tasks.Examples.CSharp.WorkingWithProjects
{
    class GetPageCountOnStartAndEndDates
    {
        public static void Run()
        {
            string dataDir = RunExamples.GetDataDir(System.Reflection.MethodBase.GetCurrentMethod().DeclaringType.FullName);
            //ExStart: GetPageCountOnStartAndEndDates
            Project project = new Project(dataDir + "GetNumberOfPages.mpp");

            var options = new ImageSaveOptions(SaveFileFormat.PNG)
            {
                SaveToSeparateFiles = true,
                PageSize = PageSize.A3,
                Timescale = Timescale.Months,
                StartDate = project.Get(Prj.StartDate) - TimeSpan.FromDays(10),
                EndDate = project.Get(Prj.FinishDate) + TimeSpan.FromDays(30)
            };
            int pageCount = project.GetPageCount(
                PageSize.A3,
                Timescale.Months,
                project.Get(Prj.StartDate) - TimeSpan.FromDays(10),
                project.Get(Prj.FinishDate) + TimeSpan.FromDays(30));

            Console.WriteLine(pageCount);
            //ExEnd: GetPageCountOnStartAndEndDates
        }
    }
}
