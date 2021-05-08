namespace Aspose.Tasks.Examples.CSharp
{
    using System;
    using NUnit.Framework;

    [TestFixture]
    public class ExTableField : ApiExampleBase
    {
        [Test]
        public void ReadTableDataFromProjectFile()
        {
            // ExStart:ReadTableDataFromProjectFile
            // ExFor: TableField
            // ExFor: TableField.#ctor
            // ExFor: TableField.AlignData
            // ExFor: TableField.AlignTitle
            // ExFor: TableField.Field
            // ExFor: TableField.Title
            // ExFor: TableField.Width
            // ExFor: TableField.WrapHeader
            // ExFor: TableField.WrapText
            // ExSummary: Shows how to read project tables. 
            var project = new Project(DataDir + "ReadTableData.mpp");

            // get the table
            var table = project.Tables.ToList()[0];
            Console.WriteLine("Print table fields of {0}", table.Name);
            Console.WriteLine("Table Fields Count" + table.TableFields.Count);

            // display all table fields' information
            foreach (var field in table.TableFields)
            {
                Console.WriteLine("  Field: " + field.Field);
                Console.WriteLine("  Width: " + field.Width);
                Console.WriteLine("  Title: " + field.Title);
                Console.WriteLine("  Title Alignment: " + field.AlignTitle);
                Console.WriteLine("  Data Alignment: " + field.AlignData);
                Console.WriteLine("  Wrap Header: " + field.WrapHeader);
                Console.WriteLine("  Wrap Text: " + field.WrapText);
                Console.WriteLine();
            }

            // ExEnd:ReadTableDataFromProjectFile
        }
    }
}