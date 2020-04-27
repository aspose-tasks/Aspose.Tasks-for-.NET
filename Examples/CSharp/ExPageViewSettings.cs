namespace Aspose.Tasks.Examples.CSharp
{
    using NUnit.Framework;
    using Saving;

    [TestFixture]
    public class ExPageViewSettings : ApiExampleBase
    {
        [Test]
        public void RenderCommentsWhenConverting()
        {
            // ExStart:RenderCommentsWhenConverting
            // ExFor: PageViewSettings.PrintNotes
            // ExSummary: Shows how to print task,resource,assignment notes on a separate page.
            var project = new Project(DataDir + "Input.mpp");
            project.DefaultView.PageInfo.PageViewSettings.PrintNotes = true;
            project.Save(OutDir + "ProjectWithComments_out.pdf", SaveFileFormat.PDF);

            // ExEnd:RenderCommentsWhenConverting
        }
    }
}