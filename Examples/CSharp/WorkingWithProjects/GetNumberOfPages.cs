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

    internal class GetNumberOfPages
    {
        public static void Run()
        {
            var dataDir = RunExamples.GetDataDir(System.Reflection.MethodBase.GetCurrentMethod());

            //ExStart:GetNumberOfPages
            //ExFor: Project.GetPageCount()
            //ExFor: Project.GetPageCount(Timescale)
            //ExSummary: Shows how to get page count for different timescales.
            // Read the input Project file
            var project = new Project(dataDir + "GetNumberOfPages.mpp");

            // Get number of pages, Timescale.Months, Timescale.ThirdsOfMonths
            var pageCount = project.GetPageCount();
            Console.WriteLine("Page count:" + pageCount);
            pageCount = project.GetPageCount(Timescale.Months);
            Console.WriteLine("Page count (Month):" + pageCount);
            pageCount = project.GetPageCount(Timescale.ThirdsOfMonths);
            Console.WriteLine("Page count (Thirds of Months):" + pageCount);
            //ExEnd:GetNumberOfPages
        }
    }
}