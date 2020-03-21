namespace Aspose.Tasks.Examples.CSharp.WorkingWithProjects.CreatingReadingAndSaving
{
    using Aspose.Tasks.Saving;

    internal class ReadProjectFiles
    {
        public static void Run()
        {
            // The path to the documents directory.
            var dataDir = RunExamples.GetDataDir(System.Reflection.MethodBase.GetCurrentMethod().DeclaringType.FullName);        

            //ExStart:ReadProjectFiles
            //ExFor: Project(String)
            //ExSummary: Shows how to read a MPP file.
            // Read existing project template file
            var project = new Project(dataDir + "ReadProjectFiles.mpp");
            project.Save(dataDir + "ReadProjectFiles_out.mpp", SaveFileFormat.XML);
            //ExEnd:ReadProjectFiles
        }
    }
}