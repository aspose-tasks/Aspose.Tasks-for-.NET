namespace Aspose.Tasks.Examples.CSharp
{
    using System;
    using NUnit.Framework;
    using Saving;

    [TestFixture]
    public class ExTasksLoggedException : ApiExampleBase
    {
        [Test]
        public void PrintTaskWritingException()
        {
            //ExStart:PrintTaskWritingException
            //ExFor: TasksLoggedException.LogText
            //ExSummary: Shows how to read log text of exception to check problems with MPP export.
            try
            {
                var project = new Project(DataDir + "PrintTaskWritingException.mpp");
                Console.Write("This example will only work if you apply a valid Aspose License. You can purchase full license or get 30 day temporary license from http://www.aspose.com/purchase/default.aspx.");
                project.Save(OutDir + "project_out.MPP", SaveFileFormat.MPP);
            }
            catch (TasksWritingException ex)
            {
                Console.WriteLine(ex.LogText);
            }
            //ExEnd:PrintTaskWritingException
            catch (NotSupportedException ex)
            {
                Console.WriteLine(ex.Message + "\nThis example will only work if you apply a valid Aspose License. You can purchase full license or get 30 day temporary license from http://www.aspose.com/purchase/default.aspx.");
            }
        }
    }
}