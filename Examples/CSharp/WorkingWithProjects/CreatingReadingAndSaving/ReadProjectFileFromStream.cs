namespace Aspose.Tasks.Examples.CSharp.WorkingWithProjects.CreatingReadingAndSaving
{
    using System.IO;

    using Aspose.Tasks.Saving;

    public class ReadProjectFileFromStream
    {
        public static void Run()
        {
            // The path to the documents directory.
            var dataDir = RunExamples.GetDataDir(System.Reflection.MethodBase.GetCurrentMethod().DeclaringType.FullName);       
            
            //ExStart:ReadProjectFileFromStream
            // Read project xml into file stream
            using (Stream filesStream = new FileStream(dataDir + "ReadProjectFileFromStream.xml", FileMode.Open))
            {
                // Create project using file stream
                var project = new Project(filesStream);
                project.Save(dataDir + "ReadProjectFileFromStream.xml", SaveFileFormat.XML);
            }
            //ExEnd:ReadProjectFileFromStream
        }
    }
}