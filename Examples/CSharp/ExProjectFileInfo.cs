namespace Aspose.Tasks.Examples.CSharp
{
    using System;
    using NUnit.Framework;

    [TestFixture]
    public class ExProjectFileInfo : ApiExampleBase
    {
        [Test]
        public void ReadProjectFileInfo()
        {
            //ExStart:ReadProjectFileInfo
            //ExFor: ProjectFileInfo
            //ExFor: ProjectFileInfo.CanRead
            //ExFor: ProjectFileInfo.ProjectFileFormat
            //ExFor: ProjectFileInfo.ProjectApplicationInfo
            //ExSummary: Shows how to read project file info.
            var info = Project.GetProjectFileInfo(DataDir + "Project.xml");
            Console.WriteLine("CanRead: " + info.CanRead);
            Console.WriteLine("ProjectApplicationInfo: " + info.ProjectApplicationInfo);
            Console.WriteLine("ProjectFileFormat: " + info.ProjectFileFormat);
            //ExEnd:ReadProjectFileInfo
        }
    }
}