namespace Aspose.Tasks.Examples.CSharp
{
    using System;
    using NUnit.Framework;

    [TestFixture]
    public class ExPrimaveraXerReader : ApiExampleBase
    {
        [Test]
        public void ReadProjectInfosFromXerFile()
        {
            // ExStart: ReadProjectInfosFromXmlFile
            // ExFor: PrimaveraXerReader
            // ExFor: PrimaveraXerReader.#ctor(String)
            // ExFor: PrimaveraBaseReader.GetProjectInfos
            // ExFor: PrimaveraBaseReader.LoadProject(int)
            // ExSummary: Shows how to examine short projects' info from a Primavera XER file.
            var reader = new PrimaveraXerReader(DataDir + "MultiprojectWithExternal.xer");
            var projectInfos = reader.GetProjectInfos();
            foreach (var info in projectInfos)
            {
                Console.WriteLine("{0} - '{1}' - {2}", info.Uid, info.Name, info.ExportFlag);
            }

            var project = reader.LoadProject(5494);

            Console.WriteLine("Loaded project '{0}' with Uid {1}", project.Name, project.Uid);

            // ExEnd
        }
    }
}