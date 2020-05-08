namespace Aspose.Tasks.Examples.CSharp
{
    using System;
    using NUnit.Framework;

    [TestFixture]
    public class ExProjectFileFormat : ApiExampleBase
    {
        [Test]
        public void ReadProjectFileFormat()
        {
            // ExStart:ReadProjectFileFormat
            // ExFor: FileFormat
            // ExSummary: Shows how to read check project file format.
            var info = Project.GetProjectFileInfo(DataDir + "Project.xml");
            Console.WriteLine("CanRead: " + info.CanRead);
            Console.WriteLine("ProjectApplicationInfo: " + info.ProjectApplicationInfo);
            Console.WriteLine("ProjectFileFormat: " + info.ProjectFileFormat);

            // ExEnd:ReadProjectFileFormat
        }
    }
}