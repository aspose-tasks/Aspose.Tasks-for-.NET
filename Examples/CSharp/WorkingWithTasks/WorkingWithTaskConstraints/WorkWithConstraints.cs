namespace Aspose.Tasks.Examples.CSharp.WorkingWithTasks.WorkingWithTaskConstraints
{
    using System;
    using Saving;
    using Visualization;

    internal class WorkWithConstraints
    {
        public static void Run()
        {
            var dataDir = RunExamples.GetDataDir(System.Reflection.MethodBase.GetCurrentMethod());
            
            {
                //ExStart:SetConstraintAsLateAsPossible
                //ExFor: ConstraintType
                //ExFor: Tsk.ConstraintType
                //ExFor: Tsk.ConstraintDate
                //ExSummary: Shows how to set constraint <see cref="Aspose.Tasks.ConstraintType" /> ConstraintType.AsLateAsPossible constraint for a task.
                var project = new Project(dataDir + "ConstraintAsLateAsPossible.mpp");
                
                // Set constraint As Late As Possible for task with Id 11
                var wallBoard = project.RootTask.Children.GetById(11);
                wallBoard.Set(Tsk.ConstraintType, ConstraintType.AsLateAsPossible);            
                        
                // Save project as pdf
                SaveOptions options = new PdfSaveOptions();
                options.StartDate = project.Get(Prj.StartDate);
                options.Timescale = Timescale.ThirdsOfMonths;
                project.Save(dataDir + "project_AsLateAsPossible_out.pdf", options);
                //ExEnd:SetConstraintAsLateAsPossible
            }

            {
                //ExStart:SetConstraintFinishNoEarlierThan
                //ExFor: ConstraintType
                //ExSummary: Shows how to set constraint <see cref="Aspose.Tasks.ConstraintType" /> ConstraintType.FinishNoEarlierThan constraint for a task.
                var project = new Project(dataDir + "ConstraintFinishNoEarlierThan.mpp");
    
                // Set constraint Finish No Earlier Than on task with Id 2
                var first = project.RootTask.Children.GetById(2);
                first.Set(Tsk.ConstraintType, ConstraintType.FinishNoEarlierThan);
                first.Set(Tsk.ConstraintDate, new DateTime(2016, 12, 1, 18, 0, 0));
                        
                // Save project as pdf
                SaveOptions options = new PdfSaveOptions();
                options.StartDate = project.Get(Prj.StartDate);
                options.Timescale = Timescale.ThirdsOfMonths;
                project.Save(dataDir + "project_FinishNoEarlierThan_out.pdf", options);
                //ExEnd:SetConstraintFinishNoEarlierThan
            }

            {
                //ExStart:SetConstraintMustFinishOn
                //ExFor: ConstraintType
                //ExSummary: Shows how to set constraint <see cref="Aspose.Tasks.ConstraintType" /> ConstraintType.MustFinishOn constraint for a task.
                var project = new Project(dataDir + "ConstraintMustFinishOn.mpp");
                
                // Set constraint Must Finish On for task with Id 15
                var interiorFixtures = project.RootTask.Children.GetById(15);
                interiorFixtures.Set(Tsk.ConstraintType, ConstraintType.MustFinishOn);
                interiorFixtures.Set(Tsk.ConstraintDate, new DateTime(2017, 3, 1, 18, 0, 0));
                        
                // Save project as pdf
                SaveOptions options = new PdfSaveOptions();
                options.StartDate = project.Get(Prj.StartDate);
                options.Timescale = Timescale.ThirdsOfMonths;
                project.Save(dataDir + "project_MustFinishOn_out.pdf", options);
                //ExEnd:SetConstraintMustFinishOn
            }

            {
                //ExStart:SetConstraintMustStartOn
                //ExFor: ConstraintType
                //ExSummary: Shows how to set constraint <see cref="Aspose.Tasks.ConstraintType" /> ConstraintType.MustStartOn constraint for a task.
                var project = new Project(dataDir + "ConstraintMustStartOn.mpp");
            
                // Set constraint Must Start On for task with Id 5
                var roof = project.RootTask.Children.GetById(5);
                roof.Set(Tsk.ConstraintType, ConstraintType.MustStartOn);
                roof.Set(Tsk.ConstraintDate, new DateTime(2017, 1, 1, 9, 0, 0));
                        
                // Save project as pdf
                SaveOptions options = new PdfSaveOptions();
                options.StartDate = project.Get(Prj.StartDate);
                options.Timescale = Timescale.ThirdsOfMonths;
                project.Save(dataDir + "project_MustStartOn_out.pdf", options);
                //ExEnd:SetConstraintMustStartOn
            }
            
            {
                //ExStart:SetConstraintStartNoEarlierThan
                //ExFor: ConstraintType
                //ExSummary: Shows how to set constraint <see cref="Aspose.Tasks.ConstraintType" /> ConstraintType.StartNoEarlierThan constraint for a task.
                var project = new Project(dataDir + "ConstraintStartNoEarlierThan.mpp");
            
                // Set constraint Start No Earlier Than on task with Id 1
                var summary = project.RootTask.Children.GetById(1);
                summary.Set(Tsk.ConstraintType, ConstraintType.StartNoEarlierThan);
                summary.Set(Tsk.ConstraintDate, new DateTime(2016, 12, 1, 9, 0, 0));

                // Save project as pdf
                SaveOptions options = new PdfSaveOptions();
                options.StartDate = project.Get(Prj.StartDate);
                options.Timescale = Timescale.ThirdsOfMonths;
                project.Save(dataDir + "project_StartNoEarlierThan_out.pdf", options);
                //ExEnd:SetConstraintStartNoEarlierThan
            }
        }
    }
}