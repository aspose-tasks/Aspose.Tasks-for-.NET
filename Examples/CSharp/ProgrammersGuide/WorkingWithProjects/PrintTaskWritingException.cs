using System.IO;
using Aspose.Tasks;
using System;

namespace Aspose.Tasks.Examples.CSharp.WorkingWithProjects
{
    public class PrintTaskWritingException
    {
        public static void Run()
        {
            //ExStart: PrintTaskWritingException
            // The path to the documents directory.
            string dataDir = RunExamples.GetDataDir_Projects();

            Project project = new Project(dataDir+ "PrintTaskWritingException.mpp");

            try
            {
                project.Save("project.MPP", Aspose.Tasks.Saving.SaveFileFormat.MPP);
            }
            catch (TasksWritingException ex)
            {
                Console.WriteLine(ex.LogText);
            }
            //ExEnd: PrintTaskWritingException
        }
    }
}