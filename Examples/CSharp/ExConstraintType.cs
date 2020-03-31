namespace Aspose.Tasks.Examples.CSharp
{
    using System;
    using NUnit.Framework;
    using Saving;
    using Visualization;

    [TestFixture]
    public class ExConstraintType : ApiExampleBase
    {
        [Test]
        public void ExConstraintType0()
        {
            //ExStart:SetConstraintAsLateAsPossible
            //ExFor: ConstraintType
            //ExSummary: Shows how to set constraint <see cref="Aspose.Tasks.ConstraintType" /> ConstraintType.AsLateAsPossible constraint for a task.
            var project = new Project(DataDir + "ConstraintAsLateAsPossible.mpp");

            // Set constraint As Late As Possible for task with Id 11
            var wallBoard = project.RootTask.Children.GetById(11);
            wallBoard.Set(Tsk.ConstraintType, ConstraintType.AsLateAsPossible);

            SaveOptions options = new PdfSaveOptions();
            options.StartDate = project.Get(Prj.StartDate);
            options.Timescale = Timescale.ThirdsOfMonths;
            project.Save(OutDir + "project_AsLateAsPossible_out.pdf", options);
            //ExEnd:SetConstraintAsLateAsPossible
        }

        [Test]
        public void ExConstraintType1()
        {
            //ExStart:SetConstraintFinishNoEarlierThan
            //ExFor: ConstraintType
            //ExSummary: Shows how to set constraint <see cref="Aspose.Tasks.ConstraintType" /> ConstraintType.FinishNoEarlierThan constraint for a task.
            var project = new Project(DataDir + "ConstraintFinishNoEarlierThan.mpp");

            // Set constraint Finish No Earlier Than on task with Id 2
            var first = project.RootTask.Children.GetById(2);
            first.Set(Tsk.ConstraintType, ConstraintType.FinishNoEarlierThan);
            first.Set(Tsk.ConstraintDate, new DateTime(2016, 12, 1, 18, 0, 0));

            SaveOptions options = new PdfSaveOptions();
            options.StartDate = project.Get(Prj.StartDate);
            options.Timescale = Timescale.ThirdsOfMonths;
            project.Save(OutDir + "project_FinishNoEarlierThan_out.pdf", options);
            //ExEnd:SetConstraintFinishNoEarlierThan
        }

        [Test]
        public void ExConstraintType2()
        {
            //ExStart:SetConstraintMustFinishOn
            //ExFor: ConstraintType
            //ExSummary: Shows how to set constraint <see cref="Aspose.Tasks.ConstraintType" /> ConstraintType.MustFinishOn constraint for a task.
            var project = new Project(DataDir + "ConstraintMustFinishOn.mpp");

            // Set constraint Must Finish On for task with Id 15
            var interiorFixtures = project.RootTask.Children.GetById(15);
            interiorFixtures.Set(Tsk.ConstraintType, ConstraintType.MustFinishOn);
            interiorFixtures.Set(Tsk.ConstraintDate, new DateTime(2017, 3, 1, 18, 0, 0));

            SaveOptions options = new PdfSaveOptions();
            options.StartDate = project.Get(Prj.StartDate);
            options.Timescale = Timescale.ThirdsOfMonths;
            project.Save(OutDir + "project_MustFinishOn_out.pdf", options);
            //ExEnd:SetConstraintMustFinishOn
        }

        [Test]
        public void ExConstraintType3()
        {
            //ExStart:SetConstraintMustStartOn
            //ExFor: ConstraintType
            //ExSummary: Shows how to set constraint <see cref="Aspose.Tasks.ConstraintType" /> ConstraintType.MustStartOn constraint for a task.
            var project = new Project(DataDir + "ConstraintMustStartOn.mpp");

            // Set constraint Must Start On for task with Id 5
            var roof = project.RootTask.Children.GetById(5);
            roof.Set(Tsk.ConstraintType, ConstraintType.MustStartOn);
            roof.Set(Tsk.ConstraintDate, new DateTime(2017, 1, 1, 9, 0, 0));

            SaveOptions options = new PdfSaveOptions();
            options.StartDate = project.Get(Prj.StartDate);
            options.Timescale = Timescale.ThirdsOfMonths;
            project.Save(OutDir + "project_MustStartOn_out.pdf", options);
            //ExEnd:SetConstraintMustStartOn
        }

        [Test]
        public void ExConstraintType4()
        {
            //ExStart:SetConstraintStartNoEarlierThan
            //ExFor: ConstraintType
            //ExSummary: Shows how to set constraint <see cref="Aspose.Tasks.ConstraintType" /> ConstraintType.StartNoEarlierThan constraint for a task.
            var project = new Project(DataDir + "ConstraintStartNoEarlierThan.mpp");

            // Set constraint Start No Earlier Than on task with Id 1
            var summary = project.RootTask.Children.GetById(1);
            summary.Set(Tsk.ConstraintType, ConstraintType.StartNoEarlierThan);
            summary.Set(Tsk.ConstraintDate, new DateTime(2016, 12, 1, 9, 0, 0));

            SaveOptions options = new PdfSaveOptions();
            options.StartDate = project.Get(Prj.StartDate);
            options.Timescale = Timescale.ThirdsOfMonths;
            project.Save(OutDir + "project_StartNoEarlierThan_out.pdf", options);
            //ExEnd:SetConstraintStartNoEarlierThan
        }
    }
}