namespace Aspose.Tasks.Examples.CSharp.WorkingWithProjects.CreatingReadingAndSaving
{
    using System;
    using System.IO;

    using Aspose.Tasks.Saving;

    internal class WorkingWithEncodings
    {
        public static void Run()
        {
            var dataDir = RunExamples.GetDataDir(System.Reflection.MethodBase.GetCurrentMethod());

            //ExStart:WorkingWithEncodings
            //ExFor: Project.#ctor(StreamReader)
            //ExSummary: Shows how to read MPX files with specific encoding.
            using (var streamReader = new StreamReader(dataDir + "EUC-KR-encoding.mpx", System.Text.Encoding.GetEncoding("ISO-8859-1")))
            {
                var project = new Project(streamReader);
                Console.WriteLine(project.RootTask.Children.ToList()[0].Get(Tsk.Name));
                project.Save(dataDir + "WorkingWithEncodings_out.mpx", SaveFileFormat.MPX);
            }
            //ExEnd:WorkingWithEncodings
        }
    }
}
