namespace Aspose.Tasks.Examples.CSharp
{
    using System.Text;
    using NUnit.Framework;
    using Saving;

    [TestFixture]
    public class ExCsvOptions : ApiExampleBase
    {
        [Test]
        public void WorkWithCsvOptions()
        {
            // ExStart:WorkWithCsvOptions
            // ExFor: CsvOptions
            // ExFor: CsvOptions.#ctor
            // ExFor: CsvOptions.DataCategory
            // ExFor: CsvOptions.Encoding
            // ExFor: CsvOptions.IncludeHeaders
            // ExFor: CsvOptions.TextDelimiter
            // ExFor: CsvTextDelimiter
            // ExFor: DataCategory
            // ExSummary: Shows how to use <see cref="Aspose.Tasks.Saving.CsvOptions" /> to save a project as CSV file.
            var project = new Project(DataDir + "EstimatedMilestoneTasks.mpp");
            var options = new CsvOptions
                              {
                                  DataCategory = DataCategory.Resources, TextDelimiter = CsvTextDelimiter.Semicolon, Encoding = Encoding.Unicode, IncludeHeaders = true
                              };
            project.Save(OutDir + "WorkWithCsvOptions_out.csv", options);

            // ExEnd:WorkWithCsvOptions
        }
    }
}