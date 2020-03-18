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

    internal class SetConstraintMustStartOn
    {
        public static void Run()
        {
            // The path to the documents directory.
            var dataDir = RunExamples.GetDataDir(System.Reflection.MethodBase.GetCurrentMethod().DeclaringType.FullName);

            //ExStart:SetConstraintMustStartOn
            //ExFor: ConstraintType.MustStartOn
            //ExFor: Tsk.ConstraintType
            //ExFor: Tsk.ConstraintDate
            //ExSummary: Shows how to set constraint <see cref="Aspose.Tasks.ConstraintType" /> ConstraintType.MustStartOn constraint for a task.
            // Create project instance
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
    }
}
