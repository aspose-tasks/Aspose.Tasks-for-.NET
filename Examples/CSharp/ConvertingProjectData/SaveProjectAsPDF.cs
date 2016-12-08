using Aspose.Tasks.Saving;

namespace Aspose.Tasks.Examples.CSharp.ConvertingProjectData
{
    public class SaveProjectAsPDF
    {
        public static void Run()
        {
            // The path to the documents directory.
            string dataDir = RunExamples.GetDataDir(System.Reflection.MethodBase.GetCurrentMethod().DeclaringType.FullName);

            // ExStart:SaveProjectAsPDF
            // Read the input Project file
            Project project = new Project(dataDir + "CreateProject2.mpp");

            // Save the Project as PDF
            project.Save(dataDir + "SaveProjectAsPDF_out.pdf", SaveFileFormat.PDF);
            // ExEnd:SaveProjectAsPDF
        }
    }
}