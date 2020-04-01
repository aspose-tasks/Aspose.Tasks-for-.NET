namespace Aspose.Tasks.Examples.CSharp
{
    using System;
    using Connectivity;
    using NUnit.Framework;

    [TestFixture]
    public class ExMpdSettings : ApiExampleBase
    {
        [Test]
        public void ImportProjectDataFromMpdFile()
        {
            //ExStart:ImportProjectDataFromMpdFile
            //ExFor: MpdSettings
            //ExSummary: Shows how to use MPD settings to control import of project from the database.
            DbSettings settings = new MpdSettings("Provider=Microsoft.Jet.OLEDB.4.0; Data Source=" + DataDir + "MpdFileToRead.mpd", 1);
            var project = new Project(settings);
            Console.WriteLine(project.Get(Prj.Name));
            //ExEnd:ImportProjectDataFromMpdFile
        }
    }
}