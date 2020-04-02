namespace Aspose.Tasks.Examples.CSharp
{
    using System;
    using NUnit.Framework;

    [TestFixture]
    public class ExApplicationInfo : ApiExampleBase
    {
        [Test]
        public void ReadApplicationInfo()
        {
            //ExStart:ReadApplicationInfo
            //ExFor: ApplicationInfo
            //ExFor: ApplicationInfo.MSP2000
            //ExFor: ApplicationInfo.MSP2003
            //ExFor: ApplicationInfo.MSP2007
            //ExFor: ApplicationInfo.MSP2010
            //ExFor: ApplicationInfo.MSP2013
            //ExFor: ApplicationInfo.MSP2016
            //ExFor: ApplicationInfo.Undefined
            //ExSummary: Shows how to check project application info.
            var info = Project.GetProjectFileInfo(DataDir + "Project.xml");
            Console.WriteLine("CanRead: " + info.CanRead);
            Console.WriteLine("ProjectApplicationInfo: " + info.ProjectApplicationInfo);
            Console.WriteLine("ProjectFileFormat: " + info.ProjectFileFormat);
            //ExEnd:ReadApplicationInfo
        }
    }
}