namespace Aspose.Tasks.Examples.CSharp
{
    using System;
    using NUnit.Framework;

    [TestFixture]
    public class ExInvalidPasswordException : ApiExampleBase
    {
        [Test]
        public void HandleInvalidPasswordException()
        {
            // ExStart:ExInvalidPasswordException
            // ExFor: InvalidPasswordException
            // ExFor: InvalidPasswordException.#ctor(SerializationInfo,StreamingContext)
            // ExSummary: Shows how to handle <see cref="InvalidPasswordException"/> while reading a password protected project files.
            try
            {
                var project = new Project("PasswordProtected.mpp");

                // working with project ...
                Console.WriteLine("Project Name: " + project.Get(Prj.Name));
            }
            catch (InvalidPasswordException e)
            {
                // the message is "The project is password protected. The password is not provided or incorrect."
                Console.WriteLine(e.Message);
            }

            // ExEnd:ExInvalidPasswordException
        }
    }
}