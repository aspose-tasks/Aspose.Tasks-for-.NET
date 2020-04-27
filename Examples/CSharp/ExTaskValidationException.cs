namespace Aspose.Tasks.Examples.CSharp
{
    using System;
    using NUnit.Framework;

    [TestFixture]
    public class ExTaskValidationException : ApiExampleBase
    {
        [Test]
        public void TestTaskValidationException()
        {
            // ExStart
            // ExFor: TaskValidationException
            // ExFor: TaskValidationException.#ctor(SerializationInfo,StreamingContext)
            // ExFor: RecalculationValidationException
            // ExFor: RecalculationValidationException.#ctor
            // ExFor: RecalculationValidationException.#ctor(SerializationInfo,StreamingContext)
            // ExFor: RecalculationValidationException.#ctor(String)
            // ExFor: RecalculationValidationException.#ctor(String,Exception)
            // ExSummary: Shows on what conditions <see cref="TaskValidationException" /> exception can be thrown.
            try
            {
                var project = new Project { CalculationMode = CalculationMode.None };
                var task = project.RootTask.Children.Add("Task");

                // accidentally set incorrect dates
                task.Set(Tsk.Start, new DateTime(2017, 6, 19, 8, 0, 0));
                task.Set(Tsk.Duration, project.GetDuration(1));
                task.Set(Tsk.Finish, new DateTime(2017, 6, 18, 17, 0, 0));

                // run project recalculation with a flag to run validation   
                project.Recalculate(true);
            }
            catch (TaskValidationException ex)
            {
                Console.WriteLine(ex.Message);
            }

            // ExEnd
        }
    }
}