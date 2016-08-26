using System.IO;

namespace Aspose.Tasks.Examples.CSharp.WorkingWithProjects
{
    public class ReadProjectFileFromStream
    {
        public static void Run()
        {
            // ExStart:ReadProjectFileFromStream
            // The path to the documents directory.
            string dataDir = RunExamples.GetDataDir_Projects();
            using (Stream filesStream = new FileStream(dataDir + "Project.xml", FileMode.Open))
            {
                Project project = new Project(filesStream);
            }
            // ExEnd:ReadProjectFileFromStream
        }
    }
}