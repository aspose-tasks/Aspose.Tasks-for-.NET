namespace Aspose.Tasks.Examples.CSharp
{
    using System;
    using NUnit.Framework;

    [TestFixture]
    public class ExVbaReference : ApiExampleBase
    {
        [Test]
        public void WorkWithVbaReference()
        {
            // ExStart:WorkWithVbaReference
            // ExFor: VbaReference
            // ExFor: VbaReference.Name
            // ExFor: VbaReference.LibIdentifier
            // ExSummary: Shows how to read VBA references.
            var project = new Project(DataDir + "VbaProject.mpp");

            Console.WriteLine("Reference count " + project.VbaProject.References.Count);

            foreach (var reference in project.VbaProject.References)
            {
                Console.WriteLine("Identifier: " + reference.LibIdentifier);
                Console.WriteLine("Name: " + reference.Name);
            }

            // ExEnd:WorkWithVbaReference
        }

        [Test]
        public void VbaReferenceEquals()
        {
            // ExStart
            // ExFor: VbaReference.Equals(Object)
            // ExFor: VbaReference.Equals(VbaReference)
            // ExSummary: Shows how to check VBA reference equality.
            var project = new Project(DataDir + "VbaProject.mpp");

            var reference1 = project.VbaProject.References.ToList()[0];
            var reference2 = project.VbaProject.References.ToList()[1];

            // the equality of references is checked against to reference's name.
            Console.WriteLine("VBA reference 1 Name: " + reference1.Name);
            Console.WriteLine("VBA reference 2 Name: " + reference2.Name);
            Console.WriteLine("Are references equal: " + reference1.Equals(reference2));

            // ExEnd
        }

        [Test]
        public void GetVbaReferenceHashCode()
        {
            // ExStart
            // ExFor: VbaReference.GetHashCode
            // ExSummary: Shows how to get a hash code of a VBA reference.
            var project = new Project(DataDir + "VbaProject.mpp");

            var reference1 = project.VbaProject.References.ToList()[0];
            var reference2 = project.VbaProject.References.ToList()[1];

            // the hash code of a reference is a hash code of internal reference's GUID
            Console.WriteLine("VBA reference Hash Code: {0}", reference1.GetHashCode());
            Console.WriteLine("VBA reference Hash Code: {0}", reference2.GetHashCode());

            // ExEnd
        }
    }
}