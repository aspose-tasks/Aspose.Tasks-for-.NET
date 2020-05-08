namespace Aspose.Tasks.Examples.CSharp
{
    using System;
    using NUnit.Framework;

    [TestFixture]
    public class ExApplicationInfo : ApiExampleBase
    {
        [Test]
        public void WorkWithApplicationInfo()
        {
            // ExStart:ReadApplicationInfo
            // ExFor: ApplicationInfo
            // ExSummary: Shows how to check project application info.
            var info = Project.GetProjectFileInfo(DataDir + "Project.xml");
            Console.WriteLine("CanRead: " + info.CanRead);
            Console.WriteLine("ProjectApplicationInfo: " + info.ProjectApplicationInfo);
            Console.WriteLine("ProjectFileFormat: " + info.ProjectFileFormat);

            // ExEnd:ReadApplicationInfo
        }
    }
}