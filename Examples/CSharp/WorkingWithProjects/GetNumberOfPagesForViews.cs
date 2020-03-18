namespace Aspose.Tasks.Examples.CSharp.WorkingWithProjects
{
    using System;

    using Aspose.Tasks.Visualization;

    public class GetNumberOfPagesForViews
    {
        public static void Run()
        {
            //ExStart:GetNumberOfPagesForViews
            // The path to the documents directory.
            var dataDir = RunExamples.GetDataDir(System.Reflection.MethodBase.GetCurrentMethod().DeclaringType.FullName);

            // Read the source Project
            var project = new Project(dataDir + "GetNumberOfPagesForViews.mpp");

            // Get number of pages,  Months and  ThirdsOfMonths
            Console.WriteLine("Number of Pages = '{0}'", project.GetPageCount(PresentationFormat.ResourceUsage, Timescale.Days));
            Console.WriteLine("Number of Pages = '{0}'", project.GetPageCount(PresentationFormat.ResourceUsage, Timescale.Months));
            Console.WriteLine($"Number of Pages = '{project.GetPageCount(PresentationFormat.ResourceUsage, Timescale.ThirdsOfMonths)}'");
            //ExEnd:GetNumberOfPagesForViews
        }
    }
}