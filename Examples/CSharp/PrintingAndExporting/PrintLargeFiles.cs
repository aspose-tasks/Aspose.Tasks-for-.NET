using Aspose.Tasks.Saving;
using Aspose.Tasks.Visualization;

namespace Aspose.Tasks.Examples.CSharp.PrintingAndExporting
{
    public class PrintLargeFiles
    {
        public static void Run()
        {
            // ExStart:PrintLargeFiles
            // The path to the documents directory.
            string dataDir = RunExamples.GetDataDir_PrintingAndExporting();

            // Read the input Project file
            Project project = new Project(dataDir + "Project2.mpp"); 
            PrintOptions options = new PrintOptions();
            options.Timescale = Timescale.ThirdsOfMonths;
            if (project.GetPageCount(Timescale.ThirdsOfMonths) <= 280)
                project.Print(options);
            // ExEnd:PrintLargeFiles
        }
    }
}