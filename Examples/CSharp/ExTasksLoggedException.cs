namespace Aspose.Tasks.Examples.CSharp
{
    using System;
    using System.Diagnostics.CodeAnalysis;

    using NUnit.Framework;
    using Saving;

    [TestFixture]
    [SuppressMessage("ReSharper", "StyleCop.SA1108", Justification = "Reviewed. Suppression is OK here.")]
    public class ExTasksLoggedException : ApiExampleBase
    {
        [Test]
        public void PrintTaskWritingException()
        {
            // ExStart:PrintTaskWritingException
            // ExFor: TasksWritingException
            // ExFor: TasksWritingException.#ctor(SerializationInfo,StreamingContext)
            // ExFor: TasksLoggedException
            // ExFor: TasksLoggedException.#ctor(SerializationInfo,StreamingContext)
            // ExFor: TasksLoggedException.LogText
            // ExFor: TasksLoggedException.Operation
            // ExSummary: Shows how to read log text and type of exception to check problems with MPP export.
            try
            {
                var project = new Project(DataDir + "PrintTaskWritingException.mpp");

                // export the project as an MPP file
                project.Save(OutDir + "PrintTaskWritingException_out.MPP", SaveFileFormat.MPP);
            }
            catch (TasksWritingException ex)
            {
                Console.WriteLine("Exception Operation: " + ex.Operation);
                Console.WriteLine("Exception Log Text: ");
                Console.WriteLine(ex.LogText);
            }

            // ExEnd:PrintTaskWritingException
            catch (NotSupportedException ex)
            {
                Console.WriteLine(
                    ex.Message
                    + "\nThis example will only work if you apply a valid Aspose License. You can purchase full license or get 30 day temporary license from http://www.aspose.com/purchase/default.aspx.");
            }
        }
    }
}