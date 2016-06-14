using System.IO;
using Aspose.Tasks;
using System;
using Aspose.Tasks.Visualization;

namespace Aspose.Tasks.Examples.CSharp.WorkingWithProjects
{
    public class GetNumberOfPagesForViews
    {
        public static void Run()
        {
            //ExStart: GetNumberOfPagesForViews
            // The path to the documents directory.
            string dataDir = RunExamples.GetDataDir_Projects();

            //Read the source Project
            Project project = new Project(dataDir+ "GetNumberOfPagesForViews.mpp");


            //Get number of pages
            Console.WriteLine(string.Format("Number of Pages = '{0}'", project.GetPageCount(PresentationFormat.ResourceUsage, Timescale.Days)));

            //Get number of pages (Months)
            Console.WriteLine(string.Format("Number of Pages = '{0}'", project.GetPageCount(PresentationFormat.ResourceUsage, Timescale.Months)));

            //Get number of pages (ThirdsOfMonths)
            Console.WriteLine(string.Format("Number of Pages = '{0}'", project.GetPageCount(PresentationFormat.ResourceUsage, Timescale.ThirdsOfMonths)));
            //ExEnd: GetNumberOfPagesForViews
        }
    }
}