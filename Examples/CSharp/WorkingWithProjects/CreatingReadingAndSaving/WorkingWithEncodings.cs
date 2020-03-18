namespace Aspose.Tasks.Examples.CSharp.WorkingWithProjects.CreatingReadingAndSaving
{
    using System.IO;

    using Aspose.Tasks.Saving;

    internal class WorkingWithEncodings
    {
        public static void Run()
        {
            // The path to the documents directory.
            var dataDir = RunExamples.GetDataDir(System.Reflection.MethodBase.GetCurrentMethod().DeclaringType.FullName);

            //ExStart:WorkingWithEncodings
            // Specify Encodings
            using (var streamReader = new StreamReader("Project.mpx", System.Text.Encoding.GetEncoding("ISO-8859-1")))
            {
                var project = new Project(streamReader.BaseStream);
                project.Save(dataDir + "WorkingWithEncodings_out.mpx", SaveFileFormat.MPX);
            }
            //ExEnd:WorkingWithEncodings
        }
    }
}
