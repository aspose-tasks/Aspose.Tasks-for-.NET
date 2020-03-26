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
    using System.Collections.Generic;

    internal class ReadProjectUIDsFromXMLFile
    {
        public static void Run()
        {
            var dataDir = RunExamples.GetDataDir(System.Reflection.MethodBase.GetCurrentMethod());

            //ExStart:ReadProjectUIDsFromXMLFile
            //ExFor: PrimaveraXmlReader.#ctor(String)
            //ExFor: PrimaveraXmlReader.GetProjectUids
            //ExSummary: Shows how to import a project from a Primavera XML file.
            var reader = new PrimaveraXmlReader(dataDir + "primavera.xml");
            List<int> projectUids = reader.GetProjectUids();
            foreach (var projectUid in projectUids)
            {
                Console.WriteLine("Project UID: " + projectUid);
            }
            //ExEnd:ReadProjectUIDsFromXMLFile
        }
    }
}