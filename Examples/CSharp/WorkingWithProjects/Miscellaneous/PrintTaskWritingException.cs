namespace Aspose.Tasks.Examples.CSharp.WorkingWithProjects.Miscellaneous
{
    using System;

    using Aspose.Tasks.Saving;

    internal class PrintTaskWritingException
    {
        public static void Run()
        {
            // The path to the documents directory.
            var dataDir = RunExamples.GetDataDir(System.Reflection.MethodBase.GetCurrentMethod().DeclaringType.FullName);

            //ExStart:PrintTaskWritingException
            //ExFor: TasksLoggedException.LogText
            //ExSummary: Shows how to read log text of exception to check problems with MPP export.
            try
            {
                var project = new Project(dataDir + "PrintTaskWritingException.mpp");
                Console.Write("This example will only work if you apply a valid Aspose License. You can purchase full license or get 30 day temporary license from http://www.aspose.com/purchase/default.aspx.");
                project.Save(dataDir + "project_out.MPP", SaveFileFormat.MPP);
            }
            catch (TasksWritingException ex)
            {
                Console.WriteLine(ex.LogText);
            }
            catch (NotSupportedException ex)
            {
                Console.WriteLine(ex.Message + "\nThis example will only work if you apply a valid Aspose License. You can purchase full license or get 30 day temporary license from http://www.aspose.com/purchase/default.aspx.");
            }
            //ExEnd:PrintTaskWritingException
        }
    }
}