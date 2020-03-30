/*
This project uses Automatic Package Restore feature of NuGet to resolve Aspose.Tasks for .NET API reference 
when the project is build. Please check https:// Docs.nuget.org/consume/nuget-faq for more information. 
If you do not wish to use NuGet, you can manually download Aspose.Tasks for .NET API from https://www.nuget.org/packages/Aspose.Tasks/, 
install it and then add its reference to this project. For any issues, questions or suggestions 
please feel free to contact us using https://forum.aspose.com/c/tasks
*/

namespace Aspose.Tasks.Examples.CSharp.WorkingWithProjects.ImportingAndExporting
{
    using System;
    using System.IO;

    internal class ImportDataFromXMLFileFormats
    {
        public static void Run()
        {
            var dataDir = RunExamples.GetDataDir(System.Reflection.MethodBase.GetCurrentMethod());

            {
                //ExStart:ImportDataFromXMLFileFormats
                //ExFor: Project.GetProjectFileInfo(String)
                //ExFor: ProjectFileInfo
                //ExFor: ProjectFileInfo.CanRead
                //ExFor: ProjectFileInfo.ProjectFileFormat
                //ExFor: ProjectFileInfo.ProjectApplicationInfo
                //ExSummary: Shows how to read project file info were read from an XML file.
                var info = Project.GetProjectFileInfo(dataDir + "Project.xml");
                Console.WriteLine("CanRead: " + info.CanRead);
                Console.WriteLine("ProjectApplicationInfo: " + info.ProjectApplicationInfo);
                Console.WriteLine("ProjectFileFormat: " + info.ProjectFileFormat);
                //ExEnd:ImportDataFromXMLFileFormats
            }

            {
                //ExStart
                //ExFor: Project.GetProjectFileInfo(Stream)
                //ExFor: ProjectFileInfo.CanRead
                //ExFor: ProjectFileInfo.ProjectFileFormat
                //ExFor: ProjectFileInfo.ProjectApplicationInfo
                //ExSummary: Shows how to read project file info were read from a stream with an XML file.
                using (var stream = new FileStream(dataDir + "Project.xml", FileMode.Open))
                {
                    var info = Project.GetProjectFileInfo(stream);
                    Console.WriteLine("CanRead: " + info.CanRead);
                    Console.WriteLine("ProjectApplicationInfo: " + info.ProjectApplicationInfo);
                    Console.WriteLine("ProjectFileFormat: " + info.ProjectFileFormat);
                }
                //ExEnd
            }
        }
    }
}