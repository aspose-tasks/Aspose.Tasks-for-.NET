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
            //ExFor: MpdSettings.ProjectId
            //ExSummary: Shows how to use MPD settings to control import of project from the database.
            var settings = new MpdSettings("Provider=Microsoft.Jet.OLEDB.4.0; Data Source=" + DataDir + "MpdFileToRead.mpd", 1);

            Console.WriteLine("Project ID to load: " + settings.ProjectId);
            
            var project = new Project(settings);
            Console.WriteLine(project.Get(Prj.Name));
            //ExEnd:ImportProjectDataFromMpdFile
        }
        
        [Test]
        public void ImportProjectDataFromMpdFile2()
        {
            try
            {
                //ExStart:ImportProjectDataFromMpdFile
                //ExFor: MpdSettings.#ctor(String,Int32)
                //ExSummary: Shows how to read a project from an MPD file.
                DbSettings settings = new MpdSettings("Provider=Microsoft.Jet.OLEDB.4.0; Data Source=" + DataDir + "MpdFileToRead.mpd", 1);
                var project = new Project(settings);            
                Console.WriteLine(project.Get(Prj.Name));
                //ExEnd:ImportProjectDataFromMpdFile
            }
            catch (NotSupportedException ex)
            {
                Console.WriteLine(ex.Message + "\nThis example will only work if you apply a valid Aspose License. You can purchase full license or get 30 day temporary license from http://www.aspose.com/purchase/default.aspx.");
            }
        }
    }
}