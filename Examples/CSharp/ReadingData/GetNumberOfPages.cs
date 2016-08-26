using Aspose.Tasks.Visualization;

namespace Aspose.Tasks.Examples.CSharp.ReadingData
{
    public class GetNumberOfPages
    {
        public static void Run()
        {
            // ExStart:GetNumberOfPages
            // The path to the documents directory.
            string dataDir = RunExamples.GetDataDir_ReadingData();

            // Read the input Project file
            Project project = new Project(dataDir + "GetNumberOfPages.mpp");

            // Get number of pages,  Timescale.Months, Timescale.ThirdsOfMonths
            int iPages = project.GetPageCount();
            iPages = project.GetPageCount(Timescale.Months);
            iPages = project.GetPageCount(Timescale.ThirdsOfMonths);
            // ExEnd:GetNumberOfPages

        }
    }
}