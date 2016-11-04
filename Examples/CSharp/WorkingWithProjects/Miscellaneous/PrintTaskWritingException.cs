using System;
using Aspose.Tasks.Saving;

namespace Aspose.Tasks.Examples.CSharp.WorkingWithProjects.Miscellaneous
{
    public class PrintTaskWritingException
    {
        public static void Run()
        {
            // ExStart:PrintTaskWritingException
            // The path to the documents directory.
            string dataDir = RunExamples.GetDataDir(System.Reflection.MethodBase.GetCurrentMethod().DeclaringType);

            try
            {
                Project project = new Project(dataDir + "PrintTaskWritingException.mpp");
                Console.Write("This example will only work if you apply a valid Aspose License. You can purchase full license or get 30 day temporary license from http://www.aspose.com/purchase/default.aspx.");
                project.Save(dataDir + "project_out.MPP", SaveFileFormat.MPP);
            }
            catch (TasksWritingException ex)
            {
                Console.WriteLine(ex.LogText);
            }
            // ExEnd:PrintTaskWritingException
        }
    }
}