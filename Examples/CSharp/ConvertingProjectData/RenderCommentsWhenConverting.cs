namespace Aspose.Tasks.Examples.CSharp.ConvertingProjectData
{
    using Saving;

    public class RenderCommentsWhenConverting
    {
        public static void Run()
        {
            // The path to the documents directory.
            var dataDir = RunExamples.GetDataDir(System.Reflection.MethodBase.GetCurrentMethod().DeclaringType.FullName);

            //ExStart:RenderCommentsWhenConverting
            //ExFor: PageViewSettings.PrintNotes
            //ExSummary: Shows how to print task,resource,assignment notes on a separate page.
            var project = new Project(dataDir + "Input.mpp");
            project.DefaultView.PageInfo.PageViewSettings.PrintNotes = true;
            project.Save(dataDir + "ProjectWithComments.pdf", SaveFileFormat.PDF);
            //ExEnd:RenderCommentsWhenConverting
        }
    }
}
