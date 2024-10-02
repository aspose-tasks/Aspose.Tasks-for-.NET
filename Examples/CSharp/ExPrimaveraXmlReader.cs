namespace Aspose.Tasks.Examples.CSharp
{
    using System;
    using System.Collections.Generic;
    using System.IO;
    using NUnit.Framework;

    [TestFixture]
    public class ExPrimaveraXmlReader : ApiExampleBase
    {
        [Test]
        public void ReadProjectInfosFromXmlFile()
        {
            // ExStart: ReadProjectInfosFromXmlFile
            // ExFor: PrimaveraXmlReader
            // ExFor: PrimaveraXmlReader.#ctor(String)
            // ExFor: PrimaveraBaseReader.GetProjectInfos
            // ExSummary: Shows how to examine short projects' info from a Primavera XML file.
            var reader = new PrimaveraXmlReader(DataDir + "MultiprojectWithExternal.xml");
            var projectInfos = reader.GetProjectInfos();
            foreach (var info in projectInfos)
            {
                Console.WriteLine("{0} - '{1}' - {2}", info.Uid, info.Name, info.ExportFlag);
            }

            // ExEnd
        }

        [Test]
        public void ReadProjectUidsFromXmlFile()
        {
            // ExStart:ReadProjectUIDsFromXMLFile
            // ExFor: PrimaveraBaseReader.GetProjectUids
            // ExSummary: Shows how to import a project from a Primavera XML file.
            var reader = new PrimaveraXmlReader(DataDir + "primavera.xml");
            List<int> projectUids = reader.GetProjectUids();
            foreach (var projectUid in projectUids)
            {
                Console.WriteLine("Project UID: " + projectUid);
            }

            // ExEnd:ReadProjectUIDsFromXMLFile
        }

        [Test]
        public void ReadLoadPrimaveraXmlProject()
        {
            // ExStart:ReadLoadPrimaveraXmlProject
            // ExFor: PrimaveraBaseReader.LoadProject(int)
            // ExSummary: Shows how to load a project from a Primavera XML file when project uid is known.
            var reader = new PrimaveraXmlReader(DataDir + "PrimaveraProject.xml");
            var project = reader.LoadProject(3882);
            Console.WriteLine(project.Name);
            // ExEnd:ReadLoadPrimaveraXmlProject
        }

        [Test]
        public void ReadProjectUidsFromStream()
        {
            // ExStart:ReadProjectUIDsStream
            // ExFor: PrimaveraXmlReader.#ctor(Stream)
            // ExSummary: Shows how to import a project from a Primavera XML stream.
            using (var stream = new FileStream(DataDir + "primavera.xml", FileMode.Open))
            {
                var reader = new PrimaveraXmlReader(stream);
                List<int> projectUids = reader.GetProjectUids();
                foreach (var projectUid in projectUids)
                {
                    Console.WriteLine("Project UID: " + projectUid);
                }
            }

            // ExEnd:ReadProjectUIDsStream
        }
    }
}