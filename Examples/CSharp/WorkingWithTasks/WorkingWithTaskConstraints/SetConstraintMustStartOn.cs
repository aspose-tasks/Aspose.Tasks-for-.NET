using Aspose.Tasks.Saving;
using Aspose.Tasks.Visualization;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

/*
This project uses Automatic Package Restore feature of NuGet to resolve Aspose.Tasks for .NET API reference 
when the project is build. Please check https:// Docs.nuget.org/consume/nuget-faq for more information. 
If you do not wish to use NuGet, you can manually download Aspose.Tasks for .NET API from http://www.aspose.com/downloads, 
install it and then add its reference to this project. For any issues, questions or suggestions 
please feel free to contact us using http://www.aspose.com/community/forums/default.aspx
*/

namespace Aspose.Tasks.Examples.CSharp.WorkingWithTasks.WorkingWithTaskConstraints
{
    class SetConstraintMustStartOn
    {
        public static void Run()
        {
            // ExStart:SetConstraintMustStartOn
            // The path to the documents directory.
            string dataDir = RunExamples.GetDataDir(System.Reflection.MethodBase.GetCurrentMethod().DeclaringType.FullName);

            // Create project instance
            Project project1 = new Project(dataDir + "ConstraintMustStartOn.mpp");

            // Set constraint Must Start On for task with Id 5
            Task roof = project1.RootTask.Children.GetById(5);
            roof.Set(Tsk.ConstraintType, ConstraintType.MustStartOn);
            roof.Set(Tsk.ConstraintDate, new DateTime(2017, 1, 1, 9, 0, 0));

            // TODO: Replace latest 
            //Task.Recalculate(project.RootTask);

            // Save project as pdf
            SaveOptions options = new PdfSaveOptions();
            options.StartDate = project1.Get(Prj.StartDate);
            options.Timescale = Timescale.ThirdsOfMonths;
            project1.Save(dataDir + "project_MustStartOn_out.pdf", options);
            // ExEnd:SetConstraintMustStartOn
        }
    }
}
