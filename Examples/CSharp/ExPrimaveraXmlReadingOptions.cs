namespace Aspose.Tasks.Examples.CSharp
{
    using System;
    using NUnit.Framework;

    [TestFixture]
    public class ExPrimaveraXmlReadingOptions : ApiExampleBase
    {
        [Test]
        public void ReadXMLFileWithMultipleProjects1()
        {
            // ExStart:ReadXMLFileWithMultipleProjects
            // ExFor: PrimaveraXmlReadingOptions
            // ExFor: PrimaveraXmlReadingOptions.#ctor
            // ExFor: PrimaveraXmlReadingOptions.ProjectUid
            // ExSummary: Shows how to read a project from a Primavera XML file with multiple projects.
            var options = new PrimaveraXmlReadingOptions();
            options.ProjectUid = 4557;

            // Returns project with special Uid
            var project = new Project(DataDir + "Project.xml", options);
            Console.WriteLine(project.Get(Prj.Name));

            // ExEnd:ReadXMLFileWithMultipleProjects
        }
    }
}