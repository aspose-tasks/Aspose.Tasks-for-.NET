namespace Aspose.Tasks.Examples.CSharp
{
    using System;
    using NUnit.Framework;

    [TestFixture]
    public class ExCompoundDocumentHeaderException : ApiExampleBase
    {
        [Test]
        public void WorkWithCompoundDocumentHeaderException()
        {
            // ExStart
            // ExFor: CompoundDocumentHeaderException
            // ExFor: CompoundDocumentHeaderException.#ctor(SerializationInfo,StreamingContext)
            // ExSummary: Shows how to catch <see cref=\"CompoundDocumentHeaderException\" /> exception.
            try
            {
                var project = new Project(DataDir + "Project1.mpp");

                Console.WriteLine("Project Name: " + project.Get(Prj.Name));
            }
            catch (CompoundDocumentHeaderException e)
            {
                Console.WriteLine(e.Message);
            }

            // ExEnd
        }
    }
}