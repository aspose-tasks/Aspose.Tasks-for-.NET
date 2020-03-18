namespace Aspose.Tasks.Examples.CSharp.WorkingWithProjects.CreatingReadingAndSaving
{
    using System.IO;

    internal class CreateEmptyProjectSaveStream
    {
        public static void Run()
        {
            // The path to the documents directory.
            var dataDir = RunExamples.GetDataDir(System.Reflection.MethodBase.GetCurrentMethod().DeclaringType.FullName);

            //ExStart:CreateEmptyProjectSaveStream
            // Create a project instance
            var newProject = new Project();

            // Create a file stream
            using (var projectStream = new FileStream(dataDir + "EmptyProjectSaveStream_out.xml", FileMode.Create, FileAccess.Write))
            {
                // Write the stream into XML format
                newProject.Save(projectStream, Aspose.Tasks.Saving.SaveFileFormat.XML);
            }
            //ExEnd: CreateEmptyProjectSaveStream
        }
    }
}
