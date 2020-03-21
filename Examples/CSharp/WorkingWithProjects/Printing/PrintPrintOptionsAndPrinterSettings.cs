/*
This project uses Automatic Package Restore feature of NuGet to resolve Aspose.Tasks for .NET API reference 
when the project is build. Please check https:// Docs.nuget.org/consume/nuget-faq for more information. 
If you do not wish to use NuGet, you can manually download Aspose.Tasks for .NET API from https://www.nuget.org/packages/Aspose.Tasks/, 
install it and then add its reference to this project. For any issues, questions or suggestions 
please feel free to contact us using https://forum.aspose.com/c/tasks
*/

namespace Aspose.Tasks.Examples.CSharp.WorkingWithProjects.Printing
{
    using System.Drawing.Printing;

    using Aspose.Tasks.Saving;
    using Aspose.Tasks.Visualization;

    internal class PrintPrintOptionsAndPrinterSettings
    {
        public static void Run()
        {
            //ExStart:PrintPrintOptionsAndPrinterSettings
            // The path to the documents directory.
            var dataDir = RunExamples.GetDataDir(System.Reflection.MethodBase.GetCurrentMethod().DeclaringType.FullName);

            // Read the input Project file
            //ExFor: Project.Print(PrinterSettings,PrintOptions)
            //ExFor: PrinterOptions
            //ExFor: PrinterSettings
            //ExFor: PageSettings
            //ExSummary: Shows how to use printer options and settings to print the project.
            var project = new Project(dataDir + "Project2.mpp");

            var options = new PrintOptions();
            options.Timescale = Timescale.Months;

            // Print first two pages
            var settings = new PrinterSettings();
            settings.PrintRange = PrintRange.SomePages;
            settings.FromPage = 1;
            settings.ToPage = 2;

            var pageSettings = settings.DefaultPageSettings;
            pageSettings.PaperSize = new PaperSize(dataDir + "Custom Size", 1000, 700);
            project.Print(settings, options);
            //ExEnd:PrintPrintOptionsAndPrinterSettings
        }
    }
}