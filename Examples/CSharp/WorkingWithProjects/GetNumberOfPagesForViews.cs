using System;
using Aspose.Tasks.Visualization;

namespace Aspose.Tasks.Examples.CSharp.WorkingWithProjects
{
    public class GetNumberOfPagesForViews
    {
        public static void Run()
        {
            // ExStart:GetNumberOfPagesForViews
            // The path to the documents directory.
            string dataDir = RunExamples.GetDataDir(System.Reflection.MethodBase.GetCurrentMethod().DeclaringType);

            // Read the source Project
            Project project = new Project(dataDir + "GetNumberOfPagesForViews.mpp");

            // Get number of pages,  Months and  ThirdsOfMonths
            Console.WriteLine(string.Format("Number of Pages = '{0}'", project.GetPageCount(PresentationFormat.ResourceUsage, Timescale.Days)));
            Console.WriteLine(string.Format("Number of Pages = '{0}'", project.GetPageCount(PresentationFormat.ResourceUsage, Timescale.Months)));
            Console.WriteLine(string.Format("Number of Pages = '{0}'", project.GetPageCount(PresentationFormat.ResourceUsage, Timescale.ThirdsOfMonths)));
            // ExEnd:GetNumberOfPagesForViews
        }
    }
}