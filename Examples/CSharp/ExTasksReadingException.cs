namespace Aspose.Tasks.Examples.CSharp
{
    using System;
    using NUnit.Framework;
    using Saving;

    [TestFixture]
    public class ExTasksReadingException : ApiExampleBase
    {
        [Test]
        public void HandleProjectReadingException()
        {
            //ExStart:ExTasksReadingException
            //ExFor: TasksReadingException
            //ExSummary: Shows how to handle project' reading/writing exceptions.
            try
            {
                var project = new Project(DataDir + "project.mpp");
                project.Save(OutDir + "HandleExceptions_out.mpp", SaveFileFormat.MPP);
            }
            catch (TasksReadingException ex)
            {
                Console.WriteLine("Message: ");
                Console.WriteLine(ex.Message);
                Console.WriteLine("Log: ");
                Console.WriteLine(ex.LogText);
                if (ex.InnerException != null)
                {
                    Console.WriteLine("Inner exception message: ");
                    Console.WriteLine(ex.InnerException.Message);
                }
            }
            //ExEnd:ExTasksReadingException
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }
    }
}