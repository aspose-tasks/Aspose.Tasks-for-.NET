/*
This project uses Automatic Package Restore feature of NuGet to resolve Aspose.Tasks for .NET API reference 
when the project is build. Please check https:// Docs.nuget.org/consume/nuget-faq for more information. 
If you do not wish to use NuGet, you can manually download Aspose.Tasks for .NET API from https://www.nuget.org/packages/Aspose.Tasks/, 
install it and then add its reference to this project. For any issues, questions or suggestions 
please feel free to contact us using https://forum.aspose.com/c/tasks
*/

namespace Aspose.Tasks.Examples.CSharp.WorkingWithProjects.CreatingReadingAndSaving
{
    using System;

    using Aspose.Tasks.Connectivity;

    internal class ImportProjectDataFromMPDFile
    {
        public static void Run()
        {
            // The path to the documents directory.
            var dataDir = RunExamples.GetDataDir(System.Reflection.MethodBase.GetCurrentMethod().DeclaringType.FullName);
            
            //ExStart:ImportProjectDataFromMPDFile
            //ExFor: MpdSettings
            //ExFor: Project(DbSettings)
            //ExSummary: Shows how to read a project from an MPD file.
            DbSettings settings = new MpdSettings("Provider=Microsoft.Jet.OLEDB.4.0; Data Source=" + dataDir + "MpdFileToRead.mpd", 1);
            var project = new Project(settings);            
            Console.WriteLine(project.Get(Prj.Name));
            //ExEnd:ImportProjectDataFromMPDFile
        }
    }
}