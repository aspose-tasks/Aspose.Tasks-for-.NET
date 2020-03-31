namespace Aspose.Tasks.Examples.CSharp
{
    using System;
    using System.Collections.Generic;
    using NUnit.Framework;

    [TestFixture]
    public class ExPrimaveraXmlReader : ApiExampleBase
    {
        [Test]
        public void ReadProjectUIDsFromXMLFile()
        {
            //ExStart:ReadProjectUIDsFromXMLFile
            //ExFor: PrimaveraXmlReader.#ctor(String)
            //ExFor: PrimaveraXmlReader.GetProjectUids
            //ExSummary: Shows how to import a project from a Primavera XML file.
            var reader = new PrimaveraXmlReader(DataDir + "primavera.xml");
            List<int> projectUids = reader.GetProjectUids();
            foreach (var projectUid in projectUids)
            {
                Console.WriteLine("Project UID: " + projectUid);
            }
            //ExEnd:ReadProjectUIDsFromXMLFile
        }
    }
}