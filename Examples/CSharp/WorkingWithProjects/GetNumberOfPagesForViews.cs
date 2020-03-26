namespace Aspose.Tasks.Examples.CSharp.WorkingWithProjects
{
    using System;

    using Aspose.Tasks.Visualization;

    internal class GetNumberOfPagesForViews
    {
        public static void Run()
        {
            var dataDir = RunExamples.GetDataDir(System.Reflection.MethodBase.GetCurrentMethod());
            
            //ExStart:GetNumberOfPagesForViews
            //ExFor: Project.GetPageCount(PresentationFormat,Timescale)
            //ExSummary: Shows how to get count of pages by presentation format and timescale.
            // Read the source Project
            var project = new Project(dataDir + "GetNumberOfPagesForViews.mpp");

            // Get number of pages,  Months and  ThirdsOfMonths
            Console.WriteLine("Number of Pages = '{0}'", project.GetPageCount(PresentationFormat.ResourceUsage, Timescale.Days));
            Console.WriteLine("Number of Pages = '{0}'", project.GetPageCount(PresentationFormat.ResourceUsage, Timescale.Months));
            Console.WriteLine("Number of Pages = '{0}'", project.GetPageCount(PresentationFormat.ResourceUsage, Timescale.ThirdsOfMonths));
            //ExEnd:GetNumberOfPagesForViews
        }
    }
}