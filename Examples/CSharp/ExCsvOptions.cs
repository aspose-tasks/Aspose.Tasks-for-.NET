namespace Aspose.Tasks.Examples.CSharp
{
    using System.Text;
    using Aspose.Tasks.Util;
    using Aspose.Tasks.Visualization;
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

        [Test]
        public void CsvOptionsCustomizeViewColumns()
        {
            // ExStart:CsvOptionsCustomizeViewColumns
            // ExFor: CsvOptions.View
            // ExFor: FieldHelper.GetDefaultFieldTitle(Field)
            // ExSummary: Shows how to use <see cref="Aspose.Tasks.Saving.CsvOptions" /> to take the columns of the default Gantt Chart and
            // save them to a CSV file.
            var project = new Project(DataDir + "EstimatedMilestoneTasks.mpp");

            CsvOptions options = new CsvOptions();
            options.TextDelimiter = CsvTextDelimiter.Tab;

            var view = project.DefaultView;
            options.View = ProjectView.GetDefaultGanttChartView();
            options.View.Columns.Clear();

            foreach (var t in view.Table.TableFields)
            {
                var columnTitle = string.IsNullOrEmpty(t.Title) ? FieldHelper.GetDefaultFieldTitle(t.Field) : t.Title;
                options.View.Columns.Add(new GanttChartColumn(columnTitle, 10, t.Field));
            }

            project.Save(OutDir + "CustomizeViewForCsvOptions_out.csv", options);

            // ExEnd:CsvOptionsCustomizeViewColumns
        }
    }
}