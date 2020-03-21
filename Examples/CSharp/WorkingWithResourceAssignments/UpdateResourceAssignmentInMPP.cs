/*
This project uses Automatic Package Restore feature of NuGet to resolve Aspose.Tasks for .NET API reference 
when the project is build. Please check https:// Docs.nuget.org/consume/nuget-faq for more information. 
If you do not wish to use NuGet, you can manually download Aspose.Tasks for .NET API from https://www.nuget.org/packages/Aspose.Tasks/, 
install it and then add its reference to this project. For any issues, questions or suggestions 
please feel free to contact us using https://forum.aspose.com/c/tasks
*/

namespace Aspose.Tasks.Examples.CSharp.WorkingWithResourceAssignments
{
    using System;

    using Aspose.Tasks.Saving;

    internal class UpdateResourceAssignmentInMPP
    {
        public static void Run()
        {
            try
            {
                // The path to the documents directory.
                var dataDir = RunExamples.GetDataDir(System.Reflection.MethodBase.GetCurrentMethod().DeclaringType.FullName);

                //ExStart:UpdateResourceAssignmentInMPP
                //ExFor: ResourceAssignmentCollection.Add(Task,Resource)
                //ExSummary: Shows how to add/update resource assignments in MPP file.
                // Create project instance and access first task and resource
                var project = new Project(dataDir + "UpdateResourceAssignment.mpp");
                var task = project.RootTask.Children.GetById(1);
                var rsc = project.Resources.GetById(1);

                // Create resource assignment
                var assn = project.ResourceAssignments.Add(task, rsc);
                assn.Set(Asn.Notes, "Newly added assignment");

                // Save project as MPP
                project.Save(dataDir + "UpdateResourceAssignment_out.mpp", SaveFileFormat.MPP);
                //ExEnd:UpdateResourceAssignmentInMPP
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message + "\nThis example will only work if you apply a valid Aspose License. You can purchase full license or get 30 day temporary license from http://www.aspose.com/purchase/default.aspx.");
            }
        }
    }
}
