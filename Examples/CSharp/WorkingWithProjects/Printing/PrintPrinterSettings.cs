namespace Aspose.Tasks.Examples.CSharp.WorkingWithProjects.Printing
{
    using System.Drawing.Printing;

    internal class PrintPrinterSettings
    {
        public static void Run()
        {
            var dataDir = RunExamples.GetDataDir(System.Reflection.MethodBase.GetCurrentMethod());

            //ExStart:PrintPrinterSettings
            //ExFor: Project.Print(PrinterSettings)
            //ExSummary: Shows how to use printer settings to print the project.
            var project = new Project(dataDir + "Project2.mpp");

            // Print first two pages
            var settings = new PrinterSettings();
            settings.PrintRange = PrintRange.SomePages;
            settings.FromPage = 1;
            settings.ToPage = 2;

            project.Print(settings);
            //ExEnd:PrintPrinterSettings
        }
    }
}