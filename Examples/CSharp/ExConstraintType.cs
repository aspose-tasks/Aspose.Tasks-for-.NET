namespace Aspose.Tasks.Examples.CSharp.SavingOptions
{
    using System;
    using NUnit.Framework;
    using Saving;
    using Visualization;

    [TestFixture]
    public class ExConstraintType : ApiExampleBase
    {
        [Test]
        public void ExConstraintTypeM1()
        {
            //ExStart:SetConstraintUndefined
            //ExFor: ConstraintType.Undefined
            //ExSummary: Shows how to set constraint <see cref="Aspose.Tasks.ConstraintType" /> ConstraintType.Undefined constraint for a task.
            var project = new Project(DataDir + "Constraints/ConstraintUndefined.mpp");

            // Set constraint Undefined for task with Id 11
            var task = project.RootTask.Children.GetById(11);
            task.Set(Tsk.ConstraintType, ConstraintType.Undefined);

            SaveOptions options = new PdfSaveOptions();
            options.StartDate = project.Get(Prj.StartDate);
            options.Timescale = Timescale.ThirdsOfMonths;
            project.Save(OutDir + "Undefined_out.pdf", options);
            //ExEnd:SetConstraintUndefined
        }
        
        [Test]
        public void ExConstraintType0()
        {
            //ExStart:SetConstraintAsSoonAsPossible
            //ExFor: ConstraintType.AsSoonAsPossible
            //ExSummary: Shows how to set constraint <see cref="Aspose.Tasks.ConstraintType" /> ConstraintType.AsSoonAsPossible constraint for a task.
            var project = new Project(DataDir + "Constraints/ConstraintAsLateAsPossible.mpp");

            // Set constraint As Soon As Possible for task with Id 11
            var task = project.RootTask.Children.GetById(11);
            task.Set(Tsk.ConstraintType, ConstraintType.AsSoonAsPossible);

            SaveOptions options = new PdfSaveOptions();
            options.StartDate = project.Get(Prj.StartDate);
            options.Timescale = Timescale.ThirdsOfMonths;
            project.Save(OutDir + "AsSoonAsPossible_out.pdf", options);
            //ExEnd:SetConstraintAsSoonAsPossible
        }
        
        [Test]
        public void ExConstraintType1()
        {
            //ExStart:SetConstraintAsLateAsPossible
            //ExFor: ConstraintType
            //ExFor: ConstraintType.AsLateAsPossible
            //ExSummary: Shows how to set constraint <see cref="Aspose.Tasks.ConstraintType" /> ConstraintType.AsLateAsPossible constraint for a task.
            var project = new Project(DataDir + "Constraints/ConstraintAsLateAsPossible.mpp");

            // Set constraint As Late As Possible for task with Id 11
            var task = project.RootTask.Children.GetById(11);
            task.Set(Tsk.ConstraintType, ConstraintType.AsLateAsPossible);

            SaveOptions options = new PdfSaveOptions();
            options.StartDate = project.Get(Prj.StartDate);
            options.Timescale = Timescale.ThirdsOfMonths;
            project.Save(OutDir + "AsLateAsPossible_out.pdf", options);
            //ExEnd:SetConstraintAsLateAsPossible
        }

        [Test]
        public void ExConstraintType2()
        {
            //ExStart:SetConstraintMustStartOn
            //ExFor: ConstraintType.MustStartOn
            //ExSummary: Shows how to set constraint <see cref="Aspose.Tasks.ConstraintType" /> ConstraintType.MustStartOn constraint for a task.
            var project = new Project(DataDir + "Constraints/ConstraintMustStartOn.mpp");

            // Set constraint Must Start On for task with Id 5
            var roof = project.RootTask.Children.GetById(5);
            roof.Set(Tsk.ConstraintType, ConstraintType.MustStartOn);
            roof.Set(Tsk.ConstraintDate, new DateTime(2017, 1, 1, 9, 0, 0));

            SaveOptions options = new PdfSaveOptions();
            options.StartDate = project.Get(Prj.StartDate);
            options.Timescale = Timescale.ThirdsOfMonths;
            project.Save(OutDir + "MustStartOn_out.pdf", options);
            //ExEnd:SetConstraintMustStartOn
        }

        [Test]
        public void ExConstraintType3()
        {
            //ExStart:SetConstraintMustFinishOn
            //ExFor: ConstraintType.MustFinishOn
            //ExSummary: Shows how to set constraint <see cref="Aspose.Tasks.ConstraintType" /> ConstraintType.MustFinishOn constraint for a task.
            var project = new Project(DataDir + "Constraints/ConstraintMustFinishOn.mpp");

            // Set constraint Must Finish On for task with Id 15
            var interiorFixtures = project.RootTask.Children.GetById(15);
            interiorFixtures.Set(Tsk.ConstraintType, ConstraintType.MustFinishOn);
            interiorFixtures.Set(Tsk.ConstraintDate, new DateTime(2017, 3, 1, 18, 0, 0));

            SaveOptions options = new PdfSaveOptions();
            options.StartDate = project.Get(Prj.StartDate);
            options.Timescale = Timescale.ThirdsOfMonths;
            project.Save(OutDir + "MustFinishOn_out.pdf", options);
            //ExEnd:SetConstraintMustFinishOn
        }

        [Test]
        public void ExConstraintType4()
        {
            //ExStart:SetConstraintStartNoEarlierThan
            //ExFor: ConstraintType.StartNoEarlierThan
            //ExSummary: Shows how to set constraint <see cref="Aspose.Tasks.ConstraintType" /> ConstraintType.StartNoEarlierThan constraint for a task.
            var project = new Project(DataDir + "Constraints/ConstraintStartNoEarlierThan.mpp");

            // Set constraint Start No Earlier Than on task with Id 1
            var summary = project.RootTask.Children.GetById(1);
            summary.Set(Tsk.ConstraintType, ConstraintType.StartNoEarlierThan);
            summary.Set(Tsk.ConstraintDate, new DateTime(2016, 12, 1, 9, 0, 0));

            SaveOptions options = new PdfSaveOptions();
            options.StartDate = project.Get(Prj.StartDate);
            options.Timescale = Timescale.ThirdsOfMonths;
            project.Save(OutDir + "StartNoEarlierThan_out.pdf", options);
            //ExEnd:SetConstraintStartNoEarlierThan
        }
        
        [Test]
        public void ExConstraintType5()
        {
            //ExStart:SetConstraintStartNoLaterThan
            //ExFor: ConstraintType.StartNoLaterThan
            //ExSummary: Shows how to set constraint <see cref="Aspose.Tasks.ConstraintType" /> ConstraintType.StartNoLaterThan constraint for a task.
            var project = new Project(DataDir + "Constraints/ConstraintStartNoLaterThan.mpp");

            // Set constraint Start No Later Than on task with Id 1
            var summary = project.RootTask.Children.GetById(1);
            summary.Set(Tsk.ConstraintType, ConstraintType.StartNoLaterThan);
            summary.Set(Tsk.ConstraintDate, new DateTime(2016, 12, 1, 9, 0, 0));

            SaveOptions options = new PdfSaveOptions();
            options.StartDate = project.Get(Prj.StartDate);
            options.Timescale = Timescale.ThirdsOfMonths;
            project.Save(OutDir + "StartNoLaterThan_out.pdf", options);
            //ExEnd:SetConstraintStartNoLaterThan
        }

        [Test]
        public void ExConstraintType6()
        {
            //ExStart:SetConstraintFinishNoEarlierThan
            //ExFor: ConstraintType.FinishNoEarlierThan
            //ExSummary: Shows how to set constraint <see cref="Aspose.Tasks.ConstraintType" /> ConstraintType.FinishNoEarlierThan constraint for a task.
            var project = new Project(DataDir + "Constraints/ConstraintFinishNoEarlierThan.mpp");

            // Set constraint Finish No Earlier Than on task with Id 2
            var first = project.RootTask.Children.GetById(2);
            first.Set(Tsk.ConstraintType, ConstraintType.FinishNoEarlierThan);
            first.Set(Tsk.ConstraintDate, new DateTime(2016, 12, 1, 18, 0, 0));

            SaveOptions options = new PdfSaveOptions();
            options.StartDate = project.Get(Prj.StartDate);
            options.Timescale = Timescale.ThirdsOfMonths;
            project.Save(OutDir + "FinishNoEarlierThan_out.pdf", options);
            //ExEnd:SetConstraintFinishNoEarlierThan
        }
        
        [Test]
        public void ExConstraintType7()
        {
            //ExStart:SetConstraintFinishNoLaterThan
            //ExFor: ConstraintType.FinishNoLaterThan
            //ExSummary: Shows how to set constraint <see cref="Aspose.Tasks.ConstraintType" /> ConstraintType.FinishNoLaterThan constraint for a task.
            var project = new Project(DataDir + "Constraints/ConstraintFinishNoLaterThan.mpp");

            // Set constraint Finish No Earlier Than on task with Id 2
            var first = project.RootTask.Children.GetById(2);
            first.Set(Tsk.ConstraintType, ConstraintType.FinishNoLaterThan);
            first.Set(Tsk.ConstraintDate, new DateTime(2016, 12, 1, 18, 0, 0));

            SaveOptions options = new PdfSaveOptions();
            options.StartDate = project.Get(Prj.StartDate);
            options.Timescale = Timescale.ThirdsOfMonths;
            project.Save(OutDir + "FinishNoLaterThan_out.pdf", options);
            //ExEnd:SetConstraintFinishNoLaterThan
        }
    }
}