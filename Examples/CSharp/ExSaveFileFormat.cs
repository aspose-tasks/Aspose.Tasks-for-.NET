namespace Aspose.Tasks.Examples.CSharp
{
    using NUnit.Framework;
    using Saving;

    [TestFixture]
    public class ExSaveFileFormat : ApiExampleBase
    {
        [Test]
        public void SaveProjectAsCsv()
        {
            // ExStart:SaveProjectAsCSV
            // ExFor: SaveFileFormat
            // ExSummary: Shows how to save a project in CSV format.
            var project = new Project(DataDir + "CreateProject1.mpp");
            project.Save(OutDir + "SaveProjectAsCSV_out.csv", SaveFileFormat.Csv);

            // ExEnd:SaveProjectAsCSV
        }
    }
}