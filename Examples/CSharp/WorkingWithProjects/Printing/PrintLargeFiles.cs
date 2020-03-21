namespace Aspose.Tasks.Examples.CSharp.WorkingWithProjects.Printing
{
    using Aspose.Tasks.Saving;
    using Aspose.Tasks.Visualization;

    internal class PrintLargeFiles
    {
        public static void Run()
        {
            // The path to the documents directory.
            var dataDir = RunExamples.GetDataDir(System.Reflection.MethodBase.GetCurrentMethod().DeclaringType.FullName);

            //ExStart:PrintLargeFiles
            //ExFor: PrintOptions
            //ExFor: Project.Print(PrintOptions)
            //ExSummary: Shows how to use print options.
            // Read the input Project file
            var project = new Project(dataDir + "Project2.mpp");
 
            var options = new PrintOptions();
            options.Timescale = Timescale.ThirdsOfMonths;
            if (project.GetPageCount(Timescale.ThirdsOfMonths) <= 280)
            {
                project.Print(options);
            }
            //ExEnd:PrintLargeFiles
        }
    }
}