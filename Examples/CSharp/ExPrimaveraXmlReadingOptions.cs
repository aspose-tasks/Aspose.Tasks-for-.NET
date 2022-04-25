namespace Aspose.Tasks.Examples.CSharp
{
    using System;
    using NUnit.Framework;

    [TestFixture]
    public class ExPrimaveraXmlReadingOptions : ApiExampleBase
    {
        [Test]
        public void ReadXmlFileWithMultipleProjects1()
        {
            // ExStart:ReadXMLFileWithMultipleProjects
            // ExFor: PrimaveraReadOptions
            // ExFor: PrimaveraReadOptions.ProjectUid
            // ExSummary: Shows how to read a project from a Primavera XML or Primavera XER file containing multiple projects.
            var options = new PrimaveraReadOptions();
            options.ProjectUid = 4557;

            // Returns project with special Uid
            var project = new Project(DataDir + "Project.xml", options);
            Console.WriteLine(project.Get(Prj.Name));

            // ExEnd:ReadXMLFileWithMultipleProjects
        }
    }
}