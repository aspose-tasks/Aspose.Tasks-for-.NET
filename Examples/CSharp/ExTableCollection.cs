namespace Aspose.Tasks.Examples.CSharp
{
    using System;
    using System.Collections.Generic;
    using NUnit.Framework;

    [TestFixture]
    public class ExTableCollection : ApiExampleBase
    {
        [Test]
        public void WorkWithTableCollection([Values] bool deleteOneByOne)
        {
            // ExStart
            // ExFor: TableCollection
            // ExFor: TableCollection.Add(Table)
            // ExFor: TableCollection.Clear
            // ExFor: TableCollection.Contains(Table)
            // ExFor: TableCollection.CopyTo(Table[],Int32)
            // ExFor: TableCollection.Count
            // ExFor: TableCollection.GetEnumerator
            // ExFor: TableCollection.IsReadOnly
            // ExFor: TableCollection.ParentProject
            // ExFor: TableCollection.Remove(Table)
            // ExFor: TableCollection.ToList
            // ExSummary: Shows how to work with table collections.
            var project = new Project(DataDir + "Project1.mpp");

            Console.WriteLine("Is collection of tables read-only?: " + project.Tables.IsReadOnly);

            // iterate over tables
            Console.WriteLine("Print tables of " + project.Get(Prj.Name) + " project.");
            Console.WriteLine("Table count: " + project.Tables.Count);
            foreach (var tbl in project.Tables)
            {
                Console.WriteLine("Index: " + tbl.Index);
                Console.WriteLine("Name: " + tbl.Name);
            }

            // add a new table
            var tableToAdd = new Table
            {
                Name = "New Table",
                ShowInMenu = true
            };
            project.Tables.Add(tableToAdd);

            Console.WriteLine("The collection contains the new table?: " + project.Tables.Contains(tableToAdd));

            // one can clear the collection in two ways
            if (deleteOneByOne)
            {
                // copy tables into the array and delete them one by one
                var tables = new Table[project.Tables.Count];
                project.Tables.CopyTo(tables, 0);
                foreach (var table in tables)
                {
                    project.Tables.Remove(table);
                }
            }
            else
            {
                // or one can clear a table collection completely
                project.Tables.Clear();
            }

            // the collection can be converted into a plain list of tables
            List<Table> list = project.Tables.ToList();
            foreach (var table in list)
            {
                Console.WriteLine("Index: " + table.Index);
                Console.WriteLine("Name: " + table.Name);
            }

            // ExEnd
        }
    }
}