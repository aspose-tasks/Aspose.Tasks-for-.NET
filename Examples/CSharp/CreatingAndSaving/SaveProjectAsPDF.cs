using Aspose.Tasks.Saving;

namespace Aspose.Tasks.Examples.CSharp.CreatingAndSaving
{
    public class SaveProjectAsPDF
    {
        public static void Run()
        {
            // ExStart:SaveProjectAsPDF
            // The path to the documents directory.
            string dataDir = RunExamples.GetDataDir_CreatingAndSaving();

            // Read the input Project file
            Project project = new Project(dataDir + "Project2.mpp");

            // Save the Project as PDF
            project.Save(dataDir + "SaveProjectAsPDF_out.pdf", SaveFileFormat.PDF);
            // ExEnd:SaveProjectAsPDF
        }
    }
}