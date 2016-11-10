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
    class SetConstraintStartNoEarlierThan
    {
        public static void Run()
        {
            // ExStart:SetConstraintStartNoEarlierThan
            // The path to the documents directory.
            string dataDir = RunExamples.GetDataDir(System.Reflection.MethodBase.GetCurrentMethod().DeclaringType); 

            // Create project instance
            Project project = new Project(dataDir + "TestProject.mpp");
            
            // Set constraint Start No Earlier Than on task with Id 1
            Task summary = project.RootTask.Children.GetById(1);
            summary.Set(Tsk.ConstraintType, ConstraintType.StartNoEarlierThan);
            summary.Set(Tsk.ConstraintDate, new DateTime(2016, 12, 1, 9, 0, 0));

            // Save project as pdf
            SaveOptions o = new PdfSaveOptions();
            o.StartDate = project.Get(Prj.StartDate);
            o.Timescale = Timescale.ThirdsOfMonths;
            project.Save(dataDir + "project_StartNoEarlierThan_out.pdf", o);
            // ExEnd:SetConstraintStartNoEarlierThan
        }
    }
}
