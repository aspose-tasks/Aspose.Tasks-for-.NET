namespace Aspose.Tasks.Examples.CSharp
{
    using System;
    using System.Diagnostics.CodeAnalysis;
    using NUnit.Framework;

    [TestFixture]
    public class ExNullableBool : ApiExampleBase
    {
        [Test]
        [SuppressMessage("ReSharper", "RedundantToStringCallForValueType", Justification = "Reviewed. Suppression is OK here.")]
        public void WorkWithNullableBool()
        {
            // ExStart:WorkWithNullableBool
            // ExFor: NullableBool
            // ExFor: NullableBool.#ctor(Boolean)
            // ExFor: NullableBool.#ctor(Boolean,Boolean)
            // ExFor: NullableBool.IsDefined
            // ExFor: NullableBool.Value
            // ExFor: NullableBool.ToString 
            // ExSummary: Shows how to work with <see cref="NullableBool" /> class.
            var project = new Project();

            // lets check where the <see cref="Aspose.Tasks.NullableBool" /> class is used
            // the main advantage of <see cref="Aspose.Tasks.NullableBool" /> that 
            // one can set it as undefined through constructing
            var actualsInSync = new NullableBool(false, false);
            Console.WriteLine("'ActualsInSync' Value: " + actualsInSync.Value);
            Console.WriteLine("'ActualsInSync' Is Defined: " + actualsInSync.IsDefined);

            // ...
            // use nullable bool instance
            project.Set(Prj.ActualsInSync, actualsInSync);

            // ...
            var honorConstraints = new NullableBool(true);
            Console.WriteLine("'HonorConstraints' ToString: " + honorConstraints.ToString());

            // ...
            // use nullable bool instance
            project.Set(Prj.HonorConstraints, honorConstraints);

            // ...
            // ExEnd:WorkWithNullableBool
        }

        [Test]
        [SuppressMessage("ReSharper", "RedundantToStringCallForValueType", Justification = "Reviewed. Suppression is OK here.")]
        public void EqualsNullableBool()
        {
            // ExStart
            // ExFor: NullableBool.Equals(NullableBool)
            // ExFor: NullableBool.Equals(Object)
            // ExFor: NullableBool.op_Equality(NullableBool,NullableBool)
            // ExFor: NullableBool.op_Implicit(NullableBool)~System.Boolean
            // ExFor: NullableBool.op_Implicit(System.Boolean)~NullableBool
            // ExFor: NullableBool.op_Inequality(NullableBool,NullableBool)
            // ExSummary: Shows how to compare <see cref="Aspose.Tasks.NullableBool" /> instances.
            var bool1 = new NullableBool(true);
            var bool2 = new NullableBool(true, false);

            // the equality of bools is checked against to 'IsDefined' and 'Value' properties.
            Console.WriteLine("Nullable Bool 1: " + bool1.ToString());
            Console.WriteLine("Nullable Bool 2: " + bool2.ToString());
            Console.WriteLine("Are bools equal: " + bool1.Equals(bool2));

            // ExEnd
        }

        [Test]
        public void GetHashCodeNullableBool()
        {
            // ExStart
            // ExFor: NullableBool.GetHashCode
            // ExSummary: Shows how to work with <see cref="Aspose.Tasks.NullableBool" />.GetHashCode method.
            var bool1 = new NullableBool(true);
            var bool2 = new NullableBool(true, false);

            // the hash code of bools is based on 'IsDefined' and 'Value' properties
            Console.WriteLine("Bool 1: {0} Hash Code 1: {1}", bool1.ToString(), bool1.GetHashCode());
            Console.WriteLine("Bool 2: {0} Hash Code 1: {1}", bool2.ToString(), bool2.GetHashCode());

            // ExEnd
        }
    }
}