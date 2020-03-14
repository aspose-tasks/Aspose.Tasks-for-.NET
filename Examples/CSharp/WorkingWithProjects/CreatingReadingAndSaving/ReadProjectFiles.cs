namespace Aspose.Tasks.Examples.CSharp.WorkingWithProjects.CreatingReadingAndSaving
{
    public class ReadProjectFiles
    {
        public static void Run()
        {
            //ExStart:ReadProjectFiles
            // The path to the documents directory.
            string dataDir = RunExamples.GetDataDir(System.Reflection.MethodBase.GetCurrentMethod().DeclaringType.FullName);        

            // Read existing project template file
            Project project = new Project(dataDir + "ReadProjectFiles.mpp");
            //ExEnd:ReadProjectFiles
        }
    }
}