namespace Aspose.Tasks.Examples.CSharp.WorkingWithProjects.CreatingReadingAndSaving
{
    using System.IO;

    using Aspose.Tasks.Saving;

    internal class ReadProjectFileFromStream
    {
        public static void Run()
        {
            // The path to the documents directory.
            var dataDir = RunExamples.GetDataDir(System.Reflection.MethodBase.GetCurrentMethod().DeclaringType.FullName);       
            
            //ExStart:ReadProjectFileFromStream
            //ExFor: Project(Stream)
            //ExSummary: Shows how to read XML project file from a stream.
            // Read project xml into file stream
            using (Stream stream = new FileStream(dataDir + "ReadProjectFileFromStream.xml", FileMode.Open))
            {
                // Create project using file stream
                var project = new Project(stream);
                project.Save(dataDir + "ReadProjectFileFromStream.xml", SaveFileFormat.XML);
            }
            //ExEnd:ReadProjectFileFromStream
        }
    }
}