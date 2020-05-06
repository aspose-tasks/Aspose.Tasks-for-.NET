namespace Aspose.Tasks.Examples.CSharp
{
    using System;
    using System.Collections.Generic;
    using System.Globalization;
    using NUnit.Framework;
    using Saving;
    using Visualization;

    [TestFixture]
    public class ExTaskXMLCreationFinished : ApiExampleBase
    {
        [Test]
        public void WorkWithTaskXMLCreationFinished()
        {
        }
    }
    
    [TestFixture]
    public class ExTaskXMLParsingFinished : ApiExampleBase
    {
        [Test]
        public void WorkWithTaskXMLParsingFinished()
        {
        }
    }

    [TestFixture]
    public class ExResourceViewColumn : ApiExampleBase
    {
        [Test]
        public void WorkWithResourceViewColumn()
        {
            // ExStart:WorkWithResourceViewColumn
            // ExFor: ResourceViewColumn
            // ExFor: ResourceViewColumn.#ctor(Int32,Field)
            // ExFor: ResourceViewColumn.#ctor(String,Int32,ResourceToColumnTextConverter)
            // ExFor: ResourceViewColumn.#ctor(String,Int32,ResourceToColumnTextConverter,Field)
            // ExFor: ResourceViewColumn.Field
            // ExFor: ResourceViewColumn.GetColumnText(Resource)
            // ExFor: ResourceToColumnTextConverter
            // ExSummary: Shows how to add resource view columns to be exported.
            var project = new Project(DataDir + "Project2.mpp");
            Resource resource = project.Resources.GetById(1);

            var options = new PdfSaveOptions();
            var columns = new List<ViewColumn>
            {
                new ResourceViewColumn(100, Field.ResourceName),
                new ResourceViewColumn(100, Field.ResourceActualWork),
                new ResourceViewColumn(100, Field.ResourceCost),
                new ResourceViewColumn(
                    "Resource Cost2", 
                    80,
                    delegate(Resource res)
                    {
                        return res.Get(Rsc.Cost).ToString(CultureInfo.InvariantCulture);
                    }),
                new ResourceViewColumn(
                    "Resource Cost2", 
                    80,
                    delegate(Resource res)
                    {
                        return res.Get(Rsc.Cost).ToString(CultureInfo.InvariantCulture);
                    }, 
                    Field.ResourceCost2)
            };
            
            // iterate over columns
            foreach (var column in columns)
            {
                var col = (ResourceViewColumn)column;
                Console.WriteLine("Column Name: " + col.Name);
                Console.WriteLine("Column Field: " + col.Field);
                Console.WriteLine("Column Text: " + col.GetColumnText(resource));
                Console.WriteLine();
            }

            options.View = new ProjectView(columns);
            options.PresentationFormat = PresentationFormat.ResourceUsage;
            project.Save(OutDir + "WorkWithAssignmentViewColumn_out.pdf", options);

            // ExEnd:WorkWithResourceViewColumn
        }
    }
}