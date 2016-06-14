using System.IO;
using Aspose.Tasks;

namespace Aspose.Tasks.Examples.CSharp.WorkingWithProjects
{
    public class GetNumberOfPages
    {
        public static void Run()
        {
            //ExStart: GetNumberOfPages
            // The path to the documents directory.
            string dataDir = RunExamples.GetDataDir_Projects();



            //Read the input Project file
            Project project = new Project(dataDir+ "GetNumberOfPages.mpp");

            //Get number of pages
            int iPages = project.GetPageCount();

            //Get number of pages (Timescale.Months)
            iPages = project.GetPageCount(Aspose.Tasks.Visualization.Timescale.Months);

            //Get number of pages (Timescale.ThirdsOfMonths)
            iPages = project.GetPageCount(Aspose.Tasks.Visualization.Timescale.ThirdsOfMonths);
            //ExEnd: GetNumberOfPages

        }
    }
}