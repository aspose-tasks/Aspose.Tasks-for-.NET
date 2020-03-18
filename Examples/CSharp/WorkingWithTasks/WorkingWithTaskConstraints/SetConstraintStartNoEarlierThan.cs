/*
This project uses Automatic Package Restore feature of NuGet to resolve Aspose.Tasks for .NET API reference 
when the project is build. Please check https:// Docs.nuget.org/consume/nuget-faq for more information. 
If you do not wish to use NuGet, you can manually download Aspose.Tasks for .NET API from https://www.nuget.org/packages/Aspose.Tasks/, 
install it and then add its reference to this project. For any issues, questions or suggestions 
please feel free to contact us using https://forum.aspose.com/c/tasks
*/

namespace Aspose.Tasks.Examples.CSharp.WorkingWithTasks.WorkingWithTaskConstraints
{
    using System;

    using Aspose.Tasks.Saving;
    using Aspose.Tasks.Visualization;

    internal class SetConstraintStartNoEarlierThan
    {
        public static void Run()
        {
            // The path to the documents directory.
            var dataDir = RunExamples.GetDataDir(System.Reflection.MethodBase.GetCurrentMethod().DeclaringType.FullName);
            
            //ExStart:SetConstraintStartNoEarlierThan
            //ExFor: Tsk.ConstraintType
            //ExFor: ConstraintType.StartNoEarlierThan
            //ExSummary: Shows how to set constraint <see cref="Aspose.Tasks.ConstraintType" /> ConstraintType.StartNoEarlierThan constraint for a task.
            // Create project instance
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
