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
            //ExStart:ReadTableDataFromProjectFile
            //ExFor: TableField
            //ExFor: TableField.#ctor
            //ExSummary: Shows how to read project tables. 
            var project = new Project(DataDir + "ReadTableData.mpp");

            // Access table
            var task = project.Tables.ToList()[0];
            Console.WriteLine("Table Fields Count" + task.TableFields.Count);

            // Display all table fields information
            foreach (var field in task.TableFields)
            {
                Console.WriteLine("Field width: " + field.Width);
                Console.WriteLine("Field Title: " + field.Title);
                Console.WriteLine("Field Title Alignment: " + field.AlignTitle);
                Console.WriteLine("Field Align Data: " + field.AlignData);
            }
            //ExEnd:ReadTableDataFromProjectFile
        }
    }
}