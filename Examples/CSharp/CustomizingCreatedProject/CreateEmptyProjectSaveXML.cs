using Aspose.Tasks.Saving;

namespace Aspose.Tasks.Examples.CSharp.CustomizingCreatedProject
{
    public class CreateEmptyProjectSaveXML
    {
        public static void Run()
        {
            // ExStart:CreateEmptyProjectSaveXML
            // The path to the documents directory.
            string dataDir = RunExamples.GetDataDir_CustomizingCreatedProject();
            Project project = new Project();
            project.Save(dataDir+ "saved_out.xml", SaveFileFormat.XML);
            // ExEnd:CreateEmptyProjectSaveXML
        }
    }
}