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

    internal class PrintProjectUsingCustomPrinter
    {
        public static void Run()
        {
            // The path to the documents directory.
            var dataDir = RunExamples.GetDataDir(System.Reflection.MethodBase.GetCurrentMethod().DeclaringType.FullName);

            //ExStart:PrintProjectUsingCustomPrinter
            //ExFor: Project.Print(String)
            //ExSummary: Shows how to print the project on the selected printer.
            // Read the input Project file
            var project = new Project(dataDir + "Project2.mpp");

            foreach (string printer in PrinterSettings.InstalledPrinters)
            {
                if (!printer.ToUpperInvariant().Contains("Microsoft Print to PDF".ToUpperInvariant()))
                {
                    continue;
                }

                project.Print(printer);
                break;
            }
            //ExEnd:PrintProjectUsingCustomPrinter
        }
    }
}