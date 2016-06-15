using System.IO;
using Aspose.Tasks;
using System;

namespace Aspose.Tasks.Examples.CSharp.WorkingWithProjects
{
    public class ReadProjectFiles
    {
        public static void Run()
        {
            //ExStart: ReadProjectFiles
            // The path to the documents directory.
            string dataDir = RunExamples.GetDataDir_Projects();

            Project project = new Project(dataDir + "ReadProjectFiles.mpp");
            //ExEnd: ReadProjectFiles
        }
    }
}