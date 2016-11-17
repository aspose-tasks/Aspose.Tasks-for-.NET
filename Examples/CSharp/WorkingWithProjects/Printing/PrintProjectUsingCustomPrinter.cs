using System.Drawing.Printing;

/*
This project uses Automatic Package Restore feature of NuGet to resolve Aspose.Tasks for .NET API reference 
when the project is build. Please check https:// Docs.nuget.org/consume/nuget-faq for more information. 
If you do not wish to use NuGet, you can manually download Aspose.Tasks for .NET API from http://www.aspose.com/downloads, 
install it and then add its reference to this project. For any issues, questions or suggestions 
please feel free to contact us using http://www.aspose.com/community/forums/default.aspx
*/


namespace Aspose.Tasks.Examples.CSharp.WorkingWithProjects.Printing
{
    public class PrintProjectUsingCustomPrinter
    {
        public static void Run()
        {
            // ExStart:PrintProjectUsingCustomPrinter
            // The path to the documents directory.
            string dataDir = RunExamples.GetDataDir(System.Reflection.MethodBase.GetCurrentMethod().DeclaringType.FullName);

            // Read the input Project file
            Project project = new Project(dataDir + "Project2.mpp");
            string printerName = "Microsoft Print to PDF";

            foreach (string printer in PrinterSettings.InstalledPrinters)
            {
                if (printer.ToUpperInvariant().Contains(printerName.ToUpperInvariant()))
                {
                    project.Print(printer);
                    break;
                }
            }
            // ExEnd:PrintProjectUsingCustomPrinter
        }
    }
}