namespace Aspose.Tasks.Examples.CSharp
{
    using System;
    using System.Collections.Generic;
    using System.Drawing;
    using NUnit.Framework;
    using Saving;

    [TestFixture]
    public class ExTable : ApiExampleBase
    {
        [Test]
        public void WorkWithTable()
        {
            try
            {
                // ExStart:WorkWithTableFields
                // ExFor: Table
                // ExFor: Table.#ctor
                // ExFor: Table.Index
                // ExFor: Table.Uid
                // ExFor: Table.Name
                // ExFor: Table.AdjustHeaderRowHeight
                // ExFor: Table.DateFormat
                // ExFor: Table.LockFirstColumn
                // ExFor: Table.ParentProject
                // ExFor: Table.RowHeight
                // ExFor: Table.ShowAddNewColumn
                // ExFor: Table.ShowInMenu
                // ExFor: Table.TableType
                // ExSummary: Shows how to define a new table (using for views).
                var project = new Project(DataDir + "Project1.mpp");

                // get a table to edit
                var table = project.Tables.ToList()[0];
                Console.WriteLine("Uid of the table: " + table.Uid);
                Console.WriteLine("Index of the table: " + table.Index);
                Console.WriteLine("Name of the table: " + table.Name);
                Console.WriteLine("Parent project of the table: " + table.ParentProject.Get(Prj.Name));
                Console.WriteLine("Type of the table: " + table.TableType);

                // tune some properties
                // set a value indicating whether the header row height of the table can be adjusted
                table.AdjustHeaderRowHeight = true;

                // set the date format of the table.
                table.DateFormat = DateFormat.DateDdMmYyyy;

                // set a value indicating whether the first column of a table is locked or editable
                table.LockFirstColumn = true;

                // set the row height in a table, where the row height is the number of lines of text
                table.RowHeight = 10;

                // sets a value indicating whether to show 'Add New Column' interface
                table.ShowAddNewColumn = true;

                // set a value indicating whether project shows the table name in the Tables drop-down list on the View tab of the Ribbon
                table.ShowInMenu = true;

                // lets save the updated table
                project.Save(OutDir + "WorkWithTable_out.mpp", SaveFileFormat.MPP);

                // ExEnd:WorkWithTableFields
            }
            catch (NotSupportedException ex)
            {
                Console.WriteLine(
                    ex.Message
                    + "\nThis example will only work if you apply a valid Aspose License. You can purchase full license or get 30 day temporary license from http:// Www.aspose.com/purchase/default.aspx.");
            }
        }

        [Test]
        public void EqualsTable()
        {
            // ExStart
            // ExFor: Table.Equals(Object)
            // ExSummary: Shows how to check table equality.
            var project = new Project(DataDir + "ReadFilterDefinitionData.mpp");
            List<Table> tables = project.Tables.ToList();

            var table1 = tables[0];
            var table2 = tables[1];

            // the equality of tables is checked against to table's UID.
            Console.WriteLine("Table 1 UID: " + table1.Uid);
            Console.WriteLine("Table 2 UID: " + table2.Uid);
            Console.WriteLine("Are tables equal: " + table1.Equals(table2));

            // ExEnd
        }

        [Test]
        public void GetHashCodeTable()
        {
            // ExStart
            // ExFor: Table.GetHashCode
            // ExSummary: Shows how to get a hash code of a table.
            var project = new Project(DataDir + "ReadFilterDefinitionData.mpp");

            List<Table> tables = project.Tables.ToList();

            var table1 = tables[0];
            var table2 = tables[1];

            // the hash code of a table is equal to table UID 
            Console.WriteLine("Table UID: {0} Hash Code: {1}", table1.Uid, table1.GetHashCode());
            Console.WriteLine("Table UID: {0} Hash Code: {1}", table2.Uid, table2.GetHashCode());

            // ExEnd
        }

        [Test]
        public void WorkWithTableFields()
        {
            try
            {
                // ExStart:WorkWithTableFields
                // ExFor: Table.TableFields
                // ExSummary: Shows how to work project's tables.
                var project = new Project(DataDir + "Project5.mpp");
                var task = project.RootTask.Children.Add("New Activity");

                // Define new custom attribute
                var definition = ExtendedAttributeDefinition.CreateTaskDefinition(ExtendedAttributeTask.Text1, null);
                project.ExtendedAttributes.Add(definition);

                // Add custom text attribute to created task.
                task.ExtendedAttributes.Add(definition.CreateExtendedAttribute("Activity attribute"));

                // Customize table by adding text attribute field
                var field = new TableField();
                field.Field = Field.TaskText1;
                field.Width = 20;
                field.Title = "Custom attribute";
                field.AlignTitle = StringAlignment.Center;
                field.AlignData = StringAlignment.Center;

                var table = project.Tables.ToList()[0];
                table.TableFields.Insert(3, field);

                project.Save(OutDir + "ConfigureGanttChart_out.mpp", new MPPSaveOptions { WriteViewData = true });

                // ExEnd:WorkWithTableFields
            }
            catch (NotSupportedException ex)
            {
                Console.WriteLine(
                    ex.Message
                    + "\nThis example will only work if you apply a valid Aspose License. You can purchase full license or get 30 day temporary license from http:// Www.aspose.com/purchase/default.aspx.");
            }
        }
    }
}