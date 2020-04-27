namespace Aspose.Tasks.Examples.CSharp
{
    using System;
    using NUnit.Framework;

    [TestFixture]
    public class ExValidationException : ApiExampleBase
    {
        [Test]
        public void HandleValidationException()
        {
            // ExStart:ExValidationException
            // ExFor: ValidationException
            // ExFor: ValidationException.#ctor(SerializationInfo,StreamingContext)
            // ExSummary: Shows how to handle <see cref="ValidationException"/> while working with recurrence tasks.
            try
            {
                var project = new Project();
                var parameters = new RecurringTaskParameters { TaskName = "t1", Duration = project.GetDuration(1, TimeUnitType.Day), RecurrencePattern = null };
                project.RootTask.Children.Add(parameters);
            }
            catch (ValidationException ex)
            {
                Console.WriteLine("Message: ");
                Console.WriteLine(ex.Message);
                if (ex.InnerException != null)
                {
                    Console.WriteLine("Inner exception message: ");
                    Console.WriteLine(ex.InnerException.Message);
                }
            }

            // ExEnd:ExValidationException
        }
    }
}