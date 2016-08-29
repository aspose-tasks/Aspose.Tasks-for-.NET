using System;
using Aspose.Tasks.Saving;

namespace Aspose.Tasks.Examples.CSharp.HandlingBasicProperties
{
    public class WriteProjectInfo
    {
        public static void Run()
        {
            // ExStart:WriteProjectInfo
            // The path to the documents directory.
            string dataDir = RunExamples.GetDataDir_HandlingBasicProperties();
            try
            {
                Project project = new Project(dataDir + "WriteProjectInfo.mpp");
                project.Set(Prj.Author, "Author");
                project.Set(Prj.LastAuthor, "Last Author");
                project.Set(Prj.Revision, 15);
                project.Set(Prj.Keywords, "MSP Aspose");
                project.Set(Prj.Comments, "Comments");
                project.Save(dataDir + "saved.mpp", SaveFileFormat.MPP);
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message + "\nThis example will only work if you apply a valid Aspose License. You can purchase full license or get 30 day temporary license from http:// Www.aspose.com/purchase/default.aspx.");
            }             
            // ExEnd:WriteProjectInfo
        }
    }
}