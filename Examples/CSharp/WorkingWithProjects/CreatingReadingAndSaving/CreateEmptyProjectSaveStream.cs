namespace Aspose.Tasks.Examples.CSharp.WorkingWithProjects.CreatingReadingAndSaving
{
    using System.IO;
    using Saving;

    internal class CreateEmptyProjectSaveStream
    {
        public static void Run()
        {
            var dataDir = RunExamples.GetDataDir(System.Reflection.MethodBase.GetCurrentMethod());

            //ExStart:CreateEmptyProjectSaveStream
            //ExFor: Project.Save(Stream, SaveFileFormat);
            //ExSummary: Shows how to save project into a stream in XML MS Project format.
            // Create a project instance
            var project = new Project();

            // Create a file stream
            using (var stream = new FileStream(dataDir + "EmptyProjectSaveStream_out.xml", FileMode.Create, FileAccess.Write))
            {
                // Write the stream into XML format
                project.Save(stream, SaveFileFormat.XML);
            }
            //ExEnd: CreateEmptyProjectSaveStream
        }
    }
}
