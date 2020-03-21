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

    internal class CreateResourceAssignments
    {
        public static void Run()
        {
            //ExStart:CreateResourceAssignments
            //ExFor: ResourceAssignmentCollection.Add(Task,Resource)
            //ExFor: Project.ResourceAssignments
            //ExSummary: Shows how to create a resource assignment.
            // Create empty project
            var project = new Project();

            // Add new task and resource
            var task = project.RootTask.Children.Add("Task");
            var resource = project.Resources.Add("Rsc");
            
            // Assign the resource desired task
            project.ResourceAssignments.Add(task, resource);
            //ExEnd:CreateResourceAssignments

            // Save project as PDF
            var dataDir = RunExamples.GetDataDir(System.Reflection.MethodBase.GetCurrentMethod().DeclaringType.FullName);
            project.Save(dataDir + "CreateResourceAssignments_out.pdf", SaveFileFormat.PDF);
        }
    }
}
