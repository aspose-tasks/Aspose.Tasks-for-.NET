namespace Aspose.Tasks.Examples.CSharp.ConvertingProjectData
{
    using Saving;

    internal class RenderCommentsWhenConverting
    {
        public static void Run()
        {
            var dataDir = RunExamples.GetDataDir(System.Reflection.MethodBase.GetCurrentMethod());

            //ExStart:RenderCommentsWhenConverting
            //ExFor: PageViewSettings.PrintNotes
            //ExSummary: Shows how to print task,resource,assignment notes on a separate page.
            var project = new Project(dataDir + "Input.mpp");
            project.DefaultView.PageInfo.PageViewSettings.PrintNotes = true;
            project.Save(dataDir + "ProjectWithComments_out.pdf", SaveFileFormat.PDF);
            //ExEnd:RenderCommentsWhenConverting
        }
    }
}
