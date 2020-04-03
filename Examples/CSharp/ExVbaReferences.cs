namespace Aspose.Tasks.Examples.CSharp
{
    using System;
    using NUnit.Framework;

    [TestFixture]
    public class ExVbaReferences : ApiExampleBase
    {
        [Test]
        public void ReadReferencesInformation()
        {
            //ExStart:ReadReferencesInformation
            //ExFor: VbaReference
            //ExFor: VbaReference.Name
            //ExFor: VbaReference.LibIdentifier
            //ExSummary: Shows how to read VBA references.
            var project = new Project(DataDir + "VbaProject.mpp");

            Console.WriteLine("Reference count " + project.VbaProject.References.Count);

            foreach (var reference in project.VbaProject.References)
            {
                Console.WriteLine("Identifier: " + reference.LibIdentifier);
                Console.WriteLine("Name: " + reference.Name);
            }
            //ExEnd:ReadReferencesInformation
        }
    }
}