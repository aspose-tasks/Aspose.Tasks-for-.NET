using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;

namespace Aspose.Tasks.Examples.CSharp.WorkingWithProjects.CreatingReadingAndSaving
{
    class WorkingWithEncodings
    {
        public static void Run()
        {
            // The path to the documents directory.
            string dataDir = RunExamples.GetDataDir(System.Reflection.MethodBase.GetCurrentMethod().DeclaringType.FullName);

            // ExStart:WorkingWithEncodings
            // Specify Encodings
            using (StreamReader streamReader = new StreamReader("Project.mpx", System.Text.Encoding.GetEncoding("ISO-8859-1")))
            {
                var project = new Project(streamReader.BaseStream);
            }
            // ExEnd:WorkingWithEncodings
        }
    }
}
