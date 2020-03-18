namespace Aspose.Tasks.Examples.CSharp.WorkingWithProjects.CreatingReadingAndSaving
{
    using Aspose.Tasks.Saving;

    public class ReadProjectFiles
    {
        public static void Run()
        {
            // The path to the documents directory.
            var dataDir = RunExamples.GetDataDir(System.Reflection.MethodBase.GetCurrentMethod().DeclaringType.FullName);        

            //ExStart:ReadProjectFiles
            // Read existing project template file
            var project = new Project(dataDir + "ReadProjectFiles.mpp");
            project.Save(dataDir + "ReadProjectFiles_out.mpp", SaveFileFormat.XML);
            //ExEnd:ReadProjectFiles
        }
    }
}