using System.IO;
using Aspose.Tasks;
using Aspose.Tasks.Saving;

namespace Aspose.Tasks.Examples.CSharp.WorkingWithProjects
{
    public class WriteProjectInfo
    {
        public static void Run()
        {
            //ExStart: WriteProjectInfo
            // The path to the documents directory.
            string dataDir = RunExamples.GetDataDir_Projects();
            Project project = new Project(dataDir+ "WriteProjectInfo.mpp");
            project.Set(Prj.Author, "Author");
            project.Set(Prj.LastAuthor, "Last Author");
            project.Set(Prj.Revision, 15);
            project.Set(Prj.Keywords, "MSP Aspose");
            project.Set(Prj.Comments, "Comments");

            project.Save(dataDir+ "saved.mpp", SaveFileFormat.MPP);
            //ExEnd: WriteProjectInfo
        }
    }
}