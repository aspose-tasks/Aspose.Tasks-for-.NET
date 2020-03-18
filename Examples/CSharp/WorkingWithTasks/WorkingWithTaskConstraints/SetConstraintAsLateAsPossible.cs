/*
This project uses Automatic Package Restore feature of NuGet to resolve Aspose.Tasks for .NET API reference 
when the project is build. Please check https:// Docs.nuget.org/consume/nuget-faq for more information. 
If you do not wish to use NuGet, you can manually download Aspose.Tasks for .NET API from https://www.nuget.org/packages/Aspose.Tasks/, 
install it and then add its reference to this project. For any issues, questions or suggestions 
please feel free to contact us using https://forum.aspose.com/c/tasks
*/

namespace Aspose.Tasks.Examples.CSharp.WorkingWithTasks.WorkingWithTaskConstraints
{
    using Aspose.Tasks.Saving;
    using Aspose.Tasks.Visualization;

    internal class SetConstraintAsLateAsPossible
    {
        public static void Run()
        {
            // The path to the documents directory.
            var dataDir = RunExamples.GetDataDir(System.Reflection.MethodBase.GetCurrentMethod().DeclaringType.FullName);

            // Create project instance
            var project = new Project(dataDir + "ConstraintAsLateAsPossible.mpp");

            //ExStart:SetConstraintAsLateAsPossible
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
    }
}
