using System.Drawing.Printing;
using Aspose.Tasks.Saving;
using Aspose.Tasks.Visualization;

/*
This project uses Automatic Package Restore feature of NuGet to resolve Aspose.Tasks for .NET API reference 
when the project is build. Please check https:// Docs.nuget.org/consume/nuget-faq for more information. 
If you do not wish to use NuGet, you can manually download Aspose.Tasks for .NET API from http://www.aspose.com/downloads, 
install it and then add its reference to this project. For any issues, questions or suggestions 
please feel free to contact us using http://www.aspose.com/community/forums/default.aspx
*/

namespace Aspose.Tasks.Examples.CSharp.PrintingAndExporting
{
    public class PrintPrintOptionsAndPrinterSettings
    {
        public static void Run()
        {
            // ExStart:PrintPrintOptionsAndPrinterSettings

            // The path to the documents directory.
            string dataDir = RunExamples.GetDataDir_PrintingAndExporting();

            // Read the input Project file
            Project project = new Project(dataDir + "ST_AV_AF_DEV_AFT_EMP.mpp");

            PrintOptions options = new PrintOptions();
            options.Timescale = Timescale.Months;

            // Print first ten pages
            PrinterSettings printerSettings = new PrinterSettings();
            printerSettings.PrintRange = PrintRange.SomePages;
            printerSettings.FromPage = 1;
            printerSettings.ToPage = 10;

            System.Drawing.Printing.PageSettings pageSettings = printerSettings.DefaultPageSettings;
            pageSettings.PaperSize = new PaperSize(dataDir+ "Custom Size", 1000, 700);
            project.Print(printerSettings, options);
            // ExEnd:PrintPrintOptionsAndPrinterSettings
        }
    }
}