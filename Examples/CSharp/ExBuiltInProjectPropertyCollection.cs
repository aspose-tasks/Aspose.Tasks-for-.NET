namespace Aspose.Tasks.Examples.CSharp
{
    using System;
    using System.Diagnostics.CodeAnalysis;
    using NUnit.Framework;
    using Properties;

    [TestFixture]
    internal class ExBuiltInProjectPropertyCollection : ApiExampleBase
    {
        [Test]
        [SuppressMessage("ReSharper", "RedundantToStringCall", Justification = "Reviewed. Suppression is OK here.")]
        public void ReadProjectMetaProperties()
        {
            // ExStart:ReadProjectMetaProperties
            // ExFor: Property
            // ExFor: Property.Name
            // ExFor: Property.Value
            // ExFor: Property.ToString
            // ExFor: BuiltInProjectPropertyCollection
            // ExFor: BuiltInProjectProperty
            // ExFor: BuiltInProjectProperty.Value
            // ExFor: BuiltInProjectPropertyCollection.Author
            // ExFor: BuiltInProjectPropertyCollection.Category
            // ExFor: BuiltInProjectPropertyCollection.Comments
            // ExFor: BuiltInProjectPropertyCollection.Company
            // ExFor: BuiltInProjectPropertyCollection.HyperlinkBase
            // ExFor: BuiltInProjectPropertyCollection.IsReadOnly
            // ExFor: BuiltInProjectPropertyCollection.Keywords
            // ExFor: BuiltInProjectPropertyCollection.Manager
            // ExFor: BuiltInProjectPropertyCollection.Subject
            // ExFor: BuiltInProjectPropertyCollection.Title
            // ExSummary: Shows how to read project builtin properties.
            var project = new Project(DataDir + "ReadProjectInfo.mpp");

            Console.WriteLine("Author: " + project.BuiltInProps.Author);
            Console.WriteLine("Category: " + project.BuiltInProps.Category);
            Console.WriteLine("Comments: " + project.BuiltInProps.Comments);
            Console.WriteLine("Company: " + project.BuiltInProps.Company);
            Console.WriteLine("HyperlinkBase: " + project.BuiltInProps.HyperlinkBase);
            Console.WriteLine("IsReadOnly: " + project.BuiltInProps.IsReadOnly);
            Console.WriteLine("Keywords: " + project.BuiltInProps.Keywords);
            Console.WriteLine("Manager: " + project.BuiltInProps.Manager);
            Console.WriteLine("Subject: " + project.BuiltInProps.Subject);
            Console.WriteLine("Title: " + project.BuiltInProps.Title);
            Console.WriteLine();
            
            // iterate over built-in property collection
            foreach (Property property in project.BuiltInProps)
            {
                Console.WriteLine("Name: " + property.Name);
                Console.WriteLine("Value: " + property.Value);
                Console.WriteLine("Prop As String: " + property.ToString());
                Console.WriteLine();
            }

            // ExEnd:ReadProjectMetaProperties
        }
    }
}
