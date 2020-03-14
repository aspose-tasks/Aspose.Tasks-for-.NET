using System.IO;

namespace Aspose.Tasks.Examples.CSharp.WorkingWithProjects.CreatingReadingAndSaving
{
    class WorkingWithEncodings
    {
        public static void Run()
        {
            //ExStart:WorkingWithEncodings
            // Specify Encodings
            using (StreamReader streamReader = new StreamReader("Project.mpx", System.Text.Encoding.GetEncoding("ISO-8859-1")))
            {
                var project = new Project(streamReader.BaseStream);
            }
            //ExEnd:WorkingWithEncodings
        }
    }
}
