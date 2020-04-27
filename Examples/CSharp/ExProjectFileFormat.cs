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
            // ExFor: FileFormat.HTML
            // ExFor: FileFormat.MPP12
            // ExFor: FileFormat.MPP14
            // ExFor: FileFormat.MPP8
            // ExFor: FileFormat.MPP9
            // ExFor: FileFormat.MPT12
            // ExFor: FileFormat.MPT14
            // ExFor: FileFormat.MPT9
            // ExFor: FileFormat.MPX
            // ExFor: FileFormat.P6XML
            // ExFor: FileFormat.Undefined
            // ExFor: FileFormat.XER
            // ExFor: FileFormat.XML
            // ExSummary: Shows how to read check project file format.
            var info = Project.GetProjectFileInfo(DataDir + "Project.xml");
            Console.WriteLine("CanRead: " + info.CanRead);
            Console.WriteLine("ProjectApplicationInfo: " + info.ProjectApplicationInfo);
            Console.WriteLine("ProjectFileFormat: " + info.ProjectFileFormat);

            // ExEnd:ReadProjectFileFormat
        }
    }
}