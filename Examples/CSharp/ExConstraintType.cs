namespace Aspose.Tasks.Examples.CSharp
{
    using NUnit.Framework;
    using Saving;
    using Visualization;

    [TestFixture]
    public class ExConstraintType : ApiExampleBase
    {
        [Test]
        public void ExConstraintType0()
        {
            // ExStart:SetConstraintAsSoonAsPossible
            // ExFor: ConstraintType
            // ExSummary: Shows how to set constraint <see cref="Aspose.Tasks.ConstraintType" /> ConstraintType.AsSoonAsPossible constraint for a task.
            var project = new Project(DataDir + "Constraints/ConstraintAsLateAsPossible.mpp");

            // Set constraint As Soon As Possible for task with Id 11
            var task = project.RootTask.Children.GetById(11);
            task.Set(Tsk.ConstraintType, ConstraintType.AsSoonAsPossible);

            SaveOptions options = new PdfSaveOptions();
            options.StartDate = project.Get(Prj.StartDate);
            options.Timescale = Timescale.ThirdsOfMonths;
            project.Save(OutDir + "AsSoonAsPossible_out.pdf", options);

            // ExEnd:SetConstraintAsSoonAsPossible
        }
    }
}