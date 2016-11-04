using System.IO;

namespace Aspose.Tasks.Examples.CSharp.WorkingWithProjects.CreatingReadingAndSaving
{
    public class ReadProjectFileFromStream
    {
        public static void Run()
        {
            // ExStart:ReadProjectFileFromStream
            // The path to the documents directory.
            string dataDir = RunExamples.GetDataDir(System.Reflection.MethodBase.GetCurrentMethod().DeclaringType);       

            // Read project xml into file stream
            using (Stream filesStream = new FileStream(dataDir + "Project.xml", FileMode.Open))
            {
                // Create project using file stream
                Project project = new Project(filesStream);
            }
            // ExEnd:ReadProjectFileFromStream
        }
    }
}