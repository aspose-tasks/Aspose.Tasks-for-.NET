using System.IO;
using Aspose.Tasks;
using System;
using Aspose.Tasks.Saving;

namespace Aspose.Tasks.Examples.CSharp.WorkingWithProjects
{
    public class WriteMPPProjectSummary
    {
        public static void Run()
        {
            //ExStart: WriteMPPProjectSummary
            // The path to the documents directory.
            string dataDir = RunExamples.GetDataDir_Projects();

            //Instantiate ProjectReader class
            Project project = new Project(dataDir+ "WriteMPPProjectSummary.mpp");
            project.Set(Prj.Author, "Author");
            project.Set(Prj.LastAuthor, "Last Author");
            project.Set(Prj.Revision, 15);
            project.Set(Prj.Keywords, "MSP Aspose");
            project.Set(Prj.Comments, "Comments");

            project.Save(dataDir+ "saved.mpp", SaveFileFormat.MPP);
            //ExEnd: WriteMPPProjectSummary
        }
    }
}