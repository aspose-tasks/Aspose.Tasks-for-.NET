namespace Aspose.Tasks.Examples.CSharp
{
    using System.Drawing;
    using NUnit.Framework;
    using Saving;

    public class ExUsageView : ApiExampleBase
    {
        [Test]
        public void RenderTaskUsageViewWithDetails()
        {
            //ExStart:RenderTaskUsageViewWithDetails
            //ExFor: UsageView.DisplayDetailsHeaderColumn
            //ExFor: UsageView.RepeatDetailsHeaderOnAllRows
            //ExFor: UsageView.AlignDetailsData
            //ExSummary: Shows how to render task usage view with details.
            var project = new Project(DataDir + "TaskUsageViewWithDetails.mpp");

            // Get Default view
            UsageView view = (TaskUsageView)project.DefaultView;

            // Details header column will not be displayed
            view.DisplayDetailsHeaderColumn = false;
            view.RepeatDetailsHeaderOnAllRows = false;
            view.AlignDetailsData = StringAlignment.Near;
            project.Save(OutDir + "task usage1_out.pdf", SaveFileFormat.PDF);

            // Display details header column
            view.DisplayDetailsHeaderColumn = true;

            // Repeat details header on all assignments rows
            view.RepeatDetailsHeaderOnAllRows = true;
            view.AlignDetailsData = StringAlignment.Far;
            project.Save(OutDir + "task usage2_out.pdf", SaveFileFormat.PDF);
            //ExEnd:RenderTaskUsageViewWithDetails
        }
    }
}