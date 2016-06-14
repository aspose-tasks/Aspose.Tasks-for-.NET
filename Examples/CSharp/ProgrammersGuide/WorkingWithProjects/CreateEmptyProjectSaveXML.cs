using System.IO;
using Aspose.Tasks;
using Aspose.Tasks.Saving;

namespace Aspose.Tasks.Examples.CSharp.WorkingWithProjects
{
    public class CreateEmptyProjectSaveXML
    {
        public static void Run()
        {
            //ExStart: CreateEmptyProjectSaveXML
            // The path to the documents directory.
            string dataDir = RunExamples.GetDataDir_Projects();

            Project project = new Project();

            project.Save(dataDir+ "saved.xml", SaveFileFormat.XML);
            //ExEnd: CreateEmptyProjectSaveXML
        }
    }
}