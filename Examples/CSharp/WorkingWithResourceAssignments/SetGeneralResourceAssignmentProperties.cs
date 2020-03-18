/*
This project uses Automatic Package Restore feature of NuGet to resolve Aspose.Tasks for .NET API reference 
when the project is build. Please check https:// Docs.nuget.org/consume/nuget-faq for more information. 
If you do not wish to use NuGet, you can manually download Aspose.Tasks for .NET API from https://www.nuget.org/packages/Aspose.Tasks/, 
install it and then add its reference to this project. For any issues, questions or suggestions 
please feel free to contact us using https://forum.aspose.com/c/tasks
*/

namespace Aspose.Tasks.Examples.CSharp.WorkingWithResourceAssignments
{
    using Aspose.Tasks.Saving;

    internal class SetGeneralResourceAssignmentProperties
    {
        public static void Run()
        {
            //ExStart:SetGeneralResourceAssignmentProperties
            // Create empty project
            var project = new Project();

            // Add new task and resource
            var task1 = project.RootTask.Children.Add("Task");
            var rsc1 = project.Resources.Add("Rsc");
            rsc1.Set(Rsc.StandardRate, 10);
            rsc1.Set(Rsc.OvertimeRate, 15);

            // Assign the resource desired task
            project.ResourceAssignments.Add(task1, rsc1);
            //ExEnd:SetGeneralResourceAssignmentProperties

            // Save project as PDF
            var dataDir = RunExamples.GetDataDir(System.Reflection.MethodBase.GetCurrentMethod().DeclaringType.FullName);
            project.Save(dataDir + "SetGeneralResourceAssignmentProperties_out.pdf", SaveFileFormat.PDF);
        }
    }
}
